using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using Framework.Core;
using Microsoft.Reporting.WinForms;

namespace VentasFEEventos
{

    
    public class venConsEdoCtaClientes
    {
        
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venConsEdoCtaClientesDS Inventario(VentasCommon.venConsEdoCtaClientesDS exch,
         VentasCommon.venConsEdoCtaClientesDS exchNoPost, int pIndice, Command cmd)
        {
            string lPedido = "";
            string lReparto = "";
            string lRemito;

            VentasExchange.venMovConStockCrPedActionExchange exchPedRep = new VentasExchange.venMovConStockCrPedActionExchange(VentasExchange.venMovConStockCrPedActionEnum.EnumvenMovConStockCrPedAction.Datos)
            {
                venMovimientos = exch.Cuerpo[pIndice].venMovimientos
            };

            VentasExchange.venMovStkHistActionExchange exchRemi = new VentasExchange.venMovStkHistActionExchange(VentasExchange.venMovStkHistActionEnum.EnumvenMovStkHistAction.Datos)
            {
                venMovimientos = exch.Cuerpo[pIndice].venMovimientos
            };

            VentasExchange.venMovConStockCrActionExchange exchmc = new VentasExchange.venMovConStockCrActionExchange(VentasExchange.venMovConStockCrActionEnum.EnumvenMovConStockCrAction.Datos);
            exchmc.venMovimientos = exch.Cuerpo[pIndice].venMovimientos;
            exchmc.RenglonCuerpo = 0;
            exchmc = new VentasExchange.venMovConStockCrActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));
            exch.Inventario.Clear();
            if (exchmc.Existe)
            {
                // FM 12/06/2019 Para una factura puede haber un solo pedido y un solo reparto //
                exchPedRep.RenglonCuerpo = 0;
                exchPedRep = new VentasExchange.venMovConStockCrPedActionExchange
                    (Generalidades.QBIInternal.WrapperExecuteActionInternal(exchPedRep, cmd));
                if (exchPedRep.Existe)
                {
                    lPedido = exchPedRep.Pedido;
                    if (!exchPedRep.IsRepartoNull)
                        // Puede no venir de un reparto la factura //
                        lReparto = exchPedRep.Reparto;
                }

                foreach (VentasCommon.venMovConStockCrDS.PrincipalRow ren in exchmc.Param.Principal)
                {
                    exchRemi.stkMoviCabe = 0;
                    exchRemi.Renglon = 0;
                    exchRemi.RenglonCuerpo = ren.RenglonCuerpo;
                    exchRemi = new VentasExchange.venMovStkHistActionExchange
                        (Generalidades.QBIInternal.WrapperExecuteActionInternal(exchRemi, cmd));
                    if (exchRemi.Existe)
                        lRemito = exchRemi.Remito;
                    else
                        lRemito = "";

                    exch.Inventario.AddInventarioRow(ren.Deposito_Id, ren.Producto_Id, ren.DescripcionProductos, ren.Medida_Id,
                        ren.CantOriginal, ren.PrecioForm, ren.CantOriginal * ren.PrecioForm, lPedido, lReparto, lRemito, ren.Bonificacion);
                }
                exch.Inventario.AcceptChanges();
            }

