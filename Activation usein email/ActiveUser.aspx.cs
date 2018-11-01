using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Activation usein email.Models;

namespace Activation usein email
{

    public partial class ActiveUser : System.Web.UI.Page
    {
        private Models.ActiveUserBayEmailEntities db = new ActiveUserBayEmailEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

            var activecod = Page.RouteData.Values["ActiveCod"].ToString();

            var user = (from u in db.Tbl_User where u.ActiveCod == activecod select u).First();
            user.IsActive = true;
            db.SaveChanges();

        }
    }
}