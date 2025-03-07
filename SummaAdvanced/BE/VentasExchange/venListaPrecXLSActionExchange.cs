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
    public class venListaPrecXLSActionExchange : Framework.Core.Exchange{

        public String ListaDesde {
            get {
                if(((VentasCommon.venListaPrecXLSDS)mParam).Principal[0]["ListaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].ListaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].ListaDesde = value;
               }
	          }
        public bool IsListaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].IsListaDesdeNull();
             }
	        }
        public String ListaHasta {
            get {
                if(((VentasCommon.venListaPrecXLSDS)mParam).Principal[0]["ListaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].ListaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].ListaHasta = value;
               }
	          }
        public bool IsListaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].IsListaHastaNull();
             }
	        }
        public String Upload {
            get {
                if(((VentasCommon.venListaPrecXLSDS)mParam).Principal[0]["Upload"] != DBNull.Value  ){
                    return ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].Upload;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].Upload = value;
               }
	          }
        public bool IsUploadNull {
             get {
                 return mParam==null || ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].IsUploadNull();
             }
	        }
        public String ProductoDesde {
            get {
                if(((VentasCommon.venListaPrecXLSDS)mParam).Principal[0]["ProductoDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].ProductoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].ProductoDesde = value;
               }
	          }
        public bool IsProductoDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].IsProductoDesdeNull();
             }
	        }
        public String ProductoHasta {
            get {
                if(((VentasCommon.venListaPrecXLSDS)mParam).Principal[0]["ProductoHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].ProductoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].ProductoHasta = value;
               }
	          }
        public bool IsProductoHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].IsProductoHastaNull();
             }
	        }
        public Boolean EliminaExistentes {
            get {
                if(((VentasCommon.venListaPrecXLSDS)mParam).Principal[0]["EliminaExistentes"] != DBNull.Value  ){
                    return ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].EliminaExistentes;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].EliminaExistentes = value;
               }
	          }
        public bool IsEliminaExistentesNull {
             get {
                 return mParam==null || ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].IsEliminaExistentesNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.venListaPrecXLSDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venListaPrecXLSDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venListaPrecXLSDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venListaPrecXLSDS );
     }
     public venListaPrecXLSActionExchange() : base( "venListaPrecXLS" ) {
     }

     public venListaPrecXLSActionExchange(venListaPrecXLSActionEnum.EnumvenListaPrecXLSAction pAccion) : base(venListaPrecXLSActionEnum.GetAccionvenListaPrecXLSAction(pAccion)) {
     }

     public venListaPrecXLSActionExchange(venListaPrecXLSActionEnum.EnumvenListaPrecXLSAction pAccion, VentasCommon.venListaPrecXLSDS pdsParam) : base(venListaPrecXLSActionEnum.GetAccionvenListaPrecXLSAction(pAccion), pdsParam) {
     }

     public venListaPrecXLSActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venListaPrecXLSDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venListaPrecXLSDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venListaPrecXLSDS)mParam;
	        }
     }
  }
}
