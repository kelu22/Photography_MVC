using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Models
{
    public class ML_Class
    {
        //Contact information properties
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }


        //Any properties related to the photographies
        [DisplayName("ImageType")]
        public string ImageType { get; set; }

        [DisplayName("ImageName")]
        public string ImageName { get; set; }

        [DisplayName("ImageURL")]
        public string ImageURL { get; set; }
    }
}
