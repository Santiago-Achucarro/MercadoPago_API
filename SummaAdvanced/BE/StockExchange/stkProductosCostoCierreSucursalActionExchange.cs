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
    public class stkProductosCostoCierreSucursalActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Sucursal {
            get {
                if(((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String DescripcionSucursalesEmpr {
            get {
                if(((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0]["DescripcionSucursalesEmpr"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].DescripcionSucursalesEmpr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].DescripcionSucursalesEmpr = value;
               }
	          }
        public bool IsDescripcionSucursalesEmprNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].IsDescripcionSucursalesEmprNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProductos {
            get {
                if(((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0]["DescripcionProductos"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].DescripcionProductos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].DescripcionProductos = value;
               }
	          }
        public bool IsDescripcionProductosNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].IsDescripcionProductosNull();
             }
	        }
        public Decimal Costo {
            get {
                if(((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0]["Costo"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].Costo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].Costo = value;
               }
	          }
        public bool IsCostoNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].IsCostoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosCostoCierreSucursalDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkProductosCostoCierreSucursalDS );
     }
     public stkProductosCostoCierreSucursalActionExchange() : base( "stkProductosCostoCierreSucursal" ) {
     }

     public stkProductosCostoCierreSucursalActionExchange(stkProductosCostoCierreSucursalActionEnum.EnumstkProductosCostoCierreSucursalAction pAccion) : base(stkProductosCostoCierreSucursalActionEnum.GetAccionstkProductosCostoCierreSucursalAction(pAccion)) {
     }

     public stkProductosCostoCierreSucursalActionExchange(stkProductosCostoCierreSucursalActionEnum.EnumstkProductosCostoCierreSucursalAction pAccion, StockCommon.stkProductosCostoCierreSucursalDS pdsParam) : base(stkProductosCostoCierreSucursalActionEnum.GetAccionstkProductosCostoCierreSucursalAction(pAccion), pdsParam) {
     }

     public stkProductosCostoCierreSucursalActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkProductosCostoCierreSucursalDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkProductosCostoCierreSucursalDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkProductosCostoCierreSucursalDS)mParam;
	        }
     }
  }
}
