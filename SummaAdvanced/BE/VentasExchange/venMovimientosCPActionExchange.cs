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
    public class venMovimientosCPActionExchange : Framework.Core.Exchange{

        public Int64 venMovimientos {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public String Segmento_Id {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["Segmento_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Segmento_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Segmento_Id = value;
               }
	          }
        public bool IsSegmento_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsSegmento_IdNull();
             }
	        }
        public String Segmento1C {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["Segmento1C"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Segmento1C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Segmento1C = value;
               }
	          }
        public bool IsSegmento1CNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsSegmento1CNull();
             }
	        }
        public String Segmento2C {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["Segmento2C"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Segmento2C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Segmento2C = value;
               }
	          }
        public bool IsSegmento2CNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsSegmento2CNull();
             }
	        }
        public String Segmento3C {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["Segmento3C"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Segmento3C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Segmento3C = value;
               }
	          }
        public bool IsSegmento3CNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsSegmento3CNull();
             }
	        }
        public String Segmento4C {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["Segmento4C"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Segmento4C;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Segmento4C = value;
               }
	          }
        public bool IsSegmento4CNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsSegmento4CNull();
             }
	        }
        public Int32 Segmento1N {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["Segmento1N"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Segmento1N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Segmento1N = value;
               }
	          }
        public bool IsSegmento1NNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsSegmento1NNull();
             }
	        }
        public Int32 Segmento2N {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["Segmento2N"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Segmento2N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Segmento2N = value;
               }
	          }
        public bool IsSegmento2NNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsSegmento2NNull();
             }
	        }
        public Int32 Segmento3N {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["Segmento3N"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Segmento3N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Segmento3N = value;
               }
	          }
        public bool IsSegmento3NNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsSegmento3NNull();
             }
	        }
        public Int32 Segmento4N {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["Segmento4N"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Segmento4N;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Segmento4N = value;
               }
	          }
        public bool IsSegmento4NNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsSegmento4NNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Cliente_Id {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String Calle {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["Calle"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Calle;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Calle = value;
               }
	          }
        public bool IsCalleNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsCalleNull();
             }
	        }
        public String NroExterior {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["NroExterior"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].NroExterior;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].NroExterior = value;
               }
	          }
        public bool IsNroExteriorNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsNroExteriorNull();
             }
	        }
        public String NroInterior {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["NroInterior"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].NroInterior;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].NroInterior = value;
               }
	          }
        public bool IsNroInteriorNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsNroInteriorNull();
             }
	        }
        public String CodPostal {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["CodPostal"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].CodPostal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].CodPostal = value;
               }
	          }
        public bool IsCodPostalNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsCodPostalNull();
             }
	        }
        public String Colonia {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["Colonia"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Colonia;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Colonia = value;
               }
	          }
        public bool IsColoniaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsColoniaNull();
             }
	        }
        public String Localidad {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["Localidad"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Localidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Localidad = value;
               }
	          }
        public bool IsLocalidadNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsLocalidadNull();
             }
	        }
        public String Provincia_Id {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["Provincia_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Provincia_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Provincia_Id = value;
               }
	          }
        public bool IsProvincia_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsProvincia_IdNull();
             }
	        }
        public Int16 Pais_Id {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["Pais_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Pais_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Pais_Id = value;
               }
	          }
        public bool IsPais_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsPais_IdNull();
             }
	        }
        public String c_ColoniaEntr {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["c_ColoniaEntr"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].c_ColoniaEntr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].c_ColoniaEntr = value;
               }
	          }
        public bool Isc_ColoniaEntrNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Isc_ColoniaEntrNull();
             }
	        }
        public String c_LocalidadEntr {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["c_LocalidadEntr"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].c_LocalidadEntr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].c_LocalidadEntr = value;
               }
	          }
        public bool Isc_LocalidadEntrNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Isc_LocalidadEntrNull();
             }
	        }
        public String c_MunicipioEntr {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["c_MunicipioEntr"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].c_MunicipioEntr;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].c_MunicipioEntr = value;
               }
	          }
        public bool Isc_MunicipioEntrNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Isc_MunicipioEntrNull();
             }
	        }
        public Decimal TotalDistRec {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["TotalDistRec"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].TotalDistRec;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].TotalDistRec = value;
               }
	          }
        public bool IsTotalDistRecNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsTotalDistRecNull();
             }
	        }
        public DateTime FechaHoraProgLlegada {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["FechaHoraProgLlegada"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].FechaHoraProgLlegada;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].FechaHoraProgLlegada = value;
               }
	          }
        public bool IsFechaHoraProgLlegadaNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsFechaHoraProgLlegadaNull();
             }
	        }
        public DateTime FechaCP {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["FechaCP"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].FechaCP;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].FechaCP = value;
               }
	          }
        public bool IsFechaCPNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsFechaCPNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venMovimientosCPDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venMovimientosCPDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venMovimientosCPDS );
     }
     public venMovimientosCPActionExchange() : base( "venMovimientosCP" ) {
     }

     public venMovimientosCPActionExchange(venMovimientosCPActionEnum.EnumvenMovimientosCPAction pAccion) : base(venMovimientosCPActionEnum.GetAccionvenMovimientosCPAction(pAccion)) {
     }

     public venMovimientosCPActionExchange(venMovimientosCPActionEnum.EnumvenMovimientosCPAction pAccion, VentasCommon.venMovimientosCPDS pdsParam) : base(venMovimientosCPActionEnum.GetAccionvenMovimientosCPAction(pAccion), pdsParam) {
     }

     public venMovimientosCPActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venMovimientosCPDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venMovimientosCPActionExchange(VentasCommon.venMovimientosCPDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venMovimientosCPDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venMovimientosCPDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venMovimientosCPDS)mParam;
	        }
     }
  }
}
