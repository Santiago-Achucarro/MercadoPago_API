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
    public class conVeriCentro12ActionExchange : Framework.Core.Exchange{

        public String Cuenta_Id {
            get {
                if(((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0]["Cuenta_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0].Cuenta_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0].Cuenta_Id = value;
               }
	          }
        public bool IsCuenta_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0].IsCuenta_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String Centro2_Id {
            get {
                if(((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conVeriCentro12DS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conVeriCentro12DS );
     }
     public conVeriCentro12ActionExchange() : base( "conVeriCentro12" ) {
     }

     public conVeriCentro12ActionExchange(conVeriCentro12ActionEnum.EnumconVeriCentro12Action pAccion) : base(conVeriCentro12ActionEnum.GetAccionconVeriCentro12Action(pAccion)) {
     }

     public conVeriCentro12ActionExchange(conVeriCentro12ActionEnum.EnumconVeriCentro12Action pAccion, ContabilidadCommon.conVeriCentro12DS pdsParam) : base(conVeriCentro12ActionEnum.GetAccionconVeriCentro12Action(pAccion), pdsParam) {
     }

     public conVeriCentro12ActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conVeriCentro12DS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conVeriCentro12DS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conVeriCentro12DS)mParam;
	        }
     }
  }
}
