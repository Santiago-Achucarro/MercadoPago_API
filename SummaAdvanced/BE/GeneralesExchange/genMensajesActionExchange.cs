using System;
using System.Data;
using System.Runtime.Serialization;
using Framework.Core;

namespace GeneralesExchange{
   // Generado por QBI
    /// <summary> 
    /// Los requerimientos, o <c>Exchange</c>, son utilizados para
    /// encapsular el llamado a una acción. En los mismos se indica el
    /// nombre de la acción a ejecutar y sus los parámetros.
    /// </summary>
    public class genMensajesActionExchange : Framework.Core.Exchange{

        public Int32 MensajeId {
            get {
                if(((GeneralesCommon.genMensajesDS)mParam).Principal[0]["MensajeId"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesDS)mParam).Principal[0].MensajeId;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesDS)mParam).Principal[0].MensajeId = value;
               }
	          }
        public bool IsMensajeIdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesDS)mParam).Principal[0].IsMensajeIdNull();
             }
	        }
        public DateTime FechaEmision {
            get {
                if(((GeneralesCommon.genMensajesDS)mParam).Principal[0]["FechaEmision"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesDS)mParam).Principal[0].FechaEmision;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesDS)mParam).Principal[0].FechaEmision = value;
               }
	          }
        public bool IsFechaEmisionNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesDS)mParam).Principal[0].IsFechaEmisionNull();
             }
	        }
        public DateTime FechaLeido {
            get {
                if(((GeneralesCommon.genMensajesDS)mParam).Principal[0]["FechaLeido"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesDS)mParam).Principal[0].FechaLeido;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesDS)mParam).Principal[0].FechaLeido = value;
               }
	          }
        public bool IsFechaLeidoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesDS)mParam).Principal[0].IsFechaLeidoNull();
             }
	        }
        public Int32 genUsuarios {
            get {
                if(((GeneralesCommon.genMensajesDS)mParam).Principal[0]["genUsuarios"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesDS)mParam).Principal[0].genUsuarios;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesDS)mParam).Principal[0].genUsuarios = value;
               }
	          }
        public bool IsgenUsuariosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesDS)mParam).Principal[0].IsgenUsuariosNull();
             }
	        }
        public String Mensaje {
            get {
                if(((GeneralesCommon.genMensajesDS)mParam).Principal[0]["Mensaje"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesDS)mParam).Principal[0].Mensaje;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesDS)mParam).Principal[0].Mensaje = value;
               }
	          }
        public bool IsMensajeNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesDS)mParam).Principal[0].IsMensajeNull();
             }
	        }
        public String Usuario_id {
            get {
                if(((GeneralesCommon.genMensajesDS)mParam).Principal[0]["Usuario_id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesDS)mParam).Principal[0].Usuario_id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesDS)mParam).Principal[0].Usuario_id = value;
               }
	          }
        public bool IsUsuario_idNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesDS)mParam).Principal[0].IsUsuario_idNull();
             }
	        }
        public String DescripcionUsuario {
            get {
                if(((GeneralesCommon.genMensajesDS)mParam).Principal[0]["DescripcionUsuario"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesDS)mParam).Principal[0].DescripcionUsuario;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesDS)mParam).Principal[0].DescripcionUsuario = value;
               }
	          }
        public bool IsDescripcionUsuarioNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesDS)mParam).Principal[0].IsDescripcionUsuarioNull();
             }
	        }
        public String UsuarioDestino {
            get {
                if(((GeneralesCommon.genMensajesDS)mParam).Principal[0]["UsuarioDestino"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesDS)mParam).Principal[0].UsuarioDestino;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesDS)mParam).Principal[0].UsuarioDestino = value;
               }
	          }
        public bool IsUsuarioDestinoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesDS)mParam).Principal[0].IsUsuarioDestinoNull();
             }
	        }
        public String DescripcionUsuarioDestino {
            get {
                if(((GeneralesCommon.genMensajesDS)mParam).Principal[0]["DescripcionUsuarioDestino"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesDS)mParam).Principal[0].DescripcionUsuarioDestino;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesDS)mParam).Principal[0].DescripcionUsuarioDestino = value;
               }
	          }
        public bool IsDescripcionUsuarioDestinoNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesDS)mParam).Principal[0].IsDescripcionUsuarioDestinoNull();
             }
	        }
        public DateTime FechaDesde {
            get {
                if(((GeneralesCommon.genMensajesDS)mParam).Principal[0]["FechaDesde"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesDS)mParam).Principal[0].FechaDesde;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesDS)mParam).Principal[0].FechaDesde = value;
               }
	          }
        public bool IsFechaDesdeNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesDS)mParam).Principal[0].IsFechaDesdeNull();
             }
	        }
        public DateTime FechaHasta {
            get {
                if(((GeneralesCommon.genMensajesDS)mParam).Principal[0]["FechaHasta"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesDS)mParam).Principal[0].FechaHasta;
                }
				else{
                    return new DateTime(1,1,2);
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesDS)mParam).Principal[0].FechaHasta = value;
               }
	          }
        public bool IsFechaHastaNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesDS)mParam).Principal[0].IsFechaHastaNull();
             }
	        }
        public String Parametros {
            get {
                if(((GeneralesCommon.genMensajesDS)mParam).Principal[0]["Parametros"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesDS)mParam).Principal[0].Parametros;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesDS)mParam).Principal[0].Parametros = value;
               }
	          }
        public bool IsParametrosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesDS)mParam).Principal[0].IsParametrosNull();
             }
	        }
        public Int32 disFormularios {
            get {
                if(((GeneralesCommon.genMensajesDS)mParam).Principal[0]["disFormularios"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesDS)mParam).Principal[0].disFormularios;
                }
				else{
                    return 0;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesDS)mParam).Principal[0].disFormularios = value;
               }
	          }
        public bool IsdisFormulariosNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesDS)mParam).Principal[0].IsdisFormulariosNull();
             }
	        }
        public String Formulario_Id {
            get {
                if(((GeneralesCommon.genMensajesDS)mParam).Principal[0]["Formulario_Id"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesDS)mParam).Principal[0].Formulario_Id;
                }
				else{
                    return "";
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesDS)mParam).Principal[0].Formulario_Id = value;
               }
	          }
        public bool IsFormulario_IdNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesDS)mParam).Principal[0].IsFormulario_IdNull();
             }
	        }
        public String Tipo
        {
            get
            {
                if (((GeneralesCommon.genMensajesDS)mParam).Principal[0]["Tipo"] != DBNull.Value)
                {
                    return ((GeneralesCommon.genMensajesDS)mParam).Principal[0].Tipo;
                }
                else
                {
                    return "";
                }
            }

            set
            {
                InitParam();
                ((GeneralesCommon.genMensajesDS)mParam).Principal[0].Tipo = value;
            }
        }
        public bool IsTipoNull
        {
            get
            {
                return mParam == null || ((GeneralesCommon.genMensajesDS)mParam).Principal[0].IsTipoNull();
            }
        }
        public String SubTipo
        {
            get
            {
                if (((GeneralesCommon.genMensajesDS)mParam).Principal[0]["SubTipo"] != DBNull.Value)
                {
                    return ((GeneralesCommon.genMensajesDS)mParam).Principal[0].SubTipo;
                }
                else
                {
                    return "";
                }
            }

            set
            {
                InitParam();
                ((GeneralesCommon.genMensajesDS)mParam).Principal[0].SubTipo = value;
            }
        }
        public bool IsSubTipoNull
        {
            get
            {
                return mParam == null || ((GeneralesCommon.genMensajesDS)mParam).Principal[0].IsSubTipoNull();
            }
        }
        public Boolean Existe {
            get {
                if(((GeneralesCommon.genMensajesDS)mParam).Principal[0]["Existe"] != DBNull.Value  ){
                    return ((GeneralesCommon.genMensajesDS)mParam).Principal[0].Existe;
                }
				else{
                    return false;
                }
            }

           set {
               InitParam();
	              ((GeneralesCommon.genMensajesDS)mParam).Principal[0].Existe = value;
               }
	          }
        public bool IsExisteNull {
             get {
                 return mParam==null || ((GeneralesCommon.genMensajesDS)mParam).Principal[0].IsExisteNull();
             }
	        }

     protected override Type GetParamType(){
	        return typeof( GeneralesCommon.genMensajesDS );
     }
     public genMensajesActionExchange() : base( "genMensajes" ) {
     }

     public genMensajesActionExchange(genMensajesActionEnum.EnumgenMensajesAction pAccion) : base(genMensajesActionEnum.GetAcciongenMensajesAction(pAccion)) {
     }

     public genMensajesActionExchange(genMensajesActionEnum.EnumgenMensajesAction pAccion, GeneralesCommon.genMensajesDS pdsParam) : base(genMensajesActionEnum.GetAcciongenMensajesAction(pAccion), pdsParam) {
     }

     public genMensajesActionExchange(Exchange pExch) : base() {
     this.Action = pExch.Action;
     this.mParam = new GeneralesCommon.genMensajesDS();
     this.mParam.Merge(pExch.RawDataSet, false, MissingSchemaAction.Ignore);
     this.mParam.AcceptChanges();
     }

     /// <summary>
     /// El DataSet con los parámetros.
     /// </summary>
     public GeneralesCommon.genMensajesDS Param{
	        get{
			    InitParam();
			    return (GeneralesCommon.genMensajesDS)mParam;
	        }
     }
  }
}
