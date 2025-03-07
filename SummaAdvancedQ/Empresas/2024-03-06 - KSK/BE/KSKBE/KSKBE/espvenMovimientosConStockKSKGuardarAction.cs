using Framework.Core;
using GeneralesExchange;
using KSKBE.MP;
using Newtonsoft.Json;
using System;
using System.Data;
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
        /// Ejecuta la acción, utilizando el Command y el <c>Exchange</c> 
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
                decimal TotalFactura = req.Importe;


                // Gustavo 14/07/2023 - solo si es factura controlo y genero cobranza
                if (req.Param.Principal[0].venTipoMov == "F")
                {


                    // if (cmd.CodigoConsulta != "S" && (req.Param.Cobranza.Count == 0 || req.Param.Cobranza[0].IsImporteNull() || TotalFactura != req.Param.Cobranza.Sum(c => c.Importe)))
                    if (cmd.CodigoConsulta != "S" && (req.Param.Cobranza.Count == 0 ||
                            req.Param.Cobranza[0].IsImporteNull() ||
                            Math.Abs(TotalFactura - req.Param.Cobranza.Sum(c => c.Importe)) > (decimal)0.99))


                        Generalidades.qQuestionException.GenerarExcepcion("No coincide el total de la factura $ <0> con el total de la cobranza $ <1>. ¿Continúa igual?", new object[] { req.Importe, req.Param.Cobranza.Sum(c => c.IsImporteNull() ? 0 : c.Importe) }, "S");


                    //ver los identificadores con los que cobraste
                    ///si hay diferencia, agrego un renglon a la lista que tiene los identificadores de la cobrnza con la diferencia
                    var diferencia = TotalFactura - req.Param.Cobranza.Sum(c => c.Importe);

                    //Gustavo 12/09/2023 Tiene que ser menor que 10 sino hacia redondeo por todo!!!!
                    if (diferencia != 0 && diferencia < 10)
                    {
                        req.Param.Cobranza.AddCobranzaRow(req.Param.Cobranza.Count, "RED", "Redondeo", "EF", diferencia, 1, "", "", "", "", DateTime.Now, "", "", 0, "", 0, 0, 0, 0, 0, 0, 0);

                        //req.Param.Cobranza[0].Importe = req.Param.Cobranza[0].Importe + diferencia;
                    }
                    lTotalCobranza = req.Param.Cobranza.Sum(c => c.IsImporteNull() ? 0 : c.Importe);
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
                string clienteDefault = string.Empty;


                #region si el cliente es consumidor final
                if (ds.Principal[0].TipoCliente == "0" && ds.Principal[0].ClienteNuevo_Id != "" && ds.Principal[0].ClienteNuevo_Id != "0")
                {
                    // 09 / 06 / 2023 - Gustavo - Busco la variable Global
                    eGenGlobales.Nombre_Var = "ESPVENCLIENTECONSFINAL";
                    eGenGlobales.Empresa_Id = 1;
                    eGenGlobales = new GeneralesExchange.genGlobalesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eGenGlobales, cmd));
                    if (eGenGlobales.Existe)
                        clienteDefault = eGenGlobales.cValor.Trim();
                    else
                        clienteDefault = "11111111";

                    // Es consumidor final, traigo los datos del CF entándar y le cambio el código de cliente //
                    VentasExchange.venClieHabitualActionExchange exchClieCF = new VentasExchange.venClieHabitualActionExchange(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos);
                    exchClieCF.Cliente_Id = clienteDefault;
                    exchClieCF.Sucursal = 1;
                    exchClieCF = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchClieCF, cmd));

                    exchClieCF.Cliente_Id = ds.Principal[0].ClienteNuevo_Id;
                    exchClieCF.Cliente_Id_Nueva = exchClieCF.Cliente_Id;
                    // Estoy creando uno nuevo entonces en el código de cliente viene el número de DNI o CUIT //
                    exchClieCF.CUIT = exchClieCF.Cliente_Id;
                    // Si la cantidad de dígitos en < que 8, es DNI sino es CUIT //
                    exchClieCF.TipoDoc = exchClieCF.CUIT.Trim().Length <= 8 ? "7" : "1";

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
                        exchClieCF.Param.grdContactos.AddgrdContactosRow(0, 1, 1, ds.Principal[0].DescripcionClienteNuevo, "",
                            ds.Principal[0].Email, ds.Principal[0].Celular, "", ds.Principal[0].Celular, true, false, false, "", false);
                    }
                    else
                    {
                        if (cmd.CodigoConsulta != "S")
                            Generalidades.qQuestionException.GenerarExcepcion("El mail <0> ingresado es incorrecto. ¿Continúa igual?", new object[] { ds.Principal[0].Email }, "S");

                    }



                    exchClieCF.Action = VentasExchange.venClieHabitualActionEnum.GetAccionvenClieHabitualAction(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Guardar);
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(exchClieCF, cmd);
                    req.Cliente_Id = ds.Principal[0].ClienteNuevo_Id;
                }
                #endregion

                #region si el cliente es responsable inscrpito
                if (ds.Principal[0].TipoCliente == "1")
                {
                    // Es RI, traigo los datos del RI entándar y le cambio en código de cliente //
                    VentasExchange.venClieHabitualActionExchange exchClie = new VentasExchange.venClieHabitualActionExchange(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos)
                    {
                        // cambio la plantilla
                        Cliente_Id = "33333333333",
                        Sucursal = 1
                    };
                    exchClie = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchClie, cmd));

                    exchClie.Cliente_Id = ds.Principal[0].ClienteNuevo_Id;
                    exchClie.Cliente_Id_Nueva = exchClie.Cliente_Id;

                    exchClie.CUIT = exchClie.Cliente_Id;
                    exchClie.TipoDoc = exchClie.CUIT.Trim().Length <= 8 ? "7" : "1";
                    exchClie.RazonSocial = ds.Principal[0].DescripcionClienteNuevo;
                    exchClie.EMail = ds.Principal[0].Email;

                    //16/08/2023 - Si no tiene el mail cargado no creo el contacto sino da error
                    if (ds.Principal[0].Email.Length > 5 && ds.Principal[0].Email.Contains("@"))
                    {
                        //borro todo lo que tiene para volver a insertarlos
                        exchClie.Param.grdContactos.Clear();
                        exchClie.Param.grdContactos.AddgrdContactosRow(0, 1, 1, ds.Principal[0].DescripcionClienteNuevo, "",
                            ds.Principal[0].Email, ds.Principal[0].Celular, "", ds.Principal[0].Celular, true, false, false, "", false);
                    }
                    else
                    {
                        if (cmd.CodigoConsulta != "S")
                            Generalidades.qQuestionException.GenerarExcepcion("El mail <0> ingresado es incorrecto. ¿Continúa igual?", new object[] { ds.Principal[0].Email }, "S");

                    }




                    exchClie.Action = VentasExchange.venClieHabitualActionEnum.GetAccionvenClieHabitualAction(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Guardar);
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

                    exchCob.Param.Principal.AddPrincipalRow(cmd.Empresa_Id, "TES", 0, 0, 0, 0, "", "", "", "", 0, "I", req.Fecha, GeneralesValidacion.FechaBaseDatos.GetFechaServer(cmd), req.Moneda_Id, "", req.Cambio, 1, false, lObs, req.Posteado, "frmTesCobranzas", "", "COB", "", req.Fecha, req.Cliente_Id, "", "", "", lTotalCobranza, lTotalCobranza, req.Importe, false, lTotalCobranza / req.Cambio, lTotalCobranza / req.Cambio, "", 0, false);
                    exchCob.Param.Principal[0].Delete();
                    exchCob.Param.Principal.AcceptChanges();

                    int i = 0;
                    req.Param.Cobranza.ToList().ForEach(d =>
                    {
                        TesoreriaExchange.tesIdentificaActionExchange exchId = TesoreriaValidacion.tesIdentifica.Existe(d.Cartera_Id, cmd);

                        exchCob.Param.Debe.AddDebeRow(0, ++i, d.Cartera_Id, "", d.Importe, d.Importe, req.Cambio, req.Moneda_Id, "", exchId.Cuenta_Id, "", exchId.Centro1_Id, "", exchId.Centro2_Id, "", 1, "TRM", exchId.TipoCartera, 0, 0, 0, "", "", 0, 0, 0, Generalidades.Nulls.NullDate, "", "", "", "", "", "", 0, d.CTBanco_Id, "", d.CTClearing, "", 0, d.CTFechaVencimiento, d.CTsucBanco, d.CTcuentaBanco, d.CTnumCheque, "C", req.Cliente_Id, "", "", "", 0, Generalidades.Nulls.NullDate, Generalidades.Nulls.NullDate, "", "", "", "", "", "", "", "", "", "", "", "", 0, "", false, "", 0, "", 0, "", "", 0, 0, 0, 0, "", "", "", "", 0, 0, 0, 0, 0, 0, "", 0, "", 0, "", "", "", "", "", "", "", "", "", 0, 0, "", "", "", d.T3Cuotas, ds.Principal[0].T3Cupon.ToString(), ds.Principal[0].T3Lote, 0, "", "", "", "");
                    });

                    //exchCob.Param.Haber.AddHaberRow(0, ++i, "CLI", "", req.Importe, req.Importe, req.Cambio, req.Moneda_Id, "", req.CtaClientes, "", "", "", "", "", 2, "CLI", "RE", 0, 0, 0, "", "", 0, 0, 0, Generalidades.Nulls.NullDate, "", "", "", "", "", "", 0, "", "", "", "", 0, Generalidades.Nulls.NullDate, "", "", 0, "C", "", "", "", 0, Generalidades.Nulls.NullDate, Generalidades.Nulls.NullDate, "", "", "", "", "", "", "", "", "", "", "", "", 0, "", false, "", 0, "", 0, "", "", 0, 0, 0, 0, "", "", "", "", 0, 0, 0, 0, 0, 0, "", 0, "", 0, "", "", "", "", "", "", "", "", "", 0);

                    exchCob.Param.FactClientes.AddFactClientesRow("", req.Fecha, req.Moneda_Id, "", req.Cambio,
                            lTotalCobranza, lTotalCobranza, lTotalCobranza, req.venMovimientos, req.CtaClientes,
                            lTotalCobranza, req.Cambio, 1, true, "", "CLI", req.Fecha);



                    //Gustavo 06 / 11 / 2023 - Antes de guardar la cobranza me fijo si es mercado pago y cobro

                    //// Llamo al metodo generar, el metodo generar vuelve al front y vemos si despues retoma aca
                    //if (req.Param.Cobranza[0].Cartera_Id == "MPAGO")
                    //{
                    //    ds.Principal[0].MPEstado = string.Empty;

                    //    Console.WriteLine("Generando orden de MP");
                    //    //esto busca la sucursal y la caja de MP segun la sucursal de summa
                    //    GenerarOrden mp = new GenerarOrden(req.Segmento2C);
                    //    // ya tengo la sucursal y caja de mercado pago llenas en mp.mpSucursal y mp.mpCaja


                    //    //genero la orden --- pasa una vez sola 
                    //    string external_reference = req.Segmento1C + "-" + req.Segmento3C + "-" + req.Segmento2C + "-" + req.Segmento1N.ToString();

                    //    GenerarOrden MpOrden = new GenerarOrden(req.Param.Principal[0].Importe, external_reference, mp.mpSucursal, mp.mpCaja);

                    //    ds.Principal[0].Comprobante = external_reference;


                    //    //Console.WriteLine("Generando Orden");
                    //    //if (MpOrden.Generar().Result)
                    //    //    {
                    //    //        ds.Principal[0].MPMensaje = "Orden Generada";
                    //    //        Console.WriteLine("Orden Generada");
                    //    //}


                    //    //ahora espero el escaneo
                    //    ConectarSQL conectar = new ConectarSQL();
                    //    Console.WriteLine("Buscando Sucursal de Ksk");
                    //    DataTable tabla = conectar.EjecutarConsulta($@"select Serie as Sucursal, 
                    //            RegPatronal as Caja from genSucursalesEmpr (nolock) where Sucursal = '{req.Segmento2C}'");

                    //    string mpsucursal = string.Empty;
                    //    string mpcaja = string.Empty;

                    //    if (tabla.Rows.Count > 0)
                    //    {
                    //        mpsucursal = tabla.Rows[0][0].ToString();
                    //        mpcaja = tabla.Rows[0][1].ToString();
                    //    }
                    //    else
                    //        Generalidades.qFunctionalException.GenerarExcepcion("Esta Sucursal no tiene Caja de MP asociada");



                    //    Console.WriteLine("Antes de Detectar Escaneo");
                    //    GenerarOrden MpOrdenEsc = new GenerarOrden(ds.Principal[0].Comprobante, mpsucursal, mpcaja);
                    //    bool escaneado = MpOrdenEsc.Escaneo(ds.Principal[0].Comprobante).Result;

                    //    if (escaneado)
                    //    {
                    //        Console.WriteLine("Escaneo Detectado");
                    //        ds.Principal[0].MPEstado = "F";
                    //        MensajeError = string.Empty;


                    //    }
                    //    else
                    //    {
                    //        // por ahora viene aca si no escaneo en los 20 segundos que le di
                    //        ds.Principal[0].MPEstado = "N";
                    //        Console.WriteLine("No se detecto escaneo");
                    //        MensajeError = "No se detecto escaneo";
                    //    }
                    //}

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

                Console.WriteLine("Buscando si hay error");
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
                Generalidades.qTechnicalException.GenerarExcepcion(ex.Message);
                throw new Exception("Error al generar Tecnical Exception");
            }

            #endregion

        }
    }
}

