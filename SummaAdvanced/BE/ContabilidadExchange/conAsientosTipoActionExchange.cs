using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ContabilidadExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class conAsientosTipoActionExchange : Framework.Core.Exchange{

        public Int32 AsiTipo_Id {
            get {
                if(((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0]["AsiTipo_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].AsiTipo_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].AsiTipo_Id = value;
               }
	          }
        public bool IsAsiTipo_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].IsAsiTipo_IdNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String LeyendaLibroDiario {
            get {
                if(((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0]["LeyendaLibroDiario"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].LeyendaLibroDiario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].LeyendaLibroDiario = value;
               }
	          }
        public bool IsLeyendaLibroDiarioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].IsLeyendaLibroDiarioNull();
             }
	        }
        public Boolean Reservada {
            get {
                if(((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0]["Reservada"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].Reservada;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].Reservada = value;
               }
	          }
        public bool IsReservadaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].IsReservadaNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsientosTipoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conAsientosTipoDS );
     }
     public conAsientosTipoActionExchange() : base( "conAsientosTipo" ) {
     }

     public conAsientosTipoActionExchange(conAsientosTipoActionEnum.EnumconAsientosTipoAction pAccion) : base(conAsientosTipoActionEnum.GetAccionconAsientosTipoAction(pAccion)) {
     }

     public conAsientosTipoActionExchange(conAsientosTipoActionEnum.EnumconAsientosTipoAction pAccion, ContabilidadCommon.conAsientosTipoDS pdsParam) : base(conAsientosTipoActionEnum.GetAccionconAsientosTipoAction(pAccion), pdsParam) {
     }

     public conAsientosTipoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conAsientosTipoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conAsientosTipoDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conAsientosTipoDS)mParam;
	        }
     }
  }
}
