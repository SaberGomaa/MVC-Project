namespace MVC_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("student")]
    public partial class student
    {
        [DisplayName("Student ID")]
        public int id { get; set; }

        [Required(ErrorMessage ="*")]
        [StringLength(50)]
        public string name { get; set; }

        [Range(15,50 , ErrorMessage = "age must from 15 to 50") ]
        public int? age { get; set; }

        [Required]
        public string address { get; set; }


        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$" , ErrorMessage ="Invalid Email")]
        [Required(ErrorMessage ="*")]
        [StringLength(50)]
        public string Email { get; set; }

        
        
        [Required(ErrorMessage ="*")]
        [StringLength(50)]
        public string password { get; set; }
        [Required(ErrorMessage = "*") ]

        [DisplayName("confirm password")]
        [NotMapped]
        [Compare("password" , ErrorMessage ="not matched password")]
        public string confirm_password { get; set; }


        [Required(ErrorMessage = "*")]
        public string img { get; set; }
        public int departmentid { get; set; }
        public virtual department department { get; set; }
    }
}
