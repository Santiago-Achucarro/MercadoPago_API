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
    public class comRiCuerpoRecibirActionExchange : Framework.Core.Exchange{

        public Int32 comReqInterno {
            get {
                if(((ComprasCommon.comRiCuerpoRecibirDS)mParam).Principal[0]["comReqInterno"] != DBNull.Value  ){
                    return ((ComprasCommon.comRiCuerpoRecibirDS)mParam).Principal[0].comReqInterno;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRiCuerpoRecibirDS)mParam).Principal[0].comReqInterno = value;
               }
	          }
        public bool IscomReqInternoNull {
             get {
                 return mParam==null || ((ComprasCommon.comRiCuerpoRecibirDS)mParam).Principal[0].IscomReqInternoNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ComprasCommon.comRiCuerpoRecibirDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ComprasCommon.comRiCuerpoRecibirDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRiCuerpoRecibirDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ComprasCommon.comRiCuerpoRecibirDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ComprasCommon.comRiCuerpoRecibirDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ComprasCommon.comRiCuerpoRecibirDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRiCuerpoRecibirDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ComprasCommon.comRiCuerpoRecibirDS)mParam).Principal[0].IsCantidadNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comRiCuerpoRecibirDS );
     }
     public comRiCuerpoRecibirActionExchange() : base( "comRiCuerpoRecibir" ) {
     }

     public comRiCuerpoRecibirActionExchange(comRiCuerpoRecibirActionEnum.EnumcomRiCuerpoRecibirAction pAccion) : base(comRiCuerpoRecibirActionEnum.GetAccioncomRiCuerpoRecibirAction(pAccion)) {
     }

     public comRiCuerpoRecibirActionExchange(comRiCuerpoRecibirActionEnum.EnumcomRiCuerpoRecibirAction pAccion, ComprasCommon.comRiCuerpoRecibirDS pdsParam) : base(comRiCuerpoRecibirActionEnum.GetAccioncomRiCuerpoRecibirAction(pAccion), pdsParam) {
     }

     public comRiCuerpoRecibirActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comRiCuerpoRecibirDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comRiCuerpoRecibirDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comRiCuerpoRecibirDS)mParam;
	        }
     }
  }
}
