using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioConsumirApi.Entidades
{
    public class Acceso
    {

        public long id_acceso { get; set; }
        public string codigo_acceso { get; set; }
        public string descripcion_acceso { get; set; }

        public List<Usuario> Usuarios { get; set; }

        public Acceso(string codigo_acceso, string descripcion_acceso)
        {
            this.codigo_acceso = codigo_acceso;
            this.descripcion_acceso = descripcion_acceso;
        }

    }
}
