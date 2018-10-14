using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee u1 = new Employee();
            u1.Name = "Pavel";
            u1.Surname = "Gnomik";
            DateTime d1 = new DateTime(1998, 7, 20);
            u1.Birthday = d1;
            u1.DataWork = new DateTime(2015, 09, 05);
            u1.Position = "Programmer";

            Console.WriteLine($"Имя {u1.Name} фамилия {u1.Surname} возраст {u1.Age}");
            Console.WriteLine($"Должность {u1.Position} Стаж {u1.Experience}");
        }
    }

    public class User
    {
        private string name;
        private string surname;
        private string patronymic;
        private DateTime birthday;
       

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

                return age.Days/365;
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

    public class Employee : User
    {
        // «стаж работы» и «должность». 

        private string position;

        private DateTime dataWork;
        
        public int Experience
        {
            get
            {
                var work = new TimeSpan();

                work = DateTime.Now - dataWork;

                return work.Days/365;
            }

        }
        public DateTime DataWork
        {
            get
            {
                return dataWork;
            }

            set
            {
                try
                {
                    if (value > DateTime.Now)
                    {
                        throw new Exception("Назад в будущее? не выйдет");
                    }
                    else if (value.Year < (DateTime.Now.Year - 100))
                    {
                        throw new Exception("От работы дохнут кони, а вы и подавно");

                    }
                    else
                    {
                        dataWork = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                }
            }

        }

        public string Position
        {
            get
            {
                return position;
            }

            set
            {
                try
                {
                    if (value == string.Empty)
                    {
                        throw new Exception("Нет занимаемой должности");
                    }
                    else if (Regex.IsMatch(value, @"\d"))
                    {
                        throw new Exception("Должность не может состоять из цифр");
                    }
                    else
                    {
                        value = value.Substring(0, 1).ToUpper() + value.Remove(0, 1);
                        position = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                }
            }

        }
    }

}
