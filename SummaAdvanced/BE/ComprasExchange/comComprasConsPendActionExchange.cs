using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comComprasConsPendActionExchange : Framework.Core.Exchange{

        public String Producto_Id {
            get {
                if(((ComprasCommon.comComprasConsPendDS)mParam).Principal[0]["Producto_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comComprasConsPendDS)mParam).Principal[0].Producto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comComprasConsPendDS)mParam).Principal[0].Producto_Id = value;
               }
	          }
        public bool IsProducto_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comComprasConsPendDS)mParam).Principal[0].IsProducto_IdNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((ComprasCommon.comComprasConsPendDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comComprasConsPendDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comComprasConsPendDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comComprasConsPendDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comComprasConsPendDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comComprasConsPendDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comComprasConsPendDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comComprasConsPendDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comComprasConsPendDS );
     }
     public comComprasConsPendActionExchange() : base( "comComprasConsPend" ) {
     }

     public comComprasConsPendActionExchange(comComprasConsPendActionEnum.EnumcomComprasConsPendAction pAccion) : base(comComprasConsPendActionEnum.GetAccioncomComprasConsPendAction(pAccion)) {
     }

     public comComprasConsPendActionExchange(comComprasConsPendActionEnum.EnumcomComprasConsPendAction pAccion, ComprasCommon.comComprasConsPendDS pdsParam) : base(comComprasConsPendActionEnum.GetAccioncomComprasConsPendAction(pAccion), pdsParam) {
     }

     public comComprasConsPendActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comComprasConsPendDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comComprasConsPendDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comComprasConsPendDS)mParam;
	        }
     }
  }
}
