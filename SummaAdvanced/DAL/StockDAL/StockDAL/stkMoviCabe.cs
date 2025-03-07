using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using StockCommon;

namespace StockDAL
{
    public class stkMoviCabe
    {

        public static stkMoviCabeDS DatosSeg(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N,
            int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, 
            string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N,
                /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkMoviCabeDatosSeg", parametros);

            string[] camposTabla0 = { "DistribuyeContrapartida", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Deposito_Id", "DescripcionDepositos", "Producto_Id", "DescripcionProductos", "Medida_Id",
                "DescripcionUniMed", "MedidaAlterna", "DescripcionMedidaAlterna", "Observaciones", "Centro1Debe",
                "DescripcionCentro1Debe", "Centro2Debe", "DescripcionCentro2Debe", "Centro1Haber", "DescripcionCentro1Haber",
                "Centro2Haber", "DescripcionCentro2Haber", "Despacho_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Cantidad", "Vencimiento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            stkMoviCabeDS dsTipado = new stkMoviCabeDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName,
                dsTipado.genAtributosGenerales.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.grdMoviDespa.TableName,
                dsTipado.Ubicaciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static void Eliminar(long /*0*/pstkMoviCabe, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("stkMoviCabeEliminar", parametros);
        }

        public static void Guardar(long /*0*/pstkMoviCabe, string /*1*/pSubTipoMov_Id, bool /*2*/pModificaCosto,
            short /*3*/pSigno, string /*4*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe, /*1*/pSubTipoMov_Id, /*2*/pModificaCosto, /*3*/pSigno };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("stkMoviCabeGuardar", parametros);
        }

        public static stkMoviCabeDS Datos(long /*0*/pstkMoviCabe, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pstkMoviCabe };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkMoviCabeDatos", parametros);

            string[] camposTabla0 = { "DistribuyeContrapartida", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Deposito_Id", "DescripcionDepositos", "Producto_Id", "DescripcionProductos", "Medida_Id",
                "DescripcionUniMed", "MedidaAlterna", "DescripcionMedidaAlterna", "Observaciones", "Centro1Debe",
                "DescripcionCentro1Debe", "Centro2Debe", "DescripcionCentro2Debe", "Centro1Haber", "DescripcionCentro1Haber",
                "Centro2Haber", "DescripcionCentro2Haber", "Despacho_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Cantidad", "Vencimiento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            stkMoviCabeDS dsTipado = new stkMoviCabeDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName,
                dsTipado.genAtributosGenerales.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.grdMoviDespa.TableName,
                dsTipado.Ubicaciones.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static stkMoviCabeDatosSalidasRemitoDS DatosSalidasRemitos(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("stkMoviCabeDatosSalidasRemito", parametros);

            string[] camposTabla0 = { "DistribuyeContrapartida", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Deposito_Id", "DescripcionDepositos", "Producto_Id", "DescripcionProductos", "Medida_Id", "DescripcionUniMed", "MedidaAlterna", "DescripcionMedidaAlterna", "Observaciones", "Centro1Debe", "DescripcionCentro1Debe", "Centro2Debe", "DescripcionCentro2Debe", "Centro1Haber", "DescripcionCentro1Haber", "Centro2Haber", "DescripcionCentro2Haber", "Despacho_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Cantidad", "Vencimiento", "Existencia", "Marcado" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla5 = { "Cantidad", "CantidadAlterna", "Existencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "Sucursal", "ListaPrecio_Id", "DescripcionListasPrecios", "Moneda_Id", "DescripcionMoneda", "HojaRuta_Id", "HojaRuta", "FormaEntrega_Id", "DescripcionFormaEntrega", "Camion_Id", "Remolque1", "Remolque2", "FechaHoraSalida", "FechaHoraProgLlegada", "Operador_Id", "NombreOperador", "TotalDistRec" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            string[] camposTabla7 = { "SoloRemito", "PendienteFacturacion", "DescripcionCausa", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[7], camposTabla7);

            string[] camposTabla8 = { "AceptaDatosExternos" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[8], camposTabla8);

            stkMoviCabeDatosSalidasRemitoDS dsTipado = new stkMoviCabeDatosSalidasRemitoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdMoviCuerpo.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.grdMoviDespa.TableName, dsTipado.Ubicaciones.TableName, dsTipado.stkRemitos.TableName, dsTipado.stkMoviCausa.TableName, dsTipado.AceptaDatosExternos.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static stkMoviCabeDatosCausaDS DatosCausa(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("stkMoviCabeDatosCausa", parametros);

            string[] camposTabla0 = { "DistribuyeContrapartida", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Deposito_Id", "DescripcionDepositos", "Producto_Id", "DescripcionProductos", "Medida_Id", "DescripcionUniMed", "MedidaAlterna", "DescripcionMedidaAlterna", "Observaciones", "Centro1Debe", "DescripcionCentro1Debe", "Centro2Debe", "DescripcionCentro2Debe", "Centro1Haber", "DescripcionCentro1Haber", "Centro2Haber", "DescripcionCentro2Haber", "Despacho_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Cantidad", "Vencimiento", "Existencia" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla5 = { "Existencia", "Cantidad", "CantidadAlterna" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "Descripcion", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            stkMoviCabeDatosCausaDS dsTipado = new stkMoviCabeDatosCausaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.grdMoviDespa.TableName, dsTipado.Ubicaciones.TableName, dsTipado.Causa.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static stkMoviCabeRevaDS RevaDatos(int /*0*/pEmpresa_id, string /*1*/pSegmento_id, int /*2*/pSegmento1N, 
            int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C,
            string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_id, /*1*/pSegmento_id, /*2*/pSegmento1N, /*3*/pSegmento2N,
                /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkMoviCabeRevaDatos", parametros);

            string[] camposTabla0 = { "DistribuyeContrapartida", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Cantidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla5 = { "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            stkMoviCabeRevaDS dsTipado = new stkMoviCabeRevaDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName,
                dsTipado.genAtributosGenerales.TableName, dsTipado.AsientoAdicional.TableName, dsTipado.CuentasAjuste.TableName,
                dsTipado.Centros.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static stkMoviCabeDatosProvDS DatosProv(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, 
            int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, 
            string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, 
                /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            DataSet ds = oiDAAB.getObject("stkMoviCabeDatosProv", parametros);

            string[] camposTabla0 = { "DistribuyeContrapartida", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Deposito_Id", "DescripcionDepositos", "Producto_Id", "DescripcionProductos", "Medida_Id",
                "DescripcionUniMed", "MedidaAlterna", "DescripcionMedidaAlterna", "Observaciones", "Centro1Debe",
                "DescripcionCentro1Debe", "Centro2Debe", "DescripcionCentro2Debe", "Centro1Haber", "DescripcionCentro1Haber",
                "Centro2Haber", "DescripcionCentro2Haber", "Despacho_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Cantidad", "Vencimiento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla5 = { "Cantidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            stkMoviCabeDatosProvDS dsTipado = new stkMoviCabeDatosProvDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName,
                dsTipado.genAtributosGenerales.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.grdModiDespa.TableName,
                dsTipado.Ubicaciones.TableName, dsTipado.Remision.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }

        public static stkMoviCabeDatosEmpleadoDS DatosEmpleado(int /*0*/pEmpresa_Id, string /*1*/pSegmento_Id, int /*2*/pSegmento1N, int /*3*/pSegmento2N, int /*4*/pSegmento3N, int /*5*/pSegmento4N, string /*6*/pSegmento1C, string /*7*/pSegmento2C, string /*8*/pSegmento3C, string /*9*/pSegmento4C, string /*10*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pEmpresa_Id, /*1*/pSegmento_Id, /*2*/pSegmento1N, /*3*/pSegmento2N, /*4*/pSegmento3N, /*5*/pSegmento4N, /*6*/pSegmento1C, /*7*/pSegmento2C, /*8*/pSegmento3C, /*9*/pSegmento4C };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("stkMoviCabeDatosEmpleado", parametros);

            string[] camposTabla0 = { "DistribuyeContrapartida", "Observaciones" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

            string[] camposTabla1 = { "Deposito_Id", "DescripcionDepositos", "Producto_Id", "DescripcionProductos", "Medida_Id", "DescripcionUniMed", "MedidaAlterna", "DescripcionMedidaAlterna", "Observaciones", "Centro1Debe", "DescripcionCentro1Debe", "Centro2Debe", "DescripcionCentro2Debe", "Centro1Haber", "DescripcionCentro1Haber", "Centro2Haber", "DescripcionCentro2Haber", "Despacho_Id" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[1], camposTabla1);

            string[] camposTabla2 = { "ValorN", "ValorC", "ValorF" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[2], camposTabla2);

            string[] camposTabla3 = { "Cantidad", "Vencimiento" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[3], camposTabla3);

            string[] camposTabla5 = { "Cantidad" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[5], camposTabla5);

            string[] camposTabla6 = { "Descripcion", "Centro1_Id", "DescripcionCentro1", "Centro2_Id", "DescripcionCentro2" };
            Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[6], camposTabla6);

            stkMoviCabeDatosEmpleadoDS dsTipado = new stkMoviCabeDatosEmpleadoDS();
            string[] nombreTablas = { dsTipado.Principal.TableName, dsTipado.grdCuerpo.TableName, dsTipado.genAtributosGenerales.TableName, dsTipado.grdMoviSerie.TableName, dsTipado.grdMoviDespa.TableName, dsTipado.Ubicaciones.TableName, dsTipado.Causa.TableName, dsTipado.Empleado.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


    }
}
