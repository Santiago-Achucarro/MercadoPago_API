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
    public class tesCheqPropImpresionActionExchange : Framework.Core.Exchange{

        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public String DescripcionCartera {
            get {
                if(((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0]["DescripcionCartera"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0].DescripcionCartera;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0].DescripcionCartera = value;
               }
	          }
        public bool IsDescripcionCarteraNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0].IsDescripcionCarteraNull();
             }
	        }
        public Int32 Chequera_Id {
            get {
                if(((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0]["Chequera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0].Chequera_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0].Chequera_Id = value;
               }
	          }
        public bool IsChequera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0].IsChequera_IdNull();
             }
	        }
        public Int32 NumChequeDesde {
            get {
                if(((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0]["NumChequeDesde"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0].NumChequeDesde;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0].NumChequeDesde = value;
               }
	          }
        public bool IsNumChequeDesdeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0].IsNumChequeDesdeNull();
             }
	        }
        public Int32 NumChequeHasta {
            get {
                if(((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0]["NumChequeHasta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0].NumChequeHasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0].NumChequeHasta = value;
               }
	          }
        public bool IsNumChequeHastaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0].IsNumChequeHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropImpresionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesCheqPropImpresionDS );
     }
     public tesCheqPropImpresionActionExchange() : base( "tesCheqPropImpresion" ) {
     }

     public tesCheqPropImpresionActionExchange(tesCheqPropImpresionActionEnum.EnumtesCheqPropImpresionAction pAccion) : base(tesCheqPropImpresionActionEnum.GetAcciontesCheqPropImpresionAction(pAccion)) {
     }

     public tesCheqPropImpresionActionExchange(tesCheqPropImpresionActionEnum.EnumtesCheqPropImpresionAction pAccion, TesoreriaCommon.tesCheqPropImpresionDS pdsParam) : base(tesCheqPropImpresionActionEnum.GetAcciontesCheqPropImpresionAction(pAccion), pdsParam) {
     }

     public tesCheqPropImpresionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesCheqPropImpresionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesCheqPropImpresionDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesCheqPropImpresionDS)mParam;
	        }
     }
  }
}
