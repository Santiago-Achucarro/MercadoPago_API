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
    public class impImpuestosCobradosActionExchange : Framework.Core.Exchange{

        public DateTime FechaDesde {
            get {
                if(((ImpuestosCommon.impImpuestosCobradosDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosCobradosDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosCobradosDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosCobradosDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ImpuestosCommon.impImpuestosCobradosDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosCobradosDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosCobradosDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosCobradosDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impImpuestosCobradosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impImpuestosCobradosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impImpuestosCobradosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impImpuestosCobradosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impImpuestosCobradosDS );
     }
     public impImpuestosCobradosActionExchange() : base( "impImpuestosCobrados" ) {
     }

     public impImpuestosCobradosActionExchange(impImpuestosCobradosActionEnum.EnumimpImpuestosCobradosAction pAccion) : base(impImpuestosCobradosActionEnum.GetAccionimpImpuestosCobradosAction(pAccion)) {
     }

     public impImpuestosCobradosActionExchange(impImpuestosCobradosActionEnum.EnumimpImpuestosCobradosAction pAccion, ImpuestosCommon.impImpuestosCobradosDS pdsParam) : base(impImpuestosCobradosActionEnum.GetAccionimpImpuestosCobradosAction(pAccion), pdsParam) {
     }

     public impImpuestosCobradosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impImpuestosCobradosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impImpuestosCobradosDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impImpuestosCobradosDS)mParam;
	        }
     }
  }
}
