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
    public class tesDepositosXBancosActionExchange : Framework.Core.Exchange{

        public DateTime FechaDesde {
            get {
                if(((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public String DescripcionCartera {
            get {
                if(((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0]["DescripcionCartera"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0].DescripcionCartera;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0].DescripcionCartera = value;
               }
	          }
        public bool IsDescripcionCarteraNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0].IsDescripcionCarteraNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepositosXBancosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesDepositosXBancosDS );
     }
     public tesDepositosXBancosActionExchange() : base( "tesDepositosXBancos" ) {
     }

     public tesDepositosXBancosActionExchange(tesDepositosXBancosActionEnum.EnumtesDepositosXBancosAction pAccion) : base(tesDepositosXBancosActionEnum.GetAcciontesDepositosXBancosAction(pAccion)) {
     }

     public tesDepositosXBancosActionExchange(tesDepositosXBancosActionEnum.EnumtesDepositosXBancosAction pAccion, TesoreriaCommon.tesDepositosXBancosDS pdsParam) : base(tesDepositosXBancosActionEnum.GetAcciontesDepositosXBancosAction(pAccion), pdsParam) {
     }

     public tesDepositosXBancosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesDepositosXBancosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesDepositosXBancosDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesDepositosXBancosDS)mParam;
	        }
     }
  }
}
