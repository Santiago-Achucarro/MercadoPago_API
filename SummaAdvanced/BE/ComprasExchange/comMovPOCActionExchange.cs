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
    public class comMovPOCActionExchange : Framework.Core.Exchange{

        public Int64 comMovProv {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["comMovProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].comMovProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].comMovProv = value;
               }
	          }
        public bool IscomMovProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IscomMovProvNull();
             }
	        }
        public Int32 comOrdenComp {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["comOrdenComp"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].comOrdenComp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].comOrdenComp = value;
               }
	          }
        public bool IscomOrdenCompNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IscomOrdenCompNull();
             }
	        }
        public Int32 Renglon_OC {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["Renglon_OC"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Renglon_OC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Renglon_OC = value;
               }
	          }
        public bool IsRenglon_OCNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsRenglon_OCNull();
             }
	        }
        public Decimal CantidadOC {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["CantidadOC"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].CantidadOC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].CantidadOC = value;
               }
	          }
        public bool IsCantidadOCNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsCantidadOCNull();
             }
	        }
        public Decimal Cantidad_Recibida {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["Cantidad_Recibida"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Cantidad_Recibida;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Cantidad_Recibida = value;
               }
	          }
        public bool IsCantidad_RecibidaNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsCantidad_RecibidaNull();
             }
	        }
        public Decimal Cantidad_Facturada {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["Cantidad_Facturada"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Cantidad_Facturada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Cantidad_Facturada = value;
               }
	          }
        public bool IsCantidad_FacturadaNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsCantidad_FacturadaNull();
             }
	        }
        public DateTime Fecha_Entrega {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["Fecha_Entrega"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Fecha_Entrega;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Fecha_Entrega = value;
               }
	          }
        public bool IsFecha_EntregaNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsFecha_EntregaNull();
             }
	        }
        public Decimal Precio {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["Precio"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Precio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Precio = value;
               }
	          }
        public bool IsPrecioNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsPrecioNull();
             }
	        }
        public Boolean Pendiente {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["Pendiente"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Pendiente;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Pendiente = value;
               }
	          }
        public bool IsPendienteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsPendienteNull();
             }
	        }
        public Decimal Cantidad_Creditos {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["Cantidad_Creditos"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Cantidad_Creditos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Cantidad_Creditos = value;
               }
	          }
        public bool IsCantidad_CreditosNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsCantidad_CreditosNull();
             }
	        }
        public Decimal PrecioOriginal {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["PrecioOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].PrecioOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].PrecioOriginal = value;
               }
	          }
        public bool IsPrecioOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsPrecioOriginalNull();
             }
	        }
        public Decimal CantidadOriginalOC {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["CantidadOriginalOC"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].CantidadOriginalOC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].CantidadOriginalOC = value;
               }
	          }
        public bool IsCantidadOriginalOCNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsCantidadOriginalOCNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal CantidadOriginal {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["CantidadOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].CantidadOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].CantidadOriginal = value;
               }
	          }
        public bool IsCantidadOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsCantidadOriginalNull();
             }
	        }
        public Decimal Factor {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["Factor"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Factor;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Factor = value;
               }
	          }
        public bool IsFactorNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsFactorNull();
             }
	        }
        public String Medida_id {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["Medida_id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Medida_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Medida_id = value;
               }
	          }
        public bool IsMedida_idNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsMedida_idNull();
             }
	        }
        public String DescripcionMedida {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["DescripcionMedida"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].DescripcionMedida;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].DescripcionMedida = value;
               }
	          }
        public bool IsDescripcionMedidaNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsDescripcionMedidaNull();
             }
	        }
        public String Centro1_id {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["Centro1_id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Centro1_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Centro1_id = value;
               }
	          }
        public bool IsCentro1_idNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsCentro1_idNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_id {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["Centro2_id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Centro2_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Centro2_id = value;
               }
	          }
        public bool IsCentro2_idNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsCentro2_idNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public String Producto_id {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["Producto_id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Producto_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Producto_id = value;
               }
	          }
        public bool IsProducto_idNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsProducto_idNull();
             }
	        }
        public String Detalle {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["Detalle"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Detalle;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Detalle = value;
               }
	          }
        public bool IsDetalleNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsDetalleNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovPOCDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovPOCDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovPOCDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovPOCDS );
     }
     public comMovPOCActionExchange() : base( "comMovPOC" ) {
     }

     public comMovPOCActionExchange(comMovPOCActionEnum.EnumcomMovPOCAction pAccion) : base(comMovPOCActionEnum.GetAccioncomMovPOCAction(pAccion)) {
     }

     public comMovPOCActionExchange(comMovPOCActionEnum.EnumcomMovPOCAction pAccion, ComprasCommon.comMovPOCDS pdsParam) : base(comMovPOCActionEnum.GetAccioncomMovPOCAction(pAccion), pdsParam) {
     }

     public comMovPOCActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovPOCDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovPOCDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovPOCDS)mParam;
	        }
     }
  }
}
