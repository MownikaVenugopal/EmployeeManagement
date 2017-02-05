using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace EmployeeApp.Models.DB
{
    public class AddEmployeeDB
    {
       // public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string Comments { get; set; }
   

        public string InsertEmployee(AddEmployeeDB empDetails)
        {
            var connstring = WebConfigurationManager.ConnectionStrings["EmployeeContextADO"].ConnectionString;
            SqlConnection con = new SqlConnection(connstring);
            SqlCommand com = new SqlCommand();
           
            com.CommandText = "Insert into Employee ([First Name], [Last Name], [Phone Number], [Address], [EmailAddress],[Comments]) values('" + empDetails.FirstName+"','"+empDetails.LastName+"','"+ empDetails.PhoneNumber+ "','"+ empDetails.Address + "','" + empDetails.EmailAddress + "','" + empDetails.Comments + "')";
            com.Connection = con;
            try{
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                return "Success";
            }
            catch (Exception es)
            {
                throw (es);
            }
        }
    }
}