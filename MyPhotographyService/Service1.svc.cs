using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using DataAccess;

namespace MyPhotographyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyPhotographyInfoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MyPhotographyInfoService.svc or MyPhotographyInfoService.svc.cs at the Solution Explorer and start debugging.
    public class MyPhotographyInfoService : IMyPhotographyInfoService
    {
        public DataSet GetImagesUsingDBWithConfig()
        {
            return DL_Class.GetImagesUsingDBWithConfig();
        }
        public DataSet GetContactUsingDBWithConfig()
        {
            return DL_Class.GetContactUsingDBWithConfig();
        }
    }
}
