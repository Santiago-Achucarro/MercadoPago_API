using System;
using System.Collections.Generic;
using System.Linq;
using VentasCommon;

namespace VentasFEEventos
{
    public class venFacturacionPedido
    {

        [Generalidades.QFuncion_Condicion]
        public string FacturaSinEnt(VentasCommon.venFacturacionPedidoDS exch, Framework.Core.Command cmd)
        {

            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
                new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));
            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.AdmiteFactsinEntr)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(VentasCommon.venFacturacionPedidoDS exch, Framework.Core.Command cmd)
        {
            GeneralesExchange.genEmpresasActionExchange ExcEmp =
               new GeneralesExchange.genEmpresasActionExchange(GeneralesExchange.genEmpresasActionEnum.EnumgenEmpresasAction.Datos);

            ExcEmp.Empresa_Id = "";
            ExcEmp.genEmpresas = cmd.Empresa_Id;
            ExcEmp = new GeneralesExchange.genEmpresasActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcEmp, cmd));

            if (ExcEmp.Existe)
            {
                if (ExcEmp.UsaCantidadAlterna)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string Extranjero(VentasCommon.venFacturacionPedidoDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venClieHabitualActionExchange ExcVen =
                    new VentasExchange.venClieHabitualActionExchange(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos);
            ExcVen.Cliente_Id = exch.Principal[0].Cliente_Id;
            ExcVen.Sucursal = exch.Principal[0].Sucursal;
            ExcVen = new VentasExchange.venClieHabitualActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVen, cmd));

            if (ExcVen.Existe)
            {
                if (ExcVen.Dominio_Id == cmd.Dominio_Id)
                    return "N";
                else
                    return "S";

            }

            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string PideCambio(VentasCommon.venFacturacionPedidoDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
               new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));
            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.PideCambio)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";

        }

        [Generalidades.QFuncion_Condicion]
        public string GeneroNC(VentasCommon.venFacturacionPedidoDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Segmento1NNC != 0)
                return "S";
            return "N";

        }
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarPdfFactura(VentasCommon.venFacturacionPedidoDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venMovimientosImprimirActionExchange eMov =
                  new VentasExchange.venMovimientosImprimirActionExchange(VentasExchange.venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Datos)
                  {
                      Segmento_Id = exch.Principal[0].Segmento_IdFact,
                      Segmento1N = exch.Principal[0].Segmento1NFact,
                      Segmento2N = exch.Principal[0].Segmento2NFact,
                      Segmento3N = exch.Principal[0].Segmento3NFact,
                      Segmento4N = exch.Principal[0].Segmento4NFact,
                      Segmento1C = exch.Principal[0].Segmento1CFact,
                      Segmento2C = exch.Principal[0].Segmento2CFact,
                      Segmento3C = exch.Principal[0].Segmento3CFact,
                      Segmento4C = exch.Principal[0].Segmento4CFact
                  };
            eMov = new VentasExchange.venMovimientosImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            if (!eMov.Existe)
            {

                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Movimiento");

            }
            if (eMov.PDF == "")
                Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");

            return Generalidades.Archivos.ConvertirADatasetDownload("PDF", eMov.NombreArchivo + ".pdf", false, "pdf",
                        eMov.PDF);

        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarXmlFactura(VentasCommon.venFacturacionPedidoDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venMovimientosImprimirActionExchange eMov =
                     new VentasExchange.venMovimientosImprimirActionExchange(VentasExchange.venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Datos)
                     {
                         Segmento_Id = exch.Principal[0].Segmento_IdFact,
                         Segmento1N = exch.Principal[0].Segmento1NFact,
                         Segmento2N = exch.Principal[0].Segmento2NFact,
                         Segmento3N = exch.Principal[0].Segmento3NFact,
                         Segmento4N = exch.Principal[0].Segmento4NFact,
                         Segmento1C = exch.Principal[0].Segmento1CFact,
                         Segmento2C = exch.Principal[0].Segmento2CFact,
                         Segmento3C = exch.Principal[0].Segmento3CFact,
                         Segmento4C = exch.Principal[0].Segmento4CFact
                     };
            eMov = new VentasExchange.venMovimientosImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            if (!eMov.Existe)
            {

                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Movimiento");

            }
            if (eMov.XML == "")
                Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");

            return Generalidades.Archivos.ConvertirADatasetDownload("XML", eMov.NombreArchivo + ".xml", false, "xml",
                        eMov.XML);

        }
        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarPdfCredito(VentasCommon.venFacturacionPedidoDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venMovimientosImprimirActionExchange eMov =
                    new VentasExchange.venMovimientosImprimirActionExchange(VentasExchange.venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Datos)
                    {
                        Segmento_Id = exch.Principal[0].Segmento_IdNC,
                        Segmento1N = exch.Principal[0].Segmento1NNC,
                        Segmento2N = exch.Principal[0].Segmento2NNC,
                        Segmento3N = exch.Principal[0].Segmento3NNC,
                        Segmento4N = exch.Principal[0].Segmento4NNC,
                        Segmento1C = exch.Principal[0].Segmento1CNC,
                        Segmento2C = exch.Principal[0].Segmento2CNC,
                        Segmento3C = exch.Principal[0].Segmento3CNC,
                        Segmento4C = exch.Principal[0].Segmento4CNC
                    };
            eMov = new VentasExchange.venMovimientosImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            if (!eMov.Existe)
            {

                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Movimiento");

            }
            if (eMov.PDF == "")
                Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");

            return Generalidades.Archivos.ConvertirADatasetDownload("PDF", eMov.NombreArchivo + ".pdf", false, "pdf",
                        eMov.PDF);

        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarXmlCredito(VentasCommon.venFacturacionPedidoDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venMovimientosImprimirActionExchange eMov =
                   new VentasExchange.venMovimientosImprimirActionExchange(VentasExchange.venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Datos)
                   {
                       Segmento_Id = exch.Principal[0].Segmento_IdNC,
                       Segmento1N = exch.Principal[0].Segmento1NNC,
                       Segmento2N = exch.Principal[0].Segmento2NNC,
                       Segmento3N = exch.Principal[0].Segmento3NNC,
                       Segmento4N = exch.Principal[0].Segmento4NNC,
                       Segmento1C = exch.Principal[0].Segmento1CNC,
                       Segmento2C = exch.Principal[0].Segmento2CNC,
                       Segmento3C = exch.Principal[0].Segmento3CNC,
                       Segmento4C = exch.Principal[0].Segmento4CNC
                   };
            eMov = new VentasExchange.venMovimientosImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            if (!eMov.Existe)
            {

                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Movimiento");

            }
            if (eMov.XML == "")
                Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");

            return Generalidades.Archivos.ConvertirADatasetDownload("XML", eMov.NombreArchivo + ".xml", false, "xml",
                        eMov.XML);


        }

        public enum venFacturacionPedidoVar
        {
            ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, DepositoDefecto, ManejaLoteoSerie, ManejoDeposito, ManejaUbicacion, Cliente, CantidadSoloLectura
        }


        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(VentasCommon.venFacturacionPedidoDS exch,
            VentasCommon.venFacturacionPedidoDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            bool lCantidadSoloLectura = false;

            StockExchange.stkProductosActionExchange exchProd = new StockExchange.stkProductosActionExchange
                (StockExchange.stkProductosActionEnum.EnumstkProductosAction.Datos);

            VentasExchange.venSubTipoMovActionExchange exchSTM = new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos)
            {
                SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id
            };
            exchSTM = new VentasExchange.venSubTipoMovActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchSTM, cmd));


            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            if (exchNoPost.Cuerpo.Count > 0)
            {
                exchProd.Producto_Id = exchNoPost.Cuerpo[0].Producto_Id;
                exchProd = new StockExchange.stkProductosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                    (new Framework.Core.Exchange(exchProd), cmd));



                if (exchProd.Serializable)
                {
                    lRetorno.Add(venFacturacionPedidoVar.ManejaSerie.ToString(), "S");
                    lCantidadSoloLectura = true;
                }
                else
                    lRetorno.Add(venFacturacionPedidoVar.ManejaSerie.ToString(), "N");

                if (exchProd.TrabajaPorLotes)
                {
                    lRetorno.Add(venFacturacionPedidoVar.ManejaLote.ToString(), "S");
                    lCantidadSoloLectura = true;
                }
                else
                    lRetorno.Add(venFacturacionPedidoVar.ManejaLote.ToString(), "N");

                if (exchProd.TrabajaPorLotes || exchProd.Serializable)
                    lRetorno.Add(venFacturacionPedidoVar.ManejaLoteoSerie.ToString(), "S");
                else
                    lRetorno.Add(venFacturacionPedidoVar.ManejaLoteoSerie.ToString(), "N");

                if (exchProd.conVencimiento)
                    lRetorno.Add(venFacturacionPedidoVar.ManejaVencimiento.ToString(), "S");
                else
                    lRetorno.Add(venFacturacionPedidoVar.ManejaVencimiento.ToString(), "N");

                if (exchProd.MedidaAlterna != "")
                    lRetorno.Add(venFacturacionPedidoVar.ManejaUMAlterna.ToString(), "S");
                else
                    lRetorno.Add(venFacturacionPedidoVar.ManejaUMAlterna.ToString(), "N");

                lRetorno.Add(venFacturacionPedidoVar.Clase.ToString(), exchProd.Clase);

                if (exchProd.Clase != "D")
                    // Si no es Servicio muestro el depósito //
                    lRetorno.Add(venFacturacionPedidoVar.ManejoDeposito.ToString(), "S");
                else
                    // Si es Servicio se pide el depósito //
                    lRetorno.Add(venFacturacionPedidoVar.ManejoDeposito.ToString(), "N");

                // PARA 
                StockExchange.stkDepositosActionExchange eDepo = new StockExchange.stkDepositosActionExchange(StockExchange.stkDepositosActionEnum.EnumstkDepositosAction.Datos)
                {
                    Deposito_Id = exchNoPost.Cuerpo[0].Deposito_Id
                };

                eDepo = new StockExchange.stkDepositosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eDepo, cmd));
                if (eDepo.Existe && eDepo.UsaUbicacion)
                {
                    lRetorno.Add(venFacturacionPedidoVar.ManejaUbicacion.ToString(), "S");
                    lCantidadSoloLectura = true;
                }
                else
                    lRetorno.Add(venFacturacionPedidoVar.ManejaUbicacion.ToString(), "N");
            }

            lRetorno.Add(venFacturacionPedidoVar.Cliente.ToString(),
                exch.Principal[0].Cliente_Id + "@" + exch.Principal[0].Sucursal.ToString());

            if (lCantidadSoloLectura)
                lRetorno.Add(venFacturacionPedidoVar.CantidadSoloLectura.ToString(), "S");
            else
                lRetorno.Add(venFacturacionPedidoVar.CantidadSoloLectura.ToString(), "N");

            return lRetorno;
        }


        [Generalidades.QFuncion_CondicionGrilla]
        public string ValirSerieLote(venFacturacionPedidoDS exch, venFacturacionPedidoDS exchNoPost,
         int pIndice, Framework.Core.Command cmd)
        {

            StockExchange.stkExistenciaSerieActionExchange exchSerie = new StockExchange.stkExistenciaSerieActionExchange
                (StockExchange.stkExistenciaSerieActionEnum.EnumstkExistenciaSerieAction.Datos);
            exchSerie.Producto_Id = exchNoPost.Cuerpo[0].Producto_Id;
            exchSerie.Serie = exchNoPost.grdMoviSerie[0].Serie;
            exchSerie.Deposito_Id = exch.Cuerpo[0].Deposito_Id;

            exchSerie = new StockExchange.stkExistenciaSerieActionExchange
                (Generalidades.QBIInternal.WrapperExecuteActionInternal(new Framework.Core.Exchange(exchSerie), cmd));

            if (!exchSerie.Existe)
                return "Serie_Lote_<0>_en_deposito_<1>_no_existe";
            return "";

        }

        [Generalidades.QFuncion_AccionGrilla]
        public venFacturacionPedidoDS SumarCant(venFacturacionPedidoDS exch, venFacturacionPedidoDS exchNoPost,
                int pIndice, Framework.Core.Command cmd)
        {

            exchNoPost.Cuerpo[0].CantidadAFacturar = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }

        [Generalidades.QFuncion_Condicion]
        public string SoloEntrega(VentasCommon.venFacturacionPedidoDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venPedidosActionExchange ePEDI = new VentasExchange.venPedidosActionExchange(VentasExchange.venPedidosActionEnum.EnumvenPedidosAction.DatosIdentity)
            {
                venPedidos = exch.Principal[0].venPedidos
            };
            ePEDI = new VentasExchange.venPedidosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ePEDI, cmd));
            if (ePEDI.Existe)
            {
                if (ePEDI.SoloEntrega)
                    return "S";
            }

            return "N";
        }


        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarPdfRmito(VentasCommon.venFacturacionPedidoDS exch, Framework.Core.Command cmd)
        {
            StockExchange.stkMoviCabeImprimirActionExchange eMov =
                  new StockExchange.stkMoviCabeImprimirActionExchange(StockExchange.stkMoviCabeImprimirActionEnum.EnumstkMoviCabeImprimirAction.Guardar)
                  {
                      Segmento_Id = exch.Principal[0].Segmento_IdRem,
                      Segmento1N = exch.Principal[0].Segmento1NRem,
                      Segmento2N = exch.Principal[0].Segmento2NRem,
                      Segmento3N = exch.Principal[0].Segmento3NRem,
                      Segmento4N = exch.Principal[0].Segmento4NRem,
                      Segmento1C = exch.Principal[0].Segmento1CRem,
                      Segmento2C = exch.Principal[0].Segmento2CRem,
                      Segmento3C = exch.Principal[0].Segmento3CRem,
                      Segmento4C = exch.Principal[0].Segmento4CRem
                  };
            eMov = new StockExchange.stkMoviCabeImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            if (!eMov.Existe)
            {

                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Movimiento");

            }
            if (eMov.PDF == "")
                Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");
            string[] lArchivo = eMov.NombreArchivo.Split('\\');

            return Generalidades.Archivos.ConvertirADatasetDownload("PDF", lArchivo[lArchivo.Length - 1] + ".pdf", false, "pdf",
                        eMov.PDF);


        }

        [Generalidades.QFuncion_AccionGrilla]
        public static venFacturacionPedidoDS AsignarCantidad(venFacturacionPedidoDS exch, venFacturacionPedidoDS exchNoPost, int pIndice,
  Framework.Core.Command cmd)
        {


            if (exchNoPost.Cuerpo[0].CantidadAEntregar == 0)
                return exchNoPost;


            exchNoPost.Ubicaciones[0].Cantidad = 0;
            StockExchange.stkExistenciaUbiActionExchange eExistU = new StockExchange.stkExistenciaUbiActionExchange(StockExchange.stkExistenciaUbiActionEnum.EnumstkExistenciaUbiAction.Datos)
            {
                Deposito_Id = exchNoPost.Cuerpo[0].Deposito_Id,
                Producto_Id = exchNoPost.Cuerpo[0].Producto_Id,
                Ubicacion_Id = exchNoPost.Ubicaciones[0].Ubicacion_Id
            };
            eExistU = new StockExchange.stkExistenciaUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eExistU, cmd));
            if (eExistU.Existe && eExistU.Cantidad > 0)
            {
                decimal lCant = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
                exchNoPost.Ubicaciones[0].Cantidad = Math.Min(exchNoPost.Cuerpo[0].CantidadAEntregar - lCant, eExistU.Cantidad / exchNoPost.Cuerpo[0].Factor);
            }


            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        public static venFacturacionPedidoDS SumarCantU(venFacturacionPedidoDS exch, venFacturacionPedidoDS exchNoPost, int pIndice,
     Framework.Core.Command cmd)
        {

            exchNoPost.Cuerpo[0].CantidadAEntregar = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
            exchNoPost.Cuerpo[0].CantidadAFacturar = exchNoPost.Cuerpo[0].CantidadAEntregar;
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_Condicion]
        public string FacturaSinEntrega(venFacturacionPedidoDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcSTM = new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos)
            {
                SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id
            };
            ExcSTM = new VentasExchange.venSubTipoMovActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcSTM, cmd));
            if (ExcSTM.Existe)
            {
                if (ExcSTM.AdmiteFactsinEntr)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string FactEnMonedaBase(VentasCommon.venFacturacionPedidoDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].MonedaFacturacion == cmd.MonedaBase)
                return "S";
            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string MonNPIgualMonFact(VentasCommon.venFacturacionPedidoDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Moneda_Id == exch.Principal[0].MonedaFacturacion)
                return "S";
            return "N";
        }


        [Generalidades.QFuncion_EnviarMail]
        public Generalidades.CorreoDS Enviar(VentasCommon.venFacturacionPedidoDS pCommonDS, Framework.Core.Command cmd)
        {
            Generalidades.CorreoDS lRetorno = new Generalidades.CorreoDS();

            if (pCommonDS.Principal[0].Segmento1NFact != 0)
            {
                VentasExchange.venMovimientosEnviarActionExchange eMov = new VentasExchange.venMovimientosEnviarActionExchange(VentasExchange.venMovimientosEnviarActionEnum.EnumvenMovimientosEnviarAction.Datos)
                {
                    Segmento_Id = pCommonDS.Principal[0].Segmento_IdFact,
                    Segmento1N = pCommonDS.Principal[0].Segmento1NFact,
                    Segmento2N = pCommonDS.Principal[0].Segmento2NFact,
                    Segmento3N = pCommonDS.Principal[0].Segmento3NFact,
                    Segmento4N = pCommonDS.Principal[0].Segmento4NFact,
                    Segmento1C = pCommonDS.Principal[0].Segmento1CFact,
                    Segmento2C = pCommonDS.Principal[0].Segmento2CFact,
                    Segmento3C = pCommonDS.Principal[0].Segmento3CFact,
                    Segmento4C = pCommonDS.Principal[0].Segmento4CFact
                };
                eMov = new VentasExchange.venMovimientosEnviarActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

                lRetorno.Principal.AddPrincipalRow(eMov.Param.Cabecera[0].Asunto, eMov.Param.Cabecera[0].Cuerpo,
                        eMov.Param.Cabecera[0].Destinatarios, eMov.Param.Cabecera[0].DestinatariosCopia, eMov.Param.Cabecera[0].DestinatariosCopiaOculta, false);
                foreach (var ren in eMov.Param.Adjuntos)
                {
                    lRetorno.Adjuntos.AddAdjuntosRow(ren.Renglon, ren.Guid, ren.NombreArchivo, ren.Extension,
                          ren.ArchivoBase64, ren.Estado);
                }
            }
            if (pCommonDS.Principal[0].Segmento1NNC != 0)
            {

                VentasExchange.venMovimientosEnviarActionExchange eMov = new VentasExchange.venMovimientosEnviarActionExchange(VentasExchange.venMovimientosEnviarActionEnum.EnumvenMovimientosEnviarAction.Datos)
                {
                    Segmento_Id = pCommonDS.Principal[0].Segmento_IdNC,
                    Segmento1N = pCommonDS.Principal[0].Segmento1NNC,
                    Segmento2N = pCommonDS.Principal[0].Segmento2NNC,
                    Segmento3N = pCommonDS.Principal[0].Segmento3NNC,
                    Segmento4N = pCommonDS.Principal[0].Segmento4NNC,
                    Segmento1C = pCommonDS.Principal[0].Segmento1CNC,
                    Segmento2C = pCommonDS.Principal[0].Segmento2CNC,
                    Segmento3C = pCommonDS.Principal[0].Segmento3CNC,
                    Segmento4C = pCommonDS.Principal[0].Segmento4CNC
                };
                eMov = new VentasExchange.venMovimientosEnviarActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

                if (lRetorno.Principal.Count == 0)
                {
                    lRetorno.Principal.AddPrincipalRow(eMov.Param.Cabecera[0].Asunto, eMov.Param.Cabecera[0].Cuerpo,
                           eMov.Param.Cabecera[0].Destinatarios, eMov.Param.Cabecera[0].DestinatariosCopia, eMov.Param.Cabecera[0].DestinatariosCopiaOculta, false);
                }
                foreach (var ren in eMov.Param.Adjuntos)
                {
                    lRetorno.Adjuntos.AddAdjuntosRow(ren.Renglon, ren.Guid, ren.NombreArchivo, ren.Extension,
                          ren.ArchivoBase64, ren.Estado);
                }


            }

            // TODO REMISION
            if (pCommonDS.Principal[0].Segmento1NRem != 0)
            {
                StockExchange.stkMoviCabeImprimirActionExchange eMov =
                 new StockExchange.stkMoviCabeImprimirActionExchange(StockExchange.stkMoviCabeImprimirActionEnum.EnumstkMoviCabeImprimirAction.Guardar)
                 {
                     Segmento_Id = pCommonDS.Principal[0].Segmento_IdRem,
                     Segmento1N = pCommonDS.Principal[0].Segmento1NRem,
                     Segmento2N = pCommonDS.Principal[0].Segmento2NRem,
                     Segmento3N = pCommonDS.Principal[0].Segmento3NRem,
                     Segmento4N = pCommonDS.Principal[0].Segmento4NRem,
                     Segmento1C = pCommonDS.Principal[0].Segmento1CRem,
                     Segmento2C = pCommonDS.Principal[0].Segmento2CRem,
                     Segmento3C = pCommonDS.Principal[0].Segmento3CRem,
                     Segmento4C = pCommonDS.Principal[0].Segmento4CRem
                 };
                eMov = new StockExchange.stkMoviCabeImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

                if (eMov.Existe)
                {
                    if (eMov.PDF == "")
                        Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");
                    // falta esto
                    if (lRetorno.Principal.Count == 0)
                    {

                        StockExchange.stkMoviCabeDatosSalidasRemitoActionExchange eRemi = new StockExchange.stkMoviCabeDatosSalidasRemitoActionExchange(StockExchange.stkMoviCabeDatosSalidasRemitoActionEnum.EnumstkMoviCabeDatosSalidasRemitoAction.Datos)
                        {
                            Segmento_Id = pCommonDS.Principal[0].Segmento_IdRem,
                            Segmento1N = pCommonDS.Principal[0].Segmento1NRem,
                            Segmento2N = pCommonDS.Principal[0].Segmento2NRem,
                            Segmento3N = pCommonDS.Principal[0].Segmento3NRem,
                            Segmento4N = pCommonDS.Principal[0].Segmento4NRem,
                            Segmento1C = pCommonDS.Principal[0].Segmento1CRem,
                            Segmento2C = pCommonDS.Principal[0].Segmento2CRem,
                            Segmento3C = pCommonDS.Principal[0].Segmento3CRem,
                            Segmento4C = pCommonDS.Principal[0].Segmento4CRem
                        };
                        eRemi = new StockExchange.stkMoviCabeDatosSalidasRemitoActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eRemi, cmd));
                        string lDestinatario = "";
                        string lCuerpo = "";
                        string lSepa = "";
                        var eEmpresa = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);

                        if (eRemi.Existe)
                        {
                            var eClie = VentasValidacion.venClieHabitual.Existe(eRemi.Param.stkRemitos[0].Cliente_Id, eRemi.Param.stkRemitos[0].Sucursal, cmd);
                            foreach (var ree in eClie.Param.grdContactos.Where(c => c.EnviaFacturas))
                            {
                                lDestinatario += lSepa + ree.Email;
                                lSepa = ";";
                            }

                            lCuerpo = "<HTML>";
                            lCuerpo += "<div><p>Sres " + eClie.RazonSocial + "</p></div>";
                            lCuerpo += "<div><p>Adjunto a este correo encontrará su Remision</p></div>";
                            lCuerpo += "<div><p>Agradecemos su Atención.</p></div>";
                            lCuerpo += "<div><p>Área de Facturación de " + eEmpresa.RazonSocial.Trim() + "</p></div>";
                            lCuerpo += "</HTML>";
                        }
                        else
                        {
                            lCuerpo = "<HTML>";
                            lCuerpo += "<div><p>Estimado Cliente</p></div>";
                            lCuerpo += "<div><p>Adjunto a este correo encontrará su Remision</p></div>";
                            lCuerpo += "<div><p>Agradecemos su Atención.</p></div>";
                            lCuerpo += "<div><p>Área de Facturación de " + eEmpresa.RazonSocial.Trim() + "</p></div>";
                            lCuerpo += "</HTML>";
                        }
                        lRetorno.Principal.AddPrincipalRow("Remision de " + eEmpresa.RazonSocial, lCuerpo, lDestinatario, "", "", false);
                    }

                    string[] lArchivo = eMov.NombreArchivo.Split('\\');

                    lRetorno.Adjuntos.AddAdjuntosRow(10, "Remito", lArchivo[lArchivo.Length - 1], "pdf", eMov.PDF, Generalidades.Archivos.QEstadoArchivo.Nuevo.ToString());
                }
            }


            // Los destinatarios van separados por ';'
            // El datatable de adjuntos tiene la misma estructura y forma de utilizarse que el datatable adjuntos de cualquier entidad o movimiwento
            // Se puede usar el método Generalidades.Auxiliares.AdjuntosCompletarDatos(NombreTabla, Identity, Path, cmd) para completar el datatable de ajuntos del mail, con los adjuntos asociados a la entidad o movimiento
            return lRetorno;

        }

        [Generalidades.QFuncion_Condicion]
        public string EnviaFactura(VentasCommon.venFacturacionPedidoDS exch, Framework.Core.Command cmd)
        {

            return (GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd).EnviaFacturas ? "S" : "N");
        }

        [Generalidades.QFuncion_Condicion]
        public string ConfirmaEnviaFactura(VentasCommon.venFacturacionPedidoDS exch, Framework.Core.Command cmd)
        {

            return (GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd).ConfirmarEnviarFacturas ? "S" : "N");
        }

        [Generalidades.QFuncion_AccionGrilla]
        public venFacturacionPedidoDS PopularSerie(venFacturacionPedidoDS pCommonDS, venFacturacionPedidoDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {

            StockExchange.stkExistenciaXSerieXUbiActionExchange exchSerie = new StockExchange.stkExistenciaXSerieXUbiActionExchange(StockExchange.stkExistenciaXSerieXUbiActionEnum.EnumstkExistenciaXSerieXUbiAction.DatosSerie)
            {
                Producto_Id = pCommonDSNoPost.Cuerpo[0].Producto_Id,
                Medida_Id = pCommonDSNoPost.Cuerpo[0].Medida_Id,
                Deposito_Id = pCommonDSNoPost.Cuerpo[0].Deposito_Id
            };
            exchSerie = new StockExchange.stkExistenciaXSerieXUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchSerie, cmd));

            if (pCommonDS.grdMoviSerie.Where(s => s.Renglon == pCommonDSNoPost.Cuerpo[0].Renglon_Pe).Count() == 0)
            {
                // Estoy entrando por primera vez en este renglón así que traigo los datos //

                pCommonDSNoPost.Cuerpo[0].CantidadAEntregar = 0;
                pCommonDSNoPost.Cuerpo[0].CantidadAFacturar = 0;
                pCommonDSNoPost.grdMoviSerie.Clear();
                pCommonDSNoPost.grdMoviSerie.Merge(exchSerie.Param.ExistenciasSerie);
                pCommonDSNoPost.grdMoviSerie.AcceptChanges();
                pCommonDSNoPost.grdMoviSerie.ToList().ForEach(s => s.Marcado = false);
            }

            // Recorro los renglones de las existencias porque pueden haber usado alguna serie en otro renglón //
            // y ya fue borrado entonces lo tengo que agregar porque lo pueden haber borrado del renglón original //
            // y ahora me tiene que volver a aparecer acá //
            exchSerie.Param.ExistenciasSerie.ToList().ForEach(e =>
            {
                if (pCommonDSNoPost.grdMoviSerie.Where(s => s.Serie == e.Serie).Count() == 0)
                {
                        // Lo tengo que agregar //
                        pCommonDSNoPost.grdMoviSerie.AddgrdMoviSerieRow(0, pCommonDSNoPost.Cuerpo[0].Renglon_Pe, e.Serie, 0, e.Vencimiento, e.Ubicacion_Id, e.Existencia, false);
                }

                else
                    pCommonDSNoPost.grdMoviSerie.Where(s => s.Serie == e.Serie).First().Existencia = e.Existencia;
            });

            // Borro los que no tienen existencia //
            pCommonDSNoPost.grdMoviSerie.ToList().ForEach(s =>
            {
                    // Resto las series que ya se pudieron haber usado de este producto en otro renglón //
                    s.Renglon = pCommonDSNoPost.Cuerpo[0].Renglon_Pe;

                s.Existencia -= (from ser in pCommonDS.grdMoviSerie
                                 join pro in pCommonDS.Cuerpo on ser.Renglon equals pro.Renglon_Pe
                                 where pro.Producto_Id == pCommonDSNoPost.Cuerpo[0].Producto_Id && ser.Ubicacion_Id == s.Ubicacion_Id && ser.Renglon != pCommonDSNoPost.Cuerpo[0].Renglon_Pe && ser.Serie == s.Serie
                                 select ser).Sum(y => y.Marcado ? 1 : 0);

                s.Cantidad = !s.Marcado ? 0 : 1;

                if (s.Existencia <= 0)
                    s.Delete();
            }
            );

            pCommonDSNoPost.grdMoviSerie.AcceptChanges();
            // Le paso el renglón de la grilla principal //
            pCommonDSNoPost.grdMoviSerie.ToList().ForEach(s => s.Renglon = pCommonDSNoPost.Cuerpo[0].Renglon_Pe);

            return pCommonDSNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public venFacturacionPedidoDS PopularLote(venFacturacionPedidoDS pCommonDS, venFacturacionPedidoDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {


            StockExchange.stkExistenciaXSerieXUbiActionExchange exchSerie = new StockExchange.stkExistenciaXSerieXUbiActionExchange(StockExchange.stkExistenciaXSerieXUbiActionEnum.EnumstkExistenciaXSerieXUbiAction.DatosSerie)
            {
                Producto_Id = pCommonDSNoPost.Cuerpo[0].Producto_Id,
                Medida_Id = pCommonDSNoPost.Cuerpo[0].Medida_Id,
                Deposito_Id = pCommonDSNoPost.Cuerpo[0].Deposito_Id
            };
            exchSerie = new StockExchange.stkExistenciaXSerieXUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchSerie, cmd));

            if (pCommonDS.grdMoviSerie.Where(s => s.Renglon == pCommonDSNoPost.Cuerpo[0].Renglon_Pe).Count() == 0)
            {
                // Estoy entrando por primera vez en este renglón así que traigo los datos //


                pCommonDSNoPost.Cuerpo[0].CantidadAEntregar = 0;
                pCommonDSNoPost.Cuerpo[0].CantidadAFacturar = 0;
                pCommonDSNoPost.grdMoviSerie.Clear();
                pCommonDSNoPost.grdMoviSerie.Merge(exchSerie.Param.ExistenciasSerie);
                pCommonDSNoPost.grdMoviSerie.AcceptChanges();
                // Le paso el renglón de la grilla principal //
            }
            else
            {
                // Si entro por segunda vez tengo que actualizar la existencia original así después resto //
                // que ya está usada en otros renglones //
                pCommonDSNoPost.grdMoviSerie.ToList().ForEach(s =>
                {
                    s.Existencia =
                       (from exi in exchSerie.Param.ExistenciasSerie
                        where exi.Serie == s.Serie && exi.Ubicacion_Id == s.Ubicacion_Id
                        select new { exi.Existencia }).Sum(u => u.Existencia);
                }
);
            }

            // Le paso el renglón de la grilla principal //
            // También resto las cantidades de esos mismos lotes y ubicaciones que ese mismo producto pueda haber usado //
            // en otros renglones de esta misma grilla //
            pCommonDSNoPost.grdMoviSerie.ToList().ForEach(s =>
            {
                s.Renglon = pCommonDSNoPost.Cuerpo[0].Renglon_Pe;
                s.Existencia -= (from ser in pCommonDS.grdMoviSerie
                                 join pro in pCommonDS.Cuerpo on ser.Renglon equals pro.Renglon_Pe
                                 where pro.Producto_Id == pCommonDSNoPost.Cuerpo[0].Producto_Id &&
                                 ser.Ubicacion_Id == s.Ubicacion_Id && ser.Renglon != pCommonDSNoPost.Cuerpo[0].Renglon_Pe && ser.Ubicacion_Id == s.Ubicacion_Id
                                 select new { ser.Cantidad, pro.Factor }).Sum(y => y.Cantidad / y.Factor);
            }
            );


            return pCommonDSNoPost;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public venFacturacionPedidoDS PopularUbi(venFacturacionPedidoDS pCommonDS, venFacturacionPedidoDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {

            StockExchange.stkExistenciaXSerieXUbiActionExchange exchUbi = new StockExchange.stkExistenciaXSerieXUbiActionExchange(StockExchange.stkExistenciaXSerieXUbiActionEnum.EnumstkExistenciaXSerieXUbiAction.DatosUbi)
            {
                Producto_Id = pCommonDSNoPost.Cuerpo[0].Producto_Id,
                Medida_Id = pCommonDSNoPost.Cuerpo[0].Medida_Id,
                Deposito_Id = pCommonDSNoPost.Cuerpo[0].Deposito_Id
            };
            exchUbi = new StockExchange.stkExistenciaXSerieXUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchUbi, cmd));

            if (pCommonDS.Ubicaciones.Where(s => s.Renglon == pCommonDSNoPost.Cuerpo[0].Renglon_Pe).Count() == 0)
            {
                // Estoy entrando por primera vez en este renglón así que traigo los datos //


                pCommonDSNoPost.Cuerpo[0].CantidadAEntregar = 0;
                pCommonDSNoPost.Cuerpo[0].CantidadAFacturar = 0;
                pCommonDSNoPost.Ubicaciones.Clear();
                pCommonDSNoPost.Ubicaciones.Merge(exchUbi.Param.ExistenciaUbi);
                pCommonDSNoPost.Ubicaciones.AcceptChanges();
            }
            else
            {
                // Si entro por segunda vez tengo que actualizar la existencia original así después resto //
                // que ya está usada en otros renglones //
                pCommonDSNoPost.Ubicaciones.ToList().ForEach(s =>
                {
                    s.Existencia =
                       (from exi in exchUbi.Param.ExistenciaUbi
                        where exi.Ubicacion_Id == s.Ubicacion_Id
                        select new { exi.Existencia, exi.ExistenciaAlterna }).Sum(u => u.Existencia);
                    s.ExistenciaAlterna =
                    (from exi in exchUbi.Param.ExistenciaUbi
                     where exi.Ubicacion_Id == s.Ubicacion_Id
                     select new { exi.Existencia, exi.ExistenciaAlterna }).Sum(u => u.ExistenciaAlterna);
                }
                );
            }

            // Le paso el renglón de la grilla principal //
            // También resto las cantidades de esas mismas ubicaciones que ese mismo producto pueda haber usado //
            // en otros renglones de esta misma grilla //
            pCommonDSNoPost.Ubicaciones.ToList().ForEach(s =>
            {
                s.Renglon = pCommonDSNoPost.Cuerpo[0].Renglon_Pe;
                s.Existencia = s.Existencia - (from ubi in pCommonDS.Ubicaciones
                                               join pro in pCommonDS.Cuerpo on ubi.Renglon equals pro.Renglon_Pe
                                               where pro.Producto_Id == pCommonDSNoPost.Cuerpo[0].Producto_Id &&
                                               ubi.Ubicacion_Id == s.Ubicacion_Id && ubi.Renglon != pCommonDSNoPost.Cuerpo[0].Renglon_Pe
                                               select new { ubi.Cantidad, pro.Factor }).Sum(y => y.Cantidad / y.Factor);

                s.ExistenciaAlterna -= (from ubi in pCommonDS.Ubicaciones
                                        join pro in pCommonDS.Cuerpo on ubi.Renglon equals pro.Renglon_Pe
                                        where pro.Producto_Id == pCommonDSNoPost.Cuerpo[0].Producto_Id &&
                                    ubi.Ubicacion_Id == s.Ubicacion_Id && ubi.Renglon != pCommonDSNoPost.Cuerpo[0].Renglon_Pe
                                        select new { ubi.CantidadAlterna }).Sum(y => y.CantidadAlterna);

            }
            );


            return pCommonDSNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public venFacturacionPedidoDS SumarCantSerie(venFacturacionPedidoDS exch, venFacturacionPedidoDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            exchNoPost.Cuerpo[0].CantidadAFacturar = exchNoPost.grdMoviSerie.ToList().Sum(r => !r.Marcado ? 0 : 1);
            exchNoPost.Cuerpo[0].CantidadAEntregar = exchNoPost.Cuerpo[0].CantidadAFacturar;
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public venFacturacionPedidoDS SumarCantLote(venFacturacionPedidoDS exch, venFacturacionPedidoDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            exchNoPost.Cuerpo[0].CantidadAFacturar = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.Cuerpo[0].CantidadAEntregar = exchNoPost.Cuerpo[0].CantidadAFacturar;
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }
    }
}
