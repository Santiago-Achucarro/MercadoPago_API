using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venClientesXLSCatalogoActionExchange : Framework.Core.Exchange{

        public String ClienteDesde {
            get {
                if(((VentasCommon.venClientesXLSCatalogoDS)mParam).Principal[0]["ClienteDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesXLSCatalogoDS)mParam).Principal[0].ClienteDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesXLSCatalogoDS)mParam).Principal[0].ClienteDesde = value;
               }
	          }
        public bool IsClienteDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesXLSCatalogoDS)mParam).Principal[0].IsClienteDesdeNull();
             }
	        }
        public String ClienteHasta {
            get {
                if(((VentasCommon.venClientesXLSCatalogoDS)mParam).Principal[0]["ClienteHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesXLSCatalogoDS)mParam).Principal[0].ClienteHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesXLSCatalogoDS)mParam).Principal[0].ClienteHasta = value;
               }
	          }
        public bool IsClienteHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesXLSCatalogoDS)mParam).Principal[0].IsClienteHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venClientesXLSCatalogoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venClientesXLSCatalogoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venClientesXLSCatalogoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venClientesXLSCatalogoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venClientesXLSCatalogoDS );
     }
     public venClientesXLSCatalogoActionExchange() : base( "venClientesXLSCatalogo" ) {
     }

     public venClientesXLSCatalogoActionExchange(venClientesXLSCatalogoActionEnum.EnumvenClientesXLSCatalogoAction pAccion) : base(venClientesXLSCatalogoActionEnum.GetAccionvenClientesXLSCatalogoAction(pAccion)) {
     }

     public venClientesXLSCatalogoActionExchange(venClientesXLSCatalogoActionEnum.EnumvenClientesXLSCatalogoAction pAccion, VentasCommon.venClientesXLSCatalogoDS pdsParam) : base(venClientesXLSCatalogoActionEnum.GetAccionvenClientesXLSCatalogoAction(pAccion), pdsParam) {
     }

     public venClientesXLSCatalogoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venClientesXLSCatalogoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venClientesXLSCatalogoDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venClientesXLSCatalogoDS)mParam;
	        }
     }
  }
}
