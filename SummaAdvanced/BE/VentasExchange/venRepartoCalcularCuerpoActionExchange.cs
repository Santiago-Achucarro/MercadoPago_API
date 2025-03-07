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
    public class venRepartoCalcularCuerpoActionExchange : Framework.Core.Exchange{

        public Int32 venReparto {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["venReparto"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].venReparto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].venReparto = value;
               }
	          }
        public bool IsvenRepartoNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsvenRepartoNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public DateTime FechaReparto {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["FechaReparto"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].FechaReparto;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].FechaReparto = value;
               }
	          }
        public bool IsFechaRepartoNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsFechaRepartoNull();
             }
	        }
        public DateTime FechaEntrega {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["FechaEntrega"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].FechaEntrega;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].FechaEntrega = value;
               }
	          }
        public bool IsFechaEntregaNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsFechaEntregaNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String DescripcionDepositos {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["DescripcionDepositos"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].DescripcionDepositos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].DescripcionDepositos = value;
               }
	          }
        public bool IsDescripcionDepositosNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsDescripcionDepositosNull();
             }
	        }
        public String ZonaDesde {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["ZonaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].ZonaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].ZonaDesde = value;
               }
	          }
        public bool IsZonaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsZonaDesdeNull();
             }
	        }
        public String ZonaHasta {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["ZonaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].ZonaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].ZonaHasta = value;
               }
	          }
        public bool IsZonaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsZonaHastaNull();
             }
	        }
        public String TipoClieDesde {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["TipoClieDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].TipoClieDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].TipoClieDesde = value;
               }
	          }
        public bool IsTipoClieDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsTipoClieDesdeNull();
             }
	        }
        public String TipoClieHasta {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["TipoClieHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].TipoClieHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].TipoClieHasta = value;
               }
	          }
        public bool IsTipoClieHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsTipoClieHastaNull();
             }
	        }
        public String ClienteDesde {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["ClienteDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].ClienteDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].ClienteDesde = value;
               }
	          }
        public bool IsClienteDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsClienteDesdeNull();
             }
	        }
        public String ClienteHasta {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["ClienteHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].ClienteHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].ClienteHasta = value;
               }
	          }
        public bool IsClienteHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsClienteHastaNull();
             }
	        }
        public String DepoPedido_Id {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["DepoPedido_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].DepoPedido_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].DepoPedido_Id = value;
               }
	          }
        public bool IsDepoPedido_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsDepoPedido_IdNull();
             }
	        }
        public String DescripcionDepoPedido {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["DescripcionDepoPedido"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].DescripcionDepoPedido;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].DescripcionDepoPedido = value;
               }
	          }
        public bool IsDescripcionDepoPedidoNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsDescripcionDepoPedidoNull();
             }
	        }
        public Boolean Automatico {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["Automatico"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Automatico;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Automatico = value;
               }
	          }
        public bool IsAutomaticoNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsAutomaticoNull();
             }
	        }
        public Boolean Cerrado {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["Cerrado"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Cerrado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Cerrado = value;
               }
	          }
        public bool IsCerradoNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsCerradoNull();
             }
	        }
        public Boolean IncluyeStockCero {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["IncluyeStockCero"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IncluyeStockCero;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IncluyeStockCero = value;
               }
	          }
        public bool IsIncluyeStockCeroNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsIncluyeStockCeroNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venRepartoCalcularCuerpoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venRepartoCalcularCuerpoDS );
     }
     public venRepartoCalcularCuerpoActionExchange() : base( "venRepartoCalcularCuerpo" ) {
     }

     public venRepartoCalcularCuerpoActionExchange(venRepartoCalcularCuerpoActionEnum.EnumvenRepartoCalcularCuerpoAction pAccion) : base(venRepartoCalcularCuerpoActionEnum.GetAccionvenRepartoCalcularCuerpoAction(pAccion)) {
     }

     public venRepartoCalcularCuerpoActionExchange(venRepartoCalcularCuerpoActionEnum.EnumvenRepartoCalcularCuerpoAction pAccion, VentasCommon.venRepartoCalcularCuerpoDS pdsParam) : base(venRepartoCalcularCuerpoActionEnum.GetAccionvenRepartoCalcularCuerpoAction(pAccion), pdsParam) {
     }

     public venRepartoCalcularCuerpoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venRepartoCalcularCuerpoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venRepartoCalcularCuerpoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venRepartoCalcularCuerpoDS)mParam;
	        }
     }
  }
}
