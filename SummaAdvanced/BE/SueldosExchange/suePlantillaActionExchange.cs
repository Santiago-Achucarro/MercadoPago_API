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
    public class suePlantillaActionExchange : Framework.Core.Exchange{

        public String Centro1_Id {
            get {
                if(((SueldosCommon.suePlantillaDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((SueldosCommon.suePlantillaDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePlantillaDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((SueldosCommon.suePlantillaDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((SueldosCommon.suePlantillaDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((SueldosCommon.suePlantillaDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePlantillaDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((SueldosCommon.suePlantillaDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public Boolean Existe {
            get {
                if(((SueldosCommon.suePlantillaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((SueldosCommon.suePlantillaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((SueldosCommon.suePlantillaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((SueldosCommon.suePlantillaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( SueldosCommon.suePlantillaDS );
     }
     public suePlantillaActionExchange() : base( "suePlantilla" ) {
     }

     public suePlantillaActionExchange(suePlantillaActionEnum.EnumsuePlantillaAction pAccion) : base(suePlantillaActionEnum.GetAccionsuePlantillaAction(pAccion)) {
     }

     public suePlantillaActionExchange(suePlantillaActionEnum.EnumsuePlantillaAction pAccion, SueldosCommon.suePlantillaDS pdsParam) : base(suePlantillaActionEnum.GetAccionsuePlantillaAction(pAccion), pdsParam) {
     }

     public suePlantillaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new SueldosCommon.suePlantillaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public SueldosCommon.suePlantillaDS Param{
	        get{
			    InitParam();
			    return (SueldosCommon.suePlantillaDS)mParam;
	        }
     }
  }
}
