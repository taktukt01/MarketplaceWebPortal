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
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        void connectionString()
        {
            con.ConnectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=MarketplaceWebPortal;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        }

        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserUI userUI, HttpPostedFileBase file)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "insert into [dbo].[User] (UserName,Password,Email,ImgUrl) values (@UserName,@Password,@Email,@ImgUrl)";

            com.Parameters.AddWithValue("@UserName", userUI.UserName);
            com.Parameters.AddWithValue("@Password", userUI.Password);
            com.Parameters.AddWithValue("@Email", userUI.Email);

            if (file != null && file.ContentLength > 0)
            {
                string filename = Path.GetFileName(file.FileName);
                string imgpath = Path.Combine(Server.MapPath("~/Profile/"), filename);
                file.SaveAs(imgpath);
            }
            //else
            //{
            //    return Redirect("/Index");
            //}
            com.Parameters.AddWithValue("@ImgUrl", "~/Profile/" + file.FileName);
            com.ExecuteNonQuery();
            con.Close();
            //sqlconn.Close();
            ViewData["Message"] = "User Record " + userUI.UserName + " Is Saved Successfully !";
            return Redirect("/Login");
        }
    }
}
