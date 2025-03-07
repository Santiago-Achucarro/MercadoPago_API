using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
using System.Xml;
using System.Security.Cryptography;
using System.Data;

namespace ComprasFEEventos
{
    public class comConsEdoCtaProveedores
    {
        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comConsEdoCtaProveedoresDS Inventario(ComprasCommon.comConsEdoCtaProveedoresDS exch,
         ComprasCommon.comConsEdoCtaProveedoresDS exchNoPost, int pIndice, Command cmd)
        {

            StockExchange.stkMoviCuerpoActionExchange exchmc = new StockExchange.stkMoviCuerpoActionExchange(StockExchange.stkMoviCuerpoActionEnum.EnumstkMoviCuerpoAction.Datos);
            exchmc.stkMoviCabe = exch.Cuerpo[pIndice].comMovProv;
            exchmc.Renglon = 0;
            exchmc = new StockExchange.stkMoviCuerpoActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));
            exch.Inventario.Clear();
            if (exchmc.Existe)
            {
                foreach (StockCommon.stkMoviCuerpoDS.PrincipalRow ren in exchmc.Param.Principal)
                {
                    exch.Inventario.AddInventarioRow(ren.Deposito_Id, ren.Producto_Id, ren.DescripcionProductos, ren.Medida_Id, ren.CantidadForm, ren.PrecioOriginal, ren.CantidadForm * ren.PrecioOriginal);
                }
                exch.Inventario.AcceptChanges();
            }

