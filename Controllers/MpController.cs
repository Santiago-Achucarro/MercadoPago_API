using System;
using System.Linq;
using System.Threading.Tasks;
using MercadoPago_API.Model.System.DTO;
using MercadoPago_API.Persistence;
using MercadoPago_API.Helpers;
using Microsoft.AspNetCore.Mvc;
using MercadoPago.Client.Preference;
using MercadoPago.Config;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using MercadoPago_API.Model.App.Scaffolded;

namespace MercadoPago_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MpController : ControllerBase
    {
        private readonly MpConfig _mpConfig;
        private readonly HttpClient _httpClient;
        private readonly AppDbContext _appDbContext;
        public MpController(MpConfig mpConfig, HttpClient httpClient, AppDbContext appDbContext)
        {
            _mpConfig = mpConfig;
            _httpClient = httpClient;
            _appDbContext = appDbContext;
        }

        [HttpPost("preferencia")]
        public async Task<ActionResult> CrearPreferencia([FromBody] PreferenciaItemsMpDTO preferencia)
        {
            MercadoPagoConfig.AccessToken = _mpConfig.ObtenerAccessToken();

            var preferenceItems = preferencia.Items.Select(item => new PreferenceItemRequest
            {
                Title = item.Title,
                UnitPrice = item.UnitPrice,
                Quantity = item.Quantity
            }).ToList();

            // Crear la preferencia
            var request = new PreferenceRequest
            {
                NotificationUrl = preferencia.NotificationUrl,
                Items = preferenceItems
            };

            var client = new PreferenceClient();
            var preference = await client.CreateAsync(request);

            return Ok(preference);
        }
        [HttpPost("notificarpago")]
        public async Task<IActionResult> NotificatePago([FromBody] dynamic eventData)
        {
            Console.WriteLine($"Este es data => {eventData}");

            if (eventData.topic == "merchant_order")
            {
                var urlMerchantOrder = eventData.resource;
                Console.WriteLine($"Esta es la url de Merchant Order => {urlMerchantOrder}");

                // Validar que el `UrlMerchantOrder` no sea nulo
                if (urlMerchantOrder == null)
                {
                    return BadRequest("MerchantOrder Link is missing.");
                }

                // Llamar a la función ObtenerPago (si es necesaria)
                try
                {
                    var resultado = await ObtenerPago(urlMerchantOrder.ToString());
                    return Ok(resultado);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error llamando a ObtenerPago: {ex.Message}");
                    return StatusCode(500, new { error = "Error interno al procesar el pago." });
                }
            }

            return Ok(eventData);
        }

        [HttpPost("obtenerpago")]
        public async Task<IActionResult> ObtenerPago(string urlMerchantOrder)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _mpConfig.ObtenerAccessToken());

            var responseMerchantOrder = await _httpClient.GetAsync(urlMerchantOrder);
            if (!responseMerchantOrder.IsSuccessStatusCode)
            {
                return StatusCode(400, new { error = "Error al procesar el evento de pago." });
            }

            var MerchantOrderJSON = await responseMerchantOrder.Content.ReadAsStringAsync();
            var MerchantOrder = JsonConvert.DeserializeObject<dynamic>(MerchantOrderJSON);
            Console.WriteLine($"Este es el MerchantOrder => {MerchantOrder}");

            // Inicializar valores predeterminados para evitar excepciones
            var MerchantOrderPayment = (MerchantOrder.payments != null && MerchantOrder.payments.Count > 0)
                ? MerchantOrder.payments[0]
                : null;

            try
            {
                // Crear la entidad para insertar en la tabla `Hdr`
                var paymentHeader = new IIMercadoPagoHdr
                {
                    PaymentId = MerchantOrderPayment?.id, // Asigna null si no hay pago
                    MerchantOrder = MerchantOrder.id
                };

                // Crear la entidad para insertar en la tabla `Body`
                var paymentBody = new IIMercadoPagoBody
                {
                    MerchantOrder = MerchantOrder.id,
                    PaymentId = MerchantOrderPayment?.id, // Asigna null si no hay pago
                    Status = MerchantOrder.status,
                    ExternalReference = MerchantOrder.external_reference,
                    TransactionAmount = MerchantOrderPayment != null ? (decimal)MerchantOrderPayment.transaction_amount : 0,
                    TotalPaidAmount = MerchantOrderPayment != null ? (decimal)MerchantOrderPayment.total_paid_amount : 0,
                    DateCreated = MerchantOrder.date_created  // Usa la fecha actual si no hay pago
                };

                // Insertar en tabla `Hdr`
                _appDbContext.IIMercadoPagoHdrs.Add(paymentHeader);
                await _appDbContext.SaveChangesAsync();
                Console.WriteLine("Registro insertado correctamente en II_MercadoPago_Header.", paymentHeader);

                // Insertar en tabla `Body`
                _appDbContext.IIMercadoPagoBodies.Add(paymentBody);
                await _appDbContext.SaveChangesAsync();
                Console.WriteLine("Registro insertado correctamente en II_MercadoPago_Body.", paymentBody);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar en la base de datos: {ex.Message}");
                return StatusCode(500, new { error = "Ocurrió un error al guardar los datos del pago." });
            }

            return Ok(new { message = "Evento procesado correctamente.", MerchantOrder });
        }

    }



}


