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
    public class venImportarListaXlsActionExchange : Framework.Core.Exchange{

        public String ListaPrecio_Id {
            get {
                if(((VentasCommon.venImportarListaXlsDS)mParam).Principal[0]["ListaPrecio_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venImportarListaXlsDS)mParam).Principal[0].ListaPrecio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImportarListaXlsDS)mParam).Principal[0].ListaPrecio_Id = value;
               }
	          }
        public bool IsListaPrecio_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venImportarListaXlsDS)mParam).Principal[0].IsListaPrecio_IdNull();
             }
	        }
        public String DescripcionListaPrecio {
            get {
                if(((VentasCommon.venImportarListaXlsDS)mParam).Principal[0]["DescripcionListaPrecio"] != DBNull.Value  ){
                    return ((VentasCommon.venImportarListaXlsDS)mParam).Principal[0].DescripcionListaPrecio;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImportarListaXlsDS)mParam).Principal[0].DescripcionListaPrecio = value;
               }
	          }
        public bool IsDescripcionListaPrecioNull {
             get {
                 return mParam==null || ((VentasCommon.venImportarListaXlsDS)mParam).Principal[0].IsDescripcionListaPrecioNull();
             }
	        }
        public Int32 Version {
            get {
                if(((VentasCommon.venImportarListaXlsDS)mParam).Principal[0]["Version"] != DBNull.Value  ){
                    return ((VentasCommon.venImportarListaXlsDS)mParam).Principal[0].Version;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImportarListaXlsDS)mParam).Principal[0].Version = value;
               }
	          }
        public bool IsVersionNull {
             get {
                 return mParam==null || ((VentasCommon.venImportarListaXlsDS)mParam).Principal[0].IsVersionNull();
             }
	        }
        public String ArchivoXls {
            get {
                if(((VentasCommon.venImportarListaXlsDS)mParam).Principal[0]["ArchivoXls"] != DBNull.Value  ){
                    return ((VentasCommon.venImportarListaXlsDS)mParam).Principal[0].ArchivoXls;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImportarListaXlsDS)mParam).Principal[0].ArchivoXls = value;
               }
	          }
        public bool IsArchivoXlsNull {
             get {
                 return mParam==null || ((VentasCommon.venImportarListaXlsDS)mParam).Principal[0].IsArchivoXlsNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venImportarListaXlsDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venImportarListaXlsDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImportarListaXlsDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venImportarListaXlsDS)mParam).Principal[0].IsExisteNull();
             }
	        }
        public Boolean Borra {
            get {
                if(((VentasCommon.venImportarListaXlsDS)mParam).Principal[0]["Borra"] != DBNull.Value  ){
                    return ((VentasCommon.venImportarListaXlsDS)mParam).Principal[0].Borra;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venImportarListaXlsDS)mParam).Principal[0].Borra = value;
               }
	          }
        public bool IsBorraNull {
             get {
                 return mParam==null || ((VentasCommon.venImportarListaXlsDS)mParam).Principal[0].IsBorraNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venImportarListaXlsDS );
     }
     public venImportarListaXlsActionExchange() : base( "venImportarListaXls" ) {
     }

     public venImportarListaXlsActionExchange(venImportarListaXlsActionEnum.EnumvenImportarListaXlsAction pAccion) : base(venImportarListaXlsActionEnum.GetAccionvenImportarListaXlsAction(pAccion)) {
     }

     public venImportarListaXlsActionExchange(venImportarListaXlsActionEnum.EnumvenImportarListaXlsAction pAccion, VentasCommon.venImportarListaXlsDS pdsParam) : base(venImportarListaXlsActionEnum.GetAccionvenImportarListaXlsAction(pAccion), pdsParam) {
     }

     public venImportarListaXlsActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venImportarListaXlsDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venImportarListaXlsDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venImportarListaXlsDS)mParam;
	        }
     }
  }
}
