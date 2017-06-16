using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib.Model
{
    public class User

    {

        private string id;

        private string username;

        private string password;

        private char gender; //"F" & "M"

        private int age;

        private string phone;



        public User()

        {
            


        }



        public User(string username, string password, char gender, int age, string phone)

        {

            this.username = username;

            this.password = password;

            this.gender = gender;

            this.age = age;

            this.phone = phone;

        }



        public User(string id, string username, string password, char gender, int age, string phone)

        {

            this.id = id;

            this.username = username;

            this.password = password;

            this.gender = gender;

            this.age = age;

            this.phone = phone;

        }

        public virtual string Id { get; set; }

        public virtual string Username { get; set; }

        public virtual string Password { get; set; }

        public virtual char Gender { get; set; }

        public virtual int Age { get; set; }

        public virtual string Phone { get; set; }

        public override bool Equals(object obj)

        {

            if (this == obj)

            {

                return true;

            }

            User user = obj as User;

            if (user == null)

            {

                return false;

            }

            else

            {

                return this.Username.Equals(user.Username);

            }

        }



        public override int GetHashCode()

        {

            return Username.GetHashCode();

        }



        public override string ToString()

        {

            return "id:" + Id + ";  Username:" + Username + ";  Password:" + Password + ";  Gender:" + Gender + ";  Age:" + Age + ";    Phone:" + Phone;

        }

    }
}
