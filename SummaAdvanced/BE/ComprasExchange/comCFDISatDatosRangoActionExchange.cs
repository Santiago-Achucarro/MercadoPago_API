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
    public class comCFDISatDatosRangoActionExchange : Framework.Core.Exchange{

        public DateTime FechaDesde {
            get {
                if(((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String RFCDesde {
            get {
                if(((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0]["RFCDesde"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0].RFCDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0].RFCDesde = value;
               }
	          }
        public bool IsRFCDesdeNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0].IsRFCDesdeNull();
             }
	        }
        public String RFCHasta {
            get {
                if(((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0]["RFCHasta"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0].RFCHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0].RFCHasta = value;
               }
	          }
        public bool IsRFCHastaNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0].IsRFCHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comCFDISatDatosRangoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comCFDISatDatosRangoDS );
     }
     public comCFDISatDatosRangoActionExchange() : base( "comCFDISatDatosRango" ) {
     }

     public comCFDISatDatosRangoActionExchange(comCFDISatDatosRangoActionEnum.EnumcomCFDISatDatosRangoAction pAccion) : base(comCFDISatDatosRangoActionEnum.GetAccioncomCFDISatDatosRangoAction(pAccion)) {
     }

     public comCFDISatDatosRangoActionExchange(comCFDISatDatosRangoActionEnum.EnumcomCFDISatDatosRangoAction pAccion, ComprasCommon.comCFDISatDatosRangoDS pdsParam) : base(comCFDISatDatosRangoActionEnum.GetAccioncomCFDISatDatosRangoAction(pAccion), pdsParam) {
     }

     public comCFDISatDatosRangoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comCFDISatDatosRangoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public comCFDISatDatosRangoActionExchange(ComprasCommon.comCFDISatDatosRangoDS pDS) : base() {
     this.Action = "";
     this.mParam = new ComprasCommon.comCFDISatDatosRangoDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comCFDISatDatosRangoDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comCFDISatDatosRangoDS)mParam;
	        }
     }
  }
}
