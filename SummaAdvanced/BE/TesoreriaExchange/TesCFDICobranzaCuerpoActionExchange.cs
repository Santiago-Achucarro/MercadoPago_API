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
    public class TesCFDICobranzaCuerpoActionExchange : Framework.Core.Exchange{

        public Int32 TesCFDICobranza {
            get {
                if(((TesoreriaCommon.TesCFDICobranzaCuerpoDS)mParam).Principal[0]["TesCFDICobranza"] != DBNull.Value  ){
                    return ((TesoreriaCommon.TesCFDICobranzaCuerpoDS)mParam).Principal[0].TesCFDICobranza;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.TesCFDICobranzaCuerpoDS)mParam).Principal[0].TesCFDICobranza = value;
               }
	          }
        public bool IsTesCFDICobranzaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.TesCFDICobranzaCuerpoDS)mParam).Principal[0].IsTesCFDICobranzaNull();
             }
	        }
        public Int64 tesMovimientos {
            get {
                if(((TesoreriaCommon.TesCFDICobranzaCuerpoDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.TesCFDICobranzaCuerpoDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.TesCFDICobranzaCuerpoDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.TesCFDICobranzaCuerpoDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.TesCFDICobranzaCuerpoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.TesCFDICobranzaCuerpoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.TesCFDICobranzaCuerpoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.TesCFDICobranzaCuerpoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.TesCFDICobranzaCuerpoDS );
     }
     public TesCFDICobranzaCuerpoActionExchange() : base( "TesCFDICobranzaCuerpo" ) {
     }

     public TesCFDICobranzaCuerpoActionExchange(TesCFDICobranzaCuerpoActionEnum.EnumTesCFDICobranzaCuerpoAction pAccion) : base(TesCFDICobranzaCuerpoActionEnum.GetAccionTesCFDICobranzaCuerpoAction(pAccion)) {
     }

     public TesCFDICobranzaCuerpoActionExchange(TesCFDICobranzaCuerpoActionEnum.EnumTesCFDICobranzaCuerpoAction pAccion, TesoreriaCommon.TesCFDICobranzaCuerpoDS pdsParam) : base(TesCFDICobranzaCuerpoActionEnum.GetAccionTesCFDICobranzaCuerpoAction(pAccion), pdsParam) {
     }

     public TesCFDICobranzaCuerpoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.TesCFDICobranzaCuerpoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.TesCFDICobranzaCuerpoDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.TesCFDICobranzaCuerpoDS)mParam;
	        }
     }
  }
}
