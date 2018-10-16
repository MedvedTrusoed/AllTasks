using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    public class User
    {
        private string name;
        private string surname;
        private string patronymic;
        private DateTime birthday;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Имя не должно быть пустым");
                }
                else if (Regex.IsMatch(value, @"\d"))
                {
                    throw new Exception("Имя не может состоять из цифр");
                }
                else
                {
                    value = value.Substring(0, 1).ToUpper() + value.Remove(0, 1);
                    name = value;
                }

            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {

                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Фамилия не должна быть пустой");
                }
                else if (Regex.IsMatch(value, @"\d"))
                {
                    throw new Exception("Фамилия не может состоять из цифр");
                }
                else
                {
                    value = value.Substring(0, 1).ToUpper() + value.Remove(0, 1);
                    surname = value;
                }

            }
        }

        public int Age
        {
            get
            {
                var now = DateTime.Now;
                int age;

                age = now.Year - birthday.Year;

                if (now.Month <= birthday.Month)
                {
                    if (now.Day < birthday.Day)
                    {
                        age--;
                    }
                }

                return age;
            }

        }

        public string Patronymic
        {
            get;
            set;
            
        }
    

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                  if (value > DateTime.Now)
                    {
                        throw new Exception("Ты еще не родился! Сначала родись, а потом и врать научись");
                    }
                    else if (value.Year < (DateTime.Now.Year - 146))
                    {
                        throw new Exception("У нас новый рекордсмен? как же");

                    }
                    else
                    {
                        birthday = value;
                    }
              
            }
        }
    }
}
