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
    public class venSTMAfipActionExchange : Framework.Core.Exchange{

        public Int32 venSubTipoMov {
            get {
                if(((VentasCommon.venSTMAfipDS)mParam).Principal[0]["venSubTipoMov"] != DBNull.Value  ){
                    return ((VentasCommon.venSTMAfipDS)mParam).Principal[0].venSubTipoMov;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSTMAfipDS)mParam).Principal[0].venSubTipoMov = value;
               }
	          }
        public bool IsvenSubTipoMovNull {
             get {
                 return mParam==null || ((VentasCommon.venSTMAfipDS)mParam).Principal[0].IsvenSubTipoMovNull();
             }
	        }
        public String Letra {
            get {
                if(((VentasCommon.venSTMAfipDS)mParam).Principal[0]["Letra"] != DBNull.Value  ){
                    return ((VentasCommon.venSTMAfipDS)mParam).Principal[0].Letra;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSTMAfipDS)mParam).Principal[0].Letra = value;
               }
	          }
        public bool IsLetraNull {
             get {
                 return mParam==null || ((VentasCommon.venSTMAfipDS)mParam).Principal[0].IsLetraNull();
             }
	        }
        public Int32 Comprobante_Id {
            get {
                if(((VentasCommon.venSTMAfipDS)mParam).Principal[0]["Comprobante_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venSTMAfipDS)mParam).Principal[0].Comprobante_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSTMAfipDS)mParam).Principal[0].Comprobante_Id = value;
               }
	          }
        public bool IsComprobante_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venSTMAfipDS)mParam).Principal[0].IsComprobante_IdNull();
             }
	        }
        public String DescripcionTiposCompAfip {
            get {
                if(((VentasCommon.venSTMAfipDS)mParam).Principal[0]["DescripcionTiposCompAfip"] != DBNull.Value  ){
                    return ((VentasCommon.venSTMAfipDS)mParam).Principal[0].DescripcionTiposCompAfip;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSTMAfipDS)mParam).Principal[0].DescripcionTiposCompAfip = value;
               }
	          }
        public bool IsDescripcionTiposCompAfipNull {
             get {
                 return mParam==null || ((VentasCommon.venSTMAfipDS)mParam).Principal[0].IsDescripcionTiposCompAfipNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venSTMAfipDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venSTMAfipDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venSTMAfipDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venSTMAfipDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venSTMAfipDS );
     }
     public venSTMAfipActionExchange() : base( "venSTMAfip" ) {
     }

     public venSTMAfipActionExchange(venSTMAfipActionEnum.EnumvenSTMAfipAction pAccion) : base(venSTMAfipActionEnum.GetAccionvenSTMAfipAction(pAccion)) {
     }

     public venSTMAfipActionExchange(venSTMAfipActionEnum.EnumvenSTMAfipAction pAccion, VentasCommon.venSTMAfipDS pdsParam) : base(venSTMAfipActionEnum.GetAccionvenSTMAfipAction(pAccion), pdsParam) {
     }

     public venSTMAfipActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venSTMAfipDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venSTMAfipDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venSTMAfipDS)mParam;
	        }
     }
  }
}
