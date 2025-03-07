using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace StockExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class stkGruposActionExchange : Framework.Core.Exchange{

        public Int32 stkGrupos {
            get {
                if(((StockCommon.stkGruposDS)mParam).Principal[0]["stkGrupos"] != DBNull.Value  ){
                    return ((StockCommon.stkGruposDS)mParam).Principal[0].stkGrupos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkGruposDS)mParam).Principal[0].stkGrupos = value;
               }
	          }
        public bool IsstkGruposNull {
             get {
                 return mParam==null || ((StockCommon.stkGruposDS)mParam).Principal[0].IsstkGruposNull();
             }
	        }
        public String Grupo_Id {
            get {
                if(((StockCommon.stkGruposDS)mParam).Principal[0]["Grupo_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkGruposDS)mParam).Principal[0].Grupo_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkGruposDS)mParam).Principal[0].Grupo_Id = value;
               }
	          }
        public bool IsGrupo_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkGruposDS)mParam).Principal[0].IsGrupo_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((StockCommon.stkGruposDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((StockCommon.stkGruposDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkGruposDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((StockCommon.stkGruposDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Grupo_Id_Nueva {
            get {
                if(((StockCommon.stkGruposDS)mParam).Principal[0]["Grupo_Id_Nueva"] != DBNull.Value  ){
                    return ((StockCommon.stkGruposDS)mParam).Principal[0].Grupo_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkGruposDS)mParam).Principal[0].Grupo_Id_Nueva = value;
               }
	          }
        public bool IsGrupo_Id_NuevaNull {
             get {
                 return mParam==null || ((StockCommon.stkGruposDS)mParam).Principal[0].IsGrupo_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((StockCommon.stkGruposDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkGruposDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkGruposDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkGruposDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((StockCommon.stkGruposDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((StockCommon.stkGruposDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkGruposDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((StockCommon.stkGruposDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((StockCommon.stkGruposDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((StockCommon.stkGruposDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkGruposDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((StockCommon.stkGruposDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((StockCommon.stkGruposDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((StockCommon.stkGruposDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkGruposDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((StockCommon.stkGruposDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((StockCommon.stkGruposDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkGruposDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkGruposDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkGruposDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((StockCommon.stkGruposDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((StockCommon.stkGruposDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkGruposDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((StockCommon.stkGruposDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkGruposDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkGruposDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkGruposDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkGruposDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkGruposDS );
     }
     public stkGruposActionExchange() : base( "stkGrupos" ) {
     }

     public stkGruposActionExchange(stkGruposActionEnum.EnumstkGruposAction pAccion) : base(stkGruposActionEnum.GetAccionstkGruposAction(pAccion)) {
     }

     public stkGruposActionExchange(stkGruposActionEnum.EnumstkGruposAction pAccion, StockCommon.stkGruposDS pdsParam) : base(stkGruposActionEnum.GetAccionstkGruposAction(pAccion), pdsParam) {
     }

     public stkGruposActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkGruposDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkGruposDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkGruposDS)mParam;
	        }
     }
  }
}
