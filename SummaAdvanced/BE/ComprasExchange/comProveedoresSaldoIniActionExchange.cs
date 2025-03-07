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
    public class comProveedoresSaldoIniActionExchange : Framework.Core.Exchange{

        public String ProveedDesde {
            get {
                if(((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0]["ProveedDesde"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0].ProveedDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0].ProveedDesde = value;
               }
	          }
        public bool IsProveedDesdeNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0].IsProveedDesdeNull();
             }
	        }
        public String ProveedHasta {
            get {
                if(((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0]["ProveedHasta"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0].ProveedHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0].ProveedHasta = value;
               }
	          }
        public bool IsProveedHastaNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0].IsProveedHastaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Archivo {
            get {
                if(((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0]["Archivo"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0].Archivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0].Archivo = value;
               }
	          }
        public bool IsArchivoNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0].IsArchivoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresSaldoIniDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comProveedoresSaldoIniDS );
     }
     public comProveedoresSaldoIniActionExchange() : base( "comProveedoresSaldoIni" ) {
     }

     public comProveedoresSaldoIniActionExchange(comProveedoresSaldoIniActionEnum.EnumcomProveedoresSaldoIniAction pAccion) : base(comProveedoresSaldoIniActionEnum.GetAccioncomProveedoresSaldoIniAction(pAccion)) {
     }

     public comProveedoresSaldoIniActionExchange(comProveedoresSaldoIniActionEnum.EnumcomProveedoresSaldoIniAction pAccion, ComprasCommon.comProveedoresSaldoIniDS pdsParam) : base(comProveedoresSaldoIniActionEnum.GetAccioncomProveedoresSaldoIniAction(pAccion), pdsParam) {
     }

     public comProveedoresSaldoIniActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comProveedoresSaldoIniDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comProveedoresSaldoIniDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comProveedoresSaldoIniDS)mParam;
	        }
     }
  }
}
