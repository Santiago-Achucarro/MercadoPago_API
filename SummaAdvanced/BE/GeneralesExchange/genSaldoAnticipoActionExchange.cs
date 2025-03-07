using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genSaldoAnticipoActionExchange : Framework.Core.Exchange{

        public Int64 Asiento_Id {
            get {
                if(((GeneralesCommon.genSaldoAnticipoDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSaldoAnticipoDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSaldoAnticipoDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSaldoAnticipoDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((GeneralesCommon.genSaldoAnticipoDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSaldoAnticipoDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSaldoAnticipoDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSaldoAnticipoDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((GeneralesCommon.genSaldoAnticipoDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSaldoAnticipoDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSaldoAnticipoDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSaldoAnticipoDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genSaldoAnticipoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genSaldoAnticipoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genSaldoAnticipoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genSaldoAnticipoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genSaldoAnticipoDS );
     }
     public genSaldoAnticipoActionExchange() : base( "genSaldoAnticipo" ) {
     }

     public genSaldoAnticipoActionExchange(genSaldoAnticipoActionEnum.EnumgenSaldoAnticipoAction pAccion) : base(genSaldoAnticipoActionEnum.GetAcciongenSaldoAnticipoAction(pAccion)) {
     }

     public genSaldoAnticipoActionExchange(genSaldoAnticipoActionEnum.EnumgenSaldoAnticipoAction pAccion, GeneralesCommon.genSaldoAnticipoDS pdsParam) : base(genSaldoAnticipoActionEnum.GetAcciongenSaldoAnticipoAction(pAccion), pdsParam) {
     }

     public genSaldoAnticipoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genSaldoAnticipoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genSaldoAnticipoDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genSaldoAnticipoDS)mParam;
	        }
     }
  }
}
