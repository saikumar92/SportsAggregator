using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using SportsAggregator.Models.Account;
using SportsAggregator.Models.DataModels;

namespace SportsAggregator.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            try
            {
                var model = new LoginModel();
                Session["UserName"] = null;
                return View(model);
            }
            catch(Exception)
            {
                return RedirectToAction("Error", "Error");
            }
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                var dataContext = new DataContext();
                var user = dataContext.LOGIN_PROFILE.Where(x => x.USERNAME.ToUpper() == model.USERNAME.ToUpper()).FirstOrDefault();

                if (user == null)
                {
                    ModelState.AddModelError("UserName", "UserName has not been registered.");
                    return View(model);
                }
                else
                {
                    if (user.PASSWORD == model.PASSWORD)
                    {
                        user.NO_OF_LOGINS++;
                        user.LASTLOGINDATE = DateTime.Now;
                        user.LOGINSTATUS = "LoggedIn Successfully";
                        dataContext.SaveChanges();

                        Session["RoleId"] = user.ROLE_ID;
                        Session["UserName"] = model.USERNAME;

                        if (user.ROLE_ID == 3)
                        {
                            return RedirectToAction("Home", "Users");
                        }

                        else if (user.ROLE_ID == 2)
                        {
                            return RedirectToAction("Home", "Agents");
                        }
                    }

                    else
                    {
                        ModelState.AddModelError("Password", "Password is incorrect");
                        return View(model);
                    }
                    return View(this);
                }
            }
            catch(Exception)
            {
                return RedirectToAction("Error", "Error");
            }
        }

        [HttpGet]
        public ActionResult Register()
        {
            try
            {
                var dataContext = new DataContext();

                ViewData["Countries"] = dataContext.COUNTRIES.OrderBy(x => x.COUNTRY1).ToList();
                ViewData["Sports"] = dataContext.SPORTS.OrderBy(x => x.NAME).ToList();
                var model = new RegisterModel();
                Session["UserName"] = null;
                return View(model);
            }
            catch(Exception)
            {
                return RedirectToAction("Error", "Error");
            }
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                var dataContext = new DataContext();

                int count = dataContext.LOGIN_PROFILE.Where(x => x.USERNAME.ToUpper() == model.LOGIN_PROFILES.USERNAME.ToUpper()).Count();

                if (count > 0)
                {
                    ModelState.AddModelError("UserName", "UserName already exists, please try to give another username.");
                    ViewData["Countries"] = dataContext.COUNTRIES.OrderBy(x => x.COUNTRY1).ToList();
                    ViewData["Sports"] = dataContext.SPORTS.OrderBy(x => x.NAME).ToList();
                    return View(model);
                }
                else
                {
                    USER user = new USER
                    {
                        FIRST_NAME = model.USERS.FIRST_NAME,
                        MIDDLE_NAME = model.USERS.MIDDLE_NAME,
                        LAST_NAME = model.USERS.LAST_NAME,
                        ADDRESS_LINE_1 = model.USERS.ADDRESS_LINE_1,
                        ADDRESS_LINE_2 = model.USERS.ADDRESS_LINE_2,
                        CITY = model.USERS.CITY,
                        STATE = model.USERS.STATE,
                        COUNTRY = int.Parse(model.COUNTRY),
                        ZIPCODE = model.USERS.ZIPCODE,
                        EMAIL_ID = model.USERS.EMAIL_ID,
                        CREATED_DT = DateTime.Now
                    };

                    dataContext.Entry(user).State = System.Data.Entity.EntityState.Added;
                    dataContext.SaveChanges();

                    int user_id = dataContext.USERS.Max(x => x.ID);

                    LOGIN_PROFILE lp = new LOGIN_PROFILE
                    {
                        USERNAME = model.LOGIN_PROFILES.USERNAME,
                        PASSWORD = model.LOGIN_PROFILES.PASSWORD,
                        USERID = user_id,
                        ROLE_ID = 3,
                        LOGINSTATUS = "Registered Now",
                        LASTLOGINDATE = DateTime.Now,
                        NO_OF_LOGINS = 0
                    };

                    dataContext.Entry(lp).State = System.Data.Entity.EntityState.Added;
                    dataContext.SaveChanges();

                    foreach (var item in model.SPORTS)
                    {
                        USERS_SPORTS us = new USERS_SPORTS
                        {
                            USER_ID = user_id,
                            SPORT_ID = int.Parse(item),
                            CREATED_DT = DateTime.Now
                        };

                        dataContext.Entry(us).State = System.Data.Entity.EntityState.Added;
                        dataContext.SaveChanges();
                    }

                    return RedirectToAction("Login", "Account", FormMethod.Get);
                }
            }
            catch(Exception)
            {
                return RedirectToAction("Error", "Error");
            }
        }

        [HttpPost]
        public ActionResult Logout()
        {
            try
            {
                if (Session["UserName"] != null)
                {
                    string name = Session["UserName"].ToString();
                    var dataContext = new DataContext();
                    var user = dataContext.LOGIN_PROFILE.Where(x => x.USERNAME.ToUpper() == name.ToUpper()).FirstOrDefault();
                    user.LOGINSTATUS = "Loggedout Successfully";
                    dataContext.SaveChanges();

                    Session["UserName"] = null;
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    Session["Login"] = "Session has been killed, so please login to continue.";
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