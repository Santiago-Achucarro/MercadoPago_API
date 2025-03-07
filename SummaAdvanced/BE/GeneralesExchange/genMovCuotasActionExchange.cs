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
    public class genMovCuotasActionExchange : Framework.Core.Exchange{

        public Int64 Asiento_Id {
            get {
                if(((GeneralesCommon.genMovCuotasDS)mParam).Principal[0]["Asiento_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovCuotasDS)mParam).Principal[0].Asiento_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovCuotasDS)mParam).Principal[0].Asiento_Id = value;
               }
	          }
        public bool IsAsiento_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovCuotasDS)mParam).Principal[0].IsAsiento_IdNull();
             }
	        }
        public Int16 CuotaNro {
            get {
                if(((GeneralesCommon.genMovCuotasDS)mParam).Principal[0]["CuotaNro"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovCuotasDS)mParam).Principal[0].CuotaNro;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovCuotasDS)mParam).Principal[0].CuotaNro = value;
               }
	          }
        public bool IsCuotaNroNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovCuotasDS)mParam).Principal[0].IsCuotaNroNull();
             }
	        }
        public DateTime FechaVencimiento {
            get {
                if(((GeneralesCommon.genMovCuotasDS)mParam).Principal[0]["FechaVencimiento"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovCuotasDS)mParam).Principal[0].FechaVencimiento;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovCuotasDS)mParam).Principal[0].FechaVencimiento = value;
               }
	          }
        public bool IsFechaVencimientoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovCuotasDS)mParam).Principal[0].IsFechaVencimientoNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((GeneralesCommon.genMovCuotasDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovCuotasDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovCuotasDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovCuotasDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Decimal Saldo {
            get {
                if(((GeneralesCommon.genMovCuotasDS)mParam).Principal[0]["Saldo"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovCuotasDS)mParam).Principal[0].Saldo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovCuotasDS)mParam).Principal[0].Saldo = value;
               }
	          }
        public bool IsSaldoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovCuotasDS)mParam).Principal[0].IsSaldoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genMovCuotasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMovCuotasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMovCuotasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMovCuotasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genMovCuotasDS );
     }
     public genMovCuotasActionExchange() : base( "genMovCuotas" ) {
     }

     public genMovCuotasActionExchange(genMovCuotasActionEnum.EnumgenMovCuotasAction pAccion) : base(genMovCuotasActionEnum.GetAcciongenMovCuotasAction(pAccion)) {
     }

     public genMovCuotasActionExchange(genMovCuotasActionEnum.EnumgenMovCuotasAction pAccion, GeneralesCommon.genMovCuotasDS pdsParam) : base(genMovCuotasActionEnum.GetAcciongenMovCuotasAction(pAccion), pdsParam) {
     }

     public genMovCuotasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genMovCuotasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genMovCuotasDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genMovCuotasDS)mParam;
	        }
     }
  }
}
