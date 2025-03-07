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
    public class stkExistenciasXDepositoXLoteActionExchange : Framework.Core.Exchange{

        public String ProductoDesde {
            get {
                if(((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0]["ProductoDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].ProductoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].ProductoDesde = value;
               }
	          }
        public bool IsProductoDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].IsProductoDesdeNull();
             }
	        }
        public String ProductoHasta {
            get {
                if(((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0]["ProductoHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].ProductoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].ProductoHasta = value;
               }
	          }
        public bool IsProductoHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].IsProductoHastaNull();
             }
	        }
        public String DepositoDesde {
            get {
                if(((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0]["DepositoDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].DepositoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].DepositoDesde = value;
               }
	          }
        public bool IsDepositoDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].IsDepositoDesdeNull();
             }
	        }
        public String DepositoHasta {
            get {
                if(((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0]["DepositoHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].DepositoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].DepositoHasta = value;
               }
	          }
        public bool IsDepositoHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].IsDepositoHastaNull();
             }
	        }
        public String LoteDesde {
            get {
                if(((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0]["LoteDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].LoteDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].LoteDesde = value;
               }
	          }
        public bool IsLoteDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].IsLoteDesdeNull();
             }
	        }
        public String LoteHasta {
            get {
                if(((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0]["LoteHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].LoteHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].LoteHasta = value;
               }
	          }
        public bool IsLoteHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].IsLoteHastaNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public String FamiliaDesde {
            get {
                if(((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0]["FamiliaDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].FamiliaDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].FamiliaDesde = value;
               }
	          }
        public bool IsFamiliaDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].IsFamiliaDesdeNull();
             }
	        }
        public String FamiliaHasta {
            get {
                if(((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0]["FamiliaHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].FamiliaHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].FamiliaHasta = value;
               }
	          }
        public bool IsFamiliaHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].IsFamiliaHastaNull();
             }
	        }
        public String GrupoDesde {
            get {
                if(((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0]["GrupoDesde"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].GrupoDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].GrupoDesde = value;
               }
	          }
        public bool IsGrupoDesdeNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].IsGrupoDesdeNull();
             }
	        }
        public String GrupoHasta {
            get {
                if(((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0]["GrupoHasta"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].GrupoHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].GrupoHasta = value;
               }
	          }
        public bool IsGrupoHastaNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].IsGrupoHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkExistenciasXDepositoXLoteDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkExistenciasXDepositoXLoteDS );
     }
     public stkExistenciasXDepositoXLoteActionExchange() : base( "stkExistenciasXDepositoXLote" ) {
     }

     public stkExistenciasXDepositoXLoteActionExchange(stkExistenciasXDepositoXLoteActionEnum.EnumstkExistenciasXDepositoXLoteAction pAccion) : base(stkExistenciasXDepositoXLoteActionEnum.GetAccionstkExistenciasXDepositoXLoteAction(pAccion)) {
     }

     public stkExistenciasXDepositoXLoteActionExchange(stkExistenciasXDepositoXLoteActionEnum.EnumstkExistenciasXDepositoXLoteAction pAccion, StockCommon.stkExistenciasXDepositoXLoteDS pdsParam) : base(stkExistenciasXDepositoXLoteActionEnum.GetAccionstkExistenciasXDepositoXLoteAction(pAccion), pdsParam) {
     }

     public stkExistenciasXDepositoXLoteActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkExistenciasXDepositoXLoteDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkExistenciasXDepositoXLoteDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkExistenciasXDepositoXLoteDS)mParam;
	        }
     }
  }
}
