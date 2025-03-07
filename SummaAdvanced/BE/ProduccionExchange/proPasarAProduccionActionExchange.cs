using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ProduccionExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class proPasarAProduccionActionExchange : Framework.Core.Exchange{

        public DateTime FechaDesde {
            get {
                if(((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public DateTime FechaProduccion {
            get {
                if(((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0]["FechaProduccion"] != DBNull.Value  ){
                    return ((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0].FechaProduccion;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0].FechaProduccion = value;
               }
	          }
        public bool IsFechaProduccionNull {
             get {
                 return mParam==null || ((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0].IsFechaProduccionNull();
             }
	        }
        public String CentroProdDesde {
            get {
                if(((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0]["CentroProdDesde"] != DBNull.Value  ){
                    return ((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0].CentroProdDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0].CentroProdDesde = value;
               }
	          }
        public bool IsCentroProdDesdeNull {
             get {
                 return mParam==null || ((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0].IsCentroProdDesdeNull();
             }
	        }
        public String CentroProdHasta {
            get {
                if(((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0]["CentroProdHasta"] != DBNull.Value  ){
                    return ((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0].CentroProdHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0].CentroProdHasta = value;
               }
	          }
        public bool IsCentroProdHastaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0].IsCentroProdHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proPasarAProduccionDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proPasarAProduccionDS );
     }
     public proPasarAProduccionActionExchange() : base( "proPasarAProduccion" ) {
     }

     public proPasarAProduccionActionExchange(proPasarAProduccionActionEnum.EnumproPasarAProduccionAction pAccion) : base(proPasarAProduccionActionEnum.GetAccionproPasarAProduccionAction(pAccion)) {
     }

     public proPasarAProduccionActionExchange(proPasarAProduccionActionEnum.EnumproPasarAProduccionAction pAccion, ProduccionCommon.proPasarAProduccionDS pdsParam) : base(proPasarAProduccionActionEnum.GetAccionproPasarAProduccionAction(pAccion), pdsParam) {
     }

     public proPasarAProduccionActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proPasarAProduccionDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proPasarAProduccionDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proPasarAProduccionDS)mParam;
	        }
     }
  }
}
