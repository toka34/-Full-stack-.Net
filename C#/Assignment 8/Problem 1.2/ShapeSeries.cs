using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
    public class SquareSeries : IShapeSeries
    {
        private int currentSideLength;
        public int CurrentShapeArea { get; set; }

        public SquareSeries()
        {
            ResetSeries();
        }

        public void GetNextArea()
        {
            currentSideLength++;
            CurrentShapeArea = currentSideLength * currentSideLength;
        }

        public void ResetSeries()
        {
            currentSideLength = 0;
            CurrentShapeArea = 0;
        }
    }

    public class CircleSeries : IShapeSeries
    {
        private int currentRadius;
        public int CurrentShapeArea { get; set; }

        public CircleSeries()
        {
            ResetSeries();
        }

        public void GetNextArea()
        {
            currentRadius++;
            CurrentShapeArea = (int)(Math.PI * currentRadius * currentRadius);
        }

        public void ResetSeries()
        {
            currentRadius = 0;
            CurrentShapeArea = 0;
        }
    }
}
