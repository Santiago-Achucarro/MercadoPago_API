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
    public class impRetPercIvaActionExchange : Framework.Core.Exchange{

        public DateTime FechaDesde {
            get {
                if(((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean Retenciones {
            get {
                if(((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0]["Retenciones"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0].Retenciones;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0].Retenciones = value;
               }
	          }
        public bool IsRetencionesNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0].IsRetencionesNull();
             }
	        }
        public Boolean Percepciones {
            get {
                if(((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0]["Percepciones"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0].Percepciones;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0].Percepciones = value;
               }
	          }
        public bool IsPercepcionesNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0].IsPercepcionesNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impRetPercIvaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impRetPercIvaDS );
     }
     public impRetPercIvaActionExchange() : base( "impRetPercIva" ) {
     }

     public impRetPercIvaActionExchange(impRetPercIvaActionEnum.EnumimpRetPercIvaAction pAccion) : base(impRetPercIvaActionEnum.GetAccionimpRetPercIvaAction(pAccion)) {
     }

     public impRetPercIvaActionExchange(impRetPercIvaActionEnum.EnumimpRetPercIvaAction pAccion, ImpuestosCommon.impRetPercIvaDS pdsParam) : base(impRetPercIvaActionEnum.GetAccionimpRetPercIvaAction(pAccion), pdsParam) {
     }

     public impRetPercIvaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impRetPercIvaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public impRetPercIvaActionExchange(ImpuestosCommon.impRetPercIvaDS pDS) : base() {
     this.Action = "";
     this.mParam = new ImpuestosCommon.impRetPercIvaDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impRetPercIvaDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impRetPercIvaDS)mParam;
	        }
     }
  }
}
