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
    public class genUsuariosActionExchange : Framework.Core.Exchange{

        public Int32 genUsuarios {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["genUsuarios"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].genUsuarios;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].genUsuarios = value;
               }
	          }
        public bool IsgenUsuariosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsgenUsuariosNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String Usuario_Id_Nueva {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Usuario_Id_Nueva"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Usuario_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Usuario_Id_Nueva = value;
               }
	          }
        public bool IsUsuario_Id_NuevaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsUsuario_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Apellido_y_Nombres {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Apellido_y_Nombres"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Apellido_y_Nombres;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Apellido_y_Nombres = value;
               }
	          }
        public bool IsApellido_y_NombresNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsApellido_y_NombresNull();
             }
	        }
        public String TipoUsuario {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["TipoUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].TipoUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].TipoUsuario = value;
               }
	          }
        public bool IsTipoUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsTipoUsuarioNull();
             }
	        }
        public String Sucursal {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public String DescripcionSucursalesEmpr {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["DescripcionSucursalesEmpr"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].DescripcionSucursalesEmpr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].DescripcionSucursalesEmpr = value;
               }
	          }
        public bool IsDescripcionSucursalesEmprNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsDescripcionSucursalesEmprNull();
             }
	        }
        public Int32 Clave_de_Acceso {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Clave_de_Acceso"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Clave_de_Acceso;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Clave_de_Acceso = value;
               }
	          }
        public bool IsClave_de_AccesoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsClave_de_AccesoNull();
             }
	        }
        public String Cargo {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Cargo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Cargo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Cargo = value;
               }
	          }
        public bool IsCargoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsCargoNull();
             }
	        }
        public DateTime UltCambioPass {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["UltCambioPass"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].UltCambioPass;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].UltCambioPass = value;
               }
	          }
        public bool IsUltCambioPassNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsUltCambioPassNull();
             }
	        }
        public Int16 Intentos {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Intentos"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Intentos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Intentos = value;
               }
	          }
        public bool IsIntentosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsIntentosNull();
             }
	        }
        public String Email {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Email"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Email;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Email = value;
               }
	          }
        public bool IsEmailNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsEmailNull();
             }
	        }
        public Int32 UsuarioCarga {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["UsuarioCarga"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].UsuarioCarga;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].UsuarioCarga = value;
               }
	          }
        public bool IsUsuarioCargaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsUsuarioCargaNull();
             }
	        }
        public String PtoEmision {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["PtoEmision"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].PtoEmision;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].PtoEmision = value;
               }
	          }
        public bool IsPtoEmisionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsPtoEmisionNull();
             }
	        }
        public Boolean CambiarClave {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["CambiarClave"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].CambiarClave;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].CambiarClave = value;
               }
	          }
        public bool IsCambiarClaveNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsCambiarClaveNull();
             }
	        }
        public Int16 MalClave {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["MalClave"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].MalClave;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].MalClave = value;
               }
	          }
        public bool IsMalClaveNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsMalClaveNull();
             }
	        }
        public Boolean EsSupervisor {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["EsSupervisor"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].EsSupervisor;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].EsSupervisor = value;
               }
	          }
        public bool IsEsSupervisorNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsEsSupervisorNull();
             }
	        }
        public String Cultura {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Cultura"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Cultura;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Cultura = value;
               }
	          }
        public bool IsCulturaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsCulturaNull();
             }
	        }
        public String DescripcionCultura {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["DescripcionCultura"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].DescripcionCultura;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].DescripcionCultura = value;
               }
	          }
        public bool IsDescripcionCulturaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsDescripcionCulturaNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Clave1 {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Clave1"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Clave1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Clave1 = value;
               }
	          }
        public bool IsClave1Null {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsClave1Null();
             }
	        }
        public String Clave2 {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Clave2"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Clave2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Clave2 = value;
               }
	          }
        public bool IsClave2Null {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsClave2Null();
             }
	        }
        public Boolean MultiplesLogins {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["MultiplesLogins"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].MultiplesLogins;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].MultiplesLogins = value;
               }
	          }
        public bool IsMultiplesLoginsNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsMultiplesLoginsNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String DescripcionCliente {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["DescripcionCliente"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].DescripcionCliente;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].DescripcionCliente = value;
               }
	          }
        public bool IsDescripcionClienteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsDescripcionClienteNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String DescripcionProveedor {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["DescripcionProveedor"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].DescripcionProveedor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].DescripcionProveedor = value;
               }
	          }
        public bool IsDescripcionProveedorNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsDescripcionProveedorNull();
             }
	        }
        public String Vendedor_Id {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Vendedor_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Vendedor_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Vendedor_Id = value;
               }
	          }
        public bool IsVendedor_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsVendedor_IdNull();
             }
	        }
        public String DescripcionVendedor {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["DescripcionVendedor"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].DescripcionVendedor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].DescripcionVendedor = value;
               }
	          }
        public bool IsDescripcionVendedorNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsDescripcionVendedorNull();
             }
	        }
        public String Cobrador_Id {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Cobrador_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Cobrador_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Cobrador_Id = value;
               }
	          }
        public bool IsCobrador_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsCobrador_IdNull();
             }
	        }
        public String DescripcionCobrador {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["DescripcionCobrador"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].DescripcionCobrador;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].DescripcionCobrador = value;
               }
	          }
        public bool IsDescripcionCobradorNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsDescripcionCobradorNull();
             }
	        }
        public Int32 Legajo {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public String DescripcionLegajo {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["DescripcionLegajo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].DescripcionLegajo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].DescripcionLegajo = value;
               }
	          }
        public bool IsDescripcionLegajoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsDescripcionLegajoNull();
             }
	        }
        public Boolean RestringeHorarios {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["RestringeHorarios"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].RestringeHorarios;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].RestringeHorarios = value;
               }
	          }
        public bool IsRestringeHorariosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsRestringeHorariosNull();
             }
	        }
        public String Firma {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Firma"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Firma;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Firma = value;
               }
	          }
        public bool IsFirmaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsFirmaNull();
             }
	        }
        public String ImagenFirmaB64 {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["ImagenFirmaB64"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].ImagenFirmaB64;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].ImagenFirmaB64 = value;
               }
	          }
        public bool IsImagenFirmaB64Null {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsImagenFirmaB64Null();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genUsuariosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genUsuariosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genUsuariosDS );
     }
     public genUsuariosActionExchange() : base( "genUsuarios" ) {
     }

     public genUsuariosActionExchange(genUsuariosActionEnum.EnumgenUsuariosAction pAccion) : base(genUsuariosActionEnum.GetAcciongenUsuariosAction(pAccion)) {
     }

     public genUsuariosActionExchange(genUsuariosActionEnum.EnumgenUsuariosAction pAccion, GeneralesCommon.genUsuariosDS pdsParam) : base(genUsuariosActionEnum.GetAcciongenUsuariosAction(pAccion), pdsParam) {
     }

     public genUsuariosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genUsuariosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public genUsuariosActionExchange(GeneralesCommon.genUsuariosDS pDS) : base() {
     this.Action = "";
     this.mParam = new GeneralesCommon.genUsuariosDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genUsuariosDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genUsuariosDS)mParam;
	        }
     }
  }
}
