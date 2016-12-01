using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadModel.Model
{
    public class Cohort
    {
        public string Name { get; set; }
        public LoadProfile Profile { get; set; }

        public int Count { get; set; }
        public int StartTime { get; set; }
        public double BaseSize { get; set; }
        public double GrowthRate { get; set; }

        public Cohort() : this("default", new LoadProfile())
        {

        }
        public Cohort(string name, LoadProfile profile, int count = 0, int startTime = 0, double baseSize = 1.0, double growthRate = 1.0)
        {
            this.Name = name;
            this.Profile = profile;
            this.Count = count;
            this.StartTime = startTime;
            this.BaseSize = baseSize;
            this.GrowthRate = growthRate;
        }

        public double GetTotalSizeAt(int time)
        {
            if (time < StartTime)
                return 0.0;

            return ((time - StartTime) * GrowthRate + BaseSize) * Count;
        }

    }
}
