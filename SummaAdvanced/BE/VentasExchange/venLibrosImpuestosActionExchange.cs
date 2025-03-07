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
    public class venLibrosImpuestosActionExchange : Framework.Core.Exchange{

        public Int32 venLibros {
            get {
                if(((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0]["venLibros"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].venLibros;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].venLibros = value;
               }
	          }
        public bool IsvenLibrosNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].IsvenLibrosNull();
             }
	        }
        public Int32 Columna {
            get {
                if(((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0]["Columna"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].Columna;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].Columna = value;
               }
	          }
        public bool IsColumnaNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].IsColumnaNull();
             }
	        }
        public String TipoRenglon {
            get {
                if(((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0]["TipoRenglon"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].TipoRenglon;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].TipoRenglon = value;
               }
	          }
        public bool IsTipoRenglonNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].IsTipoRenglonNull();
             }
	        }
        public String Impuesto_Id {
            get {
                if(((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0]["Impuesto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].Impuesto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].Impuesto_Id = value;
               }
	          }
        public bool IsImpuesto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].IsImpuesto_IdNull();
             }
	        }
        public String DescripcionImpuestos {
            get {
                if(((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0]["DescripcionImpuestos"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].DescripcionImpuestos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].DescripcionImpuestos = value;
               }
	          }
        public bool IsDescripcionImpuestosNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].IsDescripcionImpuestosNull();
             }
	        }
        public String DescripcionTipoRenglon {
            get {
                if(((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0]["DescripcionTipoRenglon"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].DescripcionTipoRenglon;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].DescripcionTipoRenglon = value;
               }
	          }
        public bool IsDescripcionTipoRenglonNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].IsDescripcionTipoRenglonNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venLibrosImpuestosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venLibrosImpuestosDS );
     }
     public venLibrosImpuestosActionExchange() : base( "venLibrosImpuestos" ) {
     }

     public venLibrosImpuestosActionExchange(venLibrosImpuestosActionEnum.EnumvenLibrosImpuestosAction pAccion) : base(venLibrosImpuestosActionEnum.GetAccionvenLibrosImpuestosAction(pAccion)) {
     }

     public venLibrosImpuestosActionExchange(venLibrosImpuestosActionEnum.EnumvenLibrosImpuestosAction pAccion, VentasCommon.venLibrosImpuestosDS pdsParam) : base(venLibrosImpuestosActionEnum.GetAccionvenLibrosImpuestosAction(pAccion), pdsParam) {
     }

     public venLibrosImpuestosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venLibrosImpuestosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venLibrosImpuestosDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venLibrosImpuestosDS)mParam;
	        }
     }
  }
}
