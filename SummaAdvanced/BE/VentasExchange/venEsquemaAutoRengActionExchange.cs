using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace VentasExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class venEsquemaAutoRengActionExchange : Framework.Core.Exchange{

        public String EsquemaAuto_Id {
            get {
                if(((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0]["EsquemaAuto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].EsquemaAuto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].EsquemaAuto_Id = value;
               }
	          }
        public bool IsEsquemaAuto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].IsEsquemaAuto_IdNull();
             }
	        }
        public String DescripcioncomEsquemaAuto {
            get {
                if(((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0]["DescripcioncomEsquemaAuto"] != DBNull.Value  ){
                    return ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].DescripcioncomEsquemaAuto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].DescripcioncomEsquemaAuto = value;
               }
	          }
        public bool IsDescripcioncomEsquemaAutoNull {
             get {
                 return mParam==null || ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].IsDescripcioncomEsquemaAutoNull();
             }
	        }
        public Int32 Orden {
            get {
                if(((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0]["Orden"] != DBNull.Value  ){
                    return ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].Orden;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].Orden = value;
               }
	          }
        public bool IsOrdenNull {
             get {
                 return mParam==null || ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].IsOrdenNull();
             }
	        }
        public String NivelAuto_Id {
            get {
                if(((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0]["NivelAuto_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].NivelAuto_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].NivelAuto_Id = value;
               }
	          }
        public bool IsNivelAuto_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].IsNivelAuto_IdNull();
             }
	        }
        public String DescripcioncomNivelesAuto {
            get {
                if(((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0]["DescripcioncomNivelesAuto"] != DBNull.Value  ){
                    return ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].DescripcioncomNivelesAuto;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].DescripcioncomNivelesAuto = value;
               }
	          }
        public bool IsDescripcioncomNivelesAutoNull {
             get {
                 return mParam==null || ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].IsDescripcioncomNivelesAutoNull();
             }
	        }
        public String Formula {
            get {
                if(((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0]["Formula"] != DBNull.Value  ){
                    return ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].Formula;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].Formula = value;
               }
	          }
        public bool IsFormulaNull {
             get {
                 return mParam==null || ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].IsFormulaNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venEsquemaAutoRengDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venEsquemaAutoRengDS );
     }
     public venEsquemaAutoRengActionExchange() : base( "venEsquemaAutoReng" ) {
     }

     public venEsquemaAutoRengActionExchange(venEsquemaAutoRengActionEnum.EnumvenEsquemaAutoRengAction pAccion) : base(venEsquemaAutoRengActionEnum.GetAccionvenEsquemaAutoRengAction(pAccion)) {
     }

     public venEsquemaAutoRengActionExchange(venEsquemaAutoRengActionEnum.EnumvenEsquemaAutoRengAction pAccion, VentasCommon.venEsquemaAutoRengDS pdsParam) : base(venEsquemaAutoRengActionEnum.GetAccionvenEsquemaAutoRengAction(pAccion), pdsParam) {
     }

     public venEsquemaAutoRengActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venEsquemaAutoRengDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venEsquemaAutoRengDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venEsquemaAutoRengDS)mParam;
	        }
     }
  }
}
