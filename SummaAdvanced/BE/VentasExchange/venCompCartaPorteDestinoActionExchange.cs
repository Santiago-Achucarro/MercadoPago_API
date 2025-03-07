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
    public class venCompCartaPorteDestinoActionExchange : Framework.Core.Exchange{

        public Int64 venmovimientos {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["venmovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].venmovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].venmovimientos = value;
               }
	          }
        public bool IsvenmovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsvenmovimientosNull();
             }
	        }
        public Int32 Ubicacion {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["Ubicacion"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Ubicacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Ubicacion = value;
               }
	          }
        public bool IsUbicacionNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsUbicacionNull();
             }
	        }
        public Int32 idDestino {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["idDestino"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].idDestino;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].idDestino = value;
               }
	          }
        public bool IsidDestinoNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsidDestinoNull();
             }
	        }
        public String RFCDestinatario {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["RFCDestinatario"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].RFCDestinatario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].RFCDestinatario = value;
               }
	          }
        public bool IsRFCDestinatarioNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsRFCDestinatarioNull();
             }
	        }
        public String NombreDestinatario {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["NombreDestinatario"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].NombreDestinatario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].NombreDestinatario = value;
               }
	          }
        public bool IsNombreDestinatarioNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsNombreDestinatarioNull();
             }
	        }
        public String NumRegIdTrib {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["NumRegIdTrib"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].NumRegIdTrib;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].NumRegIdTrib = value;
               }
	          }
        public bool IsNumRegIdTribNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsNumRegIdTribNull();
             }
	        }
        public Int16 ResidenciaFiscal {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["ResidenciaFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].ResidenciaFiscal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].ResidenciaFiscal = value;
               }
	          }
        public bool IsResidenciaFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsResidenciaFiscalNull();
             }
	        }
        public String NumEstacion {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["NumEstacion"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].NumEstacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].NumEstacion = value;
               }
	          }
        public bool IsNumEstacionNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsNumEstacionNull();
             }
	        }
        public String NombreEstacion {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["NombreEstacion"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].NombreEstacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].NombreEstacion = value;
               }
	          }
        public bool IsNombreEstacionNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsNombreEstacionNull();
             }
	        }
        public String NavegacionTrafico {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["NavegacionTrafico"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].NavegacionTrafico;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].NavegacionTrafico = value;
               }
	          }
        public bool IsNavegacionTraficoNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsNavegacionTraficoNull();
             }
	        }
        public DateTime FechaHoraProgLlegada {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["FechaHoraProgLlegada"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].FechaHoraProgLlegada;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].FechaHoraProgLlegada = value;
               }
	          }
        public bool IsFechaHoraProgLlegadaNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsFechaHoraProgLlegadaNull();
             }
	        }
        public String Calle {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["Calle"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Calle;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Calle = value;
               }
	          }
        public bool IsCalleNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsCalleNull();
             }
	        }
        public String NumeroExterior {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["NumeroExterior"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].NumeroExterior;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].NumeroExterior = value;
               }
	          }
        public bool IsNumeroExteriorNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsNumeroExteriorNull();
             }
	        }
        public String Numerointerior {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["Numerointerior"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Numerointerior;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Numerointerior = value;
               }
	          }
        public bool IsNumerointeriorNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsNumerointeriorNull();
             }
	        }
        public String Colonia {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["Colonia"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Colonia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Colonia = value;
               }
	          }
        public bool IsColoniaNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsColoniaNull();
             }
	        }
        public String Localidad {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["Localidad"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Localidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Localidad = value;
               }
	          }
        public bool IsLocalidadNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsLocalidadNull();
             }
	        }
        public String Referencia {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["Referencia"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Referencia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Referencia = value;
               }
	          }
        public bool IsReferenciaNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsReferenciaNull();
             }
	        }
        public String Municipio {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["Municipio"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Municipio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Municipio = value;
               }
	          }
        public bool IsMunicipioNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsMunicipioNull();
             }
	        }
        public String Estado {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["Estado"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Estado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Estado = value;
               }
	          }
        public bool IsEstadoNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsEstadoNull();
             }
	        }
        public Int16 Pais_Id {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["Pais_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Pais_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Pais_Id = value;
               }
	          }
        public bool IsPais_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsPais_IdNull();
             }
	        }
        public String CodigoPostal {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["CodigoPostal"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].CodigoPostal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].CodigoPostal = value;
               }
	          }
        public bool IsCodigoPostalNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsCodigoPostalNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDestinoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCompCartaPorteDestinoDS );
     }
     public venCompCartaPorteDestinoActionExchange() : base( "venCompCartaPorteDestino" ) {
     }

     public venCompCartaPorteDestinoActionExchange(venCompCartaPorteDestinoActionEnum.EnumvenCompCartaPorteDestinoAction pAccion) : base(venCompCartaPorteDestinoActionEnum.GetAccionvenCompCartaPorteDestinoAction(pAccion)) {
     }

     public venCompCartaPorteDestinoActionExchange(venCompCartaPorteDestinoActionEnum.EnumvenCompCartaPorteDestinoAction pAccion, VentasCommon.venCompCartaPorteDestinoDS pdsParam) : base(venCompCartaPorteDestinoActionEnum.GetAccionvenCompCartaPorteDestinoAction(pAccion), pdsParam) {
     }

     public venCompCartaPorteDestinoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCompCartaPorteDestinoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venCompCartaPorteDestinoActionExchange(VentasCommon.venCompCartaPorteDestinoDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venCompCartaPorteDestinoDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCompCartaPorteDestinoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCompCartaPorteDestinoDS)mParam;
	        }
     }
  }
}
