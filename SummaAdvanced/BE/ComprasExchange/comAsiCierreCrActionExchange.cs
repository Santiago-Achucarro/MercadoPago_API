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
    public class comAsiCierreCrActionExchange : Framework.Core.Exchange{

        public Int64 Asiento_Id {
            get {
                if(((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String DescripcionProveedores {
            get {
                if(((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0]["DescripcionProveedores"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].DescripcionProveedores;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].DescripcionProveedores = value;
               }
	          }
        public bool IsDescripcionProveedoresNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].IsDescripcionProveedoresNull();
             }
	        }
        public Int32 conRenglon {
            get {
                if(((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0]["conRenglon"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].conRenglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].conRenglon = value;
               }
	          }
        public bool IsconRenglonNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].IsconRenglonNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuenta {
            get {
                if(((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0]["DescripcionCuenta"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].DescripcionCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].DescripcionCuenta = value;
               }
	          }
        public bool IsDescripcionCuentaNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].IsDescripcionCuentaNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public String LeyendaLibroMayor {
            get {
                if(((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0]["LeyendaLibroMayor"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].LeyendaLibroMayor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].LeyendaLibroMayor = value;
               }
	          }
        public bool IsLeyendaLibroMayorNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].IsLeyendaLibroMayorNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Decimal ImporteMonedaOriginal {
            get {
                if(((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0]["ImporteMonedaOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].ImporteMonedaOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].ImporteMonedaOriginal = value;
               }
	          }
        public bool IsImporteMonedaOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].IsImporteMonedaOriginalNull();
             }
	        }
        public Decimal Tipomov {
            get {
                if(((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0]["Tipomov"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].Tipomov;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].Tipomov = value;
               }
	          }
        public bool IsTipomovNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].IsTipomovNull();
             }
	        }
        public String Clase {
            get {
                if(((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0]["Clase"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].Clase;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].Clase = value;
               }
	          }
        public bool IsClaseNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].IsClaseNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comAsiCierreCrDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comAsiCierreCrDS );
     }
     public comAsiCierreCrActionExchange() : base( "comAsiCierreCr" ) {
     }

     public comAsiCierreCrActionExchange(comAsiCierreCrActionEnum.EnumcomAsiCierreCrAction pAccion) : base(comAsiCierreCrActionEnum.GetAccioncomAsiCierreCrAction(pAccion)) {
     }

     public comAsiCierreCrActionExchange(comAsiCierreCrActionEnum.EnumcomAsiCierreCrAction pAccion, ComprasCommon.comAsiCierreCrDS pdsParam) : base(comAsiCierreCrActionEnum.GetAccioncomAsiCierreCrAction(pAccion), pdsParam) {
     }

     public comAsiCierreCrActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comAsiCierreCrDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comAsiCierreCrDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comAsiCierreCrDS)mParam;
	        }
     }
  }
}
