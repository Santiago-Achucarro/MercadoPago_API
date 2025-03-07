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
    public class venListasPrecProdActionExchange : Framework.Core.Exchange{

        public Int32 venListasPrecios {
            get {
                if(((VentasCommon.venListasPrecProdDS)mParam).Principal[0]["venListasPrecios"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].venListasPrecios;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].venListasPrecios = value;
               }
	          }
        public bool IsvenListasPreciosNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].IsvenListasPreciosNull();
             }
	        }
        public String ListaPrecio_Id {
            get {
                if(((VentasCommon.venListasPrecProdDS)mParam).Principal[0]["ListaPrecio_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].ListaPrecio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].ListaPrecio_Id = value;
               }
	          }
        public bool IsListaPrecio_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].IsListaPrecio_IdNull();
             }
	        }
        public String DescripcionListasPrecios {
            get {
                if(((VentasCommon.venListasPrecProdDS)mParam).Principal[0]["DescripcionListasPrecios"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].DescripcionListasPrecios;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].DescripcionListasPrecios = value;
               }
	          }
        public bool IsDescripcionListasPreciosNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].IsDescripcionListasPreciosNull();
             }
	        }
        public Int32 Version {
            get {
                if(((VentasCommon.venListasPrecProdDS)mParam).Principal[0]["Version"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].Version;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].Version = value;
               }
	          }
        public bool IsVersionNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].IsVersionNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.venListasPrecProdDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Producto_Id {
            get {
                if(((VentasCommon.venListasPrecProdDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProductos {
            get {
                if(((VentasCommon.venListasPrecProdDS)mParam).Principal[0]["DescripcionProductos"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].DescripcionProductos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].DescripcionProductos = value;
               }
	          }
        public bool IsDescripcionProductosNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].IsDescripcionProductosNull();
             }
	        }
        public Decimal PrecioLista {
            get {
                if(((VentasCommon.venListasPrecProdDS)mParam).Principal[0]["PrecioLista"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].PrecioLista;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].PrecioLista = value;
               }
	          }
        public bool IsPrecioListaNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].IsPrecioListaNull();
             }
	        }
        public Decimal PrecioPromocion {
            get {
                if(((VentasCommon.venListasPrecProdDS)mParam).Principal[0]["PrecioPromocion"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].PrecioPromocion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].PrecioPromocion = value;
               }
	          }
        public bool IsPrecioPromocionNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].IsPrecioPromocionNull();
             }
	        }
        public Boolean AdmiteRegalo {
            get {
                if(((VentasCommon.venListasPrecProdDS)mParam).Principal[0]["AdmiteRegalo"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].AdmiteRegalo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].AdmiteRegalo = value;
               }
	          }
        public bool IsAdmiteRegaloNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].IsAdmiteRegaloNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venListasPrecProdDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecProdDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venListasPrecProdDS );
     }
     public venListasPrecProdActionExchange() : base( "venListasPrecProd" ) {
     }

     public venListasPrecProdActionExchange(venListasPrecProdActionEnum.EnumvenListasPrecProdAction pAccion) : base(venListasPrecProdActionEnum.GetAccionvenListasPrecProdAction(pAccion)) {
     }

     public venListasPrecProdActionExchange(venListasPrecProdActionEnum.EnumvenListasPrecProdAction pAccion, VentasCommon.venListasPrecProdDS pdsParam) : base(venListasPrecProdActionEnum.GetAccionvenListasPrecProdAction(pAccion), pdsParam) {
     }

     public venListasPrecProdActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venListasPrecProdDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venListasPrecProdDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venListasPrecProdDS)mParam;
	        }
     }
  }
}
