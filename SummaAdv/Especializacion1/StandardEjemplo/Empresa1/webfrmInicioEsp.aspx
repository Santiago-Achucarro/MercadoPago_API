<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webfrmInicioEsp.aspx.cs" Inherits="SummaWeb.webfrmInicioEsp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio</title>
    <link href="../../../css/bootstrap.min.css?v=2.10.16" rel="stylesheet" />      
    <script src="../../../Script/modernizr-2.6.2.js"></script>
    <script src="../../../Script/jquery-1.10.2.min.js"></script>    
    <script src="../../../Script/jquery-ui-1.12.0.min.js"></script>
    <script src="../../../Script/bootstrap.min.js"></script>
    <link rel="stylesheet" href="../../../css/fontawesome/css/all.min.css?v=2.10.82" />
 <style>
    html {
        height: 100%;
    }
    body {
        height: 100%;
        background: black;
    }
    .quasar-btn-inicio {
        position: relative; 
        width: 100%; 
        height: 115px; 
        text-align: center;
        background-color: brown; 
    }
    .quasar-btn-inicio:hover{
        cursor: pointer;
        background-color: #424949;
    }

    .quasar-icono-btn-inicio {
        position: absolute; 
        left: 3px; 
        top: 3px; 
        font-size: 20px; 
        color: gainsboro;
    }
    .quasar-icono-2-btn-inicio {
        position: absolute; 
        left: 30px; 
        top: 5px; 
        font-size: 18px; 
        color: gainsboro;
    }

    .quasar-texto-btn-inicio {
        position: relative; 
        top: 50px; 
        color: gainsboro
    }
    .quasar-btn-inicio-1 {
        background-color: #17202A
    }
    .quasar-btn-inicio-2 {
        background-color: #1B2631
    }
    .quasar-btn-inicio-3 {
        background-color: #1C2833
    }
    .quasar-btn-inicio-4 {
        background-color: #212F3C
    }
    .quasar-btn-inicio-5 {
        background-color: #212F3D
    }
    .quasar-btn-inicio-6 {
        background-color: #283747
    }
    .quasar-btn-inicio-7 {
        background-color: #273746
    }
    .quasar-btn-inicio-8 {
        background-color: #2E4053
    }
    .quasar-btn-inicio-9 {
    background-color: #2C3E50
    }
    .quasar-btn-inicio-10 {
        background-color: #34495E
    }
    .quasar-btn-inicio-11 {
        background-color: #566573 
    }
  </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container-fluid">
          <div class="row">
                <div class="col-sm-4 col-md-4">
                    <div class="row">        
                        <div class="col-sm-6" style="background-color: white;">
                            <img src="Imagenes/imgarriba1.png" class="img-responsive" style="height:100%"/>
                        </div>
                        <div class="col-sm-6" style="background-color: white;">
                            <img src="Imagenes/imgarriba2.png" class="img-responsive" style="height:100%"/>
                        </div>
                    </div>
                    <div class="row">        
                        <div class="col-sm-12" style="padding: 0px 0px;">
                            <img src="Imagenes/imgabajo.jpg" class="img-responsive" style="width:100%"/>
                        </div>
                    </div>
                </div>
                <div class="col-sm-8 col-md-8">
                    <div class="row">        
                         <div class="col-sm-2" style="background-color: transparent;">
                            <div style="position: relative; width: 100%; height: 75px">
                                <h1 style="position: absolute; bottom: 0; left: 5px; color: white">Inicio</h1>
                            </div>
                        </div>
                        <div class="col-sm-10">
                        </div>
                    </div>
                    <div class="row">        
                         <div class="col-sm-6 col-md-4" style="padding: 2px 3px;">
                            <div class="quasar-btn-inicio quasar-btn-inicio-1" onclick="MostrarPagina('', '')">
                                <i class="fas fa-file-invoice quasar-icono-btn-inicio"></i>
                                <span class="quasar-texto-btn-inicio">Factura<br/>con Stock</span>
                            </div>
                        </div>
                        <div class="col-sm-3 col-md-2" style="padding: 2px 3px;;">
                            <div class="quasar-btn-inicio quasar-btn-inicio-2" onclick="MostrarPagina('', '')">
                                <i class="fas fa-boxes quasar-icono-btn-inicio"></i>
                                <i class="fas fa-search quasar-icono-2-btn-inicio"></i>
                                <span class="quasar-texto-btn-inicio">Consulta<br/>de Stock</span>
                            </div>
                        </div>
                        <div class="col-sm-3 col-md-6" style="padding: 2px 3px;;">
                        </div>
                    </div>
                    <div class="row">        
                         <div class="col-sm-3 col-md-2" style="padding: 2px 3px;">
                            <div class="quasar-btn-inicio quasar-btn-inicio-3" onclick="MostrarPagina('', '')">
                                <i class="fas fa-file-invoice-dollar quasar-icono-btn-inicio"></i>
                                <span class="quasar-texto-btn-inicio">Cobranza</span>
                            </div>
                        </div>
                        <div class="col-sm-3 col-md-2" style="padding: 2px 3px;;">
                            <div class="quasar-btn-inicio quasar-btn-inicio-4" onclick="MostrarPagina('', '')">
                                <i class="fas fa-clipboard-list quasar-icono-btn-inicio"></i>
                                <span class="quasar-texto-btn-inicio">Actualización<br/>de Pedidos</span>
                            </div>
                        </div>
                        <div class="col-sm-3 col-md-2" style="padding: 2px 3px;;">
                            <div class="quasar-btn-inicio quasar-btn-inicio-5" onclick="MostrarPagina('', '')">
                                <i class="fas fa-trash-alt quasar-icono-btn-inicio"></i>
                                <span class="quasar-texto-btn-inicio ">Desechar<br/>Pendiente<br>de Pedido</span>
                            </div>
                        </div>
                        <div class="col-sm-3 col-md-6">
                        </div>                        
                    </div>
                    <div class="row">        
                         <div class="col-sm-3 col-md-2" style="padding: 2px 3px;">
                            <div class="quasar-btn-inicio quasar-btn-inicio-6" onclick="MostrarPagina('', '')">
                                <i class="fas fa-university quasar-icono-btn-inicio"></i>
                                <span class="quasar-texto-btn-inicio">Depósitos<br/>Bancarios</span>
                            </div>
                        </div>
                        <div class="col-sm-3 col-md-2" style="padding: 2px 3px;;">
                            <div class="quasar-btn-inicio quasar-btn-inicio-7" onclick="MostrarPagina('', '')">
                                <i class="fas fa-warehouse quasar-icono-btn-inicio"></i>
                                <i class="fas fa-long-arrow-alt-left quasar-icono-2-btn-inicio"></i>
                                <span class="quasar-texto-btn-inicio">Ingreso Cambio<br/>de Depósito</span>
                            </div>
                        </div>
                        <div class="col-sm-3 col-md-2" style="padding: 2px 3px;;">
                            <div class="quasar-btn-inicio quasar-btn-inicio-8" onclick="MostrarPagina('', '')">
                                <i class="fas fa-warehouse quasar-icono-btn-inicio"></i>
                                <i class="fas fa-long-arrow-alt-right quasar-icono-2-btn-inicio"></i>
                                <span class="quasar-texto-btn-inicio">Egreso Cambio<br/>de Depósito</span>
                            </div>
                        </div>
                        <div class="col-sm-3 col-md-6">
                        </div>                        
                    </div>
                    <div class="row">        
                         <div class="col-sm-3 col-md-2" style="padding: 2px 3px;">
                            <div class="quasar-btn-inicio quasar-btn-inicio-9" onclick="MostrarPagina('frmgenProvincias', 'Provincias')">
                                <i class="fas fa-cash-register quasar-icono-btn-inicio"></i>
                                <span class="quasar-texto-btn-inicio">Apertura<br/>de Caja</span>
                            </div>
                        </div>
                        <div class="col-sm-2" style="padding: 2px 3px;;">
                            <div class="quasar-btn-inicio quasar-btn-inicio-10" onclick="MostrarPagina('frmpruPaises', 'Paises')">
                                <i class="fas fa-cash-register quasar-icono-btn-inicio"></i>
                                <i class="fas fa-times quasar-icono-btn-inicio" style="color:black"></i>
                                <span class="quasar-texto-btn-inicio">Cierre<br/>de Caja</span>
                            </div>
                        </div>
                        <div class="col-sm-3 col-md-2">
                        </div>                                                        
                        <div class="col-sm-3 col-md-6">
                        </div>                                
                    </div>
         		</div>
                <!--div class="col-sm-4">
         		</div-->
        </div>
    </div>   
    <script type='text/javascript'>
        function MostrarPagina(pPagina, pTitulo) {
            var lIdSes = sessionStorage.getItem("idses");
            $(window)[0].parent.qprin_CrearSolapa("webfrmBasico.aspx?frm=" + pPagina + "&pref=" + lIdSes, pTitulo);
        }

        $(function () {
        })
    </script>     
    </form>
</body>
</html>
