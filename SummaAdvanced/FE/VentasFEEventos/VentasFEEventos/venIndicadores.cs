using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCommon;
using VentasExchange;
using Framework.Core;
namespace VentasFEEventos
{
    public class venIndicadores
    {

        [Generalidades.QFuncion_AccionObtenerDatosIndicador]
        public Generalidades.IndicadorDatosDS IndicadorMes(VentasCommon.venIndicadoresDS pCommonDS, Command cmd)
        {
            Generalidades.IndicadorDatosDS lRetorno = new Generalidades.IndicadorDatosDS();

            decimal lPos;
            if (pCommonDS.IndicadorPeriodo[0].Meta == 0)
                lPos = 100;
            else
                lPos = pCommonDS.IndicadorPeriodo[0].Venta / pCommonDS.IndicadorPeriodo[0].Meta * 100;

            lRetorno.Indicador.AddIndicadorRow(lPos, "%");
            lRetorno.Rangos.AddRangosRow(0, 30, "#F01B0F");
            lRetorno.Rangos.AddRangosRow(30, 70, "#FFFF00");
            lRetorno.Rangos.AddRangosRow(70, 100, "#00B000");
            if (lPos > 100)
            {
                int lMeta3 = (int)(lPos/10)*10 + 10;
                lRetorno.Rangos.AddRangosRow(100, lMeta3, "#20E9C6");
            }
            return lRetorno;
        }

        [Generalidades.QFuncion_AccionObtenerDatosIndicador]
        public Generalidades.IndicadorDatosDS IndicadorAnio(VentasCommon.venIndicadoresDS pCommonDS, Command cmd)
        {
            Generalidades.IndicadorDatosDS lRetorno = new Generalidades.IndicadorDatosDS();
            decimal lPos;
            if (pCommonDS.IndicadorAnual[0].Meta == 0)
                lPos = 100;
            else
                lPos =  pCommonDS.IndicadorAnual[0].Venta / pCommonDS.IndicadorAnual[0].Meta * 100;

            lRetorno.Indicador.AddIndicadorRow(lPos, "%");
            lRetorno.Rangos.AddRangosRow(0, 30, "#F01B0F");
            lRetorno.Rangos.AddRangosRow(30, 70, "#FFFF00");
            lRetorno.Rangos.AddRangosRow(70, 100, "#00B000");
            if (lPos > 100)
            {
                int lMeta3 = (int)(lPos / 10) * 10 + 10;
                lRetorno.Rangos.AddRangosRow(100, lMeta3, "#20E9C6");
            }

            lRetorno.AcceptChanges();
            return lRetorno;
        }

        [Generalidades.QFuncion_AccionSobreGrafico]
        public VentasCommon.venIndicadoresDS ClickVentas(VentasCommon.venIndicadoresDS pCommonDS, VentasCommon.venIndicadoresDS pCommonDSParteGrafSelec, Command cmd)
        {
            ///pCommonDSParteGrafSelec contiene una única fila en la tabla asociado al gráfico.................
            ///Esa fila corresponde al elemento del gráfico sobre el cual se ha hecho click.................
            ///En este tipo de acción se debe retornar el pCommonDS, con los cambios que se le hayan hecho.................
            if (String.IsNullOrWhiteSpace(pCommonDSParteGrafSelec.Torta[0].Clave))
                Generalidades.qFunctionalException.GenerarExcepcion("No_Se_Puede_Detallar_El_Grupo_Otros");

            pCommonDS.SubTorta.Clear();

            VentasExchange.venIndicadoresActionExchange eVI = new venIndicadoresActionExchange(venIndicadoresActionEnum.EnumvenIndicadoresAction.Datos)
            {
                ProductoDesde = "",
                ProductoHasta = "ZZZZZZZZZZZZZZZZZZZZZZZZZ",
                VendedorDesde = " ",
                VendedorHasta = "ZZZZZ",
                FamiliaDesde = " ",
                FamiliaHasta = "ZZZZZZZZZZZZZZZ",
                GrupoDesde = " ",
                GrupoHasta = "ZZZZZZZZZZZZZZZ",
                ClienteDesde = " ",
                ClienteHasta = "ZZZZZZZZZZZZZZZ",
                SucursalDesde = pCommonDS.Principal[0].SucursalDesde,
                SucursalHasta = pCommonDS.Principal[0].SucursalHasta,
                FechaDesde = pCommonDS.Principal[0].FechaDesde,
                FechaHasta = pCommonDS.Principal[0].FechaHasta
            };
            pCommonDS.Principal[0].Titulo = pCommonDSParteGrafSelec.Torta[0].Clave + "-" +
                    pCommonDSParteGrafSelec.Torta[0].DescripDeta;
            switch (pCommonDS.Principal[0].Tipo)
            {
                case "C":
                    eVI.ClienteDesde =
                            pCommonDSParteGrafSelec.Torta[0].Clave;
                    eVI.ClienteHasta =
                            pCommonDSParteGrafSelec.Torta[0].Clave;
                    eVI.Tipo = "F";
                    break;
                case "V":
                    eVI.VendedorDesde =
                            pCommonDSParteGrafSelec.Torta[0].Clave;
                    eVI.VendedorHasta =
                            pCommonDSParteGrafSelec.Torta[0].Clave;
                    eVI.Tipo = "C";
                    break;
                case "F":
                    eVI.FamiliaDesde =
                            pCommonDSParteGrafSelec.Torta[0].Clave;
                    eVI.FamiliaHasta =
                            pCommonDSParteGrafSelec.Torta[0].Clave;
                    eVI.Tipo = "G";
                    break;
                case "G":
                    eVI.GrupoDesde =
                            pCommonDSParteGrafSelec.Torta[0].Clave;
                    eVI.GrupoHasta =
                            pCommonDSParteGrafSelec.Torta[0].Clave;
                    eVI.Tipo = "P";
                    break;
                case "P":
                    eVI.ProductoDesde =
                            pCommonDSParteGrafSelec.Torta[0].Clave;
                    eVI.ProductoHasta =
                            pCommonDSParteGrafSelec.Torta[0].Clave;
                    eVI.Tipo = "C";
                    break;

            }
                
            eVI = new venIndicadoresActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eVI, cmd));
            foreach (var ren in eVI.Param.Torta)
                pCommonDS.SubTorta.AddSubTortaRow(ren.Descripcion, ren.Monto);
            pCommonDS.Principal[0].VentaTotal = eVI.VentaTotal;
            pCommonDS.Principal[0].VentaPerioAnt = eVI.VentaPerioAnt;
            pCommonDS.Principal[0].VentaAnioAnt = eVI.VentaAnioAnt;
            pCommonDS.IndicadorAnual.Clear();
            pCommonDS.IndicadorPeriodo.Clear();
            pCommonDS.IndicadorAnual.Merge(eVI.Param.IndicadorAnual, false);
            pCommonDS.IndicadorPeriodo.Merge(eVI.Param.IndicadorPeriodo, false);
            pCommonDS.AcceptChanges();
            return pCommonDS;
        }

    }
}
