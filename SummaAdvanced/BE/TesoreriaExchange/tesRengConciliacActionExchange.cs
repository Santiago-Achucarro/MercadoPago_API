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
    public class tesRengConciliacActionExchange : Framework.Core.Exchange{

        public Int64 tesMovimientos {
            get {
                if(((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public Int32 conRenglon {
            get {
                if(((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0]["conRenglon"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0].conRenglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0].conRenglon = value;
               }
	          }
        public bool IsconRenglonNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0].IsconRenglonNull();
             }
	        }
        public Decimal Saldo {
            get {
                if(((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0]["Saldo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0].Saldo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0].Saldo = value;
               }
	          }
        public bool IsSaldoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0].IsSaldoNull();
             }
	        }
        public Decimal ImporteOrig {
            get {
                if(((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0]["ImporteOrig"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0].ImporteOrig;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0].ImporteOrig = value;
               }
	          }
        public bool IsImporteOrigNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0].IsImporteOrigNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengConciliacDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesRengConciliacDS );
     }
     public tesRengConciliacActionExchange() : base( "tesRengConciliac" ) {
     }

     public tesRengConciliacActionExchange(tesRengConciliacActionEnum.EnumtesRengConciliacAction pAccion) : base(tesRengConciliacActionEnum.GetAcciontesRengConciliacAction(pAccion)) {
     }

     public tesRengConciliacActionExchange(tesRengConciliacActionEnum.EnumtesRengConciliacAction pAccion, TesoreriaCommon.tesRengConciliacDS pdsParam) : base(tesRengConciliacActionEnum.GetAcciontesRengConciliacAction(pAccion), pdsParam) {
     }

     public tesRengConciliacActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesRengConciliacDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesRengConciliacDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesRengConciliacDS)mParam;
	        }
     }
  }
}
