using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace StockExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class stkHojaDeRutaActionExchange : Framework.Core.Exchange{

        public Int32 stkHojaDeRuta {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["stkHojaDeRuta"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].stkHojaDeRuta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].stkHojaDeRuta = value;
               }
	          }
        public bool IsstkHojaDeRutaNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsstkHojaDeRutaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public DateTime FechaRegistro {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public String FormaEntrega_Id {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["FormaEntrega_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].FormaEntrega_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].FormaEntrega_Id = value;
               }
	          }
        public bool IsFormaEntrega_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsFormaEntrega_IdNull();
             }
	        }
        public String ForEntregaRazonSocial {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["ForEntregaRazonSocial"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].ForEntregaRazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].ForEntregaRazonSocial = value;
               }
	          }
        public bool IsForEntregaRazonSocialNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsForEntregaRazonSocialNull();
             }
	        }
        public String Patente_Id {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["Patente_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Patente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Patente_Id = value;
               }
	          }
        public bool IsPatente_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsPatente_IdNull();
             }
	        }
        public String DescripcionCamiones {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["DescripcionCamiones"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionCamiones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionCamiones = value;
               }
	          }
        public bool IsDescripcionCamionesNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsDescripcionCamionesNull();
             }
	        }
        public String PatenteAcoplado {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["PatenteAcoplado"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].PatenteAcoplado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].PatenteAcoplado = value;
               }
	          }
        public bool IsPatenteAcopladoNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsPatenteAcopladoNull();
             }
	        }
        public String DescripcionAcoplado {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["DescripcionAcoplado"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionAcoplado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionAcoplado = value;
               }
	          }
        public bool IsDescripcionAcopladoNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsDescripcionAcopladoNull();
             }
	        }
        public String Reparto {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["Reparto"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Reparto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Reparto = value;
               }
	          }
        public bool IsRepartoNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsRepartoNull();
             }
	        }
        public Int32 Reparto_Id {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["Reparto_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Reparto_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Reparto_Id = value;
               }
	          }
        public bool IsReparto_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsReparto_IdNull();
             }
	        }
        public String ClienteDesde {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["ClienteDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].ClienteDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].ClienteDesde = value;
               }
	          }
        public bool IsClienteDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsClienteDesdeNull();
             }
	        }
        public String RazonSocialClieD {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["RazonSocialClieD"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].RazonSocialClieD;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].RazonSocialClieD = value;
               }
	          }
        public bool IsRazonSocialClieDNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsRazonSocialClieDNull();
             }
	        }
        public String ClienteHasta {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["ClienteHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].ClienteHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].ClienteHasta = value;
               }
	          }
        public bool IsClienteHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsClienteHastaNull();
             }
	        }
        public String RazonSocialClieH {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["RazonSocialClieH"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].RazonSocialClieH;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].RazonSocialClieH = value;
               }
	          }
        public bool IsRazonSocialClieHNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsRazonSocialClieHNull();
             }
	        }
        public String ZonaDesde {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["ZonaDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].ZonaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].ZonaDesde = value;
               }
	          }
        public bool IsZonaDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsZonaDesdeNull();
             }
	        }
        public String DescripcionZonaD {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["DescripcionZonaD"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionZonaD;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionZonaD = value;
               }
	          }
        public bool IsDescripcionZonaDNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsDescripcionZonaDNull();
             }
	        }
        public String ZonaHasta {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["ZonaHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].ZonaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].ZonaHasta = value;
               }
	          }
        public bool IsZonaHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsZonaHastaNull();
             }
	        }
        public String DescripcionZonaH {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["DescripcionZonaH"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionZonaH;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionZonaH = value;
               }
	          }
        public bool IsDescripcionZonaHNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsDescripcionZonaHNull();
             }
	        }
        public String RegionDesde {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["RegionDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].RegionDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].RegionDesde = value;
               }
	          }
        public bool IsRegionDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsRegionDesdeNull();
             }
	        }
        public String DescripcionRegionD {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["DescripcionRegionD"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionRegionD;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionRegionD = value;
               }
	          }
        public bool IsDescripcionRegionDNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsDescripcionRegionDNull();
             }
	        }
        public String RegionHasta {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["RegionHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].RegionHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].RegionHasta = value;
               }
	          }
        public bool IsRegionHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsRegionHastaNull();
             }
	        }
        public String DescripcionRegionH {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["DescripcionRegionH"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionRegionH;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionRegionH = value;
               }
	          }
        public bool IsDescripcionRegionHNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsDescripcionRegionHNull();
             }
	        }
        public String TipoClieDesde {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["TipoClieDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].TipoClieDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].TipoClieDesde = value;
               }
	          }
        public bool IsTipoClieDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsTipoClieDesdeNull();
             }
	        }
        public String DescripcionTipoClieD {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["DescripcionTipoClieD"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionTipoClieD;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionTipoClieD = value;
               }
	          }
        public bool IsDescripcionTipoClieDNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsDescripcionTipoClieDNull();
             }
	        }
        public String TipoClieHasta {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["TipoClieHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].TipoClieHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].TipoClieHasta = value;
               }
	          }
        public bool IsTipoClieHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsTipoClieHastaNull();
             }
	        }
        public String DescripcionTipoClieH {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["DescripcionTipoClieH"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionTipoClieH;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionTipoClieH = value;
               }
	          }
        public bool IsDescripcionTipoClieHNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsDescripcionTipoClieHNull();
             }
	        }
        public String FormaDesde {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["FormaDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].FormaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].FormaDesde = value;
               }
	          }
        public bool IsFormaDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsFormaDesdeNull();
             }
	        }
        public String DescripcionFormaD {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["DescripcionFormaD"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionFormaD;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionFormaD = value;
               }
	          }
        public bool IsDescripcionFormaDNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsDescripcionFormaDNull();
             }
	        }
        public String FormaHasta {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["FormaHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].FormaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].FormaHasta = value;
               }
	          }
        public bool IsFormaHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsFormaHastaNull();
             }
	        }
        public String DescripcionFormaH {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["DescripcionFormaH"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionFormaH;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].DescripcionFormaH = value;
               }
	          }
        public bool IsDescripcionFormaHNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsDescripcionFormaHNull();
             }
	        }
        public String SucursalDesde {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["SucursalDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].SucursalDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].SucursalDesde = value;
               }
	          }
        public bool IsSucursalDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsSucursalDesdeNull();
             }
	        }
        public String SucursalHasta {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["SucursalHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].SucursalHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].SucursalHasta = value;
               }
	          }
        public bool IsSucursalHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsSucursalHastaNull();
             }
	        }
        public Boolean FiltroXFecha {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["FiltroXFecha"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].FiltroXFecha;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].FiltroXFecha = value;
               }
	          }
        public bool IsFiltroXFechaNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsFiltroXFechaNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String Estado {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["Estado"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Estado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Estado = value;
               }
	          }
        public bool IsEstadoNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsEstadoNull();
             }
	        }
        public String Chofer {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["Chofer"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Chofer;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Chofer = value;
               }
	          }
        public bool IsChoferNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsChoferNull();
             }
	        }
        public Boolean ReporteDetallado {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["ReporteDetallado"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].ReporteDetallado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].ReporteDetallado = value;
               }
	          }
        public bool IsReporteDetalladoNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsReporteDetalladoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkHojaDeRutaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkHojaDeRutaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkHojaDeRutaDS );
     }
     public stkHojaDeRutaActionExchange() : base( "stkHojaDeRuta" ) {
     }

     public stkHojaDeRutaActionExchange(stkHojaDeRutaActionEnum.EnumstkHojaDeRutaAction pAccion) : base(stkHojaDeRutaActionEnum.GetAccionstkHojaDeRutaAction(pAccion)) {
     }

     public stkHojaDeRutaActionExchange(stkHojaDeRutaActionEnum.EnumstkHojaDeRutaAction pAccion, StockCommon.stkHojaDeRutaDS pdsParam) : base(stkHojaDeRutaActionEnum.GetAccionstkHojaDeRutaAction(pAccion), pdsParam) {
     }

     public stkHojaDeRutaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkHojaDeRutaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public stkHojaDeRutaActionExchange(StockCommon.stkHojaDeRutaDS pDS) : base() {
     this.Action = "";
     this.mParam = new StockCommon.stkHojaDeRutaDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkHojaDeRutaDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkHojaDeRutaDS)mParam;
	        }
     }
  }
}
