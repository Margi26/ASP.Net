using System;
using System.Web.UI;

namespace GiftArticleStore
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            // Retrieve user input
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            // Here you can add code to save the user to your database
            // For simplicity, let's assume we're just printing the user details
            Response.Write($"Registration successful! Username: {username}, Email: {email}");
        }
    }
}
