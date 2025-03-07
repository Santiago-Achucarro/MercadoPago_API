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
    public class comComprasPagadasActionExchange : Framework.Core.Exchange{

        public DateTime FechaDesde {
            get {
                if(((ComprasCommon.PagadasDSDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((ComprasCommon.PagadasDSDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.PagadasDSDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((ComprasCommon.PagadasDSDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ComprasCommon.PagadasDSDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ComprasCommon.PagadasDSDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.PagadasDSDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ComprasCommon.PagadasDSDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.PagadasDSDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.PagadasDSDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.PagadasDSDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.PagadasDSDS)mParam).Principal[0].IsExisteNull();
             }
	        }
        public String Text {
            get {
                if(((ComprasCommon.PagadasDSDS)mParam).Principal[0]["Text"] != DBNull.Value  ){
                    return ((ComprasCommon.PagadasDSDS)mParam).Principal[0].Text;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.PagadasDSDS)mParam).Principal[0].Text = value;
               }
	          }
        public bool IsTextNull {
             get {
                 return mParam==null || ((ComprasCommon.PagadasDSDS)mParam).Principal[0].IsTextNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.PagadasDSDS );
     }
     public comComprasPagadasActionExchange() : base( "comComprasPagadas" ) {
     }

     public comComprasPagadasActionExchange(comComprasPagadasActionEnum.EnumcomComprasPagadasAction pAccion) : base(comComprasPagadasActionEnum.GetAccioncomComprasPagadasAction(pAccion)) {
     }

     public comComprasPagadasActionExchange(comComprasPagadasActionEnum.EnumcomComprasPagadasAction pAccion, ComprasCommon.PagadasDSDS pdsParam) : base(comComprasPagadasActionEnum.GetAccioncomComprasPagadasAction(pAccion), pdsParam) {
     }

     public comComprasPagadasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.PagadasDSDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.PagadasDSDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.PagadasDSDS)mParam;
	        }
     }
  }
}
