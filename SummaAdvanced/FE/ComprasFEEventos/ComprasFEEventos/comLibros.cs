using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Core;
using ComprasValidacion;
using ImpuestosValidacion;

namespace ComprasFEEventos
{
 public   class comLibros
    {
        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaImp(ComprasCommon.comLIbrosDS exch, ComprasCommon.comLIbrosDS exchNoPost,
            int pIndice, Command cmd)
        {

            // imp exsite, columna 0,tipo renglon existe


            if (exchNoPost.Impuestos[0].Columna == 0)
                return "La_Columna_No_Puede_Ser_0";

            ComprasValidacion.comImpuestos.Existe(exchNoPost.Impuestos[0].Impuesto_Id, cmd);
            ImpuestosValidacion.impTipoRenglon.Existe(exchNoPost.Impuestos[0].TipoRenglon, cmd);
            
            return "";
        }

        [Generalidades.QFuncion_CondicionGrilla]
        public string ValidarFilaCol(ComprasCommon.comLIbrosDS exch, ComprasCommon.comLIbrosDS exchNoPost,
           int pIndice, Command cmd)

        //columna 0 ,  titulo lleno
        {

            if (exchNoPost.Columnas[0].Columna == 0)
                return "La_Columna_No_Puede_Ser_0";

            if (exchNoPost.Columnas[0].Titulo == "")
                return "La_Columna_Debe_Tener_Un_Titulo";




            return "";
        }
    }
}
