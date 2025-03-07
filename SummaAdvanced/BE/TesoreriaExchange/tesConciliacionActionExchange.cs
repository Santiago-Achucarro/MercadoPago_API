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
    public class tesConciliacionActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String Cartera_id {
            get {
                if(((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0]["Cartera_id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].Cartera_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].Cartera_id = value;
               }
	          }
        public bool IsCartera_idNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].IsCartera_idNull();
             }
	        }
        public String Descripcion {
            get {
                if(((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 NumeroConc {
            get {
                if(((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0]["NumeroConc"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].NumeroConc;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].NumeroConc = value;
               }
	          }
        public bool IsNumeroConcNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].IsNumeroConcNull();
             }
	        }
        public String ArchivoXls {
            get {
                if(((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0]["ArchivoXls"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].ArchivoXls;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].ArchivoXls = value;
               }
	          }
        public bool IsArchivoXlsNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].IsArchivoXlsNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesConciliacionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesConciliacionDS );
     }
     public tesConciliacionActionExchange() : base( "tesConciliacion" ) {
     }

     public tesConciliacionActionExchange(tesConciliacionActionEnum.EnumtesConciliacionAction pAccion) : base(tesConciliacionActionEnum.GetAcciontesConciliacionAction(pAccion)) {
     }

     public tesConciliacionActionExchange(tesConciliacionActionEnum.EnumtesConciliacionAction pAccion, TesoreriaCommon.tesConciliacionDS pdsParam) : base(tesConciliacionActionEnum.GetAcciontesConciliacionAction(pAccion), pdsParam) {
     }

     public tesConciliacionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesConciliacionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesConciliacionDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesConciliacionDS)mParam;
	        }
     }
  }
}
