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
    public class comProveedoresRetencionActionExchange : Framework.Core.Exchange{

        public Int64 Proveed_Id {
            get {
                if(((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0]["Proveed_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].Proveed_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].Proveed_Id = value;
               }
	          }
        public bool IsProveed_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].IsProveed_IdNull();
             }
	        }
        public String RazonSocial {
            get {
                if(((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0]["RazonSocial"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].RazonSocial;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].RazonSocial = value;
               }
	          }
        public bool IsRazonSocialNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].IsRazonSocialNull();
             }
	        }
        public String Cartera_Id {
            get {
                if(((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public String DescripcionIdRetProv {
            get {
                if(((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0]["DescripcionIdRetProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].DescripcionIdRetProv;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].DescripcionIdRetProv = value;
               }
	          }
        public bool IsDescripcionIdRetProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].IsDescripcionIdRetProvNull();
             }
	        }
        public Decimal Exencion {
            get {
                if(((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0]["Exencion"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].Exencion;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].Exencion = value;
               }
	          }
        public bool IsExencionNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].IsExencionNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comProveedoresRetencionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comProveedoresRetencionDS );
     }
     public comProveedoresRetencionActionExchange() : base( "comProveedoresRetencion" ) {
     }

     public comProveedoresRetencionActionExchange(comProveedoresRetencionActionEnum.EnumcomProveedoresRetencionAction pAccion) : base(comProveedoresRetencionActionEnum.GetAccioncomProveedoresRetencionAction(pAccion)) {
     }

     public comProveedoresRetencionActionExchange(comProveedoresRetencionActionEnum.EnumcomProveedoresRetencionAction pAccion, ComprasCommon.comProveedoresRetencionDS pdsParam) : base(comProveedoresRetencionActionEnum.GetAccioncomProveedoresRetencionAction(pAccion), pdsParam) {
     }

     public comProveedoresRetencionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comProveedoresRetencionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comProveedoresRetencionDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comProveedoresRetencionDS)mParam;
	        }
     }
  }
}