            return exch;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venConsEdoCtaClientesDS AsientoContable(VentasCommon.venConsEdoCtaClientesDS exch,
        VentasCommon.venConsEdoCtaClientesDS exchNoPost, int pIndice, Command cmd)
        {

            ContabilidadExchange.conMovContActionExchange exchmc = new ContabilidadExchange.conMovContActionExchange(ContabilidadExchange.conMovContActionEnum.EnumconMovContAction.Datos);
            exchmc.conAsientos = exch.Cuerpo[pIndice].venMovimientos;
            exchmc.Renglon = 0;
            exchmc = new ContabilidadExchange.conMovContActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));
            exch.AsientoContable.Clear();
            if (exchmc.Existe)
            {
                foreach (ContabilidadCommon.conMovContDS.PrincipalRow ren in exchmc.Param.Principal)
                {
                    exch.AsientoContable.AddAsientoContableRow(ren.Cuenta_Id, ren.DescripcionCuentas, ren.Centro1_Id, ren.Centro2_Id, ren.TipoMov == 1 ? ren.Importe : 0, ren.TipoMov == 2 ? ren.Importe : 0);
                }
                exch.Inventario.AcceptChanges();
            }

            return exch;

        }

        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venConsEdoCtaClientesDS Aplicaciones(VentasCommon.venConsEdoCtaClientesDS exch,
        VentasCommon.venConsEdoCtaClientesDS exchNoPost, int pIndice, Command cmd)
        {
            GeneralesExchange.genCancMovActionExchange exchmc = new GeneralesExchange.genCancMovActionExchange(GeneralesExchange.genCancMovActionEnum.EnumgenCancMovAction.Datos);
            exchmc.Asiento_Id = exch.Cuerpo[pIndice].venMovimientos;
            exchmc.CuotaNro = 0;
            exchmc.Asiento_Id_Ap = 0;
            exchmc.CuotaNro_Ap = 0;
            exchmc.Cambio = 1;
            exchmc.Cambio_Ap = 1;
            exchmc = new GeneralesExchange.genCancMovActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));
            exch.Aplicaciones.Clear();
            exch.CompAAplic.Clear();
            exch.CompAAplic.AddCompAAplicRow(1, 1, 1, 1);
            exch.CompAAplic[0].Asiento_Id = exch.Cuerpo[pIndice].venMovimientos;
            exch.CompAAplic[0].Cuota_Nro = (short)exch.Cuerpo[pIndice].CuotaNro;
            exch.CompAAplic[0].Importe = exch.Cuerpo[pIndice].Debe == 0 ? exch.Cuerpo[pIndice].Haber : exch.Cuerpo[pIndice].Debe;
            exch.CompAAplic[0].Signo = exch.Cuerpo[pIndice].Debe == 0 ? -1 : 1;
            if (exchmc.Existe)
            {
                foreach (GeneralesCommon.genCancMovDS.CuerpoRow ren in exchmc.Param.Cuerpo)
                {
                    
                    exch.Aplicaciones.AddAplicacionesRow(
                        exch.Cuerpo[pIndice].Debe==0?ren.Segmento:ren.Segmento_ap, 
                        ren.FechaAplicacion, ren.Importe, ren.Usuario_Id, false,
                        exch.Cuerpo[pIndice].Debe == 0 ? ren.Asiento_Id:ren.Asiento_Id_Ap,
                        exch.Cuerpo[pIndice].Debe == 0 ? ren.CuotaNro:ren.CuotaNro_Ap , 
                        ren.NroAplicacion, ren.AsientoApli_Id, ren.AsieDifCambio_Id);
                }
            }
           


            return exch;

        }


        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venConsEdoCtaClientesDS Impuestos(VentasCommon.venConsEdoCtaClientesDS exch,
        VentasCommon.venConsEdoCtaClientesDS exchNoPost, int pIndice, Command cmd)
        {
            VentasExchange.venMovImpuestosActionExchange exchmc = new VentasExchange.venMovImpuestosActionExchange(VentasExchange.venMovImpuestosActionEnum.EnumvenMovImpuestosAction.Datos);
            exchmc.venMovimientos = exch.Cuerpo[pIndice].venMovimientos;
            exchmc.conRenglon = 0;
            exchmc = new VentasExchange.venMovImpuestosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));
            exch.Impuestos.Clear();
            if (exchmc.Existe)
            {
                foreach (VentasCommon.venMovImpuestosDS.PrincipalRow ren in exchmc.Param.Principal)
                {
                    exch.Impuestos.AddImpuestosRow(ren.Impuesto_Id, ren.DescripcionCuenta, ren.BaseImponible, ren.Porcentaje, ren.Importe);
                }
                exch.Impuestos.AcceptChanges();
            }

            return exch;

        }

        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venConsEdoCtaClientesDS Valores(VentasCommon.venConsEdoCtaClientesDS exch,
        VentasCommon.venConsEdoCtaClientesDS exchNoPost, int pIndice, Command cmd)
        {


            TesoreriaExchange.tesRengMoviActionExchange exchmc = new TesoreriaExchange.tesRengMoviActionExchange(TesoreriaExchange.tesRengMoviActionEnum.EnumtesRengMoviAction.Datos);

            exchmc.tesMovimientos = exch.Cuerpo[pIndice].venMovimientos;
            exchmc.conRenglon = 0;
            if (exch.Cuerpo[pIndice].Debe != 0)
                exchmc.Tipomov = 2;
            else
                exchmc.Tipomov = 1;


            exchmc = new TesoreriaExchange.tesRengMoviActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));
            exch.Valores.Clear();
            string numdoc = "";
            DateTime fechad = exch.Cuerpo[pIndice].Fecha;
            if (exchmc.Existe)
            {
                foreach (TesoreriaCommon.tesRengMoviDHDS.PrincipalRow ren in exchmc.Param.Principal)
                {
                    switch (ren.TipoCartera)
                    {
                        case "CP":

                            numdoc = ren.CPnumCheque.ToString();
                            fechad = ren.CPFechaVencimiento;
                            break;

                        case "CT":
                            numdoc = ren.CTnumCheque.ToString();
                            fechad = ren.CTFechaVencimiento;
                            break;

                        case "FP":
                            numdoc = ren.Segmento1N.ToString();
                            fechad = ren.FPFecha_Ane;
                            break;

                    }
                    exch.Valores.AddValoresRow(ren.Cartera_Id, ren.DescripcionIdentifica, ren.Importe, numdoc, fechad,
                        ren.CTBanco_Id, ren.CTDescripcionBanco, ren.CTClearing, ren.ImporteOrig);
                }
                exch.Valores.AcceptChanges();
            }

            return exch;
        }
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venConsEdoCtaClientesDS Comprobantes(VentasCommon.venConsEdoCtaClientesDS exch,
          VentasCommon.venConsEdoCtaClientesDS exchNoPost, int pIndice, Command cmd)
        {

            VentasExchange.venTraePendientesActionExchange exchmc = new VentasExchange.venTraePendientesActionExchange(VentasExchange.venTraePendientesActionEnum.EnumvenTraePendientesAction.Datos);
            exchmc.venMovimientos = exch.Cuerpo[pIndice].venMovimientos;
            exchmc.Cliente_id = exch.Principal[0].Cliente_Id;
            exchmc.Moneda_Id = exch.Cuerpo[pIndice].Moneda_Id;
            if (exch.Cuerpo[pIndice].Debe == 0)
                exchmc.Signo = 1;
            else
                exchmc.Signo = -1;

            exchmc = new VentasExchange.venTraePendientesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));
            exch.CompAAplic.Clear();
            exch.Comprobantes.Clear();
            exch.CompAAplic.AddCompAAplicRow(exch.Cuerpo[pIndice].venMovimientos, (short)exch.Cuerpo[pIndice].CuotaNro, exchmc.Signo == 1 ? exch.Cuerpo[pIndice].Haber : exch.Cuerpo[pIndice].Debe, exchmc.Signo);
            if (exchmc.Existe)
            {
                foreach (VentasCommon.venTraePendientesDS.PendientesRow ren in exchmc.Param.Pendientes)
                {
                    exch.Comprobantes.AddComprobantesRow(ren.venMovimientos, ren.SegmentoStr, ren.Fecha, ren.Importe, ren.Saldo, ren.CuotaNro, ren.ImporteAplicado, ren.FechaVencimiento);
                }
                exch.Comprobantes.AcceptChanges();
            }

            return exch;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venConsEdoCtaClientesDS Aplicar(VentasCommon.venConsEdoCtaClientesDS exch,
            VentasCommon.venConsEdoCtaClientesDS exchNoPost, int pIndice, Command cmd)
        {
            GeneralesExchange.genCancMovActionExchange exchmc = new GeneralesExchange.genCancMovActionExchange(GeneralesExchange.genCancMovActionEnum.EnumgenCancMovAction.Guardar);
            exchmc.Asiento_Id = exch.CompAAplic[0].Asiento_Id;
            exchmc.CuotaNro = exch.CompAAplic[0].Cuota_Nro;
            exchmc.Asiento_Id = 0;
            exchmc.CuotaNro = 0;
            exchmc.Asiento_Id_Ap = 0;
            exchmc.CuotaNro_Ap = 0;
            exchmc.Cambio = 0;
            exchmc.Cambio_Ap = 0;

            // FM 14/07/2021 En aplicación desde la cta. cte. se puede generar una ND/NC por DC y tiene que ir a la Afip //
            if (cmd.Dominio_Id == "AR")
                exchmc.LlamarAlWS = true;
            else
                exchmc.LlamarAlWS = false;

            exchmc.Existe = true;
            foreach (VentasCommon.venConsEdoCtaClientesDS.ComprobantesRow ren in exchNoPost.Comprobantes)
            {
                if (ren.ImporteAplicado > 0)
                {
                    if (exch.CompAAplic[0].Signo == 1)
                        exchmc.Param.Cuerpo.AddCuerpoRow(cmd.Empresa_Id, 0, 0, 0, 0, " ", " ", " ", " ", exch.CompAAplic[0].Cuota_Nro,
                            exch.CompAAplic[0].Asiento_Id, 0, 0, 0, 0, " ", " ", " ", " ", ren.venMovimientos, ren.NroCuota,
                            exch.Principal[0].FechaAplicacion, ren.ImporteAplicado, ren.ImporteAplicado,
                            " ", " ", " ", " ", 0, 0, false, 0);
                    else
                        exchmc.Param.Cuerpo.AddCuerpoRow(cmd.Empresa_Id, 0, 0, 0, 0, " ", " ", " ", " ", ren.NroCuota,
                            ren.venMovimientos, 0, 0, 0, 0, " ", " ", " ", " ", exch.CompAAplic[0].Asiento_Id, exch.CompAAplic[0].Cuota_Nro,
                            exch.Principal[0].FechaAplicacion, ren.ImporteAplicado, ren.ImporteAplicado,
                            " ", " ", " ", " ", 0, 0, false, 0);
                }
            }
            Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd);
            exch = Comprobantes(exch, exchNoPost, pIndice, cmd);
            return exch;
        }
       
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venConsEdoCtaClientesDS Desaplicar(VentasCommon.venConsEdoCtaClientesDS exch,
            VentasCommon.venConsEdoCtaClientesDS exchNoPost, int pIndice, Command cmd)
        {
            GeneralesExchange.genCancMovActionExchange exchmc = new GeneralesExchange.genCancMovActionExchange(GeneralesExchange.genCancMovActionEnum.EnumgenCancMovAction.Eliminar);
            exchmc.Asiento_Id = 0;
            exchmc.CuotaNro = 0;
            exchmc.Asiento_Id_Ap = 0;
            exchmc.CuotaNro_Ap = 0;
            exchmc.Cambio = 0;
            exchmc.Cambio_Ap = 0;
            exchmc.Existe = true;
            foreach (VentasCommon.venConsEdoCtaClientesDS.AplicacionesRow ren in exchNoPost.Aplicaciones)
            {

                if (ren.Seleccionar == true)
                {
                    if (exch.CompAAplic[0].Signo == -1)
                        exchmc.Param.Cuerpo.AddCuerpoRow(cmd.Empresa_Id, 0, 0, 0, 0, " ", " ", " ", " ", exch.CompAAplic[0].Cuota_Nro,
                            exch.CompAAplic[0].Asiento_Id, 0, 0, 0, 0, " ", " ", " ", " ", ren.ven_Movimientos, ren.NroCuota,
                            ren.Fecha, ren.Importe, ren.Importe, " ", " ", " ", " ", 0, ren.NroAplicacion, false, 0);
                    else
                        exchmc.Param.Cuerpo.AddCuerpoRow(cmd.Empresa_Id, 0, 0, 0, 0, " ", " ", " ", " ", ren.NroCuota,
                            ren.ven_Movimientos, 0, 0, 0, 0, " ", " ", " ", " ", exch.CompAAplic[0].Asiento_Id, exch.CompAAplic[0].Cuota_Nro,
                            ren.Fecha, ren.Importe, ren.Importe, " ", " ", " ", " ", 0, ren.NroAplicacion, false, 0);
                }
            }
            Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd);

            exch = Aplicaciones(exch, exchNoPost, pIndice, cmd);
            return exch;
        }


        [Generalidades.QFuncion_AccionDescargarFila]
        public Generalidades.DescargaArchivoDS Pdf(VentasCommon.venConsEdoCtaClientesDS exch,
        VentasCommon.venConsEdoCtaClientesDS exchNoPost, int pIndice, Command cmd)
        {
            VentasExchange.venMovimientosActionExchange ExcM = new VentasExchange.venMovimientosActionExchange(VentasExchange.venMovimientosActionEnum.EnumvenMovimientosAction.Datos)
            {
                venMovimientos = exch.Cuerpo[pIndice].venMovimientos

            };

            ExcM = new VentasExchange.venMovimientosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcM, cmd));
            if (ExcM.Existe)
            {

                if (ExcM.venTipoMov == "C")
                {
                    // Voy a buscarlo en Tesoreria
                    // Averiguo en que Cfdi Esta
                    TesoreriaExchange.TesCFDICobranzaCuerpoActionExchange ExcTCC = new TesoreriaExchange.TesCFDICobranzaCuerpoActionExchange(TesoreriaExchange.TesCFDICobranzaCuerpoActionEnum.EnumTesCFDICobranzaCuerpoAction.Datos)
                    {
                        tesMovimientos = exch.Cuerpo[pIndice].venMovimientos,
                        TesCFDICobranza = 0
                    };

                    ExcTCC = new TesoreriaExchange.TesCFDICobranzaCuerpoActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcTCC, cmd));
                    if (!ExcTCC.Existe)
                    {
                        Generalidades.qFunctionalException.GenerarExcepcion("Cobranza_No_Timbrada");
                    }
                    TesoreriaExchange.tesCFDICobranzaActionExchange eCDFI = new TesoreriaExchange.tesCFDICobranzaActionExchange(TesoreriaExchange.tesCFDICobranzaActionEnum.EnumtesCFDICobranzaAction.DatosInt)
                    {
                        tesCFDICobranza = ExcTCC.TesCFDICobranza
                    };
                    eCDFI = new TesoreriaExchange.tesCFDICobranzaActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCDFI, cmd));
                    if (!eCDFI.Existe)
                        Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");

                    TesoreriaExchange.tesCFDICobranzaImprimirActionExchange ExcCFDI = new TesoreriaExchange.tesCFDICobranzaImprimirActionExchange(TesoreriaExchange.tesCFDICobranzaImprimirActionEnum.EnumtesCFDICobranzaImprimirAction.Datos)
                    {
                        Segmento_Id = eCDFI.Segmento_Id,
                        Segmento1C = eCDFI.Segmento1C,
                        Segmento2C = eCDFI.Segmento2C,
                        Segmento3C = eCDFI.Segmento3C,
                        Segmento4C = eCDFI.Segmento4C,
                        Segmento1N = eCDFI.Segmento1N,
                        Segmento2N = eCDFI.Segmento2N,
                        Segmento3N = eCDFI.Segmento3N,
                        Segmento4N = eCDFI.Segmento4N
                    };
                    ExcCFDI = new TesoreriaExchange.tesCFDICobranzaImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcCFDI, cmd));
                    if (!ExcCFDI.Existe)
                    {
                        Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");
                    }

                    if (ExcCFDI.PDF == "")
                        Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");

                    return Generalidades.Archivos.ConvertirADatasetDownload("PDF", ExcCFDI.NombreArchivo + ".pdf", false, "pfd",
                                ExcCFDI.PDF);



                }
                else
                {
                    VentasExchange.venMovimientosImprimirActionExchange exchmc = new VentasExchange.venMovimientosImprimirActionExchange(VentasExchange.venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Datos)
                    {
                        Segmento_Id = ExcM.Segmento_Id,
                        Segmento1C = ExcM.Segmento1C,
                        Segmento2C = ExcM.Segmento2C,
                        Segmento3C = ExcM.Segmento3C,
                        Segmento4C = ExcM.Segmento4C,
                        Segmento1N = ExcM.Segmento1N,
                        Segmento2N = ExcM.Segmento2N,
                        Segmento3N = ExcM.Segmento3N,
                        Segmento4N = ExcM.Segmento4N

                    };
                    // AJ PARA QUE NO PREGUNTE
                    cmd.CodigoConsulta = "YES";
                    exchmc = new VentasExchange.venMovimientosImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));
                    exch.Impuestos.Clear();
                    if (exchmc.Existe)
                    {
                        if (exchmc.PDF == "")
                            Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");

                        return Generalidades.Archivos.ConvertirADatasetDownload("PDF", exchmc.NombreArchivo + ".pdf", false, "pfd",
                                    exchmc.PDF);
                    }
                }

            }
            Generalidades.qFunctionalException.GenerarExcepcion("No_Se_pudo_Descargar_el_Pdf");
            return new Generalidades.DescargaArchivoDS();
        }

        [Generalidades.QFuncion_AccionDescargarFila]
        public Generalidades.DescargaArchivoDS Xml(VentasCommon.venConsEdoCtaClientesDS exch,
      VentasCommon.venConsEdoCtaClientesDS exchNoPost, int pIndice, Command cmd)
        {
            VentasExchange.venMovimientosActionExchange ExcM = new VentasExchange.venMovimientosActionExchange(VentasExchange.venMovimientosActionEnum.EnumvenMovimientosAction.Datos)
            {
                venMovimientos = exch.Cuerpo[pIndice].venMovimientos

            };

            ExcM = new VentasExchange.venMovimientosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcM, cmd));
            if (ExcM.Existe)
            {

                if (ExcM.venTipoMov == "C")
                {
                    // Voy a buscarlo en Tesoreria
                    // Averiguo en que Cfdi Esta
                    TesoreriaExchange.TesCFDICobranzaCuerpoActionExchange ExcTCC = new TesoreriaExchange.TesCFDICobranzaCuerpoActionExchange(TesoreriaExchange.TesCFDICobranzaCuerpoActionEnum.EnumTesCFDICobranzaCuerpoAction.Datos)
                    {
                        tesMovimientos = exch.Cuerpo[pIndice].venMovimientos,
                        TesCFDICobranza = 0
                    };

                    ExcTCC = new TesoreriaExchange.TesCFDICobranzaCuerpoActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcTCC, cmd));
                    if (!ExcTCC.Existe)
                    {
                        Generalidades.qFunctionalException.GenerarExcepcion("Cobranza_No_Timbrada");
                    }
                    TesoreriaExchange.tesCFDICobranzaActionExchange eCDFI = new TesoreriaExchange.tesCFDICobranzaActionExchange(TesoreriaExchange.tesCFDICobranzaActionEnum.EnumtesCFDICobranzaAction.DatosInt)
                    {
                        tesCFDICobranza = ExcTCC.TesCFDICobranza
                    };
                    eCDFI = new TesoreriaExchange.tesCFDICobranzaActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCDFI, cmd));
                    if (!eCDFI.Existe)
                        Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");
                    // AJ PARA QUE NO PREGUNTE
                    cmd.CodigoConsulta = "ENVIA";
                    TesoreriaExchange.tesCFDICobranzaImprimirActionExchange ExcCFDI = new TesoreriaExchange.tesCFDICobranzaImprimirActionExchange(TesoreriaExchange.tesCFDICobranzaImprimirActionEnum.EnumtesCFDICobranzaImprimirAction.Datos)
                    {
                        Segmento_Id = eCDFI.Segmento_Id,
                        Segmento1C = eCDFI.Segmento1C,
                        Segmento2C = eCDFI.Segmento2C,
                        Segmento3C = eCDFI.Segmento3C,
                        Segmento4C = eCDFI.Segmento4C,
                        Segmento1N = eCDFI.Segmento1N,
                        Segmento2N = eCDFI.Segmento2N,
                        Segmento3N = eCDFI.Segmento3N,
                        Segmento4N = eCDFI.Segmento4N
                    };
                    ExcCFDI = new TesoreriaExchange.tesCFDICobranzaImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcCFDI, cmd));
                    if (!ExcCFDI.Existe)
                    {
                        Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");
                    }

                    if (ExcCFDI.XML == "")
                        Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");

                    return Generalidades.Archivos.ConvertirADatasetDownload("XML", ExcCFDI.NombreArchivo + ".xml", false, "XML",
                                ExcCFDI.XML);



                }
                else
                {
                    VentasExchange.venMovimientosImprimirActionExchange exchmc = new VentasExchange.venMovimientosImprimirActionExchange(VentasExchange.venMovimientosImprimirActionEnum.EnumvenMovimientosImprimirAction.Datos)
                    {
                        Segmento_Id = ExcM.Segmento_Id,
                        Segmento1C = ExcM.Segmento1C,
                        Segmento2C = ExcM.Segmento2C,
                        Segmento3C = ExcM.Segmento3C,
                        Segmento4C = ExcM.Segmento4C,
                        Segmento1N = ExcM.Segmento1N,
                        Segmento2N = ExcM.Segmento2N,
                        Segmento3N = ExcM.Segmento3N,
                        Segmento4N = ExcM.Segmento4N

                    };

                    exchmc = new VentasExchange.venMovimientosImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));
                    exch.Impuestos.Clear();
                    if (exchmc.Existe)
                    {
                        if (exchmc.XML == "")
                            Generalidades.qFunctionalException.GenerarExcepcion("El_Archivo_no_existe");

                        return Generalidades.Archivos.ConvertirADatasetDownload("XML", exchmc.NombreArchivo + ".xml", false, "XML",
                                    exchmc.XML);
                    }


                }
            }
            Generalidades.qFunctionalException.GenerarExcepcion("No_Se_pudo_Descargar_el_XML");
            return new Generalidades.DescargaArchivoDS();
        }

        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venConsEdoCtaClientesDS EnviarPdf(VentasCommon.venConsEdoCtaClientesDS exch, 
            VentasCommon.venConsEdoCtaClientesDS exchNoPost, int pIndice, Command cmd)
        {
            VentasExchange.venMovimientosActionExchange ExcM = new VentasExchange.venMovimientosActionExchange(VentasExchange.venMovimientosActionEnum.EnumvenMovimientosAction.Datos)
            {
                venMovimientos = exch.Cuerpo[pIndice].venMovimientos

            };

            ExcM = new VentasExchange.venMovimientosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcM, cmd));
            if (!ExcM.Existe)
            {
                Generalidades.qFunctionalException.GenerarExcepcion("No_existe_el_comprobante");
            }

            if ("FDR".Contains(ExcM.venTipoMov))
            {
                // AJ PARA QUE NO PREGUNTE
                cmd.CodigoConsulta = "YES";
                VentasExchange.venMovimientosActionExchange exchEnviar = new VentasExchange.venMovimientosActionExchange(VentasExchange.venMovimientosActionEnum.EnumvenMovimientosAction.Enviar)
                {
                    Segmento_Id = ExcM.Segmento_Id,
                    Segmento1C = ExcM.Segmento1C,
                    Segmento2C = ExcM.Segmento2C,
                    Segmento3C = ExcM.Segmento3C,
                    Segmento4C = ExcM.Segmento4C,
                    Segmento1N = ExcM.Segmento1N,
                    Segmento2N = ExcM.Segmento2N,
                    Segmento3N = ExcM.Segmento3N,
                    Segmento4N = ExcM.Segmento4N,
                    Cliente_Id = exch.Principal[0].Cliente_Id,
                    Sucursal = exch.Cuerpo[pIndice].Sucursal
                };
                Generalidades.QBIInternal.WrapperExecuteActionInternal(new Exchange(exchEnviar), cmd);
            }
            return exch;
        }
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venConsEdoCtaClientesDS ActualizarFecha(VentasCommon.venConsEdoCtaClientesDS exch,
         VentasCommon.venConsEdoCtaClientesDS exchNoPost, int pIndice, Command cmd)
        {
            VentasExchange.venMovimientosActionExchange eMov = new VentasExchange.venMovimientosActionExchange(VentasExchange.venMovimientosActionEnum.EnumvenMovimientosAction.Datos)
            {
                venMovimientos = exchNoPost.Cuerpo[pIndice].venMovimientos
            };
            eMov = new VentasExchange.venMovimientosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));
            if (eMov.venTipoMov == "F")
            {
                VentasExchange.venMovConformaActionExchange eConforma = new VentasExchange.venMovConformaActionExchange(VentasExchange.venMovConformaActionEnum.EnumvenMovConformaAction.Datos)
                {
                    Segmento_Id = eMov.Segmento_Id,
                    Segmento1N = eMov.Segmento1N,
                    Segmento2N = eMov.Segmento2N,
                    Segmento3N = eMov.Segmento3N,
                    Segmento4N = eMov.Segmento4N,
                    Segmento1C = eMov.Segmento1C,
                    Segmento2C = eMov.Segmento2C,
                    Segmento3C = eMov.Segmento3C,
                    Segmento4C = eMov.Segmento4C
                };
                eConforma = new VentasExchange.venMovConformaActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eConforma, cmd));

                if ((eConforma.FechaRegistro == Generalidades.Nulls.NullDate && exchNoPost.Cuerpo[pIndice].FechaConforma != Generalidades.Nulls.NullDate)
                    || eConforma.FechaConforma != exchNoPost.Cuerpo[pIndice].FechaConforma)
                {
                    eConforma.FechaConforma = exchNoPost.Cuerpo[pIndice].FechaConforma;
                    eConforma.Action = VentasExchange.venMovConformaActionEnum.GetAccionvenMovConformaAction(VentasExchange.venMovConformaActionEnum.EnumvenMovConformaAction.Guardar);
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(eConforma, cmd);
                    var eMovC = new GeneralesExchange.genMovCuotasActionExchange(GeneralesExchange.genMovCuotasActionEnum.EnumgenMovCuotasAction.Datos)
                    {
                        Asiento_Id = exchNoPost.Cuerpo[pIndice].venMovimientos,
                        CuotaNro = 1
                    };
                    eMovC = new GeneralesExchange.genMovCuotasActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMovC, cmd));
                    if (eMov.Existe)
                        exchNoPost.Cuerpo[pIndice].FechaVencimiento = eMovC.FechaVencimiento;

                }
            }
            return exchNoPost;

        }
        [Generalidades.QFuncion_CondicionGrilla]
        public String MostrarFechaConsolida(VentasCommon.venConsEdoCtaClientesDS exch, VentasCommon.venConsEdoCtaClientesDS exchNoPost,
           int pIndice, Framework.Core.Command cmd)
        {
            if (exch.Cuerpo[pIndice].Tipomovs.Trim() == "Factura")
                return "S";
            return "N";
        }
        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venConsEdoCtaClientesDS AsignarPedido(VentasCommon.venConsEdoCtaClientesDS exch,
            VentasCommon.venConsEdoCtaClientesDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            VentasExchange.venMovConStockCrPedActionExchange eMov = new VentasExchange.venMovConStockCrPedActionExchange(VentasExchange.venMovConStockCrPedActionEnum.EnumvenMovConStockCrPedAction.Datos)
            {
                venMovimientos = exch.Cuerpo[pIndice].venMovimientos
            };
            eMov = new VentasExchange.venMovConStockCrPedActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));
            if (eMov.Existe)
            {
                VentasExchange.venPedidosActionExchange ePedido = new VentasExchange.venPedidosActionExchange(VentasExchange.venPedidosActionEnum.EnumvenPedidosAction.DatosIdentity)
                {
                    venPedidos = eMov.venPedidos
                };
                ePedido = new VentasExchange.venPedidosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ePedido, cmd));
                if (ePedido.Existe)
                    exchNoPost.Cuerpo[pIndice].Pedido = ePedido.Segmento;
                else
                    Generalidades.qFunctionalException.GenerarExcepcion("No_Tiene_Pedido_Asociado");
            }
            else
            {
                VentasExchange.venPediFacturadosActionExchange eMovP = new VentasExchange.venPediFacturadosActionExchange(VentasExchange.venPediFacturadosActionEnum.EnumvenPediFacturadosAction.Datos)
                {
                    venPedidos = 0,
                    venMovimientos = exch.Cuerpo[pIndice].venMovimientos
                };
                eMovP = new VentasExchange.venPediFacturadosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMovP, cmd));
                if (eMovP.Existe)
                {
                    VentasExchange.venPedidosActionExchange ePedido = new VentasExchange.venPedidosActionExchange(VentasExchange.venPedidosActionEnum.EnumvenPedidosAction.DatosIdentity)
                    {
                        venPedidos = eMovP.venPedidos
                    };
                    ePedido = new VentasExchange.venPedidosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ePedido, cmd));
                    if (ePedido.Existe)
                        exchNoPost.Cuerpo[pIndice].Pedido = ePedido.Segmento;
                    else
                        Generalidades.qFunctionalException.GenerarExcepcion("No_Tiene_Pedido_Asociado");
                }
                else
                    Generalidades.qFunctionalException.GenerarExcepcion("No_Tiene_Pedido_Asociado");
            }
            return exchNoPost;

        }


        [Generalidades.QFuncion_Condicion]
        public string Enviar(VentasCommon.venConsEdoCtaClientesDS exch, Command cmd)
        {

            
            var eClieCab = VentasValidacion.venClientes.Existe(exch.Principal[0].Cliente_Id, cmd);
            var eClie =
            VentasValidacion.venClieHabitual.Existe(exch.Principal[0].Cliente_Id, eClieCab.SucursalPredeter, cmd);

            if (eClie.Param.grdContactos.Where(c => !String.IsNullOrWhiteSpace(c.Email) && c.EnviaFacturas).Count() == 0)
                Generalidades.qFunctionalException.GenerarExcepcion("El_Cliente_No_Tiene_Configurado_El_Correo");

            var eEmp = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);
            // Llamo a la accion de BE que Envia
            GeneralesExchange.genReportesActionExchange ExcR =
                                     new GeneralesExchange.genReportesActionExchange(GeneralesExchange.genReportesActionEnum.EnumgenReportesAction.Datos);

            ExcR.Reporte_Id = "VENEDOCTA";
            ExcR = new GeneralesExchange.genReportesActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcR, cmd));

            SqlServerTypes.Utilities.LoadNativeAssemblies(System.IO.Directory.GetCurrentDirectory());
            ReportViewer ReportViewer1 = new ReportViewer();

            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.LocalReport.EnableExternalImages = true;
            // AJ AGO 2017
            ReportViewer1.LocalReport.EnableHyperlinks = true;
            ReportViewer1.ShowPrintButton = true;
            string lCultura = GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Cultura;

            if (lCultura == "")
                lCultura = "es-AR";

            // FIN AJ
            XmlDocument lReport = new XmlDocument();
            //lReport.AppendChild()
            string lCarpeta = System.IO.Directory.GetCurrentDirectory() + "\\Reportes\\" + ExcR.Rpt + ".rdlc";

            if (!System.IO.File.Exists(lCarpeta))
            {
                object[] lParam = { lCarpeta };
                Generalidades.qFunctionalException.GenerarExcepcion("No_Existe_El_Archivo_<0>", lParam);
            }

            lReport.Load(lCarpeta);

            // Modifico
            XmlNodeList lReportN = (XmlNodeList)lReport.GetElementsByTagName("Report");

            ((XmlElement)lReportN[0]).SetAttribute("Language", lCultura);


            XmlNodeList lLanguaje = lReport.GetElementsByTagName("Language");

            if (lLanguaje.Count == 0)
            {
                XmlNode node = lReport.CreateNode(XmlNodeType.Element, "Language", lReportN[0].NamespaceURI);
                node.InnerText = lCultura;
                ((XmlElement)lReportN[0]).AppendChild(node);
            }
            else
            {
                lLanguaje[0].InnerText = lCultura;
            }



            MemoryStream lStmReport = new MemoryStream(System.Text.UTF8Encoding.UTF8.GetBytes(lReport.InnerXml));

            ReportViewer1.LocalReport.LoadReportDefinition(lStmReport);

            CultureInfo dft = new CultureInfo(lCultura);



            ReportParameter lPA = new ReportParameter("ClienteDesde", exch.Principal[0].Cliente_Id);
            ReportViewer1.LocalReport.SetParameters(lPA);

            lPA = new ReportParameter("ClienteHasta", exch.Principal[0].Cliente_Id);
            ReportViewer1.LocalReport.SetParameters(lPA);
            lPA = new ReportParameter("Pendiente", (exch.Principal[0].PendHist==1).ToString());
            ReportViewer1.LocalReport.SetParameters(lPA);
            lPA = new ReportParameter("FechaDesde", exch.Principal[0].FechaDesde.ToString(dft.DateTimeFormat.ShortDatePattern, dft));
            ReportViewer1.LocalReport.SetParameters(lPA);
            lPA = new ReportParameter("FechaHasta", exch.Principal[0].FechaHasta.ToString(dft.DateTimeFormat.ShortDatePattern, dft));
            ReportViewer1.LocalReport.SetParameters(lPA);
            lPA = new ReportParameter("Empresa", cmd.Empresa_Id.ToString());
            ReportViewer1.LocalReport.SetParameters(lPA);
            lPA = new ReportParameter("VendedorDesde", " ");
            ReportViewer1.LocalReport.SetParameters(lPA);
            lPA = new ReportParameter("VendedorHasta", "ZZZZZ");
            ReportViewer1.LocalReport.SetParameters(lPA);
            lPA = new ReportParameter("Moneda_Id", exch.Principal[0].Moneda_Id);
            ReportViewer1.LocalReport.SetParameters(lPA);

            GeneralesExchange.genReporteEjecutarActionExchange ExcEr =
                                   new GeneralesExchange.genReporteEjecutarActionExchange(GeneralesExchange.genReporteEjecutarActionEnum.EnumgenReporteEjecutarAction.Ejecutar);
            ExcEr.StoreProcedure = ExcR.StoreProcedure;

            string lParametrosR =
                    exch.Principal[0].Cliente_Id+ "|" +
                    exch.Principal[0].Cliente_Id + "|" +
                    (exch.Principal[0].PendHist==1).ToString() + "|" +
                    exch.Principal[0].FechaDesde.ToString() + "|" +
                    exch.Principal[0].FechaHasta.ToString() + "|" +
                    cmd.Empresa_Id.ToString() + "|" +
                    "|ZZZZZ|" +
                    exch.Principal[0].Moneda_Id;

            ExcEr.Parametros = lParametrosR;

            ExcEr = new GeneralesExchange.genReporteEjecutarActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcEr, cmd));


            ReportDataSource lRDS = new ReportDataSource("Principal", (System.Data.DataTable)ExcEr.Param.Resultado);
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(lRDS);
            ExcEr = new GeneralesExchange.genReporteEjecutarActionExchange(GeneralesExchange.genReporteEjecutarActionEnum.EnumgenReporteEjecutarAction.Ejecutar);
            ExcEr.StoreProcedure = "INF_DATOSEMPRESA";
            ExcEr.Parametros = cmd.Empresa_Id.ToString();

            ExcEr = new GeneralesExchange.genReporteEjecutarActionExchange(
                 Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcEr, cmd));

            if (ExcEr.Param.Principal.Count == 0)
                Generalidades.qFunctionalException.GenerarExcepcion("No_Hay_Datos_Para_imprimir");

            lRDS = new ReportDataSource("Empresas", (System.Data.DataTable)ExcEr.Param.Resultado);
            ReportViewer1.LocalReport.DataSources.Add(lRDS);


            for (int i = 0; i < ExcR.Param.Procedimientos.Count; i++)
            {

                ExcEr =
                   new GeneralesExchange.genReporteEjecutarActionExchange(GeneralesExchange.genReporteEjecutarActionEnum.EnumgenReporteEjecutarAction.Ejecutar);
                ExcEr.StoreProcedure = ExcR.Param.Procedimientos[i].StoreProcedure;
                ExcEr.Parametros = lParametrosR;

                ExcEr = new GeneralesExchange.genReporteEjecutarActionExchange(
                           Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcEr, cmd));

                lRDS = new ReportDataSource(ExcR.Param.Procedimientos[i].DataTable, (System.Data.DataTable)ExcEr.Param.Resultado);
                ReportViewer1.LocalReport.DataSources.Add(lRDS);

            }


            ReportViewer1.LocalReport.GetDefaultPageSettings();
            ReportViewer1.ShowZoomControl = true;
            //ReportViewer1.AsyncRendering = false;


            // LAS ASIGNO PARA EL WINDOWS
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lCultura);
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(lCultura);
            string lArchivo = "Estado_de_Cuenta_" + eClie.Cliente_Id + ".pdf";

            byte[] lRes = ReportViewer1.LocalReport.Render("PDF");

            ReportViewer1.LocalReport.ReleaseSandboxAppDomain();
            ReportViewer1.LocalReport.Dispose();
            //ReportViewer1.Dispose();

            System.IO.File.WriteAllBytes(lArchivo, lRes);
            // y envio el correo
            List<string> lPara = new List<string> { };
            foreach (var ren in eClie.Param.grdContactos.Where(c => !String.IsNullOrWhiteSpace(c.Email) && c.EnviaFacturas))
            {
                lPara.Add(ren.Email);
            }

            string lTexto = Generalidades.Auxiliares.GetValorMemo("TEXTOEDOCTA", "", cmd);

            string lCuerpo = "Sres " + eClie.RazonSocial + ":<br><br>";
            if (String.IsNullOrWhiteSpace(lTexto))
            {
                lCuerpo += "&ensp;Adjunto a este correo encontrará su Estado de Cuenta<br><br>" +
                        "&ensp;Saludos Cordiales<br><br>";
            }
            else
                lCuerpo += "<br>" + lTexto;
            List<string> pAdjuntos = new List<string> { lArchivo };

            string lError = "";
            bool lResultado = GeneralesValidacion.Correo.Enviar(lPara, Recursos.Recurso.GetString("Estado_de_Cuenta_de_<0>", new object[] { eEmp.RazonSocial }), lCuerpo, pAdjuntos, out lError, cmd);
            System.IO.File.Delete(lArchivo);

            if (!lResultado)
                Generalidades.qFunctionalException.GenerarExcepcion("Error_Al_Enviar_eMail_<0>", new object[] { lError });


            return "S";




        }

        [Generalidades.QFuncion_Condicion]
        public string TieneRemitos(VentasCommon.venConsEdoCtaClientesDS exch, Framework.Core.Command cmd)
        {
            return exch.Remitos.Count == 0 ? "N" : "S";
        }

        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venConsEdoCtaClientesDS CompletarImportes(VentasCommon.venConsEdoCtaClientesDS exch,
          VentasCommon.venConsEdoCtaClientesDS exchNoPost, int pIndice, Command cmd)
        {
            decimal Acum = Math.Abs(exch.CompAAplic[0].Importe);
            foreach (VentasCommon.venConsEdoCtaClientesDS.ComprobantesRow ren in exch.Comprobantes)
            {
                Acum = Acum - ren.ImporteAplicado;
            }
            if (exch.Comprobantes[pIndice].Saldo <= Acum)
                exch.Comprobantes[pIndice].ImporteAplicado = exchNoPost.Comprobantes[pIndice].Saldo;
            else
                exch.Comprobantes[pIndice].ImporteAplicado = Acum;

            return exch;
        }



        [Generalidades.QFuncion_AccionGrilla]
        public VentasCommon.venConsEdoCtaClientesDS AsientoAplicacion(VentasCommon.venConsEdoCtaClientesDS exch,
        VentasCommon.venConsEdoCtaClientesDS exchNoPost, int pIndice, Command cmd)
        {

            exch.AsientoContable.Clear();

            if (exch.Aplicaciones[pIndice].AsientoApli_Id != 0)
            {
                ContabilidadExchange.conMovContActionExchange exchmc = new ContabilidadExchange.conMovContActionExchange(ContabilidadExchange.conMovContActionEnum.EnumconMovContAction.Datos);
                exchmc.conAsientos = exch.Aplicaciones[pIndice].AsientoApli_Id;
                exchmc.Renglon = 0;
                exchmc = new ContabilidadExchange.conMovContActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));

                if (exchmc.Existe)
                {
                    foreach (ContabilidadCommon.conMovContDS.PrincipalRow ren in exchmc.Param.Principal)
                    {
                        exch.AsientoContable.AddAsientoContableRow(ren.Cuenta_Id, ren.DescripcionCuentas, ren.Centro1_Id, ren.Centro2_Id, ren.TipoMov == 1 ? ren.Importe : 0, ren.TipoMov == 2 ? ren.Importe : 0);
                    }
                    exch.Inventario.AcceptChanges();
                }
            }

            if (exch.Aplicaciones[pIndice].AsientoDC_Id != 0)
            {
                ContabilidadExchange.conMovContActionExchange exchmc = new ContabilidadExchange.conMovContActionExchange(ContabilidadExchange.conMovContActionEnum.EnumconMovContAction.Datos);
                exchmc.conAsientos = exch.Aplicaciones[pIndice].AsientoDC_Id;
                exchmc.Renglon = 0;
                exchmc = new ContabilidadExchange.conMovContActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));

                if (exchmc.Existe)
                {
                    foreach (ContabilidadCommon.conMovContDS.PrincipalRow ren in exchmc.Param.Principal)
                    {
                        exch.AsientoContable.AddAsientoContableRow(ren.Cuenta_Id, ren.DescripcionCuentas, ren.Centro1_Id, ren.Centro2_Id, ren.TipoMov == 1 ? ren.Importe : 0, ren.TipoMov == 2 ? ren.Importe : 0);
                    }
                    exch.Inventario.AcceptChanges();
                }
            }

            return exch;

        }

    }
}
