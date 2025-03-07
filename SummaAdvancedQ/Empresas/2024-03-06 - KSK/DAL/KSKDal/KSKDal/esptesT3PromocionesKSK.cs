using KSKCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSKDAL
{
    public class esptesT3PromocionesKSK
    {
        public static esptesT3PromocionesKSKDS Datos(int /*0*/ptesT3Promociones, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesT3Promociones };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            System.Data.DataSet ds = oiDAAB.getObject("esptesT3PromocionesKSKDatos", parametros);

            esptesT3PromocionesKSKDS dsTipado = new esptesT3PromocionesKSKDS();
            string[] nombreTablas = { dsTipado.Principal.TableName };
            Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
            dsTipado.Merge(ds);
            return (dsTipado);
        }


        public static void Eliminar(int /*0*/pPromocion_Id, string /*1*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/pPromocion_Id };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.eliminar("esptesT3PromocionesKSKEliminar", parametros);
        }


        public static void Guardar(int /*0*/ptesT3Promociones, decimal /*1*/pPorcentajeEntidad, decimal /*2*/pPorcentajeBanco, string /*3*/ pAuxiliar)
        {
            Object[] parametros = new Object[] {/*0*/ptesT3Promociones, /*1*/pPorcentajeEntidad, /*2*/pPorcentajeBanco };

            interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

            oiDAAB.guardar("esptesT3PromocionesKSKGuardar", parametros);
        }





    }
}
