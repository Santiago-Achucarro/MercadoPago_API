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
    public class impCitiActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((ImpuestosCommon.impCitiDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCitiDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCitiDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCitiDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((ImpuestosCommon.impCitiDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCitiDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCitiDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCitiDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ImpuestosCommon.impCitiDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCitiDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCitiDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCitiDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String Destino {
            get {
                if(((ImpuestosCommon.impCitiDS)mParam).Principal[0]["Destino"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCitiDS)mParam).Principal[0].Destino;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCitiDS)mParam).Principal[0].Destino = value;
               }
	          }
        public bool IsDestinoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCitiDS)mParam).Principal[0].IsDestinoNull();
             }
	        }
        public Int32 ImportacionDefBienes {
            get {
                if(((ImpuestosCommon.impCitiDS)mParam).Principal[0]["ImportacionDefBienes"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCitiDS)mParam).Principal[0].ImportacionDefBienes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCitiDS)mParam).Principal[0].ImportacionDefBienes = value;
               }
	          }
        public bool IsImportacionDefBienesNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCitiDS)mParam).Principal[0].IsImportacionDefBienesNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impCitiDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCitiDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCitiDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCitiDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impCitiDS );
     }
     public impCitiActionExchange() : base( "impCiti" ) {
     }

     public impCitiActionExchange(impCitiActionEnum.EnumimpCitiAction pAccion) : base(impCitiActionEnum.GetAccionimpCitiAction(pAccion)) {
     }

     public impCitiActionExchange(impCitiActionEnum.EnumimpCitiAction pAccion, ImpuestosCommon.impCitiDS pdsParam) : base(impCitiActionEnum.GetAccionimpCitiAction(pAccion), pdsParam) {
     }

     public impCitiActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impCitiDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public impCitiActionExchange(ImpuestosCommon.impCitiDS pDS) : base() {
     this.Action = "";
     this.mParam = new ImpuestosCommon.impCitiDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impCitiDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impCitiDS)mParam;
	        }
     }
  }
}
