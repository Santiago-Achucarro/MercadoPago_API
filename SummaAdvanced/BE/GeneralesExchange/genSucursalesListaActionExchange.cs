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
    public class genSucursalesListaActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((GeneralesCommon.genSucursalesListaDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesListaDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesListaDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesListaDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genSucursalesListaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSucursalesListaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSucursalesListaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSucursalesListaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genSucursalesListaDS );
     }
     public genSucursalesListaActionExchange() : base( "genSucursalesLista" ) {
     }

     public genSucursalesListaActionExchange(genSucursalesListaActionEnum.EnumgenSucursalesListaAction pAccion) : base(genSucursalesListaActionEnum.GetAcciongenSucursalesListaAction(pAccion)) {
     }

     public genSucursalesListaActionExchange(genSucursalesListaActionEnum.EnumgenSucursalesListaAction pAccion, GeneralesCommon.genSucursalesListaDS pdsParam) : base(genSucursalesListaActionEnum.GetAcciongenSucursalesListaAction(pAccion), pdsParam) {
     }

     public genSucursalesListaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genSucursalesListaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genSucursalesListaDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genSucursalesListaDS)mParam;
	        }
     }
  }
}
