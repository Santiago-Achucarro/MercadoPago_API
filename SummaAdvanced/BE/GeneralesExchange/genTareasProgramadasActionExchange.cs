using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genTareasProgramadasActionExchange : Framework.Core.Exchange{

        public Int32 genTareasProgramadas {
            get {
                if(((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0]["genTareasProgramadas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].genTareasProgramadas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].genTareasProgramadas = value;
               }
	          }
        public bool IsgenTareasProgramadasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].IsgenTareasProgramadasNull();
             }
	        }
        public String TareaProgramada_Id {
            get {
                if(((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0]["TareaProgramada_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].TareaProgramada_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].TareaProgramada_Id = value;
               }
	          }
        public bool IsTareaProgramada_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].IsTareaProgramada_IdNull();
             }
	        }
        public String TareaProgramada_Id_Nueva {
            get {
                if(((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0]["TareaProgramada_Id_Nueva"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].TareaProgramada_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].TareaProgramada_Id_Nueva = value;
               }
	          }
        public bool IsTareaProgramada_Id_NuevaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].IsTareaProgramada_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String TipoEjecucionTarea_Id {
            get {
                if(((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0]["TipoEjecucionTarea_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].TipoEjecucionTarea_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].TipoEjecucionTarea_Id = value;
               }
	          }
        public bool IsTipoEjecucionTarea_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].IsTipoEjecucionTarea_IdNull();
             }
	        }
        public String Tarea_Id {
            get {
                if(((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0]["Tarea_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].Tarea_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].Tarea_Id = value;
               }
	          }
        public bool IsTarea_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].IsTarea_IdNull();
             }
	        }
        public String DescripcionTareas {
            get {
                if(((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0]["DescripcionTareas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].DescripcionTareas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].DescripcionTareas = value;
               }
	          }
        public bool IsDescripcionTareasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].IsDescripcionTareasNull();
             }
	        }
        public DateTime FechaInicio {
            get {
                if(((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0]["FechaInicio"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].FechaInicio;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].FechaInicio = value;
               }
	          }
        public bool IsFechaInicioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].IsFechaInicioNull();
             }
	        }
        public String HoraInicio {
            get {
                if(((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0]["HoraInicio"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].HoraInicio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].HoraInicio = value;
               }
	          }
        public bool IsHoraInicioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].IsHoraInicioNull();
             }
	        }
        public DateTime FechaFin {
            get {
                if(((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0]["FechaFin"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].FechaFin;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].FechaFin = value;
               }
	          }
        public bool IsFechaFinNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].IsFechaFinNull();
             }
	        }
        public String HoraFin {
            get {
                if(((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0]["HoraFin"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].HoraFin;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].HoraFin = value;
               }
	          }
        public bool IsHoraFinNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].IsHoraFinNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genTareasProgramadasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genTareasProgramadasDS );
     }
     public genTareasProgramadasActionExchange() : base( "genTareasProgramadas" ) {
     }

     public genTareasProgramadasActionExchange(genTareasProgramadasActionEnum.EnumgenTareasProgramadasAction pAccion) : base(genTareasProgramadasActionEnum.GetAcciongenTareasProgramadasAction(pAccion)) {
     }

     public genTareasProgramadasActionExchange(genTareasProgramadasActionEnum.EnumgenTareasProgramadasAction pAccion, GeneralesCommon.genTareasProgramadasDS pdsParam) : base(genTareasProgramadasActionEnum.GetAcciongenTareasProgramadasAction(pAccion), pdsParam) {
     }

     public genTareasProgramadasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genTareasProgramadasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genTareasProgramadasDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genTareasProgramadasDS)mParam;
	        }
     }
  }
}
