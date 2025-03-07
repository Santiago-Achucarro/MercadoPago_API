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
    public class sueGenerarArchivosTxtActionExchange : Framework.Core.Exchange{

        public String Archivo_Id {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Archivo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Archivo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Archivo_Id = value;
               }
	          }
        public bool IsArchivo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsArchivo_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 LegajoDesde {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["LegajoDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].LegajoDesde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].LegajoDesde = value;
               }
	          }
        public bool IsLegajoDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsLegajoDesdeNull();
             }
	        }
        public Int32 LegajoHasta {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["LegajoHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].LegajoHasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].LegajoHasta = value;
               }
	          }
        public bool IsLegajoHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsLegajoHastaNull();
             }
	        }
        public String SucursalDesde {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["SucursalDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].SucursalDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].SucursalDesde = value;
               }
	          }
        public bool IsSucursalDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsSucursalDesdeNull();
             }
	        }
        public String SucursalHasta {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["SucursalHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].SucursalHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].SucursalHasta = value;
               }
	          }
        public bool IsSucursalHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsSucursalHastaNull();
             }
	        }
        public String GenerarBy {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["GenerarBy"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].GenerarBy;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].GenerarBy = value;
               }
	          }
        public bool IsGenerarByNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsGenerarByNull();
             }
	        }
        public String DescripcionGrupos {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["DescripcionGrupos"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].DescripcionGrupos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].DescripcionGrupos = value;
               }
	          }
        public bool IsDescripcionGruposNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsDescripcionGruposNull();
             }
	        }
        public String Txt {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Txt"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Txt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Txt = value;
               }
	          }
        public bool IsTxtNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsTxtNull();
             }
	        }
        public String Grupo_Id {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Grupo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Grupo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Grupo_Id = value;
               }
	          }
        public bool IsGrupo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsGrupo_IdNull();
             }
	        }
        public String GrupoDescripcion {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["GrupoDescripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].GrupoDescripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].GrupoDescripcion = value;
               }
	          }
        public bool IsGrupoDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsGrupoDescripcionNull();
             }
	        }
        public Int32 Anio {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Anio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public Int32 Mes {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Mes"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Mes;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Mes = value;
               }
	          }
        public bool IsMesNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsMesNull();
             }
	        }
        public Int32 Quincena {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Quincena"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Quincena;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Quincena = value;
               }
	          }
        public bool IsQuincenaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsQuincenaNull();
             }
	        }
        public Int32 Semana {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Semana"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Semana;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Semana = value;
               }
	          }
        public bool IsSemanaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsSemanaNull();
             }
	        }
        public Int32 Decena {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Decena"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Decena;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Decena = value;
               }
	          }
        public bool IsDecenaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsDecenaNull();
             }
	        }
        public Int32 Vez {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Vez"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Vez;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Vez = value;
               }
	          }
        public bool IsVezNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsVezNull();
             }
	        }
        public String TipoPagoDesde {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["TipoPagoDesde"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].TipoPagoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].TipoPagoDesde = value;
               }
	          }
        public bool IsTipoPagoDesdeNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsTipoPagoDesdeNull();
             }
	        }
        public String TipoPagoHasta {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["TipoPagoHasta"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].TipoPagoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].TipoPagoHasta = value;
               }
	          }
        public bool IsTipoPagoHastaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsTipoPagoHastaNull();
             }
	        }
        public String Texto1 {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Texto1"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Texto1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Texto1 = value;
               }
	          }
        public bool IsTexto1Null {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsTexto1Null();
             }
	        }
        public String Texto2 {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Texto2"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Texto2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Texto2 = value;
               }
	          }
        public bool IsTexto2Null {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsTexto2Null();
             }
	        }
        public String Texto3 {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Texto3"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Texto3;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Texto3 = value;
               }
	          }
        public bool IsTexto3Null {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsTexto3Null();
             }
	        }
        public DateTime Fecha1 {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Fecha1"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Fecha1;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Fecha1 = value;
               }
	          }
        public bool IsFecha1Null {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsFecha1Null();
             }
	        }
        public DateTime Fecha2 {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Fecha2"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Fecha2;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Fecha2 = value;
               }
	          }
        public bool IsFecha2Null {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsFecha2Null();
             }
	        }
        public DateTime Fecha3 {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Fecha3"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Fecha3;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Fecha3 = value;
               }
	          }
        public bool IsFecha3Null {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsFecha3Null();
             }
	        }
        public Int32 LegajoActual {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["LegajoActual"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].LegajoActual;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].LegajoActual = value;
               }
	          }
        public bool IsLegajoActualNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsLegajoActualNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGenerarArchivosTxtDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueGenerarArchivosTxtDS );
     }
     public sueGenerarArchivosTxtActionExchange() : base( "sueGenerarArchivosTxt" ) {
     }

     public sueGenerarArchivosTxtActionExchange(sueGenerarArchivosTxtActionEnum.EnumsueGenerarArchivosTxtAction pAccion) : base(sueGenerarArchivosTxtActionEnum.GetAccionsueGenerarArchivosTxtAction(pAccion)) {
     }

     public sueGenerarArchivosTxtActionExchange(sueGenerarArchivosTxtActionEnum.EnumsueGenerarArchivosTxtAction pAccion, SueldosCommon.sueGenerarArchivosTxtDS pdsParam) : base(sueGenerarArchivosTxtActionEnum.GetAccionsueGenerarArchivosTxtAction(pAccion), pdsParam) {
     }

     public sueGenerarArchivosTxtActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueGenerarArchivosTxtDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueGenerarArchivosTxtDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueGenerarArchivosTxtDS)mParam;
	        }
     }
  }
}
