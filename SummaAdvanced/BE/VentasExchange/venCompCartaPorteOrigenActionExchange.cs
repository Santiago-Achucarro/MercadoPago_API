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
    public class venCompCartaPorteOrigenActionExchange : Framework.Core.Exchange{

        public Int64 venmovimientos {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["venmovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].venmovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].venmovimientos = value;
               }
	          }
        public bool IsvenmovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsvenmovimientosNull();
             }
	        }
        public Int32 Ubicacion {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["Ubicacion"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Ubicacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Ubicacion = value;
               }
	          }
        public bool IsUbicacionNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsUbicacionNull();
             }
	        }
        public Int32 idOrigen {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["idOrigen"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].idOrigen;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].idOrigen = value;
               }
	          }
        public bool IsidOrigenNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsidOrigenNull();
             }
	        }
        public String RFCRemitente {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["RFCRemitente"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].RFCRemitente;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].RFCRemitente = value;
               }
	          }
        public bool IsRFCRemitenteNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsRFCRemitenteNull();
             }
	        }
        public String NombreRemitente {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["NombreRemitente"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].NombreRemitente;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].NombreRemitente = value;
               }
	          }
        public bool IsNombreRemitenteNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsNombreRemitenteNull();
             }
	        }
        public String NumRegIdTrib {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["NumRegIdTrib"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].NumRegIdTrib;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].NumRegIdTrib = value;
               }
	          }
        public bool IsNumRegIdTribNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsNumRegIdTribNull();
             }
	        }
        public Int16 ResidenciaFiscal {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["ResidenciaFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].ResidenciaFiscal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].ResidenciaFiscal = value;
               }
	          }
        public bool IsResidenciaFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsResidenciaFiscalNull();
             }
	        }
        public String NumEstacion {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["NumEstacion"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].NumEstacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].NumEstacion = value;
               }
	          }
        public bool IsNumEstacionNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsNumEstacionNull();
             }
	        }
        public String NombreEstacion {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["NombreEstacion"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].NombreEstacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].NombreEstacion = value;
               }
	          }
        public bool IsNombreEstacionNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsNombreEstacionNull();
             }
	        }
        public String NavegacionTrafico {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["NavegacionTrafico"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].NavegacionTrafico;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].NavegacionTrafico = value;
               }
	          }
        public bool IsNavegacionTraficoNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsNavegacionTraficoNull();
             }
	        }
        public DateTime FechaHoraSalida {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["FechaHoraSalida"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].FechaHoraSalida;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].FechaHoraSalida = value;
               }
	          }
        public bool IsFechaHoraSalidaNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsFechaHoraSalidaNull();
             }
	        }
        public String Calle {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["Calle"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Calle;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Calle = value;
               }
	          }
        public bool IsCalleNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsCalleNull();
             }
	        }
        public String NumeroExterior {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["NumeroExterior"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].NumeroExterior;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].NumeroExterior = value;
               }
	          }
        public bool IsNumeroExteriorNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsNumeroExteriorNull();
             }
	        }
        public String Numerointerior {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["Numerointerior"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Numerointerior;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Numerointerior = value;
               }
	          }
        public bool IsNumerointeriorNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsNumerointeriorNull();
             }
	        }
        public String Colonia {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["Colonia"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Colonia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Colonia = value;
               }
	          }
        public bool IsColoniaNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsColoniaNull();
             }
	        }
        public String Localidad {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["Localidad"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Localidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Localidad = value;
               }
	          }
        public bool IsLocalidadNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsLocalidadNull();
             }
	        }
        public String Referencia {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["Referencia"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Referencia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Referencia = value;
               }
	          }
        public bool IsReferenciaNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsReferenciaNull();
             }
	        }
        public String Municipio {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["Municipio"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Municipio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Municipio = value;
               }
	          }
        public bool IsMunicipioNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsMunicipioNull();
             }
	        }
        public String Estado {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["Estado"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Estado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Estado = value;
               }
	          }
        public bool IsEstadoNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsEstadoNull();
             }
	        }
        public Int16 Pais_Id {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["Pais_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Pais_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Pais_Id = value;
               }
	          }
        public bool IsPais_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsPais_IdNull();
             }
	        }
        public String CodigoPostal {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["CodigoPostal"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].CodigoPostal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].CodigoPostal = value;
               }
	          }
        public bool IsCodigoPostalNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsCodigoPostalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteOrigenDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCompCartaPorteOrigenDS );
     }
     public venCompCartaPorteOrigenActionExchange() : base( "venCompCartaPorteOrigen" ) {
     }

     public venCompCartaPorteOrigenActionExchange(venCompCartaPorteOrigenActionEnum.EnumvenCompCartaPorteOrigenAction pAccion) : base(venCompCartaPorteOrigenActionEnum.GetAccionvenCompCartaPorteOrigenAction(pAccion)) {
     }

     public venCompCartaPorteOrigenActionExchange(venCompCartaPorteOrigenActionEnum.EnumvenCompCartaPorteOrigenAction pAccion, VentasCommon.venCompCartaPorteOrigenDS pdsParam) : base(venCompCartaPorteOrigenActionEnum.GetAccionvenCompCartaPorteOrigenAction(pAccion), pdsParam) {
     }

     public venCompCartaPorteOrigenActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCompCartaPorteOrigenDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venCompCartaPorteOrigenActionExchange(VentasCommon.venCompCartaPorteOrigenDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venCompCartaPorteOrigenDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCompCartaPorteOrigenDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCompCartaPorteOrigenDS)mParam;
	        }
     }
  }
}
