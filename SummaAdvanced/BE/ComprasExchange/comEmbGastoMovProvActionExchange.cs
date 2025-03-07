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
    public class comEmbGastoMovProvActionExchange : Framework.Core.Exchange{

        public Int64 comMovProv {
            get {
                if(((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0]["comMovProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0].comMovProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0].comMovProv = value;
               }
	          }
        public bool IscomMovProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0].IscomMovProvNull();
             }
	        }
        public Int32 comRenglon {
            get {
                if(((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0]["comRenglon"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0].comRenglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0].comRenglon = value;
               }
	          }
        public bool IscomRenglonNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0].IscomRenglonNull();
             }
	        }
        public Int64 comEmbarques {
            get {
                if(((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0]["comEmbarques"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0].comEmbarques;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0].comEmbarques = value;
               }
	          }
        public bool IscomEmbarquesNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0].IscomEmbarquesNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Detalle {
            get {
                if(((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0]["Detalle"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0].Detalle;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0].Detalle = value;
               }
	          }
        public bool IsDetalleNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0].IsDetalleNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comEmbGastoMovProvDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comEmbGastoMovProvDS );
     }
     public comEmbGastoMovProvActionExchange() : base( "comEmbGastoMovProv" ) {
     }

     public comEmbGastoMovProvActionExchange(comEmbGastoMovProvActionEnum.EnumcomEmbGastoMovProvAction pAccion) : base(comEmbGastoMovProvActionEnum.GetAccioncomEmbGastoMovProvAction(pAccion)) {
     }

     public comEmbGastoMovProvActionExchange(comEmbGastoMovProvActionEnum.EnumcomEmbGastoMovProvAction pAccion, ComprasCommon.comEmbGastoMovProvDS pdsParam) : base(comEmbGastoMovProvActionEnum.GetAccioncomEmbGastoMovProvAction(pAccion), pdsParam) {
     }

     public comEmbGastoMovProvActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comEmbGastoMovProvDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comEmbGastoMovProvDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comEmbGastoMovProvDS)mParam;
	        }
     }
  }
}
