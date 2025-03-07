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
    public class venPediRemitidosDatosCancActionExchange : Framework.Core.Exchange{

        public Int32 venPedidos {
            get {
                if(((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0]["venPedidos"] != DBNull.Value  ){
                    return ((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0].venPedidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0].venPedidos = value;
               }
	          }
        public bool IsvenPedidosNull {
             get {
                 return mParam==null || ((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0].IsvenPedidosNull();
             }
	        }
        public Int32 Renglon_Pe {
            get {
                if(((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0]["Renglon_Pe"] != DBNull.Value  ){
                    return ((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0].Renglon_Pe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0].Renglon_Pe = value;
               }
	          }
        public bool IsRenglon_PeNull {
             get {
                 return mParam==null || ((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0].IsRenglon_PeNull();
             }
	        }
        public Int64 stkMoviCabe {
            get {
                if(((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venPediRemitidosDatosCancDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venPediRemitidosDatosCancDS );
     }
     public venPediRemitidosDatosCancActionExchange() : base( "venPediRemitidosDatosCanc" ) {
     }

     public venPediRemitidosDatosCancActionExchange(venPediRemitidosDatosCancActionEnum.EnumvenPediRemitidosDatosCancAction pAccion) : base(venPediRemitidosDatosCancActionEnum.GetAccionvenPediRemitidosDatosCancAction(pAccion)) {
     }

     public venPediRemitidosDatosCancActionExchange(venPediRemitidosDatosCancActionEnum.EnumvenPediRemitidosDatosCancAction pAccion, VentasCommon.venPediRemitidosDatosCancDS pdsParam) : base(venPediRemitidosDatosCancActionEnum.GetAccionvenPediRemitidosDatosCancAction(pAccion), pdsParam) {
     }

     public venPediRemitidosDatosCancActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venPediRemitidosDatosCancDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venPediRemitidosDatosCancDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venPediRemitidosDatosCancDS)mParam;
	        }
     }
  }
}
