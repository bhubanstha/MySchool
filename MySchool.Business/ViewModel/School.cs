using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MySchool.Business.ViewModel
{
    public class SchoolVM
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Name { get; set; }

        [Required]
        [MaxLength(10)]
        public string ShortName { get; set; }

        //[Required]
        public IFormFile Logo { get; set; }

        [Required]
        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        //[DataType(DataType.PhoneNumber)]
        public string PhoneNo { get; set; }

        [Required]
        [DataType(DataType.Url)]
        public string Website { get; set; }


    }
}
