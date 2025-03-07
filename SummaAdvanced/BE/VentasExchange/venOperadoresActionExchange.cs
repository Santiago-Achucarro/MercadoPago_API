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
    public class venOperadoresActionExchange : Framework.Core.Exchange{

        public Int32 venOperadores {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["venOperadores"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].venOperadores;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].venOperadores = value;
               }
	          }
        public bool IsvenOperadoresNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsvenOperadoresNull();
             }
	        }
        public String Operador_Id {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["Operador_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].Operador_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].Operador_Id = value;
               }
	          }
        public bool IsOperador_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsOperador_IdNull();
             }
	        }
        public String Operador_Id_Nueva {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["Operador_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].Operador_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].Operador_Id_Nueva = value;
               }
	          }
        public bool IsOperador_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsOperador_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String RfcOperador {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["RfcOperador"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].RfcOperador;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].RfcOperador = value;
               }
	          }
        public bool IsRfcOperadorNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsRfcOperadorNull();
             }
	        }
        public String NumLicencia {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["NumLicencia"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].NumLicencia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].NumLicencia = value;
               }
	          }
        public bool IsNumLicenciaNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsNumLicenciaNull();
             }
	        }
        public String NombreOperador {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["NombreOperador"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].NombreOperador;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].NombreOperador = value;
               }
	          }
        public bool IsNombreOperadorNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsNombreOperadorNull();
             }
	        }
        public String NumRegIdTribOperador {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["NumRegIdTribOperador"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].NumRegIdTribOperador;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].NumRegIdTribOperador = value;
               }
	          }
        public bool IsNumRegIdTribOperadorNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsNumRegIdTribOperadorNull();
             }
	        }
        public Int16 ResidenciaFiscal {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["ResidenciaFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].ResidenciaFiscal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].ResidenciaFiscal = value;
               }
	          }
        public bool IsResidenciaFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsResidenciaFiscalNull();
             }
	        }
        public String DescripcionResidenciaFiscal {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["DescripcionResidenciaFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].DescripcionResidenciaFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].DescripcionResidenciaFiscal = value;
               }
	          }
        public bool IsDescripcionResidenciaFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsDescripcionResidenciaFiscalNull();
             }
	        }
        public String Calle {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["Calle"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].Calle;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].Calle = value;
               }
	          }
        public bool IsCalleNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsCalleNull();
             }
	        }
        public String NumeroExterior {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["NumeroExterior"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].NumeroExterior;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].NumeroExterior = value;
               }
	          }
        public bool IsNumeroExteriorNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsNumeroExteriorNull();
             }
	        }
        public String Numerointerior {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["Numerointerior"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].Numerointerior;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].Numerointerior = value;
               }
	          }
        public bool IsNumerointeriorNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsNumerointeriorNull();
             }
	        }
        public String Colonia {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["Colonia"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].Colonia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].Colonia = value;
               }
	          }
        public bool IsColoniaNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsColoniaNull();
             }
	        }
        public String Localidad {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["Localidad"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].Localidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].Localidad = value;
               }
	          }
        public bool IsLocalidadNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsLocalidadNull();
             }
	        }
        public String Referencia {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["Referencia"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].Referencia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].Referencia = value;
               }
	          }
        public bool IsReferenciaNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsReferenciaNull();
             }
	        }
        public String Municipio {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["Municipio"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].Municipio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].Municipio = value;
               }
	          }
        public bool IsMunicipioNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsMunicipioNull();
             }
	        }
        public String Estado {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["Estado"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].Estado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].Estado = value;
               }
	          }
        public bool IsEstadoNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsEstadoNull();
             }
	        }
        public Int16 Pais_Id {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["Pais_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].Pais_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].Pais_Id = value;
               }
	          }
        public bool IsPais_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsPais_IdNull();
             }
	        }
        public String DescripcionPaises {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["DescripcionPaises"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].DescripcionPaises;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].DescripcionPaises = value;
               }
	          }
        public bool IsDescripcionPaisesNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsDescripcionPaisesNull();
             }
	        }
        public String CodigoPostal {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["CodigoPostal"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].CodigoPostal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].CodigoPostal = value;
               }
	          }
        public bool IsCodigoPostalNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsCodigoPostalNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venOperadoresDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venOperadoresDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venOperadoresDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venOperadoresDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venOperadoresDS );
     }
     public venOperadoresActionExchange() : base( "venOperadores" ) {
     }

     public venOperadoresActionExchange(venOperadoresActionEnum.EnumvenOperadoresAction pAccion) : base(venOperadoresActionEnum.GetAccionvenOperadoresAction(pAccion)) {
     }

     public venOperadoresActionExchange(venOperadoresActionEnum.EnumvenOperadoresAction pAccion, VentasCommon.venOperadoresDS pdsParam) : base(venOperadoresActionEnum.GetAccionvenOperadoresAction(pAccion), pdsParam) {
     }

     public venOperadoresActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venOperadoresDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venOperadoresActionExchange(VentasCommon.venOperadoresDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venOperadoresDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venOperadoresDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venOperadoresDS)mParam;
	        }
     }
  }
}
