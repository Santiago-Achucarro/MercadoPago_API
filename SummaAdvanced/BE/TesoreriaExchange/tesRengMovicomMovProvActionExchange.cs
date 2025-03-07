using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace TesoreriaExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class tesRengMovicomMovProvActionExchange : Framework.Core.Exchange{

        public Int64 tesMovimientos {
            get {
                if(((TesoreriaCommon.tesRengMovicomMovProvDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMovicomMovProvDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMovicomMovProvDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMovicomMovProvDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((TesoreriaCommon.tesRengMovicomMovProvDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMovicomMovProvDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMovicomMovProvDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMovicomMovProvDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public Int64 comMovProv {
            get {
                if(((TesoreriaCommon.tesRengMovicomMovProvDS)mParam).Principal[0]["comMovProv"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMovicomMovProvDS)mParam).Principal[0].comMovProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMovicomMovProvDS)mParam).Principal[0].comMovProv = value;
               }
	          }
        public bool IscomMovProvNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMovicomMovProvDS)mParam).Principal[0].IscomMovProvNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesRengMovicomMovProvDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMovicomMovProvDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMovicomMovProvDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMovicomMovProvDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesRengMovicomMovProvDS );
     }
     public tesRengMovicomMovProvActionExchange() : base( "tesRengMovicomMovProv" ) {
     }

     public tesRengMovicomMovProvActionExchange(tesRengMovicomMovProvActionEnum.EnumtesRengMovicomMovProvAction pAccion) : base(tesRengMovicomMovProvActionEnum.GetAcciontesRengMovicomMovProvAction(pAccion)) {
     }

     public tesRengMovicomMovProvActionExchange(tesRengMovicomMovProvActionEnum.EnumtesRengMovicomMovProvAction pAccion, TesoreriaCommon.tesRengMovicomMovProvDS pdsParam) : base(tesRengMovicomMovProvActionEnum.GetAcciontesRengMovicomMovProvAction(pAccion), pdsParam) {
     }

     public tesRengMovicomMovProvActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesRengMovicomMovProvDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesRengMovicomMovProvDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesRengMovicomMovProvDS)mParam;
	        }
     }
  }
}
