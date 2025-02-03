using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class User
    {
        public int Id { get; set; }
        //[Column(TypeName = "Varchar(25)")]
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public User() { }

        public User(int id, string userName, string lastName, string email, int age)
        {
            Id = id;
            UserName = userName;
            LastName = lastName;
            Email = email;
            Age = age;
          
        }
    }  
}
