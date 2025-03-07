using System;
using System.Data;
using System.Globalization;
using System.Runtime.Serialization;
/// Generado por QBI lunes, 20 de mayo de 2019
/// <summary> 
/// Solo para Enumerar la Posibles Acciones/// </summary>
///
namespace ProduccionExchange{
        public static class proProgramaProduccionActionEnum
        {            public enum EnumproProgramaProduccionAction
            {
                Guardar,Datos,Eliminar,Calcular
            }
        public static string GetAccionproProgramaProduccionAction(proProgramaProduccionActionEnum.EnumproProgramaProduccionAction pEnumAccion)
        {
            string lRetorno = "";
            switch (pEnumAccion)
            {
                case proProgramaProduccionActionEnum.EnumproProgramaProduccionAction.Guardar: lRetorno = "proProgramaProduccionGuardar"; break;
                case proProgramaProduccionActionEnum.EnumproProgramaProduccionAction.Datos: lRetorno = "proProgramaProduccionDevolverDatos"; break;
                case proProgramaProduccionActionEnum.EnumproProgramaProduccionAction.Eliminar: lRetorno = "proProgramaProduccionEliminar"; break;
                case proProgramaProduccionActionEnum.EnumproProgramaProduccionAction.Calcular: lRetorno = "proProgramaProduccionCalcular"; break;
            }
            return lRetorno;
        }
        public static ProduccionExchange.proProgramaProduccionActionExchange LlenarCuerpo ( ProduccionExchange.proProgramaProduccionActionExchange req, ProduccionCommon.proProgramaProdCalcDS dsCuerpo, string Cultura)
        {
            DateTime lFechaDesde = req.FechaDesde;
            req.Param.Cuerpo.Columns.Add("Producto_Id", typeof(string));
            req.Param.Cuerpo.Columns.Add("Medida_Id", typeof(string));
            req.Param.Cuerpo.Columns.Add("Pedidos", typeof(decimal));
            req.Param.Cuerpo.Columns.Add("Stock", typeof(decimal));
            req.Param.Cuerpo.Columns.Add("MinNecesario", typeof(decimal));
            req.Param.Cuerpo.Columns.Add("Minimo", typeof(decimal));
            req.Param.Cuerpo.Columns.Add("OrdProducto", typeof(decimal));
            req.Param.Cuerpo.Columns.Add("Faltantes", typeof(decimal));
            req.Param.Cuerpo.Columns.Add("Maximo", typeof(decimal));
            req.Param.Cuerpo.Columns.Add("Ult90Dias", typeof(decimal));
            req.Param.Cuerpo.Columns.Add("ProdPeriodo", typeof(decimal));
            req.Param.Cuerpo.Columns.Add("Fila", typeof(int));
            req.Param.CuerpoSoloLect.Columns.Add("Producto_Id", typeof(bool));
            req.Param.CuerpoSoloLect.Columns.Add("Medida_Id", typeof(bool));
            req.Param.CuerpoSoloLect.Columns.Add("Pedidos", typeof(bool));
            req.Param.CuerpoSoloLect.Columns.Add("Stock", typeof(bool));
            req.Param.CuerpoSoloLect.Columns.Add("MinNecesario", typeof(bool));
            req.Param.CuerpoSoloLect.Columns.Add("Minimo", typeof(bool));
            req.Param.CuerpoSoloLect.Columns.Add("OrdProducto", typeof(bool));
            req.Param.CuerpoSoloLect.Columns.Add("Faltantes", typeof(bool));
            req.Param.CuerpoSoloLect.Columns.Add("Maximo", typeof(bool));
            req.Param.CuerpoSoloLect.Columns.Add("Ult90Dias", typeof(bool));
            req.Param.CuerpoSoloLect.Columns.Add("ProdPeriodo", typeof(bool));
            req.Param.CuerpoSoloLect.Columns.Add("Fila", typeof(bool));
            int i = 0;

            int nCol = req.Param.Cuerpo.Columns.Count;
            int nColp = nCol-1;


            foreach (var ren in dsCuerpo.Principal)
            {
                var row = req.Param.Cuerpo.AddCuerpoRow();
                row["Producto_Id"] = ren.Producto_Id;
                row["Medida_Id"] = ren.Medida_Id;
                row["Pedidos"] = ren.Pedidos;
                row["Stock"] = ren.Stock;
                row["Minimo"] = ren.Minimo;
                row["MinNecesario"] = Math.Max(ren.Pedidos - ren.Stock,0);
                row["Maximo"] = ren.Maximo;
                row["Ult90Dias"] = ren.Ult90Dias;
                row["Faltantes"] = -ren.Stock - ren.Faltantes + ren.Pedidos + ren.Minimo > 0 ? -ren.Stock - ren.Faltantes + ren.Pedidos + ren.Minimo : 0;
                row["ProdPeriodo"] = ren.ProdPeriodo;
                row["OrdProducto"] = ren.Faltantes;
                row["Fila"] = i++;

                var rowSoloLect = req.Param.CuerpoSoloLect.AddCuerpoSoloLectRow();
            }

            
            CultureInfo ci = new CultureInfo(Cultura);

            while (req.FechaHasta >= lFechaDesde)
            {
                if ((lFechaDesde.DayOfWeek == DayOfWeek.Monday && req.Lunes) || (lFechaDesde.DayOfWeek == DayOfWeek.Tuesday && req.Martes)
                    || (lFechaDesde.DayOfWeek == DayOfWeek.Wednesday && req.Miercoles) || (lFechaDesde.DayOfWeek == DayOfWeek.Thursday &&
                    req.Miercoles) || (lFechaDesde.DayOfWeek == DayOfWeek.Friday && req.Viernes) || (lFechaDesde.DayOfWeek ==
                    DayOfWeek.Saturday && req.Sabado) || (lFechaDesde.DayOfWeek == DayOfWeek.Sunday && req.Domingo))
                {
                    string lConName = lFechaDesde.DayOfWeek.ToString() + lFechaDesde.Day.ToString();
                    var Colu = req.Param.Cuerpo.Columns.Add(ci.DateTimeFormat.GetDayName(lFechaDesde.DayOfWeek).Substring(0,2) +"_"+ lFechaDesde.Day.ToString("00"), typeof(decimal));
                    req.Param.Relaciones.AddRelacionesRow(Colu.Ordinal, lFechaDesde);
                    req.Param.CuerpoSoloLect.Columns.Add(lConName, typeof(bool));
                    nCol++;
                }
                lFechaDesde = lFechaDesde.AddDays(1);
                
            }
            
            for(int nFila = 0; nFila< req.Param.Cuerpo.Count;nFila++)
            {
                for (int nc = nColp; nc < nCol; nc++)
                {
                    req.Param.CuerpoSoloLect[nFila][nc] = false;
                }
            }
            
            req.Param.AcceptChanges();
            return req;
        }
    }
}
