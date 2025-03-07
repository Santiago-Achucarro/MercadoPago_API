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
    public class AfiGenerarDepreActionExchange : Framework.Core.Exchange{

        public DateTime FechaHasta {
            get {
                if(((ActivoFijoCommon.AfiGenerarDepreDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiGenerarDepreDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiGenerarDepreDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiGenerarDepreDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String Tipo {
            get {
                if(((ActivoFijoCommon.AfiGenerarDepreDS)mParam).Principal[0]["Tipo"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiGenerarDepreDS)mParam).Principal[0].Tipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiGenerarDepreDS)mParam).Principal[0].Tipo = value;
               }
	          }
        public bool IsTipoNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiGenerarDepreDS)mParam).Principal[0].IsTipoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ActivoFijoCommon.AfiGenerarDepreDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiGenerarDepreDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiGenerarDepreDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiGenerarDepreDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ActivoFijoCommon.AfiGenerarDepreDS );
     }
     public AfiGenerarDepreActionExchange() : base( "AfiGenerarDepre" ) {
     }

     public AfiGenerarDepreActionExchange(AfiGenerarDepreActionEnum.EnumAfiGenerarDepreAction pAccion) : base(AfiGenerarDepreActionEnum.GetAccionAfiGenerarDepreAction(pAccion)) {
     }

     public AfiGenerarDepreActionExchange(AfiGenerarDepreActionEnum.EnumAfiGenerarDepreAction pAccion, ActivoFijoCommon.AfiGenerarDepreDS pdsParam) : base(AfiGenerarDepreActionEnum.GetAccionAfiGenerarDepreAction(pAccion), pdsParam) {
     }

     public AfiGenerarDepreActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ActivoFijoCommon.AfiGenerarDepreDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ActivoFijoCommon.AfiGenerarDepreDS Param{
	        get{
			    InitParam();
			    return (ActivoFijoCommon.AfiGenerarDepreDS)mParam;
	        }
     }
  }
}
