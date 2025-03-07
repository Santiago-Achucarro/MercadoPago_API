using Framework.Core;
using GeneralesExchange;
using KSKBE.MP;
using KSKBE.Varios;
using KSKExchange;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using VentasExchange;
using static VentasExchange.venClieHabitualActionEnum;

namespace KSKBE
{
    /// <summary>
    /// QBI:Utilizar esta sección para describir brevemente la clase espvenMovimientosConStockKSKGuardarAction
    /// </summary>
    /// <remarks>
    /// Esta clase implementa la acción "espvenMovimientosConStockKSKGuardarAction"
    ///
    /// Utilizar esta sección para documentar el funcionamiento 
    /// de la clase espvenMovimientosConStockKSKGuardarAction. No olvide de dar de
    /// alta la acción "espvenMovimientosConStockKSKGuardarAction" para que el Dispatcher
    /// sepa como ejecutarla.
    /// </remarks>
    public class espvenMovimientosConStockKSKGuardarAction : Framework.Core.IAction
    {
        /// <summary>
        /// Ejecuta la acción, utilizando ommand y el <c>Exchange</c> 
        /// (especializado para la acción que se está desarrollando)
        /// como parámetros, y opcionalmente devolviendo el resultado en
        /// <c>Response</c>.
        ///
        /// </summary>
        /// <param name="cmd">El comando con la información de contexto y
        /// parámetros necesarios para llevar a cabo la acción</param>
        /// <param name="exch">El request especializado para la acción actual
        /// según se describió en el "Asistente de Acciones".</param>

