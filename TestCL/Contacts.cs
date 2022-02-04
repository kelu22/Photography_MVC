using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataAccess;
using System.Data;
using TestCL;

namespace Business
{
    public class Contacts
    {
        public static List<Contacts> GetIndividualContactData()
        {
            Contacts IndivDemo = new Contacts();
            var IndivDemoList = new List<Contacts>();

            // 2nd Assignment
            // Get the contact from database but get the connection string from web.Config file
            DataSet dsGetContactReport = new DataSet();
            dsGetContactReport = DL_Class.GetContactUsingDBWithConfig();

            // 3rd Assignment
            // Calling web service - Get the contact from database but get the connection string from web.Config file

            // Transfer Dataset Details to List Object
            //if(dsGetContactReport.Tables.Count > 0)
            //{
            //    IndivDemoList = dsGetContactReport.Tables[0].AsEnumerable().Select(m => new Contact
            //    {
            //        // Left side is Model Object - Right Side is Database column
            //        FirstName = Convert.ToString(m["FirstName"]),
            //        LastName = Convert.ToString(m["LastName"]),
            //        Email = Convert.ToString(m["Email"])
            //    }).ToList();

            //}

            // Build the Business Logic here based on the requirements from the client
            return IndivDemoList;
        }

        public static List<ML_Class> GetContactData()
        {
            ML_Class contact = new ML_Class();
            var contactList = new List<ML_Class>();
            DataSet dsContacts = new DataSet();


            //2nd assignment
            dsContacts = DL_Class.GetContactUsingDBWithConfig();

            //3rd assignment - Get info from DB but the connection string details from web.conf file
            //var dbService = new TestCL.MyPhotographyService.MyPhotographyInfoServiceClient();
            //dsContacts = dbService.GetContactUsingDBWithConfig();

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

        public static List<ML_Class> GetImagesData()
        {
            ML_Class image = new ML_Class();
            var imageList = new List<ML_Class>();
            DataSet dsImages = new DataSet();

            //2nd Assignment
            //dsImages = DL_Class.GetImagesUsingDBWithConfig();

            //3rd assignment - Get info from DB but the connection string details from web.conf file
            var dbService = new TestCL.MyPhotographyService.MyPhotographyInfoServiceClient();
            dsImages = dbService.GetImagesUsingDBWithConfig();

            //Transfer DataSet to Object
            if (dsImages.Tables.Count > 0)
            {
                imageList = dsImages.Tables[0].AsEnumerable().Select(m => new ML_Class()
                {
                    ImageType = Convert.ToString(m["ImageType"]),
                    ImageURL = Convert.ToString(m["ImageURL"])
                }).ToList();
            }

            return imageList;
        }
    }
}
