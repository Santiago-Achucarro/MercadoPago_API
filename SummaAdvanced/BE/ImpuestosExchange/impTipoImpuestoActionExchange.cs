using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace ImpuestosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class impTipoImpuestoActionExchange : Framework.Core.Exchange{

        public Int32 TipoImpuesto {
            get {
                if(((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0]["TipoImpuesto"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].TipoImpuesto;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].TipoImpuesto = value;
               }
	          }
        public bool IsTipoImpuestoNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].IsTipoImpuestoNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String CodigoFiscal {
            get {
                if(((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0]["CodigoFiscal"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].CodigoFiscal;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].CodigoFiscal = value;
               }
	          }
        public bool IsCodigoFiscalNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].IsCodigoFiscalNull();
             }
	        }
        public String Juris_Id {
            get {
                if(((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0]["Juris_Id"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Juris_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Juris_Id = value;
               }
	          }
        public bool IsJuris_IdNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].IsJuris_IdNull();
             }
	        }
        public String DescripcionJurisdicciones {
            get {
                if(((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0]["DescripcionJurisdicciones"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].DescripcionJurisdicciones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].DescripcionJurisdicciones = value;
               }
	          }
        public bool IsDescripcionJurisdiccionesNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].IsDescripcionJurisdiccionesNull();
             }
	        }
        public String Referencia01 {
            get {
                if(((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0]["Referencia01"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia01;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia01 = value;
               }
	          }
        public bool IsReferencia01Null {
             get {
                 return mParam==null || ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].IsReferencia01Null();
             }
	        }
        public String Referencia02 {
            get {
                if(((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0]["Referencia02"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia02;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia02 = value;
               }
	          }
        public bool IsReferencia02Null {
             get {
                 return mParam==null || ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].IsReferencia02Null();
             }
	        }
        public String Referencia03 {
            get {
                if(((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0]["Referencia03"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia03;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia03 = value;
               }
	          }
        public bool IsReferencia03Null {
             get {
                 return mParam==null || ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].IsReferencia03Null();
             }
	        }
        public String Referencia04 {
            get {
                if(((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0]["Referencia04"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia04;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia04 = value;
               }
	          }
        public bool IsReferencia04Null {
             get {
                 return mParam==null || ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].IsReferencia04Null();
             }
	        }
        public String Referencia05 {
            get {
                if(((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0]["Referencia05"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia05;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia05 = value;
               }
	          }
        public bool IsReferencia05Null {
             get {
                 return mParam==null || ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].IsReferencia05Null();
             }
	        }
        public String Referencia06 {
            get {
                if(((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0]["Referencia06"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia06;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia06 = value;
               }
	          }
        public bool IsReferencia06Null {
             get {
                 return mParam==null || ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].IsReferencia06Null();
             }
	        }
        public String Referencia07 {
            get {
                if(((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0]["Referencia07"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia07;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia07 = value;
               }
	          }
        public bool IsReferencia07Null {
             get {
                 return mParam==null || ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].IsReferencia07Null();
             }
	        }
        public String Referencia08 {
            get {
                if(((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0]["Referencia08"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia08;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia08 = value;
               }
	          }
        public bool IsReferencia08Null {
             get {
                 return mParam==null || ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].IsReferencia08Null();
             }
	        }
        public String Referencia09 {
            get {
                if(((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0]["Referencia09"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia09;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia09 = value;
               }
	          }
        public bool IsReferencia09Null {
             get {
                 return mParam==null || ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].IsReferencia09Null();
             }
	        }
        public String Referencia10 {
            get {
                if(((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0]["Referencia10"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia10;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Referencia10 = value;
               }
	          }
        public bool IsReferencia10Null {
             get {
                 return mParam==null || ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].IsReferencia10Null();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impTipoImpuestoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impTipoImpuestoDS );
     }
     public impTipoImpuestoActionExchange() : base( "impTipoImpuesto" ) {
     }

     public impTipoImpuestoActionExchange(impTipoImpuestoActionEnum.EnumimpTipoImpuestoAction pAccion) : base(impTipoImpuestoActionEnum.GetAccionimpTipoImpuestoAction(pAccion)) {
     }

     public impTipoImpuestoActionExchange(impTipoImpuestoActionEnum.EnumimpTipoImpuestoAction pAccion, ImpuestosCommon.impTipoImpuestoDS pdsParam) : base(impTipoImpuestoActionEnum.GetAccionimpTipoImpuestoAction(pAccion), pdsParam) {
     }

     public impTipoImpuestoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impTipoImpuestoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impTipoImpuestoDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impTipoImpuestoDS)mParam;
	        }
     }
  }
}
