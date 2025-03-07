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
    public class venPediRemitidosActionExchange : Framework.Core.Exchange{

        public Int32 venPedidos {
            get {
                if(((VentasCommon.venPediRemitidosDS)mParam).Principal[0]["venPedidos"] != DBNull.Value  ){
                    return ((VentasCommon.venPediRemitidosDS)mParam).Principal[0].venPedidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediRemitidosDS)mParam).Principal[0].venPedidos = value;
               }
	          }
        public bool IsvenPedidosNull {
             get {
                 return mParam==null || ((VentasCommon.venPediRemitidosDS)mParam).Principal[0].IsvenPedidosNull();
             }
	        }
        public Int32 Renglon_Pe {
            get {
                if(((VentasCommon.venPediRemitidosDS)mParam).Principal[0]["Renglon_Pe"] != DBNull.Value  ){
                    return ((VentasCommon.venPediRemitidosDS)mParam).Principal[0].Renglon_Pe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediRemitidosDS)mParam).Principal[0].Renglon_Pe = value;
               }
	          }
        public bool IsRenglon_PeNull {
             get {
                 return mParam==null || ((VentasCommon.venPediRemitidosDS)mParam).Principal[0].IsRenglon_PeNull();
             }
	        }
        public Int64 stkMoviCabe {
            get {
                if(((VentasCommon.venPediRemitidosDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((VentasCommon.venPediRemitidosDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediRemitidosDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((VentasCommon.venPediRemitidosDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((VentasCommon.venPediRemitidosDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((VentasCommon.venPediRemitidosDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediRemitidosDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((VentasCommon.venPediRemitidosDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public Int32 venReparto {
            get {
                if(((VentasCommon.venPediRemitidosDS)mParam).Principal[0]["venReparto"] != DBNull.Value  ){
                    return ((VentasCommon.venPediRemitidosDS)mParam).Principal[0].venReparto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediRemitidosDS)mParam).Principal[0].venReparto = value;
               }
	          }
        public bool IsvenRepartoNull {
             get {
                 return mParam==null || ((VentasCommon.venPediRemitidosDS)mParam).Principal[0].IsvenRepartoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venPediRemitidosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venPediRemitidosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediRemitidosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venPediRemitidosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venPediRemitidosDS );
     }
     public venPediRemitidosActionExchange() : base( "venPediRemitidos" ) {
     }

     public venPediRemitidosActionExchange(venPediRemitidosActionEnum.EnumvenPediRemitidosAction pAccion) : base(venPediRemitidosActionEnum.GetAccionvenPediRemitidosAction(pAccion)) {
     }

     public venPediRemitidosActionExchange(venPediRemitidosActionEnum.EnumvenPediRemitidosAction pAccion, VentasCommon.venPediRemitidosDS pdsParam) : base(venPediRemitidosActionEnum.GetAccionvenPediRemitidosAction(pAccion), pdsParam) {
     }

     public venPediRemitidosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venPediRemitidosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venPediRemitidosDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venPediRemitidosDS)mParam;
	        }
     }
  }
}
