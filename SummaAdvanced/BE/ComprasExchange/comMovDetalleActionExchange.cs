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
    public class comMovDetalleActionExchange : Framework.Core.Exchange{

        public Int64 comMovProv {
            get {
                if(((ComprasCommon.comMovDetalleDS)mParam).Principal[0]["comMovProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].comMovProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].comMovProv = value;
               }
	          }
        public bool IscomMovProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].IscomMovProvNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ComprasCommon.comMovDetalleDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Detalle {
            get {
                if(((ComprasCommon.comMovDetalleDS)mParam).Principal[0]["Detalle"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].Detalle;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].Detalle = value;
               }
	          }
        public bool IsDetalleNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].IsDetalleNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((ComprasCommon.comMovDetalleDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ComprasCommon.comMovDetalleDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuenta {
            get {
                if(((ComprasCommon.comMovDetalleDS)mParam).Principal[0]["DescripcionCuenta"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].DescripcionCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].DescripcionCuenta = value;
               }
	          }
        public bool IsDescripcionCuentaNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].IsDescripcionCuentaNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ComprasCommon.comMovDetalleDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ComprasCommon.comMovDetalleDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ComprasCommon.comMovDetalleDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ComprasCommon.comMovDetalleDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public String Base_Id {
            get {
                if(((ComprasCommon.comMovDetalleDS)mParam).Principal[0]["Base_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].Base_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].Base_Id = value;
               }
	          }
        public bool IsBase_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].IsBase_IdNull();
             }
	        }
        public String DescripcionBaseDistri {
            get {
                if(((ComprasCommon.comMovDetalleDS)mParam).Principal[0]["DescripcionBaseDistri"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].DescripcionBaseDistri;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].DescripcionBaseDistri = value;
               }
	          }
        public bool IsDescripcionBaseDistriNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].IsDescripcionBaseDistriNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovDetalleDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovDetalleDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovDetalleDS );
     }
     public comMovDetalleActionExchange() : base( "comMovDetalle" ) {
     }

     public comMovDetalleActionExchange(comMovDetalleActionEnum.EnumcomMovDetalleAction pAccion) : base(comMovDetalleActionEnum.GetAccioncomMovDetalleAction(pAccion)) {
     }

     public comMovDetalleActionExchange(comMovDetalleActionEnum.EnumcomMovDetalleAction pAccion, ComprasCommon.comMovDetalleDS pdsParam) : base(comMovDetalleActionEnum.GetAccioncomMovDetalleAction(pAccion), pdsParam) {
     }

     public comMovDetalleActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovDetalleDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovDetalleDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovDetalleDS)mParam;
	        }
     }
  }
}
