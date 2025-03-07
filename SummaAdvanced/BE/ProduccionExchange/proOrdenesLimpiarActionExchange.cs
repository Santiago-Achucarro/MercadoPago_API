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
    public class proOrdenesLimpiarActionExchange : Framework.Core.Exchange{

        public DateTime FechaHasta {
            get {
                if(((ProduccionCommon.proOrdenesLimpiarDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenesLimpiarDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenesLimpiarDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenesLimpiarDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String CtroProdDesde {
            get {
                if(((ProduccionCommon.proOrdenesLimpiarDS)mParam).Principal[0]["CtroProdDesde"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenesLimpiarDS)mParam).Principal[0].CtroProdDesde;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenesLimpiarDS)mParam).Principal[0].CtroProdDesde = value;
               }
	          }
        public bool IsCtroProdDesdeNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenesLimpiarDS)mParam).Principal[0].IsCtroProdDesdeNull();
             }
	        }
        public String CtroProdHasta {
            get {
                if(((ProduccionCommon.proOrdenesLimpiarDS)mParam).Principal[0]["CtroProdHasta"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenesLimpiarDS)mParam).Principal[0].CtroProdHasta;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenesLimpiarDS)mParam).Principal[0].CtroProdHasta = value;
               }
	          }
        public bool IsCtroProdHastaNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenesLimpiarDS)mParam).Principal[0].IsCtroProdHastaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ProduccionCommon.proOrdenesLimpiarDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ProduccionCommon.proOrdenesLimpiarDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ProduccionCommon.proOrdenesLimpiarDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ProduccionCommon.proOrdenesLimpiarDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ProduccionCommon.proOrdenesLimpiarDS );
     }
     public proOrdenesLimpiarActionExchange() : base( "proOrdenesLimpiar" ) {
     }

     public proOrdenesLimpiarActionExchange(proOrdenesLimpiarActionEnum.EnumproOrdenesLimpiarAction pAccion) : base(proOrdenesLimpiarActionEnum.GetAccionproOrdenesLimpiarAction(pAccion)) {
     }

     public proOrdenesLimpiarActionExchange(proOrdenesLimpiarActionEnum.EnumproOrdenesLimpiarAction pAccion, ProduccionCommon.proOrdenesLimpiarDS pdsParam) : base(proOrdenesLimpiarActionEnum.GetAccionproOrdenesLimpiarAction(pAccion), pdsParam) {
     }

     public proOrdenesLimpiarActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ProduccionCommon.proOrdenesLimpiarDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ProduccionCommon.proOrdenesLimpiarDS Param{
	        get{
			    InitParam();
			    return (ProduccionCommon.proOrdenesLimpiarDS)mParam;
	        }
     }
  }
}
