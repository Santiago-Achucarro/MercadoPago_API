using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comEsquemaAutoActionExchange : Framework.Core.Exchange{

        public Int32 comEsquemaAuto {
            get {
                if(((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0]["comEsquemaAuto"] != DBNull.Value  ){
                    return ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].comEsquemaAuto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].comEsquemaAuto = value;
               }
	          }
        public bool IscomEsquemaAutoNull {
             get {
                 return mParam==null || ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].IscomEsquemaAutoNull();
             }
	        }
        public String EsquemaAuto_Id {
            get {
                if(((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0]["EsquemaAuto_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].EsquemaAuto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].EsquemaAuto_Id = value;
               }
	          }
        public bool IsEsquemaAuto_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].IsEsquemaAuto_IdNull();
             }
	        }
        public String EsquemaAuto_Id_Nueva {
            get {
                if(((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0]["EsquemaAuto_Id_Nueva"] != DBNull.Value  ){
                    return ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].EsquemaAuto_Id_Nueva;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].EsquemaAuto_Id_Nueva = value;
               }
	          }
        public bool IsEsquemaAuto_Id_NuevaNull {
             get {
                 return mParam==null || ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].IsEsquemaAuto_Id_NuevaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean PTodasEmpresas {
            get {
                if(((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0]["PTodasEmpresas"] != DBNull.Value  ){
                    return ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].PTodasEmpresas;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].PTodasEmpresas = value;
               }
	          }
        public bool IsPTodasEmpresasNull {
             get {
                 return mParam==null || ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].IsPTodasEmpresasNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Inactivo {
            get {
                if(((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0]["Inactivo"] != DBNull.Value  ){
                    return ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].Inactivo;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].Inactivo = value;
               }
	          }
        public bool IsInactivoNull {
             get {
                 return mParam==null || ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].IsInactivoNull();
             }
	        }
        public Boolean Posteado {
            get {
                if(((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0]["Posteado"] != DBNull.Value  ){
                    return ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].Posteado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].Posteado = value;
               }
	          }
        public bool IsPosteadoNull {
             get {
                 return mParam==null || ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].IsPosteadoNull();
             }
	        }
        public Int32 Usuario_Id {
            get {
                if(((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comEsquemaAutoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comEsquemaAutoDS );
     }
     public comEsquemaAutoActionExchange() : base( "comEsquemaAuto" ) {
     }

     public comEsquemaAutoActionExchange(comEsquemaAutoActionEnum.EnumcomEsquemaAutoAction pAccion) : base(comEsquemaAutoActionEnum.GetAccioncomEsquemaAutoAction(pAccion)) {
     }

     public comEsquemaAutoActionExchange(comEsquemaAutoActionEnum.EnumcomEsquemaAutoAction pAccion, ComprasCommon.comEsquemaAutoDS pdsParam) : base(comEsquemaAutoActionEnum.GetAccioncomEsquemaAutoAction(pAccion), pdsParam) {
     }

     public comEsquemaAutoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comEsquemaAutoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comEsquemaAutoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comEsquemaAutoDS)mParam;
	        }
     }
  }
}
