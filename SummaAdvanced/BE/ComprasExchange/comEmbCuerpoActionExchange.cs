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
    public class comEmbCuerpoActionExchange : Framework.Core.Exchange{

        public Int64 comEmbarques {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["comEmbarques"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].comEmbarques;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].comEmbarques = value;
               }
	          }
        public bool IscomEmbarquesNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IscomEmbarquesNull();
             }
	        }
        public Int32 comOrdenComp {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["comOrdenComp"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].comOrdenComp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].comOrdenComp = value;
               }
	          }
        public bool IscomOrdenCompNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IscomOrdenCompNull();
             }
	        }
        public Int32 Renglon_OC {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["Renglon_OC"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].Renglon_OC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].Renglon_OC = value;
               }
	          }
        public bool IsRenglon_OCNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsRenglon_OCNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProductos {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["DescripcionProductos"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].DescripcionProductos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].DescripcionProductos = value;
               }
	          }
        public bool IsDescripcionProductosNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsDescripcionProductosNull();
             }
	        }
        public Decimal Factor {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["Factor"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].Factor;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].Factor = value;
               }
	          }
        public bool IsFactorNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsFactorNull();
             }
	        }
        public Decimal CantidadOcOriginal {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["CantidadOcOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].CantidadOcOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].CantidadOcOriginal = value;
               }
	          }
        public bool IsCantidadOcOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsCantidadOcOriginalNull();
             }
	        }
        public Decimal PrecioOcOriginal {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["PrecioOcOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].PrecioOcOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].PrecioOcOriginal = value;
               }
	          }
        public bool IsPrecioOcOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsPrecioOcOriginalNull();
             }
	        }
        public Decimal PrecioOc {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["PrecioOc"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].PrecioOc;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].PrecioOc = value;
               }
	          }
        public bool IsPrecioOcNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsPrecioOcNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDepositos {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["DescripcionDepositos"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].DescripcionDepositos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].DescripcionDepositos = value;
               }
	          }
        public bool IsDescripcionDepositosNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsDescripcionDepositosNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal CantidadOriginal {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["CantidadOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].CantidadOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].CantidadOriginal = value;
               }
	          }
        public bool IsCantidadOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsCantidadOriginalNull();
             }
	        }
        public Decimal CantidadRecibida {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["CantidadRecibida"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].CantidadRecibida;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].CantidadRecibida = value;
               }
	          }
        public bool IsCantidadRecibidaNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsCantidadRecibidaNull();
             }
	        }
        public Decimal CantidadFacturada {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["CantidadFacturada"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].CantidadFacturada;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].CantidadFacturada = value;
               }
	          }
        public bool IsCantidadFacturadaNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsCantidadFacturadaNull();
             }
	        }
        public Decimal PrecioCalculadoOriginal {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["PrecioCalculadoOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].PrecioCalculadoOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].PrecioCalculadoOriginal = value;
               }
	          }
        public bool IsPrecioCalculadoOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsPrecioCalculadoOriginalNull();
             }
	        }
        public Decimal PrecioCalculado {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["PrecioCalculado"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].PrecioCalculado;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].PrecioCalculado = value;
               }
	          }
        public bool IsPrecioCalculadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsPrecioCalculadoNull();
             }
	        }
        public Int32 RenglonDebe {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["RenglonDebe"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].RenglonDebe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].RenglonDebe = value;
               }
	          }
        public bool IsRenglonDebeNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsRenglonDebeNull();
             }
	        }
        public Int32 RenglonHaber {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["RenglonHaber"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].RenglonHaber;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].RenglonHaber = value;
               }
	          }
        public bool IsRenglonHaberNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsRenglonHaberNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbCuerpoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comEmbCuerpoDS );
     }
     public comEmbCuerpoActionExchange() : base( "comEmbCuerpo" ) {
     }

     public comEmbCuerpoActionExchange(comEmbCuerpoActionEnum.EnumcomEmbCuerpoAction pAccion) : base(comEmbCuerpoActionEnum.GetAccioncomEmbCuerpoAction(pAccion)) {
     }

     public comEmbCuerpoActionExchange(comEmbCuerpoActionEnum.EnumcomEmbCuerpoAction pAccion, ComprasCommon.comEmbCuerpoDS pdsParam) : base(comEmbCuerpoActionEnum.GetAccioncomEmbCuerpoAction(pAccion), pdsParam) {
     }

     public comEmbCuerpoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comEmbCuerpoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comEmbCuerpoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comEmbCuerpoDS)mParam;
	        }
     }
  }
}
