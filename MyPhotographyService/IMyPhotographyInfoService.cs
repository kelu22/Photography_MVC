using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;

namespace MyPhotographyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMyPhotographyInfoService" in both code and config file together.
    [ServiceContract]
    public interface IMyPhotographyInfoService
    {

        [OperationContract]
        DataSet GetImagesUsingDBWithConfig();

        [OperationContract]
        DataSet GetContactUsingDBWithConfig();
    }

}
