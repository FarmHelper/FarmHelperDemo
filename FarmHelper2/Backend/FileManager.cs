using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmHelper2.Backend
{
    public class FileManager
    {

        public static List<Planta> ReadFile()
        {

            List<Planta> lista = new List<Planta>();

            string[] lines;


            lines = System.IO.File.ReadAllLines(@"~/FarmHelper2.txt");

            foreach (string line in lines)
            {
                string[] param = line.Split(' ');
                Planta planta = new Planta(param[1], param[2], int.Parse(param[3]), int.Parse(param[4]));
                lista.Add(planta);
            }

            return lista;


        }
    }
}