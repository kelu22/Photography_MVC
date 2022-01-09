using System;
using Models;
using DataAccess;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCL
{
    public class BL_Class
    {
        public static List<ML_Class> GetContactData()
        {
            ML_Class contact = new ML_Class();
            var contactList = new List<ML_Class>();

            DataSet dsContacts = new DataSet();
            dsContacts = DL_Class.GetContactUsingDBWithConfig();

            //Transfer DataSet to Object
            if (dsContacts.Tables.Count > 0)
            {
                contactList = dsContacts.Tables[0].AsEnumerable().Select(m => new ML_Class()
                {
                    FirstName = Convert.ToString(m["FirstName"]),
                    LastName = Convert.ToString(m["LastName"]),
                    Email = Convert.ToString(m["Email"])
                }).ToList();
            }

            return contactList;
        }
    }
}
