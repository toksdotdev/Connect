using Connect.Models;
using System;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;
using v = System.Web.Caching;

namespace Connect.classes.Account
{
    internal class Register
    {
        public Register(string fName, string lName, string email, string password)
        {
            ConnectOfflineDBEntities db = new ConnectOfflineDBEntities();

            User_Details_OfflineTable user = new User_Details_OfflineTable
            {
                iFK_AccountTypeId = 1,
                vcFirstName = fName,
                vcLastName = lName,
                vcEmail = email,
            };

            db.User_Details_OfflineTable.AddOrUpdate(user);
            //db.SaveChanges();
            SubmitAndCatchErrors(ref db);

            var query = from it in db.User_Details_OfflineTable
                        orderby it.vcFirstName
                        select it;

            string text = "";
            foreach (User_Details_OfflineTable v in query)
            {
                text += String.Format("{0} {1} {2} {3}", v.vcFirstName, v.vcLastName, v.vcEmail, v.vcProfilePicturePath);
            }
            MessageBox.Show(text);
        }

        public static void SubmitAndCatchErrors(ref ConnectOfflineDBEntities db)
        {
            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                var text = "";
                foreach (var eEntityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in eEntityValidationErrors.ValidationErrors)
                    {
                        text += "Property: " + validationError.PropertyName + "Error: " + validationError.ErrorMessage + Environment.NewLine;
                    }
                }

                if (text != "") MessageBox.Show(text);
            }

            MessageBox.Show("done");
        }
    }
}