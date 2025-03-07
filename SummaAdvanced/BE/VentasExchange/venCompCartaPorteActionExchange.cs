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
    public class venCompCartaPorteActionExchange : Framework.Core.Exchange{

        public Int64 venmovimientos {
            get {
                if(((VentasCommon.venCompCartaPorteDS)mParam).Principal[0]["venmovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].venmovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].venmovimientos = value;
               }
	          }
        public bool IsvenmovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].IsvenmovimientosNull();
             }
	        }
        public String TranspInternac {
            get {
                if(((VentasCommon.venCompCartaPorteDS)mParam).Principal[0]["TranspInternac"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].TranspInternac;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].TranspInternac = value;
               }
	          }
        public bool IsTranspInternacNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].IsTranspInternacNull();
             }
	        }
        public String EntradaSalidaMerc {
            get {
                if(((VentasCommon.venCompCartaPorteDS)mParam).Principal[0]["EntradaSalidaMerc"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].EntradaSalidaMerc;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].EntradaSalidaMerc = value;
               }
	          }
        public bool IsEntradaSalidaMercNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].IsEntradaSalidaMercNull();
             }
	        }
        public String ViaEntradaSalida {
            get {
                if(((VentasCommon.venCompCartaPorteDS)mParam).Principal[0]["ViaEntradaSalida"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].ViaEntradaSalida;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].ViaEntradaSalida = value;
               }
	          }
        public bool IsViaEntradaSalidaNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].IsViaEntradaSalidaNull();
             }
	        }
        public Decimal TotalDistRec {
            get {
                if(((VentasCommon.venCompCartaPorteDS)mParam).Principal[0]["TotalDistRec"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].TotalDistRec;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].TotalDistRec = value;
               }
	          }
        public bool IsTotalDistRecNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].IsTotalDistRecNull();
             }
	        }
        public Decimal PesoBrutoTotal {
            get {
                if(((VentasCommon.venCompCartaPorteDS)mParam).Principal[0]["PesoBrutoTotal"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].PesoBrutoTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].PesoBrutoTotal = value;
               }
	          }
        public bool IsPesoBrutoTotalNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].IsPesoBrutoTotalNull();
             }
	        }
        public String UnidadPeso {
            get {
                if(((VentasCommon.venCompCartaPorteDS)mParam).Principal[0]["UnidadPeso"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].UnidadPeso;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].UnidadPeso = value;
               }
	          }
        public bool IsUnidadPesoNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].IsUnidadPesoNull();
             }
	        }
        public Decimal PesoNetoTotal {
            get {
                if(((VentasCommon.venCompCartaPorteDS)mParam).Principal[0]["PesoNetoTotal"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].PesoNetoTotal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].PesoNetoTotal = value;
               }
	          }
        public bool IsPesoNetoTotalNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].IsPesoNetoTotalNull();
             }
	        }
        public Decimal CargoPorTasacion {
            get {
                if(((VentasCommon.venCompCartaPorteDS)mParam).Principal[0]["CargoPorTasacion"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].CargoPorTasacion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].CargoPorTasacion = value;
               }
	          }
        public bool IsCargoPorTasacionNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].IsCargoPorTasacionNull();
             }
	        }
        public String Camion_Id {
            get {
                if(((VentasCommon.venCompCartaPorteDS)mParam).Principal[0]["Camion_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].Camion_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].Camion_Id = value;
               }
	          }
        public bool IsCamion_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].IsCamion_IdNull();
             }
	        }
        public String DescripcionCamiones {
            get {
                if(((VentasCommon.venCompCartaPorteDS)mParam).Principal[0]["DescripcionCamiones"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].DescripcionCamiones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].DescripcionCamiones = value;
               }
	          }
        public bool IsDescripcionCamionesNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].IsDescripcionCamionesNull();
             }
	        }
        public String Remolque1 {
            get {
                if(((VentasCommon.venCompCartaPorteDS)mParam).Principal[0]["Remolque1"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].Remolque1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].Remolque1 = value;
               }
	          }
        public bool IsRemolque1Null {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].IsRemolque1Null();
             }
	        }
        public String DescripcionRemolque1 {
            get {
                if(((VentasCommon.venCompCartaPorteDS)mParam).Principal[0]["DescripcionRemolque1"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].DescripcionRemolque1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].DescripcionRemolque1 = value;
               }
	          }
        public bool IsDescripcionRemolque1Null {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].IsDescripcionRemolque1Null();
             }
	        }
        public String Remolque2 {
            get {
                if(((VentasCommon.venCompCartaPorteDS)mParam).Principal[0]["Remolque2"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].Remolque2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].Remolque2 = value;
               }
	          }
        public bool IsRemolque2Null {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].IsRemolque2Null();
             }
	        }
        public String DescripcionRemolque2 {
            get {
                if(((VentasCommon.venCompCartaPorteDS)mParam).Principal[0]["DescripcionRemolque2"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].DescripcionRemolque2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].DescripcionRemolque2 = value;
               }
	          }
        public bool IsDescripcionRemolque2Null {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].IsDescripcionRemolque2Null();
             }
	        }
        public String Operador_Id {
            get {
                if(((VentasCommon.venCompCartaPorteDS)mParam).Principal[0]["Operador_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].Operador_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].Operador_Id = value;
               }
	          }
        public bool IsOperador_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].IsOperador_IdNull();
             }
	        }
        public String NombreOperador {
            get {
                if(((VentasCommon.venCompCartaPorteDS)mParam).Principal[0]["NombreOperador"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].NombreOperador;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].NombreOperador = value;
               }
	          }
        public bool IsNombreOperadorNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].IsNombreOperadorNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venCompCartaPorteDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCompCartaPorteDS );
     }
     public venCompCartaPorteActionExchange() : base( "venCompCartaPorte" ) {
     }

     public venCompCartaPorteActionExchange(venCompCartaPorteActionEnum.EnumvenCompCartaPorteAction pAccion) : base(venCompCartaPorteActionEnum.GetAccionvenCompCartaPorteAction(pAccion)) {
     }

     public venCompCartaPorteActionExchange(venCompCartaPorteActionEnum.EnumvenCompCartaPorteAction pAccion, VentasCommon.venCompCartaPorteDS pdsParam) : base(venCompCartaPorteActionEnum.GetAccionvenCompCartaPorteAction(pAccion), pdsParam) {
     }

     public venCompCartaPorteActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCompCartaPorteDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venCompCartaPorteActionExchange(VentasCommon.venCompCartaPorteDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venCompCartaPorteDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCompCartaPorteDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCompCartaPorteDS)mParam;
	        }
     }
  }
}
