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
        private string birtday;
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
                return age;
            }

            set
            {

                 if (age>146)
                {
                    Console.WriteLine("Вы не рекордсмен");
                }
                else if(age <= 0)
                {
                    Console.WriteLine("Ваш возраст должен быть меньше 0");
                }
                
                else
                {
                    
                    age = value;
                }
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

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
