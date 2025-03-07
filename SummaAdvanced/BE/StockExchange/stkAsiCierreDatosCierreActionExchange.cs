using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace StockExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class stkAsiCierreDatosCierreActionExchange : Framework.Core.Exchange{

        public DateTime Fecha {
            get {
                if(((StockCommon.stkAsiCierreDatosCierreDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((StockCommon.stkAsiCierreDatosCierreDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkAsiCierreDatosCierreDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((StockCommon.stkAsiCierreDatosCierreDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkAsiCierreDatosCierreDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkAsiCierreDatosCierreDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkAsiCierreDatosCierreDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkAsiCierreDatosCierreDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkAsiCierreDatosCierreDS );
     }
     public stkAsiCierreDatosCierreActionExchange() : base( "stkAsiCierreDatosCierre" ) {
     }

     public stkAsiCierreDatosCierreActionExchange(stkAsiCierreDatosCierreActionEnum.EnumstkAsiCierreDatosCierreAction pAccion) : base(stkAsiCierreDatosCierreActionEnum.GetAccionstkAsiCierreDatosCierreAction(pAccion)) {
     }

     public stkAsiCierreDatosCierreActionExchange(stkAsiCierreDatosCierreActionEnum.EnumstkAsiCierreDatosCierreAction pAccion, StockCommon.stkAsiCierreDatosCierreDS pdsParam) : base(stkAsiCierreDatosCierreActionEnum.GetAccionstkAsiCierreDatosCierreAction(pAccion), pdsParam) {
     }

     public stkAsiCierreDatosCierreActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkAsiCierreDatosCierreDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkAsiCierreDatosCierreDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkAsiCierreDatosCierreDS)mParam;
	        }
     }
  }
}
