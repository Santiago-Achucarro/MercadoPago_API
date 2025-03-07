using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venCondFiscImpActionExchange : Framework.Core.Exchange{

        public Int32 venCondFiscal {
            get {
                if(((VentasCommon.venCondFiscImpDS)mParam).Principal[0]["venCondFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venCondFiscImpDS)mParam).Principal[0].venCondFiscal;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscImpDS)mParam).Principal[0].venCondFiscal = value;
               }
	          }
        public bool IsvenCondFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscImpDS)mParam).Principal[0].IsvenCondFiscalNull();
             }
	        }
        public String CondFisc_Id {
            get {
                if(((VentasCommon.venCondFiscImpDS)mParam).Principal[0]["CondFisc_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCondFiscImpDS)mParam).Principal[0].CondFisc_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscImpDS)mParam).Principal[0].CondFisc_Id = value;
               }
	          }
        public bool IsCondFisc_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscImpDS)mParam).Principal[0].IsCondFisc_IdNull();
             }
	        }
        public String DescripcionCondFiscal {
            get {
                if(((VentasCommon.venCondFiscImpDS)mParam).Principal[0]["DescripcionCondFiscal"] != DBNull.Value  ){
                    return ((VentasCommon.venCondFiscImpDS)mParam).Principal[0].DescripcionCondFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscImpDS)mParam).Principal[0].DescripcionCondFiscal = value;
               }
	          }
        public bool IsDescripcionCondFiscalNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscImpDS)mParam).Principal[0].IsDescripcionCondFiscalNull();
             }
	        }
        public String Impuesto_Id {
            get {
                if(((VentasCommon.venCondFiscImpDS)mParam).Principal[0]["Impuesto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCondFiscImpDS)mParam).Principal[0].Impuesto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscImpDS)mParam).Principal[0].Impuesto_Id = value;
               }
	          }
        public bool IsImpuesto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscImpDS)mParam).Principal[0].IsImpuesto_IdNull();
             }
	        }
        public String DescripcionImpuestos {
            get {
                if(((VentasCommon.venCondFiscImpDS)mParam).Principal[0]["DescripcionImpuestos"] != DBNull.Value  ){
                    return ((VentasCommon.venCondFiscImpDS)mParam).Principal[0].DescripcionImpuestos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscImpDS)mParam).Principal[0].DescripcionImpuestos = value;
               }
	          }
        public bool IsDescripcionImpuestosNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscImpDS)mParam).Principal[0].IsDescripcionImpuestosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venCondFiscImpDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venCondFiscImpDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCondFiscImpDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCondFiscImpDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCondFiscImpDS );
     }
     public venCondFiscImpActionExchange() : base( "venCondFiscImp" ) {
     }

     public venCondFiscImpActionExchange(venCondFiscImpActionEnum.EnumvenCondFiscImpAction pAccion) : base(venCondFiscImpActionEnum.GetAccionvenCondFiscImpAction(pAccion)) {
     }

     public venCondFiscImpActionExchange(venCondFiscImpActionEnum.EnumvenCondFiscImpAction pAccion, VentasCommon.venCondFiscImpDS pdsParam) : base(venCondFiscImpActionEnum.GetAccionvenCondFiscImpAction(pAccion), pdsParam) {
     }

     public venCondFiscImpActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCondFiscImpDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCondFiscImpDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCondFiscImpDS)mParam;
	        }
     }
  }
}
