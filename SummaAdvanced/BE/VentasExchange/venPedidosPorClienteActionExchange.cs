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
    public class venPedidosPorClienteActionExchange : Framework.Core.Exchange{

        public String Cliente_Id {
            get {
                if(((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public Boolean Historico {
            get {
                if(((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0]["Historico"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0].Historico;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0].Historico = value;
               }
	          }
        public bool IsHistoricoNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0].IsHistoricoNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosPorClienteDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venPedidosPorClienteDS );
     }
     public venPedidosPorClienteActionExchange() : base( "venPedidosPorCliente" ) {
     }

     public venPedidosPorClienteActionExchange(venPedidosPorClienteActionEnum.EnumvenPedidosPorClienteAction pAccion) : base(venPedidosPorClienteActionEnum.GetAccionvenPedidosPorClienteAction(pAccion)) {
     }

     public venPedidosPorClienteActionExchange(venPedidosPorClienteActionEnum.EnumvenPedidosPorClienteAction pAccion, VentasCommon.venPedidosPorClienteDS pdsParam) : base(venPedidosPorClienteActionEnum.GetAccionvenPedidosPorClienteAction(pAccion), pdsParam) {
     }

     public venPedidosPorClienteActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venPedidosPorClienteDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venPedidosPorClienteDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venPedidosPorClienteDS)mParam;
	        }
     }
  }
}
