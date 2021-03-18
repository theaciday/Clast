using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clast.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(14)]
        [Required(ErrorMessage = "Length name = !<1")]
        public string Name { get; set; }

        [Display(Name = "SurName")]
        [StringLength(14)]
        [Required(ErrorMessage = "Length SurName = !<1")]
        public string SurName { get; set; }
        [Display(Name ="Number Phone")]
        [StringLength(12)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage ="Length Pnone Number = !<7")]
        public string Phone { get; set; }

        [Display(Name = "Adress")]
        [StringLength(115)]
        [Required(ErrorMessage = "Length Address = !<10")]
        public string Adress { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(20)]
        [Required(ErrorMessage ="Length email = !<1")]
        public string Email{ get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime{ get; set; }

        public List<OrderDetail> OrderDetails { get; set; }







    }
}
