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
    public class conCuadro1FilasActionExchange : Framework.Core.Exchange{

        public Int32 conCuadro1Filas {
            get {
                if(((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0]["conCuadro1Filas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].conCuadro1Filas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].conCuadro1Filas = value;
               }
	          }
        public bool IsconCuadro1FilasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].IsconCuadro1FilasNull();
             }
	        }
        public Int32 Cuadro1Fila_Id {
            get {
                if(((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0]["Cuadro1Fila_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].Cuadro1Fila_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].Cuadro1Fila_Id = value;
               }
	          }
        public bool IsCuadro1Fila_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].IsCuadro1Fila_IdNull();
             }
	        }
        public Int32 Cuadro1Fila_Id_Nueva {
            get {
                if(((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0]["Cuadro1Fila_Id_Nueva"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].Cuadro1Fila_Id_Nueva;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].Cuadro1Fila_Id_Nueva = value;
               }
	          }
        public bool IsCuadro1Fila_Id_NuevaNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].IsCuadro1Fila_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuadro1FilasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conCuadro1FilasDS );
     }
     public conCuadro1FilasActionExchange() : base( "conCuadro1Filas" ) {
     }

     public conCuadro1FilasActionExchange(conCuadro1FilasActionEnum.EnumconCuadro1FilasAction pAccion) : base(conCuadro1FilasActionEnum.GetAccionconCuadro1FilasAction(pAccion)) {
     }

     public conCuadro1FilasActionExchange(conCuadro1FilasActionEnum.EnumconCuadro1FilasAction pAccion, ContabilidadCommon.conCuadro1FilasDS pdsParam) : base(conCuadro1FilasActionEnum.GetAccionconCuadro1FilasAction(pAccion), pdsParam) {
     }

     public conCuadro1FilasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conCuadro1FilasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conCuadro1FilasDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conCuadro1FilasDS)mParam;
	        }
     }
  }
}
