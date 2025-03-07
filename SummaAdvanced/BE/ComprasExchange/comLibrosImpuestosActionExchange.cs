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
    public class comLibrosImpuestosActionExchange : Framework.Core.Exchange{

        public Int32 comLibros {
            get {
                if(((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0]["comLibros"] != DBNull.Value  ){
                    return ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].comLibros;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].comLibros = value;
               }
	          }
        public bool IscomLibrosNull {
             get {
                 return mParam==null || ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].IscomLibrosNull();
             }
	        }
        public Int32 Columna {
            get {
                if(((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0]["Columna"] != DBNull.Value  ){
                    return ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].Columna;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].Columna = value;
               }
	          }
        public bool IsColumnaNull {
             get {
                 return mParam==null || ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].IsColumnaNull();
             }
	        }
        public String Impuesto_Id {
            get {
                if(((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0]["Impuesto_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].Impuesto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].Impuesto_Id = value;
               }
	          }
        public bool IsImpuesto_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].IsImpuesto_IdNull();
             }
	        }
        public String DescripcionImpuestos {
            get {
                if(((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0]["DescripcionImpuestos"] != DBNull.Value  ){
                    return ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].DescripcionImpuestos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].DescripcionImpuestos = value;
               }
	          }
        public bool IsDescripcionImpuestosNull {
             get {
                 return mParam==null || ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].IsDescripcionImpuestosNull();
             }
	        }
        public String TipoRenglon {
            get {
                if(((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0]["TipoRenglon"] != DBNull.Value  ){
                    return ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].TipoRenglon;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].TipoRenglon = value;
               }
	          }
        public bool IsTipoRenglonNull {
             get {
                 return mParam==null || ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].IsTipoRenglonNull();
             }
	        }
        public String DescripcionTipoImpuesto {
            get {
                if(((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0]["DescripcionTipoImpuesto"] != DBNull.Value  ){
                    return ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].DescripcionTipoImpuesto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].DescripcionTipoImpuesto = value;
               }
	          }
        public bool IsDescripcionTipoImpuestoNull {
             get {
                 return mParam==null || ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].IsDescripcionTipoImpuestoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comLibrosImpuestosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comLibrosImpuestosDS );
     }
     public comLibrosImpuestosActionExchange() : base( "comLibrosImpuestos" ) {
     }

     public comLibrosImpuestosActionExchange(comLibrosImpuestosActionEnum.EnumcomLibrosImpuestosAction pAccion) : base(comLibrosImpuestosActionEnum.GetAccioncomLibrosImpuestosAction(pAccion)) {
     }

     public comLibrosImpuestosActionExchange(comLibrosImpuestosActionEnum.EnumcomLibrosImpuestosAction pAccion, ComprasCommon.comLibrosImpuestosDS pdsParam) : base(comLibrosImpuestosActionEnum.GetAccioncomLibrosImpuestosAction(pAccion), pdsParam) {
     }

     public comLibrosImpuestosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comLibrosImpuestosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comLibrosImpuestosDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comLibrosImpuestosDS)mParam;
	        }
     }
  }
}
