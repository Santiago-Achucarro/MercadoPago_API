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
    public class conCuentasCuentasActionExchange : Framework.Core.Exchange{

        public Int32 Cantidad {
            get {
                if(((ContabilidadCommon.conCuentasCuentasDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasCuentasDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasCuentasDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasCuentasDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conCuentasCuentasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conCuentasCuentasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conCuentasCuentasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conCuentasCuentasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conCuentasCuentasDS );
     }
     public conCuentasCuentasActionExchange() : base( "conCuentasCuentas" ) {
     }

     public conCuentasCuentasActionExchange(conCuentasCuentasActionEnum.EnumconCuentasCuentasAction pAccion) : base(conCuentasCuentasActionEnum.GetAccionconCuentasCuentasAction(pAccion)) {
     }

     public conCuentasCuentasActionExchange(conCuentasCuentasActionEnum.EnumconCuentasCuentasAction pAccion, ContabilidadCommon.conCuentasCuentasDS pdsParam) : base(conCuentasCuentasActionEnum.GetAccionconCuentasCuentasAction(pAccion), pdsParam) {
     }

     public conCuentasCuentasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conCuentasCuentasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conCuentasCuentasDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conCuentasCuentasDS)mParam;
	        }
     }
  }
}
