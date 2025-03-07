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
    public class genEmpresasTodasActionExchange : Framework.Core.Exchange{

        public String Empresa_id {
            get {
                if(((GeneralesCommon.genEmpresasTodasDS)mParam).Principal[0]["Empresa_id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasTodasDS)mParam).Principal[0].Empresa_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasTodasDS)mParam).Principal[0].Empresa_id = value;
               }
	          }
        public bool IsEmpresa_idNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasTodasDS)mParam).Principal[0].IsEmpresa_idNull();
             }
	        }
        public String Detalle {
            get {
                if(((GeneralesCommon.genEmpresasTodasDS)mParam).Principal[0]["Detalle"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasTodasDS)mParam).Principal[0].Detalle;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasTodasDS)mParam).Principal[0].Detalle = value;
               }
	          }
        public bool IsDetalleNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasTodasDS)mParam).Principal[0].IsDetalleNull();
             }
	        }
        public Int32 genEmpresas {
            get {
                if(((GeneralesCommon.genEmpresasTodasDS)mParam).Principal[0]["genEmpresas"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasTodasDS)mParam).Principal[0].genEmpresas;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasTodasDS)mParam).Principal[0].genEmpresas = value;
               }
	          }
        public bool IsgenEmpresasNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasTodasDS)mParam).Principal[0].IsgenEmpresasNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genEmpresasTodasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genEmpresasTodasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genEmpresasTodasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genEmpresasTodasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genEmpresasTodasDS );
     }
     public genEmpresasTodasActionExchange() : base( "genEmpresasTodas" ) {
     }

     public genEmpresasTodasActionExchange(genEmpresasTodasActionEnum.EnumgenEmpresasTodasAction pAccion) : base(genEmpresasTodasActionEnum.GetAcciongenEmpresasTodasAction(pAccion)) {
     }

     public genEmpresasTodasActionExchange(genEmpresasTodasActionEnum.EnumgenEmpresasTodasAction pAccion, GeneralesCommon.genEmpresasTodasDS pdsParam) : base(genEmpresasTodasActionEnum.GetAcciongenEmpresasTodasAction(pAccion), pdsParam) {
     }

     public genEmpresasTodasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genEmpresasTodasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genEmpresasTodasDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genEmpresasTodasDS)mParam;
	        }
     }
  }
}
