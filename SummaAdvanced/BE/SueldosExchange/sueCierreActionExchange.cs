using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace SueldosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class sueCierreActionExchange : Framework.Core.Exchange{

        public DateTime UltimoCierre {
            get {
                if(((SueldosCommon.sueCierreDS)mParam).Principal[0]["UltimoCierre"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCierreDS)mParam).Principal[0].UltimoCierre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCierreDS)mParam).Principal[0].UltimoCierre = value;
               }
	          }
        public bool IsUltimoCierreNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCierreDS)mParam).Principal[0].IsUltimoCierreNull();
             }
	        }
        public DateTime ProximoCierre {
            get {
                if(((SueldosCommon.sueCierreDS)mParam).Principal[0]["ProximoCierre"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCierreDS)mParam).Principal[0].ProximoCierre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCierreDS)mParam).Principal[0].ProximoCierre = value;
               }
	          }
        public bool IsProximoCierreNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCierreDS)mParam).Principal[0].IsProximoCierreNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueCierreDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCierreDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCierreDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCierreDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueCierreDS );
     }
     public sueCierreActionExchange() : base( "sueCierre" ) {
     }

     public sueCierreActionExchange(sueCierreActionEnum.EnumsueCierreAction pAccion) : base(sueCierreActionEnum.GetAccionsueCierreAction(pAccion)) {
     }

     public sueCierreActionExchange(sueCierreActionEnum.EnumsueCierreAction pAccion, SueldosCommon.sueCierreDS pdsParam) : base(sueCierreActionEnum.GetAccionsueCierreAction(pAccion), pdsParam) {
     }

     public sueCierreActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueCierreDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueCierreDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueCierreDS)mParam;
	        }
     }
  }
}
