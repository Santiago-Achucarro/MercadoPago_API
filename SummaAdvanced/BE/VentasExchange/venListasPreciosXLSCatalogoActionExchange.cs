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
    public class venListasPreciosXLSCatalogoActionExchange : Framework.Core.Exchange{

        public String ListaDesde {
            get {
                if(((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0]["ListaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0].ListaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0].ListaDesde = value;
               }
	          }
        public bool IsListaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0].IsListaDesdeNull();
             }
	        }
        public String ListaHasta {
            get {
                if(((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0]["ListaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0].ListaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0].ListaHasta = value;
               }
	          }
        public bool IsListaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0].IsListaHastaNull();
             }
	        }
        public String ProductoDesde {
            get {
                if(((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0]["ProductoDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0].ProductoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0].ProductoDesde = value;
               }
	          }
        public bool IsProductoDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0].IsProductoDesdeNull();
             }
	        }
        public String ProductoHasta {
            get {
                if(((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0]["ProductoHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0].ProductoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0].ProductoHasta = value;
               }
	          }
        public bool IsProductoHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0].IsProductoHastaNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPreciosXLSCatalogoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venListasPreciosXLSCatalogoDS );
     }
     public venListasPreciosXLSCatalogoActionExchange() : base( "venListasPreciosXLSCatalogo" ) {
     }

     public venListasPreciosXLSCatalogoActionExchange(venListasPreciosXLSCatalogoActionEnum.EnumvenListasPreciosXLSCatalogoAction pAccion) : base(venListasPreciosXLSCatalogoActionEnum.GetAccionvenListasPreciosXLSCatalogoAction(pAccion)) {
     }

     public venListasPreciosXLSCatalogoActionExchange(venListasPreciosXLSCatalogoActionEnum.EnumvenListasPreciosXLSCatalogoAction pAccion, VentasCommon.venListasPreciosXLSCatalogoDS pdsParam) : base(venListasPreciosXLSCatalogoActionEnum.GetAccionvenListasPreciosXLSCatalogoAction(pAccion), pdsParam) {
     }

     public venListasPreciosXLSCatalogoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venListasPreciosXLSCatalogoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venListasPreciosXLSCatalogoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venListasPreciosXLSCatalogoDS)mParam;
	        }
     }
  }
}
