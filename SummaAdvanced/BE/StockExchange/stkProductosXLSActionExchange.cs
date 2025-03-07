using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace StockExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class stkProductosXLSActionExchange : Framework.Core.Exchange{

        public String Upload {
            get {
                if(((StockCommon.stkProductosXLSDS)mParam).Principal[0]["Upload"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosXLSDS)mParam).Principal[0].Upload;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosXLSDS)mParam).Principal[0].Upload = value;
               }
	          }
        public bool IsUploadNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosXLSDS)mParam).Principal[0].IsUploadNull();
             }
	        }
        public String ProductoDesde {
            get {
                if(((StockCommon.stkProductosXLSDS)mParam).Principal[0]["ProductoDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosXLSDS)mParam).Principal[0].ProductoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosXLSDS)mParam).Principal[0].ProductoDesde = value;
               }
	          }
        public bool IsProductoDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosXLSDS)mParam).Principal[0].IsProductoDesdeNull();
             }
	        }
        public String ProductoHasta {
            get {
                if(((StockCommon.stkProductosXLSDS)mParam).Principal[0]["ProductoHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosXLSDS)mParam).Principal[0].ProductoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosXLSDS)mParam).Principal[0].ProductoHasta = value;
               }
	          }
        public bool IsProductoHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosXLSDS)mParam).Principal[0].IsProductoHastaNull();
             }
	        }
        public String FamiliaDesde {
            get {
                if(((StockCommon.stkProductosXLSDS)mParam).Principal[0]["FamiliaDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosXLSDS)mParam).Principal[0].FamiliaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosXLSDS)mParam).Principal[0].FamiliaDesde = value;
               }
	          }
        public bool IsFamiliaDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosXLSDS)mParam).Principal[0].IsFamiliaDesdeNull();
             }
	        }
        public String FamiliaHasta {
            get {
                if(((StockCommon.stkProductosXLSDS)mParam).Principal[0]["FamiliaHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosXLSDS)mParam).Principal[0].FamiliaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosXLSDS)mParam).Principal[0].FamiliaHasta = value;
               }
	          }
        public bool IsFamiliaHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosXLSDS)mParam).Principal[0].IsFamiliaHastaNull();
             }
	        }
        public String GrupoDesde {
            get {
                if(((StockCommon.stkProductosXLSDS)mParam).Principal[0]["GrupoDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosXLSDS)mParam).Principal[0].GrupoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosXLSDS)mParam).Principal[0].GrupoDesde = value;
               }
	          }
        public bool IsGrupoDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosXLSDS)mParam).Principal[0].IsGrupoDesdeNull();
             }
	        }
        public String GrupoHasta {
            get {
                if(((StockCommon.stkProductosXLSDS)mParam).Principal[0]["GrupoHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosXLSDS)mParam).Principal[0].GrupoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosXLSDS)mParam).Principal[0].GrupoHasta = value;
               }
	          }
        public bool IsGrupoHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosXLSDS)mParam).Principal[0].IsGrupoHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkProductosXLSDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkProductosXLSDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkProductosXLSDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkProductosXLSDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkProductosXLSDS );
     }
     public stkProductosXLSActionExchange() : base( "stkProductosXLS" ) {
     }

     public stkProductosXLSActionExchange(stkProductosXLSActionEnum.EnumstkProductosXLSAction pAccion) : base(stkProductosXLSActionEnum.GetAccionstkProductosXLSAction(pAccion)) {
     }

     public stkProductosXLSActionExchange(stkProductosXLSActionEnum.EnumstkProductosXLSAction pAccion, StockCommon.stkProductosXLSDS pdsParam) : base(stkProductosXLSActionEnum.GetAccionstkProductosXLSAction(pAccion), pdsParam) {
     }

     public stkProductosXLSActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkProductosXLSDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkProductosXLSDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkProductosXLSDS)mParam;
	        }
     }
  }
}
