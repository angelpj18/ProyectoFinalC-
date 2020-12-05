using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PandaHotelWPF
{
    public class Categor
    {
        public int Id { get; set; }
        public string descripcion { get; set; }
        public string precioCategoria { get; set; }

        // VOLVER A VER SI FUNCIONA CON CATEGORIA
        public static async Task<List<Categor>> ObtenerTodos()
        {
            List<Categor> lstpersonas = new List<Categor>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:63050/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage respuesta = await client.GetAsync("api/Personas");

                if (respuesta.IsSuccessStatusCode)
                {
                    lstpersonas = await respuesta.Content.ReadAsAsync<List<Categor>>();
                }
            }

            return lstpersonas;
        }



        public static async Task<bool> AgregarPersona(Categor c)
        {           
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:63050/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage respuesta = await client.PostAsJsonAsync("api/Personas", c); 
                return respuesta.IsSuccessStatusCode;
            }
        }



        public static async Task<bool> ModificarPersona(Categor c)
        {          
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:63050/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage respuesta = await client.PutAsJsonAsync("api/Personas/" + c.Id, c);
                return respuesta.IsSuccessStatusCode;
            }
        }



        public static async Task<bool> EliminarPersona(Categor c)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:63050/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage respuesta = await client.DeleteAsync("api/Personas/" + c.Id);
                return respuesta.IsSuccessStatusCode;
            }
        }
    }
}
