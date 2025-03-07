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
    public class tesCTlinkActionExchange : Framework.Core.Exchange{

        public Int64 tesMovimientos {
            get {
                if(((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public Int32 conRenglon {
            get {
                if(((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0]["conRenglon"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].conRenglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].conRenglon = value;
               }
	          }
        public bool IsconRenglonNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].IsconRenglonNull();
             }
	        }
        public String Estado_Id {
            get {
                if(((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0]["Estado_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].Estado_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].Estado_Id = value;
               }
	          }
        public bool IsEstado_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].IsEstado_IdNull();
             }
	        }
        public String DescripcionCheqTerEstado {
            get {
                if(((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0]["DescripcionCheqTerEstado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].DescripcionCheqTerEstado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].DescripcionCheqTerEstado = value;
               }
	          }
        public bool IsDescripcionCheqTerEstadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].IsDescripcionCheqTerEstadoNull();
             }
	        }
        public Int16 Secuencia {
            get {
                if(((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0]["Secuencia"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].Secuencia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].Secuencia = value;
               }
	          }
        public bool IsSecuenciaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].IsSecuenciaNull();
             }
	        }
        public Int32 tesCheqTerceros {
            get {
                if(((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0]["tesCheqTerceros"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].tesCheqTerceros;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].tesCheqTerceros = value;
               }
	          }
        public bool IstesCheqTercerosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].IstesCheqTercerosNull();
             }
	        }
        public Int32 numCheque {
            get {
                if(((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0]["numCheque"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].numCheque;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].numCheque = value;
               }
	          }
        public bool IsnumChequeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].IsnumChequeNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesCTlinkDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesCTlinkDS );
     }
     public tesCTlinkActionExchange() : base( "tesCTlink" ) {
     }

     public tesCTlinkActionExchange(tesCTlinkActionEnum.EnumtesCTlinkAction pAccion) : base(tesCTlinkActionEnum.GetAcciontesCTlinkAction(pAccion)) {
     }

     public tesCTlinkActionExchange(tesCTlinkActionEnum.EnumtesCTlinkAction pAccion, TesoreriaCommon.tesCTlinkDS pdsParam) : base(tesCTlinkActionEnum.GetAcciontesCTlinkAction(pAccion), pdsParam) {
     }

     public tesCTlinkActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesCTlinkDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesCTlinkDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesCTlinkDS)mParam;
	        }
     }
  }
}
