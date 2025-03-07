using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ContabilidadExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class conMovContActionExchange : Framework.Core.Exchange{

        public Int64 conAsientos {
            get {
                if(((ContabilidadCommon.conMovContDS)mParam).Principal[0]["conAsientos"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContDS)mParam).Principal[0].conAsientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContDS)mParam).Principal[0].conAsientos = value;
               }
	          }
        public bool IsconAsientosNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContDS)mParam).Principal[0].IsconAsientosNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ContabilidadCommon.conMovContDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ContabilidadCommon.conMovContDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((ContabilidadCommon.conMovContDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public String LeyendaLibroMayor {
            get {
                if(((ContabilidadCommon.conMovContDS)mParam).Principal[0]["LeyendaLibroMayor"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContDS)mParam).Principal[0].LeyendaLibroMayor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContDS)mParam).Principal[0].LeyendaLibroMayor = value;
               }
	          }
        public bool IsLeyendaLibroMayorNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContDS)mParam).Principal[0].IsLeyendaLibroMayorNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((ContabilidadCommon.conMovContDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Decimal ImporteMonedaOriginal {
            get {
                if(((ContabilidadCommon.conMovContDS)mParam).Principal[0]["ImporteMonedaOriginal"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContDS)mParam).Principal[0].ImporteMonedaOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContDS)mParam).Principal[0].ImporteMonedaOriginal = value;
               }
	          }
        public bool IsImporteMonedaOriginalNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContDS)mParam).Principal[0].IsImporteMonedaOriginalNull();
             }
	        }
        public Decimal TipoMov {
            get {
                if(((ContabilidadCommon.conMovContDS)mParam).Principal[0]["TipoMov"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContDS)mParam).Principal[0].TipoMov;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContDS)mParam).Principal[0].TipoMov = value;
               }
	          }
        public bool IsTipoMovNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContDS)mParam).Principal[0].IsTipoMovNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ContabilidadCommon.conMovContDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ContabilidadCommon.conMovContDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ContabilidadCommon.conMovContDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ContabilidadCommon.conMovContDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public String Clase {
            get {
                if(((ContabilidadCommon.conMovContDS)mParam).Principal[0]["Clase"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContDS)mParam).Principal[0].Clase;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContDS)mParam).Principal[0].Clase = value;
               }
	          }
        public bool IsClaseNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContDS)mParam).Principal[0].IsClaseNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conMovContDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conMovContDS );
     }
     public conMovContActionExchange() : base( "conMovCont" ) {
     }

     public conMovContActionExchange(conMovContActionEnum.EnumconMovContAction pAccion) : base(conMovContActionEnum.GetAccionconMovContAction(pAccion)) {
     }

     public conMovContActionExchange(conMovContActionEnum.EnumconMovContAction pAccion, ContabilidadCommon.conMovContDS pdsParam) : base(conMovContActionEnum.GetAccionconMovContAction(pAccion), pdsParam) {
     }

     public conMovContActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conMovContDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conMovContDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conMovContDS)mParam;
	        }
     }
  }
}
