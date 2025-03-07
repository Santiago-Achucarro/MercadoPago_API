using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comFacturasConOrdenDeEmbarqueActionExchange : Framework.Core.Exchange{

        public Int64 comMovProv {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["comMovProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].comMovProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].comMovProv = value;
               }
	          }
        public bool IscomMovProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IscomMovProvNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public String Tipomov {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Tipomov"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Tipomov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Tipomov = value;
               }
	          }
        public bool IsTipomovNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsTipomovNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public DateTime FechaRegistro {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public Decimal CambioMonedaOriginal {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["CambioMonedaOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].CambioMonedaOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].CambioMonedaOriginal = value;
               }
	          }
        public bool IsCambioMonedaOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsCambioMonedaOriginalNull();
             }
	        }
        public Boolean Anulado {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Anulado"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Anulado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Anulado = value;
               }
	          }
        public bool IsAnuladoNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsAnuladoNull();
             }
	        }
        public String Observaciones {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public String Formulario {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Formulario"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Formulario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Formulario = value;
               }
	          }
        public bool IsFormularioNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsFormularioNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String DescripcionProveedores {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["DescripcionProveedores"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionProveedores;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionProveedores = value;
               }
	          }
        public bool IsDescripcionProveedoresNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsDescripcionProveedoresNull();
             }
	        }
        public Int32 TipoCtaProv {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["TipoCtaProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].TipoCtaProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].TipoCtaProv = value;
               }
	          }
        public bool IsTipoCtaProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsTipoCtaProvNull();
             }
	        }
        public String DescripcionProveedoresTipoPasivo {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["DescripcionProveedoresTipoPasivo"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionProveedoresTipoPasivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionProveedoresTipoPasivo = value;
               }
	          }
        public bool IsDescripcionProveedoresTipoPasivoNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsDescripcionProveedoresTipoPasivoNull();
             }
	        }
        public DateTime Fecha_CCP {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Fecha_CCP"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Fecha_CCP;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Fecha_CCP = value;
               }
	          }
        public bool IsFecha_CCPNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsFecha_CCPNull();
             }
	        }
        public Decimal Base_Ganancias {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Base_Ganancias"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Base_Ganancias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Base_Ganancias = value;
               }
	          }
        public bool IsBase_GananciasNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsBase_GananciasNull();
             }
	        }
        public Boolean Importacion {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Importacion"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Importacion;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Importacion = value;
               }
	          }
        public bool IsImportacionNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsImportacionNull();
             }
	        }
        public Int16 Origen_Id {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Origen_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Origen_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Origen_Id = value;
               }
	          }
        public bool IsOrigen_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsOrigen_IdNull();
             }
	        }
        public String DescripcionOrCredFisc {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["DescripcionOrCredFisc"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionOrCredFisc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionOrCredFisc = value;
               }
	          }
        public bool IsDescripcionOrCredFiscNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsDescripcionOrCredFiscNull();
             }
	        }
        public String CondPago_Id {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["CondPago_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].CondPago_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].CondPago_Id = value;
               }
	          }
        public bool IsCondPago_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsCondPago_IdNull();
             }
	        }
        public String DescripcionConPago {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["DescripcionConPago"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionConPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionConPago = value;
               }
	          }
        public bool IsDescripcionConPagoNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsDescripcionConPagoNull();
             }
	        }
        public String CondFiscal_Id {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["CondFiscal_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].CondFiscal_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].CondFiscal_Id = value;
               }
	          }
        public bool IsCondFiscal_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsCondFiscal_IdNull();
             }
	        }
        public String DescripcionCondFiscal {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["DescripcionCondFiscal"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionCondFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionCondFiscal = value;
               }
	          }
        public bool IsDescripcionCondFiscalNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsDescripcionCondFiscalNull();
             }
	        }
        public DateTime FechaFiscal {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["FechaFiscal"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].FechaFiscal;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].FechaFiscal = value;
               }
	          }
        public bool IsFechaFiscalNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsFechaFiscalNull();
             }
	        }
        public String ClaveFiscal {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["ClaveFiscal"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].ClaveFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].ClaveFiscal = value;
               }
	          }
        public bool IsClaveFiscalNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsClaveFiscalNull();
             }
	        }
        public Boolean VieneDeFiscal {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["VieneDeFiscal"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].VieneDeFiscal;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].VieneDeFiscal = value;
               }
	          }
        public bool IsVieneDeFiscalNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsVieneDeFiscalNull();
             }
	        }
        public String XMLFiscal {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["XMLFiscal"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].XMLFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].XMLFiscal = value;
               }
	          }
        public bool IsXMLFiscalNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsXMLFiscalNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Decimal Saldo {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Saldo"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Saldo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Saldo = value;
               }
	          }
        public bool IsSaldoNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsSaldoNull();
             }
	        }
        public Int32 TipoCompFE {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["TipoCompFE"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].TipoCompFE;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].TipoCompFE = value;
               }
	          }
        public bool IsTipoCompFENull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsTipoCompFENull();
             }
	        }
        public String DescripcionTipoCompFE {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["DescripcionTipoCompFE"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionTipoCompFE;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionTipoCompFE = value;
               }
	          }
        public bool IsDescripcionTipoCompFENull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsDescripcionTipoCompFENull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuenta {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["DescripcionCuenta"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionCuenta = value;
               }
	          }
        public bool IsDescripcionCuentaNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsDescripcionCuentaNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Decimal TipomovCont {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["TipomovCont"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].TipomovCont;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].TipomovCont = value;
               }
	          }
        public bool IsTipomovContNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsTipomovContNull();
             }
	        }
        public String Clase {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Clase"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Clase;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Clase = value;
               }
	          }
        public bool IsClaseNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsClaseNull();
             }
	        }
        public Decimal ImporteContable {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["ImporteContable"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].ImporteContable;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].ImporteContable = value;
               }
	          }
        public bool IsImporteContableNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsImporteContableNull();
             }
	        }
        public Int16 CantCuotas {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["CantCuotas"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].CantCuotas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].CantCuotas = value;
               }
	          }
        public bool IsCantCuotasNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsCantCuotasNull();
             }
	        }
        public DateTime FechaVencimiento {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["FechaVencimiento"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].FechaVencimiento;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].FechaVencimiento = value;
               }
	          }
        public bool IsFechaVencimientoNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsFechaVencimientoNull();
             }
	        }
        public String CtaProveedores {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["CtaProveedores"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].CtaProveedores;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].CtaProveedores = value;
               }
	          }
        public bool IsCtaProveedoresNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsCtaProveedoresNull();
             }
	        }
        public String DescripcionCtaProveedores {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["DescripcionCtaProveedores"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionCtaProveedores;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].DescripcionCtaProveedores = value;
               }
	          }
        public bool IsDescripcionCtaProveedoresNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsDescripcionCtaProveedoresNull();
             }
	        }
        public Boolean FacturaTesoreria {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["FacturaTesoreria"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].FacturaTesoreria;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].FacturaTesoreria = value;
               }
	          }
        public bool IsFacturaTesoreriaNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsFacturaTesoreriaNull();
             }
	        }
        public Boolean Cierre {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Cierre"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Cierre;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Cierre = value;
               }
	          }
        public bool IsCierreNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsCierreNull();
             }
	        }
        public DateTime FechaCierre {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["FechaCierre"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].FechaCierre;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].FechaCierre = value;
               }
	          }
        public bool IsFechaCierreNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsFechaCierreNull();
             }
	        }
        public String RFCPrveedor {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["RFCPrveedor"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].RFCPrveedor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].RFCPrveedor = value;
               }
	          }
        public bool IsRFCPrveedorNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsRFCPrveedorNull();
             }
	        }
        public Int32 RenglonDtoFin {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["RenglonDtoFin"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].RenglonDtoFin;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].RenglonDtoFin = value;
               }
	          }
        public bool IsRenglonDtoFinNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsRenglonDtoFinNull();
             }
	        }
        public String ArchivoXML {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["ArchivoXML"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].ArchivoXML;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].ArchivoXML = value;
               }
	          }
        public bool IsArchivoXMLNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsArchivoXMLNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comFacturasConOrdenDeEmbarqueDS );
     }
     public comFacturasConOrdenDeEmbarqueActionExchange() : base( "comFacturasConOrdenDeEmbarque" ) {
     }

     public comFacturasConOrdenDeEmbarqueActionExchange(comFacturasConOrdenDeEmbarqueActionEnum.EnumcomFacturasConOrdenDeEmbarqueAction pAccion) : base(comFacturasConOrdenDeEmbarqueActionEnum.GetAccioncomFacturasConOrdenDeEmbarqueAction(pAccion)) {
     }

     public comFacturasConOrdenDeEmbarqueActionExchange(comFacturasConOrdenDeEmbarqueActionEnum.EnumcomFacturasConOrdenDeEmbarqueAction pAccion, ComprasCommon.comFacturasConOrdenDeEmbarqueDS pdsParam) : base(comFacturasConOrdenDeEmbarqueActionEnum.GetAccioncomFacturasConOrdenDeEmbarqueAction(pAccion), pdsParam) {
     }

     public comFacturasConOrdenDeEmbarqueActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comFacturasConOrdenDeEmbarqueDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public comFacturasConOrdenDeEmbarqueActionExchange(ComprasCommon.comFacturasConOrdenDeEmbarqueDS pDS) : base() {
     this.Action = "";
     this.mParam = new ComprasCommon.comFacturasConOrdenDeEmbarqueDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comFacturasConOrdenDeEmbarqueDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comFacturasConOrdenDeEmbarqueDS)mParam;
	        }
     }
  }
}
