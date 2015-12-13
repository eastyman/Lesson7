using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Speed
    {
        private double distance;
        private double time;

        public double Distance
        {
            get { return distance; }
            set
            {
                if (value < 0)
                {
                    throw new DistanceException("Расстояние не может быть отрицательным");
                }
                else
                {
                    distance = value;

                }
            }
        }

        public double Time
        {
            get { return time; }
            set
            {
                if (value <= 0)
                {
                    throw new TimeException("Время не может быть отрицательным или нулевым");
                }
                else
                {
                    time = value;

                }
            }
        }

        public double GetSpeed()
        {
            return distance / time;
        }

    }

    class DistanceException : Exception
    {
        public DistanceException(string message) : base(message) { }
    }

    class TimeException : Exception
    {
        public TimeException(string message) : base(message) { }
    }
}
