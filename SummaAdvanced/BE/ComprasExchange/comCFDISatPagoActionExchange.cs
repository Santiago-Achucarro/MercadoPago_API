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
    public class comCFDISatPagoActionExchange : Framework.Core.Exchange{

        public String UUID {
            get {
                if(((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0]["UUID"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0].UUID;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0].UUID = value;
               }
	          }
        public bool IsUUIDNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0].IsUUIDNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String UUIDR {
            get {
                if(((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0]["UUIDR"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0].UUIDR;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0].UUIDR = value;
               }
	          }
        public bool IsUUIDRNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0].IsUUIDRNull();
             }
	        }
        public Decimal Monto {
            get {
                if(((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0]["Monto"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0].Monto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0].Monto = value;
               }
	          }
        public bool IsMontoNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0].IsMontoNull();
             }
	        }
        public String Moneda {
            get {
                if(((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0]["Moneda"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0].Moneda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0].Moneda = value;
               }
	          }
        public bool IsMonedaNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0].IsMonedaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatPagoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comCFDISatPagoDS );
     }
     public comCFDISatPagoActionExchange() : base( "comCFDISatPago" ) {
     }

     public comCFDISatPagoActionExchange(comCFDISatPagoActionEnum.EnumcomCFDISatPagoAction pAccion) : base(comCFDISatPagoActionEnum.GetAccioncomCFDISatPagoAction(pAccion)) {
     }

     public comCFDISatPagoActionExchange(comCFDISatPagoActionEnum.EnumcomCFDISatPagoAction pAccion, ComprasCommon.comCFDISatPagoDS pdsParam) : base(comCFDISatPagoActionEnum.GetAccioncomCFDISatPagoAction(pAccion), pdsParam) {
     }

     public comCFDISatPagoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comCFDISatPagoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comCFDISatPagoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comCFDISatPagoDS)mParam;
	        }
     }
  }
}
