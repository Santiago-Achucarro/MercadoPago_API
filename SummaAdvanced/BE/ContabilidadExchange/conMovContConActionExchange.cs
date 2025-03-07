using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ContabilidadExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class conMovContConActionExchange : Framework.Core.Exchange{

        public Int64 Asiento_id {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["Asiento_id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Asiento_id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Asiento_id = value;
               }
	          }
        public bool IsAsiento_idNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsAsiento_idNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public String LeyendaLibroMayor {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["LeyendaLibroMayor"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].LeyendaLibroMayor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].LeyendaLibroMayor = value;
               }
	          }
        public bool IsLeyendaLibroMayorNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsLeyendaLibroMayorNull();
             }
	        }
        public Decimal Debe {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["Debe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Debe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Debe = value;
               }
	          }
        public bool IsDebeNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsDebeNull();
             }
	        }
        public Decimal Haber {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["Haber"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Haber;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Haber = value;
               }
	          }
        public bool IsHaberNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsHaberNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public String ReferenciaT {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["ReferenciaT"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].ReferenciaT;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].ReferenciaT = value;
               }
	          }
        public bool IsReferenciaTNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsReferenciaTNull();
             }
	        }
        public String Referencia1 {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["Referencia1"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Referencia1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Referencia1 = value;
               }
	          }
        public bool IsReferencia1Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsReferencia1Null();
             }
	        }
        public String Referencia2 {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["Referencia2"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Referencia2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Referencia2 = value;
               }
	          }
        public bool IsReferencia2Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsReferencia2Null();
             }
	        }
        public String Referencia3 {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["Referencia3"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Referencia3;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Referencia3 = value;
               }
	          }
        public bool IsReferencia3Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsReferencia3Null();
             }
	        }
        public String Referencia4 {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["Referencia4"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Referencia4;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Referencia4 = value;
               }
	          }
        public bool IsReferencia4Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsReferencia4Null();
             }
	        }
        public String Referencia5 {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["Referencia5"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Referencia5;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Referencia5 = value;
               }
	          }
        public bool IsReferencia5Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsReferencia5Null();
             }
	        }
        public String Base_Id {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["Base_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Base_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Base_Id = value;
               }
	          }
        public bool IsBase_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsBase_IdNull();
             }
	        }
        public String DescripcionBaseDistri {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["DescripcionBaseDistri"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].DescripcionBaseDistri;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].DescripcionBaseDistri = value;
               }
	          }
        public bool IsDescripcionBaseDistriNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsDescripcionBaseDistriNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conMovContConDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conMovContConDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conMovContConDS );
     }
     public conMovContConActionExchange() : base( "conMovContCon" ) {
     }

     public conMovContConActionExchange(conMovContConActionEnum.EnumconMovContConAction pAccion) : base(conMovContConActionEnum.GetAccionconMovContConAction(pAccion)) {
     }

     public conMovContConActionExchange(conMovContConActionEnum.EnumconMovContConAction pAccion, ContabilidadCommon.conMovContConDS pdsParam) : base(conMovContConActionEnum.GetAccionconMovContConAction(pAccion), pdsParam) {
     }

     public conMovContConActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conMovContConDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conMovContConDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conMovContConDS)mParam;
	        }
     }
  }
}
