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
    public class conOrigAplicRengActionExchange : Framework.Core.Exchange{

        public String GrupoOAF_Id {
            get {
                if(((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0]["GrupoOAF_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].GrupoOAF_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].GrupoOAF_Id = value;
               }
	          }
        public bool IsGrupoOAF_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].IsGrupoOAF_IdNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Int32 Destino {
            get {
                if(((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0]["Destino"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].Destino;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].Destino = value;
               }
	          }
        public bool IsDestinoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].IsDestinoNull();
             }
	        }
        public Int32 Origen {
            get {
                if(((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0]["Origen"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].Origen;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].Origen = value;
               }
	          }
        public bool IsOrigenNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].IsOrigenNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].IsExisteNull();
             }
	        }
        public String DescripcionDestino {
            get {
                if(((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0]["DescripcionDestino"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].DescripcionDestino;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].DescripcionDestino = value;
               }
	          }
        public bool IsDescripcionDestinoNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conOrigAplicRengDS)mParam).Principal[0].IsDescripcionDestinoNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conOrigAplicRengDS );
     }
     public conOrigAplicRengActionExchange() : base( "conOrigAplicReng" ) {
     }

     public conOrigAplicRengActionExchange(conOrigAplicRengActionEnum.EnumconOrigAplicRengAction pAccion) : base(conOrigAplicRengActionEnum.GetAccionconOrigAplicRengAction(pAccion)) {
     }

     public conOrigAplicRengActionExchange(conOrigAplicRengActionEnum.EnumconOrigAplicRengAction pAccion, ContabilidadCommon.conOrigAplicRengDS pdsParam) : base(conOrigAplicRengActionEnum.GetAccionconOrigAplicRengAction(pAccion), pdsParam) {
     }

     public conOrigAplicRengActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conOrigAplicRengDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conOrigAplicRengDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conOrigAplicRengDS)mParam;
	        }
     }
  }
}
