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
    public class sueConcDescuentoActionExchange : Framework.Core.Exchange{

        public Int64 sueLiquidacion {
            get {
                if(((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0]["sueLiquidacion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0].sueLiquidacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0].sueLiquidacion = value;
               }
	          }
        public bool IssueLiquidacionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0].IssueLiquidacionNull();
             }
	        }
        public Int32 Legajo {
            get {
                if(((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public Int32 Concepto_Id {
            get {
                if(((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0]["Concepto_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0].Concepto_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0].Concepto_Id = value;
               }
	          }
        public bool IsConcepto_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0].IsConcepto_IdNull();
             }
	        }
        public Decimal Monto {
            get {
                if(((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0]["Monto"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0].Monto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0].Monto = value;
               }
	          }
        public bool IsMontoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0].IsMontoNull();
             }
	        }
        public Int32 sueConcAcum {
            get {
                if(((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0]["sueConcAcum"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0].sueConcAcum;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0].sueConcAcum = value;
               }
	          }
        public bool IssueConcAcumNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0].IssueConcAcumNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueConcDescuentoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueConcDescuentoDS );
     }
     public sueConcDescuentoActionExchange() : base( "sueConcDescuento" ) {
     }

     public sueConcDescuentoActionExchange(sueConcDescuentoActionEnum.EnumsueConcDescuentoAction pAccion) : base(sueConcDescuentoActionEnum.GetAccionsueConcDescuentoAction(pAccion)) {
     }

     public sueConcDescuentoActionExchange(sueConcDescuentoActionEnum.EnumsueConcDescuentoAction pAccion, SueldosCommon.sueConcDescuentoDS pdsParam) : base(sueConcDescuentoActionEnum.GetAccionsueConcDescuentoAction(pAccion), pdsParam) {
     }

     public sueConcDescuentoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueConcDescuentoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueConcDescuentoDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueConcDescuentoDS)mParam;
	        }
     }
  }
}
