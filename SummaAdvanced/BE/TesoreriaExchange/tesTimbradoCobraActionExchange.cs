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
    public class tesTimbradoCobraActionExchange : Framework.Core.Exchange{

        public DateTime FechaDesde {
            get {
                if(((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String ClienteDesde {
            get {
                if(((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0]["ClienteDesde"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].ClienteDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].ClienteDesde = value;
               }
	          }
        public bool IsClienteDesdeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].IsClienteDesdeNull();
             }
	        }
        public String DescripcionClienteDesde {
            get {
                if(((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0]["DescripcionClienteDesde"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].DescripcionClienteDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].DescripcionClienteDesde = value;
               }
	          }
        public bool IsDescripcionClienteDesdeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].IsDescripcionClienteDesdeNull();
             }
	        }
        public String ClienteHasta {
            get {
                if(((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0]["ClienteHasta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].ClienteHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].ClienteHasta = value;
               }
	          }
        public bool IsClienteHastaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].IsClienteHastaNull();
             }
	        }
        public String DescripcionClienteHasta {
            get {
                if(((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0]["DescripcionClienteHasta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].DescripcionClienteHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].DescripcionClienteHasta = value;
               }
	          }
        public bool IsDescripcionClienteHastaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].IsDescripcionClienteHastaNull();
             }
	        }
        public DateTime Fecha {
            get {
                if(((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0]["Fecha"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].Fecha;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].Fecha = value;
               }
	          }
        public bool IsFechaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].IsFechaNull();
             }
	        }
        public Boolean UnTimbrePorCob {
            get {
                if(((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0]["UnTimbrePorCob"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].UnTimbrePorCob;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].UnTimbrePorCob = value;
               }
	          }
        public bool IsUnTimbrePorCobNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].IsUnTimbrePorCobNull();
             }
	        }
        public String RazonCancelacionSAT {
            get {
                if(((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0]["RazonCancelacionSAT"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].RazonCancelacionSAT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].RazonCancelacionSAT = value;
               }
	          }
        public bool IsRazonCancelacionSATNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].IsRazonCancelacionSATNull();
             }
	        }
        public String DescripcionCancelacionSAT {
            get {
                if(((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0]["DescripcionCancelacionSAT"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].DescripcionCancelacionSAT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].DescripcionCancelacionSAT = value;
               }
	          }
        public bool IsDescripcionCancelacionSATNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].IsDescripcionCancelacionSATNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesTimbradoCobraDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesTimbradoCobraDS );
     }
     public tesTimbradoCobraActionExchange() : base( "tesTimbradoCobra" ) {
     }

     public tesTimbradoCobraActionExchange(tesTimbradoCobraActionEnum.EnumtesTimbradoCobraAction pAccion) : base(tesTimbradoCobraActionEnum.GetAcciontesTimbradoCobraAction(pAccion)) {
     }

     public tesTimbradoCobraActionExchange(tesTimbradoCobraActionEnum.EnumtesTimbradoCobraAction pAccion, TesoreriaCommon.tesTimbradoCobraDS pdsParam) : base(tesTimbradoCobraActionEnum.GetAcciontesTimbradoCobraAction(pAccion), pdsParam) {
     }

     public tesTimbradoCobraActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesTimbradoCobraDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public tesTimbradoCobraActionExchange(TesoreriaCommon.tesTimbradoCobraDS pDS) : base() {
     this.Action = "";
     this.mParam = new TesoreriaCommon.tesTimbradoCobraDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesTimbradoCobraDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesTimbradoCobraDS)mParam;
	        }
     }
  }
}
