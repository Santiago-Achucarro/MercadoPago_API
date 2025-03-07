using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venBonifTemporalActionExchange : Framework.Core.Exchange{

        public Int32 venBonifTemporal {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["venBonifTemporal"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].venBonifTemporal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].venBonifTemporal = value;
               }
	          }
        public bool IsvenBonifTemporalNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsvenBonifTemporalNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Boolean PTodasLasEmpresas {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["PTodasLasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].PTodasLasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].PTodasLasEmpresas = value;
               }
	          }
        public bool IsPTodasLasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsPTodasLasEmpresasNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String SucursalDesde {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["SucursalDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].SucursalDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].SucursalDesde = value;
               }
	          }
        public bool IsSucursalDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsSucursalDesdeNull();
             }
	        }
        public String SucursalHasta {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["SucursalHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].SucursalHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].SucursalHasta = value;
               }
	          }
        public bool IsSucursalHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsSucursalHastaNull();
             }
	        }
        public String ClienteDesde {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["ClienteDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].ClienteDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].ClienteDesde = value;
               }
	          }
        public bool IsClienteDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsClienteDesdeNull();
             }
	        }
        public String ClienteHasta {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["ClienteHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].ClienteHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].ClienteHasta = value;
               }
	          }
        public bool IsClienteHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsClienteHastaNull();
             }
	        }
        public Int32 SucursalClieDesde {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["SucursalClieDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].SucursalClieDesde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].SucursalClieDesde = value;
               }
	          }
        public bool IsSucursalClieDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsSucursalClieDesdeNull();
             }
	        }
        public Int32 SucursalClieHasta {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["SucursalClieHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].SucursalClieHasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].SucursalClieHasta = value;
               }
	          }
        public bool IsSucursalClieHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsSucursalClieHastaNull();
             }
	        }
        public String TipoClieDesde {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["TipoClieDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].TipoClieDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].TipoClieDesde = value;
               }
	          }
        public bool IsTipoClieDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsTipoClieDesdeNull();
             }
	        }
        public String TipoClieHasta {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["TipoClieHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].TipoClieHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].TipoClieHasta = value;
               }
	          }
        public bool IsTipoClieHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsTipoClieHastaNull();
             }
	        }
        public String ProductoDesde {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["ProductoDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].ProductoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].ProductoDesde = value;
               }
	          }
        public bool IsProductoDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsProductoDesdeNull();
             }
	        }
        public String ProductoHasta {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["ProductoHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].ProductoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].ProductoHasta = value;
               }
	          }
        public bool IsProductoHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsProductoHastaNull();
             }
	        }
        public String TipoProductoDesde {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["TipoProductoDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].TipoProductoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].TipoProductoDesde = value;
               }
	          }
        public bool IsTipoProductoDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsTipoProductoDesdeNull();
             }
	        }
        public String TipoProductoHasta {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["TipoProductoHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].TipoProductoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].TipoProductoHasta = value;
               }
	          }
        public bool IsTipoProductoHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsTipoProductoHastaNull();
             }
	        }
        public String Bonificacion {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["Bonificacion"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Bonificacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Bonificacion = value;
               }
	          }
        public bool IsBonificacionNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsBonificacionNull();
             }
	        }
        public String FamiliaDesde {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["FamiliaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].FamiliaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].FamiliaDesde = value;
               }
	          }
        public bool IsFamiliaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsFamiliaDesdeNull();
             }
	        }
        public String FamiliaHasta {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["FamiliaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].FamiliaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].FamiliaHasta = value;
               }
	          }
        public bool IsFamiliaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsFamiliaHastaNull();
             }
	        }
        public String GrupoDesde {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["GrupoDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].GrupoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].GrupoDesde = value;
               }
	          }
        public bool IsGrupoDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsGrupoDesdeNull();
             }
	        }
        public String GrupoHasta {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["GrupoHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].GrupoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].GrupoHasta = value;
               }
	          }
        public bool IsGrupoHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsGrupoHastaNull();
             }
	        }
        public DateTime FechaRegistro {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Int32 Prioridad {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["Prioridad"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Prioridad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Prioridad = value;
               }
	          }
        public bool IsPrioridadNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsPrioridadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venBonifTemporalDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venBonifTemporalDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venBonifTemporalDS );
     }
     public venBonifTemporalActionExchange() : base( "venBonifTemporal" ) {
     }

     public venBonifTemporalActionExchange(venBonifTemporalActionEnum.EnumvenBonifTemporalAction pAccion) : base(venBonifTemporalActionEnum.GetAccionvenBonifTemporalAction(pAccion)) {
     }

     public venBonifTemporalActionExchange(venBonifTemporalActionEnum.EnumvenBonifTemporalAction pAccion, VentasCommon.venBonifTemporalDS pdsParam) : base(venBonifTemporalActionEnum.GetAccionvenBonifTemporalAction(pAccion), pdsParam) {
     }

     public venBonifTemporalActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venBonifTemporalDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venBonifTemporalActionExchange(VentasCommon.venBonifTemporalDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venBonifTemporalDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venBonifTemporalDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venBonifTemporalDS)mParam;
	        }
     }
  }
}
