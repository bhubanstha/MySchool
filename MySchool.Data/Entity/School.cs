using MySchool.Data.Context;
using MySchool.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Data.Entity
{
    public class School : BaseEntity
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Logo { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Website { get; set; }
        public string BackImage { get; set; }

    }
}
