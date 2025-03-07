using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace StockExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class stkMoviCabeCentroActionExchange : Framework.Core.Exchange{

        public Int64 stkMoviCabe {
            get {
                if(((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0]["stkMoviCabe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0].stkMoviCabe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0].stkMoviCabe = value;
               }
	          }
        public bool IsstkMoviCabeNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0].IsstkMoviCabeNull();
             }
	        }
        public String Centro1_Id {
            get {
                if(((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0]["Centro1_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0].Centro1_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0].Centro1_Id = value;
               }
	          }
        public bool IsCentro1_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0].IsCentro1_IdNull();
             }
	        }
        public String DescripcionCentro1 {
            get {
                if(((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0]["DescripcionCentro1"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0].DescripcionCentro1;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0].DescripcionCentro1 = value;
               }
	          }
        public bool IsDescripcionCentro1Null {
             get {
                 return mParam==null || ((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0].IsDescripcionCentro1Null();
             }
	        }
        public String Centro2_Id {
            get {
                if(((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0]["Centro2_Id"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0].Centro2_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0].Centro2_Id = value;
               }
	          }
        public bool IsCentro2_IdNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0].IsCentro2_IdNull();
             }
	        }
        public String DescripcionCentro2 {
            get {
                if(((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0]["DescripcionCentro2"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0].DescripcionCentro2;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0].DescripcionCentro2 = value;
               }
	          }
        public bool IsDescripcionCentro2Null {
             get {
                 return mParam==null || ((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0].IsDescripcionCentro2Null();
             }
	        }
        public Boolean Existe {
            get {
                if(((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((StockCommon.stkMoviCabeCentroDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( StockCommon.stkMoviCabeCentroDS );
     }
     public stkMoviCabeCentroActionExchange() : base( "stkMoviCabeCentro" ) {
     }

     public stkMoviCabeCentroActionExchange(stkMoviCabeCentroActionEnum.EnumstkMoviCabeCentroAction pAccion) : base(stkMoviCabeCentroActionEnum.GetAccionstkMoviCabeCentroAction(pAccion)) {
     }

     public stkMoviCabeCentroActionExchange(stkMoviCabeCentroActionEnum.EnumstkMoviCabeCentroAction pAccion, StockCommon.stkMoviCabeCentroDS pdsParam) : base(stkMoviCabeCentroActionEnum.GetAccionstkMoviCabeCentroAction(pAccion), pdsParam) {
     }

     public stkMoviCabeCentroActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new StockCommon.stkMoviCabeCentroDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public StockCommon.stkMoviCabeCentroDS Param{
	        get{
			    InitParam();
			    return (StockCommon.stkMoviCabeCentroDS)mParam;
	        }
     }
  }
}
