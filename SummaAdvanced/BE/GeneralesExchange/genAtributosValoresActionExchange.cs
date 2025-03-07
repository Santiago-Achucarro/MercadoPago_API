using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genAtributosValoresActionExchange : Framework.Core.Exchange{

        public Int64 Identity_Id {
            get {
                if(((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0]["Identity_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].Identity_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].Identity_Id = value;
               }
	          }
        public bool IsIdentity_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].IsIdentity_IdNull();
             }
	        }
        public Int32 AtributoNro {
            get {
                if(((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0]["AtributoNro"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].AtributoNro;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].AtributoNro = value;
               }
	          }
        public bool IsAtributoNroNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].IsAtributoNroNull();
             }
	        }
        public String Tabla_Id {
            get {
                if(((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0]["Tabla_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].Tabla_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].Tabla_Id = value;
               }
	          }
        public bool IsTabla_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].IsTabla_IdNull();
             }
	        }
        public String DescripcionAtributosGenerales {
            get {
                if(((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0]["DescripcionAtributosGenerales"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].DescripcionAtributosGenerales;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].DescripcionAtributosGenerales = value;
               }
	          }
        public bool IsDescripcionAtributosGeneralesNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].IsDescripcionAtributosGeneralesNull();
             }
	        }
        public String Tipo {
            get {
                if(((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0]["Tipo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].Tipo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].Tipo = value;
               }
	          }
        public bool IsTipoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].IsTipoNull();
             }
	        }
        public Decimal ValorN {
            get {
                if(((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0]["ValorN"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].ValorN;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].ValorN = value;
               }
	          }
        public bool IsValorNNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].IsValorNNull();
             }
	        }
        public String ValorC {
            get {
                if(((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0]["ValorC"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].ValorC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].ValorC = value;
               }
	          }
        public bool IsValorCNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].IsValorCNull();
             }
	        }
        public DateTime ValorF {
            get {
                if(((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0]["ValorF"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].ValorF;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].ValorF = value;
               }
	          }
        public bool IsValorFNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].IsValorFNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genAtributosValoresDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genAtributosValoresDS );
     }
     public genAtributosValoresActionExchange() : base( "genAtributosValores" ) {
     }

     public genAtributosValoresActionExchange(genAtributosValoresActionEnum.EnumgenAtributosValoresAction pAccion) : base(genAtributosValoresActionEnum.GetAcciongenAtributosValoresAction(pAccion)) {
     }

     public genAtributosValoresActionExchange(genAtributosValoresActionEnum.EnumgenAtributosValoresAction pAccion, GeneralesCommon.genAtributosValoresDS pdsParam) : base(genAtributosValoresActionEnum.GetAcciongenAtributosValoresAction(pAccion), pdsParam) {
     }

     public genAtributosValoresActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genAtributosValoresDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genAtributosValoresDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genAtributosValoresDS)mParam;
	        }
     }
  }
}
