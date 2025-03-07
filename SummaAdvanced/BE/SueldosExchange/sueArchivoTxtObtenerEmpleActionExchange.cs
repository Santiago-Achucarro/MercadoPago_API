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
    public class sueArchivoTxtObtenerEmpleActionExchange : Framework.Core.Exchange{

        public Int32 Legajo {
            get {
                if(((SueldosCommon.sueArchivoTxtObtenerEmpleDS)mParam).Principal[0]["Legajo"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivoTxtObtenerEmpleDS)mParam).Principal[0].Legajo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivoTxtObtenerEmpleDS)mParam).Principal[0].Legajo = value;
               }
	          }
        public bool IsLegajoNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivoTxtObtenerEmpleDS)mParam).Principal[0].IsLegajoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.sueArchivoTxtObtenerEmpleDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.sueArchivoTxtObtenerEmpleDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.sueArchivoTxtObtenerEmpleDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.sueArchivoTxtObtenerEmpleDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.sueArchivoTxtObtenerEmpleDS );
     }
     public sueArchivoTxtObtenerEmpleActionExchange() : base( "sueArchivoTxtObtenerEmple" ) {
     }

     public sueArchivoTxtObtenerEmpleActionExchange(sueArchivoTxtObtenerEmpleActionEnum.EnumsueArchivoTxtObtenerEmpleAction pAccion) : base(sueArchivoTxtObtenerEmpleActionEnum.GetAccionsueArchivoTxtObtenerEmpleAction(pAccion)) {
     }

     public sueArchivoTxtObtenerEmpleActionExchange(sueArchivoTxtObtenerEmpleActionEnum.EnumsueArchivoTxtObtenerEmpleAction pAccion, SueldosCommon.sueArchivoTxtObtenerEmpleDS pdsParam) : base(sueArchivoTxtObtenerEmpleActionEnum.GetAccionsueArchivoTxtObtenerEmpleAction(pAccion), pdsParam) {
     }

     public sueArchivoTxtObtenerEmpleActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.sueArchivoTxtObtenerEmpleDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.sueArchivoTxtObtenerEmpleDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.sueArchivoTxtObtenerEmpleDS)mParam;
	        }
     }
  }
}
