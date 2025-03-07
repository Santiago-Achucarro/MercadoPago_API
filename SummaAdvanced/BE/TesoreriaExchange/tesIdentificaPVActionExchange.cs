using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesoreriaExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesIdentificaPVActionExchange : Framework.Core.Exchange{

        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String TipoCartera {
            get {
                if(((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0]["TipoCartera"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0].TipoCartera;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0].TipoCartera = value;
               }
	          }
        public bool IsTipoCarteraNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0].IsTipoCarteraNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesIdentificaPVDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesIdentificaPVDS );
     }
     public tesIdentificaPVActionExchange() : base( "tesIdentificaPV" ) {
     }

     public tesIdentificaPVActionExchange(tesIdentificaPVActionEnum.EnumtesIdentificaPVAction pAccion) : base(tesIdentificaPVActionEnum.GetAcciontesIdentificaPVAction(pAccion)) {
     }

     public tesIdentificaPVActionExchange(tesIdentificaPVActionEnum.EnumtesIdentificaPVAction pAccion, TesoreriaCommon.tesIdentificaPVDS pdsParam) : base(tesIdentificaPVActionEnum.GetAcciontesIdentificaPVAction(pAccion), pdsParam) {
     }

     public tesIdentificaPVActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesIdentificaPVDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public tesIdentificaPVActionExchange(TesoreriaCommon.tesIdentificaPVDS pDS) : base() {
     this.Action = "";
     this.mParam = new TesoreriaCommon.tesIdentificaPVDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesIdentificaPVDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesIdentificaPVDS)mParam;
	        }
     }
  }
}
