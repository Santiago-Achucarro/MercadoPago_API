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
    public class sueGanTituloActionExchange : Framework.Core.Exchange{

        public Int32 TabGan_Id {
            get {
                if(((SueldosCommon.sueGanTituloDS)mParam).Principal[0]["TabGan_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].TabGan_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].TabGan_Id = value;
               }
	          }
        public bool IsTabGan_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].IsTabGan_IdNull();
             }
	        }
        public String Descripcion {
            get {
                if(((SueldosCommon.sueGanTituloDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Int32 Usuario_Id {
            get {
                if(((SueldosCommon.sueGanTituloDS)mParam).Principal[0]["Usuario_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].Usuario_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].Usuario_Id = value;
               }
	          }
        public bool IsUsuario_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].IsUsuario_IdNull();
             }
	        }
        public DateTime FechaRegistro {
            get {
                if(((SueldosCommon.sueGanTituloDS)mParam).Principal[0]["FechaRegistro"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].FechaRegistro;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].FechaRegistro = value;
               }
	          }
        public bool IsFechaRegistroNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].IsFechaRegistroNull();
             }
	        }
        public String Codigo {
            get {
                if(((SueldosCommon.sueGanTituloDS)mParam).Principal[0]["Codigo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].Codigo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].Codigo = value;
               }
	          }
        public bool IsCodigoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].IsCodigoNull();
             }
	        }
        public DateTime FechaCodigo {
            get {
                if(((SueldosCommon.sueGanTituloDS)mParam).Principal[0]["FechaCodigo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].FechaCodigo;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].FechaCodigo = value;
               }
	          }
        public bool IsFechaCodigoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].IsFechaCodigoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueGanTituloDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueGanTituloDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueGanTituloDS );
     }
     public sueGanTituloActionExchange() : base( "sueGanTitulo" ) {
     }

     public sueGanTituloActionExchange(sueGanTituloActionEnum.EnumsueGanTituloAction pAccion) : base(sueGanTituloActionEnum.GetAccionsueGanTituloAction(pAccion)) {
     }

     public sueGanTituloActionExchange(sueGanTituloActionEnum.EnumsueGanTituloAction pAccion, SueldosCommon.sueGanTituloDS pdsParam) : base(sueGanTituloActionEnum.GetAccionsueGanTituloAction(pAccion), pdsParam) {
     }

     public sueGanTituloActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueGanTituloDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueGanTituloDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueGanTituloDS)mParam;
	        }
     }
  }
}
