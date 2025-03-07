using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace StockExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class stkProductosCostosSucursalActionExchange : Framework.Core.Exchange{

        public String Sucursal {
            get {
                if(((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String DescripcionSucursalesEmpr {
            get {
                if(((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0]["DescripcionSucursalesEmpr"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].DescripcionSucursalesEmpr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].DescripcionSucursalesEmpr = value;
               }
	          }
        public bool IsDescripcionSucursalesEmprNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].IsDescripcionSucursalesEmprNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProductos {
            get {
                if(((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0]["DescripcionProductos"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].DescripcionProductos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].DescripcionProductos = value;
               }
	          }
        public bool IsDescripcionProductosNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].IsDescripcionProductosNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public Decimal CostoPromPond {
            get {
                if(((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0]["CostoPromPond"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].CostoPromPond;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].CostoPromPond = value;
               }
	          }
        public bool IsCostoPromPondNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].IsCostoPromPondNull();
             }
	        }
        public Decimal CostoUltCompra {
            get {
                if(((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0]["CostoUltCompra"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].CostoUltCompra;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].CostoUltCompra = value;
               }
	          }
        public bool IsCostoUltCompraNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].IsCostoUltCompraNull();
             }
	        }
        public Decimal CostoStandard {
            get {
                if(((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0]["CostoStandard"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].CostoStandard;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].CostoStandard = value;
               }
	          }
        public bool IsCostoStandardNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].IsCostoStandardNull();
             }
	        }
        public DateTime FechaUltModif {
            get {
                if(((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0]["FechaUltModif"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].FechaUltModif;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].FechaUltModif = value;
               }
	          }
        public bool IsFechaUltModifNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].IsFechaUltModifNull();
             }
	        }
        public Decimal PrecioUltCompra {
            get {
                if(((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0]["PrecioUltCompra"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].PrecioUltCompra;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].PrecioUltCompra = value;
               }
	          }
        public bool IsPrecioUltCompraNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].IsPrecioUltCompraNull();
             }
	        }
        public DateTime Fecha_Ult_Compra {
            get {
                if(((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0]["Fecha_Ult_Compra"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].Fecha_Ult_Compra;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].Fecha_Ult_Compra = value;
               }
	          }
        public bool IsFecha_Ult_CompraNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].IsFecha_Ult_CompraNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostosSucursalDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkProductosCostosSucursalDS );
     }
     public stkProductosCostosSucursalActionExchange() : base( "stkProductosCostosSucursal" ) {
     }

     public stkProductosCostosSucursalActionExchange(stkProductosCostosSucursalActionEnum.EnumstkProductosCostosSucursalAction pAccion) : base(stkProductosCostosSucursalActionEnum.GetAccionstkProductosCostosSucursalAction(pAccion)) {
     }

     public stkProductosCostosSucursalActionExchange(stkProductosCostosSucursalActionEnum.EnumstkProductosCostosSucursalAction pAccion, StockCommon.stkProductosCostosSucursalDS pdsParam) : base(stkProductosCostosSucursalActionEnum.GetAccionstkProductosCostosSucursalAction(pAccion), pdsParam) {
     }

     public stkProductosCostosSucursalActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkProductosCostosSucursalDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkProductosCostosSucursalDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkProductosCostosSucursalDS)mParam;
	        }
     }
  }
}
