using StockCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StockFEEventos
{
    public class stkSalidasRemito
    {
        [Generalidades.QFuncion_Condicion]
        public string PendienteFacturacion(StockCommon.stkMoviCabeDatosSalidasRemitoDS exch, Framework.Core.Command cmd)
        {
            return (exch.stkMoviCausa[0].PendienteFacturacion ? "S" : "N");
        }

        [Generalidades.QFuncion_Condicion]
        public string UsaCartaPorte(StockCommon.stkMoviCabeDatosSalidasRemitoDS exch, Framework.Core.Command cmd)
        {
            if (String.IsNullOrWhiteSpace(exch.stkRemitos[0].FormaEntrega_Id))
                return "N";
            else
                return (VentasValidacion.venFormaEntrega.Existe(exch.stkRemitos[0].FormaEntrega_Id, cmd).UsaCartaPorte ? "S" : "N");

        }

        [Generalidades.QFuncion_Condicion]
        public string ManejaCantidadAlterna(StockCommon.stkMoviCabeDatosSalidasRemitoDS exch, Framework.Core.Command cmd)
        {
            return StockFEEventos.ComunesStock.ManejaCantidadAlterna(cmd);
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarRenglon(stkMoviCabeDatosSalidasRemitoDS exch, stkMoviCabeDatosSalidasRemitoDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {

            stkMoviCabeDatosSalidasRemitoDS.grdMoviCuerpoDataTable dt = exchNoPost.grdMoviCuerpo;
            if (dt[0].CantidadForm > 0)
            {
                if (dt[0].Producto_Id == "")
                    return "Debe_Ingresar_Un_codigo_de_producto";

                if (dt[0].Deposito_Id == "")
                    return "Debe_informar_el_deposito";
            }
            else
            {
                return "La_Cantidad_Debe_Ser_Mayor_que_Cero";
            }
            return "";
        }

        [Generalidades.QFuncion_Condicion]
        public string EnMonedaBase(stkMoviCabeDatosSalidasRemitoDS exch, Framework.Core.Command cmd)
        {
            if (exch.stkRemitos[0].Moneda_Id != cmd.MonedaBase)
                return "N";

            return "S";
        }

        [Generalidades.QFuncion_AccionObtenerVariables]
        public Dictionary<string, string> VariablesProductos(stkMoviCabeDatosSalidasRemitoDS exch,
           stkMoviCabeDatosSalidasRemitoDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            return ComunesStock.VariablesProductos(exchNoPost.grdMoviCuerpo[0].Producto_Id,
                   exchNoPost.grdMoviCuerpo[0].Deposito_Id, cmd);


        }

        public enum stkSalidasRemitoVar
        {
            ManejaSerieoLote, ManejaSerie, ManejaLote, ManejaVencimiento, ManejaUMAlterna, Clase, ManejoDeposito, ManejoCantEntregada, LetraCondFiscal, UsaDespacho, ManejaUbicacion, CantidadSoloLectura
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDatosSalidasRemitoDS SumarCant(stkMoviCabeDatosSalidasRemitoDS exch,
            stkMoviCabeDatosSalidasRemitoDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {

            exchNoPost.grdMoviCuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValirSerieLote(stkMoviCabeDatosSalidasRemitoDS exch, stkMoviCabeDatosSalidasRemitoDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            StockExchange.stkExistenciaSerieActionExchange exchSerie = new StockExchange.stkExistenciaSerieActionExchange
                            (StockExchange.stkExistenciaSerieActionEnum.EnumstkExistenciaSerieAction.Datos);
            exchSerie.Producto_Id = exchNoPost.grdMoviCuerpo[0].Producto_Id;
            exchSerie.Serie = exchNoPost.grdMoviSerie[0].Serie;
            exchSerie.Deposito_Id = exchNoPost.grdMoviCuerpo[0].Deposito_Id;

            exchSerie = new StockExchange.stkExistenciaSerieActionExchange
                (Generalidades.QBIInternal.WrapperExecuteActionInternal(new Framework.Core.Exchange(exchSerie), cmd));

            if (!exchSerie.Existe)
                return "Serie_Lote_<0>_en_deposito_<1>_no_existe";
            return "";

        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDatosSalidasRemitoDS LlenarFactor(stkMoviCabeDatosSalidasRemitoDS exch, stkMoviCabeDatosSalidasRemitoDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {


            StockExchange.stkArtiUMActionExchange exchArtiUM = StockValidacion.stkArtiUM.PerteneceUMProd
                (exchNoPost.grdMoviCuerpo[0].Producto_Id, exchNoPost.grdMoviCuerpo[0].Medida_Id, cmd);

            exchNoPost.grdMoviCuerpo[0].Factor = exchArtiUM.Factor;
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }
        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDatosSalidasRemitoDS LlenarUM(stkMoviCabeDatosSalidasRemitoDS exch, stkMoviCabeDatosSalidasRemitoDS exchNoPost,
            int pIndice, Framework.Core.Command cmd)
        {
            StockExchange.stkProductosActionExchange exchProd = StockValidacion.stkProductos.ExistePosteadoyActivo
                (exchNoPost.grdMoviCuerpo[0].Producto_Id, cmd);

            exchNoPost.grdMoviCuerpo[0].Medida_Id = exchProd.Medida_Id;
            exchNoPost.grdMoviCuerpo[0].Factor = 1;
            exchNoPost.grdMoviCuerpo[0].MedidaAlterna = exchProd.MedidaAlterna;
            exchNoPost.AcceptChanges();

            return exchNoPost;

        }

        [Generalidades.QFuncion_Condicion]
        public string Anulado(stkMoviCabeDatosSalidasRemitoDS exch, Framework.Core.Command cmd)
        {
            if (exch.Principal[0].Anulado)
                return "S";
            return "N";
        }

        [Generalidades.QFuncion_AccionGrilla]
        public static stkMoviCabeDatosSalidasRemitoDS AsignarCantidad(stkMoviCabeDatosSalidasRemitoDS exch, stkMoviCabeDatosSalidasRemitoDS exchNoPost, int pIndice,
     Framework.Core.Command cmd)
        {
            if (exchNoPost.grdMoviCuerpo[0].CantidadForm == 0)
                return exchNoPost;

            exchNoPost.Ubicaciones[0].Cantidad = 0;
            StockExchange.stkExistenciaUbiActionExchange eExistU = new StockExchange.stkExistenciaUbiActionExchange(StockExchange.stkExistenciaUbiActionEnum.EnumstkExistenciaUbiAction.Datos)
            {
                Deposito_Id = exchNoPost.grdMoviCuerpo[0].Deposito_Id,
                Producto_Id = exchNoPost.grdMoviCuerpo[0].Producto_Id,
                Ubicacion_Id = exchNoPost.Ubicaciones[0].Ubicacion_Id
            };
            eExistU = new StockExchange.stkExistenciaUbiActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(eExistU, cmd));
            if (eExistU.Existe && eExistU.Cantidad > 0)
            {
                decimal lCant = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
                exchNoPost.Ubicaciones[0].Cantidad = Math.Min(exchNoPost.grdMoviCuerpo[0].CantidadForm - lCant, eExistU.Cantidad);
            }

            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        public static stkMoviCabeDatosSalidasRemitoDS SumarCantU(stkMoviCabeDatosSalidasRemitoDS exch, stkMoviCabeDatosSalidasRemitoDS exchNoPost, int pIndice,
     Framework.Core.Command cmd)
        {
            exchNoPost.grdMoviCuerpo[0].CantidadForm = exchNoPost.Ubicaciones.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }


        [Generalidades.QFuncion_EnviarMail]
        public Generalidades.CorreoDS Enviar(StockCommon.stkMoviCabeDatosSalidasRemitoDS pCommonDS, Framework.Core.Command cmd)
        {

            Generalidades.CorreoDS lRetorno = new Generalidades.CorreoDS();
            var eEmpre = GeneralesValidacion.genEmpresas.Existe(cmd.Empresa_Id, cmd);
            var eClie = VentasValidacion.venClientes.Existe(pCommonDS.stkRemitos[0].Cliente_Id, cmd);
            var eClieS = VentasValidacion.venClieHabitual.Existe(eClie.Cliente_Id, pCommonDS.stkRemitos[0].Sucursal,  cmd);


            // Tengo que buscar los remitos de este reparto //
            StockExchange.stkMoviCabeImprimirActionExchange exchRemitos = new StockExchange.stkMoviCabeImprimirActionExchange(StockExchange.stkMoviCabeImprimirActionEnum.EnumstkMoviCabeImprimirAction.AsignarNombre)
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
            exchRemitos = new StockExchange.stkMoviCabeImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchRemitos, cmd));

            if (exchRemitos.Existe)
            {

                exchRemitos.Action = StockExchange.stkMoviCabeImprimirActionEnum.GetAccionstkMoviCabeImprimirAction(StockExchange.stkMoviCabeImprimirActionEnum.EnumstkMoviCabeImprimirAction.Guardar);
                exchRemitos = new StockExchange.stkMoviCabeImprimirActionExchange(Generalidades.QBIInternal.WrapperExecuteActionInternal(exchRemitos, cmd));

            

            }

            string lCuerpo = "<p>Sres. " + eClie.RazonSocial + "</p><p></p>";

            lCuerpo += "<p>Le Informamos que su Remision " + pCommonDS.Principal[0].Segmento1N.ToString() + pCommonDS.Principal[0].Segmento2C + " fue Generada, adjuntamos el comprobante.</p><p></p>";
            lCuerpo += "<p> Atte. Area de Logistica de " + eEmpre.RazonSocial + "</p>";
            string lDestinatarios = "";

            foreach (var ren in eClieS.Param.grdContactos.Where(c => c.EnviaFacturas && !String.IsNullOrWhiteSpace(c.Email)))
            {
                lDestinatarios += ren.Email + ";";
            }

            lRetorno.Principal.AddPrincipalRow("Remision Generada", lCuerpo,
                    lDestinatarios, "", eEmpre.MailClientesSinMail, false);
            string lArch = System.IO.Path.GetFileName(exchRemitos.NombreArchivo);

            lRetorno.Adjuntos.AddAdjuntosRow(1, Guid.NewGuid().ToString(), lArch, "pdf", exchRemitos.PDF, ((int)Generalidades.Archivos.QEstadoArchivo.Sin_Cambios).ToString());
            if (!String.IsNullOrWhiteSpace(exchRemitos.XML))
            {
                lArch = lArch.Split('.')[0]+".xml";
                    
                lRetorno.Adjuntos.AddAdjuntosRow(2, Guid.NewGuid().ToString(), lArch, "xml", exchRemitos.XML, ((int)Generalidades.Archivos.QEstadoArchivo.Sin_Cambios).ToString());
            }
            return lRetorno;

        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDatosSalidasRemitoDS PopularSerie(stkMoviCabeDatosSalidasRemitoDS pCommonDS, stkMoviCabeDatosSalidasRemitoDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // Se llaman distintos los dt y por eso los tengo que renombrar //
            // En el estándar se llaman grdCuerpo y acá en remitos grdMoviCuerpo //
            pCommonDS.grdMoviCuerpo.TableName = "grdCuerpo";
            pCommonDSNoPost.grdMoviCuerpo.TableName = "grdCuerpo";
            stkMoviCabeDatosSalidasRemitoDS ds = new stkMoviCabeDatosSalidasRemitoDS();
            ds.Merge(stkMoviSerieSalidasSolapa.PopularSerie(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Add);
            ds.Tables.Remove("grdMoviCuerpo");
            ds.Tables["grdCuerpo"].TableName = "grdMoviCuerpo";
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDatosSalidasRemitoDS PopularLote(stkMoviCabeDatosSalidasRemitoDS pCommonDS, stkMoviCabeDatosSalidasRemitoDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {
            // Se llaman distintos los dt y por eso los tengo que renombrar //
            // En el estándar se llaman grdCuerpo y acá en remitos grdMoviCuerpo //
            pCommonDS.grdMoviCuerpo.TableName = "grdCuerpo";
            pCommonDSNoPost.grdMoviCuerpo.TableName = "grdCuerpo";
            stkMoviCabeDatosSalidasRemitoDS ds = new stkMoviCabeDatosSalidasRemitoDS();
            ds.Merge(stkMoviSerieSalidasSolapa.PopularLote(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Add);
            ds.Tables.Remove("grdMoviCuerpo");
            ds.Tables["grdCuerpo"].TableName = "grdMoviCuerpo";
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDatosSalidasRemitoDS PopularUbi(stkMoviCabeDatosSalidasRemitoDS pCommonDS, stkMoviCabeDatosSalidasRemitoDS pCommonDSNoPost, int pIndice, Framework.Core.Command cmd)
        {

            // Se llaman distintos los dt y por eso los tengo que renombrar //
            // En el estándar se llaman grdCuerpo y acá en remitos grdMoviCuerpo //
            pCommonDS.grdMoviCuerpo.TableName = "grdCuerpo";
            pCommonDSNoPost.grdMoviCuerpo.TableName = "grdCuerpo";
            stkMoviCabeDatosSalidasRemitoDS ds = new stkMoviCabeDatosSalidasRemitoDS();
            ds.Merge(stkEntradasUbicacion.PopularUbi(pCommonDS, pCommonDSNoPost, pIndice, cmd), false, MissingSchemaAction.Add);
            ds.Tables.Remove("grdMoviCuerpo");
            ds.Tables["grdCuerpo"].TableName = "grdMoviCuerpo";
            return ds;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDatosSalidasRemitoDS SumarCantLote(stkMoviCabeDatosSalidasRemitoDS exch,
    stkMoviCabeDatosSalidasRemitoDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            exchNoPost.grdMoviCuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Cantidad);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }

        [Generalidades.QFuncion_AccionGrilla]
        public stkMoviCabeDatosSalidasRemitoDS SumarCantSerie(stkMoviCabeDatosSalidasRemitoDS exch,
stkMoviCabeDatosSalidasRemitoDS exchNoPost, int pIndice, Framework.Core.Command cmd)
        {
            exchNoPost.grdMoviCuerpo[0].CantidadForm = exchNoPost.grdMoviSerie.ToList().Sum(r => r.Marcado ? 1 : 0);
            exchNoPost.AcceptChanges();

            return exchNoPost;
        }
    }
}