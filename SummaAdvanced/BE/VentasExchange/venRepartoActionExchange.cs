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
    public class venRepartoActionExchange : Framework.Core.Exchange{

        public Int32 venReparto {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["venReparto"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].venReparto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].venReparto = value;
               }
	          }
        public bool IsvenRepartoNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsvenRepartoNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String Sucursal {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public DateTime FechaReparto {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["FechaReparto"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].FechaReparto;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].FechaReparto = value;
               }
	          }
        public bool IsFechaRepartoNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsFechaRepartoNull();
             }
	        }
        public DateTime FechaEntrega {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["FechaEntrega"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].FechaEntrega;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].FechaEntrega = value;
               }
	          }
        public bool IsFechaEntregaNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsFechaEntregaNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDepositos {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["DescripcionDepositos"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].DescripcionDepositos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].DescripcionDepositos = value;
               }
	          }
        public bool IsDescripcionDepositosNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsDescripcionDepositosNull();
             }
	        }
        public String ZonaDesde {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["ZonaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].ZonaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].ZonaDesde = value;
               }
	          }
        public bool IsZonaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsZonaDesdeNull();
             }
	        }
        public String DescripcionZonaDesde {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["DescripcionZonaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].DescripcionZonaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].DescripcionZonaDesde = value;
               }
	          }
        public bool IsDescripcionZonaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsDescripcionZonaDesdeNull();
             }
	        }
        public String ZonaHasta {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["ZonaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].ZonaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].ZonaHasta = value;
               }
	          }
        public bool IsZonaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsZonaHastaNull();
             }
	        }
        public String DescripcionZonaHasta {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["DescripcionZonaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].DescripcionZonaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].DescripcionZonaHasta = value;
               }
	          }
        public bool IsDescripcionZonaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsDescripcionZonaHastaNull();
             }
	        }
        public String TipoClieDesde {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["TipoClieDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].TipoClieDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].TipoClieDesde = value;
               }
	          }
        public bool IsTipoClieDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsTipoClieDesdeNull();
             }
	        }
        public String DescripcionTipoClieDesde {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["DescripcionTipoClieDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].DescripcionTipoClieDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].DescripcionTipoClieDesde = value;
               }
	          }
        public bool IsDescripcionTipoClieDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsDescripcionTipoClieDesdeNull();
             }
	        }
        public String TipoClieHasta {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["TipoClieHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].TipoClieHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].TipoClieHasta = value;
               }
	          }
        public bool IsTipoClieHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsTipoClieHastaNull();
             }
	        }
        public String DescripcionTipoClieHasta {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["DescripcionTipoClieHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].DescripcionTipoClieHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].DescripcionTipoClieHasta = value;
               }
	          }
        public bool IsDescripcionTipoClieHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsDescripcionTipoClieHastaNull();
             }
	        }
        public String ClienteDesde {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["ClienteDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].ClienteDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].ClienteDesde = value;
               }
	          }
        public bool IsClienteDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsClienteDesdeNull();
             }
	        }
        public String DescripcionClienteDesde {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["DescripcionClienteDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].DescripcionClienteDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].DescripcionClienteDesde = value;
               }
	          }
        public bool IsDescripcionClienteDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsDescripcionClienteDesdeNull();
             }
	        }
        public String ClienteHasta {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["ClienteHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].ClienteHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].ClienteHasta = value;
               }
	          }
        public bool IsClienteHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsClienteHastaNull();
             }
	        }
        public String DescripcionClienteHasta {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["DescripcionClienteHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].DescripcionClienteHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].DescripcionClienteHasta = value;
               }
	          }
        public bool IsDescripcionClienteHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsDescripcionClienteHastaNull();
             }
	        }
        public String DepoPedido_Id {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["DepoPedido_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].DepoPedido_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].DepoPedido_Id = value;
               }
	          }
        public bool IsDepoPedido_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsDepoPedido_IdNull();
             }
	        }
        public String DescripcionDepoPedido {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["DescripcionDepoPedido"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].DescripcionDepoPedido;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].DescripcionDepoPedido = value;
               }
	          }
        public bool IsDescripcionDepoPedidoNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsDescripcionDepoPedidoNull();
             }
	        }
        public Boolean Automatico {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["Automatico"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].Automatico;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].Automatico = value;
               }
	          }
        public bool IsAutomaticoNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsAutomaticoNull();
             }
	        }
        public Boolean Cerrado {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["Cerrado"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].Cerrado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].Cerrado = value;
               }
	          }
        public bool IsCerradoNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsCerradoNull();
             }
	        }
        public Boolean IncluyeStockCero {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["IncluyeStockCero"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].IncluyeStockCero;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].IncluyeStockCero = value;
               }
	          }
        public bool IsIncluyeStockCeroNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsIncluyeStockCeroNull();
             }
	        }
        public String Mensaje {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["Mensaje"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].Mensaje;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].Mensaje = value;
               }
	          }
        public bool IsMensajeNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsMensajeNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String VolverACalcular {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["VolverACalcular"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].VolverACalcular;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].VolverACalcular = value;
               }
	          }
        public bool IsVolverACalcularNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsVolverACalcularNull();
             }
	        }
        public String PrimeraVez {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["PrimeraVez"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].PrimeraVez;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].PrimeraVez = value;
               }
	          }
        public bool IsPrimeraVezNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsPrimeraVezNull();
             }
	        }
        public Int32 Total {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["Total"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].Total;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].Total = value;
               }
	          }
        public bool IsTotalNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsTotalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venRepartoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venRepartoDS );
     }
     public venRepartoActionExchange() : base( "venReparto" ) {
     }

     public venRepartoActionExchange(venRepartoActionEnum.EnumvenRepartoAction pAccion) : base(venRepartoActionEnum.GetAccionvenRepartoAction(pAccion)) {
     }

     public venRepartoActionExchange(venRepartoActionEnum.EnumvenRepartoAction pAccion, VentasCommon.venRepartoDS pdsParam) : base(venRepartoActionEnum.GetAccionvenRepartoAction(pAccion), pdsParam) {
     }

     public venRepartoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venRepartoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venRepartoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venRepartoDS)mParam;
	        }
     }
  }
}
