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
    public class comProveedoresImpuestosActionExchange : Framework.Core.Exchange{

        public Int64 genEntidades {
            get {
                if(((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0]["genEntidades"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0].genEntidades;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0].genEntidades = value;
               }
	          }
        public bool IsgenEntidadesNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0].IsgenEntidadesNull();
             }
	        }
        public String Proveed_Id {
            get {
                if(((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String Impuesto_Id {
            get {
                if(((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0]["Impuesto_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0].Impuesto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0].Impuesto_Id = value;
               }
	          }
        public bool IsImpuesto_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0].IsImpuesto_IdNull();
             }
	        }
        public String DescripcionImpuestos {
            get {
                if(((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0]["DescripcionImpuestos"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0].DescripcionImpuestos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0].DescripcionImpuestos = value;
               }
	          }
        public bool IsDescripcionImpuestosNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0].IsDescripcionImpuestosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresImpuestosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comProveedoresImpuestosDS );
     }
     public comProveedoresImpuestosActionExchange() : base( "comProveedoresImpuestos" ) {
     }

     public comProveedoresImpuestosActionExchange(comProveedoresImpuestosActionEnum.EnumcomProveedoresImpuestosAction pAccion) : base(comProveedoresImpuestosActionEnum.GetAccioncomProveedoresImpuestosAction(pAccion)) {
     }

     public comProveedoresImpuestosActionExchange(comProveedoresImpuestosActionEnum.EnumcomProveedoresImpuestosAction pAccion, ComprasCommon.comProveedoresImpuestosDS pdsParam) : base(comProveedoresImpuestosActionEnum.GetAccioncomProveedoresImpuestosAction(pAccion), pdsParam) {
     }

     public comProveedoresImpuestosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comProveedoresImpuestosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comProveedoresImpuestosDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comProveedoresImpuestosDS)mParam;
	        }
     }
  }
}
