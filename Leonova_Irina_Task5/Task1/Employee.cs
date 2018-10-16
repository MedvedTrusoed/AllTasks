using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{

    public class Employee : User
    {
        // «стаж работы» и «должность». 

        private string position;

        private DateTime dataWork;

        public int Experience
        {
            get
            {
                return DateTime.Now.Year - dataWork.Year;
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

        }

        public string Position
        {
            get
            {
                return position;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
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

        }
    }
}
