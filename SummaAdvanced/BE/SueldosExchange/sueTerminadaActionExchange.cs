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
    public class sueTerminadaActionExchange : Framework.Core.Exchange{

        public Int64 sueLiquidacion {
            get {
                if(((SueldosCommon.sueTerminadaDS)mParam).Principal[0]["sueLiquidacion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].sueLiquidacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].sueLiquidacion = value;
               }
	          }
        public bool IssueLiquidacionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].IssueLiquidacionNull();
             }
	        }
        public Int32 Legajo {
            get {
                if(((SueldosCommon.sueTerminadaDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String DescripcionPersonal {
            get {
                if(((SueldosCommon.sueTerminadaDS)mParam).Principal[0]["DescripcionPersonal"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].DescripcionPersonal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].DescripcionPersonal = value;
               }
	          }
        public bool IsDescripcionPersonalNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].IsDescripcionPersonalNull();
             }
	        }
        public Int32 Concepto_Id {
            get {
                if(((SueldosCommon.sueTerminadaDS)mParam).Principal[0]["Concepto_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].Concepto_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].Concepto_Id = value;
               }
	          }
        public bool IsConcepto_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].IsConcepto_IdNull();
             }
	        }
        public String DescripcionConceptos {
            get {
                if(((SueldosCommon.sueTerminadaDS)mParam).Principal[0]["DescripcionConceptos"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].DescripcionConceptos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].DescripcionConceptos = value;
               }
	          }
        public bool IsDescripcionConceptosNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].IsDescripcionConceptosNull();
             }
	        }
        public Decimal Dato {
            get {
                if(((SueldosCommon.sueTerminadaDS)mParam).Principal[0]["Dato"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].Dato;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].Dato = value;
               }
	          }
        public bool IsDatoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].IsDatoNull();
             }
	        }
        public Decimal Dato2 {
            get {
                if(((SueldosCommon.sueTerminadaDS)mParam).Principal[0]["Dato2"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].Dato2;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].Dato2 = value;
               }
	          }
        public bool IsDato2Null {
             get {
                 return mParam==null || ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].IsDato2Null();
             }
	        }
        public Decimal Importe {
            get {
                if(((SueldosCommon.sueTerminadaDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Int16 Signo {
            get {
                if(((SueldosCommon.sueTerminadaDS)mParam).Principal[0]["Signo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].Signo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].Signo = value;
               }
	          }
        public bool IsSignoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].IsSignoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueTerminadaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTerminadaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueTerminadaDS );
     }
     public sueTerminadaActionExchange() : base( "sueTerminada" ) {
     }

     public sueTerminadaActionExchange(sueTerminadaActionEnum.EnumsueTerminadaAction pAccion) : base(sueTerminadaActionEnum.GetAccionsueTerminadaAction(pAccion)) {
     }

     public sueTerminadaActionExchange(sueTerminadaActionEnum.EnumsueTerminadaAction pAccion, SueldosCommon.sueTerminadaDS pdsParam) : base(sueTerminadaActionEnum.GetAccionsueTerminadaAction(pAccion), pdsParam) {
     }

     public sueTerminadaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueTerminadaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueTerminadaDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueTerminadaDS)mParam;
	        }
     }
  }
}
