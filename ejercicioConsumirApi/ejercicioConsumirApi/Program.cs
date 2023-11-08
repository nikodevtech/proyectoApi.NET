using ejercicioConsumirApi.Entidades;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ejercicioConsumirApi
{
    public class Program
    {
        /// <summary>
        /// Prueba de consumo de API con HttpClient asyn indica que es una tarea asincrona
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        static async Task Main(string[] args)
        {
            // Crea una instancia de HttpClient, que se utiliza para realizar solicitudes HTTP.
            using (var httpClient = new HttpClient())
            {
                // Define la URL de la API que se va a consumir.
                string apiUrlAccesos = "https://localhost:7223/api/Accesos";
                string apiUrlUsuarios = "https://localhost:7223/api/Usuarios";

                try
                {
                    // Realiza una solicitud GET a la URL de la API y espera la respuesta de manera asincrónica.
                    var responseAccesos = await httpClient.GetAsync(apiUrlAccesos);
                    var responseUsuarios = await httpClient.GetAsync(apiUrlUsuarios);

                    // Verifica si la respuesta de la API tiene un código de estado de éxito (generalmente 2xx).
                    if (responseAccesos.IsSuccessStatusCode)
                    {
                        // Lee el contenido de la respuesta de la API como una cadena de caracteres.
                        string contenidoResponse = await responseAccesos.Content.ReadAsStringAsync();
                        // Deserializa el contenido de la respuesta en una lista de objetos Acceso, es necesario el paquete Newtonsoft.Json.
                        List<Acceso> accesos = JsonConvert.DeserializeObject<List<Acceso>>(contenidoResponse);

                        // Imprime los objetos Acceso en la consola.
                        foreach (Acceso acceso in accesos)
                        {
                            // Imprime el contenido de la respuesta desde el objeto en la consola.
                            Console.WriteLine("\n\n--- Datos Acceso ---\nCódigo acceso: {0}\nDescripción Acceso: {1}", acceso.codigo_acceso, acceso.descripcion_acceso);
                        }

                    }
                    else
                    {
                        // Si la respuesta no tiene un código de estado de éxito, muestra un mensaje de error.
                        Console.WriteLine("La solicitud a la API falló con el código: " + responseAccesos.StatusCode);
                    }

                    // Mismo proceso para la respuesta de la API a usuarios.
                    if (responseUsuarios.IsSuccessStatusCode)
                    {
                        string contenidoResponse = await responseUsuarios.Content.ReadAsStringAsync();
                        List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(contenidoResponse);
                        foreach (Usuario usuario in usuarios)
                        {
                            usuario.MostrarDatosUsuario();
                        }
                    }
                    else
                    {
                        Console.WriteLine("La solicitud a la API falló con el código: " + responseUsuarios.StatusCode);
                    }

                }
                catch (Exception ex)
                {
                    // Captura cualquier excepción que ocurra durante la solicitud y muestra un mensaje de error.
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }
                Console.WriteLine("Presiona cualquier tecla para salir...");
                Console.ReadKey();
            }
        }
    }
}
