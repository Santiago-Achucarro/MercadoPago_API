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
    public class tesAISaldosActionExchange : Framework.Core.Exchange{

        public String Cartera_Id {
            get {
                if(((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0]["Cartera_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].Cartera_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].Cartera_Id = value;
               }
	          }
        public bool IsCartera_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].IsCartera_IdNull();
             }
	        }
        public String DescripcionIdentifica {
            get {
                if(((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0]["DescripcionIdentifica"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].DescripcionIdentifica;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].DescripcionIdentifica = value;
               }
	          }
        public bool IsDescripcionIdentificaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].IsDescripcionIdentificaNull();
             }
	        }
        public Int32 Empresa_Id {
            get {
                if(((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0]["Empresa_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].Empresa_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].Empresa_Id = value;
               }
	          }
        public bool IsEmpresa_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].IsEmpresa_IdNull();
             }
	        }
        public Decimal SaldoInicial {
            get {
                if(((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0]["SaldoInicial"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].SaldoInicial;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].SaldoInicial = value;
               }
	          }
        public bool IsSaldoInicialNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].IsSaldoInicialNull();
             }
	        }
        public String Moneda_Id {
            get {
                if(((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0]["Moneda_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].Moneda_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].Moneda_Id = value;
               }
	          }
        public bool IsMoneda_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].IsMoneda_IdNull();
             }
	        }
        public String DescripcionMoneda {
            get {
                if(((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0]["DescripcionMoneda"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].DescripcionMoneda;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].DescripcionMoneda = value;
               }
	          }
        public bool IsDescripcionMonedaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].IsDescripcionMonedaNull();
             }
	        }
        public Decimal Cambio {
            get {
                if(((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0]["Cambio"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].Cambio;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].Cambio = value;
               }
	          }
        public bool IsCambioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].IsCambioNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public DateTime FechaRegistro {
            get {
                if(((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public Boolean Confirmado {
            get {
                if(((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0]["Confirmado"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].Confirmado;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].Confirmado = value;
               }
	          }
        public bool IsConfirmadoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].IsConfirmadoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesAISaldosDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesAISaldosDS );
     }
     public tesAISaldosActionExchange() : base( "tesAISaldos" ) {
     }

     public tesAISaldosActionExchange(tesAISaldosActionEnum.EnumtesAISaldosAction pAccion) : base(tesAISaldosActionEnum.GetAcciontesAISaldosAction(pAccion)) {
     }

     public tesAISaldosActionExchange(tesAISaldosActionEnum.EnumtesAISaldosAction pAccion, TesoreriaCommon.tesAISaldosDS pdsParam) : base(tesAISaldosActionEnum.GetAcciontesAISaldosAction(pAccion), pdsParam) {
     }

     public tesAISaldosActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesAISaldosDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesAISaldosDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesAISaldosDS)mParam;
	        }
     }
  }
}
