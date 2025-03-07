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
    public class comProveedoresActionExchange : Framework.Core.Exchange{

        public Int64 genEntidades {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["genEntidades"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].genEntidades;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].genEntidades = value;
               }
	          }
        public bool IsgenEntidadesNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsgenEntidadesNull();
             }
	        }
        public String CUIT {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["CUIT"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].CUIT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].CUIT = value;
               }
	          }
        public bool IsCUITNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsCUITNull();
             }
	        }
        public String TipoDoc {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["TipoDoc"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].TipoDoc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].TipoDoc = value;
               }
	          }
        public bool IsTipoDocNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsTipoDocNull();
             }
	        }
        public String idFiscal {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["idFiscal"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].idFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].idFiscal = value;
               }
	          }
        public bool IsidFiscalNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsidFiscalNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String Proveed_Id_Nueva {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Proveed_Id_Nueva"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Proveed_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Proveed_Id_Nueva = value;
               }
	          }
        public bool IsProveed_Id_NuevaNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsProveed_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String NombreLegal {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["NombreLegal"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].NombreLegal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].NombreLegal = value;
               }
	          }
        public bool IsNombreLegalNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsNombreLegalNull();
             }
	        }
        public String Direccion1 {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Direccion1"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Direccion1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Direccion1 = value;
               }
	          }
        public bool IsDireccion1Null {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsDireccion1Null();
             }
	        }
        public String Direccion2 {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Direccion2"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Direccion2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Direccion2 = value;
               }
	          }
        public bool IsDireccion2Null {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsDireccion2Null();
             }
	        }
        public String Localidad {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Localidad"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Localidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Localidad = value;
               }
	          }
        public bool IsLocalidadNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsLocalidadNull();
             }
	        }
        public String CodigoPostal {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["CodigoPostal"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].CodigoPostal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].CodigoPostal = value;
               }
	          }
        public bool IsCodigoPostalNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsCodigoPostalNull();
             }
	        }
        public String Provincia_Id {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Provincia_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Provincia_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Provincia_Id = value;
               }
	          }
        public bool IsProvincia_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsProvincia_IdNull();
             }
	        }
        public String DescripcionProvincias {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["DescripcionProvincias"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionProvincias;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionProvincias = value;
               }
	          }
        public bool IsDescripcionProvinciasNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsDescripcionProvinciasNull();
             }
	        }
        public Int16 Pais_Id {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Pais_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Pais_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Pais_Id = value;
               }
	          }
        public bool IsPais_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsPais_IdNull();
             }
	        }
        public String DescripcionPaises {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["DescripcionPaises"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionPaises;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionPaises = value;
               }
	          }
        public bool IsDescripcionPaisesNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsDescripcionPaisesNull();
             }
	        }
        public String Telefono {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Telefono"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Telefono;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Telefono = value;
               }
	          }
        public bool IsTelefonoNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsTelefonoNull();
             }
	        }
        public String Region_Id {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Region_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Region_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Region_Id = value;
               }
	          }
        public bool IsRegion_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsRegion_IdNull();
             }
	        }
        public String DescripcionRegiones {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["DescripcionRegiones"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionRegiones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionRegiones = value;
               }
	          }
        public bool IsDescripcionRegionesNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsDescripcionRegionesNull();
             }
	        }
        public String CondPago_Id {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["CondPago_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].CondPago_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].CondPago_Id = value;
               }
	          }
        public bool IsCondPago_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsCondPago_IdNull();
             }
	        }
        public String DescripcionConPago {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["DescripcionConPago"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionConPago;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionConPago = value;
               }
	          }
        public bool IsDescripcionConPagoNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsDescripcionConPagoNull();
             }
	        }
        public String FormaEnt_Id {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["FormaEnt_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].FormaEnt_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].FormaEnt_Id = value;
               }
	          }
        public bool IsFormaEnt_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsFormaEnt_IdNull();
             }
	        }
        public String DescripcionForEntre {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["DescripcionForEntre"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionForEntre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionForEntre = value;
               }
	          }
        public bool IsDescripcionForEntreNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsDescripcionForEntreNull();
             }
	        }
        public String Contacto {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Contacto"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Contacto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Contacto = value;
               }
	          }
        public bool IsContactoNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsContactoNull();
             }
	        }
        public String EMail {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["EMail"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].EMail;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].EMail = value;
               }
	          }
        public bool IsEMailNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsEMailNull();
             }
	        }
        public String Fax {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Fax"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Fax;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Fax = value;
               }
	          }
        public bool IsFaxNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsFaxNull();
             }
	        }
        public DateTime Fecha_Alta {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Fecha_Alta"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Fecha_Alta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Fecha_Alta = value;
               }
	          }
        public bool IsFecha_AltaNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsFecha_AltaNull();
             }
	        }
        public DateTime FechaUltActiv {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["FechaUltActiv"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].FechaUltActiv;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].FechaUltActiv = value;
               }
	          }
        public bool IsFechaUltActivNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsFechaUltActivNull();
             }
	        }
        public String Letra_Fact {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Letra_Fact"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Letra_Fact;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Letra_Fact = value;
               }
	          }
        public bool IsLetra_FactNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsLetra_FactNull();
             }
	        }
        public String Observaciones {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public String CondFiscal_Id {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["CondFiscal_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].CondFiscal_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].CondFiscal_Id = value;
               }
	          }
        public bool IsCondFiscal_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsCondFiscal_IdNull();
             }
	        }
        public String DescripcionCondFiscal {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["DescripcionCondFiscal"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionCondFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionCondFiscal = value;
               }
	          }
        public bool IsDescripcionCondFiscalNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsDescripcionCondFiscalNull();
             }
	        }
        public Boolean Ganancias {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Ganancias"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Ganancias;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Ganancias = value;
               }
	          }
        public bool IsGananciasNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsGananciasNull();
             }
	        }
        public String IBrutos {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["IBrutos"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IBrutos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IBrutos = value;
               }
	          }
        public bool IsIBrutosNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsIBrutosNull();
             }
	        }
        public String Especializacion {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Especializacion"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Especializacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Especializacion = value;
               }
	          }
        public bool IsEspecializacionNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsEspecializacionNull();
             }
	        }
        public Int16 Origen_Id {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Origen_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Origen_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Origen_Id = value;
               }
	          }
        public bool IsOrigen_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsOrigen_IdNull();
             }
	        }
        public String DescripcionOrCredFisc {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["DescripcionOrCredFisc"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionOrCredFisc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionOrCredFisc = value;
               }
	          }
        public bool IsDescripcionOrCredFiscNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsDescripcionOrCredFiscNull();
             }
	        }
        public Boolean EsAduana {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["EsAduana"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].EsAduana;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].EsAduana = value;
               }
	          }
        public bool IsEsAduanaNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsEsAduanaNull();
             }
	        }
        public String TipoCuenta {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["TipoCuenta"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].TipoCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].TipoCuenta = value;
               }
	          }
        public bool IsTipoCuentaNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsTipoCuentaNull();
             }
	        }
        public String NroCuenta {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["NroCuenta"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].NroCuenta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].NroCuenta = value;
               }
	          }
        public bool IsNroCuentaNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsNroCuentaNull();
             }
	        }
        public String CBU {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["CBU"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].CBU;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].CBU = value;
               }
	          }
        public bool IsCBUNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsCBUNull();
             }
	        }
        public DateTime Interbanking {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Interbanking"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Interbanking;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Interbanking = value;
               }
	          }
        public bool IsInterbankingNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsInterbankingNull();
             }
	        }
        public String Banco_Id {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Banco_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Banco_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Banco_Id = value;
               }
	          }
        public bool IsBanco_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsBanco_IdNull();
             }
	        }
        public String DescripcionBancos {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["DescripcionBancos"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionBancos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionBancos = value;
               }
	          }
        public bool IsDescripcionBancosNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsDescripcionBancosNull();
             }
	        }
        public String ProvTipo_Id {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["ProvTipo_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].ProvTipo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].ProvTipo_Id = value;
               }
	          }
        public bool IsProvTipo_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsProvTipo_IdNull();
             }
	        }
        public String DescripcionProvTipos {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["DescripcionProvTipos"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionProvTipos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionProvTipos = value;
               }
	          }
        public bool IsDescripcionProvTiposNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsDescripcionProvTiposNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comProveedoresDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comProveedoresDS );
     }
     public comProveedoresActionExchange() : base( "comProveedores" ) {
     }

     public comProveedoresActionExchange(comProveedoresActionEnum.EnumcomProveedoresAction pAccion) : base(comProveedoresActionEnum.GetAccioncomProveedoresAction(pAccion)) {
     }

     public comProveedoresActionExchange(comProveedoresActionEnum.EnumcomProveedoresAction pAccion, ComprasCommon.comProveedoresDS pdsParam) : base(comProveedoresActionEnum.GetAccioncomProveedoresAction(pAccion), pdsParam) {
     }

     public comProveedoresActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comProveedoresDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public comProveedoresActionExchange(ComprasCommon.comProveedoresDS pDS) : base() {
     this.Action = "";
     this.mParam = new ComprasCommon.comProveedoresDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comProveedoresDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comProveedoresDS)mParam;
	        }
     }
  }
}
