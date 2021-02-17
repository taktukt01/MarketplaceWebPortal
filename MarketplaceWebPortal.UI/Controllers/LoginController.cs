using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using MarketplaceWebPortal.Core.POCOClasses;

namespace MarketplaceWebPortal.UI.Controllers
{
    public class LoginController : Controller
    {

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        void connectionString()
        {
            con.ConnectionString = "Data Source=(localdb)/ProjectsV13;Initial Catalog=MarketplaceWebPortal;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        }


        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Verify(UserUI userUI)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from tblUserLogin where UserID='" + userUI.UserName + "' and Password='" + userUI.Password + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("../Home/Index");
            }
            else
            {
                con.Close();

                return RedirectToAction("/Login");
            }
        }

    }
}