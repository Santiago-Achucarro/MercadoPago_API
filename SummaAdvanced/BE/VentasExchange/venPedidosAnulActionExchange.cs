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
    public class venPedidosAnulActionExchange : Framework.Core.Exchange{

        public Int32 venPedidos {
            get {
                if(((VentasCommon.venPedidosAnulDS)mParam).Principal[0]["venPedidos"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnulDS)mParam).Principal[0].venPedidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnulDS)mParam).Principal[0].venPedidos = value;
               }
	          }
        public bool IsvenPedidosNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnulDS)mParam).Principal[0].IsvenPedidosNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.venPedidosAnulDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnulDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnulDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnulDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Operacion {
            get {
                if(((VentasCommon.venPedidosAnulDS)mParam).Principal[0]["Operacion"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnulDS)mParam).Principal[0].Operacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnulDS)mParam).Principal[0].Operacion = value;
               }
	          }
        public bool IsOperacionNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnulDS)mParam).Principal[0].IsOperacionNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venPedidosAnulDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnulDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnulDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnulDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venPedidosAnulDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnulDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnulDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnulDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venPedidosAnulDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venPedidosAnulDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPedidosAnulDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venPedidosAnulDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venPedidosAnulDS );
     }
     public venPedidosAnulActionExchange() : base( "venPedidosAnul" ) {
     }

     public venPedidosAnulActionExchange(venPedidosAnulActionEnum.EnumvenPedidosAnulAction pAccion) : base(venPedidosAnulActionEnum.GetAccionvenPedidosAnulAction(pAccion)) {
     }

     public venPedidosAnulActionExchange(venPedidosAnulActionEnum.EnumvenPedidosAnulAction pAccion, VentasCommon.venPedidosAnulDS pdsParam) : base(venPedidosAnulActionEnum.GetAccionvenPedidosAnulAction(pAccion), pdsParam) {
     }

     public venPedidosAnulActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venPedidosAnulDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venPedidosAnulDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venPedidosAnulDS)mParam;
	        }
     }
  }
}
