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
    public class genAplicacionesActionExchange : Framework.Core.Exchange{

        public Int64 Asiento_Id_Ap {
            get {
                if(((GeneralesCommon.genAplicacionesDS)mParam).Principal[0]["Asiento_Id_Ap"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAplicacionesDS)mParam).Principal[0].Asiento_Id_Ap;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAplicacionesDS)mParam).Principal[0].Asiento_Id_Ap = value;
               }
	          }
        public bool IsAsiento_Id_ApNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAplicacionesDS)mParam).Principal[0].IsAsiento_Id_ApNull();
             }
	        }
        public Int16 CuotaNro_Ap {
            get {
                if(((GeneralesCommon.genAplicacionesDS)mParam).Principal[0]["CuotaNro_Ap"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAplicacionesDS)mParam).Principal[0].CuotaNro_Ap;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAplicacionesDS)mParam).Principal[0].CuotaNro_Ap = value;
               }
	          }
        public bool IsCuotaNro_ApNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAplicacionesDS)mParam).Principal[0].IsCuotaNro_ApNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genAplicacionesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAplicacionesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAplicacionesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAplicacionesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genAplicacionesDS );
     }
     public genAplicacionesActionExchange() : base( "genAplicaciones" ) {
     }

     public genAplicacionesActionExchange(genAplicacionesActionEnum.EnumgenAplicacionesAction pAccion) : base(genAplicacionesActionEnum.GetAcciongenAplicacionesAction(pAccion)) {
     }

     public genAplicacionesActionExchange(genAplicacionesActionEnum.EnumgenAplicacionesAction pAccion, GeneralesCommon.genAplicacionesDS pdsParam) : base(genAplicacionesActionEnum.GetAcciongenAplicacionesAction(pAccion), pdsParam) {
     }

     public genAplicacionesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genAplicacionesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genAplicacionesDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genAplicacionesDS)mParam;
	        }
     }
  }
}
