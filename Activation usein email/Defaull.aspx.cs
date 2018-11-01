using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Activation usein email.Models;

namespace Activation usein email
{
    public partial class Defaull : System.Web.UI.Page
    {
        private Models.ActiveUserBayEmailEntities db = new ActiveUserBayEmailEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSendActivelink_OnClick(object sender, EventArgs e)
        {
            var guid = Guid.NewGuid().ToString().Replace("-", "");
            db.Tbl_User.Add(new Tbl_User()
            {
                Email = txtEmail.Text,
                ActiveCod = guid,
                IsActive = false,
            });
            db.SaveChanges();
            var domainName = "http://" + Request.Url.Authority;
            string body = "<div style='direction:rtl; text-align:right;'>";
            body += "<li><a href="+ domainName+"/ActiveUser/" + guid + "></a>کلیک کنید</li>";
            body += "</div>";

            SendMail.SendEmailGmail.Send(txtEmail.Text, "لینک فعال سازی", body);

        }


    }
}