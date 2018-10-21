using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public static class InterfacesDemo
    {
        public static void Main(string[] args)
        {
            ISeries progression = new GeometricalProgression(2,2);
            Console.WriteLine("Геометрическая прогрессия:");
            PrintSeries(progression);

        }

        static void PrintSeries(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }
    }

    public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }
   
}