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
    public class comProveedoresXLSCatalogoActionExchange : Framework.Core.Exchange{

        public String ProveedorDesde {
            get {
                if(((ComprasCommon.comProveedoresXLSCatalogoDS)mParam).Principal[0]["ProveedorDesde"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresXLSCatalogoDS)mParam).Principal[0].ProveedorDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresXLSCatalogoDS)mParam).Principal[0].ProveedorDesde = value;
               }
	          }
        public bool IsProveedorDesdeNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresXLSCatalogoDS)mParam).Principal[0].IsProveedorDesdeNull();
             }
	        }
        public String ProveedorHasta {
            get {
                if(((ComprasCommon.comProveedoresXLSCatalogoDS)mParam).Principal[0]["ProveedorHasta"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresXLSCatalogoDS)mParam).Principal[0].ProveedorHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresXLSCatalogoDS)mParam).Principal[0].ProveedorHasta = value;
               }
	          }
        public bool IsProveedorHastaNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresXLSCatalogoDS)mParam).Principal[0].IsProveedorHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comProveedoresXLSCatalogoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresXLSCatalogoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresXLSCatalogoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresXLSCatalogoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comProveedoresXLSCatalogoDS );
     }
     public comProveedoresXLSCatalogoActionExchange() : base( "comProveedoresXLSCatalogo" ) {
     }

     public comProveedoresXLSCatalogoActionExchange(comProveedoresXLSCatalogoActionEnum.EnumcomProveedoresXLSCatalogoAction pAccion) : base(comProveedoresXLSCatalogoActionEnum.GetAccioncomProveedoresXLSCatalogoAction(pAccion)) {
     }

     public comProveedoresXLSCatalogoActionExchange(comProveedoresXLSCatalogoActionEnum.EnumcomProveedoresXLSCatalogoAction pAccion, ComprasCommon.comProveedoresXLSCatalogoDS pdsParam) : base(comProveedoresXLSCatalogoActionEnum.GetAccioncomProveedoresXLSCatalogoAction(pAccion), pdsParam) {
     }

     public comProveedoresXLSCatalogoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comProveedoresXLSCatalogoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comProveedoresXLSCatalogoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comProveedoresXLSCatalogoDS)mParam;
	        }
     }
  }
}
