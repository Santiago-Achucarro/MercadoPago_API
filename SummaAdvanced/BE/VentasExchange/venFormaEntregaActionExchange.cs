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
    public class venFormaEntregaActionExchange : Framework.Core.Exchange{

        public Int32 venFormaEntrega {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["venFormaEntrega"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].venFormaEntrega;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].venFormaEntrega = value;
               }
	          }
        public bool IsvenFormaEntregaNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsvenFormaEntregaNull();
             }
	        }
        public String FormaEntrega_Id {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["FormaEntrega_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].FormaEntrega_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].FormaEntrega_Id = value;
               }
	          }
        public bool IsFormaEntrega_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsFormaEntrega_IdNull();
             }
	        }
        public String FormaEntrega_Id_Nueva {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["FormaEntrega_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].FormaEntrega_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].FormaEntrega_Id_Nueva = value;
               }
	          }
        public bool IsFormaEntrega_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsFormaEntrega_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String Direccion {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["Direccion"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Direccion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Direccion = value;
               }
	          }
        public bool IsDireccionNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsDireccionNull();
             }
	        }
        public String Localidad {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["Localidad"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Localidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Localidad = value;
               }
	          }
        public bool IsLocalidadNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsLocalidadNull();
             }
	        }
        public String Provincia_Id {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["Provincia_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Provincia_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Provincia_Id = value;
               }
	          }
        public bool IsProvincia_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsProvincia_IdNull();
             }
	        }
        public String DescripcionProvincias {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["DescripcionProvincias"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].DescripcionProvincias;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].DescripcionProvincias = value;
               }
	          }
        public bool IsDescripcionProvinciasNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsDescripcionProvinciasNull();
             }
	        }
        public Int16 Pais_Id {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["Pais_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Pais_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Pais_Id = value;
               }
	          }
        public bool IsPais_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsPais_IdNull();
             }
	        }
        public String DescripcionPaises {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["DescripcionPaises"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].DescripcionPaises;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].DescripcionPaises = value;
               }
	          }
        public bool IsDescripcionPaisesNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsDescripcionPaisesNull();
             }
	        }
        public String Telefono {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["Telefono"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Telefono;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Telefono = value;
               }
	          }
        public bool IsTelefonoNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsTelefonoNull();
             }
	        }
        public String Cuit {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["Cuit"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Cuit;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Cuit = value;
               }
	          }
        public bool IsCuitNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsCuitNull();
             }
	        }
        public String CondFisc_Id {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["CondFisc_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].CondFisc_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].CondFisc_Id = value;
               }
	          }
        public bool IsCondFisc_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsCondFisc_IdNull();
             }
	        }
        public String DescripcionCondFiscal {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["DescripcionCondFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].DescripcionCondFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].DescripcionCondFiscal = value;
               }
	          }
        public bool IsDescripcionCondFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsDescripcionCondFiscalNull();
             }
	        }
        public Decimal Seguro {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["Seguro"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Seguro;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Seguro = value;
               }
	          }
        public bool IsSeguroNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsSeguroNull();
             }
	        }
        public String Contacto {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["Contacto"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Contacto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Contacto = value;
               }
	          }
        public bool IsContactoNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsContactoNull();
             }
	        }
        public String Cargo {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["Cargo"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Cargo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Cargo = value;
               }
	          }
        public bool IsCargoNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsCargoNull();
             }
	        }
        public String Email {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["Email"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Email;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Email = value;
               }
	          }
        public bool IsEmailNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsEmailNull();
             }
	        }
        public Boolean ExcluirDelReparto {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["ExcluirDelReparto"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].ExcluirDelReparto;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].ExcluirDelReparto = value;
               }
	          }
        public bool IsExcluirDelRepartoNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsExcluirDelRepartoNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean UsaCartaPorte {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["UsaCartaPorte"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].UsaCartaPorte;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].UsaCartaPorte = value;
               }
	          }
        public bool IsUsaCartaPorteNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsUsaCartaPorteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venFormaEntregaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venFormaEntregaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venFormaEntregaDS );
     }
     public venFormaEntregaActionExchange() : base( "venFormaEntrega" ) {
     }

     public venFormaEntregaActionExchange(venFormaEntregaActionEnum.EnumvenFormaEntregaAction pAccion) : base(venFormaEntregaActionEnum.GetAccionvenFormaEntregaAction(pAccion)) {
     }

     public venFormaEntregaActionExchange(venFormaEntregaActionEnum.EnumvenFormaEntregaAction pAccion, VentasCommon.venFormaEntregaDS pdsParam) : base(venFormaEntregaActionEnum.GetAccionvenFormaEntregaAction(pAccion), pdsParam) {
     }

     public venFormaEntregaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venFormaEntregaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venFormaEntregaActionExchange(VentasCommon.venFormaEntregaDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venFormaEntregaDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venFormaEntregaDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venFormaEntregaDS)mParam;
	        }
     }
  }
}
