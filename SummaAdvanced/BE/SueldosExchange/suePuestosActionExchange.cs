using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace SueldosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class suePuestosActionExchange : Framework.Core.Exchange{

        public Int32 suePuestos {
            get {
                if(((SueldosCommon.suePuestosDS)mParam).Principal[0]["suePuestos"] != DBNull.Value  ){
                    return ((SueldosCommon.suePuestosDS)mParam).Principal[0].suePuestos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePuestosDS)mParam).Principal[0].suePuestos = value;
               }
	          }
        public bool IssuePuestosNull {
             get {
                 return mParam==null || ((SueldosCommon.suePuestosDS)mParam).Principal[0].IssuePuestosNull();
             }
	        }
        public String Puesto_Id {
            get {
                if(((SueldosCommon.suePuestosDS)mParam).Principal[0]["Puesto_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePuestosDS)mParam).Principal[0].Puesto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePuestosDS)mParam).Principal[0].Puesto_Id = value;
               }
	          }
        public bool IsPuesto_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePuestosDS)mParam).Principal[0].IsPuesto_IdNull();
             }
	        }
        public String Puesto_Id_Nueva {
            get {
                if(((SueldosCommon.suePuestosDS)mParam).Principal[0]["Puesto_Id_Nueva"] != DBNull.Value  ){
                    return ((SueldosCommon.suePuestosDS)mParam).Principal[0].Puesto_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePuestosDS)mParam).Principal[0].Puesto_Id_Nueva = value;
               }
	          }
        public bool IsPuesto_Id_NuevaNull {
             get {
                 return mParam==null || ((SueldosCommon.suePuestosDS)mParam).Principal[0].IsPuesto_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.suePuestosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.suePuestosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePuestosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.suePuestosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((SueldosCommon.suePuestosDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((SueldosCommon.suePuestosDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePuestosDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((SueldosCommon.suePuestosDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((SueldosCommon.suePuestosDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((SueldosCommon.suePuestosDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePuestosDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((SueldosCommon.suePuestosDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((SueldosCommon.suePuestosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePuestosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePuestosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePuestosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((SueldosCommon.suePuestosDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((SueldosCommon.suePuestosDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePuestosDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((SueldosCommon.suePuestosDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((SueldosCommon.suePuestosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePuestosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePuestosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePuestosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((SueldosCommon.suePuestosDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((SueldosCommon.suePuestosDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePuestosDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((SueldosCommon.suePuestosDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String RiesgoPuesto {
            get {
                if(((SueldosCommon.suePuestosDS)mParam).Principal[0]["RiesgoPuesto"] != DBNull.Value  ){
                    return ((SueldosCommon.suePuestosDS)mParam).Principal[0].RiesgoPuesto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePuestosDS)mParam).Principal[0].RiesgoPuesto = value;
               }
	          }
        public bool IsRiesgoPuestoNull {
             get {
                 return mParam==null || ((SueldosCommon.suePuestosDS)mParam).Principal[0].IsRiesgoPuestoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.suePuestosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.suePuestosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePuestosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.suePuestosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.suePuestosDS );
     }
     public suePuestosActionExchange() : base( "suePuestos" ) {
     }

     public suePuestosActionExchange(suePuestosActionEnum.EnumsuePuestosAction pAccion) : base(suePuestosActionEnum.GetAccionsuePuestosAction(pAccion)) {
     }

     public suePuestosActionExchange(suePuestosActionEnum.EnumsuePuestosAction pAccion, SueldosCommon.suePuestosDS pdsParam) : base(suePuestosActionEnum.GetAccionsuePuestosAction(pAccion), pdsParam) {
     }

     public suePuestosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.suePuestosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.suePuestosDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.suePuestosDS)mParam;
	        }
     }
  }
}
