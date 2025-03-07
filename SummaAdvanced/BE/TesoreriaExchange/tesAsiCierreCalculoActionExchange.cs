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
    public class tesAsiCierreCalculoActionExchange : Framework.Core.Exchange{

        public DateTime Fecha {
            get {
                if(((TesoreriaCommon.tesAsiCierreCalculoDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAsiCierreCalculoDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAsiCierreCalculoDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAsiCierreCalculoDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesAsiCierreCalculoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAsiCierreCalculoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAsiCierreCalculoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAsiCierreCalculoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesAsiCierreCalculoDS );
     }
     public tesAsiCierreCalculoActionExchange() : base( "tesAsiCierreCalculo" ) {
     }

     public tesAsiCierreCalculoActionExchange(tesAsiCierreCalculoActionEnum.EnumtesAsiCierreCalculoAction pAccion) : base(tesAsiCierreCalculoActionEnum.GetAcciontesAsiCierreCalculoAction(pAccion)) {
     }

     public tesAsiCierreCalculoActionExchange(tesAsiCierreCalculoActionEnum.EnumtesAsiCierreCalculoAction pAccion, TesoreriaCommon.tesAsiCierreCalculoDS pdsParam) : base(tesAsiCierreCalculoActionEnum.GetAcciontesAsiCierreCalculoAction(pAccion), pdsParam) {
     }

     public tesAsiCierreCalculoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesAsiCierreCalculoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesAsiCierreCalculoDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesAsiCierreCalculoDS)mParam;
	        }
     }
  }
}
