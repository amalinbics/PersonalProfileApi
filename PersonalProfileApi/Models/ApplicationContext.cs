using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PersonalProfileApi.Models
{
    public class ApplicationContext : DbContext      
    {
        public ApplicationContext() :base("PersonalProfile")
        {

        }
    }
}