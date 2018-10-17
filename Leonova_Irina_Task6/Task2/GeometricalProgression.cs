using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class GeometricalProgression : ISeries
    {
        double start, step;
        int currentIndex;

        public GeometricalProgression(double start, double step)
        {
            this.start = start;
            this.step = step;
            this.currentIndex = 1;
        }

        public double GetCurrent()
        {
            return start * step * currentIndex;
        }

        public bool MoveNext()
        {
            currentIndex *= 2;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }


    }
}
