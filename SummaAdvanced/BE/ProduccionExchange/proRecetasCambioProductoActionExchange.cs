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
    public class proRecetasCambioProductoActionExchange : Framework.Core.Exchange{

        public String ProductoOriginal {
            get {
                if(((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0]["ProductoOriginal"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0].ProductoOriginal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0].ProductoOriginal = value;
               }
	          }
        public bool IsProductoOriginalNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0].IsProductoOriginalNull();
             }
	        }
        public String DescripcionProdOrig {
            get {
                if(((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0]["DescripcionProdOrig"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0].DescripcionProdOrig;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0].DescripcionProdOrig = value;
               }
	          }
        public bool IsDescripcionProdOrigNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0].IsDescripcionProdOrigNull();
             }
	        }
        public String ProductoNuevo {
            get {
                if(((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0]["ProductoNuevo"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0].ProductoNuevo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0].ProductoNuevo = value;
               }
	          }
        public bool IsProductoNuevoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0].IsProductoNuevoNull();
             }
	        }
        public String DescripcionProdNuevo {
            get {
                if(((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0]["DescripcionProdNuevo"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0].DescripcionProdNuevo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0].DescripcionProdNuevo = value;
               }
	          }
        public bool IsDescripcionProdNuevoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0].IsDescripcionProdNuevoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proRecetasCambioProductoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proRecetasCambioProductoDS );
     }
     public proRecetasCambioProductoActionExchange() : base( "proRecetasCambioProducto" ) {
     }

     public proRecetasCambioProductoActionExchange(proRecetasCambioProductoActionEnum.EnumproRecetasCambioProductoAction pAccion) : base(proRecetasCambioProductoActionEnum.GetAccionproRecetasCambioProductoAction(pAccion)) {
     }

     public proRecetasCambioProductoActionExchange(proRecetasCambioProductoActionEnum.EnumproRecetasCambioProductoAction pAccion, ProduccionCommon.proRecetasCambioProductoDS pdsParam) : base(proRecetasCambioProductoActionEnum.GetAccionproRecetasCambioProductoAction(pAccion), pdsParam) {
     }

     public proRecetasCambioProductoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proRecetasCambioProductoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proRecetasCambioProductoDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proRecetasCambioProductoDS)mParam;
	        }
     }
  }
}
