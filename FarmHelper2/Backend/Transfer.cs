using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmHelper2.Backend
{
    public class Transfer
    {
        public List<Planta> plante { get; set; } 

        public Transfer(List<Planta> plante)
        {
            this.plante = plante;
            valid();
            calcul();
        }

        public void valid()
        {
            while (plante.Count < 5)
            {
                plante.RemoveAt(plante.Count - 1);
            }
        }

        public void calcul()
        {

            foreach(Planta planta in plante)
            {
                planta.procent = Math.Abs(planta.scor - 2) * 50.0;
            }
            foreach (Planta planta in plante)
            {
                planta.tone = (planta.tone * planta.procent)/100.0;
            }
        }
        

    }
}