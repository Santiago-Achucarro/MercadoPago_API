using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralesFEEventos
{
    public class genEmpresas
    {

        [Generalidades.QFuncion_Condicion]
        public string MuestraRegimen(GeneralesCommon.genEmpresasDS Exch, Command cmd)
        {
            return (Exch.Principal[0].Dominio_Id == "MX").ToString();

        }

        [Generalidades.QFuncion_Condicion]
        public string MuestraIB(GeneralesCommon.genEmpresasDS Exch, Command cmd)
        {
            if(Exch.Principal[0].IsDominio_IdNull())
                return (cmd.Dominio_Id == "AR").ToString();
            return (Exch.Principal[0].Dominio_Id == "AR").ToString();
            

        }
    }
}
