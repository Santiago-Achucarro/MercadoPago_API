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
    public class venRepaPediSerieActionExchange : Framework.Core.Exchange{

        public Int32 venReparto {
            get {
                if(((VentasCommon.venRepaPediSerieDS)mParam).Principal[0]["venReparto"] != DBNull.Value  ){
                    return ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].venReparto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].venReparto = value;
               }
	          }
        public bool IsvenRepartoNull {
             get {
                 return mParam==null || ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].IsvenRepartoNull();
             }
	        }
        public Int32 Renglon_Rep {
            get {
                if(((VentasCommon.venRepaPediSerieDS)mParam).Principal[0]["Renglon_Rep"] != DBNull.Value  ){
                    return ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].Renglon_Rep;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].Renglon_Rep = value;
               }
	          }
        public bool IsRenglon_RepNull {
             get {
                 return mParam==null || ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].IsRenglon_RepNull();
             }
	        }
        public Int32 venPedidos {
            get {
                if(((VentasCommon.venRepaPediSerieDS)mParam).Principal[0]["venPedidos"] != DBNull.Value  ){
                    return ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].venPedidos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].venPedidos = value;
               }
	          }
        public bool IsvenPedidosNull {
             get {
                 return mParam==null || ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].IsvenPedidosNull();
             }
	        }
        public Int32 Renglon_Pe {
            get {
                if(((VentasCommon.venRepaPediSerieDS)mParam).Principal[0]["Renglon_Pe"] != DBNull.Value  ){
                    return ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].Renglon_Pe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].Renglon_Pe = value;
               }
	          }
        public bool IsRenglon_PeNull {
             get {
                 return mParam==null || ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].IsRenglon_PeNull();
             }
	        }
        public String Serie {
            get {
                if(((VentasCommon.venRepaPediSerieDS)mParam).Principal[0]["Serie"] != DBNull.Value  ){
                    return ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].Serie;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].Serie = value;
               }
	          }
        public bool IsSerieNull {
             get {
                 return mParam==null || ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].IsSerieNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((VentasCommon.venRepaPediSerieDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public DateTime Vencimiento {
            get {
                if(((VentasCommon.venRepaPediSerieDS)mParam).Principal[0]["Vencimiento"] != DBNull.Value  ){
                    return ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].Vencimiento;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].Vencimiento = value;
               }
	          }
        public bool IsVencimientoNull {
             get {
                 return mParam==null || ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].IsVencimientoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venRepaPediSerieDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venRepaPediSerieDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venRepaPediSerieDS );
     }
     public venRepaPediSerieActionExchange() : base( "venRepaPediSerie" ) {
     }

     public venRepaPediSerieActionExchange(venRepaPediSerieActionEnum.EnumvenRepaPediSerieAction pAccion) : base(venRepaPediSerieActionEnum.GetAccionvenRepaPediSerieAction(pAccion)) {
     }

     public venRepaPediSerieActionExchange(venRepaPediSerieActionEnum.EnumvenRepaPediSerieAction pAccion, VentasCommon.venRepaPediSerieDS pdsParam) : base(venRepaPediSerieActionEnum.GetAccionvenRepaPediSerieAction(pAccion), pdsParam) {
     }

     public venRepaPediSerieActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venRepaPediSerieDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venRepaPediSerieDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venRepaPediSerieDS)mParam;
	        }
     }
  }
}
