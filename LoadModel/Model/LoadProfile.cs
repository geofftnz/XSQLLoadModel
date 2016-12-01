using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadModel.Model
{
    /// <summary>
    /// Represents a given load profile, which determines the probability of activity for a given period (hour) of the day.
    /// </summary>
    public class LoadProfile
    {
        public string Name { get; set; }

        public const int PERIODS = 24;
        private double[] probability = new double[PERIODS];

        public double this[int period]
        {
            get
            {
                if (period < 0 || period >= PERIODS)
                    throw new ArgumentOutOfRangeException("hour");

                return probability[period];
            }
            private set
            {
                if (period < 0 || period >= PERIODS)
                    throw new ArgumentOutOfRangeException("hour");

                probability[period] = value;
            }
        }

        public LoadProfile()
        {
            Name = "default";

            for (int i = 0; i < PERIODS; i++)
                probability[i] = 1.0;
        }
    }
}
