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
    public class venMovImpuestosActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venMovImpuestosDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Int32 conRenglon {
            get {
                if(((VentasCommon.venMovImpuestosDS)mParam).Principal[0]["conRenglon"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].conRenglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].conRenglon = value;
               }
	          }
        public bool IsconRenglonNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].IsconRenglonNull();
             }
	        }
        public String Impuesto_Id {
            get {
                if(((VentasCommon.venMovImpuestosDS)mParam).Principal[0]["Impuesto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].Impuesto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].Impuesto_Id = value;
               }
	          }
        public bool IsImpuesto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].IsImpuesto_IdNull();
             }
	        }
        public String DescripcionImpuestos {
            get {
                if(((VentasCommon.venMovImpuestosDS)mParam).Principal[0]["DescripcionImpuestos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].DescripcionImpuestos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].DescripcionImpuestos = value;
               }
	          }
        public bool IsDescripcionImpuestosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].IsDescripcionImpuestosNull();
             }
	        }
        public Decimal Porcentaje {
            get {
                if(((VentasCommon.venMovImpuestosDS)mParam).Principal[0]["Porcentaje"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].Porcentaje;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].Porcentaje = value;
               }
	          }
        public bool IsPorcentajeNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].IsPorcentajeNull();
             }
	        }
        public Decimal BaseImponible {
            get {
                if(((VentasCommon.venMovImpuestosDS)mParam).Principal[0]["BaseImponible"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].BaseImponible;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].BaseImponible = value;
               }
	          }
        public bool IsBaseImponibleNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].IsBaseImponibleNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((VentasCommon.venMovImpuestosDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Decimal BaseImponibleMonedaNac {
            get {
                if(((VentasCommon.venMovImpuestosDS)mParam).Principal[0]["BaseImponibleMonedaNac"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].BaseImponibleMonedaNac;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].BaseImponibleMonedaNac = value;
               }
	          }
        public bool IsBaseImponibleMonedaNacNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].IsBaseImponibleMonedaNacNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((VentasCommon.venMovImpuestosDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuenta {
            get {
                if(((VentasCommon.venMovImpuestosDS)mParam).Principal[0]["DescripcionCuenta"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].DescripcionCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].DescripcionCuenta = value;
               }
	          }
        public bool IsDescripcionCuentaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].IsDescripcionCuentaNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((VentasCommon.venMovImpuestosDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((VentasCommon.venMovImpuestosDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((VentasCommon.venMovImpuestosDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((VentasCommon.venMovImpuestosDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Decimal TipoMov {
            get {
                if(((VentasCommon.venMovImpuestosDS)mParam).Principal[0]["TipoMov"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].TipoMov;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].TipoMov = value;
               }
	          }
        public bool IsTipoMovNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].IsTipoMovNull();
             }
	        }
        public String Clase {
            get {
                if(((VentasCommon.venMovImpuestosDS)mParam).Principal[0]["Clase"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].Clase;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].Clase = value;
               }
	          }
        public bool IsClaseNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].IsClaseNull();
             }
	        }
        public Decimal ImporteContable {
            get {
                if(((VentasCommon.venMovImpuestosDS)mParam).Principal[0]["ImporteContable"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].ImporteContable;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].ImporteContable = value;
               }
	          }
        public bool IsImporteContableNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].IsImporteContableNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovImpuestosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpuestosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovImpuestosDS );
     }
     public venMovImpuestosActionExchange() : base( "venMovImpuestos" ) {
     }

     public venMovImpuestosActionExchange(venMovImpuestosActionEnum.EnumvenMovImpuestosAction pAccion) : base(venMovImpuestosActionEnum.GetAccionvenMovImpuestosAction(pAccion)) {
     }

     public venMovImpuestosActionExchange(venMovImpuestosActionEnum.EnumvenMovImpuestosAction pAccion, VentasCommon.venMovImpuestosDS pdsParam) : base(venMovImpuestosActionEnum.GetAccionvenMovImpuestosAction(pAccion), pdsParam) {
     }

     public venMovImpuestosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovImpuestosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovImpuestosDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovImpuestosDS)mParam;
	        }
     }
  }
}
