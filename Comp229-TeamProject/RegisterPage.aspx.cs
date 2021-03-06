﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_TeamProject
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Created By Shilpa Gandhi
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Server=localhost\\SqlExpress;Database=Comp229Assign03;" + "Integrated Security=True");
            //bool IsAdded = false;
            string Name = txtBoxName.Text;

            string emailaddress = txtBoxEmail.Text;

            string password = txtBoxPassword.Text;

            string address = txtBoxAddress.Text;



            SqlCommand cmd = new SqlCommand("Insert into DS_Library.[dbo].Users (Name, Email,Password,Address)values( @Name, @Email , @Password,@Address)", conn);

            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Email", emailaddress);
            cmd.Parameters.AddWithValue("@Password", password);

            cmd.Parameters.AddWithValue("@Address", address);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Response.Redirect("LoginPage.aspx");
            }
            finally
            {
                conn.Close();
            }


        }

    }
}