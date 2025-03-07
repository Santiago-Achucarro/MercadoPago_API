using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasFEEventos
{
    public class venMovimientosSinStock
    {

        [Generalidades.QFuncion_Condicion]
        public string Extranjero(VentasCommon.venMovimientosSinStockDS exch, Framework.Core.Command cmd)
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
        public string PideCambio(VentasCommon.venMovimientosSinStockDS exch, Framework.Core.Command cmd)
        {
            // Si la moneda de facturación es diferente de la moneda base, entonces tiene que pedir el cambio //
            bool lCambio1 = true;
            if (exch.Principal[0].Moneda_Id != cmd.MonedaBase)
                lCambio1 = false;


            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
                new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideCambio && !lCambio1)
                return "S";
            else
                return "N";
        }



        [Generalidades.QFuncion_Condicion]
        public string EnMonedaBase(VentasCommon.venMovimientosSinStockDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Moneda_Id == "" || exch.Principal[0].Moneda_Id == cmd.MonedaBase)
                return "S";
            else
                return "N";
        }


        /*
        [Generalidades.QFuncion_Condicion]
        public string ModCondPago(VentasCommon.venMovimientosSinStockDS exch, Framework.Core.Command cmd)
        {

            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
                new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));

            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.ModCondPago)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string ModVendedor(VentasCommon.venMovimientosSinStockDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
                new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                        Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));

            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.ModVendedor)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }


        [Generalidades.QFuncion_Condicion]
        public string PideObervaciones(VentasCommon.venMovimientosSinStockDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
                new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);

            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));
            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.PideObervaciones)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }
        */

        [Generalidades.QFuncion_Condicion]
        public string Anulada(VentasCommon.venMovimientosSinStockDS exch, Framework.Core.Command cmd)
        {
            return (exch.Principal[0].Anulado ? "S" : "N");
        }

        /*
        [Generalidades.QFuncion_Condicion]
        public string ModificaCuenta(VentasCommon.venMovimientosSinStockDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
               new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);


            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));
            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.ModCtaDefecto)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string ModificaCentro1(VentasCommon.venMovimientosSinStockDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
               new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);


            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));
            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.ModCentro1)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string ModificaCentro2(VentasCommon.venMovimientosSinStockDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
               new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);


            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));
            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.ModCentro2)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }
        */

        [Generalidades.QFuncion_CondicionGrilla]
        public String ValidarFila(VentasCommon.venMovimientosSinStockDS exch, VentasCommon.venMovimientosSinStockDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            VentasCommon.venMovimientosSinStockDS.grdCuerpoDataTable lDF = exchNoPost.grdCuerpo;

            if (lDF[0].Detalle == "")
                return "Debe_Ingresar_Un_Valor_en_Detalle";

            if (cmd.Dominio_Id == "MX")
                StockValidacion.stkUniMed.ExistePosteadoyActivo(lDF[0].Medida_Id, cmd);

            StockValidacion.stkCondFisVenta.ExistePosteadoyActivo(lDF[0].CFVenta_Id, cmd);

            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
             new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);


            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));
            if (ExcVenSubTipomov.Existe)
            {

                if (ExcVenSubTipomov.ModCtaDefecto)
                    ContabilidadValidacion.conCuentas.ExistePosteadoActivaImputableNoReservada(lDF[0].Cuenta_Id, cmd);

                if (ExcVenSubTipomov.ModCentro1)
                    ContabilidadValidacion.conCentro1.ExistePosteadoyActivo(lDF[0].Centro1_Id, cmd);

                if (ExcVenSubTipomov.ModCentro2)
                    ContabilidadValidacion.conCentro2.ExistePosteadoyActivo(lDF[0].Centro2_Id, cmd);


            }

            return "";

        }

        /*
        [Generalidades.QFuncion_Condicion]
        public string PideCodProd(VentasCommon.venMovimientosSinStockDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
               new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);


            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));
            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.PideCodProd)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }

        [Generalidades.QFuncion_Condicion]
        public string PidePredial(VentasCommon.venMovimientosSinStockDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
               new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);


            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));
            if (ExcVenSubTipomov.Existe)
            {
                if (ExcVenSubTipomov.PidePredial)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }
        */

        // PARA INE
        [Generalidades.QFuncion_Condicion]
        public string EsOrdinario(VentasCommon.venMovimientosSinStockDS exch, Framework.Core.Command cmd)
        {
            VentasFEEventos.venMovimientosFiscales lm = new VentasFEEventos.venMovimientosFiscales();
            return lm.EsOrdinario(exch.venMovFiscal[0].TipoProceso);

        }

        [Generalidades.QFuncion_Condicion]
        public string EsEstatal(VentasCommon.venMovimientosSinStockDS exch, Framework.Core.Command cmd)
        {
            VentasFEEventos.venMovimientosFiscales lm = new VentasFEEventos.venMovimientosFiscales();
            return lm.EsEstatal(exch.venMovFiscal[0].TipoComite);

        }

        [Generalidades.QFuncion_Condicion]
        public string HabilitaCompAsoc(VentasCommon.venMovimientosSinStockDS exch, Framework.Core.Command cmd)
        {
            if ("DR".Contains(exch.Principal[0].venTipoMov))
                return "S";
            return "N";

        }

        [Generalidades.QFuncion_Condicion]
        public string Pais(VentasCommon.venMovimientosConStockDS exch, Framework.Core.Command cmd)
        {
            return cmd.Dominio_Id;
        }



        [Generalidades.QFuncion_CondicionGrilla]
        public String ValidarCFDIR(VentasCommon.venMovimientosSinStockDS exch, VentasCommon.venMovimientosSinStockDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {

            VentasExchange.venMovimientosConsultaActionExchange exchVMC = new VentasExchange.venMovimientosConsultaActionExchange
                (VentasExchange.venMovimientosConsultaActionEnum.EnumvenMovimientosConsultaAction.Datos);
            exchVMC.Segmento_Id = exchNoPost.venMovimientosCFDIR[0].Segmento_Id;
            exchVMC.Segmento1N = exchNoPost.venMovimientosCFDIR[0].Segmento1N;
            exchVMC.Segmento2N = exchNoPost.venMovimientosCFDIR[0].Segmento2N;
            exchVMC.Segmento3N = exchNoPost.venMovimientosCFDIR[0].Segmento3N;
            exchVMC.Segmento4N = exchNoPost.venMovimientosCFDIR[0].Segmento4N;
            exchVMC.Segmento1C = exchNoPost.venMovimientosCFDIR[0].Segmento1C;
            exchVMC.Segmento2C = exchNoPost.venMovimientosCFDIR[0].Segmento2C;
            exchVMC.Segmento3C = exchNoPost.venMovimientosCFDIR[0].Segmento3C;
            exchVMC.Segmento4C = exchNoPost.venMovimientosCFDIR[0].Segmento4C;

            exchVMC = new VentasExchange.venMovimientosConsultaActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Framework.Core.Exchange(exchVMC), cmd));
            if (!exchVMC.Existe)
                return "No_existe_el_comprobante";

            // TODO FM Falta validar la lupa de relaciones desde entidades básicas

            return "";

        }

        public enum venMovimientosSinStockVar
        {
            PideCambio, ModCondPago, ModVendedor, PideObservaciones, ModCtaDefecto, ModCentro1, ModCentro2,
            PideCodProd, PidePredial, STMIngresado, CtaDefecto, Centro1Defecto, Centro2Defecto, LetraCondFiscal
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesSubTipo(VentasCommon.venMovimientosSinStockDS exch,
    VentasCommon.venMovimientosSinStockDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            VentasExchange.venSubTipoMovActionExchange ExcVenSubTipomov =
   new VentasExchange.venSubTipoMovActionExchange(VentasExchange.venSubTipoMovActionEnum.EnumvenSubTipoMovAction.Datos);


            ExcVenSubTipomov.SubTipoMov_Id = exch.Principal[0].SubTipoMov_Id;
            ExcVenSubTipomov = new VentasExchange.venSubTipoMovActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExcVenSubTipomov, cmd));

            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            if (exch.Principal[0].SubTipoMov_Id != "" && exch.Principal[0].Cliente_Id != "")
                lRetorno.Add(venMovimientosSinStockVar.STMIngresado.ToString(), "S");
            else
                lRetorno.Add(venMovimientosSinStockVar.STMIngresado.ToString(), "N");


            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PidePredial)
                lRetorno.Add(venMovimientosSinStockVar.PidePredial.ToString(), "S");
            else
                lRetorno.Add(venMovimientosSinStockVar.PidePredial.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideCambio)
                lRetorno.Add(venMovimientosSinStockVar.PideCambio.ToString(), "S");
            else
                lRetorno.Add(venMovimientosSinStockVar.PideCambio.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModCondPago)
                lRetorno.Add(venMovimientosSinStockVar.ModCondPago.ToString(), "S");
            else
                lRetorno.Add(venMovimientosSinStockVar.ModCondPago.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModVendedor)
                lRetorno.Add(venMovimientosSinStockVar.ModVendedor.ToString(), "S");
            else
                lRetorno.Add(venMovimientosSinStockVar.ModVendedor.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideObervaciones)
                lRetorno.Add(venMovimientosSinStockVar.PideObservaciones.ToString(), "S");
            else
                lRetorno.Add(venMovimientosSinStockVar.PideObservaciones.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModCtaDefecto)
                lRetorno.Add(venMovimientosSinStockVar.ModCtaDefecto.ToString(), "S");
            else
                lRetorno.Add(venMovimientosSinStockVar.ModCtaDefecto.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModCentro1)
                lRetorno.Add(venMovimientosSinStockVar.ModCentro1.ToString(), "S");
            else
                lRetorno.Add(venMovimientosSinStockVar.ModCentro1.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.ModCentro2)
                lRetorno.Add(venMovimientosSinStockVar.ModCentro2.ToString(), "S");
            else
                lRetorno.Add(venMovimientosSinStockVar.ModCentro2.ToString(), "N");

            if (ExcVenSubTipomov.Existe && ExcVenSubTipomov.PideCodProd)
                lRetorno.Add(venMovimientosSinStockVar.PideCodProd.ToString(), "S");
            else
                lRetorno.Add(venMovimientosSinStockVar.PideCodProd.ToString(), "N");

            lRetorno.Add(venMovimientosSinStockVar.CtaDefecto.ToString(), ExcVenSubTipomov.CtaDefecto);

            // Seguen Datos Generales
            var eEmpresa = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);
            string lCentro1 = "";
            try
            {
                switch (eEmpresa.Centro1De)
                {
                    case "CLI":
                        lCentro1 = VentasValidacion.venClieHabitual.Existe(exch.Principal[0].Cliente_Id, exch.Principal[0].Sucursal, cmd).Centro1_Id;
                        break;
                    case "DEP":
                        lCentro1 = StockValidacion.stkDepositos.Existe(GeneralesValidacion.genSucursalesEmpr.Existe(GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Sucursal, cmd).DepositoVentas, cmd).Centro1_Id;
                        break;
                    case "SUB":
                        lCentro1 = ExcVenSubTipomov.Centro1_Id;
                        break;

                }
            }
            catch
            {
            }

            lRetorno.Add(venMovimientosSinStockVar.Centro1Defecto.ToString(), lCentro1);

            string lCentro2 = "";
            try
            {
                switch (eEmpresa.Centro2De)
                {
                    case "CLI":
                        lCentro2 = VentasValidacion.venClieHabitual.Existe(exch.Principal[0].Cliente_Id, exch.Principal[0].Sucursal, cmd).Centro2_Id;
                        break;
                    case "DEP":
                        lCentro2 = StockValidacion.stkDepositos.Existe(GeneralesValidacion.genSucursalesEmpr.Existe(GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Sucursal, cmd).DepositoVentas, cmd).Centro2_Id;
                        break;
                    case "SUB":
                        lCentro1 = ExcVenSubTipomov.Centro2_Id;
                        break;

                }
            }
            catch
            {
            }

            lRetorno.Add(venMovimientosSinStockVar.Centro2Defecto.ToString(), lCentro2);

            return lRetorno;
        }
        [Generalidades.QFuncion_Condicion]
        public string MostrarBotonIne(VentasCommon.venMovimientosSinStockDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venClieHabitualActionExchange eClie = new VentasExchange.venClieHabitualActionExchange(VentasExchange.venClieHabitualActionEnum.EnumvenClieHabitualAction.Datos);
            eClie.Cliente_Id = exch.Principal[0].Cliente_Id;
            eClie.Sucursal = exch.Principal[0].Sucursal;
            eClie = new VentasExchange.venClieHabitualActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eClie, cmd));
            if (eClie.UsaComplementoINE)
                return ("S");
            return ("N");
        }

        [Generalidades.QFuncion_EnviarMail]
        public Generalidades.CorreoDS Enviar(VentasCommon.venMovimientosSinStockDS pCommonDS, Framework.Core.Command cmd)
        {
            Generalidades.CorreoDS lRetorno = new Generalidades.CorreoDS();
            VentasExchange.venMovimientosEnviarActionExchange eMov = new VentasExchange.venMovimientosEnviarActionExchange(VentasExchange.venMovimientosEnviarActionEnum.EnumvenMovimientosEnviarAction.Datos)
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
            eMov = new VentasExchange.venMovimientosEnviarActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eMov, cmd));

            lRetorno.Principal.AddPrincipalRow(eMov.Param.Cabecera[0].Asunto, eMov.Param.Cabecera[0].Cuerpo,
                    eMov.Param.Cabecera[0].Destinatarios, eMov.Param.Cabecera[0].DestinatariosCopia, eMov.Param.Cabecera[0].DestinatariosCopiaOculta, false);
            foreach (var ren in eMov.Param.Adjuntos)
            {
                lRetorno.Adjuntos.AddAdjuntosRow(ren.Renglon, ren.Guid, ren.NombreArchivo, ren.Extension,
                      ren.ArchivoBase64, ren.Estado);
            }
            //...... 
            //...... 
            // Los destinatarios van separados por ';'
            // El datatable de adjuntos tiene la misma estructura y forma de utilizarse que el datatable adjuntos de cualquier entidad o movimiwento
            // Se puede usar el método Generalidades.Auxiliares.AdjuntosCompletarDatos(NombreTabla, Identity, Path, cmd) para completar el datatable de ajuntos del mail, con los adjuntos asociados a la entidad o movimiento
            return lRetorno;

        }

        [Generalidades.QFuncion_Condicion]
        public string EnviaFactura(VentasCommon.venMovimientosSinStockDS exch, Framework.Core.Command cmd)
        {

            return (GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd).EnviaFacturas ? "S" : "N");
        }
        [Generalidades.QFuncion_Condicion]
        public String NCdeFacDeCred(VentasCommon.venMovimientosSinStockDS exch, Framework.Core.Command cmd)
        {
            VentasExchange.venMovimientosConsultaActionExchange exchVMC = new VentasExchange.venMovimientosConsultaActionExchange
     (VentasExchange.venMovimientosConsultaActionEnum.EnumvenMovimientosConsultaAction.Datos);
            exchVMC.Segmento_Id = exch.venComprobAsoc[0].Segmento_Id;
            exchVMC.Segmento1N = exch.venComprobAsoc[0].Segmento1N;
            exchVMC.Segmento2N = exch.venComprobAsoc[0].Segmento2N;
            exchVMC.Segmento3N = exch.venComprobAsoc[0].Segmento3N;
            exchVMC.Segmento4N = exch.venComprobAsoc[0].Segmento4N;
            exchVMC.Segmento1C = exch.venComprobAsoc[0].Segmento1C;
            exchVMC.Segmento2C = exch.venComprobAsoc[0].Segmento2C;
            exchVMC.Segmento3C = exch.venComprobAsoc[0].Segmento3C;
            exchVMC.Segmento4C = exch.venComprobAsoc[0].Segmento4C;

            exchVMC = new VentasExchange.venMovimientosConsultaActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Framework.Core.Exchange(exchVMC), cmd));
            if (!exchVMC.Existe)
                Generalidades.qFunctionalException.GenerarExcepcion("No_existe_el_comprobante");

            // Si estoy haciendo una NC o ND y la factura, ND o NC relacionada es de crédito que pregunte si es por anulación //
            if ((exch.Principal[0].venTipoMov == "R" || exch.Principal[0].venTipoMov == "D") && (exchVMC.venTipoMov == "I" || exchVMC.venTipoMov == "B" || exchVMC.venTipoMov == "E"))
                return "S";

            return "N";

        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesCliente(VentasCommon.venMovimientosSinStockDS pCommonDS, VentasCommon.venMovimientosSinStockDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            VentasExchange.venClientesActionExchange exchClie = new VentasExchange.venClientesActionExchange
                 (VentasExchange.venClientesActionEnum.EnumvenClientesAction.Datos);
            exchClie.Cliente_Id = pCommonDS.Principal[0].Cliente_Id;
            exchClie = new VentasExchange.venClientesActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Framework.Core.Exchange(exchClie), cmd));

            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            if (exchClie.Existe)
            {
                VentasExchange.venCondFiscalActionExchange exchVCF = new VentasExchange.venCondFiscalActionExchange
                    (VentasExchange.venCondFiscalActionEnum.EnumvenCondFiscalAction.Datos);
                exchVCF.CondFisc_Id = exchClie.CondFisc_Id;
                exchVCF = new VentasExchange.venCondFiscalActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                    (new Framework.Core.Exchange(exchVCF), cmd));


                lRetorno.Add(venMovimientosSinStockVar.LetraCondFiscal.ToString(), exchVCF.Letra);
            }
            return lRetorno;
        }
    }
}


