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
    public class impArbaTxtModifActionExchange : Framework.Core.Exchange{

        public Int16 Anio {
            get {
                if(((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int16 Mes {
            get {
                if(((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0]["Mes"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0].Mes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0].Mes = value;
               }
	          }
        public bool IsMesNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0].IsMesNull();
             }
	        }
        public String CUIT {
            get {
                if(((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0]["CUIT"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0].CUIT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0].CUIT = value;
               }
	          }
        public bool IsCUITNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0].IsCUITNull();
             }
	        }
        public Decimal AlicuotaPer {
            get {
                if(((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0]["AlicuotaPer"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0].AlicuotaPer;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0].AlicuotaPer = value;
               }
	          }
        public bool IsAlicuotaPerNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0].IsAlicuotaPerNull();
             }
	        }
        public Decimal AlicuotaRet {
            get {
                if(((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0]["AlicuotaRet"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0].AlicuotaRet;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0].AlicuotaRet = value;
               }
	          }
        public bool IsAlicuotaRetNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0].IsAlicuotaRetNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impArbaTxtModifDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impArbaTxtModifDS );
     }
     public impArbaTxtModifActionExchange() : base( "impArbaTxtModif" ) {
     }

     public impArbaTxtModifActionExchange(impArbaTxtModifActionEnum.EnumimpArbaTxtModifAction pAccion) : base(impArbaTxtModifActionEnum.GetAccionimpArbaTxtModifAction(pAccion)) {
     }

     public impArbaTxtModifActionExchange(impArbaTxtModifActionEnum.EnumimpArbaTxtModifAction pAccion, ImpuestosCommon.impArbaTxtModifDS pdsParam) : base(impArbaTxtModifActionEnum.GetAccionimpArbaTxtModifAction(pAccion), pdsParam) {
     }

     public impArbaTxtModifActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impArbaTxtModifDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public impArbaTxtModifActionExchange(ImpuestosCommon.impArbaTxtModifDS pDS) : base() {
     this.Action = "";
     this.mParam = new ImpuestosCommon.impArbaTxtModifDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impArbaTxtModifDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impArbaTxtModifDS)mParam;
	        }
     }
  }
}
