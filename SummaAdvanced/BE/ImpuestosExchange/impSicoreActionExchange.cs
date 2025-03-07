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
    public class impSicoreActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((ImpuestosCommon.impSicoreDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impSicoreDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impSicoreDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impSicoreDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((ImpuestosCommon.impSicoreDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impSicoreDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impSicoreDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impSicoreDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ImpuestosCommon.impSicoreDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impSicoreDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impSicoreDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impSicoreDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impSicoreDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impSicoreDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impSicoreDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impSicoreDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impSicoreDS );
     }
     public impSicoreActionExchange() : base( "impSicore" ) {
     }

     public impSicoreActionExchange(impSicoreActionEnum.EnumimpSicoreAction pAccion) : base(impSicoreActionEnum.GetAccionimpSicoreAction(pAccion)) {
     }

     public impSicoreActionExchange(impSicoreActionEnum.EnumimpSicoreAction pAccion, ImpuestosCommon.impSicoreDS pdsParam) : base(impSicoreActionEnum.GetAccionimpSicoreAction(pAccion), pdsParam) {
     }

     public impSicoreActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impSicoreDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impSicoreDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impSicoreDS)mParam;
	        }
     }
  }
}
