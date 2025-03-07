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
    public class venListasPrecBoniRecActionExchange : Framework.Core.Exchange{

        public Int32 venListasPrecios {
            get {
                if(((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0]["venListasPrecios"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].venListasPrecios;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].venListasPrecios = value;
               }
	          }
        public bool IsvenListasPreciosNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].IsvenListasPreciosNull();
             }
	        }
        public String ListaPrecio_Id {
            get {
                if(((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0]["ListaPrecio_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].ListaPrecio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].ListaPrecio_Id = value;
               }
	          }
        public bool IsListaPrecio_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].IsListaPrecio_IdNull();
             }
	        }
        public Int16 NroBonifRecargo {
            get {
                if(((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0]["NroBonifRecargo"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].NroBonifRecargo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].NroBonifRecargo = value;
               }
	          }
        public bool IsNroBonifRecargoNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].IsNroBonifRecargoNull();
             }
	        }
        public String Nombre {
            get {
                if(((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0]["Nombre"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].Nombre;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].Nombre = value;
               }
	          }
        public bool IsNombreNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].IsNombreNull();
             }
	        }
        public String Formula {
            get {
                if(((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0]["Formula"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].Formula;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].Formula = value;
               }
	          }
        public bool IsFormulaNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].IsFormulaNull();
             }
	        }
        public Boolean UsaCtasProducto {
            get {
                if(((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0]["UsaCtasProducto"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].UsaCtasProducto;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].UsaCtasProducto = value;
               }
	          }
        public bool IsUsaCtasProductoNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].IsUsaCtasProductoNull();
             }
	        }
        public String CtaBonificacion {
            get {
                if(((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0]["CtaBonificacion"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].CtaBonificacion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].CtaBonificacion = value;
               }
	          }
        public bool IsCtaBonificacionNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].IsCtaBonificacionNull();
             }
	        }
        public String DescripcionCtaBonif {
            get {
                if(((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0]["DescripcionCtaBonif"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].DescripcionCtaBonif;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].DescripcionCtaBonif = value;
               }
	          }
        public bool IsDescripcionCtaBonifNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].IsDescripcionCtaBonifNull();
             }
	        }
        public String CtaRecargo {
            get {
                if(((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0]["CtaRecargo"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].CtaRecargo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].CtaRecargo = value;
               }
	          }
        public bool IsCtaRecargoNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].IsCtaRecargoNull();
             }
	        }
        public String DescripcionCtaRecargo {
            get {
                if(((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0]["DescripcionCtaRecargo"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].DescripcionCtaRecargo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].DescripcionCtaRecargo = value;
               }
	          }
        public bool IsDescripcionCtaRecargoNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].IsDescripcionCtaRecargoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venListasPrecBoniRecDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venListasPrecBoniRecDS );
     }
     public venListasPrecBoniRecActionExchange() : base( "venListasPrecBoniRec" ) {
     }

     public venListasPrecBoniRecActionExchange(venListasPrecBoniRecActionEnum.EnumvenListasPrecBoniRecAction pAccion) : base(venListasPrecBoniRecActionEnum.GetAccionvenListasPrecBoniRecAction(pAccion)) {
     }

     public venListasPrecBoniRecActionExchange(venListasPrecBoniRecActionEnum.EnumvenListasPrecBoniRecAction pAccion, VentasCommon.venListasPrecBoniRecDS pdsParam) : base(venListasPrecBoniRecActionEnum.GetAccionvenListasPrecBoniRecAction(pAccion), pdsParam) {
     }

     public venListasPrecBoniRecActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venListasPrecBoniRecDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venListasPrecBoniRecActionExchange(VentasCommon.venListasPrecBoniRecDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venListasPrecBoniRecDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venListasPrecBoniRecDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venListasPrecBoniRecDS)mParam;
	        }
     }
  }
}
