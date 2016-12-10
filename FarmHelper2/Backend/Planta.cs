using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmHelper2.Backend
{
    public class Planta
    {
        private string nume;
        private string pamant;
        private int umiditate;
        private int temperatura;
        

        public Planta(string n, string p, int u, int t)
        {
            this.nume = n;
            this.pamant = p;
            this.umiditate = u;
            this.temperatura = t;
        }
    }
}