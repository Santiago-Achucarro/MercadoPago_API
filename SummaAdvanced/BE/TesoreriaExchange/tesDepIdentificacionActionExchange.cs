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
    public class tesDepIdentificacionActionExchange : Framework.Core.Exchange{

        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean TimbraAhora {
            get {
                if(((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0]["TimbraAhora"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0].TimbraAhora;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0].TimbraAhora = value;
               }
	          }
        public bool IsTimbraAhoraNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0].IsTimbraAhoraNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesDepIdentificacionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesDepIdentificacionDS );
     }
     public tesDepIdentificacionActionExchange() : base( "tesDepIdentificacion" ) {
     }

     public tesDepIdentificacionActionExchange(tesDepIdentificacionActionEnum.EnumtesDepIdentificacionAction pAccion) : base(tesDepIdentificacionActionEnum.GetAcciontesDepIdentificacionAction(pAccion)) {
     }

     public tesDepIdentificacionActionExchange(tesDepIdentificacionActionEnum.EnumtesDepIdentificacionAction pAccion, TesoreriaCommon.tesDepIdentificacionDS pdsParam) : base(tesDepIdentificacionActionEnum.GetAcciontesDepIdentificacionAction(pAccion), pdsParam) {
     }

     public tesDepIdentificacionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesDepIdentificacionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public tesDepIdentificacionActionExchange(TesoreriaCommon.tesDepIdentificacionDS pDS) : base() {
     this.Action = "";
     this.mParam = new TesoreriaCommon.tesDepIdentificacionDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesDepIdentificacionDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesDepIdentificacionDS)mParam;
	        }
     }
  }
}
