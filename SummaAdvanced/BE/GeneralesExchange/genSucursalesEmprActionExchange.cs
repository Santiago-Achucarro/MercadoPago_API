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
    public class genSucursalesEmprActionExchange : Framework.Core.Exchange{

        public Int32 genSucursalesEmpr {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["genSucursalesEmpr"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].genSucursalesEmpr;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].genSucursalesEmpr = value;
               }
	          }
        public bool IsgenSucursalesEmprNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsgenSucursalesEmprNull();
             }
	        }
        public String Sucursal {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String Sucursal_Nueva {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["Sucursal_Nueva"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Sucursal_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Sucursal_Nueva = value;
               }
	          }
        public bool IsSucursal_NuevaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsSucursal_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Provincia_Id {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["Provincia_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Provincia_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Provincia_Id = value;
               }
	          }
        public bool IsProvincia_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsProvincia_IdNull();
             }
	        }
        public String DescripcionProvincias {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["DescripcionProvincias"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcionProvincias;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcionProvincias = value;
               }
	          }
        public bool IsDescripcionProvinciasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsDescripcionProvinciasNull();
             }
	        }
        public Int16 Pais_Id {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["Pais_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Pais_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Pais_Id = value;
               }
	          }
        public bool IsPais_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsPais_IdNull();
             }
	        }
        public String DescripcionPaises {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["DescripcionPaises"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcionPaises;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcionPaises = value;
               }
	          }
        public bool IsDescripcionPaisesNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsDescripcionPaisesNull();
             }
	        }
        public String DepositoVentas {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["DepositoVentas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DepositoVentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DepositoVentas = value;
               }
	          }
        public bool IsDepositoVentasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsDepositoVentasNull();
             }
	        }
        public String DescripcionDepositoVentas {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["DescripcionDepositoVentas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcionDepositoVentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcionDepositoVentas = value;
               }
	          }
        public bool IsDescripcionDepositoVentasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsDescripcionDepositoVentasNull();
             }
	        }
        public String DepositoPedidos {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["DepositoPedidos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DepositoPedidos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DepositoPedidos = value;
               }
	          }
        public bool IsDepositoPedidosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsDepositoPedidosNull();
             }
	        }
        public String DescripcionDepositoPedidos {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["DescripcionDepositoPedidos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcionDepositoPedidos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcionDepositoPedidos = value;
               }
	          }
        public bool IsDescripcionDepositoPedidosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsDescripcionDepositoPedidosNull();
             }
	        }
        public String DepositoOC {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["DepositoOC"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DepositoOC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DepositoOC = value;
               }
	          }
        public bool IsDepositoOCNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsDepositoOCNull();
             }
	        }
        public String DescripcionDepositoOC {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["DescripcionDepositoOC"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcionDepositoOC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcionDepositoOC = value;
               }
	          }
        public bool IsDescripcionDepositoOCNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsDescripcionDepositoOCNull();
             }
	        }
        public DateTime FechaCaja {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["FechaCaja"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].FechaCaja;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].FechaCaja = value;
               }
	          }
        public bool IsFechaCajaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsFechaCajaNull();
             }
	        }
        public Boolean VaConCentral {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["VaConCentral"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].VaConCentral;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].VaConCentral = value;
               }
	          }
        public bool IsVaConCentralNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsVaConCentralNull();
             }
	        }
        public Boolean FacturaElectronica {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["FacturaElectronica"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].FacturaElectronica;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].FacturaElectronica = value;
               }
	          }
        public bool IsFacturaElectronicaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsFacturaElectronicaNull();
             }
	        }
        public Boolean UsaWS {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["UsaWS"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].UsaWS;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].UsaWS = value;
               }
	          }
        public bool IsUsaWSNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsUsaWSNull();
             }
	        }
        public String TipoFE {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["TipoFE"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].TipoFE;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].TipoFE = value;
               }
	          }
        public bool IsTipoFENull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsTipoFENull();
             }
	        }
        public String DescripcionTipoFE {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["DescripcionTipoFE"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcionTipoFE;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcionTipoFE = value;
               }
	          }
        public bool IsDescripcionTipoFENull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsDescripcionTipoFENull();
             }
	        }
        public String Direccion {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["Direccion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Direccion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Direccion = value;
               }
	          }
        public bool IsDireccionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsDireccionNull();
             }
	        }
        public String Localidad {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["Localidad"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Localidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Localidad = value;
               }
	          }
        public bool IsLocalidadNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsLocalidadNull();
             }
	        }
        public String Telefono {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["Telefono"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Telefono;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Telefono = value;
               }
	          }
        public bool IsTelefonoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsTelefonoNull();
             }
	        }
        public String SucursalRemito {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["SucursalRemito"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].SucursalRemito;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].SucursalRemito = value;
               }
	          }
        public bool IsSucursalRemitoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsSucursalRemitoNull();
             }
	        }
        public String SucursalTesoreria {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["SucursalTesoreria"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].SucursalTesoreria;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].SucursalTesoreria = value;
               }
	          }
        public bool IsSucursalTesoreriaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsSucursalTesoreriaNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String CodigoPostal {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["CodigoPostal"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].CodigoPostal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].CodigoPostal = value;
               }
	          }
        public bool IsCodigoPostalNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsCodigoPostalNull();
             }
	        }
        public String Serie {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["Serie"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Serie;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Serie = value;
               }
	          }
        public bool IsSerieNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsSerieNull();
             }
	        }
        public String RegPatronal {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["RegPatronal"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].RegPatronal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].RegPatronal = value;
               }
	          }
        public bool IsRegPatronalNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsRegPatronalNull();
             }
	        }
        public String codColonia {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["codColonia"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].codColonia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].codColonia = value;
               }
	          }
        public bool IscodColoniaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IscodColoniaNull();
             }
	        }
        public String DescripcioncodColonia {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["DescripcioncodColonia"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcioncodColonia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcioncodColonia = value;
               }
	          }
        public bool IsDescripcioncodColoniaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsDescripcioncodColoniaNull();
             }
	        }
        public String codLocalidad {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["codLocalidad"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].codLocalidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].codLocalidad = value;
               }
	          }
        public bool IscodLocalidadNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IscodLocalidadNull();
             }
	        }
        public String DescripcioncodLocalidad {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["DescripcioncodLocalidad"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcioncodLocalidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcioncodLocalidad = value;
               }
	          }
        public bool IsDescripcioncodLocalidadNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsDescripcioncodLocalidadNull();
             }
	        }
        public String codMunicipio {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["codMunicipio"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].codMunicipio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].codMunicipio = value;
               }
	          }
        public bool IscodMunicipioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IscodMunicipioNull();
             }
	        }
        public String DescripcioncodMunicipio {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["DescripcioncodMunicipio"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcioncodMunicipio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].DescripcioncodMunicipio = value;
               }
	          }
        public bool IsDescripcioncodMunicipioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsDescripcioncodMunicipioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesEmprDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genSucursalesEmprDS );
     }
     public genSucursalesEmprActionExchange() : base( "genSucursalesEmpr" ) {
     }

     public genSucursalesEmprActionExchange(genSucursalesEmprActionEnum.EnumgenSucursalesEmprAction pAccion) : base(genSucursalesEmprActionEnum.GetAcciongenSucursalesEmprAction(pAccion)) {
     }

     public genSucursalesEmprActionExchange(genSucursalesEmprActionEnum.EnumgenSucursalesEmprAction pAccion, GeneralesCommon.genSucursalesEmprDS pdsParam) : base(genSucursalesEmprActionEnum.GetAcciongenSucursalesEmprAction(pAccion), pdsParam) {
     }

     public genSucursalesEmprActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genSucursalesEmprDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public genSucursalesEmprActionExchange(GeneralesCommon.genSucursalesEmprDS pDS) : base() {
     this.Action = "";
     this.mParam = new GeneralesCommon.genSucursalesEmprDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genSucursalesEmprDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genSucursalesEmprDS)mParam;
	        }
     }
  }
}
