using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    //Написать класс User, описывающий человека(Фамилия, Имя, Отчество, Дата рождения, Возраст). 
    //Написать программу, демонстрирующую использование этого класса

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
                if (name == string.Empty)
                {
                    Console.WriteLine("Имя не должно быть пустым");
                }
                else if (Regex.IsMatch(name, @"\d"))
                {
                    Console.WriteLine("Имя не может состоять из цифр");
                }
                else
                {
                    name = name.Substring(0, 1).ToUpper() + name.Remove(0, 1);
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
                if (surname == string.Empty)
                {
                    Console.WriteLine("Фамилия не должно быть пустым");
                }
                else if (Regex.IsMatch(surname, @"\d"))
                {
                    Console.WriteLine("Фамилия не может состоять из цифр");
                }
                else
                {
                    surname = surname.Substring(0, 1).ToUpper() + surname.Remove(0, 1);
                    surname = value;
                }
            }
        }

        public int Age
        {
            get
            {
                
                return age = DateTime.Now.Year-birthday.Year; ;
            }

        }

        public string Patronymic
        {
            get
            {
                return patronymic;
            }

            set
            {
                if (Regex.IsMatch(patronymic, @"\d"))
                {
                    Console.WriteLine("Отчество не может состоять из цифр");
                }
                else
                {
                    patronymic = patronymic.Substring(0, 1).ToUpper() + patronymic.Remove(0, 1);
                    patronymic = value;
                }
            }
        }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                if (birthday > DateTime.Now)
                {
                    Console.WriteLine("Ты еще не родился! Сначала родись, а потом и врать научись");
                }
                else if (birthday.Year < (DateTime.Now.Year - 146))
                {
                    Console.WriteLine("У нас новый рекордсмен? как же");

                }
                else
                {
                    birthday = value;
                }
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
