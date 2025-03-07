using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;
using KSKCommon;
using System.Data;

namespace KSKDAL
{
    public class espConfPtoVtaKSK
    {
		public static espConfPtoVtaKSKDS Datos(int /*0*/pEmpresa_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			DataSet ds = oiDAAB.getObject("espConfPtoVtaKSKDatos", parametros);

			string[] camposTabla0 = { "SubTipoMov_Id", "DescripcionSubTipoMov", "Efectivo", "DescripcionEfectivo", "Cheques", "DescripcionCheques", "TDebito", "DescripcionTDebito", "TCredito", "DescripcionTCredito", "Transferencia", "DescripcionTransferencia" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			espConfPtoVtaKSKDS dsTipado = new espConfPtoVtaKSKDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}

		public static void Eliminar(int /*0*/pEmpresa_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id };

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("espConfPtoVtaKSKEliminar", parametros);
		}

		public static void Guardar(int /*0*/pEmpresa_Id, string /*1*/pSubTipoMov_Id, string /*2*/pEfectivo, string /*3*/pCheques, string /*4*/pTDebito, string /*5*/pTCredito, string /*6*/pTransferencia, string /*7*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pEmpresa_Id, new Generalidades.NullableString(/*1*/pSubTipoMov_Id), new Generalidades.NullableString(/*2*/pEfectivo), new Generalidades.NullableString(/*3*/pCheques), new Generalidades.NullableString(/*4*/pTDebito), new Generalidades.NullableString(/*5*/pTCredito), new Generalidades.NullableString(/*6*/pTransferencia) };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.guardar("espConfPtoVtaKSKGuardar", parametros);
		}



	}
}
