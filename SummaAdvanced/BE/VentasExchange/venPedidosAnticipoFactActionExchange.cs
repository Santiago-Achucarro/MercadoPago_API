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
    public class venPedidosAnticipoFactActionExchange : Framework.Core.Exchange{

        public Int32 venPedidos {
            get {
                if(((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0]["venPedidos"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0].venPedidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0].venPedidos = value;
               }
	          }
        public bool IsvenPedidosNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0].IsvenPedidosNull();
             }
	        }
        public Decimal ImporteFac {
            get {
                if(((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0]["ImporteFac"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0].ImporteFac;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0].ImporteFac = value;
               }
	          }
        public bool IsImporteFacNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0].IsImporteFacNull();
             }
	        }
        public Decimal ImporteOriginalFac {
            get {
                if(((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0]["ImporteOriginalFac"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0].ImporteOriginalFac;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0].ImporteOriginalFac = value;
               }
	          }
        public bool IsImporteOriginalFacNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0].IsImporteOriginalFacNull();
             }
	        }
        public Decimal ImporteNC {
            get {
                if(((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0]["ImporteNC"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0].ImporteNC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0].ImporteNC = value;
               }
	          }
        public bool IsImporteNCNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0].IsImporteNCNull();
             }
	        }
        public Decimal ImporteOriginalNC {
            get {
                if(((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0]["ImporteOriginalNC"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0].ImporteOriginalNC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0].ImporteOriginalNC = value;
               }
	          }
        public bool IsImporteOriginalNCNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0].IsImporteOriginalNCNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnticipoFactDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venPedidosAnticipoFactDS );
     }
     public venPedidosAnticipoFactActionExchange() : base( "venPedidosAnticipoFact" ) {
     }

     public venPedidosAnticipoFactActionExchange(venPedidosAnticipoFactActionEnum.EnumvenPedidosAnticipoFactAction pAccion) : base(venPedidosAnticipoFactActionEnum.GetAccionvenPedidosAnticipoFactAction(pAccion)) {
     }

     public venPedidosAnticipoFactActionExchange(venPedidosAnticipoFactActionEnum.EnumvenPedidosAnticipoFactAction pAccion, VentasCommon.venPedidosAnticipoFactDS pdsParam) : base(venPedidosAnticipoFactActionEnum.GetAccionvenPedidosAnticipoFactAction(pAccion), pdsParam) {
     }

     public venPedidosAnticipoFactActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venPedidosAnticipoFactDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venPedidosAnticipoFactDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venPedidosAnticipoFactDS)mParam;
	        }
     }
  }
}
