using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ImpuestosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class impLibrosTiposRenglonActionExchange : Framework.Core.Exchange{

        public String TipoRenglon {
            get {
                if(((ImpuestosCommon.impLibrosTiposRenglonDS)mParam).Principal[0]["TipoRenglon"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLibrosTiposRenglonDS)mParam).Principal[0].TipoRenglon;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLibrosTiposRenglonDS)mParam).Principal[0].TipoRenglon = value;
               }
	          }
        public bool IsTipoRenglonNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLibrosTiposRenglonDS)mParam).Principal[0].IsTipoRenglonNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ImpuestosCommon.impLibrosTiposRenglonDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLibrosTiposRenglonDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLibrosTiposRenglonDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLibrosTiposRenglonDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impLibrosTiposRenglonDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impLibrosTiposRenglonDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impLibrosTiposRenglonDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impLibrosTiposRenglonDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impLibrosTiposRenglonDS );
     }
     public impLibrosTiposRenglonActionExchange() : base( "impLibrosTiposRenglon" ) {
     }

     public impLibrosTiposRenglonActionExchange(impLibrosTiposRenglonActionEnum.EnumimpLibrosTiposRenglonAction pAccion) : base(impLibrosTiposRenglonActionEnum.GetAccionimpLibrosTiposRenglonAction(pAccion)) {
     }

     public impLibrosTiposRenglonActionExchange(impLibrosTiposRenglonActionEnum.EnumimpLibrosTiposRenglonAction pAccion, ImpuestosCommon.impLibrosTiposRenglonDS pdsParam) : base(impLibrosTiposRenglonActionEnum.GetAccionimpLibrosTiposRenglonAction(pAccion), pdsParam) {
     }

     public impLibrosTiposRenglonActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impLibrosTiposRenglonDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impLibrosTiposRenglonDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impLibrosTiposRenglonDS)mParam;
	        }
     }
  }
}
