using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genDiasFestivosActionExchange : Framework.Core.Exchange{

        public Int32 NoUsado {
            get {
                if(((GeneralesCommon.genDiasFestivosDS)mParam).Principal[0]["NoUsado"] != DBNull.Value  ){
                    return ((GeneralesCommon.genDiasFestivosDS)mParam).Principal[0].NoUsado;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genDiasFestivosDS)mParam).Principal[0].NoUsado = value;
               }
	          }
        public bool IsNoUsadoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genDiasFestivosDS)mParam).Principal[0].IsNoUsadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genDiasFestivosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genDiasFestivosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genDiasFestivosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genDiasFestivosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genDiasFestivosDS );
     }
     public genDiasFestivosActionExchange() : base( "genDiasFestivos" ) {
     }

     public genDiasFestivosActionExchange(genDiasFestivosActionEnum.EnumgenDiasFestivosAction pAccion) : base(genDiasFestivosActionEnum.GetAcciongenDiasFestivosAction(pAccion)) {
     }

     public genDiasFestivosActionExchange(genDiasFestivosActionEnum.EnumgenDiasFestivosAction pAccion, GeneralesCommon.genDiasFestivosDS pdsParam) : base(genDiasFestivosActionEnum.GetAcciongenDiasFestivosAction(pAccion), pdsParam) {
     }

     public genDiasFestivosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genDiasFestivosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genDiasFestivosDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genDiasFestivosDS)mParam;
	        }
     }
  }
}
