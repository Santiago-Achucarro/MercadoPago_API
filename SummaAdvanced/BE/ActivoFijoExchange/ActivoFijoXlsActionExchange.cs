using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ActivoFijoExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class ActivoFijoXlsActionExchange : Framework.Core.Exchange{

        public String Archivo {
            get {
                if(((ActivoFijoCommon.ActivoFijoXlsDS)mParam).Principal[0]["Archivo"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.ActivoFijoXlsDS)mParam).Principal[0].Archivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.ActivoFijoXlsDS)mParam).Principal[0].Archivo = value;
               }
	          }
        public bool IsArchivoNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.ActivoFijoXlsDS)mParam).Principal[0].IsArchivoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ActivoFijoCommon.ActivoFijoXlsDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.ActivoFijoXlsDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.ActivoFijoXlsDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.ActivoFijoXlsDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ActivoFijoCommon.ActivoFijoXlsDS );
     }
     public ActivoFijoXlsActionExchange() : base( "ActivoFijoXls" ) {
     }

     public ActivoFijoXlsActionExchange(ActivoFijoXlsActionEnum.EnumActivoFijoXlsAction pAccion) : base(ActivoFijoXlsActionEnum.GetAccionActivoFijoXlsAction(pAccion)) {
     }

     public ActivoFijoXlsActionExchange(ActivoFijoXlsActionEnum.EnumActivoFijoXlsAction pAccion, ActivoFijoCommon.ActivoFijoXlsDS pdsParam) : base(ActivoFijoXlsActionEnum.GetAccionActivoFijoXlsAction(pAccion), pdsParam) {
     }

     public ActivoFijoXlsActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ActivoFijoCommon.ActivoFijoXlsDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ActivoFijoCommon.ActivoFijoXlsDS Param{
	        get{
			    InitParam();
			    return (ActivoFijoCommon.ActivoFijoXlsDS)mParam;
	        }
     }
  }
}
