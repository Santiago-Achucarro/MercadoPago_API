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
    public class venListasVersionActionExchange : Framework.Core.Exchange{

        public String ListaPrecio_Id {
            get {
                if(((VentasCommon.venListasVersionDS)mParam).Principal[0]["ListaPrecio_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venListasVersionDS)mParam).Principal[0].ListaPrecio_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasVersionDS)mParam).Principal[0].ListaPrecio_Id = value;
               }
	          }
        public bool IsListaPrecio_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venListasVersionDS)mParam).Principal[0].IsListaPrecio_IdNull();
             }
	        }
        public String DescripcionListasPrecios {
            get {
                if(((VentasCommon.venListasVersionDS)mParam).Principal[0]["DescripcionListasPrecios"] != DBNull.Value  ){
                    return ((VentasCommon.venListasVersionDS)mParam).Principal[0].DescripcionListasPrecios;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasVersionDS)mParam).Principal[0].DescripcionListasPrecios = value;
               }
	          }
        public bool IsDescripcionListasPreciosNull {
             get {
                 return mParam==null || ((VentasCommon.venListasVersionDS)mParam).Principal[0].IsDescripcionListasPreciosNull();
             }
	        }
        public Int32 Version {
            get {
                if(((VentasCommon.venListasVersionDS)mParam).Principal[0]["Version"] != DBNull.Value  ){
                    return ((VentasCommon.venListasVersionDS)mParam).Principal[0].Version;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasVersionDS)mParam).Principal[0].Version = value;
               }
	          }
        public bool IsVersionNull {
             get {
                 return mParam==null || ((VentasCommon.venListasVersionDS)mParam).Principal[0].IsVersionNull();
             }
	        }
        public DateTime VigenciaDesde {
            get {
                if(((VentasCommon.venListasVersionDS)mParam).Principal[0]["VigenciaDesde"] != DBNull.Value  ){
                    return ((VentasCommon.venListasVersionDS)mParam).Principal[0].VigenciaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasVersionDS)mParam).Principal[0].VigenciaDesde = value;
               }
	          }
        public bool IsVigenciaDesdeNull {
             get {
                 return mParam==null || ((VentasCommon.venListasVersionDS)mParam).Principal[0].IsVigenciaDesdeNull();
             }
	        }
        public DateTime VigenciaHasta {
            get {
                if(((VentasCommon.venListasVersionDS)mParam).Principal[0]["VigenciaHasta"] != DBNull.Value  ){
                    return ((VentasCommon.venListasVersionDS)mParam).Principal[0].VigenciaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasVersionDS)mParam).Principal[0].VigenciaHasta = value;
               }
	          }
        public bool IsVigenciaHastaNull {
             get {
                 return mParam==null || ((VentasCommon.venListasVersionDS)mParam).Principal[0].IsVigenciaHastaNull();
             }
	        }
        public Int32 Usuario_Id {
            get {
                if(((VentasCommon.venListasVersionDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venListasVersionDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasVersionDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venListasVersionDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venListasVersionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venListasVersionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venListasVersionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venListasVersionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venListasVersionDS );
     }
     public venListasVersionActionExchange() : base( "venListasVersion" ) {
     }

     public venListasVersionActionExchange(venListasVersionActionEnum.EnumvenListasVersionAction pAccion) : base(venListasVersionActionEnum.GetAccionvenListasVersionAction(pAccion)) {
     }

     public venListasVersionActionExchange(venListasVersionActionEnum.EnumvenListasVersionAction pAccion, VentasCommon.venListasVersionDS pdsParam) : base(venListasVersionActionEnum.GetAccionvenListasVersionAction(pAccion), pdsParam) {
     }

     public venListasVersionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venListasVersionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venListasVersionDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venListasVersionDS)mParam;
	        }
     }
  }
}
