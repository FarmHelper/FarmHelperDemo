using System;
using System.Collections.Generic;
using System.IO;
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

            lines = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Backend\\TextFile1.txt"));

            foreach (string line in lines)
            {
                string[] param = line.Split(' ');
                Planta planta = new Planta(param[0], param[1], int.Parse(param[2]), int.Parse(param[3]), int.Parse(param[4]), double.Parse(param[5]));
                lista.Add(planta);
            }

            return lista;


        }
    }
}