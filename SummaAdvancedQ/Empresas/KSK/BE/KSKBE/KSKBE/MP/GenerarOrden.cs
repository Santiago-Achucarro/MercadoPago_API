using Framework.Core;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KSKBE.MP
{
    public class GenerarOrden
    {
        private readonly decimal total;
        public string detalle;
        private readonly string sucursal;
        private readonly string url;
        private readonly string urlEscaneo;
        private readonly string accessToken;
        


        private string Sucursal;
        public string mpSucursal;
        public string mpCaja;
        public string mpToken;
        public string mpCollector;


        public string RespuestaId;
        public string Mensaje;
        public bool respuesta;
        


        //para la busqueda
        public string status;
        public string pay_status;
        public decimal monto;
        public string fecha;

        public GenerarOrden(decimal total, string detalle, string mpsucursal, string mpcaja)
        {
            this.total = total;
            this.detalle = detalle;


            TraerToken();
            this.accessToken = mpToken;
            TraerCollectorId();

            this.url = "https://api.mercadopago.com/instore/qr/seller/collectors/" + mpCollector + "/stores/" + 
                        mpsucursal + "/pos/" + mpcaja + "/orders";



            //this.accessToken = "TEST-1533457854847182-070511-97706d0b5afacb65ecaf0a9a11b837ba-129768028";
            this.urlEscaneo = $"https://api.mercadopago.com/merchant_orders/search?external_reference={this.detalle}";

            //string urlGustavo = "https://api.mercadopago.com/instore/qr/seller/collectors/58003510/stores/SUC0010/pos/CAJA01/orders";
            //string accessTokenGustavo = "APP_USR-238366883478725-071108-313efcff2c390874b7a35e733abbbe8b-58003510";
        }


        public GenerarOrden(string detalle, string mpsucursal, string mpcaja)
        {
            TraerCollectorId();

            this.url = "https://api.mercadopago.com/instore/qr/seller/collectors/" + mpCollector + "/stores/" +
                        mpsucursal.Trim() + "/pos/" + mpcaja.Trim() + "/orders";


            this.detalle = detalle;

            TraerToken();
            this.accessToken = mpToken;


            

            //this.accessToken = "TEST-1533457854847182-070511-97706d0b5afacb65ecaf0a9a11b837ba-129768028";
            this.urlEscaneo = $"https://api.mercadopago.com/merchant_orders/search?external_reference={this.detalle}";

            //string urlGustavo = "https://api.mercadopago.com/instore/qr/seller/collectors/58003510/stores/SUC0010/pos/CAJA01/orders";
            //string accessTokenGustavo = "APP_USR-238366883478725-071108-313efcff2c390874b7a35e733abbbe8b-58003510";

            //
        }
        public GenerarOrden(string detalle, string sucursal)
        {
            Sucursal = sucursal;
            TraerSucursalCaja();

            TraerCollectorId();

            this.url = "https://api.mercadopago.com/instore/qr/seller/collectors/" + mpCollector +"/stores/" +
                        mpSucursal.Trim() + "/pos/" + mpCaja + "/orders";


            this.detalle = detalle;

            TraerToken();
            this.accessToken = mpToken;


            //this.accessToken = "TEST-1533457854847182-070511-97706d0b5afacb65ecaf0a9a11b837ba-129768028";
            this.urlEscaneo = $"https://api.mercadopago.com/merchant_orders/search?external_reference={this.detalle}";

            //string urlGustavo = "https://api.mercadopago.com/instore/qr/seller/collectors/58003510/stores/SUC0010/pos/CAJA01/orders";
            //string accessTokenGustavo = "APP_USR-238366883478725-071108-313efcff2c390874b7a35e733abbbe8b-58003510";

            //
        }


        public GenerarOrden(string sucursal)
        {
            Sucursal = sucursal;
            TraerSucursalCaja();

        }


        private void TraerSucursalCaja()
        {
            Console.WriteLine("Buscando Sucursal de Ksk");
            ConectarSQL conectar = new ConectarSQL();
            DataTable tabla = conectar.EjecutarConsulta($@"select Serie as Sucursal, 
                                RegPatronal as Caja from genSucursalesEmpr (nolock) where Sucursal = '{Sucursal}'");


            if (tabla.Rows.Count > 0)
            {
                mpSucursal = tabla.Rows[0][0].ToString().Trim();
                mpCaja = tabla.Rows[0][1].ToString().Trim();
                Console.WriteLine($"Sucursal {mpSucursal} y Caja {mpCaja}");
            }
            else
            {
                Generalidades.qFunctionalException.GenerarExcepcion("Esta Sucursal no tiene Caja de MP asociada");
                Console.WriteLine("Sucursal o Caja no encntradas");
            }

           
        }
        private void TraerToken()
        {
            Console.WriteLine("Buscando Token de Ksk");
            ConectarSQL conectar = new ConectarSQL();
            DataTable tabla = conectar.EjecutarConsulta($@"select cValor from genGlobales (nolock) where Nombre_Var = 'KSK_MP_Token'");

            if (tabla.Rows.Count > 0)
            {
                mpToken = tabla.Rows[0][0].ToString().Trim();
                Console.WriteLine($"Token {mpToken}");
                }
            else
            {
                mpToken = string.Empty;
                Console.WriteLine("Token no encontrado");
            }
        }

        private void TraerCollectorId()
        {
            Console.WriteLine("Buscando Collector de Ksk");
            ConectarSQL conectar = new ConectarSQL();
            DataTable tabla = conectar.EjecutarConsulta($@"select cValor from genGlobales (nolock) where Nombre_Var = 'KSK_MP_USERID'");

            if (tabla.Rows.Count > 0)
            {
                mpCollector = tabla.Rows[0][0].ToString().Trim();
                Console.WriteLine($"Collecctor {mpCollector} ");
            }
            else
            {
                mpCollector = string.Empty;
                Console.WriteLine("Collector no Encontrado");
            }
        }


        public async Task Borrar()
        {

            string urlBorrar = "https://api.mercadopago.com/instore/qr/seller/collectors/" + mpCollector  + "/pos/" +  mpCaja + "/orders";
           
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
        public async Task<bool> Escaneo(string comprobante)
        {


            string responseBody = string.Empty;
            dynamic responseObject = string.Empty;
            int contador = 0;
            int espera = 50;
            bool TeDi = false;

            while (contador <= espera)
            {
                await Task.Delay(1500);
                contador++;

                Console.WriteLine(contador.ToString());

                HttpClient client = new HttpClient();


                Console.WriteLine($"Pidiendo autorizacion en API con token {accessToken}");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

                Console.WriteLine($"Accediendo a la URL {urlEscaneo}");
                HttpResponseMessage response = await client.GetAsync(urlEscaneo);

                Console.WriteLine($"contenido{response.Content.ToString()}");

                if (response.IsSuccessStatusCode)
                {
                    responseBody = await response.Content.ReadAsStringAsync();
                    // Deserializa el JSON en un objeto anónimo
                    responseObject = JsonConvert.DeserializeObject<dynamic>(responseBody);

                    if (responseBody.Contains(comprobante))
                    {
                        var firstElement = responseObject.elements[0];
                        RespuestaId = firstElement.id.ToString();
                        string status = firstElement.status.ToString();


                        if (status == "closed")
                        {
                            return true;
                        }

                        if (status == "opened" && !TeDi)
                        {
                            //reinicio el contador para darle mas tiempo
                            contador = 1;
                            TeDi = true;
                        }

                    }

                }
                else
                {
                    Mensaje = "No se pudo llegar a la Api";
                    return false;

                }

            };

            Mensaje = "Llego al final del ciclo";
            return false;
        }
        public async Task<bool> Buscar()
        {
            string urlConsultar = "https://api.mercadopago.com/merchant_orders/search?external_reference=" + detalle;
            status = string.Empty;
            fecha = string.Empty;
            pay_status = string.Empty;

            monto = 0;
            //borro las ordenes por las dudas
            using (HttpClient client = new HttpClient())
            {

                string responseBody = string.Empty;
                dynamic responseObject = string.Empty;

                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                HttpResponseMessage response = await client.GetAsync(urlConsultar);
                if (response.IsSuccessStatusCode)
                {
                    responseBody = await response.Content.ReadAsStringAsync();
                    responseObject = JsonConvert.DeserializeObject<dynamic>(responseBody);
                    status = string.Empty;
                    monto = total;
                    pay_status = "Listo para Escanear";
                    fecha = DateTime.Now.ToLongDateString();



                    if (responseBody.Contains(detalle))
                    {
                        try
                        {
                            string montostr = string.Empty;
                            var firstElement = responseObject.elements[0];
                            status = firstElement.status.ToString();
                            fecha = firstElement.status.ToString();
                            RespuestaId = firstElement.id.ToString();
                            pay_status = "0";
                            fecha = DateTime.Now.ToLongDateString();
                            montostr = firstElement.total_amount.ToString();

                            if (status != "opened")
                            {
                                detalle = detalle + "-1";
                                pay_status = firstElement.payments[0]["status"].ToString();
                                fecha = firstElement.payments[0]["date_approved"].ToString();

                            }

                            monto = decimal.Parse(montostr);
                        }
                        catch (Exception ex)
                        {
                            return false;
                        }
                    }
                }
                else
                    return false;


                return true;
            }
        }

        public async Task<bool> Obtener()
        {
            return true;
        }
    }
}