            if (exch.Inventario.Count == 0)
            {
                ComprasExchange.comMovProvActionExchange eComMovprov =
                        new ComprasExchange.comMovProvActionExchange(ComprasExchange.comMovProvActionEnum.EnumcomMovProvAction.Datos)
                        {
                            comMovProv = exch.Cuerpo[pIndice].comMovProv
                        };
                eComMovprov = new ComprasExchange.comMovProvActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eComMovprov, cmd));

                if (eComMovprov.Existe)
                {

                    switch (eComMovprov.Formulario)
                    {
                        case "frmcomFacturaOC":

                            // Pude ser tambien por O.C.
                            ComprasExchange.comFacturasConOrdenDeCompraActionExchange eFactura =
                                new ComprasExchange.comFacturasConOrdenDeCompraActionExchange(ComprasExchange.comFacturasConOrdenDeCompraActionEnum.EnumcomFacturasConOrdenDeCompraAction.Datos)
                                {
                                    Segmento_Id = eComMovprov.Segmento_Id,
                                    Segmento1C = eComMovprov.Segmento1C,
                                    Segmento2C = eComMovprov.Segmento2C,
                                    Segmento3C = eComMovprov.Segmento3C,
                                    Segmento4C = eComMovprov.Segmento4C,
                                    Segmento1N = eComMovprov.Segmento1N,
                                    Segmento2N = eComMovprov.Segmento2N,
                                    Segmento3N = eComMovprov.Segmento3N,
                                    Segmento4N = eComMovprov.Segmento4N

                                };
                            eFactura = new ComprasExchange.comFacturasConOrdenDeCompraActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eFactura, cmd));
                            foreach (var ren in eFactura.Param.Cuerpo)
                            {
                                exch.Inventario.AddInventarioRow("", ren.Producto_Id, ren.DescripcionProductos, ren.Medida_Id, ren.CantidadForm, ren.PrecioOriginal, ren.CantidadForm * ren.PrecioOriginal);
                            }
                            exch.Inventario.AcceptChanges();
                            break;
                        case "frmcomFacturasEmbarque":
                            // Pude ser tambien por Embarque.
                            ComprasExchange.comFacturasConOrdenDeEmbarqueActionExchange eFacturaEmb =
                                new ComprasExchange.comFacturasConOrdenDeEmbarqueActionExchange(ComprasExchange.comFacturasConOrdenDeEmbarqueActionEnum.EnumcomFacturasConOrdenDeEmbarqueAction.Datos)
                                {
                                    Segmento_Id = eComMovprov.Segmento_Id,
                                    Segmento1C = eComMovprov.Segmento1C,
                                    Segmento2C = eComMovprov.Segmento2C,
                                    Segmento3C = eComMovprov.Segmento3C,
                                    Segmento4C = eComMovprov.Segmento4C,
                                    Segmento1N = eComMovprov.Segmento1N,
                                    Segmento2N = eComMovprov.Segmento2N,
                                    Segmento3N = eComMovprov.Segmento3N,
                                    Segmento4N = eComMovprov.Segmento4N

                                };
                            eFacturaEmb = new ComprasExchange.comFacturasConOrdenDeEmbarqueActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eFacturaEmb, cmd));
                            foreach (var ren in eFacturaEmb.Param.Cuerpo)
                            {
                                exch.Inventario.AddInventarioRow("", ren.Producto_Id, ren.DescripcionProductos, ren.Medida_Id, ren.CantidadForm, ren.PrecioOriginal, ren.CantidadForm * ren.PrecioOriginal);
                            }
                            exch.Inventario.AcceptChanges();
                            break;
                        case "frmcomFacturasVariasOC":
                            // Pude ser tambien por Varias OC.
                            ComprasExchange.comFacturasVariasOCActionExchange eFacturaOCS =
                                new ComprasExchange.comFacturasVariasOCActionExchange(ComprasExchange.comFacturasVariasOCActionEnum.EnumcomFacturasVariasOCAction.Datos)
                                {
                                    Segmento_Id = eComMovprov.Segmento_Id,
                                    Segmento1C = eComMovprov.Segmento1C,
                                    Segmento2C = eComMovprov.Segmento2C,
                                    Segmento3C = eComMovprov.Segmento3C,
                                    Segmento4C = eComMovprov.Segmento4C,
                                    Segmento1N = eComMovprov.Segmento1N,
                                    Segmento2N = eComMovprov.Segmento2N,
                                    Segmento3N = eComMovprov.Segmento3N,
                                    Segmento4N = eComMovprov.Segmento4N

                                };
                            eFacturaOCS = new ComprasExchange.comFacturasVariasOCActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eFacturaOCS, cmd));
                            foreach (var ren in eFacturaOCS.Param.Cuerpo)
                            {
                                exch.Inventario.AddInventarioRow("", ren.Producto_Id, ren.DescripcionProductos, ren.Medida_Id, ren.CantidadForm, ren.PrecioOriginal, ren.CantidadForm * ren.PrecioOriginal);
                            }
                            exch.Inventario.AcceptChanges();
                            break;

                    }

                }
            }
            return exch;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comConsEdoCtaProveedoresDS AsientoContable(ComprasCommon.comConsEdoCtaProveedoresDS exch,
        ComprasCommon.comConsEdoCtaProveedoresDS exchNoPost, int pIndice, Command cmd)
        {

            ContabilidadExchange.conMovContActionExchange exchmc = new ContabilidadExchange.conMovContActionExchange(ContabilidadExchange.conMovContActionEnum.EnumconMovContAction.Datos);
            exchmc.conAsientos = exch.Cuerpo[pIndice].comMovProv;
            exchmc.Renglon = 0;
            exchmc = new ContabilidadExchange.conMovContActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));
            exch.AsientoContable.Clear();
            if (exchmc.Existe)
            {
                foreach (ContabilidadCommon.conMovContDS.PrincipalRow ren in exchmc.Param.Principal)
                {
                    exch.AsientoContable.AddAsientoContableRow(ren.Cuenta_Id, ren.DescripcionCuentas, ren.Centro1_Id, ren.Centro2_Id, ren.TipoMov == 1 ? ren.Importe : 0, ren.TipoMov == 2 ? ren.Importe : 0,ren.LeyendaLibroMayor);
                }
                exch.Inventario.AcceptChanges();
            }

            return exch;

        }

        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comConsEdoCtaProveedoresDS Aplicaciones(ComprasCommon.comConsEdoCtaProveedoresDS exch,
        ComprasCommon.comConsEdoCtaProveedoresDS exchNoPost, int pIndice, Command cmd)
        {
            GeneralesExchange.genCancMovActionExchange exchmc = new GeneralesExchange.genCancMovActionExchange(GeneralesExchange.genCancMovActionEnum.EnumgenCancMovAction.Datos);
            exchmc.Asiento_Id = exch.Cuerpo[pIndice].comMovProv;
            exchmc.CuotaNro = (short)exch.Cuerpo[pIndice].CuotaNro;
            exchmc.Importacion = false;

            exchmc.Asiento_Id_Ap = 0;
            exchmc.CuotaNro_Ap = 0;
            exchmc.Cambio = 1;
            exchmc.Cambio_Ap = 1;
            exchmc = new GeneralesExchange.genCancMovActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));
            exch.Aplicaciones.Clear();
            exch.CompAAplic.Clear();
            exch.CompAAplic.AddCompAAplicRow(exch.Cuerpo[pIndice].comMovProv, (short)exch.Cuerpo[pIndice].CuotaNro,
                exch.Cuerpo[pIndice].Debe == 0 ? exch.Cuerpo[pIndice].Haber : exch.Cuerpo[pIndice].Debe, exch.Cuerpo[pIndice].Debe == 0 ? -1 : 1);
            if (exchmc.Existe)
            {
                foreach (GeneralesCommon.genCancMovDS.CuerpoRow ren in exchmc.Param.Cuerpo)
                {
                    if (exch.Cuerpo[pIndice].Haber == 0)
                        exch.Aplicaciones.AddAplicacionesRow(ren.Segmento_ap, ren.FechaAplicacion, ren.Importe, ren.Usuario_Id, false,
                        ren.Asiento_Id_Ap, ren.CuotaNro_Ap, ren.NroAplicacion, ren.AsientoApli_Id, ren.AsieDifCambio_Id, ren.Importe_ap, ren.Importacion);
                    else
                        exch.Aplicaciones.AddAplicacionesRow(ren.Segmento, ren.FechaAplicacion, ren.Importe, ren.Usuario_Id, false,
                        ren.Asiento_Id, ren.CuotaNro, ren.NroAplicacion, ren.AsientoApli_Id, ren.AsieDifCambio_Id, ren.Importe_ap, ren.Importacion);

                }
            }



            return exch;

        }


        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comConsEdoCtaProveedoresDS Impuestos(ComprasCommon.comConsEdoCtaProveedoresDS exch,
        ComprasCommon.comConsEdoCtaProveedoresDS exchNoPost, int pIndice, Command cmd)
        {
            ComprasExchange.comMovImpuestosActionExchange exchmc = new ComprasExchange.comMovImpuestosActionExchange(ComprasExchange.comMovImpuestosActionEnum.EnumcomMovImpuestosAction.Datos);
            exchmc.comMovProv = exch.Cuerpo[pIndice].comMovProv;
            exchmc.conRenglon = 0;
            exchmc = new ComprasExchange.comMovImpuestosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));
            exch.Impuestos.Clear();
            if (exchmc.Existe)
            {
                foreach (ComprasCommon.comMovImpuestosDS.PrincipalRow ren in exchmc.Param.Principal)
                {
                    exch.Impuestos.AddImpuestosRow(ren.Impuesto_Id, ren.DescripcionCuenta, ren.Base_Imponible, ren.Porcentaje, ren.Importe_Impuesto);
                }
                exch.Impuestos.AcceptChanges();
            }

            return exch;

        }

        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comConsEdoCtaProveedoresDS Valores(ComprasCommon.comConsEdoCtaProveedoresDS exch,
        ComprasCommon.comConsEdoCtaProveedoresDS exchNoPost, int pIndice, Command cmd)
        {
            TesoreriaExchange.tesRengMoviActionExchange exchmc = new TesoreriaExchange.tesRengMoviActionExchange(TesoreriaExchange.tesRengMoviActionEnum.EnumtesRengMoviAction.Datos);

            exchmc.tesMovimientos = exch.Cuerpo[pIndice].comMovProv;
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
                    exch.Valores.AddValoresRow(ren.Cartera_Id, ren.DescripcionIdentifica, ren.Importe, numdoc, fechad);
                }
                exch.Impuestos.AcceptChanges();
            }

            return exch;

        }
        [Generalidades.QFuncion_Condicion]
        public string MuestrasXML(ComprasCommon.comConsEdoCtaProveedoresDS exch, Command cmd)
        {
            string P = "N";
            if (cmd.Dominio_Id == "MX")
                P = "S";
            return P;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comConsEdoCtaProveedoresDS Comprobantes(ComprasCommon.comConsEdoCtaProveedoresDS exch,
         ComprasCommon.comConsEdoCtaProveedoresDS exchNoPost, int pIndice, Command cmd)
        {

            ComprasExchange.comTraePendientesActionExchange exchmc = new ComprasExchange.comTraePendientesActionExchange
                (ComprasExchange.comTraePendientesActionEnum.EnumcomTraePendientesAction.Datos);
            exchmc.comMovProv = exch.Cuerpo[pIndice].comMovProv;
            exchmc.Proveee_id = exch.Principal[0].Proveed_Id;
            exchmc.Moneda_Id = exch.Cuerpo[pIndice].Moneda_Id;
            if (exch.Cuerpo[pIndice].Debe == 0)
                exchmc.Signo = 1;
            else
                exchmc.Signo = -1;

            exchmc = new ComprasExchange.comTraePendientesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));
            exch.Comprobantes.Clear();
            exch.CompAAplic.Clear();
            exch.CompAAplic.AddCompAAplicRow(exch.Cuerpo[pIndice].comMovProv, (short)exch.Cuerpo[pIndice].CuotaNro, exch.Cuerpo[pIndice].Saldo, exchmc.Signo); //Reemplace exchmc.Signo == 1 ? exch.Cuerpo[pIndice].Haber : exch.Cuerpo[pIndice].Debe x el saldo
            if (exchmc.Existe)
            {
                foreach (ComprasCommon.comTraePendientesDS.PendientesRow ren in exchmc.Param.Pendientes)
                {
                    exch.Comprobantes.AddComprobantesRow(ren.comMovProv, ren.SegmentoStr, ren.Fecha, ren.Importe, ren.Saldo,
                        ren.CuotaNro, ren.ImporteAplicado);
                }
                exch.Comprobantes.AcceptChanges();
            }

            return exch;
        }

        /* ESTOS PASARON A ACCIONES PARA QUE SEAN TRANSACIONABLES
         * 
        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comConsEdoCtaProveedoresDS Aplicar(ComprasCommon.comConsEdoCtaProveedoresDS exch,
            ComprasCommon.comConsEdoCtaProveedoresDS exchNoPost, int pIndice, Command cmd)
        {
            GeneralesExchange.genCancMovActionExchange exchmc = new GeneralesExchange.genCancMovActionExchange(GeneralesExchange.genCancMovActionEnum.EnumgenCancMovAction.Guardar);
            exchmc.Asiento_Id = 0;
            exchmc.CuotaNro = 0;
            exchmc.Asiento_Id_Ap = 0;
            exchmc.CuotaNro_Ap = 0;
            exchmc.Cambio = 0;
            exchmc.Cambio_Ap = 0;
            exchmc.Existe = true;
            foreach (ComprasCommon.comConsEdoCtaProveedoresDS.ComprobantesRow ren in exchNoPost.Comprobantes)
            {
                if (ren.ImporteAplicado > 0)
                {

                    if (exch.CompAAplic[0].Signo == 1)
                    {
                        exchmc.Param.Cuerpo.AddCuerpoRow(cmd.Empresa_Id, 0, 0, 0, 0, " ", " ", " ", " ", exch.CompAAplic[0].Cuota_Nro,
                                exch.CompAAplic[0].Asiento_Id, 0, 0, 0, 0, " ", " ", " ", " ", ren.Asiento_Id, ren.NroCuota,
                                ren.Fecha, ren.ImporteAplicado, ren.ImporteAplicado, " ", " ", " ", " ", 0,0, false);
                    }
                    else
                    exchmc.Param.Cuerpo.AddCuerpoRow(cmd.Empresa_Id, 0, 0, 0, 0, " ", " ", " ", " ", ren.NroCuota,
                        ren.Asiento_Id, 0, 0, 0, 0, " ", " ", " ", " ", exch.CompAAplic[0].Asiento_Id, exch.CompAAplic[0].Cuota_Nro,
                        ren.Fecha, ren.ImporteAplicado, ren.ImporteAplicado, " ", " ", " ", " ", 0, 0, false);
                    
                    
                    }
            }
            Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd);
            return exch;
        }
        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comConsEdoCtaProveedoresDS Desaplicar(ComprasCommon.comConsEdoCtaProveedoresDS exch,
            ComprasCommon.comConsEdoCtaProveedoresDS exchNoPost, int pIndice, Command cmd)
        {
            GeneralesExchange.genCancMovActionExchange exchmc = new GeneralesExchange.genCancMovActionExchange(GeneralesExchange.genCancMovActionEnum.EnumgenCancMovAction.Eliminar);
            exchmc.Asiento_Id = 0;
            exchmc.CuotaNro = 0;
            exchmc.Asiento_Id_Ap = 0;
            exchmc.CuotaNro_Ap = 0;
            exchmc.Cambio = 0;
            exchmc.Cambio_Ap = 0;
            exchmc.Existe = true;
            foreach (ComprasCommon.comConsEdoCtaProveedoresDS.AplicacionesRow ren in exchNoPost.Aplicaciones)
            {
                
                if (ren.Seleccionar == true)
                {
                    if (exch.CompAAplic[0].Signo == -1)
                        exchmc.Param.Cuerpo.AddCuerpoRow(cmd.Empresa_Id, 0, 0, 0, 0, " ", " ", " ", " ", exch.CompAAplic[0].Cuota_Nro,
                            exch.CompAAplic[0].Asiento_Id, 0, 0, 0, 0, " ", " ", " ", " ", ren.Asiento_Id, ren.NroCuota,
                            ren.Fecha, ren.Importe, ren.Importe, " ", " ", " ", " ", 0,ren.NroAplicacion, false);
                    else
                        exchmc.Param.Cuerpo.AddCuerpoRow(cmd.Empresa_Id, 0, 0, 0, 0, " ", " ", " ", " ", ren.NroCuota,
                            ren.Asiento_Id, 0, 0, 0, 0, " ", " ", " ", " ", exch.CompAAplic[0].Asiento_Id, exch.CompAAplic[0].Cuota_Nro,
                            ren.Fecha, ren.Importe, ren.Importe, " ", " ", " ", " ", 0,ren.NroAplicacion, false);
                }
            }
            Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd);
            return exch;
        }

    */
        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comConsEdoCtaProveedoresDS EmbarquesRelacionados(ComprasCommon.comConsEdoCtaProveedoresDS exch,
             ComprasCommon.comConsEdoCtaProveedoresDS exchNoPost, int pIndice, Command cmd)
        {
            if (exch.Cuerpo[pIndice].TipoMov != "P")
                Generalidades.qFunctionalException.GenerarExcepcion("El_Movimiento_<0>_No_Es_Un_Pago", new object[] { exch.Cuerpo[pIndice].Segmento });
            exch.Principal[0].Renglon = pIndice;
            exch.Embarques.Clear();
            ComprasExchange.comMovProvEmbActionExchange eRelaciones = new ComprasExchange.comMovProvEmbActionExchange(ComprasExchange.comMovProvEmbActionEnum.EnumcomMovProvEmbAction.Datos);
            eRelaciones.comMovProv = exch.Cuerpo[pIndice].comMovProv;
            eRelaciones = new ComprasExchange.comMovProvEmbActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eRelaciones, cmd));
            if (eRelaciones.Existe)
                foreach (var Reng in eRelaciones.Param.Principal)
                {
                    ComprasExchange.comMovProvEmbDatosFullActionExchange eSegEmb = new ComprasExchange.comMovProvEmbDatosFullActionExchange(ComprasExchange.comMovProvEmbDatosFullActionEnum.EnumcomMovProvEmbDatosFullAction.Datos)
                    {
                        conAsientos = Reng.comEmbarques
                    };
                    eSegEmb = new ComprasExchange.comMovProvEmbDatosFullActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eSegEmb, cmd));
                    exch.Embarques.AddEmbarquesRow(eSegEmb.conAsientos, Reng.comMovProv, eSegEmb.Segmento_Id, eSegEmb.Segmento1N, eSegEmb.Segmento2N,
                        eSegEmb.Segmento3N, eSegEmb.Segmento4N, eSegEmb.Segmento1C, eSegEmb.Segmento2C, eSegEmb.Segmento3C, eSegEmb.Segmento4C, eSegEmb.SegmentoSTR);
                }

            return exch;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comConsEdoCtaProveedoresDS AgregarEmbarque(ComprasCommon.comConsEdoCtaProveedoresDS exch,
                 ComprasCommon.comConsEdoCtaProveedoresDS exchNoPost, int pIndice, Command cmd)
        {
            foreach (var Reng in exch.Embarques)
            {
                if (Reng.IsSegmentoSTRNull() || Reng.SegmentoSTR == "")
                {
                    ComprasExchange.comEmbarquesActionExchange eEmb = new ComprasExchange.comEmbarquesActionExchange(ComprasExchange.comEmbarquesActionEnum.EnumcomEmbarquesAction.Datos)
                    {
                        Segmento_Id = Reng.Segmento_Id,
                        Segmento1N = Reng.Segmento1N,
                        Segmento2N = Reng.Segmento2N,
                        Segmento3N = Reng.Segmento3N,
                        Segmento4N = Reng.Segmento4N,
                        Segmento1C = Reng.Segmento1C,
                        Segmento2C = Reng.Segmento2C,
                        Segmento3C = Reng.Segmento3C,
                        Segmento4C = Reng.Segmento4C
                    };
                    eEmb = new ComprasExchange.comEmbarquesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eEmb, cmd));
                    ComprasExchange.comMovProvEmbDatosFullActionExchange eSegEmb = new ComprasExchange.comMovProvEmbDatosFullActionExchange(ComprasExchange.comMovProvEmbDatosFullActionEnum.EnumcomMovProvEmbDatosFullAction.Datos)
                    {
                        conAsientos = eEmb.comEmbarques
                    };
                    eSegEmb = new ComprasExchange.comMovProvEmbDatosFullActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eSegEmb, cmd));
                    Reng.comEmbarque = eEmb.comEmbarques;
                    Reng.SegmentoSTR = eSegEmb.SegmentoSTR;
                    Reng.comMovProv = exchNoPost.Cuerpo[0].comMovProv;
                }
            }
            return exch;
        }

        [Generalidades.QFuncion_AccionDescargarFila]
        public Generalidades.DescargaArchivoDS Xml(ComprasCommon.comConsEdoCtaProveedoresDS exch,
            ComprasCommon.comConsEdoCtaProveedoresDS exchNoPost, int pIndice, Command cmd)
        {
            ComprasExchange.comMovProvActionExchange ExcMp = new ComprasExchange.comMovProvActionExchange(ComprasExchange.comMovProvActionEnum.EnumcomMovProvAction.Datos)
            {
                comMovProv = exch.Cuerpo[pIndice].comMovProv
            };

            ExcMp = new ComprasExchange.comMovProvActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcMp, cmd));
            if (ExcMp.Existe && ExcMp.XMLFiscal != "")
            {
                string lNombreArchivo = ExcMp.ClaveFiscal;
                if (lNombreArchivo == "")
                    lNombreArchivo = ExcMp.Proveed_Id + "_" + ExcMp.Segmento1N.ToString();

                return Generalidades.Archivos.ConvertirADatasetDownload("XML", lNombreArchivo + ".xml", false, "XML",
                                    Convert.ToBase64String(UTF8Encoding.UTF8.GetBytes(ExcMp.XMLFiscal)));
            }
            Generalidades.qFunctionalException.GenerarExcepcion("No_Se_pudo_Descargar_el_XML");
            return new Generalidades.DescargaArchivoDS();
        }


        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comConsEdoCtaProveedoresDS AdjuntarXml(ComprasCommon.comConsEdoCtaProveedoresDS exch,
                 ComprasCommon.comConsEdoCtaProveedoresDS exchNoPost, int pIndice, Command cmd)

        {
            if (exch.Principal[0].OrigenXml == "U")
            {
                Generalidades.Archivos.QEstadoArchivo qEstadoArchivo;
                string lNombreCliente;
                string lNombreTemp;
                Generalidades.Archivos.ObtenerInfoArchivoUpload(exch.Principal[0].XmlUpload, cmd.Instalacion,
                        cmd.Empresa_Id, cmd.Usuario_Id, out qEstadoArchivo, out lNombreCliente, out lNombreTemp);


                string lUUID = "";
                string lRfcEmisor = "";
                string lRfcReceptor = "";
                if (qEstadoArchivo.Equals(Generalidades.Archivos.QEstadoArchivo.Nuevo))
                {
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(lNombreTemp);
                    // Averiguo el UUID 

                    XmlNodeList Timbre = xDoc.GetElementsByTagName("tfd:TimbreFiscalDigital");
                    if (Timbre.Count == 0)
                        Generalidades.qFunctionalException.GenerarExcepcion("No_Tiene_El_Nodo_TimbreFiscal");

                    lUUID = ((XmlElement)Timbre[0]).GetAttribute("UUID");

                    XmlNodeList Emisor = xDoc.GetElementsByTagName("cfdi:Emisor");
                    if (Emisor.Count == 0)
                        Generalidades.qFunctionalException.GenerarExcepcion("No_Tiene_El_Nodo_Emisor");

                    lRfcEmisor = ((XmlElement)Emisor[0]).GetAttribute("Rfc");
                    ComprasExchange.comProveedoresActionExchange ePROV = new ComprasExchange.comProveedoresActionExchange(ComprasExchange.comProveedoresActionEnum.EnumcomProveedoresAction.Datos)
                    {
                        Proveed_Id = exch.Principal[0].Proveed_Id
                    };
                    ePROV = new ComprasExchange.comProveedoresActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ePROV, cmd));

                    if (ePROV.CUIT.Trim() != lRfcEmisor.Trim())
                        Generalidades.qFunctionalException.GenerarExcepcion("El_XML_Pertenece_Al_Proveedor_<0>", new object[] { lRfcEmisor });

                    XmlNodeList Receptor = xDoc.GetElementsByTagName("cfdi:Receptor");
                    if (Receptor.Count == 0)
                        Generalidades.qFunctionalException.GenerarExcepcion("No_Tiene_El_Nodo_Receptor");

                    lRfcReceptor = ((XmlElement)Receptor[0]).GetAttribute("Rfc");
                    GeneralesExchange.genEmpresasActionExchange eEmpr = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);
                    if (eEmpr.Cuit.Trim() != lRfcReceptor)
                        Generalidades.qFunctionalException.GenerarExcepcion("El_XML_Pertenece_A_La_Empresa_<0>", new object[] { lRfcReceptor });
                    // TODO GUARDAR
                    ComprasExchange.comMovProvActionExchange eMovProv = new ComprasExchange.comMovProvActionExchange(ComprasExchange.comMovProvActionEnum.EnumcomMovProvAction.AdjuntarXML);
                    eMovProv.comMovProv = exch.Cuerpo[pIndice].comMovProv;
                    eMovProv.XMLFiscal = xDoc.InnerXml;
                    eMovProv.ClaveFiscal = lUUID;
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(eMovProv, cmd);
                    //Generalidades.qFunctionalException.GenerarExcepcion("UUID:" + lUUID + " Emisor:" + lRfcEmisor + " Receptor:" + lRfcReceptor);

                }
                exch.Cuerpo[pIndice].XML = 1;
                return exch;
            }
            else
            {
                string lUUID = "";
                string lRfcEmisor = "";
                string lRfcReceptor = "";
                ComprasExchange.comCFDISatActionExchange eCFDI = new ComprasExchange.comCFDISatActionExchange(ComprasExchange.comCFDISatActionEnum.EnumcomCFDISatAction.Datos)
                {
                    UUID = exch.Principal[0].Xml
                };
                eCFDI = new ComprasExchange.comCFDISatActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eCFDI, cmd));
                XmlDocument xDoc = new XmlDocument();

                xDoc.LoadXml(eCFDI.XML);
                // Averiguo el UUID 

                XmlNodeList Timbre = xDoc.GetElementsByTagName("tfd:TimbreFiscalDigital");
                if (Timbre.Count == 0)
                    Generalidades.qFunctionalException.GenerarExcepcion("No_Tiene_El_Nodo_TimbreFiscal");

                lUUID = ((XmlElement)Timbre[0]).GetAttribute("UUID");

                XmlNodeList Emisor = xDoc.GetElementsByTagName("cfdi:Emisor");
                if (Emisor.Count == 0)
                    Generalidades.qFunctionalException.GenerarExcepcion("No_Tiene_El_Nodo_Emisor");

                lRfcEmisor = ((XmlElement)Emisor[0]).GetAttribute("Rfc");
                ComprasExchange.comProveedoresDatosCUITActionExchange ePROV = new ComprasExchange.comProveedoresDatosCUITActionExchange(ComprasExchange.comProveedoresDatosCUITActionEnum.EnumcomProveedoresDatosCUITAction.Datos)
                {
                    Proveed_Id = lRfcEmisor
                };
                ePROV = new ComprasExchange.comProveedoresDatosCUITActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(ePROV, cmd));
                if (exch.Principal[0].Proveed_Id.Trim() != ePROV.Proveed_Id.Trim())
                    Generalidades.qFunctionalException.GenerarExcepcion("El_XML_Pertenece_Al_Proveedor_<0>", new object[] { ePROV.Proveed_Id });

                XmlNodeList Receptor = xDoc.GetElementsByTagName("cfdi:Receptor");
                if (Receptor.Count == 0)
                    Generalidades.qFunctionalException.GenerarExcepcion("No_Tiene_El_Nodo_Receptor");

                lRfcReceptor = ((XmlElement)Receptor[0]).GetAttribute("Rfc");
                GeneralesExchange.genEmpresasActionExchange eEmpr = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);
                if (eEmpr.Cuit.Trim() != lRfcReceptor)
                    Generalidades.qFunctionalException.GenerarExcepcion("El_XML_Pertenece_A_La_Empresa_<0>", new object[] { lRfcReceptor });
                // TODO GUARDAR
                ComprasExchange.comMovProvActionExchange eMovProv = new ComprasExchange.comMovProvActionExchange(ComprasExchange.comMovProvActionEnum.EnumcomMovProvAction.AdjuntarXML);
                eMovProv.comMovProv = exch.Cuerpo[pIndice].comMovProv;
                eMovProv.XMLFiscal = xDoc.InnerXml;
                eMovProv.ClaveFiscal = lUUID;
                Generalidades.QBIInternal.WrapperExecuteActionInternal(eMovProv, cmd);
                //Generalidades.qFunctionalException.GenerarExcepcion("UUID:" + lUUID + " Emisor:" + lRfcEmisor + " Receptor:" + lRfcReceptor);


                exch.Cuerpo[pIndice].XML = 1;
                return exch;
            }

        }


        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comConsEdoCtaProveedoresDS AsientoAplicacion(ComprasCommon.comConsEdoCtaProveedoresDS exch,
ComprasCommon.comConsEdoCtaProveedoresDS exchNoPost, int pIndice, Command cmd)
        {


            exch.AsientoContable.Clear();
            if (!exch.Aplicaciones[0].IsAsientoApli_IdNull() && exch.Aplicaciones[0].AsientoApli_Id != 0)
            {
                ContabilidadExchange.conMovContActionExchange exchmc = new ContabilidadExchange.conMovContActionExchange(ContabilidadExchange.conMovContActionEnum.EnumconMovContAction.Datos);
                exchmc.conAsientos = exch.Aplicaciones[0].AsientoApli_Id;

                exchmc.Renglon = 0;
                exchmc = new ContabilidadExchange.conMovContActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));
                if (exchmc.Existe)
                {
                    foreach (ContabilidadCommon.conMovContDS.PrincipalRow ren in exchmc.Param.Principal)
                    {
                        exch.AsientoContable.AddAsientoContableRow(ren.Cuenta_Id, ren.DescripcionCuentas, ren.Centro1_Id, ren.Centro2_Id,
                            ren.TipoMov == 1 ? ren.Importe : 0, ren.TipoMov == 2 ? ren.Importe : 0,ren.LeyendaLibroMayor);
                    }
                }
                exch.AsientoContable.AcceptChanges();
            }

            // AJ  AGO 21 AGREGO EL DE DIF EN CAMBIO
            if (!exch.Aplicaciones[0].IsAsiDifCambio_IdNull() && exch.Aplicaciones[0].AsiDifCambio_Id != 0)
            {
                ContabilidadExchange.conMovContActionExchange exchmc = new ContabilidadExchange.conMovContActionExchange(ContabilidadExchange.conMovContActionEnum.EnumconMovContAction.Datos);
                exchmc.conAsientos = exch.Aplicaciones[0].AsiDifCambio_Id;
                exchmc.Renglon = 0;
                exchmc = new ContabilidadExchange.conMovContActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));
                if (exchmc.Existe)
                {
                    foreach (ContabilidadCommon.conMovContDS.PrincipalRow ren in exchmc.Param.Principal)
                    {
                        exch.AsientoContable.AddAsientoContableRow(ren.Cuenta_Id, ren.DescripcionCuentas, ren.Centro1_Id, ren.Centro2_Id,
                            ren.TipoMov == 1 ? ren.Importe : 0, ren.TipoMov == 2 ? ren.Importe : 0, ren.LeyendaLibroMayor);
                    }
                }
                exch.AsientoContable.AcceptChanges();
            }

            return exch;

        }

        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comConsEdoCtaProveedoresDS ConsultaOcEmb(ComprasCommon.comConsEdoCtaProveedoresDS exch,
ComprasCommon.comConsEdoCtaProveedoresDS exchNoPost, int pIndice, Command cmd)
        {

            ComprasExchange.comConsEdoCtaOcEmbActionExchange exchmc = new ComprasExchange.comConsEdoCtaOcEmbActionExchange(ComprasExchange.comConsEdoCtaOcEmbActionEnum.EnumcomConsEdoCtaOcEmbAction.Datos)

            {
                comMovProv = exch.Cuerpo[pIndice].comMovProv

            };
            exchmc = new ComprasExchange.comConsEdoCtaOcEmbActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchmc, cmd));
            exch.EmbCons.Clear();
            exch.EmbCons.Merge(exchmc.Param.Embarques, false, System.Data.MissingSchemaAction.Ignore);
            exch.Oc.Clear();
            exch.Oc.Merge(exchmc.Param.Principal, false, System.Data.MissingSchemaAction.Ignore);
            return exch;

        }

        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comConsEdoCtaProveedoresDS CompletarImportes(ComprasCommon.comConsEdoCtaProveedoresDS exch,
        ComprasCommon.comConsEdoCtaProveedoresDS exchNoPost, int pIndice, Command cmd)
        {
            decimal Acum = Math.Abs(exch.CompAAplic[0].Importe);
            foreach (ComprasCommon.comConsEdoCtaProveedoresDS.ComprobantesRow ren in exch.Comprobantes)
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
        public ComprasCommon.comConsEdoCtaProveedoresDS EliminarXML(ComprasCommon.comConsEdoCtaProveedoresDS exch,
            ComprasCommon.comConsEdoCtaProveedoresDS exchNoPost, int pIndice, Command cmd)
        {

            ComprasExchange.comConsEdoCtaProveedoresActionExchange eRenglon = new ComprasExchange.comConsEdoCtaProveedoresActionExchange(ComprasExchange.comConsEdoCtaProveedoresActionEnum.EnumcomConsEdoCtaProveedoresAction.EliminarXML);
            eRenglon.Param.Cuerpo.AddCuerpoRow(exch.Cuerpo[pIndice].comMovProv, exch.Cuerpo[pIndice].TipoMov, exch.Cuerpo[pIndice].Tipomovs,
                exch.Cuerpo[pIndice].Segmento, exch.Cuerpo[pIndice].Fecha, exch.Cuerpo[pIndice].Debe, exch.Cuerpo[pIndice].Haber,
                exch.Cuerpo[pIndice].Saldo, exch.Cuerpo[pIndice].SaldoAcum, exch.Cuerpo[pIndice].CuotaNro, exch.Cuerpo[pIndice].FechaVencimiento,
                exch.Cuerpo[pIndice].Moneda_Id, exch.Cuerpo[pIndice].Cambio, exch.Cuerpo[pIndice].Apellido_y_Nombres, exch.Cuerpo[pIndice].FechaRegistro,
                exch.Cuerpo[pIndice].XML, exch.Cuerpo[pIndice].EditaEmbarques, exch.Cuerpo[pIndice].Observaciones, exch.Cuerpo[pIndice].Base_Ganancias,
                exch.Cuerpo[pIndice].TipoCtaProv, exch.Cuerpo[pIndice].TipoCtaProvDescripcion, exch.Cuerpo[pIndice].ClaveFiscal);

            eRenglon = new
                ComprasExchange.comConsEdoCtaProveedoresActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eRenglon, cmd));

            exch.Cuerpo[pIndice].XML = 0;
            return exch;
        }


        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comConsEdoCtaProveedoresDS TraerAdjuntos(ComprasCommon.comConsEdoCtaProveedoresDS exch,
         ComprasCommon.comConsEdoCtaProveedoresDS exchNoPost, int pIndice, Command cmd)
        {

            GeneralesExchange.genGlobalesActionExchange eGenGlobales = new GeneralesExchange.genGlobalesActionExchange(GeneralesExchange.genGlobalesActionEnum.EnumgenGlobalesAction.Datos)
            {
                Empresa_Id = cmd.Empresa_Id,
                Nombre_Var = "PathAdjuntosMovProv"
            };
            eGenGlobales = new GeneralesExchange.genGlobalesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eGenGlobales, cmd));
            string lDirAdjuntos = "C:\\Adv\\Adjuntos\\AdjuntosMovProv\\" + cmd.Empresa_Id.ToString() + "\\";
            if (eGenGlobales.Existe && !String.IsNullOrWhiteSpace(eGenGlobales.cValor))
            {
                lDirAdjuntos = eGenGlobales.cValor.Trim();

            }

            if (!lDirAdjuntos.EndsWith("\\"))
            {
                lDirAdjuntos += "\\";
            }

            DataTable dt = Generalidades.Auxiliares.AdjuntosCompletarDatos("comMovProv", exch.Cuerpo[pIndice].comMovProv, lDirAdjuntos, cmd);

            exch.Adjuntos.Clear();
            exch.Adjuntos.Merge(dt, false, System.Data.MissingSchemaAction.Ignore);
            exch.Adjuntos.AcceptChanges();

            return exch;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public ComprasCommon.comConsEdoCtaProveedoresDS GuardarAdjuntos(ComprasCommon.comConsEdoCtaProveedoresDS exch,
        ComprasCommon.comConsEdoCtaProveedoresDS exchNoPost, int pIndice, Command cmd)
        {

            GeneralesExchange.genGlobalesActionExchange eGenGlobales = new GeneralesExchange.genGlobalesActionExchange(GeneralesExchange.genGlobalesActionEnum.EnumgenGlobalesAction.Datos)
            {
                Empresa_Id = cmd.Empresa_Id,
                Nombre_Var = "PathAdjuntosMovProv"
            };
            eGenGlobales = new GeneralesExchange.genGlobalesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eGenGlobales, cmd));
            string lDirAdjuntos = "C:\\Adv\\Adjuntos\\AdjuntosMovProv\\" + cmd.Empresa_Id.ToString() + "\\";
            if (eGenGlobales.Existe && !String.IsNullOrWhiteSpace(eGenGlobales.cValor))
            {
                lDirAdjuntos = eGenGlobales.cValor.Trim();

            }

            if (!lDirAdjuntos.EndsWith("\\"))
            {
                lDirAdjuntos += "\\";
            }

            if (!System.IO.Directory.Exists(lDirAdjuntos))
            {
                System.IO.Directory.CreateDirectory(lDirAdjuntos);
            }


            Generalidades.Auxiliares.AdjuntosGuardar("comMovProv", exch.Cuerpo[pIndice].comMovProv, exch.Adjuntos, lDirAdjuntos, cmd);


            return exch;
        }
    }
}