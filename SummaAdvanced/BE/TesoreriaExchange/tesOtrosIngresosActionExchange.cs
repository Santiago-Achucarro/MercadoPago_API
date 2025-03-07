using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesoreriaExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesOtrosIngresosActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int64 tesMovimientos {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public String Tipomov {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Tipomov"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Tipomov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Tipomov = value;
               }
	          }
        public bool IsTipomovNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsTipomovNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public DateTime FechaRegistro {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescrpcionMoneda {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["DescrpcionMoneda"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].DescrpcionMoneda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].DescrpcionMoneda = value;
               }
	          }
        public bool IsDescrpcionMonedaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsDescrpcionMonedaNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public Decimal CambioMonedaOriginal {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["CambioMonedaOriginal"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].CambioMonedaOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].CambioMonedaOriginal = value;
               }
	          }
        public bool IsCambioMonedaOriginalNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsCambioMonedaOriginalNull();
             }
	        }
        public Boolean Anulado {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Anulado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Anulado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Anulado = value;
               }
	          }
        public bool IsAnuladoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsAnuladoNull();
             }
	        }
        public String Observaciones {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Formulario_Id {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Formulario_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Formulario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Formulario_Id = value;
               }
	          }
        public bool IsFormulario_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsFormulario_IdNull();
             }
	        }
        public String DescripcionFormulario {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["DescripcionFormulario"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].DescripcionFormulario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].DescripcionFormulario = value;
               }
	          }
        public bool IsDescripcionFormularioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsDescripcionFormularioNull();
             }
	        }
        public String SubTipo_Id {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["SubTipo_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].SubTipo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].SubTipo_Id = value;
               }
	          }
        public bool IsSubTipo_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsSubTipo_IdNull();
             }
	        }
        public String DescripcionSubTiposMov {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["DescripcionSubTiposMov"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].DescripcionSubTiposMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].DescripcionSubTiposMov = value;
               }
	          }
        public bool IsDescripcionSubTiposMovNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsDescripcionSubTiposMovNull();
             }
	        }
        public DateTime Fecha_Real {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Fecha_Real"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Fecha_Real;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Fecha_Real = value;
               }
	          }
        public bool IsFecha_RealNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsFecha_RealNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String RazonSocialCliente {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["RazonSocialCliente"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].RazonSocialCliente;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].RazonSocialCliente = value;
               }
	          }
        public bool IsRazonSocialClienteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsRazonSocialClienteNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String RazonSocialProveedor {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["RazonSocialProveedor"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].RazonSocialProveedor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].RazonSocialProveedor = value;
               }
	          }
        public bool IsRazonSocialProveedorNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsRazonSocialProveedorNull();
             }
	        }
        public Decimal TotalDebe {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["TotalDebe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].TotalDebe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].TotalDebe = value;
               }
	          }
        public bool IsTotalDebeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsTotalDebeNull();
             }
	        }
        public Decimal TotalHaber {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["TotalHaber"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].TotalHaber;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].TotalHaber = value;
               }
	          }
        public bool IsTotalHaberNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsTotalHaberNull();
             }
	        }
        public Decimal TotalHabilitado {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["TotalHabilitado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].TotalHabilitado;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].TotalHabilitado = value;
               }
	          }
        public bool IsTotalHabilitadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsTotalHabilitadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsExisteNull();
             }
	        }
        public Boolean ControlaFormulario {
            get {
                if(((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0]["ControlaFormulario"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].ControlaFormulario;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].ControlaFormulario = value;
               }
	          }
        public bool IsControlaFormularioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMovimientosDatosBaseDS)mParam).Principal[0].IsControlaFormularioNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesMovimientosDatosBaseDS );
     }
     public tesOtrosIngresosActionExchange() : base( "tesOtrosIngresos" ) {
     }

     public tesOtrosIngresosActionExchange(tesOtrosIngresosActionEnum.EnumtesOtrosIngresosAction pAccion) : base(tesOtrosIngresosActionEnum.GetAcciontesOtrosIngresosAction(pAccion)) {
     }

     public tesOtrosIngresosActionExchange(tesOtrosIngresosActionEnum.EnumtesOtrosIngresosAction pAccion, TesoreriaCommon.tesMovimientosDatosBaseDS pdsParam) : base(tesOtrosIngresosActionEnum.GetAcciontesOtrosIngresosAction(pAccion), pdsParam) {
     }

     public tesOtrosIngresosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesMovimientosDatosBaseDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesMovimientosDatosBaseDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesMovimientosDatosBaseDS)mParam;
	        }
     }
  }
}
