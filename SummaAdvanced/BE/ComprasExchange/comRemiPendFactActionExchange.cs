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
    public class comRemiPendFactActionExchange : Framework.Core.Exchange{

        public Int64 comMovProv {
            get {
                if(((ComprasCommon.comRemiPendFactDS)mParam).Principal[0]["comMovProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].comMovProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].comMovProv = value;
               }
	          }
        public bool IscomMovProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].IscomMovProvNull();
             }
	        }
        public Int32 RenglonCuerpo {
            get {
                if(((ComprasCommon.comRemiPendFactDS)mParam).Principal[0]["RenglonCuerpo"] != DBNull.Value  ){
                    return ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].RenglonCuerpo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].RenglonCuerpo = value;
               }
	          }
        public bool IsRenglonCuerpoNull {
             get {
                 return mParam==null || ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].IsRenglonCuerpoNull();
             }
	        }
        public Int64 stkMoviCabe {
            get {
                if(((ComprasCommon.comRemiPendFactDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ComprasCommon.comRemiPendFactDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public Decimal CantidadFacturado {
            get {
                if(((ComprasCommon.comRemiPendFactDS)mParam).Principal[0]["CantidadFacturado"] != DBNull.Value  ){
                    return ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].CantidadFacturado;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].CantidadFacturado = value;
               }
	          }
        public bool IsCantidadFacturadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].IsCantidadFacturadoNull();
             }
	        }
        public Decimal PrecioFacturado {
            get {
                if(((ComprasCommon.comRemiPendFactDS)mParam).Principal[0]["PrecioFacturado"] != DBNull.Value  ){
                    return ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].PrecioFacturado;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].PrecioFacturado = value;
               }
	          }
        public bool IsPrecioFacturadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].IsPrecioFacturadoNull();
             }
	        }
        public Decimal CantidadOriginalFact {
            get {
                if(((ComprasCommon.comRemiPendFactDS)mParam).Principal[0]["CantidadOriginalFact"] != DBNull.Value  ){
                    return ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].CantidadOriginalFact;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].CantidadOriginalFact = value;
               }
	          }
        public bool IsCantidadOriginalFactNull {
             get {
                 return mParam==null || ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].IsCantidadOriginalFactNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comRemiPendFactDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comRemiPendFactDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comRemiPendFactDS );
     }
     public comRemiPendFactActionExchange() : base( "comRemiPendFact" ) {
     }

     public comRemiPendFactActionExchange(comRemiPendFactActionEnum.EnumcomRemiPendFactAction pAccion) : base(comRemiPendFactActionEnum.GetAccioncomRemiPendFactAction(pAccion)) {
     }

     public comRemiPendFactActionExchange(comRemiPendFactActionEnum.EnumcomRemiPendFactAction pAccion, ComprasCommon.comRemiPendFactDS pdsParam) : base(comRemiPendFactActionEnum.GetAccioncomRemiPendFactAction(pAccion), pdsParam) {
     }

     public comRemiPendFactActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comRemiPendFactDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comRemiPendFactDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comRemiPendFactDS)mParam;
	        }
     }
  }
}
