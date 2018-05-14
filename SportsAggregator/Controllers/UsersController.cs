using SportsAggregator.Models.DataModels;
using SportsAggregator.Models.Users;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsAggregator.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Home()
        {
            try
            {
                if (Session["UserName"] != null)
                {
                    var dataContext = new DataContext();
                    var nlist = dataContext.NOTIFICATIONS.OrderByDescending(x => x.ID).ToList();
                    ViewData["Notifications"] = "";
                    foreach (var item in nlist)
                    {
                        TimeZoneInfo ACT = TimeZoneInfo.FindSystemTimeZoneById("US Eastern Standard Time");
                        DateTime Time = TimeZoneInfo.ConvertTime(Convert.ToDateTime(item.CREATED_DT.ToString()), ACT, TimeZoneInfo.Local);
                        ViewData["Notifications"] += Time + " - " + item.NOTIFICATION1 + "\n";
                    }

                    ViewData["articles"] = dataContext.USER_ARTICLES.Where(x => x.VALID_FLAG == "Y").OrderByDescending(x => x.VALIDATED_DT).ToList();

                    return View();
                }
                else
                {
                    Session["Login"] = "Please Login to the website to access that page.";
                    return RedirectToAction("Login", "Account", FormMethod.Get);
                }
            }
            catch(Exception)
            {
                return RedirectToAction("Error", "Error");
            }
        }

        [HttpGet]
        public ActionResult Posts()
        {
            try
            {
                if (Session["UserName"] != null)
                {
                    var dataContext = new DataContext();

                    string name = Session["UserName"].ToString();
                    var user = dataContext.LOGIN_PROFILE.Where(x => x.USERNAME.ToUpper() == name.ToUpper()).FirstOrDefault();
                    ViewData["Sports"] = dataContext.USERS_SPORTS.Where(x => x.USER.ID == user.USERID).Select(x => new { ID = x.SPORT.ID, NAME = x.SPORT.NAME }).ToList();

                    return View();
                }
                else
                {
                    Session["Login"] = "Please Login to the website to access that page.";
                    return RedirectToAction("Login", "Account", FormMethod.Get);
                }
            }
            catch(Exception)
            {
                return RedirectToAction("Error", "Error");
            }
        }

        [HttpPost]
        public ActionResult Posts(PostsModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                else
                {
                    var dataContext = new DataContext();

                    var name = Session["Username"].ToString();
                    USER_ARTICLES ua = new USER_ARTICLES
                    {
                        SPORT_ID = model.SPORT,
                        TITLE = model.TITLE,
                        DESCRIPTION1 = model.Description,
                        POSTED_BY = dataContext.LOGIN_PROFILE.Where(x => x.USERNAME.ToUpper() == name.ToUpper()).Select(x => x.USERID).FirstOrDefault(),
                        POSTED_DT = DateTime.Now,
                        VALID_FLAG = "N"
                    };

                    dataContext.Entry(ua).State = System.Data.Entity.EntityState.Added;
                    dataContext.SaveChanges();

                    var articleId = ua.ID;

                    string[] filesContext = System.Web.HttpContext.Current.Request.Files.AllKeys;
                    string dataBaseimgPath = "";
                    string dataBaseDocPath = "";
                    for (int i = 0; i < filesContext.Length; i++)
                    {
                        var thisfile = System.Web.HttpContext.Current.Request.Files[i];

                        if (Path.GetExtension(thisfile.FileName) != "")
                        {
                            var fileSavePath = "";
                            string fileExtension = Path.GetExtension(thisfile.FileName);

                            if (i == 0)
                            {
                                if (fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".jpeg" || fileExtension.ToLower() == ".png")
                                {
                                    string dataBaseFilePath = "/Docs/" + articleId + "_Image" + fileExtension;
                                    dataBaseimgPath = dataBaseFilePath;
                                    fileSavePath = Path.Combine(System.Web.HttpContext.Current.Server.MapPath("~/Docs/"), articleId + "_Image" + fileExtension);
                                    thisfile.SaveAs(fileSavePath);
                                    ua.IMAGE1 = dataBaseimgPath;
                                    dataContext.Entry(ua).State = System.Data.Entity.EntityState.Modified;
                                    dataContext.SaveChanges();
                                }
                                else
                                {
                                    ModelState.AddModelError("ImageError", "Only jpg/jpeg/png files are allowed.");
                                    string name1 = Session["UserName"].ToString();
                                    var user = dataContext.LOGIN_PROFILE.Where(x => x.USERNAME.ToUpper() == name1.ToUpper()).FirstOrDefault();
                                    ViewData["Sports"] = dataContext.USERS_SPORTS.Where(x => x.USER.ID == user.USERID).Select(x => new { ID = x.SPORT.ID, NAME = x.SPORT.NAME }).ToList();
                                    return View(model);
                                }
                            }
                            else
                            {
                                if (fileExtension.ToLower() == ".pdf" || fileExtension.ToLower() == ".txt" || fileExtension.ToLower() == ".pdf")
                                {
                                    string dataBaseFilePath = "/Docs/" + articleId + "_Document" + fileExtension;
                                    dataBaseDocPath = dataBaseFilePath;
                                    fileSavePath = Path.Combine(System.Web.HttpContext.Current.Server.MapPath("~/Docs/"), articleId + "_Document" + fileExtension);
                                    thisfile.SaveAs(fileSavePath);
                                    ua.DOCUMENT1 = dataBaseDocPath;

                                    dataContext.Entry(ua).State = System.Data.Entity.EntityState.Modified;
                                    dataContext.SaveChanges();
                                }
                                else
                                {
                                    ModelState.AddModelError("fileError", "Only pdf/txt/doc files are allowed.");
                                    string name1 = Session["UserName"].ToString();
                                    var user = dataContext.LOGIN_PROFILE.Where(x => x.USERNAME.ToUpper() == name1.ToUpper()).FirstOrDefault();
                                    ViewData["Sports"] = dataContext.USERS_SPORTS.Where(x => x.USER.ID == user.USERID).Select(x => new { ID = x.SPORT.ID, NAME = x.SPORT.NAME }).ToList();
                                    return View(model);
                                }
                            }
                        }
                    }

                    Session["Output"] = "Your Article has been posted successfully. It will be validated by our agents and displayed in the website.";

                    return RedirectToAction("Posts", "Users", FormMethod.Get);
                }
            }
            catch(Exception)
            {
                return RedirectToAction("Error","Error");
            }
        }

        [HttpGet]
        public ActionResult Players()
        {
            try
            {
                if (Session["UserName"] != null)
                {
                    return View();
                }
                else
                {
                    Session["Login"] = "Please Login to the website to access that page.";
                    return RedirectToAction("Login", "Account", FormMethod.Get);
                }
            }
            catch(Exception)
            {
                return RedirectToAction("Error", "Error");
            }
        }

        [HttpGet]
        public ActionResult Tournaments()
        {
            try
            {
                if (Session["UserName"] != null)
                {
                    return View();
                }
                else
                {
                    Session["Login"] = "Please Login to the website to access that page.";
                    return RedirectToAction("Login", "Account", FormMethod.Get);
                }
            }
            catch(Exception)
            {
                return RedirectToAction("Error", "Error");
            }
        }

        [HttpGet]
        public ActionResult Tickets()
        {
            try
            {
                if (Session["UserName"] != null)
                {
                    return View();
                }
                else
                {
                    Session["Login"] = "Please Login to the website to access that page.";
                    return RedirectToAction("Login", "Account", FormMethod.Get);
                }
            }
            catch(Exception)
            {
                return RedirectToAction("Error", "Error");
            }
        }
    }
}