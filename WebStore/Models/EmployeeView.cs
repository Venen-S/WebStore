﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class EmployeeView
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя является обязательным")]
        [Display(Name = "Имя")]
        [StringLength(maximumLength:200,MinimumLength = 2,ErrorMessage 
            = "В имени должно быть не менее 2х и не более 200 символов")]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false,ErrorMessage = "Фамилия должна быть обязательно")]
        [Display(Name = "Фамилия")]
        public string SurName { get; set; }
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }
        [Required(AllowEmptyStrings = false,ErrorMessage = "Возраст обязателен")]
        [Display(Name = "Возраст")]
        public int Age { get; set; }
        [Required(AllowEmptyStrings = false,ErrorMessage = "Должность обязательна")]
        [Display(Name = "Возраст")]
        public string Position { get; set; }
    }
}
