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
    public class venMovDetalleActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Int32 conRenglon {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["conRenglon"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].conRenglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].conRenglon = value;
               }
	          }
        public bool IsconRenglonNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsconRenglonNull();
             }
	        }
        public String Detalle {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["Detalle"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].Detalle;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].Detalle = value;
               }
	          }
        public bool IsDetalleNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsDetalleNull();
             }
	        }
        public String CFVenta_Id {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["CFVenta_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].CFVenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].CFVenta_Id = value;
               }
	          }
        public bool IsCFVenta_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsCFVenta_IdNull();
             }
	        }
        public String DescripcionCondFisVenta {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["DescripcionCondFisVenta"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].DescripcionCondFisVenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].DescripcionCondFisVenta = value;
               }
	          }
        public bool IsDescripcionCondFisVentaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsDescripcionCondFisVentaNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String DescripcionUniMed {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["DescripcionUniMed"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].DescripcionUniMed;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].DescripcionUniMed = value;
               }
	          }
        public bool IsDescripcionUniMedNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsDescripcionUniMedNull();
             }
	        }
        public Decimal ImporteUnitario {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["ImporteUnitario"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].ImporteUnitario;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].ImporteUnitario = value;
               }
	          }
        public bool IsImporteUnitarioNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsImporteUnitarioNull();
             }
	        }
        public Decimal SubTotal {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["SubTotal"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].SubTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].SubTotal = value;
               }
	          }
        public bool IsSubTotalNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsSubTotalNull();
             }
	        }
        public Decimal ImporteUnitarioDelImpuesto {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["ImporteUnitarioDelImpuesto"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].ImporteUnitarioDelImpuesto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].ImporteUnitarioDelImpuesto = value;
               }
	          }
        public bool IsImporteUnitarioDelImpuestoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsImporteUnitarioDelImpuestoNull();
             }
	        }
        public Decimal SubTotalFormImpuesto {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["SubTotalFormImpuesto"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].SubTotalFormImpuesto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].SubTotalFormImpuesto = value;
               }
	          }
        public bool IsSubTotalFormImpuestoNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsSubTotalFormImpuestoNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuenta {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["DescripcionCuenta"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].DescripcionCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].DescripcionCuenta = value;
               }
	          }
        public bool IsDescripcionCuentaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsDescripcionCuentaNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Decimal TipoMov {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["TipoMov"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].TipoMov;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].TipoMov = value;
               }
	          }
        public bool IsTipoMovNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsTipoMovNull();
             }
	        }
        public String Clase {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["Clase"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].Clase;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].Clase = value;
               }
	          }
        public bool IsClaseNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsClaseNull();
             }
	        }
        public Decimal ImporteContable {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["ImporteContable"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].ImporteContable;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].ImporteContable = value;
               }
	          }
        public bool IsImporteContableNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsImporteContableNull();
             }
	        }
        public String CodigoFiscal {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["CodigoFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].CodigoFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].CodigoFiscal = value;
               }
	          }
        public bool IsCodigoFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsCodigoFiscalNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String CuentaPredial {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["CuentaPredial"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].CuentaPredial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].CuentaPredial = value;
               }
	          }
        public bool IsCuentaPredialNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsCuentaPredialNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovDetalleDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovDetalleDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovDetalleDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovDetalleDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovDetalleDS );
     }
     public venMovDetalleActionExchange() : base( "venMovDetalle" ) {
     }

     public venMovDetalleActionExchange(venMovDetalleActionEnum.EnumvenMovDetalleAction pAccion) : base(venMovDetalleActionEnum.GetAccionvenMovDetalleAction(pAccion)) {
     }

     public venMovDetalleActionExchange(venMovDetalleActionEnum.EnumvenMovDetalleAction pAccion, VentasCommon.venMovDetalleDS pdsParam) : base(venMovDetalleActionEnum.GetAccionvenMovDetalleAction(pAccion), pdsParam) {
     }

     public venMovDetalleActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovDetalleDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovDetalleDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovDetalleDS)mParam;
	        }
     }
  }
}
