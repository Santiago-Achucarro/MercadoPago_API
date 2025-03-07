using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaceDAAB;

namespace ComprasDAL
{
public    class comBorrarProveedorDesdeHasta
    {
		public static void Eliminar(string /*0*/pProveed_IdDesde, string /*1*/pProveed_IdHasta, DateTime /*2*/pFechaHasta, int /*3*/pSecuencia, int /*4*/pEmpresa_Id, string /*5*/pMoneda, string /*6*/ pAuxiliar)
		{
			Object[] parametros = new Object[] {/*0*/pProveed_IdDesde, /*1*/pProveed_IdHasta, /*2*/pFechaHasta, new Generalidades.NullableInt(/*3*/pSecuencia), /*4*/pEmpresa_Id, /*5*/pMoneda };

			Generalidades.Auxiliares.ReemplazarParametrosNulables(ref parametros);

			interfaceDAAB.iDAAB oiDAAB = Global.Global.globalDAAB(pAuxiliar);

			oiDAAB.eliminar("comBorrarProveedorDesdeHasta", parametros);
		}



	}
}
