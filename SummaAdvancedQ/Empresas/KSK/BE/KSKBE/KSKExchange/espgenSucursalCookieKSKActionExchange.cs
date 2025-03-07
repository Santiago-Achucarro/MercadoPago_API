using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace KSKExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class espgenSucursalCookieKSKActionExchange : Framework.Core.Exchange{

        public String Sucursal_Id {
            get {
                if(((KSKCommon.espgenSucursalCookieKSKDS)mParam).Principal[0]["Sucursal_Id"] != DBNull.Value  ){
                    return ((KSKCommon.espgenSucursalCookieKSKDS)mParam).Principal[0].Sucursal_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espgenSucursalCookieKSKDS)mParam).Principal[0].Sucursal_Id = value;
               }
	          }
        public bool IsSucursal_IdNull {
             get {
                 return mParam==null || ((KSKCommon.espgenSucursalCookieKSKDS)mParam).Principal[0].IsSucursal_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((KSKCommon.espgenSucursalCookieKSKDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((KSKCommon.espgenSucursalCookieKSKDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espgenSucursalCookieKSKDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((KSKCommon.espgenSucursalCookieKSKDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((KSKCommon.espgenSucursalCookieKSKDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((KSKCommon.espgenSucursalCookieKSKDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((KSKCommon.espgenSucursalCookieKSKDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((KSKCommon.espgenSucursalCookieKSKDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( KSKCommon.espgenSucursalCookieKSKDS );
     }
     public espgenSucursalCookieKSKActionExchange() : base( "espgenSucursalCookieKSK" ) {
     }

     public espgenSucursalCookieKSKActionExchange(espgenSucursalCookieKSKActionEnum.EnumespgenSucursalCookieKSKAction pAccion) : base(espgenSucursalCookieKSKActionEnum.GetAccionespgenSucursalCookieKSKAction(pAccion)) {
     }

     public espgenSucursalCookieKSKActionExchange(espgenSucursalCookieKSKActionEnum.EnumespgenSucursalCookieKSKAction pAccion, KSKCommon.espgenSucursalCookieKSKDS pdsParam) : base(espgenSucursalCookieKSKActionEnum.GetAccionespgenSucursalCookieKSKAction(pAccion), pdsParam) {
     }

     public espgenSucursalCookieKSKActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new KSKCommon.espgenSucursalCookieKSKDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public espgenSucursalCookieKSKActionExchange(KSKCommon.espgenSucursalCookieKSKDS pDS) : base() {
     this.Action = "";
     this.mParam = new KSKCommon.espgenSucursalCookieKSKDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public KSKCommon.espgenSucursalCookieKSKDS Param{
	        get{
			    InitParam();
			    return (KSKCommon.espgenSucursalCookieKSKDS)mParam;
	        }
     }
  }
}
