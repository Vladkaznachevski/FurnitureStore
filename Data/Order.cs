using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Order : BaseEntity
    {

        [Display(Name = "Введите ваше Имя")]
        [StringLength(30)]
        [Required(ErrorMessage = "длина имени не может")]
        public string Name { get; set; }

        [Display(Name = "Введите вашу Фамилию")]
        public string Surname { get; set; }

        [Display(Name = "Введите ваше Адрес")]
        public string Address { get; set; }

        [Display(Name = "Введите ваш Телефон")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "это не телефон")]
        public string Phone { get; set; }

        [Display(Name = "Введите вашу электронную почту")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "это не почта")]
        public string Email { get; set; }

        public DateTime OrderTime { get; set; }




    }
}
