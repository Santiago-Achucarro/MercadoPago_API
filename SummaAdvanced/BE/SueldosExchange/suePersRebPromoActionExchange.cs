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
    public class suePersRebPromoActionExchange : Framework.Core.Exchange{

        public Int64 Legajo {
            get {
                if(((SueldosCommon.suePersRebPromoDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String DescripcionPersonal {
            get {
                if(((SueldosCommon.suePersRebPromoDS)mParam).Principal[0]["DescripcionPersonal"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].DescripcionPersonal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].DescripcionPersonal = value;
               }
	          }
        public bool IsDescripcionPersonalNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].IsDescripcionPersonalNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((SueldosCommon.suePersRebPromoDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((SueldosCommon.suePersRebPromoDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Decimal Rebaja {
            get {
                if(((SueldosCommon.suePersRebPromoDS)mParam).Principal[0]["Rebaja"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].Rebaja;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].Rebaja = value;
               }
	          }
        public bool IsRebajaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].IsRebajaNull();
             }
	        }
        public Int32 Usuario_Id {
            get {
                if(((SueldosCommon.suePersRebPromoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.suePersRebPromoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.suePersRebPromoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.suePersRebPromoDS );
     }
     public suePersRebPromoActionExchange() : base( "suePersRebPromo" ) {
     }

     public suePersRebPromoActionExchange(suePersRebPromoActionEnum.EnumsuePersRebPromoAction pAccion) : base(suePersRebPromoActionEnum.GetAccionsuePersRebPromoAction(pAccion)) {
     }

     public suePersRebPromoActionExchange(suePersRebPromoActionEnum.EnumsuePersRebPromoAction pAccion, SueldosCommon.suePersRebPromoDS pdsParam) : base(suePersRebPromoActionEnum.GetAccionsuePersRebPromoAction(pAccion), pdsParam) {
     }

     public suePersRebPromoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.suePersRebPromoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.suePersRebPromoDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.suePersRebPromoDS)mParam;
	        }
     }
  }
}
