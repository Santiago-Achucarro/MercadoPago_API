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
    public class comOCArticuloActionExchange : Framework.Core.Exchange{

        public Int32 comOrdenComp {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["comOrdenComp"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].comOrdenComp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].comOrdenComp = value;
               }
	          }
        public bool IscomOrdenCompNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IscomOrdenCompNull();
             }
	        }
        public Int32 Renglon_OC {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["Renglon_OC"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Renglon_OC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Renglon_OC = value;
               }
	          }
        public bool IsRenglon_OCNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsRenglon_OCNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProductos {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["DescripcionProductos"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].DescripcionProductos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].DescripcionProductos = value;
               }
	          }
        public bool IsDescripcionProductosNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsDescripcionProductosNull();
             }
	        }
        public Decimal Factor {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["Factor"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Factor;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Factor = value;
               }
	          }
        public bool IsFactorNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsFactorNull();
             }
	        }
        public Decimal CantidadOriginal {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["CantidadOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].CantidadOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].CantidadOriginal = value;
               }
	          }
        public bool IsCantidadOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsCantidadOriginalNull();
             }
	        }
        public Decimal PrecioOriginal {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["PrecioOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].PrecioOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].PrecioOriginal = value;
               }
	          }
        public bool IsPrecioOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsPrecioOriginalNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDepositos {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["DescripcionDepositos"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].DescripcionDepositos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].DescripcionDepositos = value;
               }
	          }
        public bool IsDescripcionDepositosNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsDescripcionDepositosNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal Cantidad_Recibida {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["Cantidad_Recibida"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Cantidad_Recibida;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Cantidad_Recibida = value;
               }
	          }
        public bool IsCantidad_RecibidaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsCantidad_RecibidaNull();
             }
	        }
        public Decimal Cantidad_Embarcada {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["Cantidad_Embarcada"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Cantidad_Embarcada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Cantidad_Embarcada = value;
               }
	          }
        public bool IsCantidad_EmbarcadaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsCantidad_EmbarcadaNull();
             }
	        }
        public Decimal Cantidad_Facturada {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["Cantidad_Facturada"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Cantidad_Facturada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Cantidad_Facturada = value;
               }
	          }
        public bool IsCantidad_FacturadaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsCantidad_FacturadaNull();
             }
	        }
        public DateTime Fecha_Entrega {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["Fecha_Entrega"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Fecha_Entrega;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Fecha_Entrega = value;
               }
	          }
        public bool IsFecha_EntregaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsFecha_EntregaNull();
             }
	        }
        public Decimal Precio {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["Precio"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Precio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Precio = value;
               }
	          }
        public bool IsPrecioNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsPrecioNull();
             }
	        }
        public Boolean Pendiente {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["Pendiente"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Pendiente;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Pendiente = value;
               }
	          }
        public bool IsPendienteNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsPendienteNull();
             }
	        }
        public Decimal Cantidad_Creditos {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["Cantidad_Creditos"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Cantidad_Creditos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Cantidad_Creditos = value;
               }
	          }
        public bool IsCantidad_CreditosNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsCantidad_CreditosNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String DescripcionUniMed {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["DescripcionUniMed"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].DescripcionUniMed;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].DescripcionUniMed = value;
               }
	          }
        public bool IsDescripcionUniMedNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsDescripcionUniMedNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Decimal CantidadConsignada {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["CantidadConsignada"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].CantidadConsignada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].CantidadConsignada = value;
               }
	          }
        public bool IsCantidadConsignadaNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsCantidadConsignadaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comOCArticuloDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comOCArticuloDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comOCArticuloDS );
     }
     public comOCArticuloActionExchange() : base( "comOCArticulo" ) {
     }

     public comOCArticuloActionExchange(comOCArticuloActionEnum.EnumcomOCArticuloAction pAccion) : base(comOCArticuloActionEnum.GetAccioncomOCArticuloAction(pAccion)) {
     }

     public comOCArticuloActionExchange(comOCArticuloActionEnum.EnumcomOCArticuloAction pAccion, ComprasCommon.comOCArticuloDS pdsParam) : base(comOCArticuloActionEnum.GetAccioncomOCArticuloAction(pAccion), pdsParam) {
     }

     public comOCArticuloActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comOCArticuloDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comOCArticuloDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comOCArticuloDS)mParam;
	        }
     }
  }
}
