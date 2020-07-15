using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    
        public class DynamicArray<T>
        {
            private T[] arr;
            //Конструктор без параметров(создается массив емкостью 8 элементов). 

            public DynamicArray()
            {
                arr = new T[8];
            }

            //2. Конструктор с 1 целочисленным параметром(создается массив заданной емкости). 

            public DynamicArray(int n)
            {
                int[] arr = new int[n];
            }
            //3. Конструктор, который в качестве параметра принимает массив.

            public DynamicArray(T[] n)
            {
                //што тут будет?
            }

            // Метод Add, добавляющий в конец массива один элемент.
            //При нехватке места для добавления элемента емкость массива должна расширяться в 2 раза.

            public T[] Add(T element)
            {//сравнить length и capacity наверн
                if (Length >= Capacity)
                {
                    T[] result = new T[arr.Length * 2];
                    Array.Copy(arr, result, arr.Length);
                    result[arr.Length] = element;
                    return result;
                }
                else
                {
                    T[] result = new T[arr.Length];
                    Array.Copy(arr, result, arr.Length);
                    result[arr.Length] = element;
                    return result;
                }
               
            }
            
            static T[] Insert<T>(T[] arr, int index, T element)
            {
                T[] result = new T[arr.Length + 1];

                Array.Copy(arr, result, index);
                result[index] = element;
                Array.Copy(arr, index, result, index + 1, arr.Length - index);

                return result;
            }
            // . Свойство Length – получение длины заполненной части массива.

            public int Length
            {
                get
                {
                    int count = 0;

                    count = arr.Count();
                    
                    return count;
                }
            }

            // 9. Свойство Capacity – получение реальной ёмкости массива.
            public int Capacity
            {                
                get
                {
                    return arr.Length;
                }
            }
            //10. Индексатор, позволяющий работать с элементом с указанным номером.
            //При выходе за границу массива должно генерироваться исключение ArgumentOutOfRangeException.

            public T this[int index]
		{
                
			get
                {
                    if (index >= arr.Length)
                    {
                        throw new Exception("ArgumentOutOfRangeException");
                    }
                    return arr[index];
                }
            }
            //5. Метод AddRange, добавляющий в конец массива содержимое переданного массива.
            //    Обратите внимание, метод должен корректно учитывать число элементов в коллекции с тем, 
            //    чтобы при необходимости расширения массива делать это только один раз вне зависимости 
            //    от числа элементов в добавляемой коллекции. 

            public T[] AddRange<T>(T[] initialArr, T[] transferArr)
            {
                
                T[] result = new T[initialArr.Length + transferArr.Length];

                Array.Copy(initialArr, result, initialArr.Length);
                
                Array.Copy(transferArr, initialArr.Length, result, initialArr.Length + 1, transferArr.Length);

                return result;
            }
            //6. Метод Remove, удаляющий из коллекции указанный элемент.
            //    Метод должен возвращать true, если удаление прошло успешно и false в противном случае.
            //    При удалении элементов реальная емкость массива не должна уменьшаться.

            public bool Remove(T[] initialArr,int index)
            {
                if (index < 0 || index >= initialArr.Length) 
                {
                    //throw new Exception("Индекс за пределами массива");
                    return false;
                }
                else
                {
                    initialArr[index] = default(T);
                    return true;
                }
                
            }
            
        }

        public interface IIndexable <T>
        {
            T this[int index] { get; }
        }

    class Program
    {

        static void Main(string[] args)
        {
        }
    }
}
