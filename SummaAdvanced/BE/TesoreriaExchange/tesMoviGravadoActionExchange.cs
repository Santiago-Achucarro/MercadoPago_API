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
    public class tesMoviGravadoActionExchange : Framework.Core.Exchange{

        public Int64 tesMovimientos {
            get {
                if(((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0]["tesMovimientos"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0].tesMovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0].tesMovimientos = value;
               }
	          }
        public bool IstesMovimientosNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0].IstesMovimientosNull();
             }
	        }
        public Int32 TipoCtaProv {
            get {
                if(((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0]["TipoCtaProv"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0].TipoCtaProv;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0].TipoCtaProv = value;
               }
	          }
        public bool IsTipoCtaProvNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0].IsTipoCtaProvNull();
             }
	        }
        public String DescripcionProveedoresTipoPasivo {
            get {
                if(((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0]["DescripcionProveedoresTipoPasivo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0].DescripcionProveedoresTipoPasivo;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0].DescripcionProveedoresTipoPasivo = value;
               }
	          }
        public bool IsDescripcionProveedoresTipoPasivoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0].IsDescripcionProveedoresTipoPasivoNull();
             }
	        }
        public Decimal Importe {
            get {
                if(((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0]["Importe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0].Importe;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0].Importe = value;
               }
	          }
        public bool IsImporteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0].IsImporteNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesMoviGravadoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesMoviGravadoDS );
     }
     public tesMoviGravadoActionExchange() : base( "tesMoviGravado" ) {
     }

     public tesMoviGravadoActionExchange(tesMoviGravadoActionEnum.EnumtesMoviGravadoAction pAccion) : base(tesMoviGravadoActionEnum.GetAcciontesMoviGravadoAction(pAccion)) {
     }

     public tesMoviGravadoActionExchange(tesMoviGravadoActionEnum.EnumtesMoviGravadoAction pAccion, TesoreriaCommon.tesMoviGravadoDS pdsParam) : base(tesMoviGravadoActionEnum.GetAcciontesMoviGravadoAction(pAccion), pdsParam) {
     }

     public tesMoviGravadoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesMoviGravadoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesMoviGravadoDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesMoviGravadoDS)mParam;
	        }
     }
  }
}
