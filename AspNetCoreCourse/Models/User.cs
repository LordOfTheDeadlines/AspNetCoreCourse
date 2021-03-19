using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCourse.Models
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public User(String Login, String Password)
        {
            this.Login = Login;
            this.Password = Password;
        }
    }
}
