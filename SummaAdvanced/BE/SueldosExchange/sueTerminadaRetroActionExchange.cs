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
    public class sueTerminadaRetroActionExchange : Framework.Core.Exchange{

        public Int64 sueLiquidacion {
            get {
                if(((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0]["sueLiquidacion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].sueLiquidacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].sueLiquidacion = value;
               }
	          }
        public bool IssueLiquidacionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].IssueLiquidacionNull();
             }
	        }
        public Int32 Legajo {
            get {
                if(((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public Int32 Concepto_Id {
            get {
                if(((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0]["Concepto_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].Concepto_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].Concepto_Id = value;
               }
	          }
        public bool IsConcepto_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].IsConcepto_IdNull();
             }
	        }
        public Int32 AnioRetro {
            get {
                if(((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0]["AnioRetro"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].AnioRetro;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].AnioRetro = value;
               }
	          }
        public bool IsAnioRetroNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].IsAnioRetroNull();
             }
	        }
        public Int32 MesRetro {
            get {
                if(((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0]["MesRetro"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].MesRetro;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].MesRetro = value;
               }
	          }
        public bool IsMesRetroNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].IsMesRetroNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTerminadaRetroDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueTerminadaRetroDS );
     }
     public sueTerminadaRetroActionExchange() : base( "sueTerminadaRetro" ) {
     }

     public sueTerminadaRetroActionExchange(sueTerminadaRetroActionEnum.EnumsueTerminadaRetroAction pAccion) : base(sueTerminadaRetroActionEnum.GetAccionsueTerminadaRetroAction(pAccion)) {
     }

     public sueTerminadaRetroActionExchange(sueTerminadaRetroActionEnum.EnumsueTerminadaRetroAction pAccion, SueldosCommon.sueTerminadaRetroDS pdsParam) : base(sueTerminadaRetroActionEnum.GetAccionsueTerminadaRetroAction(pAccion), pdsParam) {
     }

     public sueTerminadaRetroActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueTerminadaRetroDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueTerminadaRetroDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueTerminadaRetroDS)mParam;
	        }
     }
  }
}
