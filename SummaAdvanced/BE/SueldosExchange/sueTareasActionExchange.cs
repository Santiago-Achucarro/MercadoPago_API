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
    public class sueTareasActionExchange : Framework.Core.Exchange{

        public Int32 sueTareas {
            get {
                if(((SueldosCommon.sueTareasDS)mParam).Principal[0]["sueTareas"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTareasDS)mParam).Principal[0].sueTareas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTareasDS)mParam).Principal[0].sueTareas = value;
               }
	          }
        public bool IssueTareasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTareasDS)mParam).Principal[0].IssueTareasNull();
             }
	        }
        public String Tarea_Id {
            get {
                if(((SueldosCommon.sueTareasDS)mParam).Principal[0]["Tarea_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTareasDS)mParam).Principal[0].Tarea_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTareasDS)mParam).Principal[0].Tarea_Id = value;
               }
	          }
        public bool IsTarea_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTareasDS)mParam).Principal[0].IsTarea_IdNull();
             }
	        }
        public String Tarea_Id_Nueva {
            get {
                if(((SueldosCommon.sueTareasDS)mParam).Principal[0]["Tarea_Id_Nueva"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTareasDS)mParam).Principal[0].Tarea_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTareasDS)mParam).Principal[0].Tarea_Id_Nueva = value;
               }
	          }
        public bool IsTarea_Id_NuevaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTareasDS)mParam).Principal[0].IsTarea_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueTareasDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTareasDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTareasDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTareasDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((SueldosCommon.sueTareasDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTareasDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTareasDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTareasDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((SueldosCommon.sueTareasDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTareasDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTareasDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTareasDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((SueldosCommon.sueTareasDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTareasDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTareasDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTareasDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((SueldosCommon.sueTareasDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTareasDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTareasDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTareasDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((SueldosCommon.sueTareasDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTareasDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTareasDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTareasDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((SueldosCommon.sueTareasDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTareasDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTareasDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTareasDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueTareasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueTareasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueTareasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueTareasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueTareasDS );
     }
     public sueTareasActionExchange() : base( "sueTareas" ) {
     }

     public sueTareasActionExchange(sueTareasActionEnum.EnumsueTareasAction pAccion) : base(sueTareasActionEnum.GetAccionsueTareasAction(pAccion)) {
     }

     public sueTareasActionExchange(sueTareasActionEnum.EnumsueTareasAction pAccion, SueldosCommon.sueTareasDS pdsParam) : base(sueTareasActionEnum.GetAccionsueTareasAction(pAccion), pdsParam) {
     }

     public sueTareasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueTareasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueTareasDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueTareasDS)mParam;
	        }
     }
  }
}
