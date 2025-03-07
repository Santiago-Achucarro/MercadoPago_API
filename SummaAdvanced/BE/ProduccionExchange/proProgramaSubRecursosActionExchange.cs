using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ProduccionExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class proProgramaSubRecursosActionExchange : Framework.Core.Exchange{

        public String Recurso_Id {
            get {
                if(((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0]["Recurso_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].Recurso_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].Recurso_Id = value;
               }
	          }
        public bool IsRecurso_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].IsRecurso_IdNull();
             }
	        }
        public String DescripcionRecurso {
            get {
                if(((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0]["DescripcionRecurso"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].DescripcionRecurso;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].DescripcionRecurso = value;
               }
	          }
        public bool IsDescripcionRecursoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].IsDescripcionRecursoNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String PendHist {
            get {
                if(((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0]["PendHist"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].PendHist;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].PendHist = value;
               }
	          }
        public bool IsPendHistNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].IsPendHistNull();
             }
	        }
        public Boolean SoloEnProd {
            get {
                if(((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0]["SoloEnProd"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].SoloEnProd;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].SoloEnProd = value;
               }
	          }
        public bool IsSoloEnProdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].IsSoloEnProdNull();
             }
	        }
        public String SubRecurso_Id {
            get {
                if(((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0]["SubRecurso_Id"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].SubRecurso_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].SubRecurso_Id = value;
               }
	          }
        public bool IsSubRecurso_IdNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].IsSubRecurso_IdNull();
             }
	        }
        public String DescripcionSubRecurso {
            get {
                if(((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0]["DescripcionSubRecurso"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].DescripcionSubRecurso;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].DescripcionSubRecurso = value;
               }
	          }
        public bool IsDescripcionSubRecursoNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].IsDescripcionSubRecursoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proProgramaSubRecursosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proProgramaSubRecursosDS );
     }
     public proProgramaSubRecursosActionExchange() : base( "proProgramaSubRecursos" ) {
     }

     public proProgramaSubRecursosActionExchange(proProgramaSubRecursosActionEnum.EnumproProgramaSubRecursosAction pAccion) : base(proProgramaSubRecursosActionEnum.GetAccionproProgramaSubRecursosAction(pAccion)) {
     }

     public proProgramaSubRecursosActionExchange(proProgramaSubRecursosActionEnum.EnumproProgramaSubRecursosAction pAccion, ProduccionCommon.proProgramaSubRecursosDS pdsParam) : base(proProgramaSubRecursosActionEnum.GetAccionproProgramaSubRecursosAction(pAccion), pdsParam) {
     }

     public proProgramaSubRecursosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proProgramaSubRecursosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proProgramaSubRecursosDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proProgramaSubRecursosDS)mParam;
	        }
     }
  }
}
