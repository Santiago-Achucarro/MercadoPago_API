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
    public class comOcReceCuerpoActionExchange : Framework.Core.Exchange{

        public Int64 Asiento_Id {
            get {
                if(((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public Int32 conRenglon {
            get {
                if(((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0]["conRenglon"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].conRenglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].conRenglon = value;
               }
	          }
        public bool IsconRenglonNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].IsconRenglonNull();
             }
	        }
        public Int32 comOrdenComp {
            get {
                if(((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0]["comOrdenComp"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].comOrdenComp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].comOrdenComp = value;
               }
	          }
        public bool IscomOrdenCompNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].IscomOrdenCompNull();
             }
	        }
        public Int32 Renglon_OC {
            get {
                if(((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0]["Renglon_OC"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Renglon_OC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Renglon_OC = value;
               }
	          }
        public bool IsRenglon_OCNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].IsRenglon_OCNull();
             }
	        }
        public String Detalle {
            get {
                if(((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0]["Detalle"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Detalle;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Detalle = value;
               }
	          }
        public bool IsDetalleNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].IsDetalleNull();
             }
	        }
        public Decimal CantidadOC {
            get {
                if(((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0]["CantidadOC"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].CantidadOC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].CantidadOC = value;
               }
	          }
        public bool IsCantidadOCNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].IsCantidadOCNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public String Observaciones {
            get {
                if(((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuenta {
            get {
                if(((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0]["DescripcionCuenta"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].DescripcionCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].DescripcionCuenta = value;
               }
	          }
        public bool IsDescripcionCuentaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].IsDescripcionCuentaNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Decimal Importe {
            get {
                if(((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Decimal ImporteMonedaOriginal {
            get {
                if(((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0]["ImporteMonedaOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].ImporteMonedaOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].ImporteMonedaOriginal = value;
               }
	          }
        public bool IsImporteMonedaOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].IsImporteMonedaOriginalNull();
             }
	        }
        public Decimal CantFactPendiente {
            get {
                if(((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0]["CantFactPendiente"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].CantFactPendiente;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].CantFactPendiente = value;
               }
	          }
        public bool IsCantFactPendienteNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].IsCantFactPendienteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comOcReceCuerpoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comOcReceCuerpoDS );
     }
     public comOcReceCuerpoActionExchange() : base( "comOcReceCuerpo" ) {
     }

     public comOcReceCuerpoActionExchange(comOcReceCuerpoActionEnum.EnumcomOcReceCuerpoAction pAccion) : base(comOcReceCuerpoActionEnum.GetAccioncomOcReceCuerpoAction(pAccion)) {
     }

     public comOcReceCuerpoActionExchange(comOcReceCuerpoActionEnum.EnumcomOcReceCuerpoAction pAccion, ComprasCommon.comOcReceCuerpoDS pdsParam) : base(comOcReceCuerpoActionEnum.GetAccioncomOcReceCuerpoAction(pAccion), pdsParam) {
     }

     public comOcReceCuerpoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comOcReceCuerpoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comOcReceCuerpoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comOcReceCuerpoDS)mParam;
	        }
     }
  }
}
