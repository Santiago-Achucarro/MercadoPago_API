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
    public class genReporteEjecutarActionExchange : Framework.Core.Exchange{

        public String StoreProcedure {
            get {
                if(((GeneralesCommon.genReporteEjecutarDS)mParam).Principal[0]["StoreProcedure"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReporteEjecutarDS)mParam).Principal[0].StoreProcedure;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReporteEjecutarDS)mParam).Principal[0].StoreProcedure = value;
               }
	          }
        public bool IsStoreProcedureNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReporteEjecutarDS)mParam).Principal[0].IsStoreProcedureNull();
             }
	        }
        public String Parametros {
            get {
                if(((GeneralesCommon.genReporteEjecutarDS)mParam).Principal[0]["Parametros"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReporteEjecutarDS)mParam).Principal[0].Parametros;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReporteEjecutarDS)mParam).Principal[0].Parametros = value;
               }
	          }
        public bool IsParametrosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReporteEjecutarDS)mParam).Principal[0].IsParametrosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genReporteEjecutarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genReporteEjecutarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genReporteEjecutarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genReporteEjecutarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genReporteEjecutarDS );
     }
     public genReporteEjecutarActionExchange() : base( "genReporteEjecutar" ) {
     }

     public genReporteEjecutarActionExchange(genReporteEjecutarActionEnum.EnumgenReporteEjecutarAction pAccion) : base(genReporteEjecutarActionEnum.GetAcciongenReporteEjecutarAction(pAccion)) {
     }

     public genReporteEjecutarActionExchange(genReporteEjecutarActionEnum.EnumgenReporteEjecutarAction pAccion, GeneralesCommon.genReporteEjecutarDS pdsParam) : base(genReporteEjecutarActionEnum.GetAcciongenReporteEjecutarAction(pAccion), pdsParam) {
     }

     public genReporteEjecutarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genReporteEjecutarDS();
     this.mParam.Merge(pExch.RawDataSet, true, MissingSchemaAction.Add);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genReporteEjecutarDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genReporteEjecutarDS)mParam;
	        }
     }
  }
}
