using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using TesoreriaExchange;

namespace TesoreriaFEEventos
{
    public class tesRengMoviVirtual
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public static string ValidarFilaDebe(TesoreriaCommon.tesMovimientosDatosBaseDS.DebeRow Dt, Framework.Core.Command cmd)
        {
            return "";
        }


        [Generalidades.QFuncion_CondicionGrilla]
        public static string ValidarAnticipo(TesoreriaCommon.tesMovimientosDatosBaseDS.AntClientesRow Dt, Framework.Core.Command cmd)
        {
            return "";
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS AsignarMontoDebe(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos,
                    TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {

            if (ExcNoPos.Debe[0].Cambio == 0)
            {
                // Asigno el Cambio
                if (ExcNoPos.Debe[0].Moneda_Id == cmd.MonedaBase)
                    ExcNoPos.Debe[0].Cambio = 1;
                else
                {
                    if (ExcNoPos.Debe[0].Moneda_Id == ExcPos.Principal[0].Moneda_Id)
                        ExcNoPos.Debe[0].Cambio = ExcPos.Principal[0].Cambio;
                    else
                    {
                        GeneralesExchange.genTipoCambioActionExchange ExcCa =
                        GeneralesValidacion.genTipoCambio.Existe(ExcNoPos.Debe[0].Moneda_Id, ExcPos.Principal[0].Fecha, cmd);
                        ExcNoPos.Debe[0].Cambio = ExcCa.CambioCompra;
                    }
                }
            }

            decimal lTotalDebe = ExcPos.Debe.AsEnumerable().Sum(r => r.Importe);
            if (Indice > 0)
                lTotalDebe -= ExcPos.Debe[Indice].Importe;

            decimal lTotalHaber = 0;
            if (!ExcPos.Principal[0].IsTotalHaberNull())
                lTotalHaber = ExcPos.Principal[0].TotalHaber;

            if (lTotalHaber == 0 && !ExcPos.Principal[0].IsTotalHabilitadoNull())
                lTotalHaber = ExcPos.Principal[0].TotalHabilitado;

            // TODO DECIMALES
            ExcNoPos.Debe[0].Importe = Math.Round(ExcNoPos.Debe[0].ImporteOrig * ExcNoPos.Debe[0].Cambio, 2);
            lTotalDebe += ExcNoPos.Debe[0].Importe;

            ExcNoPos.Debe[0].Diferencia = lTotalDebe - lTotalHaber;
            return (ExcNoPos);

        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS CalcularDif(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos,
                    TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            decimal lTotalDebe;
            decimal lTotalHaber;
            if (ExcPos.Debe.Count > 0)
                lTotalDebe = ExcPos.Debe.Where(r => !r.IsImporteNull()).AsEnumerable().Sum(r => r.Importe);
            else
                lTotalDebe = 0;
            if (ExcPos.Principal[0].SubTipo_Id == "PAP" || ExcPos.Principal[0].SubTipo_Id == "COP")
            {
                lTotalDebe += ExcPos.FactProveedores.ToList().Where(d => !d.IsSaldoOriNull()).ToList().Sum(d => d.SaldoOri);
                lTotalDebe += ExcPos.AntProveedores.ToList().Where(d => !d.IsImporteNull()).ToList().Sum(d => d.Importe);
            }
            else
            {
                if (lTotalDebe == 0 && !ExcPos.Principal[0].IsTotalHabilitadoNull())
                    lTotalDebe = ExcPos.Principal[0].TotalHabilitado;
            }
            if (ExcPos.Haber.Count > 0)
                // Si se entraba a hacer una cobranza, se elegía el cliente y no tenía ninguna factura pendiente, //
                // si se elegía el Debe primero, cuando entraba por acá daba error porque el Haber tiene un registro //
                // pero sin datos. Por eso le puse el Where. Lo mismo hice con el Debe //
                lTotalHaber = ExcPos.Haber.Where(r => !r.IsImporteNull()).AsEnumerable().Sum(r => r.Importe);
            else
                lTotalHaber = 0;

            if (ExcPos.Principal[0].SubTipo_Id == "COB" || ExcPos.Principal[0].SubTipo_Id == "PAC")
            {
                lTotalHaber += ExcPos.FactClientes.ToList().Where(h => !h.IsImporteNull()).ToList().Sum(d => d.SaldoOri);
                lTotalHaber += ExcPos.AntClientes.ToList().Where(h => !h.IsImporteNull()).ToList().Sum(d => d.Importe);
            }
            else
            {
                if (lTotalHaber == 0 && !ExcPos.Principal[0].IsTotalHabilitadoNull())
                    lTotalHaber = ExcPos.Principal[0].TotalHabilitado;
            }
            if (ExcNoPos.Debe.Rows.Count > 0)
                ExcNoPos.Debe[0].Diferencia = lTotalDebe - lTotalHaber;
            if (ExcNoPos.Haber.Rows.Count > 0)
                ExcNoPos.Haber[0].Diferencia = lTotalDebe - lTotalHaber;
            return (ExcNoPos);

        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS AsignarMontoHaber(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos,
                            TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {

            GeneralesExchange.genMonedasActionExchange exchGM = GeneralesValidacion.genMonedas.Existe(cmd.MonedaBase, cmd);
            if (ExcNoPos.Haber[0].Cambio == 0)
            {
                // Asigno el Cambio
                if (ExcNoPos.Haber[0].Moneda_Id == cmd.MonedaBase)
                    ExcNoPos.Haber[0].Cambio = 1;
                else
                {
                    if (ExcNoPos.Haber[0].Moneda_Id == ExcPos.Principal[0].Moneda_Id)
                        ExcNoPos.Haber[0].Cambio = ExcPos.Principal[0].Cambio;
                    else
                    {
                        GeneralesExchange.genTipoCambioActionExchange ExcCa =
                        GeneralesValidacion.genTipoCambio.Existe(ExcNoPos.Haber[0].Moneda_Id, ExcPos.Principal[0].Fecha, cmd);
                        ExcNoPos.Haber[0].Cambio = ExcCa.CambioVenta;
                    }
                }
            }
            ExcPos.Principal[0].TotalDebe = ExcPos.Principal[0].IsTotalDebeNull() ? 0 : ExcPos.Principal[0].TotalDebe;
            decimal lTotalDebe = ExcPos.Principal[0].TotalDebe;
            decimal lTotalHaber = ExcPos.Haber.AsEnumerable().Sum(r => r.Importe);
            if (Indice > 0)
                lTotalHaber -= ExcPos.Haber[Indice].Importe;

            ExcNoPos.Haber[0].Importe = Generalidades.Auxiliares.Redondear
                (ExcNoPos.Haber[0].ImporteOrig * ExcNoPos.Haber[0].Cambio, exchGM.CantidadDigitos);
            lTotalHaber += ExcNoPos.Haber[0].Importe;

            ExcNoPos.Haber[0].Diferencia = lTotalDebe - lTotalHaber;

            //ExcNoPos.Haber[0].CPFechaVencimiento = ExcPos.Principal[0].Fecha;
            return (ExcNoPos);

        }


        [Generalidades.QFuncion_CondicionGrilla]
        public static string EnMonedaBaseHaber(string Moneda_Id, Framework.Core.Command cmd)
        {
            // Es Virtual
            return (Moneda_Id == cmd.MonedaBase ? "S" : "N");
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS AsignarCheque(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos,
               TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            if (ExcNoPos.Haber[0].CPChequera_Id == 0)
            {
                // Asigno la predeterminada
                TesoreriaExchange.tesIdBancoPropioActionExchange ExcBA =
                        new TesoreriaExchange.tesIdBancoPropioActionExchange
                        (TesoreriaExchange.tesIdBancoPropioActionEnum.EnumtesIdBancoPropioAction.Datos);

                ExcBA.Cartera_Id = ExcNoPos.Haber[0].Cartera_Id;
                ExcBA = new TesoreriaExchange.tesIdBancoPropioActionExchange
                    (Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcBA, cmd));
                if (ExcBA.Existe)
                {
                    if (ExcBA.ChequeraPredeter == 0)
                        return (ExcNoPos);
                    ExcNoPos.Haber[0].CPChequera_Id = ExcBA.ChequeraPredeter;
                }
            }

            // Reviso si hay otro Cheque Asignado


            TesoreriaExchange.tesChequerasActionExchange ExcCheq =
                TesoreriaValidacion.tesChequeras.Existe(ExcNoPos.Haber[0].CPChequera_Id, ExcNoPos.Haber[0].Cartera_Id, cmd);

            int lProximo = ExcCheq.Proximo;

            for (int i = 0; i < ExcPos.Haber.Count; i++)
            {
                if (i != Indice)
                {
                    if (ExcPos.Haber[i].Cartera_Id == ExcNoPos.Haber[0].Cartera_Id &&
                            ExcPos.Haber[i].CPChequera_Id == ExcNoPos.Haber[0].CPChequera_Id)
                    {

                        lProximo = Math.Max(lProximo, ExcPos.Haber[i].CPnumCheque + 1);

                    }
                }

            }

            ExcNoPos.Haber[0].CPnumCheque = lProximo;

            if (cmd.Dominio_Id != "MX")
            {
                tesIdBancoPropioActionExchange exchTBP = new tesIdBancoPropioActionExchange
                    (tesIdBancoPropioActionEnum.EnumtesIdBancoPropioAction.Datos);
                exchTBP.Cartera_Id = ExcNoPos.Haber[0].Cartera_Id;
                exchTBP = new tesIdBancoPropioActionExchange
                    (Generalidades.QBIInternal.WrapperExecuteActionInternal(new Exchange(exchTBP), cmd));

                if (ExcCheq.TipoChequera == "D")
                {
                    // Es chequera diferida así que cambio la cuenta //

                    if (exchTBP.CtaContDiferido == "")
                    {
                        object[] lParam = { exchTBP.Cartera_Id };
                        Generalidades.qFunctionalException.GenerarExcepcion
                            ("Debe_definir_la_cuenta_de_pago_diferido_en_identificado_<0>", lParam);
                    }
                    ExcNoPos.Haber[0].Cuenta_Id = exchTBP.CtaContDiferido;

                }
                else
                {
                    // FM 25/09/2019 //
                    // Si eligen una chequera diferida cambia la cuenta pero si la cambian por una chequera normal quedaba la cuenta anterior //
                    ExcNoPos.Haber[0].Cuenta_Id = exchTBP.Cuenta_Id;
                }
            }

            return (ExcNoPos);

        }



        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS AsignarDatosDestinatario(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos,
       TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {

            if (!ExcPos.Principal[0].IsProveed_IdNull() && ExcPos.Principal[0].Proveed_Id != "")
            {
                if (ExcNoPos.Haber[0].CPCuit == "")
                {
                    // Si el Proveedor Existe Asigno los Datos
                    ComprasExchange.comProveedoresActionExchange ExcPr = new ComprasExchange.comProveedoresActionExchange
                        (ComprasExchange.comProveedoresActionEnum.EnumcomProveedoresAction.Datos);
                    ExcPr.Proveed_Id = ExcPos.Principal[0].Proveed_Id;
                    ExcPr = new ComprasExchange.comProveedoresActionExchange
                        (Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcPr, cmd));

                    if (ExcPr.Existe)
                    {
                        if (cmd.Dominio_Id == "MX")
                        {
                            ExcNoPos.Haber[0].CPCuit = ExcPr.CUIT;
                            // TODO ESTO VA PARA ARGENTINA?
                            ExcNoPos.Haber[0].CPCuentaDestino = ExcPr.CBU;
                            ExcNoPos.Haber[0].CPDescripcionBanco = ExcPr.DescripcionBancos;
                            ExcNoPos.Haber[0].CPBanco_Id = ExcPr.Banco_Id;
                        }
                        ExcNoPos.Haber[0].CPAlaOrden = ExcPr.RazonSocial;
                    }

                }


            }

            // También asigno la chequera predeterminada //
            if (ExcNoPos.Haber[0].CPChequera_Id == 0)
            {
                // Asigno la predeterminada
                TesoreriaExchange.tesIdBancoPropioActionExchange ExcBA =
                        new TesoreriaExchange.tesIdBancoPropioActionExchange
                        (TesoreriaExchange.tesIdBancoPropioActionEnum.EnumtesIdBancoPropioAction.Datos);

                ExcBA.Cartera_Id = ExcNoPos.Haber[0].Cartera_Id;
                ExcBA = new TesoreriaExchange.tesIdBancoPropioActionExchange
                    (Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcBA, cmd));
                if (ExcBA.Existe)
                {
                    if (ExcBA.ChequeraPredeter == 0)
                        return (ExcNoPos);
                    ExcNoPos.Haber[0].CPChequera_Id = ExcBA.ChequeraPredeter;

                    // AJ OCT 2020 Sino no traia el numero de cheque
                    TesoreriaExchange.tesChequerasActionExchange ExcCheq =
                    TesoreriaValidacion.tesChequeras.Existe(ExcNoPos.Haber[0].CPChequera_Id, ExcNoPos.Haber[0].Cartera_Id, cmd);
                    ExcNoPos.Haber[0].CPnumCheque = ExcCheq.Proximo;
                }
                ExcNoPos.Haber[0].CPFechaVencimiento = ExcPos.Principal[0].Fecha;
            }
            // AJ OCT 2020

            //ExcNoPos.Haber[0].CPFechaVencimiento = ExcPos.Principal[0].Fecha;

            return ExcNoPos;
        }


        [Generalidades.QFuncion_CondicionGrilla]
        public static string ValidarCheqProp(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos,
           TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            // NO tiene que estar repetido el númeor de cheque propio //
            string lRet = "";
            //ExcPos.Haber.Where(r => !r.IsCPChequera_IdNull() && !r.IsCPnumChequeNull()).ToList().ForEach(cheq =>
            for (int i = 0; i < ExcPos.Haber.Count; i++)
            {
                if (i != Indice && !ExcPos.Haber[i].IsCPChequera_IdNull() && !ExcPos.Haber[i].IsCPnumChequeNull() &&
                    ExcNoPos.Haber[0].CPChequera_Id != 0 &&
                    ExcPos.Haber[i].Cartera_Id == ExcNoPos.Haber[0].Cartera_Id &&
                    ExcPos.Haber[i].CPChequera_Id == ExcNoPos.Haber[0].CPChequera_Id &&
                    ExcPos.Haber[i].CPnumCheque == ExcNoPos.Haber[0].CPnumCheque)
                {
                    lRet = "El_cheque_ingresado_ya_fue_usado_previamente_en_esta_OP";
                    break;
                }
            };
            return lRet;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public TesoreriaCommon.tesMovimientosDatosBaseDS LeerXmlDebe(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos,
                   TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {

            return (TesoreriaFEEventos.tesRengMoviVirtual.LeerXml(ExcNoPos, ExcNoPos, Indice, "D", cmd));

        }

        [Generalidades.QFuncion_AccionGrilla]
        public TesoreriaCommon.tesMovimientosDatosBaseDS LeerXmlHaber(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos,
                   TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {

            return (TesoreriaFEEventos.tesRengMoviVirtual.LeerXml(ExcNoPos, ExcNoPos, Indice, "H", cmd));

        }


        public static TesoreriaCommon.tesMovimientosDatosBaseDS LeerXml(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos,
                    TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, string DoH, Framework.Core.Command cmd)
        {

            string lArchivo = "";
            
            DateTime lFecha_CCP = GeneralesValidacion.FechaBaseDatos.GetFechaServer(cmd).Date;
            string lTipomov = "", lClaveFiscal = "";
            decimal lCambio = 1;
            decimal lImporte = 0;
            string lUUID = "";
            if (DoH == "D")
            {
                lArchivo = ExcNoPos.Debe[0].FPArchvoXml;

                //lArchivo = "CAB6610044K1_A_216772243_XAXX010101000_23F83E60-D913-46CA-9DED-947139FE9F99.xml";
                lUUID = ExcNoPos.Debe[0].FPClaveFiscal;
            }

            else
            {
                lArchivo = ExcNoPos.Haber[0].FPArchvoXml;
                lUUID = ExcNoPos.Haber[0].FPClaveFiscal;
            }
            /*
            // AJ FEB 2020
            if (lArchivo == "X|  ")
                lArchivo = "";
                */
            if (lArchivo == "" && lUUID == "")
                Generalidades.qFunctionalException.GenerarExcepcion("Debe_Ingresar_un_archivo_xml");

            string oNombreCliente = "";
            string oNombreEnTemporal = "";

            if (lArchivo != "")
            {
                Generalidades.Archivos.QEstadoArchivo oEstadoArchivo = Generalidades.Archivos.QEstadoArchivo.Sin_Cambios;

                Generalidades.Archivos.ObtenerInfoArchivoUpload(lArchivo, cmd.Instalacion, cmd.Empresa_Id, cmd.Usuario_Id,
                    out oEstadoArchivo, out oNombreCliente, out oNombreEnTemporal);
            }
            XmlDocument lDoc = new XmlDocument();

            try
            {

                if (lArchivo != "")
                {
                    //lDoc.Load(lFolder + req.XMLFiscal);
                    lDoc.Load(oNombreEnTemporal);


                }
                else
                {
                    // Viende del comCfdiSat
                    ComprasExchange.comCFDISatActionExchange eCfdi = new ComprasExchange.comCFDISatActionExchange(ComprasExchange.comCFDISatActionEnum.EnumcomCFDISatAction.Datos)
                    {
                        UUID = lUUID
                    };
                    eCfdi = new ComprasExchange.comCFDISatActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(eCfdi, cmd));

                    if (!eCfdi.Existe)
                    {
                        object[] lParam = { lUUID };
                        Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_UUID_<0>", lParam);
                    }
                    lDoc.LoadXml(eCfdi.XML);
                }

            }

            catch
            {
                Generalidades.qFunctionalException.GenerarExcepcion("Xml_Invalido");
            }
            XmlNodeList lndComprobante = lDoc.GetElementsByTagName("cfdi:Comprobante");
            XmlNodeList lndComplemento = ((XmlElement)lndComprobante[0]).GetElementsByTagName("cfdi:Complemento");
            XmlNodeList lndTimbre = ((XmlElement)lndComplemento[0]).GetElementsByTagName("tfd:TimbreFiscalDigital");
            if (lArchivo != "")
            {
                lUUID = ((XmlElement)lndTimbre[0]).GetAttribute("UUID");
            }

            int lDecimales = 2;


            if (lndComprobante.Count == 0)
                Generalidades.qFunctionalException.GenerarExcepcion("Xml_Invalido");

            // PARA MEX VALOR2C = SERIE
            // VALOR1N = COMPROBANTE
            // TODO REVISAR EL RFC RECEPTOR
            string lVersion = ((XmlElement)lndComprobante[0]).GetAttribute("Version");
            if (lVersion == "")
                lVersion = ((XmlElement)lndComprobante[0]).GetAttribute("version");
            string lFolio = "";
            string lFecha = "";
            string lSegmento1C = "";



            if (lVersion == "3.3")
            {
                lSegmento1C = ((XmlElement)lndComprobante[0]).GetAttribute("Serie");
                lFolio = ((XmlElement)lndComprobante[0]).GetAttribute("Folio");
                lFecha = ((XmlElement)lndComprobante[0]).GetAttribute("Fecha");
            }
            else
            {
                lSegmento1C = ((XmlElement)lndComprobante[0]).GetAttribute("serie");
                lFolio = ((XmlElement)lndComprobante[0]).GetAttribute("folio");
                lFecha = ((XmlElement)lndComprobante[0]).GetAttribute("fecha");
            }
            
            
            

            int lAnio = Convert.ToInt32(lFecha.Substring(0, 4));
            int lMes = Convert.ToInt32(lFecha.Substring(5, 2));
            int lDia = Convert.ToInt32(lFecha.Substring(8, 2));






            lFecha_CCP = new DateTime(lAnio, lMes, lDia);

            if (lVersion == "3.3")
            {
                string lTipoComprobante = ((XmlElement)lndComprobante[0]).GetAttribute("TipoDeComprobante");
                if ((lTipoComprobante == "P") || (lTipoComprobante == "N"))
                    Generalidades.qFunctionalException.GenerarExcepcion("Xml_es_de_Nominas_o_Complemento_de_pago");

                if ((lTipoComprobante == "I") || (lTipoComprobante == "F"))
                    lTipomov = "F";
                else
                    lTipomov = "R";
            }
            else
            {
                string lTipoComprobante = ((XmlElement)lndComprobante[0]).GetAttribute("tipoDeComprobante");
                if (lTipoComprobante == "ingreso")
                    lTipomov = "F";
                else
                    lTipomov = "R";
            }


            if (DoH == "D")
            {

                if (lTipomov == "R")
                    Generalidades.qFunctionalException.GenerarExcepcion("Debe_Ser_Tipo_Ingresos");

            }
            else
            {
                if (lTipomov == "F")
                    Generalidades.qFunctionalException.GenerarExcepcion("Debe_Ser_Tipo_Egresos");

            }
            // VALIDAR CON LA FISCAL
            string lMoneda_Id = ((XmlElement)lndComprobante[0]).GetAttribute("Moneda");

            GeneralesExchange.genMonedasActionExchange eMoneda =
            GeneralesValidacion.genMonedas.ExistePosteadoyActivaFiscal(lMoneda_Id, cmd);

            string lCambio1 = ((XmlElement)lndComprobante[0]).GetAttribute("TipoCambio");
            if (lCambio1 == "")
                lCambio = 1;
            else
                lCambio = Convert.ToDecimal(lCambio);

            lImporte = Generalidades.Auxiliares.Redondear(Convert.ToDecimal(((XmlElement)lndComprobante[0]).GetAttribute(lVersion == "3.3" ? "Total" : "total")), lDecimales);

            XmlNodeList lndEmisor = ((XmlElement)lndComprobante[0]).GetElementsByTagName("cfdi:Emisor");
            XmlNodeList lndReceptor = ((XmlElement)lndComprobante[0]).GetElementsByTagName("cfdi:Receptor");

            // VALIDAR EL RFC DEL Receptor CON EL DE LA EMPRESA 
            if (lndReceptor.Count > 0)
            {

                string lRFCReceptor = ((XmlElement)lndReceptor[0]).GetAttribute(lVersion == "3.3" ? "Rfc" : "rfc");
                var eEmp = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);
                if (eEmp.Cuit.Trim() != lRFCReceptor)
                    Generalidades.qFunctionalException.GenerarExcepcion("Este_Cfdi_Corresponde_al_RFC_<0>",
                            new object[] { lRFCReceptor });
                
            }
            


            string lRFCEmisor = ((XmlElement)lndEmisor[0]).GetAttribute(lVersion == "3.3" ? "Rfc" : "rfc");


            // Busco el Anexo por RFC
            ComprasExchange.comProvAnexoActionExchange ExcP =
                    new ComprasExchange.comProvAnexoActionExchange(ComprasExchange.comProvAnexoActionEnum.EnumcomProvAnexoAction.Datos);

            string lRfc = "";
            if (Generalidades.Auxiliares.VeriCuit(lRFCEmisor, "MX"))
                ExcP.CUIT = lRFCEmisor;
            else
                ExcP.CUIT = " " + lRFCEmisor;
            lRfc = ExcP.CUIT;
            ExcP = new ComprasExchange.comProvAnexoActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcP, cmd));

            if (ExcP.Existe)
            {
                ExcNoPos.Debe[0].FPCuit = ExcP.CUIT;
                ExcNoPos.Debe[0].FPRazonSocial = ExcP.RazonSocial;
                ExcNoPos.Debe[0].FPOrigen_Id = 3;
                ExcNoPos.Debe[0].FPCondFiscal_Id = ExcP.CondFiscal_Id;
                ExcNoPos.Debe[0].FPDescripcionCondFiscal = ExcP.DescripcionCondFiscal;
                ExcNoPos.Debe[0].Provincia_Id = ExcP.Provincia_Id;
                ExcNoPos.Debe[0].FPDescripcionPcia = ExcP.DescripcionProvincias;
            }
            else
            {
                ExcNoPos.Debe[0].FPCuit = lRfc;
                ExcNoPos.Debe[0].FPRazonSocial = ((XmlElement)lndEmisor[0]).GetAttribute("Nombre");

            }

            if (lndComplemento.Count == 0)
            {
                object[] lParam = { "cfdi:Complemento" };
                Generalidades.qFunctionalException.GenerarExcepcion("El_xml_no_tiene_el_nodo_<0>", lParam);
            }


            if (lndTimbre.Count == 0)
            {
                object[] lParam = { "tfd:TimbreFiscalDigital" };
                Generalidades.qFunctionalException.GenerarExcepcion("El_xml_no_tiene_el_nodo_<0>", lParam);
            }

            lClaveFiscal = ((XmlElement)lndTimbre[0]).GetAttribute("UUID");

            if (String.IsNullOrEmpty(lFolio))
            {
                lFolio = lClaveFiscal.Substring(lClaveFiscal.Length-20,20);
            }

            XmlNodeList lndConceptos = ((XmlElement)lndComprobante[0]).GetElementsByTagName("cfdi:Conceptos");
            if (lndComplemento.Count == 0)
            {
                object[] lParam = { "cfdi:Conceptos" };
                Generalidades.qFunctionalException.GenerarExcepcion("El_xml_no_tiene_el_nodo_<0>", lParam);
            }

            if (DoH == "D")
            {
                //EJ 2021 01 19 si la serie estaba llena no la sobreescribo
                lSegmento1C = string.IsNullOrWhiteSpace(ExcNoPos.Debe[0].Segmento1C) ? lSegmento1C : ExcNoPos.Debe[0].Segmento1C;
                ExcNoPos.Debe[0].Segmento2C = lTipomov;
                ExcNoPos.Debe[0].Segmento1C =  lSegmento1C;
                ExcNoPos.Debe[0].Segmento3C = ExcNoPos.Debe[0].FPCuit;
                ExcNoPos.Debe[0].Segmento4C = lFolio;

                ExcNoPos.Debe[0].ImporteOrig = lImporte;
                ExcNoPos.Debe[0].Importe = Generalidades.Auxiliares.Redondear(lImporte * lCambio, 2);
                ExcNoPos.Debe[0].Segmento2C = lTipomov;
                ExcNoPos.Debe[0].Segmento1C = lSegmento1C;
                ExcNoPos.Debe[0].Segmento4C = lFolio;
                ExcNoPos.Debe[0].FPClaveFiscal = lClaveFiscal;
                if (ExcP.Existe)
                {
                    ExcNoPos.Debe[0].FPCondFiscal_Id = ExcP.CondFiscal_Id;
                    ExcNoPos.Debe[0].FPDescripcionCondFiscal = ExcP.DescripcionCondFiscal;
                    ExcNoPos.Debe[0].FPDireccion1 = ExcP.Direccion1;
                    ExcNoPos.Debe[0].FPDireccion2 = ExcP.Direccion1;

                }

                ExcNoPos.Debe[0].FPFechaFiscal = lFecha_CCP;
                ExcNoPos.Debe[0].FPFecha_Ane = lFecha_CCP;
                // TODO ??
                //ExcNoPos.Debe[0].FPIdFiscal = 
                ExcNoPos.Debe[0].FPOrigen_Id = 3;
                ExcNoPos.Debe[0].FPXMLFiscal = lDoc.InnerText;
                foreach (var ren in ExcNoPos.FactAneCuerpoDebe.Where(c => c.RenglonRenMovi == ExcNoPos.Debe[0].conRenglon))
                    ren.Delete();

                foreach (var ren in ExcNoPos.FactAneImpuestoDebe.Where(c => c.RenglonRenMovi == ExcNoPos.Debe[0].conRenglon))
                    ren.Delete();

                ExcNoPos.FactAneCuerpoDebe.AcceptChanges();
                ExcNoPos.FactAneImpuestoDebe.AcceptChanges();


            }
            else
            {
                //EJ 2021 01 19 si la serie estaba llena no la sobreescribo
                lSegmento1C = string.IsNullOrWhiteSpace(ExcNoPos.Haber[0].Segmento1C) ? lSegmento1C : ExcNoPos.Haber[0].Segmento1C;

                ExcNoPos.Haber[0].Segmento2C = lTipomov;
                ExcNoPos.Haber[0].Segmento1C = lSegmento1C;
                ExcNoPos.Haber[0].Segmento3C = ExcNoPos.Debe[0].FPCuit;
                ExcNoPos.Haber[0].Segmento4C = lFolio;

                ExcNoPos.Haber[0].ImporteOrig = lImporte;
                ExcNoPos.Haber[0].Importe = Generalidades.Auxiliares.Redondear(lImporte * lCambio, 2);
                ExcNoPos.Haber[0].Segmento2C = lTipomov;
                ExcNoPos.Haber[0].Segmento1C = lSegmento1C;
                ExcNoPos.Haber[0].Segmento4C = lFolio;

                ExcNoPos.Haber[0].FPClaveFiscal = lClaveFiscal;
                if (ExcP.Existe)
                {

                    ExcNoPos.Haber[0].FPCondFiscal_Id = ExcP.CondFiscal_Id;
                    ExcNoPos.Haber[0].FPDescripcionCondFiscal = ExcP.DescripcionCondFiscal;
                    ExcNoPos.Haber[0].FPDireccion1 = ExcP.Direccion1;
                    ExcNoPos.Haber[0].FPDireccion2 = ExcP.Direccion1;


                }

                ExcNoPos.Haber[0].FPFechaFiscal = lFecha_CCP;
                ExcNoPos.Haber[0].FPFecha_Ane = lFecha_CCP;
                // TODO ??
                //ExcNoPos.Debe[0].FPIdFiscal = 
                ExcNoPos.Haber[0].FPOrigen_Id = 3;
                ExcNoPos.Haber[0].FPXMLFiscal = lDoc.InnerText;
                foreach (var ren in ExcNoPos.FactAneCuerpoHaber.Where(c => c.RenglonRenMovi == ExcNoPos.Debe[0].conRenglon))
                    ren.Delete();

                foreach (var ren in ExcNoPos.FactAneImpuestoHaber.Where(c => c.RenglonRenMovi == ExcNoPos.Debe[0].conRenglon))
                    ren.Delete();


                ExcNoPos.FactAneCuerpoHaber.AcceptChanges();
                ExcNoPos.FactAneImpuestoHaber.AcceptChanges();
            }


            XmlNodeList lndConcepto = ((XmlElement)lndConceptos[0]).GetElementsByTagName("cfdi:Concepto");


            if (lndConcepto.Count > 0)
            {
                string lCodigo = ((XmlElement)lndConcepto[0]).GetAttribute(lVersion == "3.3" ? "NoIdentificacion" : "noIdentificacion");
                decimal lPrecioUnitario = Convert.ToDecimal(((XmlElement)lndConcepto[0]).GetAttribute(lVersion == "3.3" ? "ValorUnitario" : "valorUnitario"));
                decimal lCantidad = Convert.ToDecimal(((XmlElement)lndConcepto[0]).GetAttribute(lVersion == "3.3" ? "Cantidad" : "cantidad"));
                string lUnidad = ((XmlElement)lndConcepto[0]).GetAttribute(lVersion == "3.3" ? "Unidad" : "unidad");
                string lDescripcion = ((XmlElement)lndConcepto[0]).GetAttribute(lVersion == "3.3" ? "Descripcion" : "descripcion");
                decimal lImporteR = Generalidades.Auxiliares.Redondear(Convert.ToDecimal(((XmlElement)lndConcepto[0]).GetAttribute(lVersion == "3.3" ? "Importe" : "importe")), lDecimales);
                //EJ 2020 01 20 sumo los importes de los renglones y muestro uno solo
                // TODO CUENTAS
                if (DoH == "D")
                {
                    var reng = ExcNoPos.FactAneCuerpoDebe.AddFactAneCuerpoDebeRow(0, 0,
                            "", "", "", "", "", "", "", lDescripcion, lImporteR, ExcNoPos.Debe[0].conRenglon);
                    for (int i = 1; i < lndConcepto.Count; i++)
                    {
                        lImporteR = Generalidades.Auxiliares.Redondear(Convert.ToDecimal(((XmlElement)lndConcepto[i]).GetAttribute(lVersion == "3.3" ? "Importe" : "importe")), lDecimales);
                        reng.Importe += lImporteR;
                    }
                    

                }
                else
                {

                    var reng= ExcNoPos.FactAneCuerpoHaber.AddFactAneCuerpoHaberRow(0, 0,
                            "", "", "", "", "", "", "", lDescripcion, lImporteR, ExcNoPos.Haber[0].conRenglon);
                    for (int i = 1; i < lndConcepto.Count; i++)
                    {
                        lImporteR = Generalidades.Auxiliares.Redondear(Convert.ToDecimal(((XmlElement)lndConcepto[i]).GetAttribute(lVersion == "3.3" ? "Importe" : "importe")), lDecimales);
                        reng.Importe += lImporteR;
                    }

                }

                
            }

            // impuestos


            XmlNodeList lndImpuestos = ((XmlElement)lndComprobante[0]).GetElementsByTagName("cfdi:Impuestos");

            if (lndImpuestos.Count > 0)
            {
                XmlNodeList lndTraslados = ((XmlElement)lndImpuestos[lndImpuestos.Count-1]).GetElementsByTagName("cfdi:Traslados");

                if (lndTraslados.Count > 0)
                {
                    XmlNodeList lndTraslado = ((XmlElement)lndImpuestos[lndImpuestos.Count-1]).GetElementsByTagName("cfdi:Traslado");
                    for (int i = 0; i < lndTraslado.Count; i++)
                    {
                        string lTipo = ((XmlElement)lndTraslado[i]).GetAttribute(lVersion == "3.3" ? "Impuesto" : "impuesto");
                        decimal lTasa = 0;
                        decimal lImporteI = 0;
                        int lTipoImpuesto = 9;
                        if (((XmlElement)lndTraslado[i]).GetAttribute("TipoFactor") != "Exento")
                        {
                            lTasa = Convert.ToDecimal(((XmlElement)lndTraslado[i]).GetAttribute(lVersion == "3.3" ? "TasaOCuota" : "tasa"));
                            if (lVersion == "3.3")
                                lTasa = lTasa * 100;

                            lImporteI = Generalidades.Auxiliares.Redondear(Convert.ToDecimal(((XmlElement)lndTraslado[i]).GetAttribute(lVersion == "3.3" ? "Importe" : "importe")), lDecimales);
                        }

                        //string lCodigoFiscal = "OT";

                        switch (lTipo)
                        {
                            case "002":
                            case "IVA":
                                lTipoImpuesto = 9;
                              
                                break;
                            case "001":
                            case "IEPS":
                                // lCodigoFiscal = "OT";
                                lTipoImpuesto = 1;
                                break;

                        }


                        string lImpuesto_Id = "IVA16";
                        string lCuenta_Id = "";
                        string lDescripcion = "";

                        var eImpuesto = ComprasValidacion.comImpuestos.PorTipo(lTipoImpuesto, lTasa, lFecha_CCP, cmd);
                        if (eImpuesto.Existe)
                        {
                            lImpuesto_Id = eImpuesto.Impuesto_Id;
                            if (eImpuesto.PorAcreditacion)
                                lCuenta_Id = eImpuesto.CtaReversion;
                            else
                                lCuenta_Id = (DoH == "D") ? eImpuesto.CtaHaber : eImpuesto.CtaDebe;

                            lDescripcion = eImpuesto.Descripcion;
                        }

                        if (DoH == "D")
                        {

                            ExcNoPos.FactAneImpuestoDebe.AddFactAneImpuestoDebeRow(i,
                                    lImpuesto_Id, lDescripcion, lTasa, "",
                                        Generalidades.Auxiliares.Redondear(lImporteI / (1 + lTasa / 100), 2),
                                        lImporteI, lCuenta_Id, "", lCuenta_Id, "", "", "", "", "", ExcNoPos.Debe[0].conRenglon);
                        }
                        else
                        {

                            ExcNoPos.FactAneImpuestoHaber.AddFactAneImpuestoHaberRow(i,
                                    lImpuesto_Id, lDescripcion, lTasa, "",
                                        Generalidades.Auxiliares.Redondear(lImporteI / (1 + lTasa / 100), 2),
                                        lImporteI, lCuenta_Id, "", lCuenta_Id, "", "", "", "", "", ExcNoPos.Haber[0].conRenglon);

                        }


                    }


                }
                // Retenciones
                XmlNodeList lndRetenciones = ((XmlElement)lndImpuestos[lndImpuestos.Count-1]).GetElementsByTagName("cfdi:Retenciones");
                if (lndRetenciones.Count > 0)
                {
                    XmlNodeList lndRetencion = ((XmlElement)lndImpuestos[lndImpuestos.Count-1]).GetElementsByTagName("cfdi:Retencion");
                    XmlNodeList lndRetencionesP = ((XmlElement)lndImpuestos[0]).GetElementsByTagName("cfdi:Retencion");
                    for (int i = 0; i < lndRetencion.Count; i++)
                    {
                        string lTipo = ((XmlElement)lndRetencion[i]).GetAttribute(lVersion == "3.3" ? "Impuesto" : "impuesto");
                        
                        string lTasaStr = "";
                        if (lndRetencionesP.Count > 0)
                        {
                            lTasaStr = ((XmlElement)lndRetencionesP[0]).GetAttribute(lVersion == "3.3" ? "TasaOCuota" : "tasa");
                        }
                        if (String.IsNullOrWhiteSpace(lTasaStr))
                            lTasaStr = "0";
                        decimal lTasa = Convert.ToDecimal(lTasaStr);
                        if (lVersion == "3.3")
                            lTasa = lTasa * 100;
                        decimal lImporteI = -Convert.ToDecimal(((XmlElement)lndRetencion[i]).GetAttribute(lVersion == "3.3" ? "Importe" : "importe"));

                        //string lCodigoFiscal = "OT";
                        int lTipoImpuesto = 1;
                        switch (lTipo)
                        {
                            case "IVA":
                            case "002":
                                //lCodigoFiscal = "R1";
                                lTipoImpuesto = 7;
                                break;
                            case "001":
                            case "ISR":
                                //lCodigoFiscal = "RS";
                                lTipoImpuesto = 13;
                                break;

                        }




                        string lImpuesto_Id = "RISR";
                        string lCuenta_Id = "";
                        string lDescripcion = "";

                        var eImpuesto = ComprasValidacion.comImpuestos.PorTipo(lTipoImpuesto, lTasa, lFecha_CCP, cmd);
                        if (eImpuesto.Existe)
                        {
                            lImpuesto_Id = eImpuesto.Impuesto_Id;
                            if (eImpuesto.PorAcreditacion)
                                lCuenta_Id = eImpuesto.CtaReversion;
                            else
                                lCuenta_Id = (DoH == "D") ? eImpuesto.CtaHaber : eImpuesto.CtaDebe;

                            lDescripcion = eImpuesto.Descripcion;
                            lTasa = eImpuesto.Porcentaje;
                        }
                        if (DoH == "D")
                        {
                            if (lTasa != 0)
                            {
                                ExcNoPos.FactAneImpuestoDebe.AddFactAneImpuestoDebeRow(i,
                                        lImpuesto_Id, lDescripcion, -lTasa, "",
                                            Generalidades.Auxiliares.Redondear(-lImporteI / (lTasa / 100), 2),
                                            lImporteI, lCuenta_Id, "", lCuenta_Id, "", "", "", "", "", ExcNoPos.Debe[0].conRenglon);
                            }
                        }
                        else
                        {
                            if (lTasa != 0)
                            {
                                ExcNoPos.FactAneImpuestoHaber.AddFactAneImpuestoHaberRow(i,
                                    lImpuesto_Id, lDescripcion, -lTasa, "",
                                        Generalidades.Auxiliares.Redondear(-lImporteI / (lTasa / 100), 2),
                                        lImporteI, lCuenta_Id, "", lCuenta_Id, "", "", "", "", "", ExcNoPos.Debe[0].conRenglon);
                            }
                        }


                    }


                }



            }
            ExcNoPos.AcceptChanges();
            return ExcNoPos;

        }

        public enum tesRengMoviVirtualVar
        {
            ModiCentro1Debe,
            ModiCentro2Debe,
            TipoCarteraDebe,
            ModiCuentaDebe,
            EnMonedaBaseDebe,
            ModiCentro1Haber,
            ModiCentro2Haber,
            TipoCarteraHaber,
            ModiCuentaHaber,
            EnMonedaBaseHaber,
            MonCarteraEsPpal // La moneda de la cartera es la moneda principal del movimiento


        }
        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> AsignarVariablesDebe(TesoreriaCommon.tesMovimientosDatosBaseDS Exch, TesoreriaCommon.tesMovimientosDatosBaseDS Exch2, int pIndice, Framework.Core.Command cmd)
        {
            Dictionary<string, string> lRetorno = new Dictionary<string, string>();
            return lRetorno;
        }
        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> AsignarVariablesHaber(TesoreriaCommon.tesMovimientosDatosBaseDS Exch, TesoreriaCommon.tesMovimientosDatosBaseDS Exch2, int pIndice, Framework.Core.Command cmd)
        {
            Dictionary<string, string> lRetorno = new Dictionary<string, string>();
            return lRetorno;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS AsignarMontoAnticipo(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                   TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {



            ExcNoPos.AntClientes[0].Importe = Generalidades.Auxiliares.Redondear(ExcNoPos.AntClientes[0].ImporteMonedaOriginal *
                    ExcPost.Principal[0].Cambio, 2);

            ExcNoPos.AntClientes[0].Cambio = ExcPost.Principal[0].Cambio;


            return ExcNoPos;

        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS ChequesEnCartera(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                   TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            // Tomo la Cartera que seleccionaron

            return ExcNoPos;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS CalcularImpuestoDebe(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                   TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            // FM 12/02/20202 //
            // En grilla de grilla, el ExcNoPos no viene solamente con 1 registro sino que viene con todos los que tenga //
            if (Indice < 0)
                Indice = ExcNoPos.FactAneImpuestoDebe.Count - 1;

            //ExcNoPos.FactAneImpuestoDebe[0].Importe_Impuesto = Math.Round(ExcNoPos.FactAneImpuestoDebe[0].Base_Imponible * ExcNoPos.FactAneImpuestoDebe[0].Porcentaje / 100, 2);
            ExcNoPos.FactAneImpuestoDebe[Indice].Importe_Impuesto = Generalidades.Auxiliares.Redondear(
                ExcNoPos.FactAneImpuestoDebe[Indice].Base_Imponible * ExcNoPos.FactAneImpuestoDebe[Indice].Porcentaje / 100, 2);

            return ExcNoPos;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS CalcularImpuestoDebeGlobal(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                   TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            // Se llama desde los renglones del Cuerpo
            decimal lBase = 0;
            for (int i = 0; i < ExcNoPos.FactAneCuerpoDebe.Count; i++)
            {
                //if (i != Indice)
                lBase += ExcNoPos.FactAneCuerpoDebe[i].Importe;
            }

            //lBase += ExcNoPos.FactAneCuerpoDebe[0].Importe;

            for (int i = 0; i < ExcNoPos.FactAneImpuestoDebe.Count; i++)
            {

                ExcNoPos.FactAneImpuestoDebe[i].Base_Imponible = lBase;
                decimal lSigno = 1;
                if (!ExcNoPos.FactAneImpuestoDebe[i].IsFormulaCalcNull())
                    lSigno = (ExcNoPos.FactAneImpuestoDebe[i].FormulaCalc.StartsWith("-") ? -1 : 1);

                ExcNoPos.FactAneImpuestoDebe[i].Importe_Impuesto = Math.Round(ExcNoPos.FactAneImpuestoDebe[i].Base_Imponible * ExcNoPos.FactAneImpuestoDebe[i].Porcentaje / 100, 2) * lSigno;
            }
            return ExcNoPos;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS FactAneValoresSugeridos(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                   TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            // Se llama al Cambiar el Proveedor
            ComprasExchange.comFactTesValoresSugeridosActionExchange ExcSu =
                    new ComprasExchange.comFactTesValoresSugeridosActionExchange(ComprasExchange.comFactTesValoresSugeridosActionEnum.EnumcomFactTesValoresSugeridosAction.Datos);


            ExcSu.Proveed_id = ExcNoPos.Debe[0].FPCuit;
            ExcSu.Fecha = ExcNoPos.Debe[0].FPFecha_Ane;
            ExcSu = new ComprasExchange.comFactTesValoresSugeridosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcSu, cmd));

            if (ExcSu.Existe)
            {

                ExcNoPos.FactAneCuerpoDebe.Clear();
                if (ExcSu.Param.Cuentas.Count > 0)
                {
                    ExcSu.Param.Cuentas.ToList().ForEach(r =>
                   {
                       ExcNoPos.FactAneCuerpoDebe.AddFactAneCuerpoDebeRow(0, 0, r.Cuenta_Id, r.Descripcion, r.Centro1_Id, "",
                               r.Centro2_Id, "", "", r.DETALLE, 0, ExcNoPos.Debe[0].conRenglon);
                   }
                    );
                }

                ExcNoPos.FactAneImpuestoDebe.Clear();
                for (int i = 0; i < ExcSu.Param.Impuestos.Count; i++)
                {
                    ExcNoPos.FactAneImpuestoDebe.AddFactAneImpuestoDebeRow(0,
                            ExcSu.Param.Impuestos[i].Impuesto_Id,
                            ExcSu.Param.Impuestos[i].Descripcion,
                            ExcSu.Param.Impuestos[i].Porcentaje, ExcSu.Param.Impuestos[i].Formulacalc,
                            0, 0, "", "", "", "", "", "", "", "", ExcNoPos.Debe[0].conRenglon);
                }

                ExcNoPos.AcceptChanges();

            }

            return ExcNoPos;

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public static string EsProvMenor(TesoreriaCommon.tesMovimientosDatosBaseDS.DebeRow Dt, Framework.Core.Command cmd)
        {
            ComprasExchange.comProveedoresActionExchange excProv =
                    new ComprasExchange.comProveedoresActionExchange(ComprasExchange.comProveedoresActionEnum.EnumcomProveedoresAction.Datos);
            excProv.Proveed_Id = Dt.FPCuit;
            excProv = new ComprasExchange.comProveedoresActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(excProv, cmd));

            return (!excProv.Existe || excProv.Especializacion == "A" ? "S" : "N");
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS CalcularTotalAne(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            ExcNoPos.Debe[0].ImporteOrig = 0;
            for (int i = 0; i < ExcNoPos.FactAneCuerpoDebe.Count; i++)
            {
                ExcNoPos.Debe[0].ImporteOrig += ExcNoPos.FactAneCuerpoDebe[i].Importe;

            }

            for (int i = 0; i < ExcNoPos.FactAneImpuestoDebe.Count; i++)
            {
                ExcNoPos.Debe[0].ImporteOrig += ExcNoPos.FactAneImpuestoDebe[i].Importe_Impuesto;
            }

            ExcNoPos.Debe[0].Importe = ExcNoPos.Debe[0].ImporteOrig * ExcNoPos.Debe[0].Cambio;

            return ExcNoPos;
            //return AsignarMontoDebe(ExcPost, ExcNoPos, Indice, cmd);

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public static string TDFormaPago(TesoreriaCommon.tesMovimientosDatosBaseDS.DebeRow Dt, Framework.Core.Command cmd)
        {
            return (Dt.TDFormaDePagoP);
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public static string TDTipoCadena(TesoreriaCommon.tesMovimientosDatosBaseDS.DebeRow Dt, Framework.Core.Command cmd)
        {
            return (Dt.TDTipoCadPago);
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public static string TDExtranjero(TesoreriaCommon.tesMovimientosDatosBaseDS.DebeRow Dt, Framework.Core.Command cmd)
        {
            return (Dt.TDRfcEmisorCtaOrd.Trim() == "XEXX010101000" ? "S" : "N");
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS LeerDatosChequeDebe(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos,
TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            // FM 04/03/2021 FM Hay lectores que no agregan una C y una E sino un ; y : así que ya no pregunto por los caracteres //
            //if (ExcNoPos.Debe[0].CTLectoraCheques.Substring(0, 1) == "C" || ExcNoPos.Debe[0].CTLectoraCheques.Substring(30, 1) == "E")
            if (ExcNoPos.Debe[0].CTLectoraCheques.Length == 31)
            {
                // Leyó bien el cheque //

                // Asigno el banco //
                ExcNoPos.Debe[0].CTBanco_Id = ExcNoPos.Debe[0].CTLectoraCheques.Substring(1, 3);

                // Asigno la sucursal del banco //
                ExcNoPos.Debe[0].CTsucBanco = ExcNoPos.Debe[0].CTLectoraCheques.Substring(4, 3);

                // Todos los cheques son 48 hs //
                ExcNoPos.Debe[0].CTClearing = "48";

                // Asigno el número de cheque //
                ExcNoPos.Debe[0].CTnumCheque = Convert.ToInt32(ExcNoPos.Debe[0].CTLectoraCheques.Substring(11, 8));

                // Asigna cuenta banco //
                ExcNoPos.Debe[0].CTcuentaBanco = ExcNoPos.Debe[0].CTLectoraCheques.Substring(19, 11);

            };

            return ExcNoPos;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS LeerDatosChequeHaber(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos,
TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            // FM 04/03/2021 FM Hay lectores que no agregan una C y una E sino un ; y : así que ya no pregunto por los caracteres //
            //if (ExcNoPos.Haber[0].CTLectoraCheques.Substring(0, 1) == "C" || ExcNoPos.Haber[0].CTLectoraCheques.Substring(30, 1) == "E")
            if(ExcNoPos.Haber[0].CTLectoraCheques.Length == 31)
            {
                // Leyó bien el cheque //

                // Busco el cheque leído dentro del dt y lo marco //
                ExcNoPos.CheqTercerosHaber.ToList().Where(ch => ch.numCheque == Convert.ToInt32(ExcNoPos.Haber[0].CTLectoraCheques.Substring(11, 8)) &&
                ch.Banco_Id == ExcNoPos.Haber[0].CTLectoraCheques.Substring(1, 3) &&
                ch.sucBanco == ExcNoPos.Haber[0].CTLectoraCheques.Substring(4, 3)).ToList().ForEach(ch => ch.Marca = true);
            };

            return ExcNoPos;
        }


        ///////////
        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS CalcularImpuestoHaber(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
           TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            // FM 12/02/20202 //
            // En grilla de grilla, el ExcNoPos no viene solamente con 1 registro sino que viene con todos los que tenga //
            if (Indice < 0)
                Indice = ExcNoPos.FactAneImpuestoDebe.Count - 1;

            //ExcNoPos.FactAneImpuestoHaber[0].Importe_Impuesto = Math.Round(ExcNoPos.FactAneImpuestoHaber[0].Base_Imponible *
            //    ExcNoPos.FactAneImpuestoHaber[0].Porcentaje / 100, 2);
            ExcNoPos.FactAneImpuestoHaber[Indice].Importe_Impuesto = Generalidades.Auxiliares.Redondear(
                ExcNoPos.FactAneImpuestoHaber[Indice].Base_Imponible * ExcNoPos.FactAneImpuestoHaber[Indice].Porcentaje / 100, 2);

            return ExcNoPos;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS CalcularImpuestoHaberGlobal(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                   TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            // Se llama desde los renglones del Cuerpo
            decimal lBase = 0;
            for (int i = 0; i < ExcNoPos.FactAneCuerpoHaber.Count; i++)
            {
                //if (i != Indice)
                lBase += ExcNoPos.FactAneCuerpoHaber[i].Importe;
            }

            //lBase += ExcNoPos.FactAneCuerpoDebe[0].Importe;

            for (int i = 0; i < ExcNoPos.FactAneImpuestoHaber.Count; i++)
            {

                ExcNoPos.FactAneImpuestoHaber[i].Base_Imponible = lBase;
                decimal lSigno = 1;
                if (!ExcNoPos.FactAneImpuestoHaber[i].IsFormulaCalcNull())
                    lSigno = (ExcNoPos.FactAneImpuestoHaber[i].FormulaCalc.StartsWith("-") ? -1 : 1);

                ExcNoPos.FactAneImpuestoHaber[i].Importe_Impuesto = Math.Round(ExcNoPos.FactAneImpuestoHaber[i].Base_Imponible *
                    ExcNoPos.FactAneImpuestoHaber[i].Porcentaje / 100, 2) * lSigno;
            }
            return ExcNoPos;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS FactAneValoresSugeridosHaber(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                   TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            // Se llama al Cambiar el Proveedor
            ComprasExchange.comFactTesValoresSugeridosActionExchange ExcSu = new ComprasExchange.comFactTesValoresSugeridosActionExchange
                    (ComprasExchange.comFactTesValoresSugeridosActionEnum.EnumcomFactTesValoresSugeridosAction.Datos);


            ExcSu.Proveed_id = ExcNoPos.Haber[0].FPCuit;
            ExcSu.Fecha = ExcNoPos.Haber[0].FPFecha_Ane;
            ExcSu = new ComprasExchange.comFactTesValoresSugeridosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcSu, cmd));

            if (ExcSu.Existe)
            {

                ExcNoPos.FactAneCuerpoHaber.Clear();
                if (ExcSu.Param.Cuentas.Count > 0)
                {
                    ExcSu.Param.Cuentas.ToList().ForEach(r =>
                    {
                        ExcNoPos.FactAneCuerpoHaber.AddFactAneCuerpoHaberRow(0, 0, r.Cuenta_Id, r.Descripcion, r.Centro1_Id, "",
                                r.Centro2_Id, "", "", r.DETALLE, 0, ExcNoPos.Haber[0].conRenglon);
                    }
                    );
                }

                ExcNoPos.FactAneImpuestoHaber.Clear();
                for (int i = 0; i < ExcSu.Param.Impuestos.Count; i++)
                {
                    ExcNoPos.FactAneImpuestoHaber.AddFactAneImpuestoHaberRow(0,
                            ExcSu.Param.Impuestos[i].Impuesto_Id,
                            ExcSu.Param.Impuestos[i].Descripcion,
                            ExcSu.Param.Impuestos[i].Porcentaje, ExcSu.Param.Impuestos[i].Formulacalc,
                            0, 0, "", "", "", "", "", "", "", "", ExcNoPos.Haber[0].conRenglon);
                }

                ExcNoPos.AcceptChanges();

            }

            return ExcNoPos;

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public static string EsProvMenorHaber(TesoreriaCommon.tesMovimientosDatosBaseDS.HaberRow Dt, Framework.Core.Command cmd)
        {
            ComprasExchange.comProveedoresActionExchange excProv =
                    new ComprasExchange.comProveedoresActionExchange(ComprasExchange.comProveedoresActionEnum.EnumcomProveedoresAction.Datos);
            excProv.Proveed_Id = Dt.FPCuit;
            excProv = new ComprasExchange.comProveedoresActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(excProv, cmd));

            return (!excProv.Existe || excProv.Especializacion == "A" ? "S" : "N");
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS CalcularTotalAneHaber(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            ExcNoPos.Haber[0].ImporteOrig = 0;
            for (int i = 0; i < ExcNoPos.FactAneCuerpoHaber.Count; i++)
            {
                ExcNoPos.Haber[0].ImporteOrig += ExcNoPos.FactAneCuerpoHaber[i].Importe;

            }

            for (int i = 0; i < ExcNoPos.FactAneImpuestoHaber.Count; i++)
            {
                ExcNoPos.Haber[0].ImporteOrig += ExcNoPos.FactAneImpuestoHaber[i].Importe_Impuesto;
            }

            ExcNoPos.Haber[0].Importe = ExcNoPos.Haber[0].ImporteOrig * ExcNoPos.Haber[0].Cambio;

            return ExcNoPos;
            //return AsignarMontoDebe(ExcPost, ExcNoPos, Indice, cmd);

        }

        [Generalidades.QFuncion_Condicion]
        public static string TieneCliente(TesoreriaCommon.tesMovimientosDatosBaseDS Exch, Command cmd)
        {
            if (!Exch.Principal[0].IsCliente_IdNull() && Exch.Principal[0].Cliente_Id != "")
                return "S";
            return "N";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public static string PideDatosCheque(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos,
           TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            if (cmd.Dominio_Id == "MX")
                return "S";

            if(ExcNoPos.Haber[0].CPChequera_Id != 0)
            {
                tesChequerasActionExchange exchChequera = new tesChequerasActionExchange(tesChequerasActionEnum.EnumtesChequerasAction.Datos)
                {
                    Cartera_Id = ExcNoPos.Haber[0].Cartera_Id,
                    Chequera_id = ExcNoPos.Haber[0].CPChequera_Id
                };
                exchChequera = new tesChequerasActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchChequera, cmd));
                if (exchChequera.Existe && exchChequera.TipoChequera == "B")
                    // Es transferencia //
                    return "N";
            }
            return "S";
        }
        
        [Generalidades.QFuncion_AccionGrilla]
        public TesoreriaCommon.tesMovimientosDatosBaseDS ClabeCliente(TesoreriaCommon.tesMovimientosDatosBaseDS pCommonDS, TesoreriaCommon.tesMovimientosDatosBaseDS pCommonDSNoPost, int pIndice, Command cmd)
        {
            VentasExchange.venClientesActionExchange eClie = new VentasExchange.venClientesActionExchange(VentasExchange.venClientesActionEnum.EnumvenClientesAction.Datos)
            {
                Cliente_Id = pCommonDS.Principal[0].Cliente_Id
            };
            eClie = new VentasExchange.venClientesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eClie, cmd));
            if (!eClie.Existe)
                return pCommonDS;
            VentasExchange.venClieHabitualActionExchange eClieHab = new VentasExchange.venClieHabitualActionExchange(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos)
            {
                Cliente_Id = eClie.Cliente_Id,
                Sucursal=eClie.SucursalPredeter
            };
            eClieHab = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eClieHab, cmd));
            if (eClieHab.NumCuenta.Length<3)
                return pCommonDS;

            pCommonDS.Debe[pIndice].TDCtaOrdenante = eClieHab.NumCuenta;
            TesoreriaExchange.tesBancosActionExchange eBanco = new tesBancosActionExchange(TesoreriaExchange.tesBancosActionEnum.EnumtesBancosAction.Datos)
            {
                Banco_Id = eClieHab.NumCuenta.Substring(3)
            };
            eBanco = new tesBancosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eBanco, cmd));
            if (eBanco.Existe)
                pCommonDS.Debe[pIndice].TDRfcEmisorCtaOrd = eBanco.RFC;
            return pCommonDS;
        }
    }
}
