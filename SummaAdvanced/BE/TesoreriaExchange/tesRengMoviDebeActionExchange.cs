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
    public class tesRengMoviDebeActionExchange : Framework.Core.Exchange{

        public Int64 tesMovimientos {
            get {
                if(((TesoreriaCommon.tesRengMoviDebeDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDebeDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDebeDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDebeDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesRengMoviDebeDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesRengMoviDebeDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesRengMoviDebeDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesRengMoviDebeDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesRengMoviDebeDS );
     }
     public tesRengMoviDebeActionExchange() : base( "tesRengMoviDebe" ) {
     }

     public tesRengMoviDebeActionExchange(tesRengMoviDebeActionEnum.EnumtesRengMoviDebeAction pAccion) : base(tesRengMoviDebeActionEnum.GetAcciontesRengMoviDebeAction(pAccion)) {
     }

     public tesRengMoviDebeActionExchange(tesRengMoviDebeActionEnum.EnumtesRengMoviDebeAction pAccion, TesoreriaCommon.tesRengMoviDebeDS pdsParam) : base(tesRengMoviDebeActionEnum.GetAcciontesRengMoviDebeAction(pAccion), pdsParam) {
     }

     public tesRengMoviDebeActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesRengMoviDebeDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesRengMoviDebeDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesRengMoviDebeDS)mParam;
	        }
     }
  }
}
