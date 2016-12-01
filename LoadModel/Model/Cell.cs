﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadModel.Model
{
    public class Cell
    {
        /// <summary>
        /// Name of this cell
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Size of this cell, eg: Amount of memory
        /// </summary>
        public double Size { get; set; }

        /// <summary>
        /// List of cohorts (groups of tenants) in this cell
        /// </summary>
        public List<Cohort> Cohorts { get; } = new List<Cohort>();


        public Cell()
        {

        }

    }
}
