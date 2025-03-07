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
    public class comDespachosActionExchange : Framework.Core.Exchange{

        public Int32 comDespachos {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["comDespachos"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].comDespachos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].comDespachos = value;
               }
	          }
        public bool IscomDespachosNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IscomDespachosNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Despacho_Id {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["Despacho_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].Despacho_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].Despacho_Id = value;
               }
	          }
        public bool IsDespacho_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IsDespacho_IdNull();
             }
	        }
        public String Despacho_Id_Nuevo {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["Despacho_Id_Nuevo"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].Despacho_Id_Nuevo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].Despacho_Id_Nuevo = value;
               }
	          }
        public bool IsDespacho_Id_NuevoNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IsDespacho_Id_NuevoNull();
             }
	        }
        public String Origen {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["Origen"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].Origen;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].Origen = value;
               }
	          }
        public bool IsOrigenNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IsOrigenNull();
             }
	        }
        public String Aduana {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["Aduana"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].Aduana;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].Aduana = value;
               }
	          }
        public bool IsAduanaNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IsAduanaNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String Aduana_Id {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["Aduana_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].Aduana_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].Aduana_Id = value;
               }
	          }
        public bool IsAduana_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IsAduana_IdNull();
             }
	        }
        public String Anio {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["Anio"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].Anio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].Anio = value;
               }
	          }
        public bool IsAnioNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IsAnioNull();
             }
	        }
        public String Patente {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["Patente"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].Patente;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].Patente = value;
               }
	          }
        public bool IsPatenteNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IsPatenteNull();
             }
	        }
        public Decimal Pedimento {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["Pedimento"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].Pedimento;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].Pedimento = value;
               }
	          }
        public bool IsPedimentoNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IsPedimentoNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMoneda {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["DescripcionMoneda"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].DescripcionMoneda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].DescripcionMoneda = value;
               }
	          }
        public bool IsDescripcionMonedaNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IsDescripcionMonedaNull();
             }
	        }
        public DateTime FechaModificacion {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["FechaModificacion"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].FechaModificacion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].FechaModificacion = value;
               }
	          }
        public bool IsFechaModificacionNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IsFechaModificacionNull();
             }
	        }
        public Boolean TomaCambioTes {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["TomaCambioTes"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].TomaCambioTes;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].TomaCambioTes = value;
               }
	          }
        public bool IsTomaCambioTesNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IsTomaCambioTesNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comDespachosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comDespachosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comDespachosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comDespachosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comDespachosDS );
     }
     public comDespachosActionExchange() : base( "comDespachos" ) {
     }

     public comDespachosActionExchange(comDespachosActionEnum.EnumcomDespachosAction pAccion) : base(comDespachosActionEnum.GetAccioncomDespachosAction(pAccion)) {
     }

     public comDespachosActionExchange(comDespachosActionEnum.EnumcomDespachosAction pAccion, ComprasCommon.comDespachosDS pdsParam) : base(comDespachosActionEnum.GetAccioncomDespachosAction(pAccion), pdsParam) {
     }

     public comDespachosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comDespachosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comDespachosDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comDespachosDS)mParam;
	        }
     }
  }
}
