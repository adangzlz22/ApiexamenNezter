using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsDatFlotillas
{
    public class Conexion
    {
        public static string conectarExamenNezter()
        {
            string conexion = "";
            string User = "db_a567ba_nezter_admin";
            string Password = "ASDstdskf.234";
            string bd = "db_a567ba_nezter";
            string server = "SQL5101.site4now.net";
            conexion = "Data Source=" + server + ";Initial Catalog=" + bd + ";User ID=" + User + ";Password=" + Password + ";";
            return conexion;
        }
    }
}