        public string mpSucursal;
        public string MensajeError;
        public decimal nCotizacion = 1;
        public bool esConTarjeta = false;
        decimal totalcob = 0;
        public Exchange Execute(Command cmd, Exchange exch)
        {
            VentasExchange.venMovimientosConStockActionExchange req = new VentasExchange.venMovimientosConStockActionExchange(exch);
            VentasExchange.venMovimientosConStockActionExchange res = new VentasExchange.venMovimientosConStockActionExchange();

            MensajeError = string.Empty;
            try
            {
                

                KSKCommon.espvenMovimientosConStockKSKDS ds = new KSKCommon.espvenMovimientosConStockKSKDS();
                ds.Merge(cmd.CommonDSEsp, false, System.Data.MissingSchemaAction.Ignore);

                TesoreriaExchange.tesCobranzasActionExchange exchCob = new TesoreriaExchange.tesCobranzasActionExchange(TesoreriaExchange.tesCobranzasActionEnum.EnumtesCobranzasAction.Guardar);
                

                decimal lTotalCobranza = 0;
                totalcob = 0;
                decimal TotalFactura = req.Importe;
                decimal diferencia = 0;

                //Gustavo 18/10/2024
                if (TotalFactura <= 0)
                    Generalidades.qFunctionalException.GenerarExcepcion("No se puede Facturar con Valor negativo o igual que 0");


                //Gustavo 14/05/2024
                if (req.Param.Principal[0].Vendedor_Id == "UNICO")
                    Generalidades.qFunctionalException.GenerarExcepcion("Por favor cambia el Vendedor antes de seguir");



                // Gustavo 14/07/2023 - solo si es factura controlo y genero cobranza
                if (req.Param.Principal[0].venTipoMov == "F" )
                {
                    if (req.Param.Cobranza.Count > 0)
                    { 
                        if(!req.Param.Cobranza[0].IsImporteNull())
                        {
                            if (req.Param.Cobranza[0].Cartera_Id == "MPAGO")
                            {
                                if (ds.Principal[0].MPEstado != "F")
                                {
                                    Generalidades.qFunctionalException.GenerarExcepcion("Te falta cobrar por MP");

                                }
                            }
                        }
                    }


                    // if (cmd.CodigoConsulta != "S" && (req.Param.Cobranza.Count == 0 || req.Param.Cobranza[0].IsImporteNull() || TotalFactura != req.Param.Cobranza.Sum(c => c.Importe)))
                    //if (cmd.CodigoConsulta != "S" && (req.Param.Cobranza.Count == 0 ||
                    //        req.Param.Cobranza[0].IsImporteNull() ||
                    //        Math.Abs(TotalFactura - req.Param.Cobranza.Sum(c => c.Importe)) > (decimal)0.99))
                    
                    if (cmd.CodigoConsulta != "S" && (req.Param.Cobranza.Count == 0 ||
                            req.Param.Cobranza[0].IsImporteNull()))
                    {

                        Generalidades.qQuestionException.GenerarExcepcion("No coincide el total de la factura $ <0> con el total de la cobranza $ <1>. ¿Continúa igual?", new object[] { req.Importe, req.Param.Cobranza.Sum(c => c.IsImporteNull() ? 0 : c.Importe) }, "S");

                    }

                    //foreach (var item in req.Param.Cobranza)
                    foreach (var item in ds.Identificadores)
                    {
                        
                        
                        
                        nCotizacion = 1;
                        if (item.Cartera_Id == "DOL")
                        {
                            GeneralesExchange.genTipoCambioActionExchange ocambio =
                                    new GeneralesExchange.genTipoCambioActionExchange(GeneralesExchange.genTipoCambioActionEnum.EnumgenTipoCambioAction.Datos);

                            ocambio.Moneda_Id = item.Cartera_Id;
                            ocambio.Empresa_Id = 1;
                            ocambio.Fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                            ocambio = new genTipoCambioActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ocambio, cmd));
                            nCotizacion = ocambio.CambioVenta == 0 ? 1 : ocambio.CambioVenta;
                        }


                        //totalcob += ( item.Importe * nCotizacion);
                        totalcob += item.Importe;
                            
                    }
                    if (Math.Abs(TotalFactura - totalcob) > (decimal)0.99)
                    {
                        if (cmd.CodigoConsulta != "S")
                            Generalidades.qQuestionException.GenerarExcepcion("No coincide el total de la factura $ <0> con el total de la cobranza $ <1>. ¿Continúa igual?", new object[] { req.Importe, totalcob }, "S");
                    }
                    nCotizacion = 1;
                    diferencia = 0;
                    //ver los identificadores con los que cobraste
                    ///si hay diferencia, agrego un renglon a la lista que tiene los identificadores de la cobrnza con la diferencia
                    if (req.Param.Cobranza.Count > 0)
                    {
                        if (!req.Param.Cobranza[0].IsImporteNull())
                        {
                            diferencia = TotalFactura - req.Param.Cobranza.Sum(c => c.Importe);

                            //Gustavo 12/09/2023 Tiene que ser menor que 10 sino hacia redondeo por todo!!!!
                            if (diferencia != 0 && Math.Abs(diferencia) < 10)
                            {
                                req.Param.Cobranza.AddCobranzaRow(req.Param.Cobranza.Count, "RED", "Redondeo", "EF", diferencia, 1, "", "", "", "", DateTime.Now, "", "", 0, "", 0, 0, 0, 0, 0, 0, 0);

                                //req.Param.Cobranza[0].Importe = req.Param.Cobranza[0].Importe + diferencia;
                            }
                        }
                    }
                    totalcob = totalcob + diferencia;
                    lTotalCobranza =  totalcob;

                }

                // gustavo 14/07/2023 - si es nota de credito me fijo si teiene comprobantes asociados
                if (req.Param.Principal[0].venTipoMov == "R")
                {
                    if (req.Param.venComprobAsoc[0].Segmento1N == 0)
                    {
                        Generalidades.qFunctionalException.GenerarExcepcion("Por favor asocie el comprobante");
                    }
                }

                // 09/06/2023 - Gustavo - Inicializo Variables Globales
                GeneralesExchange.genGlobalesActionExchange eGenGlobales =
                new GeneralesExchange.genGlobalesActionExchange(GeneralesExchange.genGlobalesActionEnum.EnumgenGlobalesAction.Datos);

