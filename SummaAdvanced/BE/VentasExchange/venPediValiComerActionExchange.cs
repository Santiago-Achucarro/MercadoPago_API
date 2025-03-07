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
    public class venPediValiComerActionExchange : Framework.Core.Exchange{

        public Int32 venPedidos {
            get {
                if(((VentasCommon.venPediValiComerDS)mParam).Principal[0]["venPedidos"] != DBNull.Value  ){
                    return ((VentasCommon.venPediValiComerDS)mParam).Principal[0].venPedidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediValiComerDS)mParam).Principal[0].venPedidos = value;
               }
	          }
        public bool IsvenPedidosNull {
             get {
                 return mParam==null || ((VentasCommon.venPediValiComerDS)mParam).Principal[0].IsvenPedidosNull();
             }
	        }
        public Boolean MVendedor {
            get {
                if(((VentasCommon.venPediValiComerDS)mParam).Principal[0]["MVendedor"] != DBNull.Value  ){
                    return ((VentasCommon.venPediValiComerDS)mParam).Principal[0].MVendedor;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediValiComerDS)mParam).Principal[0].MVendedor = value;
               }
	          }
        public bool IsMVendedorNull {
             get {
                 return mParam==null || ((VentasCommon.venPediValiComerDS)mParam).Principal[0].IsMVendedorNull();
             }
	        }
        public Boolean MFormaE {
            get {
                if(((VentasCommon.venPediValiComerDS)mParam).Principal[0]["MFormaE"] != DBNull.Value  ){
                    return ((VentasCommon.venPediValiComerDS)mParam).Principal[0].MFormaE;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediValiComerDS)mParam).Principal[0].MFormaE = value;
               }
	          }
        public bool IsMFormaENull {
             get {
                 return mParam==null || ((VentasCommon.venPediValiComerDS)mParam).Principal[0].IsMFormaENull();
             }
	        }
        public Boolean MListaP {
            get {
                if(((VentasCommon.venPediValiComerDS)mParam).Principal[0]["MListaP"] != DBNull.Value  ){
                    return ((VentasCommon.venPediValiComerDS)mParam).Principal[0].MListaP;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediValiComerDS)mParam).Principal[0].MListaP = value;
               }
	          }
        public bool IsMListaPNull {
             get {
                 return mParam==null || ((VentasCommon.venPediValiComerDS)mParam).Principal[0].IsMListaPNull();
             }
	        }
        public Boolean MBonifDato {
            get {
                if(((VentasCommon.venPediValiComerDS)mParam).Principal[0]["MBonifDato"] != DBNull.Value  ){
                    return ((VentasCommon.venPediValiComerDS)mParam).Principal[0].MBonifDato;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediValiComerDS)mParam).Principal[0].MBonifDato = value;
               }
	          }
        public bool IsMBonifDatoNull {
             get {
                 return mParam==null || ((VentasCommon.venPediValiComerDS)mParam).Principal[0].IsMBonifDatoNull();
             }
	        }
        public Boolean MBonifReng {
            get {
                if(((VentasCommon.venPediValiComerDS)mParam).Principal[0]["MBonifReng"] != DBNull.Value  ){
                    return ((VentasCommon.venPediValiComerDS)mParam).Principal[0].MBonifReng;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediValiComerDS)mParam).Principal[0].MBonifReng = value;
               }
	          }
        public bool IsMBonifRengNull {
             get {
                 return mParam==null || ((VentasCommon.venPediValiComerDS)mParam).Principal[0].IsMBonifRengNull();
             }
	        }
        public Boolean MPrecioReng {
            get {
                if(((VentasCommon.venPediValiComerDS)mParam).Principal[0]["MPrecioReng"] != DBNull.Value  ){
                    return ((VentasCommon.venPediValiComerDS)mParam).Principal[0].MPrecioReng;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediValiComerDS)mParam).Principal[0].MPrecioReng = value;
               }
	          }
        public bool IsMPrecioRengNull {
             get {
                 return mParam==null || ((VentasCommon.venPediValiComerDS)mParam).Principal[0].IsMPrecioRengNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venPediValiComerDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venPediValiComerDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPediValiComerDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venPediValiComerDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venPediValiComerDS );
     }
     public venPediValiComerActionExchange() : base( "venPediValiComer" ) {
     }

     public venPediValiComerActionExchange(venPediValiComerActionEnum.EnumvenPediValiComerAction pAccion) : base(venPediValiComerActionEnum.GetAccionvenPediValiComerAction(pAccion)) {
     }

     public venPediValiComerActionExchange(venPediValiComerActionEnum.EnumvenPediValiComerAction pAccion, VentasCommon.venPediValiComerDS pdsParam) : base(venPediValiComerActionEnum.GetAccionvenPediValiComerAction(pAccion), pdsParam) {
     }

     public venPediValiComerActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venPediValiComerDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venPediValiComerDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venPediValiComerDS)mParam;
	        }
     }
  }
}
