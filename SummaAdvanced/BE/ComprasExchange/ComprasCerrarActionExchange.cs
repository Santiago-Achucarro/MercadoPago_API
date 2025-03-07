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
    public class ComprasCerrarActionExchange : Framework.Core.Exchange{

        public DateTime UltimoCierre {
            get {
                if(((ComprasCommon.ComprasCerrarDS)mParam).Principal[0]["UltimoCierre"] != DBNull.Value  ){
                    return ((ComprasCommon.ComprasCerrarDS)mParam).Principal[0].UltimoCierre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.ComprasCerrarDS)mParam).Principal[0].UltimoCierre = value;
               }
	          }
        public bool IsUltimoCierreNull {
             get {
                 return mParam==null || ((ComprasCommon.ComprasCerrarDS)mParam).Principal[0].IsUltimoCierreNull();
             }
	        }
        public DateTime ProximoCierre {
            get {
                if(((ComprasCommon.ComprasCerrarDS)mParam).Principal[0]["ProximoCierre"] != DBNull.Value  ){
                    return ((ComprasCommon.ComprasCerrarDS)mParam).Principal[0].ProximoCierre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.ComprasCerrarDS)mParam).Principal[0].ProximoCierre = value;
               }
	          }
        public bool IsProximoCierreNull {
             get {
                 return mParam==null || ((ComprasCommon.ComprasCerrarDS)mParam).Principal[0].IsProximoCierreNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.ComprasCerrarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.ComprasCerrarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.ComprasCerrarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.ComprasCerrarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.ComprasCerrarDS );
     }
     public ComprasCerrarActionExchange() : base( "ComprasCerrar" ) {
     }

     public ComprasCerrarActionExchange(ComprasCerrarActionEnum.EnumComprasCerrarAction pAccion) : base(ComprasCerrarActionEnum.GetAccionComprasCerrarAction(pAccion)) {
     }

     public ComprasCerrarActionExchange(ComprasCerrarActionEnum.EnumComprasCerrarAction pAccion, ComprasCommon.ComprasCerrarDS pdsParam) : base(ComprasCerrarActionEnum.GetAccionComprasCerrarAction(pAccion), pdsParam) {
     }

     public ComprasCerrarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.ComprasCerrarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.ComprasCerrarDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.ComprasCerrarDS)mParam;
	        }
     }
  }
}
