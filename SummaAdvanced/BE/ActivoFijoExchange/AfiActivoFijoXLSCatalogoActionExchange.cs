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
    public class AfiActivoFijoXLSCatalogoActionExchange : Framework.Core.Exchange{

        public String ActivoFijoDesde {
            get {
                if(((ActivoFijoCommon.AfiActivoFijoXLSCatalogoDS)mParam).Principal[0]["ActivoFijoDesde"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiActivoFijoXLSCatalogoDS)mParam).Principal[0].ActivoFijoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiActivoFijoXLSCatalogoDS)mParam).Principal[0].ActivoFijoDesde = value;
               }
	          }
        public bool IsActivoFijoDesdeNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiActivoFijoXLSCatalogoDS)mParam).Principal[0].IsActivoFijoDesdeNull();
             }
	        }
        public String ActivoFijoHasta {
            get {
                if(((ActivoFijoCommon.AfiActivoFijoXLSCatalogoDS)mParam).Principal[0]["ActivoFijoHasta"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiActivoFijoXLSCatalogoDS)mParam).Principal[0].ActivoFijoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiActivoFijoXLSCatalogoDS)mParam).Principal[0].ActivoFijoHasta = value;
               }
	          }
        public bool IsActivoFijoHastaNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiActivoFijoXLSCatalogoDS)mParam).Principal[0].IsActivoFijoHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ActivoFijoCommon.AfiActivoFijoXLSCatalogoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ActivoFijoCommon.AfiActivoFijoXLSCatalogoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ActivoFijoCommon.AfiActivoFijoXLSCatalogoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ActivoFijoCommon.AfiActivoFijoXLSCatalogoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ActivoFijoCommon.AfiActivoFijoXLSCatalogoDS );
     }
     public AfiActivoFijoXLSCatalogoActionExchange() : base( "AfiActivoFijoXLSCatalogo" ) {
     }

     public AfiActivoFijoXLSCatalogoActionExchange(AfiActivoFijoXLSCatalogoActionEnum.EnumAfiActivoFijoXLSCatalogoAction pAccion) : base(AfiActivoFijoXLSCatalogoActionEnum.GetAccionAfiActivoFijoXLSCatalogoAction(pAccion)) {
     }

     public AfiActivoFijoXLSCatalogoActionExchange(AfiActivoFijoXLSCatalogoActionEnum.EnumAfiActivoFijoXLSCatalogoAction pAccion, ActivoFijoCommon.AfiActivoFijoXLSCatalogoDS pdsParam) : base(AfiActivoFijoXLSCatalogoActionEnum.GetAccionAfiActivoFijoXLSCatalogoAction(pAccion), pdsParam) {
     }

     public AfiActivoFijoXLSCatalogoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ActivoFijoCommon.AfiActivoFijoXLSCatalogoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ActivoFijoCommon.AfiActivoFijoXLSCatalogoDS Param{
	        get{
			    InitParam();
			    return (ActivoFijoCommon.AfiActivoFijoXLSCatalogoDS)mParam;
	        }
     }
  }
}
