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
    public class venClieEstadosActionExchange : Framework.Core.Exchange{

        public Int32 venClieEstados {
            get {
                if(((VentasCommon.venClieEstadosDS)mParam).Principal[0]["venClieEstados"] != DBNull.Value  ){
                    return ((VentasCommon.venClieEstadosDS)mParam).Principal[0].venClieEstados;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieEstadosDS)mParam).Principal[0].venClieEstados = value;
               }
	          }
        public bool IsvenClieEstadosNull {
             get {
                 return mParam==null || ((VentasCommon.venClieEstadosDS)mParam).Principal[0].IsvenClieEstadosNull();
             }
	        }
        public String Estado_Id {
            get {
                if(((VentasCommon.venClieEstadosDS)mParam).Principal[0]["Estado_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Estado_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Estado_Id = value;
               }
	          }
        public bool IsEstado_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieEstadosDS)mParam).Principal[0].IsEstado_IdNull();
             }
	        }
        public String Estado_Id_Nueva {
            get {
                if(((VentasCommon.venClieEstadosDS)mParam).Principal[0]["Estado_Id_Nueva"] != DBNull.Value  ){
                    return ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Estado_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Estado_Id_Nueva = value;
               }
	          }
        public bool IsEstado_Id_NuevaNull {
             get {
                 return mParam==null || ((VentasCommon.venClieEstadosDS)mParam).Principal[0].IsEstado_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((VentasCommon.venClieEstadosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieEstadosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((VentasCommon.venClieEstadosDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((VentasCommon.venClieEstadosDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieEstadosDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((VentasCommon.venClieEstadosDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venClieEstadosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venClieEstadosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((VentasCommon.venClieEstadosDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieEstadosDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((VentasCommon.venClieEstadosDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((VentasCommon.venClieEstadosDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieEstadosDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((VentasCommon.venClieEstadosDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public Boolean Reservado {
            get {
                if(((VentasCommon.venClieEstadosDS)mParam).Principal[0]["Reservado"] != DBNull.Value  ){
                    return ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Reservado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Reservado = value;
               }
	          }
        public bool IsReservadoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieEstadosDS)mParam).Principal[0].IsReservadoNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((VentasCommon.venClieEstadosDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieEstadosDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean ImpideOperaciones {
            get {
                if(((VentasCommon.venClieEstadosDS)mParam).Principal[0]["ImpideOperaciones"] != DBNull.Value  ){
                    return ((VentasCommon.venClieEstadosDS)mParam).Principal[0].ImpideOperaciones;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieEstadosDS)mParam).Principal[0].ImpideOperaciones = value;
               }
	          }
        public bool IsImpideOperacionesNull {
             get {
                 return mParam==null || ((VentasCommon.venClieEstadosDS)mParam).Principal[0].IsImpideOperacionesNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((VentasCommon.venClieEstadosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venClieEstadosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((VentasCommon.venClieEstadosDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((VentasCommon.venClieEstadosDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieEstadosDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((VentasCommon.venClieEstadosDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((VentasCommon.venClieEstadosDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((VentasCommon.venClieEstadosDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venClieEstadosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClieEstadosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venClieEstadosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venClieEstadosDS );
     }
     public venClieEstadosActionExchange() : base( "venClieEstados" ) {
     }

     public venClieEstadosActionExchange(venClieEstadosActionEnum.EnumvenClieEstadosAction pAccion) : base(venClieEstadosActionEnum.GetAccionvenClieEstadosAction(pAccion)) {
     }

     public venClieEstadosActionExchange(venClieEstadosActionEnum.EnumvenClieEstadosAction pAccion, VentasCommon.venClieEstadosDS pdsParam) : base(venClieEstadosActionEnum.GetAccionvenClieEstadosAction(pAccion), pdsParam) {
     }

     public venClieEstadosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venClieEstadosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venClieEstadosDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venClieEstadosDS)mParam;
	        }
     }
  }
}
