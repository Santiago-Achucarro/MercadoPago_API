using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KSKFEEventos.MP

{
    public class GenerarOrden
    {
        private readonly decimal total;
        private readonly string detalle;
        private readonly string sucursal;
        private readonly string url;
        private readonly string urlEscaneo;
        private readonly string accessToken;
        public string Mensaje;
        private bool respuesta;

        public GenerarOrden(decimal total, string detalle, string sucursal)
        {
            this.total = total;
            this.detalle = detalle;
            this.sucursal = sucursal;

            this.url = "https://api.mercadopago.com/instore/qr/seller/collectors/129768028/stores/SUC001/pos/SUC001POS001/orders";
            this.accessToken = "TEST-1533457854847182-070511-97706d0b5afacb65ecaf0a9a11b837ba-129768028";
            this.urlEscaneo = $"https://api.mercadopago.com/merchant_orders/search?external_reference={this.detalle}";

            //string urlGustavo = "https://api.mercadopago.com/instore/qr/seller/collectors/58003510/stores/SUC0010/pos/CAJA01/orders";
            //string accessTokenGustavo = "APP_USR-238366883478725-071108-313efcff2c390874b7a35e733abbbe8b-58003510";
        }
        public GenerarOrden(string detalle)
        {
            this.detalle = detalle;

            this.url = "https://api.mercadopago.com/instore/qr/seller/collectors/129768028/stores/SUC001/pos/SUC001POS001/orders";
            this.accessToken = "TEST-1533457854847182-070511-97706d0b5afacb65ecaf0a9a11b837ba-129768028";
            this.urlEscaneo = $"https://api.mercadopago.com/merchant_orders/search?external_reference={this.detalle}";

            //string urlGustavo = "https://api.mercadopago.com/instore/qr/seller/collectors/58003510/stores/SUC0010/pos/CAJA01/orders";
            //string accessTokenGustavo = "APP_USR-238366883478725-071108-313efcff2c390874b7a35e733abbbe8b-58003510";
        }

        public async Task Borrar()
        {
            string urlBorrar = "https://api.mercadopago.com/instore/qr/seller/collectors/129768028/pos/SUC001POS001/orders";
            //borro las ordenes por las dudas
            using (HttpClient client = new HttpClient())
            {

                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                HttpResponseMessage response = await client.DeleteAsync(urlBorrar);

                //no me importa si me da error o no
                return;
            }

        }
        public async Task<bool> Generar()
        {
            

            var model = new
            {
                external_reference = detalle,
                title = $"Factura desde Sucursal {sucursal}",
                description = "DynamicsGPdescripcion",
                total_amount = total,
                items = new[]
                {
                    new {
                        sku_number = "A001",
                        category = "marketplace",
                        title = "DynamicsGP",
                        description = "DynamicsGPdescripcion",
                        unit_price = total,
                        quantity = 1,
                        unit_measure = "unit",
                        total_amount = total
                    }
                }
            };
            try
            {

                using (HttpClient client = new HttpClient())
                {
                    string jsonData = JsonConvert.SerializeObject(model);

                    // Configurar el contenido de la solicitud POST
                    HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                    HttpResponseMessage response = await client.PutAsync(url, content);

                    if (!response.IsSuccessStatusCode)
                    {
                        // Si la respuesta no es exitosa, obtener el contenido del mensaje de error
                        string errorContent = await response.Content.ReadAsStringAsync();

                        // Deserializar el contenido del error a un objeto para manipularlo
                        dynamic errorResponse = JsonConvert.DeserializeObject(errorContent);

                        // Obtener el mensaje de error específico y otros detalles si es necesario
                        string errorMessage = errorResponse.message;
                        string errorCode = errorResponse.cause[0].code;
                        string errordescription = errorResponse.cause[0].description;

                        Console.WriteLine($"Error {response.StatusCode}: {errorMessage} (Código: {errorCode}) (Error: {errordescription})");
                        return false;
                    }
                    else
                    {
                        // Si la respuesta es exitosa, imprimir el mensaje de éxito
                        Console.WriteLine("Solicitud POST exitosa!");
                        return true;
                    }

                }
            }
            catch (HttpRequestException ex)
            {
                // Capturar errores de la solicitud HTTP
                Console.WriteLine($"Error en la solicitud: {ex.Message}");
                return false;

            }
            catch (Exception ex)
            {
                // Capturar otras excepciones
                Console.WriteLine($"Error inesperado: {ex.Message}");
                return false;

            }
        }
        public async Task<string> Escaneo(string comprobante)
        {

            string respuesta = "1";
            string responseBody = string.Empty;
            dynamic responseObject = string.Empty;
            int contador = 0;
            int espera = 20;

            while (contador <= espera)
            {
                await Task.Delay(1000);
                contador++;

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                HttpResponseMessage response = await client.GetAsync(urlEscaneo);
                if (response.IsSuccessStatusCode)
                {
                    responseBody = await response.Content.ReadAsStringAsync();
                    // Deserializa el JSON en un objeto anónimo
                    responseObject = JsonConvert.DeserializeObject<dynamic>(responseBody);

                    if (responseBody.Contains(comprobante))
                    {
                        var firstElement = responseObject.elements[0];
                        string id = firstElement.id.ToString();
                        string status = firstElement.status.ToString();

                        if (status == "closed")
                        {
                            respuesta = "2";
                            return respuesta;
                        }
                        if (status == "opened")
                        {
                            //le doy un poco mas de tiempo
                            contador = contador - (contador / 2);
                        }

                    }

                }
                else
                {
                    Mensaje = "No se pudo llegar a la Api";
                    return "3";

                }

            };

            Mensaje = "Llego al final del ciclo";
            return "4";
        }
    }
}
