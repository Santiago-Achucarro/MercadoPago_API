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
    public class venCompCartaPorteMercanciaActionExchange : Framework.Core.Exchange{

        public Int64 venmovimientos {
            get {
                if(((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0]["venmovimientos"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].venmovimientos;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].venmovimientos = value;
               }
	          }
        public bool IsvenmovimientosNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].IsvenmovimientosNull();
             }
	        }
        public Int32 idDestino {
            get {
                if(((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0]["idDestino"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].idDestino;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].idDestino = value;
               }
	          }
        public bool IsidDestinoNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].IsidDestinoNull();
             }
	        }
        public Int32 Renglon {
            get {
                if(((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0]["Renglon"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].Renglon;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].Renglon = value;
               }
	          }
        public bool IsRenglonNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].IsRenglonNull();
             }
	        }
        public String BienesTransp {
            get {
                if(((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0]["BienesTransp"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].BienesTransp;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].BienesTransp = value;
               }
	          }
        public bool IsBienesTranspNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].IsBienesTranspNull();
             }
	        }
        public String ClaveSTCC {
            get {
                if(((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0]["ClaveSTCC"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].ClaveSTCC;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].ClaveSTCC = value;
               }
	          }
        public bool IsClaveSTCCNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].IsClaveSTCCNull();
             }
	        }
        public String Descripcion {
            get {
                if(((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0]["Descripcion"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].Descripcion;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].Descripcion = value;
               }
	          }
        public bool IsDescripcionNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].IsDescripcionNull();
             }
	        }
        public Decimal Cantidad {
            get {
                if(((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0]["Cantidad"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].Cantidad;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].Cantidad = value;
               }
	          }
        public bool IsCantidadNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].IsCantidadNull();
             }
	        }
        public String Medida_Id {
            get {
                if(((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0]["Medida_Id"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].Medida_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].Medida_Id = value;
               }
	          }
        public bool IsMedida_IdNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].IsMedida_IdNull();
             }
	        }
        public String Dimensiones {
            get {
                if(((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0]["Dimensiones"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].Dimensiones;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].Dimensiones = value;
               }
	          }
        public bool IsDimensionesNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].IsDimensionesNull();
             }
	        }
        public String MaterialPeligroso {
            get {
                if(((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0]["MaterialPeligroso"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].MaterialPeligroso;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].MaterialPeligroso = value;
               }
	          }
        public bool IsMaterialPeligrosoNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].IsMaterialPeligrosoNull();
             }
	        }
        public String CveMaterialPeligroso {
            get {
                if(((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0]["CveMaterialPeligroso"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].CveMaterialPeligroso;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].CveMaterialPeligroso = value;
               }
	          }
        public bool IsCveMaterialPeligrosoNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].IsCveMaterialPeligrosoNull();
             }
	        }
        public String Embalaje {
            get {
                if(((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0]["Embalaje"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].Embalaje;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].Embalaje = value;
               }
	          }
        public bool IsEmbalajeNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].IsEmbalajeNull();
             }
	        }
        public String DescripEmbalaje {
            get {
                if(((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0]["DescripEmbalaje"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].DescripEmbalaje;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].DescripEmbalaje = value;
               }
	          }
        public bool IsDescripEmbalajeNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].IsDescripEmbalajeNull();
             }
	        }
        public Decimal PesoEnKg {
            get {
                if(((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0]["PesoEnKg"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].PesoEnKg;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].PesoEnKg = value;
               }
	          }
        public bool IsPesoEnKgNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].IsPesoEnKgNull();
             }
	        }
        public Decimal ValorMercancia {
            get {
                if(((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0]["ValorMercancia"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].ValorMercancia;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].ValorMercancia = value;
               }
	          }
        public bool IsValorMercanciaNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].IsValorMercanciaNull();
             }
	        }
        public String FraccionArancelaria {
            get {
                if(((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0]["FraccionArancelaria"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].FraccionArancelaria;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].FraccionArancelaria = value;
               }
	          }
        public bool IsFraccionArancelariaNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].IsFraccionArancelariaNull();
             }
	        }
        public String UUIDComercioExt {
            get {
                if(((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0]["UUIDComercioExt"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].UUIDComercioExt;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].UUIDComercioExt = value;
               }
	          }
        public bool IsUUIDComercioExtNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].IsUUIDComercioExtNull();
             }
	        }
        public Boolean Existe {
            get {
                if(((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((VentasCommon.venCompCartaPorteMercanciaDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( VentasCommon.venCompCartaPorteMercanciaDS );
     }
     public venCompCartaPorteMercanciaActionExchange() : base( "venCompCartaPorteMercancia" ) {
     }

     public venCompCartaPorteMercanciaActionExchange(venCompCartaPorteMercanciaActionEnum.EnumvenCompCartaPorteMercanciaAction pAccion) : base(venCompCartaPorteMercanciaActionEnum.GetAccionvenCompCartaPorteMercanciaAction(pAccion)) {
     }

     public venCompCartaPorteMercanciaActionExchange(venCompCartaPorteMercanciaActionEnum.EnumvenCompCartaPorteMercanciaAction pAccion, VentasCommon.venCompCartaPorteMercanciaDS pdsParam) : base(venCompCartaPorteMercanciaActionEnum.GetAccionvenCompCartaPorteMercanciaAction(pAccion), pdsParam) {
     }

     public venCompCartaPorteMercanciaActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new VentasCommon.venCompCartaPorteMercanciaDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     public venCompCartaPorteMercanciaActionExchange(VentasCommon.venCompCartaPorteMercanciaDS pDS) : base() {
     this.Action = "";
     this.mParam = new VentasCommon.venCompCartaPorteMercanciaDS();
     this.mParam.Merge(pDS, false, MissingSchemaAction.Ignore);
     //this.mParam.Principal[0].Delete();
     this.mParam.AcceptChanges();
     this.Existe=pDS.Principal.Count>0;
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public VentasCommon.venCompCartaPorteMercanciaDS Param{
	        get{
			    InitParam();
			    return (VentasCommon.venCompCartaPorteMercanciaDS)mParam;
	        }
     }
  }
}
