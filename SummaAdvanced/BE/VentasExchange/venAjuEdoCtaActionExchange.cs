using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venAjuEdoCtaActionExchange : Framework.Core.Exchange{

        public String ClieDesde {
            get {
                if(((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0]["ClieDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].ClieDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].ClieDesde = value;
               }
	          }
        public bool IsClieDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].IsClieDesdeNull();
             }
	        }
        public String RazonSocialDesde {
            get {
                if(((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0]["RazonSocialDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].RazonSocialDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].RazonSocialDesde = value;
               }
	          }
        public bool IsRazonSocialDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].IsRazonSocialDesdeNull();
             }
	        }
        public String ClieHasta {
            get {
                if(((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0]["ClieHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].ClieHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].ClieHasta = value;
               }
	          }
        public bool IsClieHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].IsClieHastaNull();
             }
	        }
        public String RazonSocialHasta {
            get {
                if(((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0]["RazonSocialHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].RazonSocialHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].RazonSocialHasta = value;
               }
	          }
        public bool IsRazonSocialHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].IsRazonSocialHastaNull();
             }
	        }
        public Decimal Monto {
            get {
                if(((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0]["Monto"] != DBNull.Value  ){
                    return ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].Monto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].Monto = value;
               }
	          }
        public bool IsMontoNull {
             get {
                 return mParam==null || ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].IsMontoNull();
             }
	        }
        public String CuentaDebe {
            get {
                if(((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0]["CuentaDebe"] != DBNull.Value  ){
                    return ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].CuentaDebe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].CuentaDebe = value;
               }
	          }
        public bool IsCuentaDebeNull {
             get {
                 return mParam==null || ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].IsCuentaDebeNull();
             }
	        }
        public String DescripcionCtaDebe {
            get {
                if(((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0]["DescripcionCtaDebe"] != DBNull.Value  ){
                    return ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].DescripcionCtaDebe;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].DescripcionCtaDebe = value;
               }
	          }
        public bool IsDescripcionCtaDebeNull {
             get {
                 return mParam==null || ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].IsDescripcionCtaDebeNull();
             }
	        }
        public String CuentaHaber {
            get {
                if(((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0]["CuentaHaber"] != DBNull.Value  ){
                    return ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].CuentaHaber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].CuentaHaber = value;
               }
	          }
        public bool IsCuentaHaberNull {
             get {
                 return mParam==null || ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].IsCuentaHaberNull();
             }
	        }
        public String DescripcionCtaHaber {
            get {
                if(((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0]["DescripcionCtaHaber"] != DBNull.Value  ){
                    return ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].DescripcionCtaHaber;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].DescripcionCtaHaber = value;
               }
	          }
        public bool IsDescripcionCtaHaberNull {
             get {
                 return mParam==null || ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].IsDescripcionCtaHaberNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public String SucursalDesde {
            get {
                if(((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0]["SucursalDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].SucursalDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].SucursalDesde = value;
               }
	          }
        public bool IsSucursalDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].IsSucursalDesdeNull();
             }
	        }
        public String SucursalHasta {
            get {
                if(((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0]["SucursalHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].SucursalHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].SucursalHasta = value;
               }
	          }
        public bool IsSucursalHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].IsSucursalHastaNull();
             }
	        }
        public String Avance {
            get {
                if(((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0]["Avance"] != DBNull.Value  ){
                    return ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].Avance;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].Avance = value;
               }
	          }
        public bool IsAvanceNull {
             get {
                 return mParam==null || ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].IsAvanceNull();
             }
	        }
        public String Termino {
            get {
                if(((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0]["Termino"] != DBNull.Value  ){
                    return ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].Termino;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].Termino = value;
               }
	          }
        public bool IsTerminoNull {
             get {
                 return mParam==null || ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].IsTerminoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venAjuEdoCtaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venAjuEdoCtaDS );
     }
     public venAjuEdoCtaActionExchange() : base( "venAjuEdoCta" ) {
     }

     public venAjuEdoCtaActionExchange(venAjuEdoCtaActionEnum.EnumvenAjuEdoCtaAction pAccion) : base(venAjuEdoCtaActionEnum.GetAccionvenAjuEdoCtaAction(pAccion)) {
     }

     public venAjuEdoCtaActionExchange(venAjuEdoCtaActionEnum.EnumvenAjuEdoCtaAction pAccion, VentasCommon.venAjuEdoCtaDS pdsParam) : base(venAjuEdoCtaActionEnum.GetAccionvenAjuEdoCtaAction(pAccion), pdsParam) {
     }

     public venAjuEdoCtaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venAjuEdoCtaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venAjuEdoCtaDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venAjuEdoCtaDS)mParam;
	        }
     }
  }
}
