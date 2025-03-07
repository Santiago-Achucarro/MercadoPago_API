using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesoreriaExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesSolicitudParaAutorizarActionExchange : Framework.Core.Exchange{

        public Int32 Empresa {
            get {
                if(((TesoreriaCommon.tesSolicitudParaAutorizarDS)mParam).Principal[0]["Empresa"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudParaAutorizarDS)mParam).Principal[0].Empresa;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudParaAutorizarDS)mParam).Principal[0].Empresa = value;
               }
	          }
        public bool IsEmpresaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudParaAutorizarDS)mParam).Principal[0].IsEmpresaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesSolicitudParaAutorizarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesSolicitudParaAutorizarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesSolicitudParaAutorizarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesSolicitudParaAutorizarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesSolicitudParaAutorizarDS );
     }
     public tesSolicitudParaAutorizarActionExchange() : base( "tesSolicitudParaAutorizar" ) {
     }

     public tesSolicitudParaAutorizarActionExchange(tesSolicitudParaAutorizarActionEnum.EnumtesSolicitudParaAutorizarAction pAccion) : base(tesSolicitudParaAutorizarActionEnum.GetAcciontesSolicitudParaAutorizarAction(pAccion)) {
     }

     public tesSolicitudParaAutorizarActionExchange(tesSolicitudParaAutorizarActionEnum.EnumtesSolicitudParaAutorizarAction pAccion, TesoreriaCommon.tesSolicitudParaAutorizarDS pdsParam) : base(tesSolicitudParaAutorizarActionEnum.GetAcciontesSolicitudParaAutorizarAction(pAccion), pdsParam) {
     }

     public tesSolicitudParaAutorizarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesSolicitudParaAutorizarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesSolicitudParaAutorizarDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesSolicitudParaAutorizarDS)mParam;
	        }
     }
  }
}
