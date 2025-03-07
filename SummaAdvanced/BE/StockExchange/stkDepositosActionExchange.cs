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
    public class stkDepositosActionExchange : Framework.Core.Exchange{

        public Int32 stkDepositos {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["stkDepositos"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].stkDepositos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].stkDepositos = value;
               }
	          }
        public bool IsstkDepositosNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsstkDepositosNull();
             }
	        }
        public String Deposito_Id {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["Deposito_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].Deposito_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].Deposito_Id = value;
               }
	          }
        public bool IsDeposito_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsDeposito_IdNull();
             }
	        }
        public String Deposito_Id_Nueva {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["Deposito_Id_Nueva"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].Deposito_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].Deposito_Id_Nueva = value;
               }
	          }
        public bool IsDeposito_Id_NuevaNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsDeposito_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Sucursal {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String DescripcionSucursalesEmpr {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["DescripcionSucursalesEmpr"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionSucursalesEmpr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionSucursalesEmpr = value;
               }
	          }
        public bool IsDescripcionSucursalesEmprNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsDescripcionSucursalesEmprNull();
             }
	        }
        public String Descripcion {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Direccion {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["Direccion"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].Direccion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].Direccion = value;
               }
	          }
        public bool IsDireccionNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsDireccionNull();
             }
	        }
        public String GrupoUsuarios {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["GrupoUsuarios"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].GrupoUsuarios;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].GrupoUsuarios = value;
               }
	          }
        public bool IsGrupoUsuariosNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsGrupoUsuariosNull();
             }
	        }
        public String DescripcionGrupoUsuarios {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["DescripcionGrupoUsuarios"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionGrupoUsuarios;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionGrupoUsuarios = value;
               }
	          }
        public bool IsDescripcionGrupoUsuariosNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsDescripcionGrupoUsuariosNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Boolean AdmiteVentas {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["AdmiteVentas"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].AdmiteVentas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].AdmiteVentas = value;
               }
	          }
        public bool IsAdmiteVentasNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsAdmiteVentasNull();
             }
	        }
        public Boolean Consignacion {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["Consignacion"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].Consignacion;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].Consignacion = value;
               }
	          }
        public bool IsConsignacionNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsConsignacionNull();
             }
	        }
        public String CuentaDeudCons {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["CuentaDeudCons"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].CuentaDeudCons;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].CuentaDeudCons = value;
               }
	          }
        public bool IsCuentaDeudConsNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsCuentaDeudConsNull();
             }
	        }
        public String DescripcionCuentaDeudCons {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["DescripcionCuentaDeudCons"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionCuentaDeudCons;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionCuentaDeudCons = value;
               }
	          }
        public bool IsDescripcionCuentaDeudConsNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsDescripcionCuentaDeudConsNull();
             }
	        }
        public String CuentaAcredCons {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["CuentaAcredCons"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].CuentaAcredCons;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].CuentaAcredCons = value;
               }
	          }
        public bool IsCuentaAcredConsNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsCuentaAcredConsNull();
             }
	        }
        public String DescripcionCuentaAcredCons {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["DescripcionCuentaAcredCons"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionCuentaAcredCons;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionCuentaAcredCons = value;
               }
	          }
        public bool IsDescripcionCuentaAcredConsNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsDescripcionCuentaAcredConsNull();
             }
	        }
        public String CtaBienesCambio {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["CtaBienesCambio"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].CtaBienesCambio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].CtaBienesCambio = value;
               }
	          }
        public bool IsCtaBienesCambioNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsCtaBienesCambioNull();
             }
	        }
        public String DescripcionCtaBienesCambio {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["DescripcionCtaBienesCambio"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionCtaBienesCambio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionCtaBienesCambio = value;
               }
	          }
        public bool IsDescripcionCtaBienesCambioNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsDescripcionCtaBienesCambioNull();
             }
	        }
        public String CtaMercEnCons {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["CtaMercEnCons"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].CtaMercEnCons;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].CtaMercEnCons = value;
               }
	          }
        public bool IsCtaMercEnConsNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsCtaMercEnConsNull();
             }
	        }
        public String DescripcionCtaMercEnCons {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["DescripcionCtaMercEnCons"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionCtaMercEnCons;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionCtaMercEnCons = value;
               }
	          }
        public bool IsDescripcionCtaMercEnConsNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsDescripcionCtaMercEnConsNull();
             }
	        }
        public String DepositoReal {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["DepositoReal"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].DepositoReal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].DepositoReal = value;
               }
	          }
        public bool IsDepositoRealNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsDepositoRealNull();
             }
	        }
        public String DescripcionDepositoReal {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["DescripcionDepositoReal"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionDepositoReal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionDepositoReal = value;
               }
	          }
        public bool IsDescripcionDepositoRealNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsDescripcionDepositoRealNull();
             }
	        }
        public Boolean consCompra_Venta {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["consCompra_Venta"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].consCompra_Venta;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].consCompra_Venta = value;
               }
	          }
        public bool IsconsCompra_VentaNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsconsCompra_VentaNull();
             }
	        }
        public String Localidad {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["Localidad"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].Localidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].Localidad = value;
               }
	          }
        public bool IsLocalidadNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsLocalidadNull();
             }
	        }
        public String CodigoPostal {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["CodigoPostal"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].CodigoPostal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].CodigoPostal = value;
               }
	          }
        public bool IsCodigoPostalNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsCodigoPostalNull();
             }
	        }
        public String Provincia_Id {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["Provincia_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].Provincia_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].Provincia_Id = value;
               }
	          }
        public bool IsProvincia_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsProvincia_IdNull();
             }
	        }
        public String DescripcionProvincias {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["DescripcionProvincias"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionProvincias;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionProvincias = value;
               }
	          }
        public bool IsDescripcionProvinciasNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsDescripcionProvinciasNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean UsaUbicacion {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["UsaUbicacion"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].UsaUbicacion;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].UsaUbicacion = value;
               }
	          }
        public bool IsUsaUbicacionNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsUsaUbicacionNull();
             }
	        }
        public String c_ColoniaEntr {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["c_ColoniaEntr"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].c_ColoniaEntr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].c_ColoniaEntr = value;
               }
	          }
        public bool Isc_ColoniaEntrNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].Isc_ColoniaEntrNull();
             }
	        }
        public String c_LocalidadEntr {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["c_LocalidadEntr"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].c_LocalidadEntr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].c_LocalidadEntr = value;
               }
	          }
        public bool Isc_LocalidadEntrNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].Isc_LocalidadEntrNull();
             }
	        }
        public String c_MunicipioEntr {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["c_MunicipioEntr"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].c_MunicipioEntr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].c_MunicipioEntr = value;
               }
	          }
        public bool Isc_MunicipioEntrNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].Isc_MunicipioEntrNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkDepositosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkDepositosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkDepositosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkDepositosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkDepositosDS );
     }
     public stkDepositosActionExchange() : base( "stkDepositos" ) {
     }

     public stkDepositosActionExchange(stkDepositosActionEnum.EnumstkDepositosAction pAccion) : base(stkDepositosActionEnum.GetAccionstkDepositosAction(pAccion)) {
     }

     public stkDepositosActionExchange(stkDepositosActionEnum.EnumstkDepositosAction pAccion, StockCommon.stkDepositosDS pdsParam) : base(stkDepositosActionEnum.GetAccionstkDepositosAction(pAccion), pdsParam) {
     }

     public stkDepositosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkDepositosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public stkDepositosActionExchange(StockCommon.stkDepositosDS pDS) : base() {
     this.Action = "";
     this.mParam = new StockCommon.stkDepositosDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkDepositosDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkDepositosDS)mParam;
	        }
     }
  }
}
