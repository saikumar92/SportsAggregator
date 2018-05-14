using SportsAggregator.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsAggregator.Controllers
{
    public class AgentsController : Controller
    {
        // GET: Agents
        public ActionResult Home()
        {
            try
            {
                if (Session["UserName"] != null)
                {
                    var dataContext = new DataContext();

                    ViewData["Count"] = dataContext.USER_ARTICLES.Where(x => x.VALID_FLAG == "N").Count();
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
        public ActionResult ValidatePosts()
        {
            try
            {
                if (Session["UserName"] != null)
                {
                    var dataContext = new DataContext();

                    ViewData["Count"] = dataContext.USER_ARTICLES.Where(x => x.VALID_FLAG == "N").Count();
                    ViewData["articles"] = dataContext.USER_ARTICLES.Where(x => x.VALID_FLAG == "N").OrderBy(x => x.VALIDATED_DT).ToList();
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

        public ActionResult UpdatePost(int id)
        {
            try
            {
                var dataContext = new DataContext();
                var ua = dataContext.USER_ARTICLES.Where(x => x.ID == id).FirstOrDefault();
                var name = Session["UserName"].ToString();

                ua.VALID_FLAG = "Y";
                ua.VALIDATED_BY = dataContext.LOGIN_PROFILE.Where(x => x.USERNAME.ToUpper() == name.ToUpper()).Select(x => x.USERID).FirstOrDefault();
                ua.VALIDATED_DT = DateTime.Now;

                dataContext.Entry(ua).State = System.Data.Entity.EntityState.Modified;
                dataContext.SaveChanges();

                Session["UpdatePosts"] = "Article has been published successfully to all the users.";

                return RedirectToAction("ValidatePosts", "Agents", FormMethod.Get);
            }
            catch(Exception)
            {
                return RedirectToAction("Error", "Error");
            }
        }

        public ActionResult DeletePost(int id)
        {
            try
            {
                var dataContext = new DataContext();
                var ua = dataContext.USER_ARTICLES.Where(x => x.ID == id).FirstOrDefault();
                var name = Session["UserName"].ToString();

                dataContext.USER_ARTICLES.Remove(ua);
                dataContext.SaveChanges();

                Session["UpdatePosts"] = "Article has been deleted successfully from the database.";

                return RedirectToAction("ValidatePosts", "Agents", FormMethod.Get);
            }
            catch(Exception)
            {
                return RedirectToAction("Error", "Error");
            }
        }

        public ActionResult Players()
        {
            try
            {
                if (Session["UserName"] != null)
                {
                    var dataContext = new DataContext();

                    ViewData["Count"] = dataContext.USER_ARTICLES.Where(x => x.VALID_FLAG == "N").Count();
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

        public ActionResult Tournaments()
        {
            try
            {
                if (Session["UserName"] != null)
                {
                    var dataContext = new DataContext();

                    ViewData["Count"] = dataContext.USER_ARTICLES.Where(x => x.VALID_FLAG == "N").Count();
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

        public ActionResult Tickets()
        {
            try
            {
                if (Session["UserName"] != null)
                {
                    var dataContext = new DataContext();

                    ViewData["Count"] = dataContext.USER_ARTICLES.Where(x => x.VALID_FLAG == "N").Count();
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

        public ActionResult AddPosts()
        {
            try
            {
                if (Session["UserName"] != null)
                {
                    var dataContext = new DataContext();

                    ViewData["Count"] = dataContext.USER_ARTICLES.Where(x => x.VALID_FLAG == "N").Count();
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