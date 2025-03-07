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
    public class tesCheqPropAnulActionExchange : Framework.Core.Exchange{

        public Int32 Empresa_Id {
            get {
                if(((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public Int32 Chequera_Id {
            get {
                if(((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0]["Chequera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].Chequera_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].Chequera_Id = value;
               }
	          }
        public bool IsChequera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].IsChequera_IdNull();
             }
	        }
        public Int32 numCheque {
            get {
                if(((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0]["numCheque"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].numCheque;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].numCheque = value;
               }
	          }
        public bool IsnumChequeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].IsnumChequeNull();
             }
	        }
        public DateTime Fecha_Anul {
            get {
                if(((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0]["Fecha_Anul"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].Fecha_Anul;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].Fecha_Anul = value;
               }
	          }
        public bool IsFecha_AnulNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].IsFecha_AnulNull();
             }
	        }
        public String Observaciones {
            get {
                if(((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0]["Observaciones"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].Observaciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].Observaciones = value;
               }
	          }
        public bool IsObservacionesNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].IsObservacionesNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public DateTime FechaOriginal {
            get {
                if(((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0]["FechaOriginal"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].FechaOriginal;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].FechaOriginal = value;
               }
	          }
        public bool IsFechaOriginalNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].IsFechaOriginalNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCheqPropAnulDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesCheqPropAnulDS );
     }
     public tesCheqPropAnulActionExchange() : base( "tesCheqPropAnul" ) {
     }

     public tesCheqPropAnulActionExchange(tesCheqPropAnulActionEnum.EnumtesCheqPropAnulAction pAccion) : base(tesCheqPropAnulActionEnum.GetAcciontesCheqPropAnulAction(pAccion)) {
     }

     public tesCheqPropAnulActionExchange(tesCheqPropAnulActionEnum.EnumtesCheqPropAnulAction pAccion, TesoreriaCommon.tesCheqPropAnulDS pdsParam) : base(tesCheqPropAnulActionEnum.GetAcciontesCheqPropAnulAction(pAccion), pdsParam) {
     }

     public tesCheqPropAnulActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesCheqPropAnulDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesCheqPropAnulDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesCheqPropAnulDS)mParam;
	        }
     }
  }
}
