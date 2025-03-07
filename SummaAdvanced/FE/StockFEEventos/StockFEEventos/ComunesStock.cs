using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockFEEventos
{
    public static class ComunesStock
    {
        public static string ManejaCantidadAlterna(Framework.Core.Command cmd)
        {
            GeneralesExchange.genEmpresasActionExchange ExchEmp =
               new GeneralesExchange.genEmpresasActionExchange(GeneralesExchange.genEmpresasActionEnum.EnumgenEmpresasAction.Datos);

            ExchEmp.Empresa_Id = "";
            ExchEmp.genEmpresas = cmd.Empresa_Id;
            ExchEmp = new GeneralesExchange.genEmpresasActionExchange(
                    Generalidades.QBIInternal.WrapperExecuteActionInternal(ExchEmp, cmd));

            if (ExchEmp.Existe)
            {
                if (ExchEmp.UsaCantidadAlterna)
                    return "S";
                else
                {

                    return "N";
                }
            }

            return "N";
        }

        public static Dictionary<string, string> VariablesProductos(String Producto_id, String pDeposito_Id, Framework.Core.Command cmd)
        {
            StockExchange.stkProductosActionExchange exchProd = new StockExchange.stkProductosActionExchange
                (StockExchange.stkProductosActionEnum.EnumstkProductosAction.Datos);
            exchProd.Producto_Id = Producto_id;
            exchProd = new StockExchange.stkProductosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal
                (new Framework.Core.Exchange(exchProd), cmd));

            Dictionary<string, string> lRetorno = new Dictionary<string, string>();

            if (exchProd.Serializable || exchProd.TrabajaPorLotes)
                lRetorno.Add(ProdcutosVar.ManejaSerieoLote.ToString(), "S");
            else
                lRetorno.Add(ProdcutosVar.ManejaSerieoLote.ToString(), "N");

            if (exchProd.Serializable)
                lRetorno.Add(ProdcutosVar.ManejaSerie.ToString(), "S");
            else
                lRetorno.Add(ProdcutosVar.ManejaSerie.ToString(), "N");

            if (exchProd.TrabajaPorLotes)
                lRetorno.Add(ProdcutosVar.ManejaLote.ToString(), "S");
            else
                lRetorno.Add(ProdcutosVar.ManejaLote.ToString(), "N");

            if (exchProd.conVencimiento)
                lRetorno.Add(ProdcutosVar.ManejaVencimiento.ToString(), "S");
            else
                lRetorno.Add(ProdcutosVar.ManejaVencimiento.ToString(), "N");

            if (exchProd.MedidaAlterna != "")
                lRetorno.Add(ProdcutosVar.ManejaUMAlterna.ToString(), "S");
            else
                lRetorno.Add(ProdcutosVar.ManejaUMAlterna.ToString(), "N");

            lRetorno.Add(ProdcutosVar.Clase.ToString(), exchProd.Clase);

            if (exchProd.Clase != "D")
                // Si no es Servicio muestro el depósito //
                lRetorno.Add(ProdcutosVar.ManejoDeposito.ToString(), "S");
            else
                // Si es Servicio se pide el depósito //
                lRetorno.Add(ProdcutosVar.ManejoDeposito.ToString(), "N");

            if (exchProd.UsaDespachoImportacion)
                lRetorno.Add(ProdcutosVar.UsaDespacho.ToString(), "S");
            else
                lRetorno.Add(ProdcutosVar.UsaDespacho.ToString(), "N");


            lRetorno.Add(ProdcutosVar.DepositoDefecto.ToString(), 
                    GeneralesValidacion.genSucursalesEmpr.Existe(GeneralesValidacion.genUsuarios.Existe(cmd.Usuario_Id, cmd).Sucursal, cmd).DepositoOC);

            StockExchange.stkDepositosActionExchange eDepo = new StockExchange.stkDepositosActionExchange(StockExchange.stkDepositosActionEnum.EnumstkDepositosAction.Datos)
            {
                Deposito_Id = pDeposito_Id
            };

            eDepo = new StockExchange.stkDepositosActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eDepo, cmd));
            if (eDepo.Existe && eDepo.UsaUbicacion)
                lRetorno.Add(ProdcutosVar.ManejaUbicacion.ToString(), "S");
            else
                lRetorno.Add(ProdcutosVar.ManejaUbicacion.ToString(), "N");


            if(exchProd.Serializable || exchProd.TrabajaPorLotes || eDepo.UsaUbicacion)
                lRetorno.Add(ProdcutosVar.CantidadSoloLectura.ToString(), "S");
            else
                lRetorno.Add(ProdcutosVar.CantidadSoloLectura.ToString(), "N");


            return lRetorno;
        }


        public enum ProdcutosVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, UsaDespacho, ManejaUbicacion, DepositoDefecto, CantidadSoloLectura
        }

        public static decimal toDecimal(string Cadena)
        {
            decimal lRet = 0;
            if (Cadena != "")

                try
                {
                    lRet = Convert.ToDecimal(Cadena);
                }
                catch
                {
                    lRet = 0;
                }
            return lRet;

        }

        public static DateTime toDate(string Cadena)
        {
            DateTime lRet = DateTime.Now.Date;
            if (Cadena != "")

                try
                {
                    string[] lVal = Cadena.Split('/');

                    lRet = new DateTime(Convert.ToInt32(lVal[2]), Convert.ToInt32(lVal[1]), Convert.ToInt32(lVal[0]));
                }
                catch
                {
                }
            return lRet;

        }
    }
}
