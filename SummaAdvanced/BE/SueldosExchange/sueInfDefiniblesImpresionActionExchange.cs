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
    public class sueInfDefiniblesImpresionActionExchange : Framework.Core.Exchange{

        public String Informe_Id {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Informe_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Informe_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Informe_Id = value;
               }
	          }
        public bool IsInforme_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsInforme_IdNull();
             }
	        }
        public String DescripcionInforme {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["DescripcionInforme"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].DescripcionInforme;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].DescripcionInforme = value;
               }
	          }
        public bool IsDescripcionInformeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsDescripcionInformeNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 LegajoDesde {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["LegajoDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].LegajoDesde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].LegajoDesde = value;
               }
	          }
        public bool IsLegajoDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsLegajoDesdeNull();
             }
	        }
        public Int32 LegajoHasta {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["LegajoHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].LegajoHasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].LegajoHasta = value;
               }
	          }
        public bool IsLegajoHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsLegajoHastaNull();
             }
	        }
        public String SucursalDesde {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["SucursalDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].SucursalDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].SucursalDesde = value;
               }
	          }
        public bool IsSucursalDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsSucursalDesdeNull();
             }
	        }
        public String SucursalHasta {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["SucursalHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].SucursalHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].SucursalHasta = value;
               }
	          }
        public bool IsSucursalHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsSucursalHastaNull();
             }
	        }
        public String ConvenioDesde {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["ConvenioDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].ConvenioDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].ConvenioDesde = value;
               }
	          }
        public bool IsConvenioDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsConvenioDesdeNull();
             }
	        }
        public String ConvenioHasta {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["ConvenioHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].ConvenioHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].ConvenioHasta = value;
               }
	          }
        public bool IsConvenioHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsConvenioHastaNull();
             }
	        }
        public String Centro1Desde {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Centro1Desde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Centro1Desde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Centro1Desde = value;
               }
	          }
        public bool IsCentro1DesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsCentro1DesdeNull();
             }
	        }
        public String Centro1Hasta {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Centro1Hasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Centro1Hasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Centro1Hasta = value;
               }
	          }
        public bool IsCentro1HastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsCentro1HastaNull();
             }
	        }
        public String Centro2Desde {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Centro2Desde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Centro2Desde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Centro2Desde = value;
               }
	          }
        public bool IsCentro2DesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsCentro2DesdeNull();
             }
	        }
        public String Centro2Hasta {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Centro2Hasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Centro2Hasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Centro2Hasta = value;
               }
	          }
        public bool IsCentro2HastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsCentro2HastaNull();
             }
	        }
        public Int32 Grupo_Id {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Grupo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Grupo_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Grupo_Id = value;
               }
	          }
        public bool IsGrupo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsGrupo_IdNull();
             }
	        }
        public String DescripcionGrupo {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["DescripcionGrupo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].DescripcionGrupo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].DescripcionGrupo = value;
               }
	          }
        public bool IsDescripcionGrupoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsDescripcionGrupoNull();
             }
	        }
        public Int32 Anio {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int32 Mes {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Mes"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Mes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Mes = value;
               }
	          }
        public bool IsMesNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsMesNull();
             }
	        }
        public Int32 Quincena {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Quincena"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Quincena;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Quincena = value;
               }
	          }
        public bool IsQuincenaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsQuincenaNull();
             }
	        }
        public Int32 Semana {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Semana"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Semana;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Semana = value;
               }
	          }
        public bool IsSemanaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsSemanaNull();
             }
	        }
        public Int32 Decena {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Decena"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Decena;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Decena = value;
               }
	          }
        public bool IsDecenaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsDecenaNull();
             }
	        }
        public Int32 Vez {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Vez"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Vez;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Vez = value;
               }
	          }
        public bool IsVezNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsVezNull();
             }
	        }
        public String GenerarBy {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["GenerarBy"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].GenerarBy;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].GenerarBy = value;
               }
	          }
        public bool IsGenerarByNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsGenerarByNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueInfDefiniblesImpresionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueInfDefiniblesImpresionDS );
     }
     public sueInfDefiniblesImpresionActionExchange() : base( "sueInfDefiniblesImpresion" ) {
     }

     public sueInfDefiniblesImpresionActionExchange(sueInfDefiniblesImpresionActionEnum.EnumsueInfDefiniblesImpresionAction pAccion) : base(sueInfDefiniblesImpresionActionEnum.GetAccionsueInfDefiniblesImpresionAction(pAccion)) {
     }

     public sueInfDefiniblesImpresionActionExchange(sueInfDefiniblesImpresionActionEnum.EnumsueInfDefiniblesImpresionAction pAccion, SueldosCommon.sueInfDefiniblesImpresionDS pdsParam) : base(sueInfDefiniblesImpresionActionEnum.GetAccionsueInfDefiniblesImpresionAction(pAccion), pdsParam) {
     }

     public sueInfDefiniblesImpresionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueInfDefiniblesImpresionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueInfDefiniblesImpresionDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueInfDefiniblesImpresionDS)mParam;
	        }
     }
  }
}
