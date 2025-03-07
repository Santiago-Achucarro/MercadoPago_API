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
    public class comMovpAnexoActionExchange : Framework.Core.Exchange{

        public Int64 Asiento_Id {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public Decimal CambioMonedaOriginal {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["CambioMonedaOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].CambioMonedaOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].CambioMonedaOriginal = value;
               }
	          }
        public bool IsCambioMonedaOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsCambioMonedaOriginalNull();
             }
	        }
        public String Observaciones {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Int64 tesRengMovi_Id {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["tesRengMovi_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].tesRengMovi_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].tesRengMovi_Id = value;
               }
	          }
        public bool IstesRengMovi_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IstesRengMovi_IdNull();
             }
	        }
        public Int32 RenglonRengMovi {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["RenglonRengMovi"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].RenglonRengMovi;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].RenglonRengMovi = value;
               }
	          }
        public bool IsRenglonRengMoviNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsRenglonRengMoviNull();
             }
	        }
        public Int32 conRenglonProv {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["conRenglonProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].conRenglonProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].conRenglonProv = value;
               }
	          }
        public bool IsconRenglonProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsconRenglonProvNull();
             }
	        }
        public Decimal Tipomov {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Tipomov"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Tipomov;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Tipomov = value;
               }
	          }
        public bool IsTipomovNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsTipomovNull();
             }
	        }
        public DateTime Fecha_Contable {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Fecha_Contable"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Fecha_Contable;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Fecha_Contable = value;
               }
	          }
        public bool IsFecha_ContableNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsFecha_ContableNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Decimal ImporteMonedaOriginal {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["ImporteMonedaOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].ImporteMonedaOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].ImporteMonedaOriginal = value;
               }
	          }
        public bool IsImporteMonedaOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsImporteMonedaOriginalNull();
             }
	        }
        public String Cartera_Id {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public String DescripcionCartera {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["DescripcionCartera"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].DescripcionCartera;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].DescripcionCartera = value;
               }
	          }
        public bool IsDescripcionCarteraNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsDescripcionCarteraNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuenta {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["DescripcionCuenta"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].DescripcionCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].DescripcionCuenta = value;
               }
	          }
        public bool IsDescripcionCuentaNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsDescripcionCuentaNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public String CUIT {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["CUIT"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].CUIT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].CUIT = value;
               }
	          }
        public bool IsCUITNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsCUITNull();
             }
	        }
        public Int64 genEntidades {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["genEntidades"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].genEntidades;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].genEntidades = value;
               }
	          }
        public bool IsgenEntidadesNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsgenEntidadesNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String Direccion1 {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Direccion1"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Direccion1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Direccion1 = value;
               }
	          }
        public bool IsDireccion1Null {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsDireccion1Null();
             }
	        }
        public String Direccion2 {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Direccion2"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Direccion2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Direccion2 = value;
               }
	          }
        public bool IsDireccion2Null {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsDireccion2Null();
             }
	        }
        public String Localidad {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Localidad"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Localidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Localidad = value;
               }
	          }
        public bool IsLocalidadNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsLocalidadNull();
             }
	        }
        public String Cod_Postal {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Cod_Postal"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Cod_Postal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Cod_Postal = value;
               }
	          }
        public bool IsCod_PostalNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsCod_PostalNull();
             }
	        }
        public String Provincia_id {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Provincia_id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Provincia_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Provincia_id = value;
               }
	          }
        public bool IsProvincia_idNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsProvincia_idNull();
             }
	        }
        public String DescripcionProvincia {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["DescripcionProvincia"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].DescripcionProvincia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].DescripcionProvincia = value;
               }
	          }
        public bool IsDescripcionProvinciaNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsDescripcionProvinciaNull();
             }
	        }
        public DateTime Fecha_Ane {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Fecha_Ane"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Fecha_Ane;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Fecha_Ane = value;
               }
	          }
        public bool IsFecha_AneNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsFecha_AneNull();
             }
	        }
        public DateTime FechaFiscal {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["FechaFiscal"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].FechaFiscal;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].FechaFiscal = value;
               }
	          }
        public bool IsFechaFiscalNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsFechaFiscalNull();
             }
	        }
        public Int16 Origen_Id {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Origen_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Origen_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Origen_Id = value;
               }
	          }
        public bool IsOrigen_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsOrigen_IdNull();
             }
	        }
        public String DescripcioncomOrigenesFiscales {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["DescripcioncomOrigenesFiscales"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].DescripcioncomOrigenesFiscales;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].DescripcioncomOrigenesFiscales = value;
               }
	          }
        public bool IsDescripcioncomOrigenesFiscalesNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsDescripcioncomOrigenesFiscalesNull();
             }
	        }
        public String CondFiscal_Id {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["CondFiscal_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].CondFiscal_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].CondFiscal_Id = value;
               }
	          }
        public bool IsCondFiscal_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsCondFiscal_IdNull();
             }
	        }
        public String DescripcionCondFiscal {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["DescripcionCondFiscal"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].DescripcionCondFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].DescripcionCondFiscal = value;
               }
	          }
        public bool IsDescripcionCondFiscalNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsDescripcionCondFiscalNull();
             }
	        }
        public Boolean VieneDeFiscal {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["VieneDeFiscal"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].VieneDeFiscal;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].VieneDeFiscal = value;
               }
	          }
        public bool IsVieneDeFiscalNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsVieneDeFiscalNull();
             }
	        }
        public String XMLFiscal {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["XMLFiscal"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].XMLFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].XMLFiscal = value;
               }
	          }
        public bool IsXMLFiscalNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsXMLFiscalNull();
             }
	        }
        public String ClaveFiscal {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["ClaveFiscal"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].ClaveFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].ClaveFiscal = value;
               }
	          }
        public bool IsClaveFiscalNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsClaveFiscalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovpAnexoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovpAnexoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovpAnexoDS );
     }
     public comMovpAnexoActionExchange() : base( "comMovpAnexo" ) {
     }

     public comMovpAnexoActionExchange(comMovpAnexoActionEnum.EnumcomMovpAnexoAction pAccion) : base(comMovpAnexoActionEnum.GetAccioncomMovpAnexoAction(pAccion)) {
     }

     public comMovpAnexoActionExchange(comMovpAnexoActionEnum.EnumcomMovpAnexoAction pAccion, ComprasCommon.comMovpAnexoDS pdsParam) : base(comMovpAnexoActionEnum.GetAccioncomMovpAnexoAction(pAccion), pdsParam) {
     }

     public comMovpAnexoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovpAnexoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovpAnexoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovpAnexoDS)mParam;
	        }
     }
  }
}
