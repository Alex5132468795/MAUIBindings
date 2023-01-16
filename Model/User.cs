using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3.Model
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FuthersName { get; set; }
        public string source{ get; set; }

    public User(string name, string surname, string futhersName, string source)
        {
            this.Name = name;
            this.Surname = surname;
            this.FuthersName = futhersName;
            this.source = source;
        }
        //public User(params string[] name)
        //{
        //    this.name = name[0];
        //    this.surname = name[1];
        //    this.futhersName = name[2];
        //    this.source = name[3];
        //}
        //public User()
        //{
        //    this.name = "qwe";
        //}
    }
}