                string clienteCF = string.Empty;
                string clienteRI = string.Empty;


                #region si el cliente es consumidor final
                if (ds.Principal[0].TipoCliente == "0" 
                        && ds.Principal[0].ClienteNuevo_Id != "" && ds.Principal[0].ClienteNuevo_Id != "0")
                {
                    // 09 / 06 / 2023 - Gustavo - Busco la variable Global
                    eGenGlobales.Nombre_Var = "ESPVENCLIENTECONSFINAL";
                    eGenGlobales.Empresa_Id = 1;
                    eGenGlobales = new GeneralesExchange.genGlobalesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eGenGlobales, cmd));
                    if (eGenGlobales.Existe)
                    {

                        clienteCF = eGenGlobales.cValor.Trim();
                       

                    }
                    else
                        clienteCF = "11111111";

                    // Es consumidor final, traigo los datos del CF entándar y le cambio el código de cliente //
                    VentasExchange.venClieHabitualActionExchange exchClieCF = new VentasExchange.venClieHabitualActionExchange(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos);
                    exchClieCF.Cliente_Id = clienteCF;
                    exchClieCF.Sucursal = 1;
                    exchClieCF = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchClieCF, cmd));

                    exchClieCF.Cliente_Id = ds.Principal[0].ClienteNuevo_Id;
                    exchClieCF.Cliente_Id_Nueva = exchClieCF.Cliente_Id;
                    // Estoy creando uno nuevo entonces en el código de cliente viene el número de DNI o CUIT //
                    exchClieCF.CUIT = exchClieCF.Cliente_Id;
                    // Si la cantidad de dígitos en < que 8, es DNI sino es CUIT //
                    //exchClieCF.TipoDoc = exchClieCF.CUIT.Trim().Length <= 8 ? "7" : "1";

                    // Gustavo 4/6/2024 - Para que acepte guardar mascars alfanumericas con mas caracteres
                    exchClieCF.TipoDoc = "7";

                    //exchClieCF.RazonSocial = ds.Principal[0].ClienteNuevo_Id;
                    exchClieCF.RazonSocial = ds.Principal[0].DescripcionClienteNuevo;

                    exchClieCF.EMail = ds.Principal[0].Email;
                    //exchClieCF.NombreFantasia = ds.Principal[0].ClienteNuevo_Id;
                    exchClieCF.NombreFantasia = ds.Principal[0].DescripcionClienteNuevo;


                    //16/08/2023 - Si no tiene el mail cargado no creo el contacto sino da error
                    if (ds.Principal[0].Email.Length > 5 && ds.Principal[0].Email.Contains("@"))
                    {
                        //borro todo lo que tiene para volver a insertarlos
                        exchClieCF.Param.grdContactos.Clear();
                        // Para la Version 3
                        //exchClieCF.Param.grdContactos.AddgrdContactosRow(0, 1, 1, ds.Principal[0].DescripcionClienteNuevo, "",
                        //ds.Principal[0].Email, ds.Principal[0].Celular, "", ds.Principal[0].Celular, true, false, false, "", false,"","");

                        //Version 1
                        exchClieCF.Param.grdContactos.AddgrdContactosRow(0, 1, 1, ds.Principal[0].DescripcionClienteNuevo, "",
                                ds.Principal[0].Email, ds.Principal[0].Celular, "", ds.Principal[0].Celular, true, false, false, "", false);

                    }
                    else
                    {
                        if (cmd.CodigoConsulta != "S")
                            Generalidades.qQuestionException.GenerarExcepcion("El mail <0> ingresado es incorrecto. ¿Continúa igual?", new object[] { ds.Principal[0].Email }, "S");

                    }

                    if (clienteCF == exchClieCF.Cliente_Id)
                        Generalidades.qFunctionalException.GenerarExcepcion($"El cliente CF no puede ser {clienteCF}");

                    exchClieCF.Action = VentasExchange.venClieHabitualActionEnum.GetAccionvenClieHabitualAction(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Guardar);
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(exchClieCF, cmd);
                    req.Cliente_Id = ds.Principal[0].ClienteNuevo_Id;
                }
                #endregion

                #region si el cliente es responsable inscrpito
                if (ds.Principal[0].TipoCliente == "1")
                {
                    

                    eGenGlobales.Nombre_Var = "ESPVENCLIENTERI";
                    eGenGlobales.Empresa_Id = 1;
                    eGenGlobales = new GeneralesExchange.genGlobalesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eGenGlobales, cmd));
                    if (eGenGlobales.Existe)
                        clienteRI = eGenGlobales.cValor.Trim();
                    else
                        clienteRI = "33333333333";


                    // Es RI, traigo los datos del RI entándar y le cambio en código de cliente //
                    VentasExchange.venClieHabitualActionExchange exchClie = new VentasExchange.venClieHabitualActionExchange(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos)
                    {
                        // cambio la plantilla
                        Cliente_Id = clienteRI,
                        Sucursal = 1
                    };
                    exchClie = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchClie, cmd));

                    exchClie.Cliente_Id = ds.Principal[0].ClienteNuevo_Id;
                    exchClie.Cliente_Id_Nueva = exchClie.Cliente_Id;

                    exchClie.CUIT = exchClie.Cliente_Id;
                    //exchClie.TipoDoc = exchClie.CUIT.Trim().Length <= 8 ? "7" : "1";

                    // gustavo 4/6/2024
                    exchClie.TipoDoc = "1";


                    exchClie.RazonSocial = ds.Principal[0].DescripcionClienteNuevo;
                    exchClie.EMail = ds.Principal[0].Email;

                    //16/08/2023 - Si no tiene el mail cargado no creo el contacto sino da error
                    if (ds.Principal[0].Email.Length > 5 && ds.Principal[0].Email.Contains("@"))
                    {
                        //borro todo lo que tiene para volver a insertarlos
                        exchClie.Param.grdContactos.Clear();

                        //Para la version 3
                        //exchClie.Param.grdContactos.AddgrdContactosRow(0, 1, 1, ds.Principal[0].DescripcionClienteNuevo, "",
                        //    ds.Principal[0].Email, ds.Principal[0].Celular, "", ds.Principal[0].Celular, true, false, false, "", false,"","");
                        
                        //Version 1
                        exchClie.Param.grdContactos.AddgrdContactosRow(0, 1, 1, ds.Principal[0].DescripcionClienteNuevo, "",
                            ds.Principal[0].Email, ds.Principal[0].Celular, "", ds.Principal[0].Celular, true, false, false, "", false);

                    }
                    else
                    {
                        if (cmd.CodigoConsulta != "S")
                            Generalidades.qQuestionException.GenerarExcepcion("El mail <0> ingresado es incorrecto. ¿Continúa igual?", new object[] { ds.Principal[0].Email }, "S");

                    }




                    if (clienteRI== exchClie.Cliente_Id)
                        Generalidades.qFunctionalException.GenerarExcepcion($"El cliente RI no puede ser {clienteRI}");


                    exchClie.Action = venClieHabitualActionEnum.GetAccionvenClieHabitualAction(venClieHabitualActionEnum.EnumvenClieHabitualAction.Guardar);
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(exchClie, cmd);
                    req.Cliente_Id = ds.Principal[0].ClienteNuevo_Id;
                }
                #endregion
                //Gustavo 09/06/2023 -- busco el cliente que acabo de guardar arriba para traer el identyty que tiene y guardar en el especial
                venClieHabitualActionExchange exchClieAux = new venClieHabitualActionExchange(EnumvenClieHabitualAction.Datos)
                {
                    Cliente_Id = req.Cliente_Id,
                    Sucursal = 1
                };
                exchClieAux = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchClieAux, cmd));
                KSKDAL.espvenClieHabitualKSK.Guardar(exchClieAux.genEntidades, exchClieAux.Sucursal, ds.Principal[0].Celular,
                    ds.Principal[0].Mes, ds.Principal[0].Dia, ds.Principal[0].Instagram, ds.Principal[0].Youtube, ds.Principal[0].Linkedin,
                    ds.Principal[0].Facebook, cmd.ConnectionString);



                VentasBE.venMovimientosConStockGuardarAction actionBE = new VentasBE.venMovimientosConStockGuardarAction();


                req.LlamarAlWSFE = false;

                // Gustavo 7/9/2023 - esto es para que podamos hacer el update del documetno de afip en el genasisegmento
                //req.Posteado = false;  
                //------------------------------------------------------------------------------------------------------

                

                Console.WriteLine("Por Guardar la Factura");
                req = new VentasExchange.venMovimientosConStockActionExchange(actionBE.Execute(cmd, req));
                Console.WriteLine("Factura Guardada");

                // Gustavo 7/9/2023 - Para que se postee la cobranza
                //req.Posteado = true; 
                // -------------------------------------------------


                if (lTotalCobranza > 0)
                {
                    // Armo la cobranza //


                    string lObs = "Cobranza Factura " + req.Segmento1C + "-" + req.Segmento2C + "-" + req.Segmento3C + "-" + req.Segmento1N.ToString() + " " + req.Cliente_Id + "-" + req.NombreFantasia;

                    exchCob.Param.Principal.AddPrincipalRow(cmd.Empresa_Id, "TES", 0, 0, 0, 0, "", "", "", "", 0, "I", req.Fecha, 
                            GeneralesValidacion.FechaBaseDatos.GetFechaServer(cmd), 
                            req.Moneda_Id, "", req.Cambio, 1, false, lObs, req.Posteado, 
                            "frmTesCobranzas", "", "COB", "", req.Fecha, req.Cliente_Id, "", "", "", 
                            lTotalCobranza, lTotalCobranza, req.Importe, false, lTotalCobranza / req.Cambio, 
                            lTotalCobranza / req.Cambio, "", 0, false);

                    exchCob.Param.Principal[0].Delete();
                    exchCob.Param.Principal.AcceptChanges();


                    int i = 0;
                    DataRow datostarjeta;
                    decimal nImporte = 0;
                    lTotalCobranza = 0;
                    ds.Identificadores.Where(x => x.Importe != 0).ToList().ForEach(d =>
//                    req.Param.Cobranza.ToList().ForEach(d =>
                    {
                        // 05/07/2024 -  para buscar cotizacion dolar si es que paga en dolares
                        nCotizacion = 1;
                        nImporte = 0;
                        if (d.Cartera_Id == "DOL")
                        {
                            GeneralesExchange.genTipoCambioActionExchange oGenTipoCambio =
                        new GeneralesExchange.genTipoCambioActionExchange(GeneralesExchange.genTipoCambioActionEnum.EnumgenTipoCambioAction.Datos);


                            oGenTipoCambio.Moneda_Id = "DOL";
                            oGenTipoCambio.Empresa_Id = 1;
                            oGenTipoCambio.Fecha = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                            oGenTipoCambio = new genTipoCambioActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(oGenTipoCambio, cmd));
                            nCotizacion = oGenTipoCambio.CambioVenta == 0 ? 1 : oGenTipoCambio.CambioVenta;

                            
                        }

                        //nImporte = d.Importe * nCotizacion;
                        nImporte = d.Importe;
                        lTotalCobranza += nImporte;

                        TesoreriaExchange.tesIdentificaActionExchange exchId = TesoreriaValidacion.tesIdentifica.Existe(d.Cartera_Id, cmd);


                        #region datos Cupon
                        //busco el cupon
                        string NroAutorizacion = string.Empty;
                        int NroTarjeta = 0;
                        int NroCuotas = 0;
                        int NroCupon = 0;
                        int NroLote = 0;

                        if (d.TipoCartera == "T3")
                        {
                            datostarjeta = ds.Identificadores.First(x => x.Cartera_Id == d.Cartera_Id);
                            
                            
                            try
                            {
                                d.T3Cupon = (int)datostarjeta["T3Cupon"];
                            }
                            catch (Exception)
                            {

                                d.T3Cupon = 0;
                            }
                            try
                            {
                                d.T3Cuotas = (int)datostarjeta["T3Cuotas"];

                            }
                            catch (Exception)
                            {

                                d.T3Cuotas = 0;
                            }
                            try
                            {
                                d.T3Lote = (int)datostarjeta["T3Lote"];

                            }
                            catch (Exception)
                            {

                                d.T3Lote = 0;
                            }
                            try
                            {
                                d.T3Comercio = (int)datostarjeta["T3Comercio"];

                            }
                            catch (Exception)
                            {

                                d.T3Comercio = 0;
                            }
                            try
                            {

                                d.T3Promocion =  (int)datostarjeta["T3Promocion"];
                            }
                            catch (Exception)
                            {

                                d.T3Promocion = 0;
                            }
                            try
                            {
                                    
                                d.T3NroTarjeta = (int)datostarjeta["T3NroTarjeta"];
                            }
                            catch (Exception)
                            {

                                d.T3NroTarjeta = 0;
                            }
                            try
                            {

                                d.DescripcionPromocion = datostarjeta["DescripcionPromocion"].ToString();
                            }
                            catch (Exception)
                            {

                                d.DescripcionPromocion = string.Empty;
                            }
                            NroAutorizacion = d.T3Promocion.ToString() + " * " + d.DescripcionPromocion;
                            NroCuotas = d.T3Cuotas;
                            NroCupon = d.T3Cupon;
                            NroLote = d.T3Lote;
                            NroTarjeta = d.T3NroTarjeta;
                        }
                        #endregion
                        var nImporteOriginal = nImporte;
                        var sMoneda = "PES";
                        if (d.Cartera_Id == "DOL")
                        {
                            nImporteOriginal = nImporte / nCotizacion;
                            sMoneda = "DOL";
                        }

        

                        // si la moneda es DOL el parametro importeOriginal deberia ir con el valor en dolares
                        // y el valor Importe va con el valor pasado a pesos (d.Importe), pero no funciona porque me da mal el asiento
                        //asi que paso los 2 en pesos
        
                        exchCob.Param.Debe.AddDebeRow(0, ++i, d.Cartera_Id, "", nImporteOriginal, nImporte, nCotizacion, sMoneda, "",
                            exchId.Cuenta_Id, "", exchId.Centro1_Id, "", exchId.Centro2_Id, "", 1, "TRM", exchId.TipoCartera, 0, 0, 0, "",
                            "", 0, 0, 0, Generalidades.Nulls.NullDate, "", "", "", "", "", "", 0, "", "", "", "",
                            0, Generalidades.Nulls.NullDate, "", "", 0, "C", req.Cliente_Id, "", "", "", 0,
                            Generalidades.Nulls.NullDate, Generalidades.Nulls.NullDate, "", "", "", "", "", "", "", "", "", "", "", "", 0, "",
                            false, "", 0, "", 0, "", "", 0, 0, 0, 0, "", "", "", "", 0, 0, 0, 0, 0, 0, "", 0, "", 0, "", "", "", "", "",
                           "", "", "", "", 0, 0, "", "", "", NroCuotas, NroCupon.ToString(), NroLote, 0, NroAutorizacion,
                            NroTarjeta.ToString(), "","");
                        
                    });


                    //si hay diferencia agrego un renglon mas con el redondeo porque sino te da asiento desbalanceado
                    if(diferencia != 0)
                    {
                        TesoreriaExchange.tesIdentificaActionExchange exchId = TesoreriaValidacion.tesIdentifica.Existe("RED", cmd);

                        exchCob.Param.Debe.AddDebeRow(0, ++i, "RED", "", diferencia, diferencia, 1, "PES", "",
                            exchId.Cuenta_Id, "", exchId.Centro1_Id, "", exchId.Centro2_Id, "", 1, "TRM", exchId.TipoCartera, 0, 0, 0, "",
                            "", 0, 0, 0, Generalidades.Nulls.NullDate, "", "", "", "", "", "", 0, "", "", "", "",
                            0, Generalidades.Nulls.NullDate, "", "", 0, "C", req.Cliente_Id, "", "", "", 0,
                            Generalidades.Nulls.NullDate, Generalidades.Nulls.NullDate, "", "", "", "", "", "", "", "", "", "", "", "", 0, "",
                            false, "", 0, "", 0, "", "", 0, 0, 0, 0, "", "", "", "", 0, 0, 0, 0, 0, 0, "", 0, "", 0, "", "", "", "", "",
                           "", "", "", "", 0, 0, "", "", "", 1, "", 0, 0, "", "", "", "");
                    }



                    //exchCob.Param.Haber.AddHaberRow(0, ++i, "CLI", "", req.Importe, req.Importe, req.Cambio, req.Moneda_Id, "", req.CtaClientes, "", "", "", "", "", 2, "CLI", "RE", 0, 0, 0, "", "", 0, 0, 0, Generalidades.Nulls.NullDate, "", "", "", "", "", "", 0, "", "", "", "", 0, Generalidades.Nulls.NullDate, "", "", 0, "C", "", "", "", 0, Generalidades.Nulls.NullDate, Generalidades.Nulls.NullDate, "", "", "", "", "", "", "", "", "", "", "", "", 0, "", false, "", 0, "", 0, "", "", 0, 0, 0, 0, "", "", "", "", 0, 0, 0, 0, 0, 0, "", 0, "", 0, "", "", "", "", "", "", "", "", "", 0);
                    lTotalCobranza = lTotalCobranza + diferencia;

                    exchCob.Param.FactClientes.AddFactClientesRow("", req.Fecha, req.Moneda_Id, "", req.Cambio,
                            lTotalCobranza, lTotalCobranza, lTotalCobranza, req.venMovimientos, req.CtaClientes,
                            lTotalCobranza, req.Cambio, 1, true, "", "CLI", req.Fecha);



                    Console.WriteLine("Guardando la Cobranza");
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(exchCob, cmd);
                    Console.WriteLine("Cobranza Guardada");
                   


                } // Fin if(totalCobranza...)

                if (!ds.Principal[0].Comanda)
                {
                    // Si es factura llamo al ws //
                    req.Action = VentasExchange.venMovimientosConStockActionEnum.GetAccionvenMovimientosConStockAction
                             (VentasExchange.venMovimientosConStockActionEnum.EnumvenMovimientosConStockAction.LlamarAlWebServiceFE);

                    req = new VentasExchange.venMovimientosConStockActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                        (new Exchange(req), cmd));
                }



                Console.WriteLine($"Venmovimientos:{req.venMovimientos}");
                if (MensajeError.Length > 0)
                {
                    Console.WriteLine("Antes de hacer el rollback");
                    Generalidades.qFunctionalException.GenerarExcepcion(MensajeError);
                    Console.WriteLine("Rollback realizado");
                }


                // SolicitarCAESuccess es SP


                #region fin Proceso
                ds.Identificadores.Clear();
                ds.Promociones.Clear();
                ds.Cuotas.Clear();
                ds.AcceptChanges();


                req.Param.Cobranza.Clear();
                req.Param.Cobranza.AcceptChanges();

                req.Existe = true;
                Generalidades.Especializacion.UnirDatatSets(req.Param, ds);

                return new Exchange(req);
                #endregion
            }
            #region Catch

            catch (FaultException<QuestionFault> ex)
            {
                throw ex;
            }
            catch (FaultException<FunctionalFault> ex)
            {
                    throw ex;
            }
            catch (Exception ex)
            {
                //Generalidades.qTechnicalException.GenerarExcepcion(ex.Message);
                throw new Exception("Error al generar Tecnical Exception");
            }

            #endregion

        }
    }
}

