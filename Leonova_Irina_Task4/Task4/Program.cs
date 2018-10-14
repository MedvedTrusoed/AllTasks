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
                try
                {
                    if (value == string.Empty)
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
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
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
                try
                {
                    if (value == string.Empty)
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
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                }
            }
        }

        public int Age
        {
            get
            {
                var age = new TimeSpan();

                age = DateTime.Now - birthday;

                return age.Days / 365;
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
                try
                {
                    if (Regex.IsMatch(value, @"\d"))
                    {
                        throw new Exception("Отчество не может состоять из цифр");
                    }
                    else
                    {
                        value = value.Substring(0, 1).ToUpper() + value.Remove(0, 1);
                        patronymic = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
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
                try
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
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
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
