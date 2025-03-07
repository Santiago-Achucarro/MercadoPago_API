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
    public class venClieContactoActionExchange : Framework.Core.Exchange{

        public Int64 Cliente_Id {
            get {
                if(((VentasCommon.venClieContactoDS)mParam).Principal[0]["Cliente_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieContactoDS)mParam).Principal[0].Cliente_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieContactoDS)mParam).Principal[0].Cliente_Id = value;
               }
	          }
        public bool IsCliente_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieContactoDS)mParam).Principal[0].IsCliente_IdNull();
             }
	        }
        public Int32 Sucursal {
            get {
                if(((VentasCommon.venClieContactoDS)mParam).Principal[0]["Sucursal"] != DBNull.Value  ){
                    return ((VentasCommon.venClieContactoDS)mParam).Principal[0].Sucursal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieContactoDS)mParam).Principal[0].Sucursal = value;
               }
	          }
        public bool IsSucursalNull {
             get {
                 return mParam==null || ((VentasCommon.venClieContactoDS)mParam).Principal[0].IsSucursalNull();
             }
	        }
        public Int32 NroContacto {
            get {
                if(((VentasCommon.venClieContactoDS)mParam).Principal[0]["NroContacto"] != DBNull.Value  ){
                    return ((VentasCommon.venClieContactoDS)mParam).Principal[0].NroContacto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieContactoDS)mParam).Principal[0].NroContacto = value;
               }
	          }
        public bool IsNroContactoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieContactoDS)mParam).Principal[0].IsNroContactoNull();
             }
	        }
        public String Nombre {
            get {
                if(((VentasCommon.venClieContactoDS)mParam).Principal[0]["Nombre"] != DBNull.Value  ){
                    return ((VentasCommon.venClieContactoDS)mParam).Principal[0].Nombre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieContactoDS)mParam).Principal[0].Nombre = value;
               }
	          }
        public bool IsNombreNull {
             get {
                 return mParam==null || ((VentasCommon.venClieContactoDS)mParam).Principal[0].IsNombreNull();
             }
	        }
        public String Puesto {
            get {
                if(((VentasCommon.venClieContactoDS)mParam).Principal[0]["Puesto"] != DBNull.Value  ){
                    return ((VentasCommon.venClieContactoDS)mParam).Principal[0].Puesto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieContactoDS)mParam).Principal[0].Puesto = value;
               }
	          }
        public bool IsPuestoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieContactoDS)mParam).Principal[0].IsPuestoNull();
             }
	        }
        public String Email {
            get {
                if(((VentasCommon.venClieContactoDS)mParam).Principal[0]["Email"] != DBNull.Value  ){
                    return ((VentasCommon.venClieContactoDS)mParam).Principal[0].Email;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieContactoDS)mParam).Principal[0].Email = value;
               }
	          }
        public bool IsEmailNull {
             get {
                 return mParam==null || ((VentasCommon.venClieContactoDS)mParam).Principal[0].IsEmailNull();
             }
	        }
        public String Telefono {
            get {
                if(((VentasCommon.venClieContactoDS)mParam).Principal[0]["Telefono"] != DBNull.Value  ){
                    return ((VentasCommon.venClieContactoDS)mParam).Principal[0].Telefono;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieContactoDS)mParam).Principal[0].Telefono = value;
               }
	          }
        public bool IsTelefonoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieContactoDS)mParam).Principal[0].IsTelefonoNull();
             }
	        }
        public String Interno {
            get {
                if(((VentasCommon.venClieContactoDS)mParam).Principal[0]["Interno"] != DBNull.Value  ){
                    return ((VentasCommon.venClieContactoDS)mParam).Principal[0].Interno;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieContactoDS)mParam).Principal[0].Interno = value;
               }
	          }
        public bool IsInternoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieContactoDS)mParam).Principal[0].IsInternoNull();
             }
	        }
        public String Movil {
            get {
                if(((VentasCommon.venClieContactoDS)mParam).Principal[0]["Movil"] != DBNull.Value  ){
                    return ((VentasCommon.venClieContactoDS)mParam).Principal[0].Movil;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieContactoDS)mParam).Principal[0].Movil = value;
               }
	          }
        public bool IsMovilNull {
             get {
                 return mParam==null || ((VentasCommon.venClieContactoDS)mParam).Principal[0].IsMovilNull();
             }
	        }
        public Boolean EnviaFacturas {
            get {
                if(((VentasCommon.venClieContactoDS)mParam).Principal[0]["EnviaFacturas"] != DBNull.Value  ){
                    return ((VentasCommon.venClieContactoDS)mParam).Principal[0].EnviaFacturas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieContactoDS)mParam).Principal[0].EnviaFacturas = value;
               }
	          }
        public bool IsEnviaFacturasNull {
             get {
                 return mParam==null || ((VentasCommon.venClieContactoDS)mParam).Principal[0].IsEnviaFacturasNull();
             }
	        }
        public Boolean EnviaRecibo {
            get {
                if(((VentasCommon.venClieContactoDS)mParam).Principal[0]["EnviaRecibo"] != DBNull.Value  ){
                    return ((VentasCommon.venClieContactoDS)mParam).Principal[0].EnviaRecibo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieContactoDS)mParam).Principal[0].EnviaRecibo = value;
               }
	          }
        public bool IsEnviaReciboNull {
             get {
                 return mParam==null || ((VentasCommon.venClieContactoDS)mParam).Principal[0].IsEnviaReciboNull();
             }
	        }
        public Boolean EnviaPedido {
            get {
                if(((VentasCommon.venClieContactoDS)mParam).Principal[0]["EnviaPedido"] != DBNull.Value  ){
                    return ((VentasCommon.venClieContactoDS)mParam).Principal[0].EnviaPedido;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieContactoDS)mParam).Principal[0].EnviaPedido = value;
               }
	          }
        public bool IsEnviaPedidoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieContactoDS)mParam).Principal[0].IsEnviaPedidoNull();
             }
	        }
        public String Observaciones {
            get {
                if(((VentasCommon.venClieContactoDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venClieContactoDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieContactoDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venClieContactoDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((VentasCommon.venClieContactoDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((VentasCommon.venClieContactoDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieContactoDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieContactoDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venClieContactoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venClieContactoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieContactoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venClieContactoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venClieContactoDS );
     }
     public venClieContactoActionExchange() : base( "venClieContacto" ) {
     }

     public venClieContactoActionExchange(venClieContactoActionEnum.EnumvenClieContactoAction pAccion) : base(venClieContactoActionEnum.GetAccionvenClieContactoAction(pAccion)) {
     }

     public venClieContactoActionExchange(venClieContactoActionEnum.EnumvenClieContactoAction pAccion, VentasCommon.venClieContactoDS pdsParam) : base(venClieContactoActionEnum.GetAccionvenClieContactoAction(pAccion), pdsParam) {
     }

     public venClieContactoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venClieContactoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venClieContactoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venClieContactoDS)mParam;
	        }
     }
  }
}
