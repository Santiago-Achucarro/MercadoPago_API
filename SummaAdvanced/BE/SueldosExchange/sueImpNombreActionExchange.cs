using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace SueldosExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class sueImpNombreActionExchange : Framework.Core.Exchange{

        public Int32 Importe_Id {
            get {
                if(((SueldosCommon.sueImpNombreDS)mParam).Principal[0]["Importe_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueImpNombreDS)mParam).Principal[0].Importe_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueImpNombreDS)mParam).Principal[0].Importe_Id = value;
               }
	          }
        public bool IsImporte_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueImpNombreDS)mParam).Principal[0].IsImporte_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueImpNombreDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueImpNombreDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueImpNombreDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueImpNombreDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public String Usuario_Id {
            get {
                if(((SueldosCommon.sueImpNombreDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueImpNombreDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueImpNombreDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueImpNombreDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((SueldosCommon.sueImpNombreDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((SueldosCommon.sueImpNombreDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueImpNombreDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((SueldosCommon.sueImpNombreDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueImpNombreDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueImpNombreDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueImpNombreDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueImpNombreDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueImpNombreDS );
     }
     public sueImpNombreActionExchange() : base( "sueImpNombre" ) {
     }

     public sueImpNombreActionExchange(sueImpNombreActionEnum.EnumsueImpNombreAction pAccion) : base(sueImpNombreActionEnum.GetAccionsueImpNombreAction(pAccion)) {
     }

     public sueImpNombreActionExchange(sueImpNombreActionEnum.EnumsueImpNombreAction pAccion, SueldosCommon.sueImpNombreDS pdsParam) : base(sueImpNombreActionEnum.GetAccionsueImpNombreAction(pAccion), pdsParam) {
     }

     public sueImpNombreActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueImpNombreDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueImpNombreDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueImpNombreDS)mParam;
	        }
     }
  }
}
