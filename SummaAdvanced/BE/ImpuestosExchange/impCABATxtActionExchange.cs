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
    public class impCABATxtActionExchange : Framework.Core.Exchange{

        public String ArchivoRegGral {
            get {
                if(((ImpuestosCommon.impCABATxtDS)mParam).Principal[0]["ArchivoRegGral"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].ArchivoRegGral;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].ArchivoRegGral = value;
               }
	          }
        public bool IsArchivoRegGralNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].IsArchivoRegGralNull();
             }
	        }
        public String ArchivoMagSup {
            get {
                if(((ImpuestosCommon.impCABATxtDS)mParam).Principal[0]["ArchivoMagSup"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].ArchivoMagSup;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].ArchivoMagSup = value;
               }
	          }
        public bool IsArchivoMagSupNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].IsArchivoMagSupNull();
             }
	        }
        public String ArchivoRiesFisc {
            get {
                if(((ImpuestosCommon.impCABATxtDS)mParam).Principal[0]["ArchivoRiesFisc"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].ArchivoRiesFisc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].ArchivoRiesFisc = value;
               }
	          }
        public bool IsArchivoRiesFiscNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].IsArchivoRiesFiscNull();
             }
	        }
        public String ArchivoExentos {
            get {
                if(((ImpuestosCommon.impCABATxtDS)mParam).Principal[0]["ArchivoExentos"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].ArchivoExentos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].ArchivoExentos = value;
               }
	          }
        public bool IsArchivoExentosNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].IsArchivoExentosNull();
             }
	        }
        public Int16 Mes {
            get {
                if(((ImpuestosCommon.impCABATxtDS)mParam).Principal[0]["Mes"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].Mes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].Mes = value;
               }
	          }
        public bool IsMesNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].IsMesNull();
             }
	        }
        public Int16 Anio {
            get {
                if(((ImpuestosCommon.impCABATxtDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int16 Trimestre {
            get {
                if(((ImpuestosCommon.impCABATxtDS)mParam).Principal[0]["Trimestre"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].Trimestre;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].Trimestre = value;
               }
	          }
        public bool IsTrimestreNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].IsTrimestreNull();
             }
	        }
        public String MesTrimestre {
            get {
                if(((ImpuestosCommon.impCABATxtDS)mParam).Principal[0]["MesTrimestre"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].MesTrimestre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].MesTrimestre = value;
               }
	          }
        public bool IsMesTrimestreNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].IsMesTrimestreNull();
             }
	        }
        public Int32 CantGral {
            get {
                if(((ImpuestosCommon.impCABATxtDS)mParam).Principal[0]["CantGral"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].CantGral;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].CantGral = value;
               }
	          }
        public bool IsCantGralNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].IsCantGralNull();
             }
	        }
        public Int32 CantMagSup {
            get {
                if(((ImpuestosCommon.impCABATxtDS)mParam).Principal[0]["CantMagSup"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].CantMagSup;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].CantMagSup = value;
               }
	          }
        public bool IsCantMagSupNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].IsCantMagSupNull();
             }
	        }
        public Int32 CantExentos {
            get {
                if(((ImpuestosCommon.impCABATxtDS)mParam).Principal[0]["CantExentos"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].CantExentos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].CantExentos = value;
               }
	          }
        public bool IsCantExentosNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].IsCantExentosNull();
             }
	        }
        public Int32 CantRiesgo {
            get {
                if(((ImpuestosCommon.impCABATxtDS)mParam).Principal[0]["CantRiesgo"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].CantRiesgo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].CantRiesgo = value;
               }
	          }
        public bool IsCantRiesgoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].IsCantRiesgoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impCABATxtDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impCABATxtDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impCABATxtDS );
     }
     public impCABATxtActionExchange() : base( "impCABATxt" ) {
     }

     public impCABATxtActionExchange(impCABATxtActionEnum.EnumimpCABATxtAction pAccion) : base(impCABATxtActionEnum.GetAccionimpCABATxtAction(pAccion)) {
     }

     public impCABATxtActionExchange(impCABATxtActionEnum.EnumimpCABATxtAction pAccion, ImpuestosCommon.impCABATxtDS pdsParam) : base(impCABATxtActionEnum.GetAccionimpCABATxtAction(pAccion), pdsParam) {
     }

     public impCABATxtActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impCABATxtDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impCABATxtDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impCABATxtDS)mParam;
	        }
     }
  }
}
