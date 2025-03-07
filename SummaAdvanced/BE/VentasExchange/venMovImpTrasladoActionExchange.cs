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
    public class venMovImpTrasladoActionExchange : Framework.Core.Exchange{

        public Int64 Asiento_Id {
            get {
                if(((VentasCommon.venMovImpTrasladoDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpTrasladoDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpTrasladoDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpTrasladoDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public Int32 RenglonDebe {
            get {
                if(((VentasCommon.venMovImpTrasladoDS)mParam).Principal[0]["RenglonDebe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpTrasladoDS)mParam).Principal[0].RenglonDebe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpTrasladoDS)mParam).Principal[0].RenglonDebe = value;
               }
	          }
        public bool IsRenglonDebeNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpTrasladoDS)mParam).Principal[0].IsRenglonDebeNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovImpTrasladoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovImpTrasladoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovImpTrasladoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovImpTrasladoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovImpTrasladoDS );
     }
     public venMovImpTrasladoActionExchange() : base( "venMovImpTraslado" ) {
     }

     public venMovImpTrasladoActionExchange(venMovImpTrasladoActionEnum.EnumvenMovImpTrasladoAction pAccion) : base(venMovImpTrasladoActionEnum.GetAccionvenMovImpTrasladoAction(pAccion)) {
     }

     public venMovImpTrasladoActionExchange(venMovImpTrasladoActionEnum.EnumvenMovImpTrasladoAction pAccion, VentasCommon.venMovImpTrasladoDS pdsParam) : base(venMovImpTrasladoActionEnum.GetAccionvenMovImpTrasladoAction(pAccion), pdsParam) {
     }

     public venMovImpTrasladoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovImpTrasladoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovImpTrasladoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovImpTrasladoDS)mParam;
	        }
     }
  }
}
