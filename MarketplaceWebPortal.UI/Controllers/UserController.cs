using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketplaceWebPortal.Core.POCOClasses;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace MarketplaceWebPortal.UI.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserUI userUI, HttpPostedFileBase file)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MarketplaceWebPortalEntities"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "insert into [dbo].[User] (UserName,Password,Email,ImgUrl) values (@UserName,@Password,@Email,@ImgUrl)";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            sqlcomm.Parameters.AddWithValue("@UserName", userUI.UserName);
            sqlcomm.Parameters.AddWithValue("@Password", userUI.Password);
            sqlcomm.Parameters.AddWithValue("@Email", userUI.Email);

            if (file != null && file.ContentLength > 0)
            {
                string filename = Path.GetFileName(file.FileName);
                string imgpath = Path.Combine(Server.MapPath("~/UserImages/"), filename);
                file.SaveAs(imgpath);
            }
            sqlcomm.Parameters.AddWithValue("@ImgUrl", "~/UserImages/" + file.FileName);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            ViewData["Message"] = "User Record " + userUI.UserName + " Is Saved Successfully !";
            return View("");
        }
    }
}