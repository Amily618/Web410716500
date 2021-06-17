using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web410716500.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Class1
    {
    }
    public partial class StudentMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "請填寫姓名")]
        [Display(Name = "姓名")]
        [StringLength(10,MinimumLength = 5, ErrorMessage = " 請輸入2~5個字")]

        public string Name { get; set; }

        [Required(ErrorMessage = "請填寫學號")]
        [Display(Name = "學號")]
        [StringLength(10,MinimumLength = 5, ErrorMessage = " 請輸入1~10個字")]

        public string Number { get; set; }

        [Required(ErrorMessage = "請填寫 Email")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "請輸入正確的格式")]

        public string Email { get; set; }

    }
}