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
    public class venPropietarioArrendaActionExchange : Framework.Core.Exchange{

        public Int32 venPropietarioArrenda {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["venPropietarioArrenda"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].venPropietarioArrenda;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].venPropietarioArrenda = value;
               }
	          }
        public bool IsvenPropietarioArrendaNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsvenPropietarioArrendaNull();
             }
	        }
        public String PropArre_Id {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["PropArre_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].PropArre_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].PropArre_Id = value;
               }
	          }
        public bool IsPropArre_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsPropArre_IdNull();
             }
	        }
        public String PropArre_Id_Nueva {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["PropArre_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].PropArre_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].PropArre_Id_Nueva = value;
               }
	          }
        public bool IsPropArre_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsPropArre_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Int32 PropArre {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["PropArre"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].PropArre;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].PropArre = value;
               }
	          }
        public bool IsPropArreNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsPropArreNull();
             }
	        }
        public String Rfc {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["Rfc"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Rfc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Rfc = value;
               }
	          }
        public bool IsRfcNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsRfcNull();
             }
	        }
        public String Nombre {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["Nombre"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Nombre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Nombre = value;
               }
	          }
        public bool IsNombreNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsNombreNull();
             }
	        }
        public String NumRegIdTrib {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["NumRegIdTrib"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].NumRegIdTrib;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].NumRegIdTrib = value;
               }
	          }
        public bool IsNumRegIdTribNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsNumRegIdTribNull();
             }
	        }
        public Int16 ResidenciaFiscal {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["ResidenciaFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].ResidenciaFiscal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].ResidenciaFiscal = value;
               }
	          }
        public bool IsResidenciaFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsResidenciaFiscalNull();
             }
	        }
        public String DescripcionRecidenciaFiscal {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["DescripcionRecidenciaFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].DescripcionRecidenciaFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].DescripcionRecidenciaFiscal = value;
               }
	          }
        public bool IsDescripcionRecidenciaFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsDescripcionRecidenciaFiscalNull();
             }
	        }
        public String Calle {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["Calle"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Calle;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Calle = value;
               }
	          }
        public bool IsCalleNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsCalleNull();
             }
	        }
        public String NumeroExterior {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["NumeroExterior"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].NumeroExterior;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].NumeroExterior = value;
               }
	          }
        public bool IsNumeroExteriorNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsNumeroExteriorNull();
             }
	        }
        public String Numerointerior {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["Numerointerior"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Numerointerior;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Numerointerior = value;
               }
	          }
        public bool IsNumerointeriorNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsNumerointeriorNull();
             }
	        }
        public String Colonia {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["Colonia"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Colonia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Colonia = value;
               }
	          }
        public bool IsColoniaNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsColoniaNull();
             }
	        }
        public String Localidad {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["Localidad"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Localidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Localidad = value;
               }
	          }
        public bool IsLocalidadNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsLocalidadNull();
             }
	        }
        public String Referencia {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["Referencia"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Referencia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Referencia = value;
               }
	          }
        public bool IsReferenciaNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsReferenciaNull();
             }
	        }
        public String Municipio {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["Municipio"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Municipio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Municipio = value;
               }
	          }
        public bool IsMunicipioNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsMunicipioNull();
             }
	        }
        public String Estado {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["Estado"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Estado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Estado = value;
               }
	          }
        public bool IsEstadoNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsEstadoNull();
             }
	        }
        public Int16 Pais_Id {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["Pais_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Pais_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Pais_Id = value;
               }
	          }
        public bool IsPais_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsPais_IdNull();
             }
	        }
        public String DescripcionPaises {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["DescripcionPaises"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].DescripcionPaises;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].DescripcionPaises = value;
               }
	          }
        public bool IsDescripcionPaisesNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsDescripcionPaisesNull();
             }
	        }
        public String CodigoPostal {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["CodigoPostal"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].CodigoPostal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].CodigoPostal = value;
               }
	          }
        public bool IsCodigoPostalNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsCodigoPostalNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venPropietarioArrendaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venPropietarioArrendaDS );
     }
     public venPropietarioArrendaActionExchange() : base( "venPropietarioArrenda" ) {
     }

     public venPropietarioArrendaActionExchange(venPropietarioArrendaActionEnum.EnumvenPropietarioArrendaAction pAccion) : base(venPropietarioArrendaActionEnum.GetAccionvenPropietarioArrendaAction(pAccion)) {
     }

     public venPropietarioArrendaActionExchange(venPropietarioArrendaActionEnum.EnumvenPropietarioArrendaAction pAccion, VentasCommon.venPropietarioArrendaDS pdsParam) : base(venPropietarioArrendaActionEnum.GetAccionvenPropietarioArrendaAction(pAccion), pdsParam) {
     }

     public venPropietarioArrendaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venPropietarioArrendaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venPropietarioArrendaActionExchange(VentasCommon.venPropietarioArrendaDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venPropietarioArrendaDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venPropietarioArrendaDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venPropietarioArrendaDS)mParam;
	        }
     }
  }
}
