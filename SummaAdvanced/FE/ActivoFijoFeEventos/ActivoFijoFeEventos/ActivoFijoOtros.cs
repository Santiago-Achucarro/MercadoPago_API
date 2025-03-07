using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;

namespace ActivoFijoFeEventos
{
    public class ActivoFijoOtros
    {
        [Generalidades.QFuncion_AccionGrilla]
        public ActivoFijoCommon.afiActivoFijoOtrosDS Seleccionar(ActivoFijoCommon.afiActivoFijoOtrosDS exch,
         ActivoFijoCommon.afiActivoFijoOtrosDS exchNoPost, int pIndice, Command cmd)
        {
            exchNoPost.Principal[0].Descripcion = exchNoPost.Pendientes[pIndice].DescripcionMovCont;
            exchNoPost.Principal[0].FechaAlta = exchNoPost.Pendientes[pIndice].Fecha;
            exchNoPost.Principal[0].Cantidad = exchNoPost.Pendientes[pIndice].Cantidad;
            exchNoPost.Principal[0].ValorInicial = exchNoPost.Pendientes[pIndice].Importe;
            exchNoPost.Principal[0].ValorFiscal = exchNoPost.Pendientes[pIndice].Importe;
            ActivoFijoExchange.AfiRubrosActionExchange eRubro = new ActivoFijoExchange.AfiRubrosActionExchange(ActivoFijoExchange.AfiRubrosActionEnum.EnumAfiRubrosAction.DatosCuenta)
            {
                CtaValorOrigen = exchNoPost.Pendientes[pIndice].Cuenta_Id
            };
            eRubro = new ActivoFijoExchange.AfiRubrosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eRubro, cmd));
            exchNoPost.Principal[0].AmortAcumSI = 0;
            exchNoPost.Principal[0].AmortAcumulada = 0;
            exchNoPost.Principal[0].ValorInicialSI = 0;
            exchNoPost.Principal[0].AsientoOrigen = exchNoPost.Pendientes[pIndice].conAsientos;
            exchNoPost.Principal[0].RenglonOrigen = exchNoPost.Pendientes[pIndice].Renglon;
            exchNoPost.Principal[0].TieneMovimientos = false;
            exchNoPost.Principal[0].CtaValorOrigen_Id = exchNoPost.Pendientes[pIndice].Cuenta_Id;
            exchNoPost.Principal[0].DescripcionCuentasOrigen = exchNoPost.Pendientes[pIndice].DescripcionCuenta;
            if (eRubro.Existe)
            {

                exchNoPost.Principal[0].Rubro_Id = eRubro.Rubro_Id;
                exchNoPost.Principal[0].DescripcionRubros = eRubro.Descripcion;
                exchNoPost.Principal[0].CtaAmortAcum_Id = eRubro.CtaAmortAcum_Id;
                exchNoPost.Principal[0].DescripcionCtaAmortAcum_Id = eRubro.DescripcionCtaAmortAcum_Id;
                exchNoPost.Principal[0].CtaAmortizacion = eRubro.CtaAmortizacion_Id;
                exchNoPost.Principal[0].DescripcionCtaAmortizacion = eRubro.DescripcionCtaAmortizacion_Id;
                exchNoPost.Principal[0].Tipo = eRubro.Tipo;
                exchNoPost.Principal[0].VidaUtil = eRubro.VidaUtil;
                exchNoPost.Principal[0].VidaUtilRestante = eRubro.VidaUtil;
                
            }
            exchNoPost.Principal[0].ActivoFijo_Id = "";
            exchNoPost.Principal[0].ActivoFijo_Id_Nueva = "";
            if (exchNoPost.Centros.Count == 0)
                exchNoPost.Centros.AddCentrosRow(0, exchNoPost.Pendientes[0].Centro1_Id, exchNoPost.Pendientes[0].DescripcionCentro1, exchNoPost.Pendientes[0].Centro2_Id, exchNoPost.Pendientes[0].DescripcionCentro2, 100);


            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public ActivoFijoCommon.afiActivoFijoOtrosDS DesactivarFE(ActivoFijoCommon.afiActivoFijoOtrosDS exch,
         ActivoFijoCommon.afiActivoFijoOtrosDS exchNoPost, int pIndice, Command cmd)
        {
            var ren=exch.Pendientes[pIndice];
            ActivoFijoExchange.afiActivoFijoOtrosActionExchange eAfi = new ActivoFijoExchange.afiActivoFijoOtrosActionExchange(ActivoFijoExchange.afiActivoFijoOtrosActionEnum.EnumafiActivoFijoOtrosAction.Desactivar)
            {
                Existe = false
            };
            eAfi.Param.Pendientes.AddPendientesRow(ren.conAsientos, ren.Renglon, ren.DescripcionMovCont, 
                ren.Comprobante, ren.Fecha, ren.Empresa_Id, ren.Cuenta_Id, ren.DescripcionCuenta,ren.Cantidad, ren.Importe,ren.Centro1_Id,ren.DescripcionCentro1,ren.Centro2_Id,ren.DescripcionCentro2, ren.Porcentaje);

            Generalidades.QBIInternal.WrapperExecuteActionInternal(eAfi,cmd);


         
            return exchNoPost;
        }
        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarResponsable(ActivoFijoCommon.afiActivoFijoOtrosDS pCommonDS, ActivoFijoCommon.afiActivoFijoOtrosDS pCommonDSNoPost, int pIndice, Command cmd)
        {
            string lRetorno = "";

            ActivoFijoValidacion.AfiActivoFijo.ExisteResponsable(pCommonDSNoPost.Responsables[0].Responsable_Id, cmd);
            if (pCommonDSNoPost.Responsables[0].Responsable_Id == "")
            {
                lRetorno = "El Responsable No Existe";
            }


            ///.................
            return lRetorno;
        }
    }
}