using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataAccess;
using System.Data;


namespace Business
{
    public class Contact
    {
        public static List<Contact> GetIndividualContactData()
        {
            Contact IndivDemo = new Contact();
            var IndivDemoList = new List<Contact>();

            // 2nd Assignment
            // Get the contact from database but get the connection string from web.Config file
            DataSet dsGetContactReport = new DataSet();
            dsGetContactReport = DL_Class.GetContactUsingDBWithConfig();

            // 3rd Assignment
            // Calling web service - Get the contact from database but get the connection string from web.Config file

            // Transfer Dataset Details to List Object
            if(dsGetContactReport.Tables.Count > 0)
            {
                IndivDemoList = dsGetContactReport.Tables[0].AsEnumerable().Select(m => new Contact
                {
                    // Left side is Model Object - Right Side is Database column
                    FirstName = Convert.ToString(m["FirstName"]),
                    LastName = Convert.ToString(m["LastName"]),
                    Email = Convert.ToString(m["Email"])
                }).ToList();

            }

            // Build the Business Logic here based on the requirements from the client
            return IndivDemoList;
        }
    }
}
