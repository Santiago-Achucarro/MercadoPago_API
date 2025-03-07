using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesoreriaExchange;
using Framework.Core;

namespace TesoreriaFEEventos
{
    public class tesMovientos
    {

        [Generalidades.QFuncion_Condicion]
        public string ClearingVariable(TesoreriaCommon.tesRengMoviDebeDS exch, Framework.Core.Command cmd)
        {
            if (exch.Debe.Count == 0 || exch.Debe[0].CTClearing == "")
            {
                return "N";
            }

            TesoreriaExchange.tesClearingActionExchange ExcCL =
                    new TesoreriaExchange.tesClearingActionExchange(TesoreriaExchange.tesClearingActionEnum.EnumtesClearingAction.Datos);

            ExcCL.Clearing = exch.Debe[0].CTClearing;
            ExcCL = new TesoreriaExchange.tesClearingActionExchange(
                        Generalidades.QBIInternal.WrapperExecuteActionInternal(
                        ExcCL, cmd));
            if (!ExcCL.Existe)
                return "N";

            return (ExcCL.cVariable);
        }

        [Generalidades.QFuncion_AccionGrilla]
        public TesoreriaCommon.tesMovimientosDatosBaseDS AsignarMontoDebe(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                    TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {

            return (TesoreriaFEEventos.tesRengMoviVirtual.AsignarMontoDebe(ExcPost, ExcNoPos, Indice, cmd));

        }

        [Generalidades.QFuncion_AccionGrilla]
        public TesoreriaCommon.tesMovimientosDatosBaseDS AsignarMontoHaber(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                 TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            return (TesoreriaFEEventos.tesRengMoviVirtual.AsignarMontoHaber(ExcPost, ExcNoPos, Indice, cmd));

        }


        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS AsignarCheque(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
              TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            return (TesoreriaFEEventos.tesRengMoviVirtual.AsignarCheque(ExcPost, ExcNoPos, Indice, cmd));
        }


        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS AsignarDatosDestinatario(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
      TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            return (TesoreriaFEEventos.tesRengMoviVirtual.AsignarDatosDestinatario(ExcPost, ExcNoPos, Indice, cmd));
        }


        [Generalidades.QFuncion_CondicionGrilla]
        public static string ValidarCheqProp(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos,
   TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            return tesRengMoviVirtual.ValidarCheqProp(ExcPos, ExcNoPos, Indice, cmd);
        }

        [Generalidades.QFuncion_AccionGrilla]
        public TesoreriaCommon.tesMovimientosDatosBaseDS LeerXmlDebe(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                    TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {

            return (TesoreriaFEEventos.tesRengMoviVirtual.LeerXml(ExcPost, ExcNoPos, Indice, "D", cmd));

        }

        [Generalidades.QFuncion_AccionGrilla]
        public TesoreriaCommon.tesMovimientosDatosBaseDS LeerXmlHaber(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                    TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {

            return (TesoreriaFEEventos.tesRengMoviVirtual.LeerXml(ExcPost, ExcNoPos, Indice, "H", cmd));

        }

        public enum tesMovientosVar
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
            CarteraDebe,
            CarteraHaber,
            EnMonedaBase,
            MonCarteraEsPpal, // La moneda de la cartera es la moneda principal del movimiento
            FechaAperturaCaja,
            UsaLectoraCheques
        }


        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> AsignarVariablesDebe(TesoreriaCommon.tesMovimientosDatosBaseDS Exch, TesoreriaCommon.tesMovimientosDatosBaseDS Exch2, int pIndice, Framework.Core.Command cmd)
        {
            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            string Cartera_Id = Exch2.Debe[0].Cartera_Id;
            string lModiCentro1 = "N";
            string lModiCentro2 = "N";
            string lModiCuenta = "N";
            string lEnMonedaBase = "S";
            string lTipoCartera = " ";
            string lMonCarteraEsPpal = "S";

            if (Cartera_Id != "")
            {

                TesoreriaExchange.tesIdentificaActionExchange Exc =
                    TesoreriaValidacion.tesIdentifica.ExistePosteadoyActivo(Cartera_Id, cmd);
                if (Exc.Existe)
                {
                    lModiCentro1 = Exc.ModiCent1 ? "S" : "N";
                    lModiCentro2 = Exc.ModiCent2 ? "S" : "N";
                    lTipoCartera = Exc.TipoCartera;
                    // para cheques regreso el dominio tambien
                    if (lTipoCartera == "CP")
                        lTipoCartera += cmd.Dominio_Id;

                    if (lTipoCartera == "CT")
                    {
                        if (Exch.Principal[0].SubTipo_Id == "CR3")
                            lTipoCartera = "CTRE";
                    }
                    lEnMonedaBase = Exc.Moneda_Id.ToUpper() == cmd.MonedaBase.ToUpper() ? "S" : "N";
                    lMonCarteraEsPpal = Exc.Moneda_Id.ToUpper() == Exch.Principal[0].Moneda_Id.ToUpper() ? "S" : "N";


                    if (Exc.TipoCartera == "VA")
                    {
                        TesoreriaExchange.tesIdVariosActionExchange ExcVa =
                                new TesoreriaExchange.tesIdVariosActionExchange(TesoreriaExchange.tesIdVariosActionEnum.EnumtesIdVariosAction.Datos);

                        ExcVa.Cartera_id = Cartera_Id;

                        ExcVa = new TesoreriaExchange.tesIdVariosActionExchange(
                                Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVa, cmd));

                        if (ExcVa.Existe)
                            lModiCuenta = ExcVa.Modi_Cuenta ? "S" : "N";


                    }

                }
            }
            lRetorno.Add(tesMovientosVar.ModiCentro1Debe.ToString(), lModiCentro1);
            lRetorno.Add(tesMovientosVar.ModiCentro2Debe.ToString(), lModiCentro2);
            lRetorno.Add(tesMovientosVar.ModiCuentaDebe.ToString(), lModiCuenta);
            lRetorno.Add(tesMovientosVar.TipoCarteraDebe.ToString(), lTipoCartera);
            lRetorno.Add(tesMovientosVar.EnMonedaBaseDebe.ToString(), lEnMonedaBase);
            lRetorno.Add(tesMovientosVar.CarteraDebe.ToString(), Cartera_Id);
            lRetorno.Add(tesMovientosVar.MonCarteraEsPpal.ToString(), lMonCarteraEsPpal);
            return lRetorno;
        }


        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> AsignarVariables(TesoreriaCommon.tesMovimientosDatosBaseDS Exch, TesoreriaCommon.tesMovimientosDatosBaseDS Exch2, int pIndice, Framework.Core.Command cmd)
        {
            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            string lEnMonedaBase = "S";
            lEnMonedaBase = Exch.Principal[0].Moneda_Id.ToUpper() == cmd.MonedaBase.ToUpper() ? "S" : "N";

            lRetorno.Add(tesMovientosVar.UsaLectoraCheques.ToString(), Generalidades.Auxiliares.GetValorString("CTUsaLectoraCheques", "N", cmd));

            lRetorno.Add(tesMovientosVar.EnMonedaBase.ToString(), lEnMonedaBase);
            

            DateTime FechaCaja= 
            GeneralesValidacion.genSucursalesEmpr.Existe(
                GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Sucursal,
                cmd
                ).FechaCaja;

            // FM 22/04/2020 Asignar la fecha con formato //
            lRetorno.Add(tesMovientosVar.FechaAperturaCaja.ToString(), FechaCaja.Date.ToString("dd/MM/yyyy"));
            return lRetorno;
        } 


        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> AsignarVariablesHaber(TesoreriaCommon.tesMovimientosDatosBaseDS Exch, TesoreriaCommon.tesMovimientosDatosBaseDS Exch2, int pIndice, Framework.Core.Command cmd)
        {
            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            string Cartera_Id = Exch2.Haber[0].Cartera_Id;
            string lModiCentro1 = "N";
            string lModiCentro2 = "N";
            string lModiCuenta = "N";
            string lEnMonedaBase = "S";
            string lTipoCartera = " ";
            string lMonCarteraEsPpal = "S";

            if (Cartera_Id != "")
            {

                TesoreriaExchange.tesIdentificaActionExchange Exc =
                    TesoreriaValidacion.tesIdentifica.ExistePosteadoyActivo(Cartera_Id, cmd);
                if (Exc.Existe)
                {
                    lModiCentro1 = Exc.ModiCent1 ? "S" : "N";
                    lModiCentro2 = Exc.ModiCent2 ? "S" : "N";
                    lTipoCartera = Exc.TipoCartera;
                    lEnMonedaBase = Exc.Moneda_Id == cmd.MonedaBase ? "S" : "N";
                    lMonCarteraEsPpal = Exc.Moneda_Id == Exch.Principal[0].Moneda_Id ? "S" : "N";


                    if (Exc.TipoCartera == "VA")
                    {
                        TesoreriaExchange.tesIdVariosActionExchange ExcVa =
                                new TesoreriaExchange.tesIdVariosActionExchange(TesoreriaExchange.tesIdVariosActionEnum.EnumtesIdVariosAction.Datos);

                        ExcVa.Cartera_id = Cartera_Id;

                        ExcVa = new TesoreriaExchange.tesIdVariosActionExchange(
                                Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVa, cmd));

                        if (ExcVa.Existe)
                            lModiCuenta = ExcVa.Modi_Cuenta ? "S" : "N";


                    }

                }
            }
            lRetorno.Add(tesMovientosVar.ModiCentro1Haber.ToString(), lModiCentro1);
            lRetorno.Add(tesMovientosVar.ModiCentro2Haber.ToString(), lModiCentro2);
            lRetorno.Add(tesMovientosVar.ModiCuentaHaber.ToString(), lModiCuenta);
            lRetorno.Add(tesMovientosVar.TipoCarteraHaber.ToString(), lTipoCartera);
            lRetorno.Add(tesMovientosVar.EnMonedaBaseHaber.ToString(), lEnMonedaBase);
            lRetorno.Add(tesMovientosVar.CarteraHaber.ToString(), Cartera_Id);
            lRetorno.Add(tesMovientosVar.MonCarteraEsPpal.ToString(), lMonCarteraEsPpal);

            return lRetorno;

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public static string ValidarAnticipo(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
            TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            if (ExcNoPost.AntClientes[0].Cuenta_Id == "")
                return "Debe_Ingresar_la_cuenta_de_Anticipos";

            if (ExcNoPost.AntClientes[0].ImporteMonedaOriginal <= 0)
                return "El_Importe_Debe_ser_Mayor_que_Cero";

            ContabilidadValidacion.conCuentas.ExistePosteadoActivaImputable(ExcNoPost.AntClientes[0].Cuenta_Id, cmd);

            return "";
        }

        [Generalidades.QFuncion_AccionGrilla]
        public TesoreriaCommon.tesMovimientosDatosBaseDS AsignarMontoAnticipo(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                   TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {

            return (TesoreriaFEEventos.tesRengMoviVirtual.AsignarMontoAnticipo(ExcPost, ExcNoPos, Indice, cmd));

        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS ChequesEnCartera(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                   TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            // Si estoy consultando una OP existente no tengo que traer los cheques en cartera sino los que se usaron en esta OP //
            if (!ExcPost.Principal[0].IstesMovimientosNull() && ExcPost.Principal[0].tesMovimientos > 0)
            {
                ExcNoPos.CarteraUnicaContra.Clear();
                ExcPost.Haber.Where(ren => !ren.IstesCheqTercerosNull() && ren.tesCheqTerceros > 0).ToList().ForEach(cheq =>
                {
                    ExcNoPos.CheqTercerosHaber.AddCheqTercerosHaberRow(true, ExcNoPos.Haber[0].Cartera_Id, "", cheq.CTBanco_Id, "", 
                        cheq.CTFechaVencimiento, cheq.CTsucBanco, cheq.CTnumCheque, "", cheq.CTCliente_Id, cheq.CTRazonSocial, 0, cheq.Importe, 
                        cheq.ImporteOrig, "");
                }
                );

                ExcNoPos.CarteraUnicaContra.AcceptChanges();
            }
            else
            {

                // Tomo la Cartera que seleccionaron
                TesoreriaExchange.tesMovimientosDatosBaseActionExchange Exc =
                        new TesoreriaExchange.tesMovimientosDatosBaseActionExchange
                        (TesoreriaExchange.tesMovimientosDatosBaseActionEnum.EnumtesMovimientosDatosBaseAction.TraeChequesCartera);

                Exc.Fecha = ExcPost.Principal[0].Fecha;
                Exc.Param.CarteraUnicaContra.Clear();
                Exc.Param.CarteraUnicaContra.AddCarteraUnicaContraRow(ExcNoPos.Haber[0].Cartera_Id, "", 0, 0, "C",
                    Generalidades.Nulls.NullDate, Generalidades.Nulls.NullDate, false, "", "");
                Exc = new TesoreriaExchange.tesMovimientosDatosBaseActionExchange
                    (Generalidades.QBIInternal.WrapperExecuteActionInternal(Exc, cmd));

                // Guardo la cartera en CarteraUnicaContra porque lo va a usar la acción TotalHaber //
                ExcPost.CarteraUnicaContra.Clear();
                ExcPost.CarteraUnicaContra.AddCarteraUnicaContraRow(ExcNoPos.Haber[0].Cartera_Id, "", 0, 0, "C",
                    Generalidades.Nulls.NullDate, Generalidades.Nulls.NullDate, false, "", "");
                ExcPost.CarteraUnicaContra.AcceptChanges();

                ExcNoPos.CheqTercerosHaber.Clear();
                ExcNoPos.CheqTercerosHaber.Merge(Exc.Param.CheqTercerosHaber, false);
                // Tengo que dejar marcados los mismos cheques que estaban marcados //
                ExcPost.Haber.Where(ren => !ren.IstesCheqTercerosNull()).ToList().ForEach(cheq =>
                {
                // Busco el mismo cheque en CheqTercerosHaber que es el dt que se edita en el popup //
                ExcNoPos.CheqTercerosHaber.Where(ren => ren.tesCheqTerceros == cheq.tesCheqTerceros).ToList().ForEach
                    (marcar => marcar.Marca = true);
                }
                );

                ExcPost.CheqTercerosHaber.Clear();
                //ExcNoPos.CheqTercerosHaber.Clear();

                ExcNoPos.CheqTercerosHaber.AcceptChanges();
            }
            return ExcNoPos;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS CalcularImpuestoDebe(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                 TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            return TesoreriaFEEventos.tesRengMoviVirtual.CalcularImpuestoDebe(ExcPost, ExcNoPos, Indice, cmd);
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS CalcularImpuestoDebeGlobal(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                   TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            return TesoreriaFEEventos.tesRengMoviVirtual.CalcularImpuestoDebeGlobal(ExcPost, ExcNoPos, Indice, cmd);
        }


        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS FactAneValoresSugeridos(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                   TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            return TesoreriaFEEventos.tesRengMoviVirtual.FactAneValoresSugeridos(ExcPost, ExcNoPos, Indice, cmd);
        }


        [Generalidades.QFuncion_CondicionGrilla]
        public static string EsProvMenor(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                    TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPost,
                    int pIndice, Framework.Core.Command cmd)
        {
            return TesoreriaFEEventos.tesRengMoviVirtual.EsProvMenor(ExcNoPost.Debe[0], cmd);
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS CalcularTotalAne(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
             TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            return TesoreriaFEEventos.tesRengMoviVirtual.CalcularTotalAne(ExcPost, ExcNoPos, Indice, cmd);
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public static string TDFormaPago(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                    TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPost,
                    int pIndice, Framework.Core.Command cmd)
        {
            return TesoreriaFEEventos.tesRengMoviVirtual.TDFormaPago(ExcNoPost.Debe[0], cmd);
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public static string TDTipoCadena(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                    TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPost,
                    int pIndice, Framework.Core.Command cmd)
        {
            return TesoreriaFEEventos.tesRengMoviVirtual.TDTipoCadena(ExcNoPost.Debe[0], cmd);
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public static string TDExtranjero(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                  TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPost,
                  int pIndice, Framework.Core.Command cmd)
        {
            return TesoreriaFEEventos.tesRengMoviVirtual.TDExtranjero(ExcNoPost.Debe[0], cmd);
        }


        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS CalcularDif(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos,
            TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {

            return TesoreriaFEEventos.tesRengMoviVirtual.CalcularDif(ExcPos, ExcNoPos, Indice, cmd);
        }


        [Generalidades.QFuncion_Condicion]
        public string MovimientoAnulado(TesoreriaCommon.tesMovimientosDatosBaseDS exch, Framework.Core.Command cmd)
        {
            // FM 29/07/2019 //
            // Venía en null en campo Anulado //
            if (!exch.Principal[0].IsAnuladoNull() && exch.Principal[0].Anulado)
            {
                return "S";
            }
            return "N";
        }
        //[Generalidades.QFuncion_AccionObtenerVariables]
        //public Dictionary<string, string> FechaAperturaCaja(TesoreriaCommon.tesMovimientosDatosBaseDS Exch, TesoreriaCommon.tesMovimientosDatosBaseDS Exch2, int pIndice, Framework.Core.Command cmd)
        //{
        //    Dictionary<string, string> lRetorno = new Dictionary<string, string>();
        //    GeneralesExchange.genUsuariosActionExchange eUsu = new GeneralesExchange.genUsuariosActionExchange(GeneralesExchange.genUsuariosActionEnum.EnumgenUsuariosAction.DatosIdentity)
        //    {
        //        genUsuarios = cmd.Usuario_Id
        //    };
        //    eUsu = new GeneralesExchange.genUsuariosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eUsu, cmd));


        //    GeneralesExchange.genSucursalesEmprActionExchange eSucursal = new GeneralesExchange.genSucursalesEmprActionExchange(GeneralesExchange.genSucursalesEmprActionEnum.EnumgenSucursalesEmprAction.Datos)
        //    {
        //        Sucursal = eUsu.Sucursal
        //    };
        //    eSucursal = new GeneralesExchange.genSucursalesEmprActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eSucursal, cmd));
        //    lRetorno.Add(tesMovientosVar.FechaAperturaCaja.ToString(), eSucursal.FechaCaja.Date.ToString());
        //    return lRetorno;
        //}

        [Generalidades.QFuncion_AccionDescargarFila]
        public Generalidades.DescargaArchivoDS Pdf(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos,
            TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            tesRengMoviRetProvActionExchange ExchRet = new tesRengMoviRetProvActionExchange
                (tesRengMoviRetProvActionEnum.EnumtesRengMoviRetProvAction.Datos)
            {
                tesMovimientos = ExcPos.Adjuntos[Indice].tesMovimientos,
                conRenglon = ExcPos.Adjuntos[Indice].conRenglon
            };

            ExchRet = new tesRengMoviRetProvActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Framework.Core.Exchange(ExchRet),cmd));
            if(ExchRet.Existe)
            {
                ExchRet.Action = TesoreriaExchange.tesRengMoviRetProvActionEnum.GetAcciontesRengMoviRetProvAction
                    (tesRengMoviRetProvActionEnum.EnumtesRengMoviRetProvAction.DevolverPDF);
                ExchRet = new tesRengMoviRetProvActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                    (new Framework.Core.Exchange(ExchRet), cmd));

                if (ExchRet.PDF == "")
                    Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");

                return Generalidades.Archivos.ConvertirADatasetDownload("PDF", ExchRet.NombreArchivo + ".pdf", false, "pfd", ExchRet.PDF);
            }

            Generalidades.qFunctionalException.GenerarExcepcion("No_Se_pudo_Descargar_el_Pdf");
            return new Generalidades.DescargaArchivoDS();
        }

        [Generalidades.QFuncion_Condicion]
        public string VeTodasLasSuc(TesoreriaCommon.tesMovimientosDatosBaseDS exch, Framework.Core.Command cmd)
        {
            // Si no está informada la sucursal principal o la sucursal del usuario es la principal entonces ve todas las sucursales //
            GeneralesExchange.genEmpresasActionExchange exchEmpr = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);
            GeneralesExchange.genUsuariosActionExchange exchUsu = GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd);
            if(exchEmpr.SucursalCentral == "" || exchUsu.Sucursal == exchEmpr.SucursalCentral)
                return "S";
            return "N";
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS LeerDatosChequeDebe(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos, 
            TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {

            return TesoreriaFEEventos.tesRengMoviVirtual.LeerDatosChequeDebe(ExcPos, ExcNoPos, Indice, cmd);
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS LeerDatosChequeHaber(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos,
    TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {

            return TesoreriaFEEventos.tesRengMoviVirtual.LeerDatosChequeHaber(ExcPos, ExcNoPos, Indice, cmd);
        }


        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS CalcularImpuestoHaber(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
         TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            return TesoreriaFEEventos.tesRengMoviVirtual.CalcularImpuestoHaber(ExcPost, ExcNoPos, Indice, cmd);
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS CalcularImpuestoHaberGlobal(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                   TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            return TesoreriaFEEventos.tesRengMoviVirtual.CalcularImpuestoHaberGlobal(ExcPost, ExcNoPos, Indice, cmd);
        }


        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS FactAneValoresSugeridosHaber(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                   TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            return TesoreriaFEEventos.tesRengMoviVirtual.FactAneValoresSugeridosHaber(ExcPost, ExcNoPos, Indice, cmd);
        }


        [Generalidades.QFuncion_CondicionGrilla]
        public static string EsProvMenorHaber(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
                    TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPost,
                    int pIndice, Framework.Core.Command cmd)
        {
            return TesoreriaFEEventos.tesRengMoviVirtual.EsProvMenorHaber(ExcNoPost.Haber[0], cmd);
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static TesoreriaCommon.tesMovimientosDatosBaseDS CalcularTotalAneHaber(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPost,
             TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            return TesoreriaFEEventos.tesRengMoviVirtual.CalcularTotalAneHaber(ExcPost, ExcNoPos, Indice, cmd);
        }

        [Generalidades.QFuncion_AccionDescargar]
        public Generalidades.DescargaArchivoDS DescargarXmlFactura(TesoreriaCommon.tesMovimientosDatosBaseDS exch, Framework.Core.Command cmd)
        {
            TesoreriaExchange.tesCFDICobranzaImprimirActionExchange eMov =
                    new TesoreriaExchange.tesCFDICobranzaImprimirActionExchange(TesoreriaExchange.tesCFDICobranzaImprimirActionEnum.EnumtesCFDICobranzaImprimirAction.Datos)
                    {

                        Segmento_Id = exch.ReqCompPago[0].Segmento_Id,
                        Segmento1N = exch.ReqCompPago[0].Segmento1N,
                        Segmento2N = exch.ReqCompPago[0].Segmento2N,
                        Segmento3N = exch.ReqCompPago[0].Segmento3N,
                        Segmento4N = exch.ReqCompPago[0].Segmento4N,
                        Segmento1C = exch.ReqCompPago[0].Segmento1C,
                        Segmento2C = exch.ReqCompPago[0].Segmento2C,
                        Segmento3C = exch.ReqCompPago[0].Segmento3C,
                        Segmento4C = exch.ReqCompPago[0].Segmento4C
                    };
            eMov = new TesoreriaExchange.tesCFDICobranzaImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

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
        public Generalidades.DescargaArchivoDS DescargarPDFFactura(TesoreriaCommon.tesMovimientosDatosBaseDS exch, Framework.Core.Command cmd)
        {


            TesoreriaExchange.tesCFDICobranzaImprimirActionExchange eMov =
                    new TesoreriaExchange.tesCFDICobranzaImprimirActionExchange(TesoreriaExchange.tesCFDICobranzaImprimirActionEnum.EnumtesCFDICobranzaImprimirAction.Datos)
                    {
                        Segmento_Id = exch.ReqCompPago[0].Segmento_Id,
                        Segmento1N = exch.ReqCompPago[0].Segmento1N,
                        Segmento2N = exch.ReqCompPago[0].Segmento2N,
                        Segmento3N = exch.ReqCompPago[0].Segmento3N,
                        Segmento4N = exch.ReqCompPago[0].Segmento4N,
                        Segmento1C = exch.ReqCompPago[0].Segmento1C,
                        Segmento2C = exch.ReqCompPago[0].Segmento2C,
                        Segmento3C = exch.ReqCompPago[0].Segmento3C,
                        Segmento4C = exch.ReqCompPago[0].Segmento4C
                    };
            eMov = new TesoreriaExchange.tesCFDICobranzaImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));
            if (!eMov.Existe)
            {

                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_el_Movimiento");

            }
            if (eMov.PDF == "")
                eMov.PDF = tesCFDICobranza.GenerarPDF(eMov, cmd);

            return Generalidades.Archivos.ConvertirADatasetDownload("PDF", eMov.NombreArchivo + ".pdf", false, "pdf", eMov.PDF);
        }

        [Generalidades.QFuncion_Condicion]
        public string TieneCliente(TesoreriaCommon.tesMovimientosDatosBaseDS Exch, Framework.Core.Command cmd)
        {
            return TesoreriaFEEventos.tesRengMoviVirtual.TieneCliente(Exch, cmd);
        }


        [Generalidades.QFuncion_Condicion]
        public string EsFechaCajaHoy(TesoreriaCommon.tesMovimientosDatosBaseDS exch, Framework.Core.Command cmd)
        {
            DateTime FechaCaja =
                        GeneralesValidacion.genSucursalesEmpr.Existe(
                            GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Sucursal,
                            cmd
                            ).FechaCaja.Date;
            if (GeneralesValidacion.FechaBaseDatos.GetFechaServer(cmd).Date != FechaCaja.Date)
                return "N";
            return "S";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public static string PideDatosCheque(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos,
   TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            return tesRengMoviVirtual.PideDatosCheque(ExcPos, ExcNoPos, Indice, cmd);
        }
        
        [Generalidades.QFuncion_AccionGrilla]
        public TesoreriaCommon.tesMovimientosDatosBaseDS ClabeCliente(TesoreriaCommon.tesMovimientosDatosBaseDS pCommonDS, TesoreriaCommon.tesMovimientosDatosBaseDS pCommonDSNoPost, int pIndice, Command cmd)
        {

            if (!pCommonDS.Principal[0].IsCliente_IdNull())
            {
                VentasExchange.venClientesActionExchange eClie = new VentasExchange.venClientesActionExchange(VentasExchange.venClientesActionEnum.EnumvenClientesAction.Datos)
                {
                    Cliente_Id = pCommonDS.Principal[0].Cliente_Id
                };
                eClie = new VentasExchange.venClientesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eClie, cmd));
                if (!eClie.Existe)
                    return pCommonDSNoPost;
                VentasExchange.venClieHabitualActionExchange eClieHab = new VentasExchange.venClieHabitualActionExchange(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos)
                {
                    Cliente_Id = eClie.Cliente_Id,
                    Sucursal = eClie.SucursalPredeter
                };
                eClieHab = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eClieHab, cmd));
                if (eClieHab.NumCuenta.Length < 3)
                    return pCommonDSNoPost;
                if (!string.IsNullOrEmpty(pCommonDSNoPost.Debe[0].TDCtaOrdenante))
                {
                    pCommonDSNoPost.Debe[0].TDCtaOrdenante = eClieHab.NumCuenta;
                    if (!string.IsNullOrEmpty(pCommonDSNoPost.Debe[0].TDRfcEmisorCtaOrd))
                    {
                        TesoreriaExchange.tesBancosActionExchange eBanco = new tesBancosActionExchange(TesoreriaExchange.tesBancosActionEnum.EnumtesBancosAction.Datos)
                        {
                            Banco_Id = eClieHab.NumCuenta.Substring(0, 3)
                        };
                        eBanco = new tesBancosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eBanco, cmd));
                        if (eBanco.Existe)
                            pCommonDSNoPost.Debe[0].TDRfcEmisorCtaOrd = eBanco.RFC;
                    }
                }
            }
            return pCommonDSNoPost;
        }

        [Generalidades.QFuncion_EnviarMail]
        public Generalidades.CorreoDS Enviar(TesoreriaCommon.tesMovimientosDatosBaseDS pCommonDS, Framework.Core.Command cmd)
        {

            if (cmd.Dominio_Id == "MX" && pCommonDS.Reversa.Count > 0 
                && pCommonDS.Reversa[0].Segmento1N != 0)
            {
                return EnviarCPago(pCommonDS, cmd);
            }

            Generalidades.CorreoDS lRetorno = new Generalidades.CorreoDS();

            TesoreriaExchange.tesMovimientosEnviarActionExchange eMov = new tesMovimientosEnviarActionExchange(TesoreriaExchange.tesMovimientosEnviarActionEnum.EnumtesMovimientosEnviarAction.Datos)
            {
                Segmento_Id = pCommonDS.Principal[0].Segmento_Id,
                Segmento1N = pCommonDS.Principal[0].Segmento1N,
                Segmento2N = pCommonDS.Principal[0].Segmento2N,
                Segmento3N = pCommonDS.Principal[0].Segmento3N,
                Segmento4N = pCommonDS.Principal[0].Segmento4N,
                Segmento1C = pCommonDS.Principal[0].Segmento1C,
                Segmento2C = pCommonDS.Principal[0].Segmento2C,
                Segmento3C = pCommonDS.Principal[0].Segmento3C,
                Segmento4C = pCommonDS.Principal[0].Segmento4C
            };
            eMov = new tesMovimientosEnviarActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            if (eMov.Param.Cabecera.Count > 0)
            {
                lRetorno.Principal.AddPrincipalRow(eMov.Param.Cabecera[0].Asunto, eMov.Param.Cabecera[0].Cuerpo,
                        eMov.Param.Cabecera[0].Destinatarios, eMov.Param.Cabecera[0].DestinatariosCopia, eMov.Param.Cabecera[0].DestinatariosCopiaOculta, false);

                foreach (var ren in eMov.Param.Adjuntos)
                {
                    lRetorno.Adjuntos.AddAdjuntosRow(ren.Renglon, ren.Guid, ren.NombreArchivo, ren.Extension, ren.ArchivoBase64, ren.Estado);
                }
            }
            return lRetorno;

        }


        [Generalidades.QFuncion_EnviarMail]
        public Generalidades.CorreoDS EnviarCPago(TesoreriaCommon.tesMovimientosDatosBaseDS pCommonDS, Framework.Core.Command cmd)
        {



            Generalidades.CorreoDS lRetorno = new Generalidades.CorreoDS();

            TesoreriaExchange.tesTimbradoCobranzaEnviarActionExchange eMov = new tesTimbradoCobranzaEnviarActionExchange(tesTimbradoCobranzaEnviarActionEnum.EnumtesTimbradoCobranzaEnviarAction.Datos)
            {
                Segmento_Id = pCommonDS.Reversa[0].Segmento_Id,
                Segmento1N = pCommonDS.Reversa[0].Segmento1N,
                Segmento2N = pCommonDS.Reversa[0].Segmento2N,
                Segmento3N = pCommonDS.Reversa[0].Segmento3N,
                Segmento4N = pCommonDS.Reversa[0].Segmento4N,
                Segmento1C = pCommonDS.Reversa[0].Segmento1C,
                Segmento2C = pCommonDS.Reversa[0].Segmento2C,
                Segmento3C = pCommonDS.Reversa[0].Segmento3C,
                Segmento4C = pCommonDS.Reversa[0].Segmento4C
            };
            eMov = new tesTimbradoCobranzaEnviarActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));


            lRetorno.Principal.AddPrincipalRow(eMov.Param.Cabecera[0].Asunto, eMov.Param.Cabecera[0].Cuerpo,
                    eMov.Param.Cabecera[0].Destinatarios, eMov.Param.Cabecera[0].DestinatariosCopia, eMov.Param.Cabecera[0].DestinatariosCopiaOculta, false);

            foreach (var ren in eMov.Param.Adjuntos)
            {
                lRetorno.Adjuntos.AddAdjuntosRow(ren.Renglon, ren.Guid, ren.NombreArchivo, ren.Extension, ren.ArchivoBase64, ren.Estado);
            }
            return lRetorno;

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public static string ValidarImpuestos(TesoreriaCommon.tesMovimientosDatosBaseDS ExcPos,
TesoreriaCommon.tesMovimientosDatosBaseDS ExcNoPos, int Indice, Framework.Core.Command cmd)
        {
            VentasValidacion.venImpuestos.ExistePosteadoyActivo(ExcNoPos.Impuestos[0].Impuesto_Id, cmd);
            if (ExcNoPos.Impuestos[0].Importe == 0)
                return "El_Importe_Debe_Ser_Distinto_Que_Cero";
            return "";
        }


    }
}
