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
    public class sueCategoriasActionExchange : Framework.Core.Exchange{

        public Int32 sueCategorias {
            get {
                if(((SueldosCommon.sueCategoriasDS)mParam).Principal[0]["sueCategorias"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].sueCategorias;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].sueCategorias = value;
               }
	          }
        public bool IssueCategoriasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].IssueCategoriasNull();
             }
	        }
        public String Categoria_Id {
            get {
                if(((SueldosCommon.sueCategoriasDS)mParam).Principal[0]["Categoria_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Categoria_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Categoria_Id = value;
               }
	          }
        public bool IsCategoria_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].IsCategoria_IdNull();
             }
	        }
        public String Categoria_Id_Nueva {
            get {
                if(((SueldosCommon.sueCategoriasDS)mParam).Principal[0]["Categoria_Id_Nueva"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Categoria_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Categoria_Id_Nueva = value;
               }
	          }
        public bool IsCategoria_Id_NuevaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].IsCategoria_Id_NuevaNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueCategoriasDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Periodo_Id {
            get {
                if(((SueldosCommon.sueCategoriasDS)mParam).Principal[0]["Periodo_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Periodo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Periodo_Id = value;
               }
	          }
        public bool IsPeriodo_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].IsPeriodo_IdNull();
             }
	        }
        public String DescripcionPeriodicidad {
            get {
                if(((SueldosCommon.sueCategoriasDS)mParam).Principal[0]["DescripcionPeriodicidad"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].DescripcionPeriodicidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].DescripcionPeriodicidad = value;
               }
	          }
        public bool IsDescripcionPeriodicidadNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].IsDescripcionPeriodicidadNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((SueldosCommon.sueCategoriasDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((SueldosCommon.sueCategoriasDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Int32 Usuario_Id {
            get {
                if(((SueldosCommon.sueCategoriasDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((SueldosCommon.sueCategoriasDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((SueldosCommon.sueCategoriasDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((SueldosCommon.sueCategoriasDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueCategoriasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueCategoriasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueCategoriasDS );
     }
     public sueCategoriasActionExchange() : base( "sueCategorias" ) {
     }

     public sueCategoriasActionExchange(sueCategoriasActionEnum.EnumsueCategoriasAction pAccion) : base(sueCategoriasActionEnum.GetAccionsueCategoriasAction(pAccion)) {
     }

     public sueCategoriasActionExchange(sueCategoriasActionEnum.EnumsueCategoriasAction pAccion, SueldosCommon.sueCategoriasDS pdsParam) : base(sueCategoriasActionEnum.GetAccionsueCategoriasAction(pAccion), pdsParam) {
     }

     public sueCategoriasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueCategoriasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueCategoriasDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueCategoriasDS)mParam;
	        }
     }
  }
}
