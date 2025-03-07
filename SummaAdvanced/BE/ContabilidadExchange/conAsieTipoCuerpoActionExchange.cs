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
    public class conAsieTipoCuerpoActionExchange : Framework.Core.Exchange{

        public Int32 AsiTipo_Id {
            get {
                if(((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0]["AsiTipo_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].AsiTipo_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].AsiTipo_Id = value;
               }
	          }
        public bool IsAsiTipo_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].IsAsiTipo_IdNull();
             }
	        }
        public Int16 Renglon {
            get {
                if(((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public String LeyendaLibroMayor {
            get {
                if(((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0]["LeyendaLibroMayor"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].LeyendaLibroMayor;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].LeyendaLibroMayor = value;
               }
	          }
        public bool IsLeyendaLibroMayorNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].IsLeyendaLibroMayorNull();
             }
	        }
        public Decimal Haber {
            get {
                if(((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0]["Haber"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].Haber;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].Haber = value;
               }
	          }
        public bool IsHaberNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].IsHaberNull();
             }
	        }
        public Decimal Debe {
            get {
                if(((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0]["Debe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].Debe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].Debe = value;
               }
	          }
        public bool IsDebeNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].IsDebeNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAsieTipoCuerpoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conAsieTipoCuerpoDS );
     }
     public conAsieTipoCuerpoActionExchange() : base( "conAsieTipoCuerpo" ) {
     }

     public conAsieTipoCuerpoActionExchange(conAsieTipoCuerpoActionEnum.EnumconAsieTipoCuerpoAction pAccion) : base(conAsieTipoCuerpoActionEnum.GetAccionconAsieTipoCuerpoAction(pAccion)) {
     }

     public conAsieTipoCuerpoActionExchange(conAsieTipoCuerpoActionEnum.EnumconAsieTipoCuerpoAction pAccion, ContabilidadCommon.conAsieTipoCuerpoDS pdsParam) : base(conAsieTipoCuerpoActionEnum.GetAccionconAsieTipoCuerpoAction(pAccion), pdsParam) {
     }

     public conAsieTipoCuerpoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conAsieTipoCuerpoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conAsieTipoCuerpoDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conAsieTipoCuerpoDS)mParam;
	        }
     }
  }
}
