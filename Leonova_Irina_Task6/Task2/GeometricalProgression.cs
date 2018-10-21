using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class GeometricalProgression : ISeries
    {
        int start, step;
        int currentIndex;

        public GeometricalProgression(int start, int step)
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
            currentIndex *= step;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }


    }
}
