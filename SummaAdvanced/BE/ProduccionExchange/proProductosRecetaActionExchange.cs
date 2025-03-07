using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ProduccionExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class proProductosRecetaActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String DescripcionProductos {
            get {
                if(((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0]["DescripcionProductos"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0].DescripcionProductos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0].DescripcionProductos = value;
               }
	          }
        public bool IsDescripcionProductosNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0].IsDescripcionProductosNull();
             }
	        }
        public String Receta_Id {
            get {
                if(((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0]["Receta_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0].Receta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0].Receta_Id = value;
               }
	          }
        public bool IsReceta_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0].IsReceta_IdNull();
             }
	        }
        public String DescripcionReceta {
            get {
                if(((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0]["DescripcionReceta"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0].DescripcionReceta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0].DescripcionReceta = value;
               }
	          }
        public bool IsDescripcionRecetaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0].IsDescripcionRecetaNull();
             }
	        }
        public Boolean Principal {
            get {
                if(((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0]["Principal"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0].Principal;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0].Principal = value;
               }
	          }
        public bool IsPrincipalNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0].IsPrincipalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProductosRecetaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proProductosRecetaDS );
     }
     public proProductosRecetaActionExchange() : base( "proProductosReceta" ) {
     }

     public proProductosRecetaActionExchange(proProductosRecetaActionEnum.EnumproProductosRecetaAction pAccion) : base(proProductosRecetaActionEnum.GetAccionproProductosRecetaAction(pAccion)) {
     }

     public proProductosRecetaActionExchange(proProductosRecetaActionEnum.EnumproProductosRecetaAction pAccion, ProduccionCommon.proProductosRecetaDS pdsParam) : base(proProductosRecetaActionEnum.GetAccionproProductosRecetaAction(pAccion), pdsParam) {
     }

     public proProductosRecetaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proProductosRecetaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proProductosRecetaDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proProductosRecetaDS)mParam;
	        }
     }
  }
}
