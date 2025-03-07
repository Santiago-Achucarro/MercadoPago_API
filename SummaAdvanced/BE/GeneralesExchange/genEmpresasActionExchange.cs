using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genEmpresasActionExchange : Framework.Core.Exchange{

        public Int32 genEmpresas {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["genEmpresas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].genEmpresas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].genEmpresas = value;
               }
	          }
        public bool IsgenEmpresasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsgenEmpresasNull();
             }
	        }
        public String Empresa_Id {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Empresa_Id_Nueva {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Empresa_Id_Nueva"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Empresa_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Empresa_Id_Nueva = value;
               }
	          }
        public bool IsEmpresa_Id_NuevaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsEmpresa_Id_NuevaNull();
             }
	        }
        public String Detalle {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Detalle"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Detalle;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Detalle = value;
               }
	          }
        public bool IsDetalleNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDetalleNull();
             }
	        }
        public String Logo {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Logo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Logo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Logo = value;
               }
	          }
        public bool IsLogoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsLogoNull();
             }
	        }
        public String LogoOriginal {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["LogoOriginal"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].LogoOriginal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].LogoOriginal = value;
               }
	          }
        public bool IsLogoOriginalNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsLogoOriginalNull();
             }
	        }
        public String ExtensionArchivo {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["ExtensionArchivo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].ExtensionArchivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].ExtensionArchivo = value;
               }
	          }
        public bool IsExtensionArchivoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsExtensionArchivoNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMonedas {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["DescripcionMonedas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionMonedas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionMonedas = value;
               }
	          }
        public bool IsDescripcionMonedasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDescripcionMonedasNull();
             }
	        }
        public Int16 Pais_Id {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Pais_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Pais_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Pais_Id = value;
               }
	          }
        public bool IsPais_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsPais_IdNull();
             }
	        }
        public String DescripcionPaises {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["DescripcionPaises"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionPaises;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionPaises = value;
               }
	          }
        public bool IsDescripcionPaisesNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDescripcionPaisesNull();
             }
	        }
        public String Cuit {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Cuit"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Cuit;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Cuit = value;
               }
	          }
        public bool IsCuitNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCuitNull();
             }
	        }
        public String Calle {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Calle"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Calle;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Calle = value;
               }
	          }
        public bool IsCalleNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCalleNull();
             }
	        }
        public String NoExterior {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["NoExterior"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].NoExterior;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].NoExterior = value;
               }
	          }
        public bool IsNoExteriorNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsNoExteriorNull();
             }
	        }
        public String NoInterior {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["NoInterior"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].NoInterior;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].NoInterior = value;
               }
	          }
        public bool IsNoInteriorNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsNoInteriorNull();
             }
	        }
        public String Colonia {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Colonia"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Colonia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Colonia = value;
               }
	          }
        public bool IsColoniaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsColoniaNull();
             }
	        }
        public String Localidad {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Localidad"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Localidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Localidad = value;
               }
	          }
        public bool IsLocalidadNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsLocalidadNull();
             }
	        }
        public String Municipio {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Municipio"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Municipio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Municipio = value;
               }
	          }
        public bool IsMunicipioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsMunicipioNull();
             }
	        }
        public String Referencia {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Referencia"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Referencia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Referencia = value;
               }
	          }
        public bool IsReferenciaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsReferenciaNull();
             }
	        }
        public String Provincia_Id {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Provincia_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Provincia_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Provincia_Id = value;
               }
	          }
        public bool IsProvincia_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsProvincia_IdNull();
             }
	        }
        public String DescripcionProvincias {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["DescripcionProvincias"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionProvincias;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionProvincias = value;
               }
	          }
        public bool IsDescripcionProvinciasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDescripcionProvinciasNull();
             }
	        }
        public String CodigoPostal {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CodigoPostal"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CodigoPostal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CodigoPostal = value;
               }
	          }
        public bool IsCodigoPostalNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCodigoPostalNull();
             }
	        }
        public DateTime FechaInicioSumma {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["FechaInicioSumma"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaInicioSumma;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaInicioSumma = value;
               }
	          }
        public bool IsFechaInicioSummaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsFechaInicioSummaNull();
             }
	        }
        public DateTime FechaInicioSociedad {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["FechaInicioSociedad"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaInicioSociedad;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaInicioSociedad = value;
               }
	          }
        public bool IsFechaInicioSociedadNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsFechaInicioSociedadNull();
             }
	        }
        public DateTime FechaCierreVentas {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["FechaCierreVentas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCierreVentas;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCierreVentas = value;
               }
	          }
        public bool IsFechaCierreVentasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsFechaCierreVentasNull();
             }
	        }
        public DateTime FechaCierreCompras {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["FechaCierreCompras"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCierreCompras;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCierreCompras = value;
               }
	          }
        public bool IsFechaCierreComprasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsFechaCierreComprasNull();
             }
	        }
        public DateTime FechaCierreTesoreria {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["FechaCierreTesoreria"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCierreTesoreria;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCierreTesoreria = value;
               }
	          }
        public bool IsFechaCierreTesoreriaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsFechaCierreTesoreriaNull();
             }
	        }
        public DateTime FechaCierreStock {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["FechaCierreStock"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCierreStock;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCierreStock = value;
               }
	          }
        public bool IsFechaCierreStockNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsFechaCierreStockNull();
             }
	        }
        public DateTime FechaCalculoStock {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["FechaCalculoStock"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCalculoStock;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCalculoStock = value;
               }
	          }
        public bool IsFechaCalculoStockNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsFechaCalculoStockNull();
             }
	        }
        public DateTime FechaCierreSueldos {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["FechaCierreSueldos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCierreSueldos;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCierreSueldos = value;
               }
	          }
        public bool IsFechaCierreSueldosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsFechaCierreSueldosNull();
             }
	        }
        public String NumeroIIBB {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["NumeroIIBB"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].NumeroIIBB;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].NumeroIIBB = value;
               }
	          }
        public bool IsNumeroIIBBNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsNumeroIIBBNull();
             }
	        }
        public String IGJ {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["IGJ"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IGJ;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IGJ = value;
               }
	          }
        public bool IsIGJNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsIGJNull();
             }
	        }
        public String Actividad {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Actividad"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Actividad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Actividad = value;
               }
	          }
        public bool IsActividadNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsActividadNull();
             }
	        }
        public String Regimen {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Regimen"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Regimen;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Regimen = value;
               }
	          }
        public bool IsRegimenNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsRegimenNull();
             }
	        }
        public String Telefono {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Telefono"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Telefono;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Telefono = value;
               }
	          }
        public bool IsTelefonoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsTelefonoNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String Dominio_Id {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Dominio_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Dominio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Dominio_Id = value;
               }
	          }
        public bool IsDominio_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDominio_IdNull();
             }
	        }
        public String CarpetaEspecial {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CarpetaEspecial"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CarpetaEspecial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CarpetaEspecial = value;
               }
	          }
        public bool IsCarpetaEspecialNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCarpetaEspecialNull();
             }
	        }
        public Boolean UsaCantidadAlterna {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["UsaCantidadAlterna"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].UsaCantidadAlterna;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].UsaCantidadAlterna = value;
               }
	          }
        public bool IsUsaCantidadAlternaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsUsaCantidadAlternaNull();
             }
	        }
        public Boolean UsaDespachoImportacion {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["UsaDespachoImportacion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].UsaDespachoImportacion;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].UsaDespachoImportacion = value;
               }
	          }
        public bool IsUsaDespachoImportacionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsUsaDespachoImportacionNull();
             }
	        }
        public Boolean UsaSerie {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["UsaSerie"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].UsaSerie;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].UsaSerie = value;
               }
	          }
        public bool IsUsaSerieNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsUsaSerieNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String TipoCosto {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["TipoCosto"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].TipoCosto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].TipoCosto = value;
               }
	          }
        public bool IsTipoCostoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsTipoCostoNull();
             }
	        }
        public String TipoCosto2 {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["TipoCosto2"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].TipoCosto2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].TipoCosto2 = value;
               }
	          }
        public bool IsTipoCosto2Null {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsTipoCosto2Null();
             }
	        }
        public String TipoCosto3 {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["TipoCosto3"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].TipoCosto3;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].TipoCosto3 = value;
               }
	          }
        public bool IsTipoCosto3Null {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsTipoCosto3Null();
             }
	        }
        public String CodLocalidad {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CodLocalidad"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CodLocalidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CodLocalidad = value;
               }
	          }
        public bool IsCodLocalidadNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCodLocalidadNull();
             }
	        }
        public String CodColonia {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CodColonia"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CodColonia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CodColonia = value;
               }
	          }
        public bool IsCodColoniaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCodColoniaNull();
             }
	        }
        public String CodMunicipio {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CodMunicipio"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CodMunicipio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CodMunicipio = value;
               }
	          }
        public bool IsCodMunicipioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCodMunicipioNull();
             }
	        }
        public String CondFiscal {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CondFiscal"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CondFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CondFiscal = value;
               }
	          }
        public bool IsCondFiscalNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCondFiscalNull();
             }
	        }
        public String PaginaWeb {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["PaginaWeb"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].PaginaWeb;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].PaginaWeb = value;
               }
	          }
        public bool IsPaginaWebNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsPaginaWebNull();
             }
	        }
        public String CtaMercaEnTransitoImpor {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CtaMercaEnTransitoImpor"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaMercaEnTransitoImpor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaMercaEnTransitoImpor = value;
               }
	          }
        public bool IsCtaMercaEnTransitoImporNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCtaMercaEnTransitoImporNull();
             }
	        }
        public String DescripcionCtaMercaEnTransitoImpor {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["DescripcionCtaMercaEnTransitoImpor"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaMercaEnTransitoImpor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaMercaEnTransitoImpor = value;
               }
	          }
        public bool IsDescripcionCtaMercaEnTransitoImporNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDescripcionCtaMercaEnTransitoImporNull();
             }
	        }
        public String CtaMercTransito {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CtaMercTransito"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaMercTransito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaMercTransito = value;
               }
	          }
        public bool IsCtaMercTransitoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCtaMercTransitoNull();
             }
	        }
        public String DescripcionCtaMercTransito {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["DescripcionCtaMercTransito"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaMercTransito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaMercTransito = value;
               }
	          }
        public bool IsDescripcionCtaMercTransitoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDescripcionCtaMercTransitoNull();
             }
	        }
        public String CtaApliImportacion {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CtaApliImportacion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaApliImportacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaApliImportacion = value;
               }
	          }
        public bool IsCtaApliImportacionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCtaApliImportacionNull();
             }
	        }
        public String DescripcionCtaApliImportacion {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["DescripcionCtaApliImportacion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaApliImportacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaApliImportacion = value;
               }
	          }
        public bool IsDescripcionCtaApliImportacionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDescripcionCtaApliImportacionNull();
             }
	        }
        public String SucursalCentral {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["SucursalCentral"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].SucursalCentral;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].SucursalCentral = value;
               }
	          }
        public bool IsSucursalCentralNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsSucursalCentralNull();
             }
	        }
        public String DescripcionSucursalCentral {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["DescripcionSucursalCentral"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionSucursalCentral;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionSucursalCentral = value;
               }
	          }
        public bool IsDescripcionSucursalCentralNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDescripcionSucursalCentralNull();
             }
	        }
        public String Centro1De {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Centro1De"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Centro1De;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Centro1De = value;
               }
	          }
        public bool IsCentro1DeNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCentro1DeNull();
             }
	        }
        public String Centro2De {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Centro2De"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Centro2De;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Centro2De = value;
               }
	          }
        public bool IsCentro2DeNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCentro2DeNull();
             }
	        }
        public String CtaUtiCambioRealizada {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CtaUtiCambioRealizada"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaUtiCambioRealizada;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaUtiCambioRealizada = value;
               }
	          }
        public bool IsCtaUtiCambioRealizadaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCtaUtiCambioRealizadaNull();
             }
	        }
        public String DescripcionCtaUtiCambioRealizada {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["DescripcionCtaUtiCambioRealizada"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaUtiCambioRealizada;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaUtiCambioRealizada = value;
               }
	          }
        public bool IsDescripcionCtaUtiCambioRealizadaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDescripcionCtaUtiCambioRealizadaNull();
             }
	        }
        public String CtaPerCambioRealizada {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CtaPerCambioRealizada"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaPerCambioRealizada;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaPerCambioRealizada = value;
               }
	          }
        public bool IsCtaPerCambioRealizadaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCtaPerCambioRealizadaNull();
             }
	        }
        public String DescripcionCtaPerCambioRealizada {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["DescripcionCtaPerCambioRealizada"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaPerCambioRealizada;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaPerCambioRealizada = value;
               }
	          }
        public bool IsDescripcionCtaPerCambioRealizadaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDescripcionCtaPerCambioRealizadaNull();
             }
	        }
        public String CtaUtiCambioProv {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CtaUtiCambioProv"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaUtiCambioProv;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaUtiCambioProv = value;
               }
	          }
        public bool IsCtaUtiCambioProvNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCtaUtiCambioProvNull();
             }
	        }
        public String DescripcionCtaUtiCambioProv {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["DescripcionCtaUtiCambioProv"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaUtiCambioProv;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaUtiCambioProv = value;
               }
	          }
        public bool IsDescripcionCtaUtiCambioProvNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDescripcionCtaUtiCambioProvNull();
             }
	        }
        public String CtaPerCambioProv {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CtaPerCambioProv"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaPerCambioProv;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaPerCambioProv = value;
               }
	          }
        public bool IsCtaPerCambioProvNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCtaPerCambioProvNull();
             }
	        }
        public String DescripcionCtaPerCambioProv {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["DescripcionCtaPerCambioProv"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaPerCambioProv;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaPerCambioProv = value;
               }
	          }
        public bool IsDescripcionCtaPerCambioProvNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDescripcionCtaPerCambioProvNull();
             }
	        }
        public String CtaAjuStockPos {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CtaAjuStockPos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaAjuStockPos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaAjuStockPos = value;
               }
	          }
        public bool IsCtaAjuStockPosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCtaAjuStockPosNull();
             }
	        }
        public String CtaAjuStockPosDescripcion {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CtaAjuStockPosDescripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaAjuStockPosDescripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaAjuStockPosDescripcion = value;
               }
	          }
        public bool IsCtaAjuStockPosDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCtaAjuStockPosDescripcionNull();
             }
	        }
        public String CtaAjuStockNeg {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CtaAjuStockNeg"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaAjuStockNeg;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaAjuStockNeg = value;
               }
	          }
        public bool IsCtaAjuStockNegNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCtaAjuStockNegNull();
             }
	        }
        public String CtaAjuStockNegDescripcion {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CtaAjuStockNegDescripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaAjuStockNegDescripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaAjuStockNegDescripcion = value;
               }
	          }
        public bool IsCtaAjuStockNegDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCtaAjuStockNegDescripcionNull();
             }
	        }
        public String Servidor {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Servidor"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Servidor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Servidor = value;
               }
	          }
        public bool IsServidorNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsServidorNull();
             }
	        }
        public Int32 Puerto {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Puerto"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Puerto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Puerto = value;
               }
	          }
        public bool IsPuertoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsPuertoNull();
             }
	        }
        public String Correo {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Correo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Correo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Correo = value;
               }
	          }
        public bool IsCorreoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCorreoNull();
             }
	        }
        public String UsuarioCorreo {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["UsuarioCorreo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].UsuarioCorreo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].UsuarioCorreo = value;
               }
	          }
        public bool IsUsuarioCorreoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsUsuarioCorreoNull();
             }
	        }
        public String Clave {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Clave"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Clave;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Clave = value;
               }
	          }
        public bool IsClaveNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsClaveNull();
             }
	        }
        public String Seguridad {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Seguridad"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Seguridad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Seguridad = value;
               }
	          }
        public bool IsSeguridadNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsSeguridadNull();
             }
	        }
        public String CFVenta_Id {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CFVenta_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CFVenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CFVenta_Id = value;
               }
	          }
        public bool IsCFVenta_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCFVenta_IdNull();
             }
	        }
        public String DescripcionCFVenta_Id {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["DescripcionCFVenta_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCFVenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCFVenta_Id = value;
               }
	          }
        public bool IsDescripcionCFVenta_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDescripcionCFVenta_IdNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String DescripcionMedida_Id {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["DescripcionMedida_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionMedida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionMedida_Id = value;
               }
	          }
        public bool IsDescripcionMedida_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDescripcionMedida_IdNull();
             }
	        }
        public Boolean EnviaFacturas {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["EnviaFacturas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].EnviaFacturas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].EnviaFacturas = value;
               }
	          }
        public bool IsEnviaFacturasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsEnviaFacturasNull();
             }
	        }
        public Boolean EnviaRecibo {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["EnviaRecibo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].EnviaRecibo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].EnviaRecibo = value;
               }
	          }
        public bool IsEnviaReciboNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsEnviaReciboNull();
             }
	        }
        public Boolean EnviaOC {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["EnviaOC"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].EnviaOC;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].EnviaOC = value;
               }
	          }
        public bool IsEnviaOCNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsEnviaOCNull();
             }
	        }
        public Boolean EnviaPedido {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["EnviaPedido"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].EnviaPedido;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].EnviaPedido = value;
               }
	          }
        public bool IsEnviaPedidoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsEnviaPedidoNull();
             }
	        }
        public String MailClientesSinMail {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["MailClientesSinMail"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].MailClientesSinMail;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].MailClientesSinMail = value;
               }
	          }
        public bool IsMailClientesSinMailNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsMailClientesSinMailNull();
             }
	        }
        public DateTime FechaCierreImpuestos {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["FechaCierreImpuestos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCierreImpuestos;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCierreImpuestos = value;
               }
	          }
        public bool IsFechaCierreImpuestosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsFechaCierreImpuestosNull();
             }
	        }
        public String CFAjusCtaCte {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CFAjusCtaCte"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CFAjusCtaCte;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CFAjusCtaCte = value;
               }
	          }
        public bool IsCFAjusCtaCteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCFAjusCtaCteNull();
             }
	        }
        public String DescripcionCFAjusCtaCte {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["DescripcionCFAjusCtaCte"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCFAjusCtaCte;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCFAjusCtaCte = value;
               }
	          }
        public bool IsDescripcionCFAjusCtaCteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDescripcionCFAjusCtaCteNull();
             }
	        }
        public DateTime FechaCierreActivoFijo {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["FechaCierreActivoFijo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCierreActivoFijo;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCierreActivoFijo = value;
               }
	          }
        public bool IsFechaCierreActivoFijoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsFechaCierreActivoFijoNull();
             }
	        }
        public DateTime FechaCalculoActivoFijo {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["FechaCalculoActivoFijo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCalculoActivoFijo;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCalculoActivoFijo = value;
               }
	          }
        public bool IsFechaCalculoActivoFijoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsFechaCalculoActivoFijoNull();
             }
	        }
        public DateTime FechaCalculoActivoDiferido {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["FechaCalculoActivoDiferido"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCalculoActivoDiferido;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].FechaCalculoActivoDiferido = value;
               }
	          }
        public bool IsFechaCalculoActivoDiferidoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsFechaCalculoActivoDiferidoNull();
             }
	        }
        public String TipoDtoFin {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["TipoDtoFin"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].TipoDtoFin;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].TipoDtoFin = value;
               }
	          }
        public bool IsTipoDtoFinNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsTipoDtoFinNull();
             }
	        }
        public Decimal MontoDtoFinanciero {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["MontoDtoFinanciero"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].MontoDtoFinanciero;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].MontoDtoFinanciero = value;
               }
	          }
        public bool IsMontoDtoFinancieroNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsMontoDtoFinancieroNull();
             }
	        }
        public String CtaDtoFinPos {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CtaDtoFinPos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaDtoFinPos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaDtoFinPos = value;
               }
	          }
        public bool IsCtaDtoFinPosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCtaDtoFinPosNull();
             }
	        }
        public String DescripcionCtaDtoFinPos {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["DescripcionCtaDtoFinPos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaDtoFinPos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaDtoFinPos = value;
               }
	          }
        public bool IsDescripcionCtaDtoFinPosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDescripcionCtaDtoFinPosNull();
             }
	        }
        public String CtaDtoFinNeg {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CtaDtoFinNeg"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaDtoFinNeg;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaDtoFinNeg = value;
               }
	          }
        public bool IsCtaDtoFinNegNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCtaDtoFinNegNull();
             }
	        }
        public String DescripcionCtaDtoFinNeg {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["DescripcionCtaDtoFinNeg"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaDtoFinNeg;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaDtoFinNeg = value;
               }
	          }
        public bool IsDescripcionCtaDtoFinNegNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDescripcionCtaDtoFinNegNull();
             }
	        }
        public Boolean ConfirmarEnviarFacturas {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["ConfirmarEnviarFacturas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].ConfirmarEnviarFacturas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].ConfirmarEnviarFacturas = value;
               }
	          }
        public bool IsConfirmarEnviarFacturasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsConfirmarEnviarFacturasNull();
             }
	        }
        public Boolean ConfirmarEnviarOC {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["ConfirmarEnviarOC"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].ConfirmarEnviarOC;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].ConfirmarEnviarOC = value;
               }
	          }
        public bool IsConfirmarEnviarOCNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsConfirmarEnviarOCNull();
             }
	        }
        public Boolean ConfirmarEnviarPedidos {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["ConfirmarEnviarPedidos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].ConfirmarEnviarPedidos;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].ConfirmarEnviarPedidos = value;
               }
	          }
        public bool IsConfirmarEnviarPedidosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsConfirmarEnviarPedidosNull();
             }
	        }
        public Boolean ConfirmarEnviarRecibo {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["ConfirmarEnviarRecibo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].ConfirmarEnviarRecibo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].ConfirmarEnviarRecibo = value;
               }
	          }
        public bool IsConfirmarEnviarReciboNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsConfirmarEnviarReciboNull();
             }
	        }
        public String Firma {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Firma"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Firma;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Firma = value;
               }
	          }
        public bool IsFirmaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsFirmaNull();
             }
	        }
        public String ImagenFirmaB64 {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["ImagenFirmaB64"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].ImagenFirmaB64;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].ImagenFirmaB64 = value;
               }
	          }
        public bool IsImagenFirmaB64Null {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsImagenFirmaB64Null();
             }
	        }
        public String CuentasDeposito {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CuentasDeposito"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CuentasDeposito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CuentasDeposito = value;
               }
	          }
        public bool IsCuentasDepositoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCuentasDepositoNull();
             }
	        }
        public Boolean RemisionesAlCosto {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["RemisionesAlCosto"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].RemisionesAlCosto;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].RemisionesAlCosto = value;
               }
	          }
        public bool IsRemisionesAlCostoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsRemisionesAlCostoNull();
             }
	        }
        public String CtaRemisiones {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CtaRemisiones"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaRemisiones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CtaRemisiones = value;
               }
	          }
        public bool IsCtaRemisionesNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCtaRemisionesNull();
             }
	        }
        public String DescripcionCtaRemisiones {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["DescripcionCtaRemisiones"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaRemisiones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].DescripcionCtaRemisiones = value;
               }
	          }
        public bool IsDescripcionCtaRemisionesNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsDescripcionCtaRemisionesNull();
             }
	        }
        public Boolean UsaServerRH {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["UsaServerRH"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].UsaServerRH;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].UsaServerRH = value;
               }
	          }
        public bool IsUsaServerRHNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsUsaServerRHNull();
             }
	        }
        public String ServidorRH {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["ServidorRH"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].ServidorRH;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].ServidorRH = value;
               }
	          }
        public bool IsServidorRHNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsServidorRHNull();
             }
	        }
        public Int32 PuertoRH {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["PuertoRH"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].PuertoRH;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].PuertoRH = value;
               }
	          }
        public bool IsPuertoRHNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsPuertoRHNull();
             }
	        }
        public String CorreoRH {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["CorreoRH"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CorreoRH;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].CorreoRH = value;
               }
	          }
        public bool IsCorreoRHNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsCorreoRHNull();
             }
	        }
        public String UsuarioCorreoRH {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["UsuarioCorreoRH"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].UsuarioCorreoRH;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].UsuarioCorreoRH = value;
               }
	          }
        public bool IsUsuarioCorreoRHNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsUsuarioCorreoRHNull();
             }
	        }
        public String ClaveRH {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["ClaveRH"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].ClaveRH;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].ClaveRH = value;
               }
	          }
        public bool IsClaveRHNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsClaveRHNull();
             }
	        }
        public String SeguridadRH {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["SeguridadRH"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].SeguridadRH;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].SeguridadRH = value;
               }
	          }
        public bool IsSeguridadRHNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsSeguridadRHNull();
             }
	        }
        public String TipoPermisoSCT {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["TipoPermisoSCT"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].TipoPermisoSCT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].TipoPermisoSCT = value;
               }
	          }
        public bool IsTipoPermisoSCTNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsTipoPermisoSCTNull();
             }
	        }
        public String NroPermisoSCT {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["NroPermisoSCT"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].NroPermisoSCT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].NroPermisoSCT = value;
               }
	          }
        public bool IsNroPermisoSCTNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsNroPermisoSCTNull();
             }
	        }
        public Boolean TrabajaSabado {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["TrabajaSabado"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].TrabajaSabado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].TrabajaSabado = value;
               }
	          }
        public bool IsTrabajaSabadoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsTrabajaSabadoNull();
             }
	        }
        public Boolean TrabajaDomingo {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["TrabajaDomingo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].TrabajaDomingo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].TrabajaDomingo = value;
               }
	          }
        public bool IsTrabajaDomingoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsTrabajaDomingoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genEmpresasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genEmpresasDS );
     }
     public genEmpresasActionExchange() : base( "genEmpresas" ) {
     }

     public genEmpresasActionExchange(genEmpresasActionEnum.EnumgenEmpresasAction pAccion) : base(genEmpresasActionEnum.GetAcciongenEmpresasAction(pAccion)) {
     }

     public genEmpresasActionExchange(genEmpresasActionEnum.EnumgenEmpresasAction pAccion, GeneralesCommon.genEmpresasDS pdsParam) : base(genEmpresasActionEnum.GetAcciongenEmpresasAction(pAccion), pdsParam) {
     }

     public genEmpresasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genEmpresasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public genEmpresasActionExchange(GeneralesCommon.genEmpresasDS pDS) : base() {
     this.Action = "";
     this.mParam = new GeneralesCommon.genEmpresasDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genEmpresasDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genEmpresasDS)mParam;
	        }
     }
  }
}
