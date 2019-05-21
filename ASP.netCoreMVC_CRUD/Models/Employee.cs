using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.netCoreMVC_CRUD.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }


        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage ="This field required")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }


        [Column(TypeName = "varchar(10)")]
        [DisplayName("Employe Code")]
        public string EmployeeCode { get; set; }

        [DisplayName("Position")]
        [Column(TypeName = "varchar(100)")]
        public string Position { get; set; }

        [DisplayName("Office Location")]

        [Column(TypeName = "varchar(100)")]
        public string OfficeLocation { get; set; }
    }
}
