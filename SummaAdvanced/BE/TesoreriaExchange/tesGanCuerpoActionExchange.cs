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
    public class tesGanCuerpoActionExchange : Framework.Core.Exchange{

        public Int32 Tabla_Id {
            get {
                if(((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0]["Tabla_Id"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0].Tabla_Id;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0].Tabla_Id = value;
               }
	          }
        public bool IsTabla_IdNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0].IsTabla_IdNull();
             }
	        }
        public String DescripcionGanancias {
            get {
                if(((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0]["DescripcionGanancias"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0].DescripcionGanancias;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0].DescripcionGanancias = value;
               }
	          }
        public bool IsDescripcionGananciasNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0].IsDescripcionGananciasNull();
             }
	        }
        public Decimal Hasta {
            get {
                if(((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0]["Hasta"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0].Hasta;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0].Hasta = value;
               }
	          }
        public bool IsHastaNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0].IsHastaNull();
             }
	        }
        public Decimal Porcentaje {
            get {
                if(((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0]["Porcentaje"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0].Porcentaje;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0].Porcentaje = value;
               }
	          }
        public bool IsPorcentajeNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0].IsPorcentajeNull();
             }
	        }
        public Decimal Minimo {
            get {
                if(((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0]["Minimo"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0].Minimo;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0].Minimo = value;
               }
	          }
        public bool IsMinimoNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0].IsMinimoNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((TesoreriaCommon.tesGanCuerpoDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( TesoreriaCommon.tesGanCuerpoDS );
     }
     public tesGanCuerpoActionExchange() : base( "tesGanCuerpo" ) {
     }

     public tesGanCuerpoActionExchange(tesGanCuerpoActionEnum.EnumtesGanCuerpoAction pAccion) : base(tesGanCuerpoActionEnum.GetAcciontesGanCuerpoAction(pAccion)) {
     }

     public tesGanCuerpoActionExchange(tesGanCuerpoActionEnum.EnumtesGanCuerpoAction pAccion, TesoreriaCommon.tesGanCuerpoDS pdsParam) : base(tesGanCuerpoActionEnum.GetAcciontesGanCuerpoAction(pAccion), pdsParam) {
     }

     public tesGanCuerpoActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new TesoreriaCommon.tesGanCuerpoDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public TesoreriaCommon.tesGanCuerpoDS Param{
	        get{
			    InitParam();
			    return (TesoreriaCommon.tesGanCuerpoDS)mParam;
	        }
     }
  }
}
