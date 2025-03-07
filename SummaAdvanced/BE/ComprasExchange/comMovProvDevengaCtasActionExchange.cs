using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ComprasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class comMovProvDevengaCtasActionExchange : Framework.Core.Exchange{

        public Int64 comMovProv {
            get {
                if(((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0]["comMovProv"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].comMovProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].comMovProv = value;
               }
	          }
        public bool IscomMovProvNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].IscomMovProvNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Decimal Porcentaje {
            get {
                if(((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0]["Porcentaje"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].Porcentaje;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].Porcentaje = value;
               }
	          }
        public bool IsPorcentajeNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].IsPorcentajeNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ComprasCommon.comMovProvDevengaCtasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ComprasCommon.comMovProvDevengaCtasDS );
     }
     public comMovProvDevengaCtasActionExchange() : base( "comMovProvDevengaCtas" ) {
     }

     public comMovProvDevengaCtasActionExchange(comMovProvDevengaCtasActionEnum.EnumcomMovProvDevengaCtasAction pAccion) : base(comMovProvDevengaCtasActionEnum.GetAccioncomMovProvDevengaCtasAction(pAccion)) {
     }

     public comMovProvDevengaCtasActionExchange(comMovProvDevengaCtasActionEnum.EnumcomMovProvDevengaCtasAction pAccion, ComprasCommon.comMovProvDevengaCtasDS pdsParam) : base(comMovProvDevengaCtasActionEnum.GetAccioncomMovProvDevengaCtasAction(pAccion), pdsParam) {
     }

     public comMovProvDevengaCtasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ComprasCommon.comMovProvDevengaCtasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public comMovProvDevengaCtasActionExchange(ComprasCommon.comMovProvDevengaCtasDS pDS) : base() {
     this.Action = "";
     this.mParam = new ComprasCommon.comMovProvDevengaCtasDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ComprasCommon.comMovProvDevengaCtasDS Param{
	        get{
			    InitParam();
			    return (ComprasCommon.comMovProvDevengaCtasDS)mParam;
	        }
     }
  }
}
