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
    public class sueMovContActionExchange : Framework.Core.Exchange{

        public Int64 sueLiquidacion {
            get {
                if(((SueldosCommon.sueMovContDS)mParam).Principal[0]["sueLiquidacion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueMovContDS)mParam).Principal[0].sueLiquidacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueMovContDS)mParam).Principal[0].sueLiquidacion = value;
               }
	          }
        public bool IssueLiquidacionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueMovContDS)mParam).Principal[0].IssueLiquidacionNull();
             }
	        }
        public Int32 Legajo {
            get {
                if(((SueldosCommon.sueMovContDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueMovContDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueMovContDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueMovContDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String DescripcionLegajo {
            get {
                if(((SueldosCommon.sueMovContDS)mParam).Principal[0]["DescripcionLegajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueMovContDS)mParam).Principal[0].DescripcionLegajo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueMovContDS)mParam).Principal[0].DescripcionLegajo = value;
               }
	          }
        public bool IsDescripcionLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueMovContDS)mParam).Principal[0].IsDescripcionLegajoNull();
             }
	        }
        public Int32 Concepto_Id {
            get {
                if(((SueldosCommon.sueMovContDS)mParam).Principal[0]["Concepto_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueMovContDS)mParam).Principal[0].Concepto_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueMovContDS)mParam).Principal[0].Concepto_Id = value;
               }
	          }
        public bool IsConcepto_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueMovContDS)mParam).Principal[0].IsConcepto_IdNull();
             }
	        }
        public String DescripcionConcepto {
            get {
                if(((SueldosCommon.sueMovContDS)mParam).Principal[0]["DescripcionConcepto"] != DBNull.Value  ){
                    return ((SueldosCommon.sueMovContDS)mParam).Principal[0].DescripcionConcepto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueMovContDS)mParam).Principal[0].DescripcionConcepto = value;
               }
	          }
        public bool IsDescripcionConceptoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueMovContDS)mParam).Principal[0].IsDescripcionConceptoNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((SueldosCommon.sueMovContDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueMovContDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueMovContDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueMovContDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((SueldosCommon.sueMovContDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((SueldosCommon.sueMovContDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueMovContDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueMovContDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((SueldosCommon.sueMovContDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueMovContDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueMovContDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueMovContDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((SueldosCommon.sueMovContDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((SueldosCommon.sueMovContDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueMovContDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((SueldosCommon.sueMovContDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((SueldosCommon.sueMovContDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueMovContDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueMovContDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueMovContDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((SueldosCommon.sueMovContDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((SueldosCommon.sueMovContDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueMovContDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((SueldosCommon.sueMovContDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Decimal Importe {
            get {
                if(((SueldosCommon.sueMovContDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueMovContDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueMovContDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueMovContDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueMovContDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueMovContDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueMovContDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueMovContDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueMovContDS );
     }
     public sueMovContActionExchange() : base( "sueMovCont" ) {
     }

     public sueMovContActionExchange(sueMovContActionEnum.EnumsueMovContAction pAccion) : base(sueMovContActionEnum.GetAccionsueMovContAction(pAccion)) {
     }

     public sueMovContActionExchange(sueMovContActionEnum.EnumsueMovContAction pAccion, SueldosCommon.sueMovContDS pdsParam) : base(sueMovContActionEnum.GetAccionsueMovContAction(pAccion), pdsParam) {
     }

     public sueMovContActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueMovContDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueMovContDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueMovContDS)mParam;
	        }
     }
  }
}
