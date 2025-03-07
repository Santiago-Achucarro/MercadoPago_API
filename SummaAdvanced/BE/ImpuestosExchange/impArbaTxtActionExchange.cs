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
    public class impArbaTxtActionExchange : Framework.Core.Exchange{

        public String ArchivoRet {
            get {
                if(((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0]["ArchivoRet"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].ArchivoRet;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].ArchivoRet = value;
               }
	          }
        public bool IsArchivoRetNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].IsArchivoRetNull();
             }
	        }
        public String ArchivoPer {
            get {
                if(((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0]["ArchivoPer"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].ArchivoPer;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].ArchivoPer = value;
               }
	          }
        public bool IsArchivoPerNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].IsArchivoPerNull();
             }
	        }
        public Int16 Mes {
            get {
                if(((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0]["Mes"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].Mes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].Mes = value;
               }
	          }
        public bool IsMesNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].IsMesNull();
             }
	        }
        public Int16 Anio {
            get {
                if(((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int32 CantRet {
            get {
                if(((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0]["CantRet"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].CantRet;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].CantRet = value;
               }
	          }
        public bool IsCantRetNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].IsCantRetNull();
             }
	        }
        public Int32 CantPer {
            get {
                if(((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0]["CantPer"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].CantPer;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].CantPer = value;
               }
	          }
        public bool IsCantPerNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].IsCantPerNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impArbaTxtDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impArbaTxtDS );
     }
     public impArbaTxtActionExchange() : base( "impArbaTxt" ) {
     }

     public impArbaTxtActionExchange(impArbaTxtActionEnum.EnumimpArbaTxtAction pAccion) : base(impArbaTxtActionEnum.GetAccionimpArbaTxtAction(pAccion)) {
     }

     public impArbaTxtActionExchange(impArbaTxtActionEnum.EnumimpArbaTxtAction pAccion, ImpuestosCommon.impArbaTxtDS pdsParam) : base(impArbaTxtActionEnum.GetAccionimpArbaTxtAction(pAccion), pdsParam) {
     }

     public impArbaTxtActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impArbaTxtDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impArbaTxtDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impArbaTxtDS)mParam;
	        }
     }
  }
}
