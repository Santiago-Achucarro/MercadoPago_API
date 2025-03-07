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
    public class comMovTiposActionExchange : Framework.Core.Exchange{

        public String TipoMov {
            get {
                if(((ComprasCommon.comMovTiposDS)mParam).Principal[0]["TipoMov"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovTiposDS)mParam).Principal[0].TipoMov;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovTiposDS)mParam).Principal[0].TipoMov = value;
               }
	          }
        public bool IsTipoMovNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovTiposDS)mParam).Principal[0].IsTipoMovNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ComprasCommon.comMovTiposDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovTiposDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovTiposDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovTiposDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int16 Signo {
            get {
                if(((ComprasCommon.comMovTiposDS)mParam).Principal[0]["Signo"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovTiposDS)mParam).Principal[0].Signo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovTiposDS)mParam).Principal[0].Signo = value;
               }
	          }
        public bool IsSignoNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovTiposDS)mParam).Principal[0].IsSignoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovTiposDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovTiposDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovTiposDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovTiposDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovTiposDS );
     }
     public comMovTiposActionExchange() : base( "comMovTipos" ) {
     }

     public comMovTiposActionExchange(comMovTiposActionEnum.EnumcomMovTiposAction pAccion) : base(comMovTiposActionEnum.GetAccioncomMovTiposAction(pAccion)) {
     }

     public comMovTiposActionExchange(comMovTiposActionEnum.EnumcomMovTiposAction pAccion, ComprasCommon.comMovTiposDS pdsParam) : base(comMovTiposActionEnum.GetAccioncomMovTiposAction(pAccion), pdsParam) {
     }

     public comMovTiposActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovTiposDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovTiposDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovTiposDS)mParam;
	        }
     }
  }
}
