using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genCancMovCuentaActionExchange : Framework.Core.Exchange{

        public Int64 conAsientos {
            get {
                if(((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0]["conAsientos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].conAsientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].conAsientos = value;
               }
	          }
        public bool IsconAsientosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].IsconAsientosNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Clase {
            get {
                if(((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0]["Clase"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].Clase;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].Clase = value;
               }
	          }
        public bool IsClaseNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].IsClaseNull();
             }
	        }
        public Decimal TipoMov {
            get {
                if(((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0]["TipoMov"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].TipoMov;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].TipoMov = value;
               }
	          }
        public bool IsTipoMovNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].IsTipoMovNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCancMovCuentaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genCancMovCuentaDS );
     }
     public genCancMovCuentaActionExchange() : base( "genCancMovCuenta" ) {
     }

     public genCancMovCuentaActionExchange(genCancMovCuentaActionEnum.EnumgenCancMovCuentaAction pAccion) : base(genCancMovCuentaActionEnum.GetAcciongenCancMovCuentaAction(pAccion)) {
     }

     public genCancMovCuentaActionExchange(genCancMovCuentaActionEnum.EnumgenCancMovCuentaAction pAccion, GeneralesCommon.genCancMovCuentaDS pdsParam) : base(genCancMovCuentaActionEnum.GetAcciongenCancMovCuentaAction(pAccion), pdsParam) {
     }

     public genCancMovCuentaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genCancMovCuentaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genCancMovCuentaDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genCancMovCuentaDS)mParam;
	        }
     }
  }
}
