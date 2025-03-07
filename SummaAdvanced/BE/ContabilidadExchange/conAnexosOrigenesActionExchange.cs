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
    public class conAnexosOrigenesActionExchange : Framework.Core.Exchange{

        public Int16 Origen {
            get {
                if(((ContabilidadCommon.conAnexosOrigenesDS)mParam).Principal[0]["Origen"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAnexosOrigenesDS)mParam).Principal[0].Origen;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAnexosOrigenesDS)mParam).Principal[0].Origen = value;
               }
	          }
        public bool IsOrigenNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAnexosOrigenesDS)mParam).Principal[0].IsOrigenNull();
             }
	        }
        public String Descripcion {
            get {
                if(((ContabilidadCommon.conAnexosOrigenesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAnexosOrigenesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAnexosOrigenesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAnexosOrigenesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String TipoRubro {
            get {
                if(((ContabilidadCommon.conAnexosOrigenesDS)mParam).Principal[0]["TipoRubro"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAnexosOrigenesDS)mParam).Principal[0].TipoRubro;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAnexosOrigenesDS)mParam).Principal[0].TipoRubro = value;
               }
	          }
        public bool IsTipoRubroNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAnexosOrigenesDS)mParam).Principal[0].IsTipoRubroNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((ContabilidadCommon.conAnexosOrigenesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((ContabilidadCommon.conAnexosOrigenesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((ContabilidadCommon.conAnexosOrigenesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((ContabilidadCommon.conAnexosOrigenesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( ContabilidadCommon.conAnexosOrigenesDS );
     }
     public conAnexosOrigenesActionExchange() : base( "conAnexosOrigenes" ) {
     }

     public conAnexosOrigenesActionExchange(conAnexosOrigenesActionEnum.EnumconAnexosOrigenesAction pAccion) : base(conAnexosOrigenesActionEnum.GetAccionconAnexosOrigenesAction(pAccion)) {
     }

     public conAnexosOrigenesActionExchange(conAnexosOrigenesActionEnum.EnumconAnexosOrigenesAction pAccion, ContabilidadCommon.conAnexosOrigenesDS pdsParam) : base(conAnexosOrigenesActionEnum.GetAccionconAnexosOrigenesAction(pAccion), pdsParam) {
     }

     public conAnexosOrigenesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new ContabilidadCommon.conAnexosOrigenesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public ContabilidadCommon.conAnexosOrigenesDS Param{
	        get{
			    InitParam();
			    return (ContabilidadCommon.conAnexosOrigenesDS)mParam;
	        }
     }
  }
}
