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
    public class tesIdentificaSaldoActionExchange : Framework.Core.Exchange{

        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesIdentificaSaldoDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdentificaSaldoDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdentificaSaldoDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdentificaSaldoDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public Decimal SaldoContable {
            get {
                if(((TesoreriaCommon.tesIdentificaSaldoDS)mParam).Principal[0]["SaldoContable"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdentificaSaldoDS)mParam).Principal[0].SaldoContable;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdentificaSaldoDS)mParam).Principal[0].SaldoContable = value;
               }
	          }
        public bool IsSaldoContableNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdentificaSaldoDS)mParam).Principal[0].IsSaldoContableNull();
             }
	        }
        public Decimal SaldoBanco {
            get {
                if(((TesoreriaCommon.tesIdentificaSaldoDS)mParam).Principal[0]["SaldoBanco"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdentificaSaldoDS)mParam).Principal[0].SaldoBanco;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdentificaSaldoDS)mParam).Principal[0].SaldoBanco = value;
               }
	          }
        public bool IsSaldoBancoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdentificaSaldoDS)mParam).Principal[0].IsSaldoBancoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesIdentificaSaldoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdentificaSaldoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdentificaSaldoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdentificaSaldoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesIdentificaSaldoDS );
     }
     public tesIdentificaSaldoActionExchange() : base( "tesIdentificaSaldo" ) {
     }

     public tesIdentificaSaldoActionExchange(tesIdentificaSaldoActionEnum.EnumtesIdentificaSaldoAction pAccion) : base(tesIdentificaSaldoActionEnum.GetAcciontesIdentificaSaldoAction(pAccion)) {
     }

     public tesIdentificaSaldoActionExchange(tesIdentificaSaldoActionEnum.EnumtesIdentificaSaldoAction pAccion, TesoreriaCommon.tesIdentificaSaldoDS pdsParam) : base(tesIdentificaSaldoActionEnum.GetAcciontesIdentificaSaldoAction(pAccion), pdsParam) {
     }

     public tesIdentificaSaldoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesIdentificaSaldoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesIdentificaSaldoDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesIdentificaSaldoDS)mParam;
	        }
     }
  }
}
