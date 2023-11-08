using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioConsumirApi.Entidades
{
    public class Usuario
    {
        public long id_usuario { get; set; }
        public string dni_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string apellidos_usuario { get; set; }
        public string tlf_usuario { get; set; }
        public string email_usuario { get; set; }
        public string clave_usuario { get; set; }
        public bool? estaBloqueado_usuario { get; set; }
        public DateTime? fch_fin_bloqueo_usuario { get; set; }
        public DateTime? fch_alta_usuario { get; set; }
        public DateTime? fch_baja_usuario { get; set; }
        public long AccesoId { get; set; }

        public Usuario(string dni_usuario, string nombre_usuario, string apellidos_usuario, string tlf_usuario
            , string email_usuario, string clave_usuario, bool? estaBloqueado_usuario, DateTime? fch_fin_bloqueo_usuario
            , DateTime? fch_alta_usuario, DateTime? fch_baja_usuario, long accesoId)
        {
            this.dni_usuario = dni_usuario;
            this.nombre_usuario = nombre_usuario;
            this.apellidos_usuario = apellidos_usuario;
            this.tlf_usuario = tlf_usuario;
            this.email_usuario = email_usuario;
            this.clave_usuario = clave_usuario;
            this.estaBloqueado_usuario = estaBloqueado_usuario;
            this.fch_fin_bloqueo_usuario = fch_fin_bloqueo_usuario;
            this.fch_alta_usuario = fch_alta_usuario;
            this.fch_baja_usuario = fch_baja_usuario;
            this.AccesoId = accesoId;
        }

        public void MostrarDatosUsuario()
        {
            Console.WriteLine("\n\n--- Datos del Usuario ---\nDni: {0}\nNombre:{1}\nApellidos:{2}\nTelefono:{3}\nEmail:{4}\nClave:{5}" +
                "\nEstaBloqueado:{6}\nFecha Fin Bloqueo:{7}\nFecha Alta Usuario: {8}\nFecha Baja Usuario: {9}", dni_usuario
                                                                                                              , nombre_usuario
                                                                                                              , apellidos_usuario
                                                                                                              , tlf_usuario
                                                                                                              , email_usuario
                                                                                                              , clave_usuario
                                                                                                              , estaBloqueado_usuario
                                                                                                              , fch_fin_bloqueo_usuario
                                                                                                              , fch_alta_usuario
                                                                                                              , fch_baja_usuario);
        }
    }
}
