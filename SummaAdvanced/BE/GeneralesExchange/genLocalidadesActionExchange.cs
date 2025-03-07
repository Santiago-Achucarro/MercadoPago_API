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
    public class genLocalidadesActionExchange : Framework.Core.Exchange{

        public String c_Localidad {
            get {
                if(((GeneralesCommon.genLocalidadesDS)mParam).Principal[0]["c_Localidad"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLocalidadesDS)mParam).Principal[0].c_Localidad;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLocalidadesDS)mParam).Principal[0].c_Localidad = value;
               }
	          }
        public bool Isc_LocalidadNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLocalidadesDS)mParam).Principal[0].Isc_LocalidadNull();
             }
	        }
        public String c_Estado {
            get {
                if(((GeneralesCommon.genLocalidadesDS)mParam).Principal[0]["c_Estado"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLocalidadesDS)mParam).Principal[0].c_Estado;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLocalidadesDS)mParam).Principal[0].c_Estado = value;
               }
	          }
        public bool Isc_EstadoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLocalidadesDS)mParam).Principal[0].Isc_EstadoNull();
             }
	        }
        public String Descripcion {
            get {
                if(((GeneralesCommon.genLocalidadesDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLocalidadesDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLocalidadesDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLocalidadesDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genLocalidadesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genLocalidadesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genLocalidadesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genLocalidadesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genLocalidadesDS );
     }
     public genLocalidadesActionExchange() : base( "genLocalidades" ) {
     }

     public genLocalidadesActionExchange(genLocalidadesActionEnum.EnumgenLocalidadesAction pAccion) : base(genLocalidadesActionEnum.GetAcciongenLocalidadesAction(pAccion)) {
     }

     public genLocalidadesActionExchange(genLocalidadesActionEnum.EnumgenLocalidadesAction pAccion, GeneralesCommon.genLocalidadesDS pdsParam) : base(genLocalidadesActionEnum.GetAcciongenLocalidadesAction(pAccion), pdsParam) {
     }

     public genLocalidadesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genLocalidadesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public genLocalidadesActionExchange(GeneralesCommon.genLocalidadesDS pDS) : base() {
     this.Action = "";
     this.mParam = new GeneralesCommon.genLocalidadesDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genLocalidadesDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genLocalidadesDS)mParam;
	        }
     }
  }
}
