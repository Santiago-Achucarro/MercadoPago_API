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
    public class venRepaPediActionExchange : Framework.Core.Exchange{

        public Int32 venReparto {
            get {
                if(((VentasCommon.venRepaPediDS)mParam).Principal[0]["venReparto"] != DBNull.Value  ){
                    return ((VentasCommon.venRepaPediDS)mParam).Principal[0].venReparto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepaPediDS)mParam).Principal[0].venReparto = value;
               }
	          }
        public bool IsvenRepartoNull {
             get {
                 return mParam==null || ((VentasCommon.venRepaPediDS)mParam).Principal[0].IsvenRepartoNull();
             }
	        }
        public Int32 Renglon_Rep {
            get {
                if(((VentasCommon.venRepaPediDS)mParam).Principal[0]["Renglon_Rep"] != DBNull.Value  ){
                    return ((VentasCommon.venRepaPediDS)mParam).Principal[0].Renglon_Rep;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepaPediDS)mParam).Principal[0].Renglon_Rep = value;
               }
	          }
        public bool IsRenglon_RepNull {
             get {
                 return mParam==null || ((VentasCommon.venRepaPediDS)mParam).Principal[0].IsRenglon_RepNull();
             }
	        }
        public Int32 venPedidos {
            get {
                if(((VentasCommon.venRepaPediDS)mParam).Principal[0]["venPedidos"] != DBNull.Value  ){
                    return ((VentasCommon.venRepaPediDS)mParam).Principal[0].venPedidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepaPediDS)mParam).Principal[0].venPedidos = value;
               }
	          }
        public bool IsvenPedidosNull {
             get {
                 return mParam==null || ((VentasCommon.venRepaPediDS)mParam).Principal[0].IsvenPedidosNull();
             }
	        }
        public Int32 Renglon_Pe {
            get {
                if(((VentasCommon.venRepaPediDS)mParam).Principal[0]["Renglon_Pe"] != DBNull.Value  ){
                    return ((VentasCommon.venRepaPediDS)mParam).Principal[0].Renglon_Pe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepaPediDS)mParam).Principal[0].Renglon_Pe = value;
               }
	          }
        public bool IsRenglon_PeNull {
             get {
                 return mParam==null || ((VentasCommon.venRepaPediDS)mParam).Principal[0].IsRenglon_PeNull();
             }
	        }
        public Decimal CantidadForm {
            get {
                if(((VentasCommon.venRepaPediDS)mParam).Principal[0]["CantidadForm"] != DBNull.Value  ){
                    return ((VentasCommon.venRepaPediDS)mParam).Principal[0].CantidadForm;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepaPediDS)mParam).Principal[0].CantidadForm = value;
               }
	          }
        public bool IsCantidadFormNull {
             get {
                 return mParam==null || ((VentasCommon.venRepaPediDS)mParam).Principal[0].IsCantidadFormNull();
             }
	        }
        public Decimal CantidadAlternaForm {
            get {
                if(((VentasCommon.venRepaPediDS)mParam).Principal[0]["CantidadAlternaForm"] != DBNull.Value  ){
                    return ((VentasCommon.venRepaPediDS)mParam).Principal[0].CantidadAlternaForm;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepaPediDS)mParam).Principal[0].CantidadAlternaForm = value;
               }
	          }
        public bool IsCantidadAlternaFormNull {
             get {
                 return mParam==null || ((VentasCommon.venRepaPediDS)mParam).Principal[0].IsCantidadAlternaFormNull();
             }
	        }
        public Boolean Remitido {
            get {
                if(((VentasCommon.venRepaPediDS)mParam).Principal[0]["Remitido"] != DBNull.Value  ){
                    return ((VentasCommon.venRepaPediDS)mParam).Principal[0].Remitido;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepaPediDS)mParam).Principal[0].Remitido = value;
               }
	          }
        public bool IsRemitidoNull {
             get {
                 return mParam==null || ((VentasCommon.venRepaPediDS)mParam).Principal[0].IsRemitidoNull();
             }
	        }
        public Boolean Facturado {
            get {
                if(((VentasCommon.venRepaPediDS)mParam).Principal[0]["Facturado"] != DBNull.Value  ){
                    return ((VentasCommon.venRepaPediDS)mParam).Principal[0].Facturado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepaPediDS)mParam).Principal[0].Facturado = value;
               }
	          }
        public bool IsFacturadoNull {
             get {
                 return mParam==null || ((VentasCommon.venRepaPediDS)mParam).Principal[0].IsFacturadoNull();
             }
	        }
        public Int32 RenglonFactura {
            get {
                if(((VentasCommon.venRepaPediDS)mParam).Principal[0]["RenglonFactura"] != DBNull.Value  ){
                    return ((VentasCommon.venRepaPediDS)mParam).Principal[0].RenglonFactura;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepaPediDS)mParam).Principal[0].RenglonFactura = value;
               }
	          }
        public bool IsRenglonFacturaNull {
             get {
                 return mParam==null || ((VentasCommon.venRepaPediDS)mParam).Principal[0].IsRenglonFacturaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venRepaPediDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venRepaPediDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepaPediDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venRepaPediDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venRepaPediDS );
     }
     public venRepaPediActionExchange() : base( "venRepaPedi" ) {
     }

     public venRepaPediActionExchange(venRepaPediActionEnum.EnumvenRepaPediAction pAccion) : base(venRepaPediActionEnum.GetAccionvenRepaPediAction(pAccion)) {
     }

     public venRepaPediActionExchange(venRepaPediActionEnum.EnumvenRepaPediAction pAccion, VentasCommon.venRepaPediDS pdsParam) : base(venRepaPediActionEnum.GetAccionvenRepaPediAction(pAccion), pdsParam) {
     }

     public venRepaPediActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venRepaPediDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venRepaPediActionExchange(VentasCommon.venRepaPediDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venRepaPediDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venRepaPediDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venRepaPediDS)mParam;
	        }
     }
  }
}
