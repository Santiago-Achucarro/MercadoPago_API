using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange
{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venCotizClienteActionExchange : Framework.Core.Exchange{

        public Int32 Cotizacion_Id {
            get {
                if(((VentasCommon.venCotizClienteDS)mParam).Principal[0]["Cotizacion_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizClienteDS)mParam).Principal[0].Cotizacion_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizClienteDS)mParam).Principal[0].Cotizacion_Id = value;
               }
	          }
        public bool IsCotizacion_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizClienteDS)mParam).Principal[0].IsCotizacion_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((VentasCommon.venCotizClienteDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizClienteDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizClienteDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizClienteDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String Direccion1 {
            get {
                if(((VentasCommon.venCotizClienteDS)mParam).Principal[0]["Direccion1"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizClienteDS)mParam).Principal[0].Direccion1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizClienteDS)mParam).Principal[0].Direccion1 = value;
               }
	          }
        public bool IsDireccion1Null {
             get {
                 return mParam==null || ((VentasCommon.venCotizClienteDS)mParam).Principal[0].IsDireccion1Null();
             }
	        }
        public String Direccion2 {
            get {
                if(((VentasCommon.venCotizClienteDS)mParam).Principal[0]["Direccion2"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizClienteDS)mParam).Principal[0].Direccion2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizClienteDS)mParam).Principal[0].Direccion2 = value;
               }
	          }
        public bool IsDireccion2Null {
             get {
                 return mParam==null || ((VentasCommon.venCotizClienteDS)mParam).Principal[0].IsDireccion2Null();
             }
	        }
        public String NroExterior {
            get {
                if(((VentasCommon.venCotizClienteDS)mParam).Principal[0]["NroExterior"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizClienteDS)mParam).Principal[0].NroExterior;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizClienteDS)mParam).Principal[0].NroExterior = value;
               }
	          }
        public bool IsNroExteriorNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizClienteDS)mParam).Principal[0].IsNroExteriorNull();
             }
	        }
        public String NroInterior {
            get {
                if(((VentasCommon.venCotizClienteDS)mParam).Principal[0]["NroInterior"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizClienteDS)mParam).Principal[0].NroInterior;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizClienteDS)mParam).Principal[0].NroInterior = value;
               }
	          }
        public bool IsNroInteriorNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizClienteDS)mParam).Principal[0].IsNroInteriorNull();
             }
	        }
        public String Localidad {
            get {
                if(((VentasCommon.venCotizClienteDS)mParam).Principal[0]["Localidad"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizClienteDS)mParam).Principal[0].Localidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizClienteDS)mParam).Principal[0].Localidad = value;
               }
	          }
        public bool IsLocalidadNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizClienteDS)mParam).Principal[0].IsLocalidadNull();
             }
	        }
        public String CodigoPostal {
            get {
                if(((VentasCommon.venCotizClienteDS)mParam).Principal[0]["CodigoPostal"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizClienteDS)mParam).Principal[0].CodigoPostal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizClienteDS)mParam).Principal[0].CodigoPostal = value;
               }
	          }
        public bool IsCodigoPostalNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizClienteDS)mParam).Principal[0].IsCodigoPostalNull();
             }
	        }
        public String Provincia_Id {
            get {
                if(((VentasCommon.venCotizClienteDS)mParam).Principal[0]["Provincia_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizClienteDS)mParam).Principal[0].Provincia_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizClienteDS)mParam).Principal[0].Provincia_Id = value;
               }
	          }
        public bool IsProvincia_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizClienteDS)mParam).Principal[0].IsProvincia_IdNull();
             }
	        }
        public String DescripcionProvincia {
            get {
                if(((VentasCommon.venCotizClienteDS)mParam).Principal[0]["DescripcionProvincia"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizClienteDS)mParam).Principal[0].DescripcionProvincia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizClienteDS)mParam).Principal[0].DescripcionProvincia = value;
               }
	          }
        public bool IsDescripcionProvinciaNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizClienteDS)mParam).Principal[0].IsDescripcionProvinciaNull();
             }
	        }
        public Int16 Pais_Id {
            get {
                if(((VentasCommon.venCotizClienteDS)mParam).Principal[0]["Pais_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizClienteDS)mParam).Principal[0].Pais_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizClienteDS)mParam).Principal[0].Pais_Id = value;
               }
	          }
        public bool IsPais_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizClienteDS)mParam).Principal[0].IsPais_IdNull();
             }
	        }
        public String DescripcionPaises {
            get {
                if(((VentasCommon.venCotizClienteDS)mParam).Principal[0]["DescripcionPaises"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizClienteDS)mParam).Principal[0].DescripcionPaises;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizClienteDS)mParam).Principal[0].DescripcionPaises = value;
               }
	          }
        public bool IsDescripcionPaisesNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizClienteDS)mParam).Principal[0].IsDescripcionPaisesNull();
             }
	        }
        public String Telefono {
            get {
                if(((VentasCommon.venCotizClienteDS)mParam).Principal[0]["Telefono"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizClienteDS)mParam).Principal[0].Telefono;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizClienteDS)mParam).Principal[0].Telefono = value;
               }
	          }
        public bool IsTelefonoNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizClienteDS)mParam).Principal[0].IsTelefonoNull();
             }
	        }
        public String CUIT {
            get {
                if(((VentasCommon.venCotizClienteDS)mParam).Principal[0]["CUIT"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizClienteDS)mParam).Principal[0].CUIT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizClienteDS)mParam).Principal[0].CUIT = value;
               }
	          }
        public bool IsCUITNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizClienteDS)mParam).Principal[0].IsCUITNull();
             }
	        }
        public String Email {
            get {
                if(((VentasCommon.venCotizClienteDS)mParam).Principal[0]["Email"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizClienteDS)mParam).Principal[0].Email;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizClienteDS)mParam).Principal[0].Email = value;
               }
	          }
        public bool IsEmailNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizClienteDS)mParam).Principal[0].IsEmailNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venCotizClienteDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venCotizClienteDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCotizClienteDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCotizClienteDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCotizClienteDS );
     }
     public venCotizClienteActionExchange() : base( "venCotizCliente" ) {
     }

     public venCotizClienteActionExchange(venCotizClienteActionEnum.EnumvenCotizClienteAction pAccion) : base(venCotizClienteActionEnum.GetAccionvenCotizClienteAction(pAccion)) {
     }

     public venCotizClienteActionExchange(venCotizClienteActionEnum.EnumvenCotizClienteAction pAccion, VentasCommon.venCotizClienteDS pdsParam) : base(venCotizClienteActionEnum.GetAccionvenCotizClienteAction(pAccion), pdsParam) {
     }

     public venCotizClienteActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCotizClienteDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCotizClienteDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCotizClienteDS)mParam;
	        }
     }
  }
}
