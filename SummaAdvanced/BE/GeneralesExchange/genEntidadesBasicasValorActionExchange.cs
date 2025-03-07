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
    public class genEntidadesBasicasValorActionExchange : Framework.Core.Exchange{

        public Int32 Entidad_Id {
            get {
                if(((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0]["Entidad_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].Entidad_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].Entidad_Id = value;
               }
	          }
        public bool IsEntidad_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].IsEntidad_IdNull();
             }
	        }
        public String DescripcionEntidadesBasicas {
            get {
                if(((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0]["DescripcionEntidadesBasicas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].DescripcionEntidadesBasicas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].DescripcionEntidadesBasicas = value;
               }
	          }
        public bool IsDescripcionEntidadesBasicasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].IsDescripcionEntidadesBasicasNull();
             }
	        }
        public String Dominio_Id {
            get {
                if(((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0]["Dominio_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].Dominio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].Dominio_Id = value;
               }
	          }
        public bool IsDominio_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].IsDominio_IdNull();
             }
	        }
        public String DescripcionDominios {
            get {
                if(((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0]["DescripcionDominios"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].DescripcionDominios;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].DescripcionDominios = value;
               }
	          }
        public bool IsDescripcionDominiosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].IsDescripcionDominiosNull();
             }
	        }
        public String Clave {
            get {
                if(((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0]["Clave"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].Clave;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].Clave = value;
               }
	          }
        public bool IsClaveNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].IsClaveNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEntidadesBasicasValorDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genEntidadesBasicasValorDS );
     }
     public genEntidadesBasicasValorActionExchange() : base( "genEntidadesBasicasValor" ) {
     }

     public genEntidadesBasicasValorActionExchange(genEntidadesBasicasValorActionEnum.EnumgenEntidadesBasicasValorAction pAccion) : base(genEntidadesBasicasValorActionEnum.GetAcciongenEntidadesBasicasValorAction(pAccion)) {
     }

     public genEntidadesBasicasValorActionExchange(genEntidadesBasicasValorActionEnum.EnumgenEntidadesBasicasValorAction pAccion, GeneralesCommon.genEntidadesBasicasValorDS pdsParam) : base(genEntidadesBasicasValorActionEnum.GetAcciongenEntidadesBasicasValorAction(pAccion), pdsParam) {
     }

     public genEntidadesBasicasValorActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genEntidadesBasicasValorDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genEntidadesBasicasValorDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genEntidadesBasicasValorDS)mParam;
	        }
     }
  }
}
