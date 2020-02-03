﻿using System.ComponentModel.DataAnnotations;
namespace MyStore.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Не указано имя")]
        public string Name { get; set; }
 
        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}