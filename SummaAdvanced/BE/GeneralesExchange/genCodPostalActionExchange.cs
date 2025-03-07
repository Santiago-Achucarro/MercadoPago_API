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
    public class genCodPostalActionExchange : Framework.Core.Exchange{

        public String CodigoPostal {
            get {
                if(((GeneralesCommon.genCodPostalDS)mParam).Principal[0]["CodigoPostal"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].CodigoPostal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].CodigoPostal = value;
               }
	          }
        public bool IsCodigoPostalNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].IsCodigoPostalNull();
             }
	        }
        public String Estado {
            get {
                if(((GeneralesCommon.genCodPostalDS)mParam).Principal[0]["Estado"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].Estado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].Estado = value;
               }
	          }
        public bool IsEstadoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].IsEstadoNull();
             }
	        }
        public String Municipio {
            get {
                if(((GeneralesCommon.genCodPostalDS)mParam).Principal[0]["Municipio"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].Municipio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].Municipio = value;
               }
	          }
        public bool IsMunicipioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].IsMunicipioNull();
             }
	        }
        public String Localidad {
            get {
                if(((GeneralesCommon.genCodPostalDS)mParam).Principal[0]["Localidad"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].Localidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].Localidad = value;
               }
	          }
        public bool IsLocalidadNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].IsLocalidadNull();
             }
	        }
        public Boolean FranjaFonteriza {
            get {
                if(((GeneralesCommon.genCodPostalDS)mParam).Principal[0]["FranjaFonteriza"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].FranjaFonteriza;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].FranjaFonteriza = value;
               }
	          }
        public bool IsFranjaFonterizaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].IsFranjaFonterizaNull();
             }
	        }
        public String CodigoUso {
            get {
                if(((GeneralesCommon.genCodPostalDS)mParam).Principal[0]["CodigoUso"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].CodigoUso;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].CodigoUso = value;
               }
	          }
        public bool IsCodigoUsoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].IsCodigoUsoNull();
             }
	        }
        public String Provincia_Id {
            get {
                if(((GeneralesCommon.genCodPostalDS)mParam).Principal[0]["Provincia_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].Provincia_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].Provincia_Id = value;
               }
	          }
        public bool IsProvincia_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].IsProvincia_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genCodPostalDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genCodPostalDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genCodPostalDS );
     }
     public genCodPostalActionExchange() : base( "genCodPostal" ) {
     }

     public genCodPostalActionExchange(genCodPostalActionEnum.EnumgenCodPostalAction pAccion) : base(genCodPostalActionEnum.GetAcciongenCodPostalAction(pAccion)) {
     }

     public genCodPostalActionExchange(genCodPostalActionEnum.EnumgenCodPostalAction pAccion, GeneralesCommon.genCodPostalDS pdsParam) : base(genCodPostalActionEnum.GetAcciongenCodPostalAction(pAccion), pdsParam) {
     }

     public genCodPostalActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genCodPostalDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public genCodPostalActionExchange(GeneralesCommon.genCodPostalDS pDS) : base() {
     this.Action = "";
     this.mParam = new GeneralesCommon.genCodPostalDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genCodPostalDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genCodPostalDS)mParam;
	        }
     }
  }
}
