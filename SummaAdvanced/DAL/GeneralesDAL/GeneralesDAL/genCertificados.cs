using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using interfaceDAAB;
using GeneralesCommon;

namespace GeneralesDAL
{
    public class genCertificados
    {
		public static genCertificadosDS Datos(int /*0*/Empresa_Id, string /*1*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/Empresa_Id };

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			System.Data.DataSet ds = oiDAAB.getObject("genCertificadosDatos", parametros);

			string[] camposTabla0 = { "NoCertificado", "GENWSAAPRIVATEKEY", "GENWSAAPUBLICKEY", "VENPAC", "VENCLAVEPAC", "VENUSUARIOPAC", "VENCLAVEPACCANC", "VENUSUARIOPACANC", "EMPDIRPDFFACT", "VENLLAMAPAC", "CLAVEPRIVATEKEY", "VENCLAPFXCANC", "VENCANCCONTRA", "GENVERSIONCFDI" };
			Generalidades.Auxiliares.ReemplazarNulos(ds.Tables[0], camposTabla0);

			genCertificadosDS dsTipado = new genCertificadosDS();
			string[] nombreTablas = { dsTipado.Principal.TableName };
			Generalidades.Auxiliares.renombrar(ds, dsTipado.DataSetName, nombreTablas);
			dsTipado.Merge(ds);
			return (dsTipado);
		}







	}
}
