using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsModFlotillas.Usuarios
{
    public class ClsModUsuarios
    {
     
        public int status { get; set; }
        public string mensaje { get; set; }

        public int idUsuario { get; set; }
        public string Usuario { get; set; }
        public string UserName { get; set; }
        public string PassName { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CodigoPostal { get; set; }
        public int TipoUsuario { get; set; }
        public int idPais { get; set; }
        public string Pais { get; set; }
        public int idEstado { get; set; }
        public string Estado { get; set; }
        public int idCiudad { get; set; }
        public string Municipio { get; set; }

    }
}
