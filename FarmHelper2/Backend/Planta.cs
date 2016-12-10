﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmHelper2.Backend
{
    public class Planta
    {
        public string nume { get; set; }
        public string pamant { get; set; }
        public int umiditate { get; set; }
        public int temperatura { get; set;}
        public double scor { get; set; }
        public double procent { get; set; }
        public double tone { get; set; }
        

        public Planta(string n, string p, int u, int c, int t)
        {
            this.nume = n;
            this.pamant = p;
            this.umiditate = u;
            this.temperatura = c;
            this.tone = t;
        }
    }
}