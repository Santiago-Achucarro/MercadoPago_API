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
    public class tesBPlinkActionExchange : Framework.Core.Exchange{

        public Int64 tesMovimientos {
            get {
                if(((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public Int32 conRenglon {
            get {
                if(((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0]["conRenglon"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].conRenglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].conRenglon = value;
               }
	          }
        public bool IsconRenglonNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].IsconRenglonNull();
             }
	        }
        public String Estado_Id {
            get {
                if(((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0]["Estado_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].Estado_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].Estado_Id = value;
               }
	          }
        public bool IsEstado_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].IsEstado_IdNull();
             }
	        }
        public String DescripcionCheqPropEstado {
            get {
                if(((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0]["DescripcionCheqPropEstado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].DescripcionCheqPropEstado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].DescripcionCheqPropEstado = value;
               }
	          }
        public bool IsDescripcionCheqPropEstadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].IsDescripcionCheqPropEstadoNull();
             }
	        }
        public Int16 Secuencia {
            get {
                if(((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0]["Secuencia"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].Secuencia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].Secuencia = value;
               }
	          }
        public bool IsSecuenciaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].IsSecuenciaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public Int32 Chequera_Id {
            get {
                if(((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0]["Chequera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].Chequera_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].Chequera_Id = value;
               }
	          }
        public bool IsChequera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].IsChequera_IdNull();
             }
	        }
        public Int32 numCheque {
            get {
                if(((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0]["numCheque"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].numCheque;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].numCheque = value;
               }
	          }
        public bool IsnumChequeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].IsnumChequeNull();
             }
	        }
        public Int32 tesCheqProp {
            get {
                if(((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0]["tesCheqProp"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].tesCheqProp;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].tesCheqProp = value;
               }
	          }
        public bool IstesCheqPropNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].IstesCheqPropNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesBPlinkDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesBPlinkDS );
     }
     public tesBPlinkActionExchange() : base( "tesBPlink" ) {
     }

     public tesBPlinkActionExchange(tesBPlinkActionEnum.EnumtesBPlinkAction pAccion) : base(tesBPlinkActionEnum.GetAcciontesBPlinkAction(pAccion)) {
     }

     public tesBPlinkActionExchange(tesBPlinkActionEnum.EnumtesBPlinkAction pAccion, TesoreriaCommon.tesBPlinkDS pdsParam) : base(tesBPlinkActionEnum.GetAcciontesBPlinkAction(pAccion), pdsParam) {
     }

     public tesBPlinkActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesBPlinkDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesBPlinkDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesBPlinkDS)mParam;
	        }
     }
  }
}
