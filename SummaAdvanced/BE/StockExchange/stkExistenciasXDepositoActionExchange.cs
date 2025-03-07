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
    public class stkExistenciasXDepositoActionExchange : Framework.Core.Exchange{

        public String ProductoDesde {
            get {
                if(((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0]["ProductoDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].ProductoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].ProductoDesde = value;
               }
	          }
        public bool IsProductoDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].IsProductoDesdeNull();
             }
	        }
        public String ProductoHasta {
            get {
                if(((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0]["ProductoHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].ProductoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].ProductoHasta = value;
               }
	          }
        public bool IsProductoHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].IsProductoHastaNull();
             }
	        }
        public String DepositoDesde {
            get {
                if(((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0]["DepositoDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].DepositoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].DepositoDesde = value;
               }
	          }
        public bool IsDepositoDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].IsDepositoDesdeNull();
             }
	        }
        public String DepositoHasta {
            get {
                if(((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0]["DepositoHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].DepositoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].DepositoHasta = value;
               }
	          }
        public bool IsDepositoHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].IsDepositoHastaNull();
             }
	        }
        public String FamiliaDesde {
            get {
                if(((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0]["FamiliaDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].FamiliaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].FamiliaDesde = value;
               }
	          }
        public bool IsFamiliaDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].IsFamiliaDesdeNull();
             }
	        }
        public String FamiliaHasta {
            get {
                if(((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0]["FamiliaHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].FamiliaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].FamiliaHasta = value;
               }
	          }
        public bool IsFamiliaHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].IsFamiliaHastaNull();
             }
	        }
        public String GrupoDesde {
            get {
                if(((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0]["GrupoDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].GrupoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].GrupoDesde = value;
               }
	          }
        public bool IsGrupoDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].IsGrupoDesdeNull();
             }
	        }
        public String GrupoHasta {
            get {
                if(((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0]["GrupoHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].GrupoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].GrupoHasta = value;
               }
	          }
        public bool IsGrupoHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].IsGrupoHastaNull();
             }
	        }
        public String TipoDesde {
            get {
                if(((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0]["TipoDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].TipoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].TipoDesde = value;
               }
	          }
        public bool IsTipoDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].IsTipoDesdeNull();
             }
	        }
        public String TipoHasta {
            get {
                if(((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0]["TipoHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].TipoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].TipoHasta = value;
               }
	          }
        public bool IsTipoHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].IsTipoHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkExistenciasXDepositoDS );
     }
     public stkExistenciasXDepositoActionExchange() : base( "stkExistenciasXDeposito" ) {
     }

     public stkExistenciasXDepositoActionExchange(stkExistenciasXDepositoActionEnum.EnumstkExistenciasXDepositoAction pAccion) : base(stkExistenciasXDepositoActionEnum.GetAccionstkExistenciasXDepositoAction(pAccion)) {
     }

     public stkExistenciasXDepositoActionExchange(stkExistenciasXDepositoActionEnum.EnumstkExistenciasXDepositoAction pAccion, StockCommon.stkExistenciasXDepositoDS pdsParam) : base(stkExistenciasXDepositoActionEnum.GetAccionstkExistenciasXDepositoAction(pAccion), pdsParam) {
     }

     public stkExistenciasXDepositoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkExistenciasXDepositoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkExistenciasXDepositoDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkExistenciasXDepositoDS)mParam;
	        }
     }
  }
}
