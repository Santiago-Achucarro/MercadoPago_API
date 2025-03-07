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
    public class comHabilitarPagosMasivosActionExchange : Framework.Core.Exchange{

        public String ProveedorDesde {
            get {
                if(((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0]["ProveedorDesde"] != DBNull.Value  ){
                    return ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].ProveedorDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].ProveedorDesde = value;
               }
	          }
        public bool IsProveedorDesdeNull {
             get {
                 return mParam==null || ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].IsProveedorDesdeNull();
             }
	        }
        public String ProveedorHasta {
            get {
                if(((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0]["ProveedorHasta"] != DBNull.Value  ){
                    return ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].ProveedorHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].ProveedorHasta = value;
               }
	          }
        public bool IsProveedorHastaNull {
             get {
                 return mParam==null || ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].IsProveedorHastaNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Decimal Total {
            get {
                if(((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0]["Total"] != DBNull.Value  ){
                    return ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].Total;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].Total = value;
               }
	          }
        public bool IsTotalNull {
             get {
                 return mParam==null || ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].IsTotalNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comHabilitarPagosMasivosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comHabilitarPagosMasivosDS );
     }
     public comHabilitarPagosMasivosActionExchange() : base( "comHabilitarPagosMasivos" ) {
     }

     public comHabilitarPagosMasivosActionExchange(comHabilitarPagosMasivosActionEnum.EnumcomHabilitarPagosMasivosAction pAccion) : base(comHabilitarPagosMasivosActionEnum.GetAccioncomHabilitarPagosMasivosAction(pAccion)) {
     }

     public comHabilitarPagosMasivosActionExchange(comHabilitarPagosMasivosActionEnum.EnumcomHabilitarPagosMasivosAction pAccion, ComprasCommon.comHabilitarPagosMasivosDS pdsParam) : base(comHabilitarPagosMasivosActionEnum.GetAccioncomHabilitarPagosMasivosAction(pAccion), pdsParam) {
     }

     public comHabilitarPagosMasivosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comHabilitarPagosMasivosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comHabilitarPagosMasivosDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comHabilitarPagosMasivosDS)mParam;
	        }
     }
  }
}
