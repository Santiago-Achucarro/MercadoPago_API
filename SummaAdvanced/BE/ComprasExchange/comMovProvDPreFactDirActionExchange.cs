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
    public class comMovProvDPreFactDirActionExchange : Framework.Core.Exchange{

        public Int64 comMovProv {
            get {
                if(((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0]["comMovProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].comMovProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].comMovProv = value;
               }
	          }
        public bool IscomMovProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].IscomMovProvNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public Int64 stkMoviCabe {
            get {
                if(((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public Int32 RenglonStk {
            get {
                if(((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0]["RenglonStk"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].RenglonStk;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].RenglonStk = value;
               }
	          }
        public bool IsRenglonStkNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].IsRenglonStkNull();
             }
	        }
        public Decimal CantidadOriginal {
            get {
                if(((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0]["CantidadOriginal"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].CantidadOriginal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].CantidadOriginal = value;
               }
	          }
        public bool IsCantidadOriginalNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].IsCantidadOriginalNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public Decimal Descuento {
            get {
                if(((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0]["Descuento"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].Descuento;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].Descuento = value;
               }
	          }
        public bool IsDescuentoNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].IsDescuentoNull();
             }
	        }
        public Decimal Monto {
            get {
                if(((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0]["Monto"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].Monto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].Monto = value;
               }
	          }
        public bool IsMontoNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].IsMontoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDPreFactDirDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovProvDPreFactDirDS );
     }
     public comMovProvDPreFactDirActionExchange() : base( "comMovProvDPreFactDir" ) {
     }

     public comMovProvDPreFactDirActionExchange(comMovProvDPreFactDirActionEnum.EnumcomMovProvDPreFactDirAction pAccion) : base(comMovProvDPreFactDirActionEnum.GetAccioncomMovProvDPreFactDirAction(pAccion)) {
     }

     public comMovProvDPreFactDirActionExchange(comMovProvDPreFactDirActionEnum.EnumcomMovProvDPreFactDirAction pAccion, ComprasCommon.comMovProvDPreFactDirDS pdsParam) : base(comMovProvDPreFactDirActionEnum.GetAccioncomMovProvDPreFactDirAction(pAccion), pdsParam) {
     }

     public comMovProvDPreFactDirActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovProvDPreFactDirDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovProvDPreFactDirDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovProvDPreFactDirDS)mParam;
	        }
     }
  }
}
