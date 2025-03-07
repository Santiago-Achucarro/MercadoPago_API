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
    public class tesDepoPorIdentActionExchange : Framework.Core.Exchange{

        public Int64 tesMovimientos {
            get {
                if(((TesoreriaCommon.tesDepoPorIdentDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepoPorIdentDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepoPorIdentDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepoPorIdentDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public Int64 venMovimientos {
            get {
                if(((TesoreriaCommon.tesDepoPorIdentDS)mParam).Principal[0]["venMovimientos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepoPorIdentDS)mParam).Principal[0].venMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepoPorIdentDS)mParam).Principal[0].venMovimientos = value;
               }
	          }
        public bool IsvenMovimientosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepoPorIdentDS)mParam).Principal[0].IsvenMovimientosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesDepoPorIdentDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepoPorIdentDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepoPorIdentDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepoPorIdentDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesDepoPorIdentDS );
     }
     public tesDepoPorIdentActionExchange() : base( "tesDepoPorIdent" ) {
     }

     public tesDepoPorIdentActionExchange(tesDepoPorIdentActionEnum.EnumtesDepoPorIdentAction pAccion) : base(tesDepoPorIdentActionEnum.GetAcciontesDepoPorIdentAction(pAccion)) {
     }

     public tesDepoPorIdentActionExchange(tesDepoPorIdentActionEnum.EnumtesDepoPorIdentAction pAccion, TesoreriaCommon.tesDepoPorIdentDS pdsParam) : base(tesDepoPorIdentActionEnum.GetAcciontesDepoPorIdentAction(pAccion), pdsParam) {
     }

     public tesDepoPorIdentActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesDepoPorIdentDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public tesDepoPorIdentActionExchange(TesoreriaCommon.tesDepoPorIdentDS pDS) : base() {
     this.Action = "";
     this.mParam = new TesoreriaCommon.tesDepoPorIdentDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesDepoPorIdentDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesDepoPorIdentDS)mParam;
	        }
     }
  }
}
