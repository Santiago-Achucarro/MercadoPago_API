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
    public class impPadronTxtActionExchange : Framework.Core.Exchange{

        public String Padron_Id {
            get {
                if(((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0]["Padron_Id"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].Padron_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].Padron_Id = value;
               }
	          }
        public bool IsPadron_IdNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].IsPadron_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Cuit {
            get {
                if(((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0]["Cuit"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].Cuit;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].Cuit = value;
               }
	          }
        public bool IsCuitNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].IsCuitNull();
             }
	        }
        public Int32 Anio {
            get {
                if(((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int32 Mes {
            get {
                if(((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0]["Mes"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].Mes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].Mes = value;
               }
	          }
        public bool IsMesNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].IsMesNull();
             }
	        }
        public Int32 Trimestre {
            get {
                if(((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0]["Trimestre"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].Trimestre;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].Trimestre = value;
               }
	          }
        public bool IsTrimestreNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].IsTrimestreNull();
             }
	        }
        public Decimal Alicuota {
            get {
                if(((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0]["Alicuota"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].Alicuota;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].Alicuota = value;
               }
	          }
        public bool IsAlicuotaNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].IsAlicuotaNull();
             }
	        }
        public String StoreProcedure {
            get {
                if(((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0]["StoreProcedure"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].StoreProcedure;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].StoreProcedure = value;
               }
	          }
        public bool IsStoreProcedureNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].IsStoreProcedureNull();
             }
	        }
        public String Archivo {
            get {
                if(((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0]["Archivo"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].Archivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].Archivo = value;
               }
	          }
        public bool IsArchivoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].IsArchivoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impPadronTxtDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impPadronTxtDS );
     }
     public impPadronTxtActionExchange() : base( "impPadronTxt" ) {
     }

     public impPadronTxtActionExchange(impPadronTxtActionEnum.EnumimpPadronTxtAction pAccion) : base(impPadronTxtActionEnum.GetAccionimpPadronTxtAction(pAccion)) {
     }

     public impPadronTxtActionExchange(impPadronTxtActionEnum.EnumimpPadronTxtAction pAccion, ImpuestosCommon.impPadronTxtDS pdsParam) : base(impPadronTxtActionEnum.GetAccionimpPadronTxtAction(pAccion), pdsParam) {
     }

     public impPadronTxtActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impPadronTxtDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public impPadronTxtActionExchange(ImpuestosCommon.impPadronTxtDS pDS) : base() {
     this.Action = "";
     this.mParam = new ImpuestosCommon.impPadronTxtDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impPadronTxtDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impPadronTxtDS)mParam;
	        }
     }
  }
}
