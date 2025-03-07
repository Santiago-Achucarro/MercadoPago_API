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
    public class impValidacionFComprasActionExchange : Framework.Core.Exchange{

        public String ProveedDesde {
            get {
                if(((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0]["ProveedDesde"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0].ProveedDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0].ProveedDesde = value;
               }
	          }
        public bool IsProveedDesdeNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0].IsProveedDesdeNull();
             }
	        }
        public String ProveedHasta {
            get {
                if(((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0]["ProveedHasta"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0].ProveedHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0].ProveedHasta = value;
               }
	          }
        public bool IsProveedHastaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0].IsProveedHastaNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean SoloConErrores {
            get {
                if(((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0]["SoloConErrores"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0].SoloConErrores;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0].SoloConErrores = value;
               }
	          }
        public bool IsSoloConErroresNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0].IsSoloConErroresNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impValidacionFComprasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impValidacionFComprasDS );
     }
     public impValidacionFComprasActionExchange() : base( "impValidacionFCompras" ) {
     }

     public impValidacionFComprasActionExchange(impValidacionFComprasActionEnum.EnumimpValidacionFComprasAction pAccion) : base(impValidacionFComprasActionEnum.GetAccionimpValidacionFComprasAction(pAccion)) {
     }

     public impValidacionFComprasActionExchange(impValidacionFComprasActionEnum.EnumimpValidacionFComprasAction pAccion, ImpuestosCommon.impValidacionFComprasDS pdsParam) : base(impValidacionFComprasActionEnum.GetAccionimpValidacionFComprasAction(pAccion), pdsParam) {
     }

     public impValidacionFComprasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impValidacionFComprasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public impValidacionFComprasActionExchange(ImpuestosCommon.impValidacionFComprasDS pDS) : base() {
     this.Action = "";
     this.mParam = new ImpuestosCommon.impValidacionFComprasDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impValidacionFComprasDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impValidacionFComprasDS)mParam;
	        }
     }
  }
}
