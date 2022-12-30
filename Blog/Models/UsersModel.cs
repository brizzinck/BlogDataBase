using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Models
{
    public class UsersModel
    {
        [Display(Name = "Возраст")]
        [Range(7, 70, ErrorMessage = "Вам необходимо вписать возраст от 7 до 70")]
        public int age { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Необходимо заполнить поле имя")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Необходимо заполнить поле фамилия")]
        public string surname { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Почта")]
        [Required(ErrorMessage = "Необходимо заполнить поле почты")]
        public string Email { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Подтрверждения почты")]
        [System.ComponentModel.DataAnnotations.Compare("Email", ErrorMessage = "Подтрверждения почты неверное")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Необходимо заполнить поле пароль")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Пароль должен быть менее 50 и более 4 символов")]
        public string Password { get; set; }

        [Display(Name = "Подтверждения пароля")]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Подтрверждения пароля неверное")]
        public string ConfirmPassword { get; set; }
    }
}