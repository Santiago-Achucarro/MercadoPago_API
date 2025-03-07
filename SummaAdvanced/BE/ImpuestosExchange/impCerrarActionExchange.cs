using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ImpuestosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class impCerrarActionExchange : Framework.Core.Exchange{

        public DateTime UltimoCierre {
            get {
                if(((ImpuestosCommon.impCerrarDS)mParam).Principal[0]["UltimoCierre"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCerrarDS)mParam).Principal[0].UltimoCierre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCerrarDS)mParam).Principal[0].UltimoCierre = value;
               }
	          }
        public bool IsUltimoCierreNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCerrarDS)mParam).Principal[0].IsUltimoCierreNull();
             }
	        }
        public DateTime ProximoCierre {
            get {
                if(((ImpuestosCommon.impCerrarDS)mParam).Principal[0]["ProximoCierre"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCerrarDS)mParam).Principal[0].ProximoCierre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCerrarDS)mParam).Principal[0].ProximoCierre = value;
               }
	          }
        public bool IsProximoCierreNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCerrarDS)mParam).Principal[0].IsProximoCierreNull();
             }
	        }
        public DateTime FechaCierreCompras {
            get {
                if(((ImpuestosCommon.impCerrarDS)mParam).Principal[0]["FechaCierreCompras"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCerrarDS)mParam).Principal[0].FechaCierreCompras;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCerrarDS)mParam).Principal[0].FechaCierreCompras = value;
               }
	          }
        public bool IsFechaCierreComprasNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCerrarDS)mParam).Principal[0].IsFechaCierreComprasNull();
             }
	        }
        public DateTime FechaCierreVentas {
            get {
                if(((ImpuestosCommon.impCerrarDS)mParam).Principal[0]["FechaCierreVentas"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCerrarDS)mParam).Principal[0].FechaCierreVentas;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCerrarDS)mParam).Principal[0].FechaCierreVentas = value;
               }
	          }
        public bool IsFechaCierreVentasNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCerrarDS)mParam).Principal[0].IsFechaCierreVentasNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impCerrarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCerrarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCerrarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCerrarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impCerrarDS );
     }
     public impCerrarActionExchange() : base( "impCerrar" ) {
     }

     public impCerrarActionExchange(impCerrarActionEnum.EnumimpCerrarAction pAccion) : base(impCerrarActionEnum.GetAccionimpCerrarAction(pAccion)) {
     }

     public impCerrarActionExchange(impCerrarActionEnum.EnumimpCerrarAction pAccion, ImpuestosCommon.impCerrarDS pdsParam) : base(impCerrarActionEnum.GetAccionimpCerrarAction(pAccion), pdsParam) {
     }

     public impCerrarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impCerrarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impCerrarDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impCerrarDS)mParam;
	        }
     }
  }
}
