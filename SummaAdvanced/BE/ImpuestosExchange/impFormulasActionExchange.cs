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
    public class impFormulasActionExchange : Framework.Core.Exchange{

        public String DescripcionImpuestos {
            get {
                if(((ImpuestosCommon.impFormulasDS)mParam).Principal[0]["DescripcionImpuestos"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].DescripcionImpuestos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].DescripcionImpuestos = value;
               }
	          }
        public bool IsDescripcionImpuestosNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].IsDescripcionImpuestosNull();
             }
	        }
        public Int16 Renglon {
            get {
                if(((ImpuestosCommon.impFormulasDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String Cuenta_Id {
            get {
                if(((ImpuestosCommon.impFormulasDS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String DescripcionCuentas {
            get {
                if(((ImpuestosCommon.impFormulasDS)mParam).Principal[0]["DescripcionCuentas"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].DescripcionCuentas;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].DescripcionCuentas = value;
               }
	          }
        public bool IsDescripcionCuentasNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].IsDescripcionCuentasNull();
             }
	        }
        public String Detalle {
            get {
                if(((ImpuestosCommon.impFormulasDS)mParam).Principal[0]["Detalle"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].Detalle;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].Detalle = value;
               }
	          }
        public bool IsDetalleNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].IsDetalleNull();
             }
	        }
        public String DebeHaberAmbos {
            get {
                if(((ImpuestosCommon.impFormulasDS)mParam).Principal[0]["DebeHaberAmbos"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].DebeHaberAmbos;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].DebeHaberAmbos = value;
               }
	          }
        public bool IsDebeHaberAmbosNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].IsDebeHaberAmbosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ImpuestosCommon.impFormulasDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ImpuestosCommon.impFormulasDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ImpuestosCommon.impFormulasDS );
     }
     public impFormulasActionExchange() : base( "impFormulas" ) {
     }

     public impFormulasActionExchange(impFormulasActionEnum.EnumimpFormulasAction pAccion) : base(impFormulasActionEnum.GetAccionimpFormulasAction(pAccion)) {
     }

     public impFormulasActionExchange(impFormulasActionEnum.EnumimpFormulasAction pAccion, ImpuestosCommon.impFormulasDS pdsParam) : base(impFormulasActionEnum.GetAccionimpFormulasAction(pAccion), pdsParam) {
     }

     public impFormulasActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ImpuestosCommon.impFormulasDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ImpuestosCommon.impFormulasDS Param{
	        get{
			    InitParam();
			    return (ImpuestosCommon.impFormulasDS)mParam;
	        }
     }
  }
}
