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
    public class comMovProvDPreOCActionExchange : Framework.Core.Exchange{

        public Int64 comMovProv {
            get {
                if(((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0]["comMovProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].comMovProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].comMovProv = value;
               }
	          }
        public bool IscomMovProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].IscomMovProvNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public Int64 comMovProvFactOrig {
            get {
                if(((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0]["comMovProvFactOrig"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].comMovProvFactOrig;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].comMovProvFactOrig = value;
               }
	          }
        public bool IscomMovProvFactOrigNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].IscomMovProvFactOrigNull();
             }
	        }
        public Int32 comOrdenComp {
            get {
                if(((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0]["comOrdenComp"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].comOrdenComp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].comOrdenComp = value;
               }
	          }
        public bool IscomOrdenCompNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].IscomOrdenCompNull();
             }
	        }
        public Int32 Renglon_OC {
            get {
                if(((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0]["Renglon_OC"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].Renglon_OC;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].Renglon_OC = value;
               }
	          }
        public bool IsRenglon_OCNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].IsRenglon_OCNull();
             }
	        }
        public Decimal CantidadOriginal {
            get {
                if(((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0]["CantidadOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].CantidadOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].CantidadOriginal = value;
               }
	          }
        public bool IsCantidadOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].IsCantidadOriginalNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal Descuento {
            get {
                if(((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0]["Descuento"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].Descuento;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].Descuento = value;
               }
	          }
        public bool IsDescuentoNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].IsDescuentoNull();
             }
	        }
        public Decimal Monto {
            get {
                if(((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0]["Monto"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].Monto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].Monto = value;
               }
	          }
        public bool IsMontoNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].IsMontoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreOCDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovProvDPreOCDS );
     }
     public comMovProvDPreOCActionExchange() : base( "comMovProvDPreOC" ) {
     }

     public comMovProvDPreOCActionExchange(comMovProvDPreOCActionEnum.EnumcomMovProvDPreOCAction pAccion) : base(comMovProvDPreOCActionEnum.GetAccioncomMovProvDPreOCAction(pAccion)) {
     }

     public comMovProvDPreOCActionExchange(comMovProvDPreOCActionEnum.EnumcomMovProvDPreOCAction pAccion, ComprasCommon.comMovProvDPreOCDS pdsParam) : base(comMovProvDPreOCActionEnum.GetAccioncomMovProvDPreOCAction(pAccion), pdsParam) {
     }

     public comMovProvDPreOCActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovProvDPreOCDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovProvDPreOCDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovProvDPreOCDS)mParam;
	        }
     }
  }
}
