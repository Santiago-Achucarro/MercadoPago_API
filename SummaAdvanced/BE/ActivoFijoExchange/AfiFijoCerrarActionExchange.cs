using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ActivoFijoExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class AfiFijoCerrarActionExchange : Framework.Core.Exchange{

        public DateTime UltimoCierre {
            get {
                if(((ActivoFijoCommon.AfiFijoCerrarDS)mParam).Principal[0]["UltimoCierre"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiFijoCerrarDS)mParam).Principal[0].UltimoCierre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiFijoCerrarDS)mParam).Principal[0].UltimoCierre = value;
               }
	          }
        public bool IsUltimoCierreNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiFijoCerrarDS)mParam).Principal[0].IsUltimoCierreNull();
             }
	        }
        public DateTime ProximoCierre {
            get {
                if(((ActivoFijoCommon.AfiFijoCerrarDS)mParam).Principal[0]["ProximoCierre"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiFijoCerrarDS)mParam).Principal[0].ProximoCierre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiFijoCerrarDS)mParam).Principal[0].ProximoCierre = value;
               }
	          }
        public bool IsProximoCierreNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiFijoCerrarDS)mParam).Principal[0].IsProximoCierreNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ActivoFijoCommon.AfiFijoCerrarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiFijoCerrarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiFijoCerrarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiFijoCerrarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ActivoFijoCommon.AfiFijoCerrarDS );
     }
     public AfiFijoCerrarActionExchange() : base( "AfiFijoCerrar" ) {
     }

     public AfiFijoCerrarActionExchange(AfiFijoCerrarActionEnum.EnumAfiFijoCerrarAction pAccion) : base(AfiFijoCerrarActionEnum.GetAccionAfiFijoCerrarAction(pAccion)) {
     }

     public AfiFijoCerrarActionExchange(AfiFijoCerrarActionEnum.EnumAfiFijoCerrarAction pAccion, ActivoFijoCommon.AfiFijoCerrarDS pdsParam) : base(AfiFijoCerrarActionEnum.GetAccionAfiFijoCerrarAction(pAccion), pdsParam) {
     }

     public AfiFijoCerrarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ActivoFijoCommon.AfiFijoCerrarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ActivoFijoCommon.AfiFijoCerrarDS Param{
	        get{
			    InitParam();
			    return (ActivoFijoCommon.AfiFijoCerrarDS)mParam;
	        }
     }
  }
}
