using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comAjuEdoCtaActionExchange : Framework.Core.Exchange{

        public String ProveeedDesde {
            get {
                if(((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0]["ProveeedDesde"] != DBNull.Value  ){
                    return ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].ProveeedDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].ProveeedDesde = value;
               }
	          }
        public bool IsProveeedDesdeNull {
             get {
                 return mParam==null || ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].IsProveeedDesdeNull();
             }
	        }
        public String RazonSocialDesde {
            get {
                if(((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0]["RazonSocialDesde"] != DBNull.Value  ){
                    return ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].RazonSocialDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].RazonSocialDesde = value;
               }
	          }
        public bool IsRazonSocialDesdeNull {
             get {
                 return mParam==null || ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].IsRazonSocialDesdeNull();
             }
	        }
        public String ProveeedHasta {
            get {
                if(((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0]["ProveeedHasta"] != DBNull.Value  ){
                    return ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].ProveeedHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].ProveeedHasta = value;
               }
	          }
        public bool IsProveeedHastaNull {
             get {
                 return mParam==null || ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].IsProveeedHastaNull();
             }
	        }
        public String RazonSocialHasta {
            get {
                if(((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0]["RazonSocialHasta"] != DBNull.Value  ){
                    return ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].RazonSocialHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].RazonSocialHasta = value;
               }
	          }
        public bool IsRazonSocialHastaNull {
             get {
                 return mParam==null || ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].IsRazonSocialHastaNull();
             }
	        }
        public Decimal Monto {
            get {
                if(((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0]["Monto"] != DBNull.Value  ){
                    return ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].Monto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].Monto = value;
               }
	          }
        public bool IsMontoNull {
             get {
                 return mParam==null || ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].IsMontoNull();
             }
	        }
        public String CuentaDebe {
            get {
                if(((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0]["CuentaDebe"] != DBNull.Value  ){
                    return ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].CuentaDebe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].CuentaDebe = value;
               }
	          }
        public bool IsCuentaDebeNull {
             get {
                 return mParam==null || ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].IsCuentaDebeNull();
             }
	        }
        public String DescripcionCtaDebe {
            get {
                if(((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0]["DescripcionCtaDebe"] != DBNull.Value  ){
                    return ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].DescripcionCtaDebe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].DescripcionCtaDebe = value;
               }
	          }
        public bool IsDescripcionCtaDebeNull {
             get {
                 return mParam==null || ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].IsDescripcionCtaDebeNull();
             }
	        }
        public String CuentaHaber {
            get {
                if(((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0]["CuentaHaber"] != DBNull.Value  ){
                    return ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].CuentaHaber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].CuentaHaber = value;
               }
	          }
        public bool IsCuentaHaberNull {
             get {
                 return mParam==null || ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].IsCuentaHaberNull();
             }
	        }
        public String DescripcionCtaHaber {
            get {
                if(((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0]["DescripcionCtaHaber"] != DBNull.Value  ){
                    return ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].DescripcionCtaHaber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].DescripcionCtaHaber = value;
               }
	          }
        public bool IsDescripcionCtaHaberNull {
             get {
                 return mParam==null || ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].IsDescripcionCtaHaberNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comAjuEdoCtaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comAjuEdoCtaDS );
     }
     public comAjuEdoCtaActionExchange() : base( "comAjuEdoCta" ) {
     }

     public comAjuEdoCtaActionExchange(comAjuEdoCtaActionEnum.EnumcomAjuEdoCtaAction pAccion) : base(comAjuEdoCtaActionEnum.GetAccioncomAjuEdoCtaAction(pAccion)) {
     }

     public comAjuEdoCtaActionExchange(comAjuEdoCtaActionEnum.EnumcomAjuEdoCtaAction pAccion, ComprasCommon.comAjuEdoCtaDS pdsParam) : base(comAjuEdoCtaActionEnum.GetAccioncomAjuEdoCtaAction(pAccion), pdsParam) {
     }

     public comAjuEdoCtaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comAjuEdoCtaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comAjuEdoCtaDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comAjuEdoCtaDS)mParam;
	        }
     }
  }
}
