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
    public class stkCataProductosActionExchange : Framework.Core.Exchange{

        public String ProductoDesde {
            get {
                if(((StockCommon.stkCataProductosDS)mParam).Principal[0]["ProductoDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkCataProductosDS)mParam).Principal[0].ProductoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCataProductosDS)mParam).Principal[0].ProductoDesde = value;
               }
	          }
        public bool IsProductoDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkCataProductosDS)mParam).Principal[0].IsProductoDesdeNull();
             }
	        }
        public String ProductoHasta {
            get {
                if(((StockCommon.stkCataProductosDS)mParam).Principal[0]["ProductoHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkCataProductosDS)mParam).Principal[0].ProductoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCataProductosDS)mParam).Principal[0].ProductoHasta = value;
               }
	          }
        public bool IsProductoHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkCataProductosDS)mParam).Principal[0].IsProductoHastaNull();
             }
	        }
        public String FamiliaDesde {
            get {
                if(((StockCommon.stkCataProductosDS)mParam).Principal[0]["FamiliaDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkCataProductosDS)mParam).Principal[0].FamiliaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCataProductosDS)mParam).Principal[0].FamiliaDesde = value;
               }
	          }
        public bool IsFamiliaDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkCataProductosDS)mParam).Principal[0].IsFamiliaDesdeNull();
             }
	        }
        public String FamiliaHasta {
            get {
                if(((StockCommon.stkCataProductosDS)mParam).Principal[0]["FamiliaHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkCataProductosDS)mParam).Principal[0].FamiliaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCataProductosDS)mParam).Principal[0].FamiliaHasta = value;
               }
	          }
        public bool IsFamiliaHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkCataProductosDS)mParam).Principal[0].IsFamiliaHastaNull();
             }
	        }
        public String GrupoDesde {
            get {
                if(((StockCommon.stkCataProductosDS)mParam).Principal[0]["GrupoDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkCataProductosDS)mParam).Principal[0].GrupoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCataProductosDS)mParam).Principal[0].GrupoDesde = value;
               }
	          }
        public bool IsGrupoDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkCataProductosDS)mParam).Principal[0].IsGrupoDesdeNull();
             }
	        }
        public String GrupoHasta {
            get {
                if(((StockCommon.stkCataProductosDS)mParam).Principal[0]["GrupoHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkCataProductosDS)mParam).Principal[0].GrupoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCataProductosDS)mParam).Principal[0].GrupoHasta = value;
               }
	          }
        public bool IsGrupoHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkCataProductosDS)mParam).Principal[0].IsGrupoHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkCataProductosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkCataProductosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkCataProductosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkCataProductosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkCataProductosDS );
     }
     public stkCataProductosActionExchange() : base( "stkCataProductos" ) {
     }

     public stkCataProductosActionExchange(stkCataProductosActionEnum.EnumstkCataProductosAction pAccion) : base(stkCataProductosActionEnum.GetAccionstkCataProductosAction(pAccion)) {
     }

     public stkCataProductosActionExchange(stkCataProductosActionEnum.EnumstkCataProductosAction pAccion, StockCommon.stkCataProductosDS pdsParam) : base(stkCataProductosActionEnum.GetAccionstkCataProductosAction(pAccion), pdsParam) {
     }

     public stkCataProductosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkCataProductosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkCataProductosDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkCataProductosDS)mParam;
	        }
     }
  }
}
