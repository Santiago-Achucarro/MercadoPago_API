using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace SueldosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class sueTimbradoRecibosActionExchange : Framework.Core.Exchange{

        public String Segmento_Id {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Grupo_Id {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Grupo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Grupo_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Grupo_Id = value;
               }
	          }
        public bool IsGrupo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsGrupo_IdNull();
             }
	        }
        public String DescripcionGrupo {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["DescripcionGrupo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].DescripcionGrupo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].DescripcionGrupo = value;
               }
	          }
        public bool IsDescripcionGrupoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsDescripcionGrupoNull();
             }
	        }
        public Int32 LegajoDesde {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["LegajoDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].LegajoDesde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].LegajoDesde = value;
               }
	          }
        public bool IsLegajoDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsLegajoDesdeNull();
             }
	        }
        public String DescripcionLegajoDesde {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["DescripcionLegajoDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].DescripcionLegajoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].DescripcionLegajoDesde = value;
               }
	          }
        public bool IsDescripcionLegajoDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsDescripcionLegajoDesdeNull();
             }
	        }
        public Int32 LegajoHasta {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["LegajoHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].LegajoHasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].LegajoHasta = value;
               }
	          }
        public bool IsLegajoHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsLegajoHastaNull();
             }
	        }
        public String DescripcionLegajoHasta {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["DescripcionLegajoHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].DescripcionLegajoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].DescripcionLegajoHasta = value;
               }
	          }
        public bool IsDescripcionLegajoHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsDescripcionLegajoHastaNull();
             }
	        }
        public String TipoNomina {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["TipoNomina"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].TipoNomina;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].TipoNomina = value;
               }
	          }
        public bool IsTipoNominaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsTipoNominaNull();
             }
	        }
        public Boolean Descargar {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Descargar"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Descargar;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Descargar = value;
               }
	          }
        public bool IsDescargarNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsDescargarNull();
             }
	        }
        public String Zip {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Zip"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Zip;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Zip = value;
               }
	          }
        public bool IsZipNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsZipNull();
             }
	        }
        public String NombreZip {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["NombreZip"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].NombreZip;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].NombreZip = value;
               }
	          }
        public bool IsNombreZipNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsNombreZipNull();
             }
	        }
        public Int32 Anio {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int32 Mes {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Mes"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Mes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Mes = value;
               }
	          }
        public bool IsMesNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsMesNull();
             }
	        }
        public Int32 Quincena {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Quincena"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Quincena;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Quincena = value;
               }
	          }
        public bool IsQuincenaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsQuincenaNull();
             }
	        }
        public Int32 Decena {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Decena"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Decena;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Decena = value;
               }
	          }
        public bool IsDecenaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsDecenaNull();
             }
	        }
        public Int32 Semana {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Semana"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Semana;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Semana = value;
               }
	          }
        public bool IsSemanaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsSemanaNull();
             }
	        }
        public Int32 Vez {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Vez"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Vez;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Vez = value;
               }
	          }
        public bool IsVezNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsVezNull();
             }
	        }
        public String RazonCancelacionDescrip {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["RazonCancelacionDescrip"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].RazonCancelacionDescrip;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].RazonCancelacionDescrip = value;
               }
	          }
        public bool IsRazonCancelacionDescripNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsRazonCancelacionDescripNull();
             }
	        }
        public String RazonCancelacion {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["RazonCancelacion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].RazonCancelacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].RazonCancelacion = value;
               }
	          }
        public bool IsRazonCancelacionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsRazonCancelacionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTimbradoRecibosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueTimbradoRecibosDS );
     }
     public sueTimbradoRecibosActionExchange() : base( "sueTimbradoRecibos" ) {
     }

     public sueTimbradoRecibosActionExchange(sueTimbradoRecibosActionEnum.EnumsueTimbradoRecibosAction pAccion) : base(sueTimbradoRecibosActionEnum.GetAccionsueTimbradoRecibosAction(pAccion)) {
     }

     public sueTimbradoRecibosActionExchange(sueTimbradoRecibosActionEnum.EnumsueTimbradoRecibosAction pAccion, SueldosCommon.sueTimbradoRecibosDS pdsParam) : base(sueTimbradoRecibosActionEnum.GetAccionsueTimbradoRecibosAction(pAccion), pdsParam) {
     }

     public sueTimbradoRecibosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueTimbradoRecibosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public sueTimbradoRecibosActionExchange(SueldosCommon.sueTimbradoRecibosDS pDS) : base() {
     this.Action = "";
     this.mParam = new SueldosCommon.sueTimbradoRecibosDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueTimbradoRecibosDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueTimbradoRecibosDS)mParam;
	        }
     }
  }
}
