using HtmlAgilityPack;
using System.IO.Compression;
using System.Net;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public static class HTML
{
    public static string html = "<?xml version=\"1.0\" encoding=\"iso-8859-1\"?>\r\n<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n\r\n<html>\r\n<head>\r\n<title>Mesa de Entradas Virtual</title>\r\n<script type=\"text/javascript\">\r\n<!--\r\n\r\nestilo=\"estilo.css\";\r\n\r\nif (screen.availWidth <= 800) {estilo=\"estilo800600.css\"};\r\n\r\ndocument.write(\"<link rel=\\\"stylesheet\\\" href=\\\"\" + estilo + \"\\\" />\")\r\n\r\n-->\r\n</script>\r\n<script type=\"text/javascript\" src=\"mev.js?V=5\">\r\n<!--\r\n//-->\r\n</script>\r\n<script>\r\n  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){\r\n  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),\r\n  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)\r\n  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');\r\n \r\n  ga('create', 'UA-52485560-3', 'auto');\r\n  ga('send', 'pageview');\r\n \r\n</script>\r\n\r\n</head>\r\n<body>\r\n<link rel=\"stylesheet\" href=\"estilo2014.css\" />\r\n\r\n\r\n\r\n<script type=\"text/javascript\">\r\n<!--\r\nvar estilo = \"estilo2014.css\";\r\nif (screen.availWidth <= 1024) {estilo=\"estilomenor1024.css\"};\r\ndocument.write(\"<link rel=\\\"stylesheet\\\" href=\\\"\" + estilo + \"\\\" />\")\r\n-->\r\n</script>\r\n\r\n<table class=\"pegada\"><tr><td class=\"fondonuevo\" style=\"text-align:center\">\r\n<script type=\"text/javascript\">\r\n<!--\r\nalto = \"169px\";\r\nancho = \"1104px\";\r\nif (screen.availWidth <= 1024) {ancho=\"1000px\"; alto=\"153px\"};\r\nif (screen.availWidth <= 800) {ancho=\"770px\"; alto=\"117px\"};\r\n// texto = \"<img style=\\\"width: \" + ancho + \"; height: \" + alto + \";\\\" src=\\\"frisomev.jpg\\\" /></a>\";\r\n texto = \"<img src=\\\"frisomev.jpg\\\" />\";\r\ndocument.write(texto);\r\n\r\n-->\r\n\r\n</script>\r\n</td></tr><table>\r\n\r\n\r\n\r\n\r\n<p class=\"renglonchico\">&nbsp;</p>\r\n<table class=\"marco\"><tr><td><table class=\"pegada\">\r\n<tr>\r\n<td class=\"fondoazul\" width=\"33%\"><p class=\"whiteleft\">\r\n \r\nUsuarioMEV:&nbsp;<b>lcorrea</b>&nbsp;</b> \r\n    \r\n    <img src=\"images/TildeVerde.jpg\" width=\"30px\" alt=\"Usuario apto para solicitar autorizaciones de causas\" title=\"Usuario apto para solicitar autorizaciones de causas\"/><br /><b> Usuario apto para solicitar autorizaciones de causas</b>\r\n    \r\n<br> \r\nNombre:&nbsp;<b>Leandro Ernesto Correa</b> \r\n\r\n</p>\r\n</td>\r\n<td class=\"fondoazul\" width=\"34%\"><p class=\"whitecenter\">\r\n</p>\r\n</td>\r\n<td class=\"fondoazul\" width=\"33%\"><p class=\"whiteright\">\r\n</p>\r\n</td>\r\n</tr>\r\n</table>\r\n<!-- <table class=\"pegada\"><tr><td class=\"fondoazulclaro\">\r\n<p class=\"center\">\r\n</p></td></tr>\r\n</table>  -->\r\n    <p class=\"bluebig\"><strong></strong></p>    \r\n    <form action=\"POSLoguin.asp\" id=\"FORM2\" name=\"FORM2\" onsubmit=\"return verif_checks(this)\" method=\"post\">\r\n           \r\n\r\n    <table class=\"pegada\">            \r\n\r\n        \r\n\r\n        <h1><tr><td class=\"fondoclaro\" colspan=\"5\"><p class=\"center\">Seleccione el Organismo que quiera consultar</td></tr></h1>\r\n\r\n\t\t<tr><td class=\"fondoceleste\"></td><td class=\"fondoceleste\" colspan=\"2\"><p class=\"left\">\r\n\t\t<input id=\"TipoDto1\" type=\"radio\" value=\"SCJ\" name=\"TipoDto\" accesskey=\"S\"/><u>S</u>UPREMA CORTE</p></td><td class=\"fondoceleste\" colspan=\"2\"></td></tr>\r\n\t\t<tr><td class=\"fondoceleste\"></td><td class=\"fondoceleste\" colspan=\"2\"><p class=\"left\">\r\n\t\t<input id=\"TipoDto2\" type=\"radio\" value=\"LPC\" name=\"TipoDto\" accesskey =\"T\"/><u>T</u>ribunal de Casaci&oacute;n Penal</p></td><td class=\"fondoceleste\" colspan=\"2\"></td></tr>\r\n        <tr><td class=\"fondoceleste\"></td><td class=\"fondoceleste\" colspan=\"2\"><p class=\"left\">\r\n        <input id=\"TipoDto3\" type=\"radio\" value=\"PZ\"  name=\"TipoDto\" accesskey=\"Z\"/>Justicia de Pa<u>z</u></p></td><td class=\"fondoceleste\" colspan=\"2\"></td></tr>\r\n        <tr><td class=\"fondoceleste\"></td><td class=\"fondoceleste\" colspan=\"2\"><p class=\"left\">\r\n        <input id=\"TipoDto4\" type=\"radio\" value=\"CC\" name=\"TipoDto\" checked=\"checked\" accesskey=\"J\"/>Departamento <u>J</u>udicial:&nbsp;&nbsp;&nbsp;<select style=\"width:200px;\" id=\"DtoJudElegido\" size=\"1\" name=\"DtoJudElegido\" onclick=\"javascript:SetDepto();\"><option value=80 <H6>Avellaneda-Lanus</H6><option value=10 <H6>Azul</H6><option value=11 <H6>Bah�a Blanca</H6><option value=12 <H6>Dolores</H6><option value=13 <H6>Jun�n</H6><option value=14 <H6>La Matanza</H6><option value=6 <H6>La Plata</H6><option value=16 <H6>Lomas de Zamora</H6><option value=17 <H6>Mar del Plata</H6><option value=18 <H6>Mercedes</H6><option value=52 <H6>Moreno - Gral. Rodriguez</H6><option value=19 <H6>Moron</H6><option value=20 <H6>Necochea</H6><option value=21 <H6>Olavarr�a</H6><option value=22 <H6>Pergamino</H6><option value=23 <H6>Quilmes</H6><option value=24 <H6>San Isidro</H6><option value=25 <H6>San Mart�n</H6><option value=26 <H6>San Nicolas</H6><option value=27 <H6>Tandil</H6><option value=28 <H6>Trenque Lauquen</H6><option value=49 <H6>Tres Arroyos</H6><option value=29 <H6>Zarate/Campana</H6></select>\r\n        &nbsp;&nbsp;&nbsp;\r\n\t\t<input id=\"TipoF1\" type=\"CheckBox\" value=\"FF\" name=\"TipoF\" accesskey=\"F\"/>Fuero <u>F</u>amilia&nbsp;&nbsp;&nbsp;\r\n\t\t<input id=\"TipoF2\" type=\"CheckBox\" value=\"PP\" name=\"TipoP\"  accesskey=\"P\"/>Fuero <u>P</u>enal&nbsp;&nbsp;&nbsp;  \r\n\t\t<input id=\"Submit1\" name=\"Aceptar\" type=\"submit\" value=\"Aceptar\" accesskey=\"A\">\r\n        <td class=\"fondoceleste\"><p class=\"left\"></td>\r\n        </p></td></tr>\r\n        <tr><td class=\"fondoceleste\" colspan=\"5\"><p class=\"center\">&nbsp;</p></td></tr>\r\n    </table>\r\n           \r\n     <br>\r\n\r\n\t\r\n         <h2><table class=\"pegada\"><tr><td class=\"fondoclaro\" colspan=\"2\"><p class=\"center\">Men&uacute; con m&aacute;s Opciones</p></td></tr></table></h2>\r\n\r\n         <p class=\"bigcenter\">        \r\n            <a style=\"color: #003063\" href=\"ConsultasXMailAJuzgados.asp\"><strong>Consultas a Organismos</strong></A>&nbsp;&nbsp;&nbsp;&nbsp;\r\n            <a style=\"color: #003063\" href=\"AltaSolicitud.asp\">Alta Solicitud Autorizaci&oacute;nMEV</A>&nbsp;&nbsp;&nbsp;&nbsp;\r\n            <a style=\"color: #003063\" href=\"ConsSolicitudes.asp\">Consulta de Solicitudes</A>&nbsp;&nbsp;&nbsp;&nbsp;            \r\n            <a style=\"color: #003063\" href=\"ayuda.asp\">Ayuda</a>&nbsp;&nbsp;&nbsp;&nbsp;\r\n            <a style=\"color: #003063\" href=\"loguin.asp\">Desconectarse</a>\r\n        </p>\r\n        </form>    \r\n        <table class=\"pegada\"><tr><td class=\"lineaazul\" colspan=\"2\"></td></tr></table></td></tr></table></td></tr></table></body></html>";
    public static string searchPage = "\r\n<?xml version=\"1.0\" encoding=\"iso-8859-1\"?>\r\n<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n\r\n<html>\r\n<head>\r\n<title>Mesa de Entradas Virtual</title>\r\n<script type=\"text/javascript\">\r\n<!--\r\n\r\nestilo=\"estilo.css\";\r\n\r\nif (screen.availWidth <= 800) {estilo=\"estilo800600.css\"};\r\n\r\ndocument.write(\"<link rel=\\\"stylesheet\\\" href=\\\"\" + estilo + \"\\\" />\")\r\n\r\n-->\r\n</script>\r\n<script type=\"text/javascript\" src=\"mev.js?V=5\">\r\n<!--\r\n//-->\r\n</script>\r\n<script>\r\n  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){\r\n  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),\r\n  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)\r\n  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');\r\n \r\n  ga('create', 'UA-52485560-3', 'auto');\r\n  ga('send', 'pageview');\r\n \r\n</script>\r\n\r\n<SCRIPT type=text/javascript>\r\n<!--\r\n  if(navigator.appName == \"Netscape\"){\r\n  document.captureEvents(Event.MOUSEMOVE);\r\n  document.onmousemove = netscapeMouseMove;}\r\n\r\nfunction netscapeMouseMove(e) {\r\n  document.puntero.y.value = e.clientY + document.body.scrollTop + document.documentElement.scrollTop + 5;\r\n  document.puntero.x.value = e.clientX + document.body.scrollLeft + document.documentElement.scrollLeft - 50;} \r\n\r\nfunction MM_findObj(n, d) { //v4.01\r\n  var p,i,x;  if(!d) d=document; if((p=n.indexOf(\"?\"))>0&&parent.frames.length) {\r\n    d=parent.frames[n.substring(p+1)].document; n=n.substring(0,p);}\r\n  if(!(x=d[n])&&d.all) x=d.all[n]; for (i=0;!x&&i<d.forms.length;i++) x=d.forms[i][n];\r\n  for(i=0;!x&&d.layers&&i<d.layers.length;i++) x=MM_findObj(n,d.layers[i].document);\r\n  if(!x && d.getElementById) x=d.getElementById(n); return x;\r\n}\r\n\r\nfunction MM_showHideLayers() { //v6.0\r\n  var i,p,v,x,y,obj,args=MM_showHideLayers.arguments;\r\n  if(navigator.appName == \"Netscape\")\r\n  {y = document.puntero.y.value;\r\n  x = document.puntero.x.value;}\r\n  else {y = window.event.clientY + document.body.scrollTop + document.documentElement.scrollTop + 5;\r\n  x = window.event.clientX + document.body.scrollLeft + document.documentElement.scrollLeft - 50;}\r\n  for (i=0; i<(args.length-2); i+=3) if ((obj=MM_findObj(args[i]))!=null) { v=args[i+2];\r\n  if (obj.style) { obj=obj.style; v=(v=='show')?'visible':(v=='hide')?'hidden':v; }\r\n  obj.visibility=v; obj.left=(x + \"px\"); obj.top=(y + \"px\");}\r\n}\r\nfunction MM_jumpMenu(targ,selObj,restore){ //v3.0\r\n    eval(targ+\".location='\"+selObj.options[selObj.selectedIndex].value+\"'\");\r\n  if (restore) selObj.selectedIndex=0;\r\n}\r\n\r\nfunction MoverDeOrden() {\r\n    var selectBox = document.getElementById(\"selectColumna\");\r\n    var selectedValue = selectBox.options[selectBox.selectedIndex].value;\r\n    document.location.href = selectedValue;\r\n}\r\n\r\n-->\r\n</SCRIPT>\r\n</head>\r\n<body>\r\n<link rel=\"stylesheet\" href=\"estilo2014.css\" />\r\n\r\n\r\n\r\n<script type=\"text/javascript\">\r\n<!--\r\nvar estilo = \"estilo2014.css\";\r\nif (screen.availWidth <= 1024) {estilo=\"estilomenor1024.css\"};\r\ndocument.write(\"<link rel=\\\"stylesheet\\\" href=\\\"\" + estilo + \"\\\" />\")\r\n-->\r\n</script>\r\n\r\n<table class=\"pegada\"><tr><td class=\"fondonuevo\" style=\"text-align:center\">\r\n<script type=\"text/javascript\">\r\n<!--\r\nalto = \"169px\";\r\nancho = \"1104px\";\r\nif (screen.availWidth <= 1024) {ancho=\"1000px\"; alto=\"153px\"};\r\nif (screen.availWidth <= 800) {ancho=\"770px\"; alto=\"117px\"};\r\n// texto = \"<img style=\\\"width: \" + ancho + \"; height: \" + alto + \";\\\" src=\\\"frisomev.jpg\\\" /></a>\";\r\n texto = \"<img src=\\\"frisomev.jpg\\\" />\";\r\ndocument.write(texto);\r\n\r\n-->\r\n\r\n</script>\r\n</td></tr><table>\r\n\r\n\r\n\r\n\r\n<p class=\"renglonchico\">&nbsp;</p>\r\n<table class=\"marco\"><tr><td><table class=\"pegada\">\r\n<tr>\r\n<td class=\"fondoazul\" width=\"33%\"><p class=\"whiteleft\">\r\n \r\nUsuarioMEV:&nbsp;<b>lcorrea</b>&nbsp;</b> \r\n    \r\n    <img src=\"images/TildeVerde.jpg\" width=\"30px\" alt=\"Usuario apto para solicitar autorizaciones de causas\" title=\"Usuario apto para solicitar autorizaciones de causas\"/><br /><b> Usuario apto para solicitar autorizaciones de causas</b>\r\n    \r\n<br> \r\nNombre:&nbsp;<b>Leandro Ernesto Correa</b> \r\n\r\n</p>\r\n</td>\r\n<td class=\"fondoazul\" width=\"34%\"><p class=\"whitecenter\">Juzgado en lo Civil y Comercial Nro. 1\r\n</p>\r\n</td>\r\n<td class=\"fondoazul\" width=\"33%\"><p class=\"whiteright\">Quilmes\r\n</p>\r\n</td>\r\n</tr>\r\n</table>\r\n<!-- <table class=\"pegada\"><tr><td class=\"fondoazulclaro\">\r\n<p class=\"center\">Juzgado en lo Civil y Comercial Nro. 1\r\n</p></td></tr>\r\n</table>  -->\r\n    <table class=\"pegada\">\r\n        <tr><td class=\"fondoclaro\"><p class=\"center\">Expresi�n de b�squeda&nbsp;<b>Car�tula: montanari</b></p></td></tr>\r\n        \r\n            <tr><td><p class=\"bigcenter\">\r\n            <a style=\"color: #003063\" href=\"ayuda.asp\">Ayuda</a>&nbsp;&nbsp;&nbsp;&nbsp;\r\n            <a style=\"color: #003063\" href=\"Busqueda.asp\">Nueva B�squeda</a>&nbsp;&nbsp;&nbsp;&nbsp;\r\n            <a style=\"color: #003063\" href=\"Sets.asp\">Organizar Mis Sets</a>&nbsp;&nbsp;&nbsp;&nbsp;\r\n            <a style=\"color: #003063\" href=\"POSloguin.asp\">Cambiar Jurisdicci�n</a>&nbsp;&nbsp;&nbsp;&nbsp;\r\n            <a style=\"color: #003063\" href=\"loguin.asp\">Desconectarse</a></td></tr>\r\n        \r\n    </table>\r\n    <br>\r\n\t\r\n<form id=\"form1\" name=\"form1\" action=\"MuestraCausas.asp?\" method=\"post\">\r\n<font size=2 color=\"#003063\"><b>Usuario SIN Set de B�squeda</b></font>    \r\n    <table class=pegada>  \r\n    <tr><td class=left><p>Ordenar por: \r\n    <SELECT style=\"FONT-SIZE: 10px\" onchange=\"MoverDeOrden()\" name=menu1 id=\"selectColumna\">\r\n    <OPTION value=MuestraCausas.asp?radio=xCa&pagina=1&pOrden=xCa&pOrdenAD=Asc&NroColumna=1 selected>Car�tula (ascendente)</OPTION>  \r\n    <OPTION value=MuestraCausas.asp?radio=xCa&pagina=1&pOrden=xCa&pOrdenAD=Desc&NroColumna=1>Car�tula (descendente)</OPTION> \r\n    <OPTION value=MuestraCausas.asp?radio=xNc&pagina=1&pOrden=xNc&pOrdenAD=Asc&NroColumna=2>Nro.Expediente (ascendente)</OPTION>\r\n    <OPTION value=MuestraCausas.asp?radio=xNc&pagina=1&pOrden=xNc&pOrdenAD=Desc&NroColumna=2>Nro.Expediente (descendente)</OPTION>\r\n    <OPTION value=MuestraCausas.asp?radio=xFi&pagina=1&pOrden=xFi&pOrdenAD=Asc&NroColumna=3>Inicio (ascendente)</OPTION>\r\n    <OPTION value=MuestraCausas.asp?radio=xFi&pagina=1&pOrden=xFi&pOrdenAD=Desc&NroColumna=3>Inicio (descendente)</OPTION>\r\n    </SELECT>&nbsp;&nbsp;&nbsp;&nbsp;</p></td> \r\n    <td><p class=right>   \r\n    <p class=\"right\">Total Expedientes : 9&nbsp;&nbsp;&nbsp;&nbsp; \r\n    </p></td></tr></table>\r\n    \r\n<br>\r\n<TABLE class=pegada>\r\n  <TBODY>  \r\n     \r\n    <TR class=fondoceleste>\r\n    <TD colspan=\"5\" nowrap><div class=AnchoFijoCaratula>\r\n    <P class=smallleft>\r\n    <INPUT type=\"checkbox\" value=226552 name=\"Marcados\">\r\n    <INPUT type=\"hidden\" value=GAM591  ><A href=\"procesales.asp?nidCausa=226552&pidJuzgado=GAM591\">MONTANARI, GERARADO ADRIAN C/BONFOCCO, JUAN ANGEL S/ DA�OS Y PERJUICIOS - </A>\r\n    </P></div></TD></TR>\r\n    <TR class=fondoceleste>\r\n    <TD><div class=OverflowHidden><P class=smallleft>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;EN LETRA</P></div></TD>        \r\n    \r\n        <TD nowrap onmouseover=\"MM_showHideLayers('Layer1','','show')\" onmouseout=\"MM_showHideLayers('Layer1','','hide')\"><P class=smallleft>2778</P></TD>\r\n    \r\n        <TD nowrap onmouseover=\"MM_showHideLayers('Layer2','','show')\" onmouseout=\"MM_showHideLayers('Layer2','','hide')\"><P class=smallleft>2226</P></TD>\r\n            \r\n    <TD nowrap onmouseover=\"MM_showHideLayers('Layer3','','show')\" onmouseout=\"MM_showHideLayers('Layer3','','hide')\"><P class=smallleft></P></TD>\r\n    <TD><div class=OverflowHidden><A href=\"procesales.asp?nidCausa=226552&pidJuzgado=GAM591\">\r\n    <!--<TD onmouseover=\"MM_showHideLayers('Layer5','','show')\" onmouseout=\"MM_showHideLayers('Layer5','','hide')\"><div class=OverflowHidden><A href=\"procesales.asp?nidCausa=226552&pidJuzgado=GAM591\"> -->\r\n    <P class=smallleft></P></A></div></TD></TR>     \r\n    <TR>\r\n    <TD colspan=\"5\" nowrap><div class=AnchoFijoCaratula>\r\n    <P class=smallleft>\r\n    <INPUT type=\"checkbox\" value=226554 name=\"Marcados\"> \r\n    <INPUT type=\"hidden\" value=GAM591  ><A href=\"procesales.asp?nidCausa=226554&pidJuzgado=GAM591\">MONTANARI, GERARDO ADRIAN S/ DA�OS Y PERJUICIOS DEL /CUAS.(EXC.USO AUT.Y ESTADO)(98) - </A>\r\n    </P></div></TD></TR>\r\n    <TR>\r\n    <TD><div class=OverflowHidden><P class=smallleft>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;EN LETRA</P></div></TD>\r\n    \r\n        <TD nowrap onmouseover=\"MM_showHideLayers('Layer1','','show')\" onmouseout=\"MM_showHideLayers('Layer1','','hide')\"><P class=smallleft>2844</P></TD>\r\n    \r\n        <TD nowrap onmouseover=\"MM_showHideLayers('Layer2','','show')\" onmouseout=\"MM_showHideLayers('Layer2','','hide')\"><P class=smallleft>2229</P></TD>\r\n            \r\n    <TD nowrap onmouseover=\"MM_showHideLayers('Layer3','','show')\" onmouseout=\"MM_showHideLayers('Layer3','','hide')\"><P class=smallleft></P></TD>\r\n    <TD><div class=OverflowHidden><A href=\"procesales.asp?nidCausa=226554&pidJuzgado=GAM591\">\r\n    <!--<TD onmouseover=\"MM_showHideLayers('Layer5','','show')\" onmouseout=\"MM_showHideLayers('Layer5','','hide')\"><div class=OverflowHidden><A href=\"procesales.asp?nidCausa=226554&pidJuzgado=GAM591\"> -->\r\n    <P class=smallleft></P></A></div></TD>\r\n    </TR>     \r\n    <TR class=fondoceleste>\r\n    <TD colspan=\"5\" nowrap><div class=AnchoFijoCaratula>\r\n    <P class=smallleft>\r\n    <INPUT type=\"checkbox\" value=235117 name=\"Marcados\">\r\n    <INPUT type=\"hidden\" value=GAM591  ><A href=\"procesales.asp?nidCausa=235117&pidJuzgado=GAM591\">MONTANARI, LUISA S/ SUCESION AB INTESTATO (21) - </A>\r\n    </P></div></TD></TR>\r\n    <TR class=fondoceleste>\r\n    <TD><div class=OverflowHidden><P class=smallleft>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;PARALIZADA</P></div></TD>        \r\n    \r\n        <TD nowrap onmouseover=\"MM_showHideLayers('Layer1','','show')\" onmouseout=\"MM_showHideLayers('Layer1','','hide')\"><P class=smallleft>A&nbsp;-&nbsp;0&nbsp;-&nbsp;1</P></TD>\r\n    \r\n        <TD nowrap onmouseover=\"MM_showHideLayers('Layer2','','show')\" onmouseout=\"MM_showHideLayers('Layer2','','hide')\"><P class=smallleft>14118</P></TD>\r\n            \r\n    <TD nowrap onmouseover=\"MM_showHideLayers('Layer3','','show')\" onmouseout=\"MM_showHideLayers('Layer3','','hide')\"><P class=smallleft>26/11/2001</P></TD>\r\n    <TD><div class=OverflowHidden><A href=\"procesales.asp?nidCausa=235117&pidJuzgado=GAM591\">\r\n    <!--<TD onmouseover=\"MM_showHideLayers('Layer5','','show')\" onmouseout=\"MM_showHideLayers('Layer5','','hide')\"><div class=OverflowHidden><A href=\"procesales.asp?nidCausa=235117&pidJuzgado=GAM591\"> -->\r\n    <P class=smallleft>03/08/2022 - CAUSA PARALIZADA</P></A></div></TD></TR>     \r\n    <TR>\r\n    <TD colspan=\"5\" nowrap><div class=AnchoFijoCaratula>\r\n    <P class=smallleft>\r\n    <INPUT type=\"checkbox\" value=223711 name=\"Marcados\"> \r\n    <INPUT type=\"hidden\" value=GAM591  ><A href=\"procesales.asp?nidCausa=223711&pidJuzgado=GAM591\">MONTANARI, PEDRO FEDERICO S/ SUCESION AB INTESTATO (21) - </A>\r\n    </P></div></TD></TR>\r\n    <TR>\r\n    <TD><div class=OverflowHidden><P class=smallleft>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;EN LETRA</P></div></TD>\r\n    \r\n        <TD nowrap onmouseover=\"MM_showHideLayers('Layer1','','show')\" onmouseout=\"MM_showHideLayers('Layer1','','hide')\"><P class=smallleft>6310</P></TD>\r\n    \r\n        <TD nowrap onmouseover=\"MM_showHideLayers('Layer2','','show')\" onmouseout=\"MM_showHideLayers('Layer2','','hide')\"><P class=smallleft>5809</P></TD>\r\n            \r\n    <TD nowrap onmouseover=\"MM_showHideLayers('Layer3','','show')\" onmouseout=\"MM_showHideLayers('Layer3','','hide')\"><P class=smallleft>02/07/1997</P></TD>\r\n    <TD><div class=OverflowHidden><A href=\"procesales.asp?nidCausa=223711&pidJuzgado=GAM591\">\r\n    <!--<TD onmouseover=\"MM_showHideLayers('Layer5','','show')\" onmouseout=\"MM_showHideLayers('Layer5','','hide')\"><div class=OverflowHidden><A href=\"procesales.asp?nidCausa=223711&pidJuzgado=GAM591\"> -->\r\n    <P class=smallleft>15/07/1997 - RECUSACION</P></A></div></TD>\r\n    </TR>     \r\n    <TR class=fondoceleste>\r\n    <TD colspan=\"5\" nowrap><div class=AnchoFijoCaratula>\r\n    <P class=smallleft>\r\n    <INPUT type=\"checkbox\" value=248654 name=\"Marcados\">\r\n    <INPUT type=\"hidden\" value=GAM591  ><A href=\"procesales.asp?nidCausa=248654&pidJuzgado=GAM591\">MONTANARI, RUBEN EMILIO S/ SUCESION AB INTESTATO (21) - </A>\r\n    </P></div></TD></TR>\r\n    <TR class=fondoceleste>\r\n    <TD><div class=OverflowHidden><P class=smallleft>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;PARALIZADA</P></div></TD>        \r\n    \r\n        <TD nowrap onmouseover=\"MM_showHideLayers('Layer1','','show')\" onmouseout=\"MM_showHideLayers('Layer1','','hide')\"><P class=smallleft>QL&nbsp;-&nbsp;22689&nbsp;-&nbsp;8</P></TD>\r\n    \r\n        <TD nowrap onmouseover=\"MM_showHideLayers('Layer2','','show')\" onmouseout=\"MM_showHideLayers('Layer2','','hide')\"><P class=smallleft>27397</P></TD>\r\n            \r\n    <TD nowrap onmouseover=\"MM_showHideLayers('Layer3','','show')\" onmouseout=\"MM_showHideLayers('Layer3','','hide')\"><P class=smallleft>02/09/2008</P></TD>\r\n    <TD><div class=OverflowHidden><A href=\"procesales.asp?nidCausa=248654&pidJuzgado=GAM591\">\r\n    <!--<TD onmouseover=\"MM_showHideLayers('Layer5','','show')\" onmouseout=\"MM_showHideLayers('Layer5','','hide')\"><div class=OverflowHidden><A href=\"procesales.asp?nidCausa=248654&pidJuzgado=GAM591\"> -->\r\n    <P class=smallleft>08/01/2018 - CAUSA PARALIZADA</P></A></div></TD></TR>     \r\n    <TR>\r\n    <TD colspan=\"5\" nowrap><div class=AnchoFijoCaratula>\r\n    <P class=smallleft>\r\n    <INPUT type=\"checkbox\" value=221327 name=\"Marcados\"> \r\n    <INPUT type=\"hidden\" value=GAM591  ><A href=\"procesales.asp?nidCausa=221327&pidJuzgado=GAM591\">MUNICIPALIDAD DE BERAZATEGUI C/MONTANARI,GUSTAVO S/ APREMIO - </A>\r\n    </P></div></TD></TR>\r\n    <TR>\r\n    <TD><div class=OverflowHidden><P class=smallleft>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;PARALIZADA</P></div></TD>\r\n    \r\n        <TD nowrap onmouseover=\"MM_showHideLayers('Layer1','','show')\" onmouseout=\"MM_showHideLayers('Layer1','','hide')\"><P class=smallleft>3053</P></TD>\r\n    \r\n        <TD nowrap onmouseover=\"MM_showHideLayers('Layer2','','show')\" onmouseout=\"MM_showHideLayers('Layer2','','hide')\"><P class=smallleft>982</P></TD>\r\n            \r\n    <TD nowrap onmouseover=\"MM_showHideLayers('Layer3','','show')\" onmouseout=\"MM_showHideLayers('Layer3','','hide')\"><P class=smallleft>09/02/1995</P></TD>\r\n    <TD><div class=OverflowHidden><A href=\"procesales.asp?nidCausa=221327&pidJuzgado=GAM591\">\r\n    <!--<TD onmouseover=\"MM_showHideLayers('Layer5','','show')\" onmouseout=\"MM_showHideLayers('Layer5','','hide')\"><div class=OverflowHidden><A href=\"procesales.asp?nidCausa=221327&pidJuzgado=GAM591\"> -->\r\n    <P class=smallleft>27/06/2001 - AGR�GUESE Y T�NGASE PRESENTE.-</P></A></div></TD>\r\n    </TR>     \r\n    <TR class=fondoceleste>\r\n    <TD colspan=\"5\" nowrap><div class=AnchoFijoCaratula>\r\n    <P class=smallleft>\r\n    <INPUT type=\"checkbox\" value=927554 name=\"Marcados\">\r\n    <INPUT type=\"hidden\" value=GAM591  ><A href=\"procesales.asp?nidCausa=927554&pidJuzgado=GAM591\">MUNICIPALIDAD DE QUILMES  C/ MONTANARI CANDIDO S/APREMIO - </A>\r\n    </P></div></TD></TR>\r\n    <TR class=fondoceleste>\r\n    <TD><div class=OverflowHidden><P class=smallleft>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</P></div></TD>        \r\n    \r\n        <TD nowrap onmouseover=\"MM_showHideLayers('Layer1','','show')\" onmouseout=\"MM_showHideLayers('Layer1','','hide')\"><P class=smallleft>QL&nbsp;-&nbsp;19651&nbsp;-&nbsp;2012</P></TD>\r\n    \r\n        <TD nowrap onmouseover=\"MM_showHideLayers('Layer2','','show')\" onmouseout=\"MM_showHideLayers('Layer2','','hide')\"><P class=smallleft>QL&nbsp;-&nbsp;19651&nbsp;-&nbsp;2012</P></TD>\r\n            \r\n    <TD nowrap onmouseover=\"MM_showHideLayers('Layer3','','show')\" onmouseout=\"MM_showHideLayers('Layer3','','hide')\"><P class=smallleft>27/05/2019 10:45:37</P></TD>\r\n    <TD><div class=OverflowHidden><A href=\"procesales.asp?nidCausa=927554&pidJuzgado=GAM591\">\r\n    <!--<TD onmouseover=\"MM_showHideLayers('Layer5','','show')\" onmouseout=\"MM_showHideLayers('Layer5','','hide')\"><div class=OverflowHidden><A href=\"procesales.asp?nidCausa=927554&pidJuzgado=GAM591\"> -->\r\n    <P class=smallleft></P></A></div></TD></TR>     \r\n    <TR>\r\n    <TD colspan=\"5\" nowrap><div class=AnchoFijoCaratula>\r\n    <P class=smallleft>\r\n    <INPUT type=\"checkbox\" value=235744 name=\"Marcados\"> \r\n    <INPUT type=\"hidden\" value=GAM591  ><A href=\"procesales.asp?nidCausa=235744&pidJuzgado=GAM591\">MUNICIPALIDAD DE QUILMES C/  MONTANARI, SANDRA S/ APREMIO - </A>\r\n    </P></div></TD></TR>\r\n    <TR>\r\n    <TD><div class=OverflowHidden><P class=smallleft>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;PARALIZADA</P></div></TD>\r\n    \r\n        <TD nowrap onmouseover=\"MM_showHideLayers('Layer1','','show')\" onmouseout=\"MM_showHideLayers('Layer1','','hide')\"><P class=smallleft>66035</P></TD>\r\n    \r\n        <TD nowrap onmouseover=\"MM_showHideLayers('Layer2','','show')\" onmouseout=\"MM_showHideLayers('Layer2','','hide')\"><P class=smallleft>14733</P></TD>\r\n            \r\n    <TD nowrap onmouseover=\"MM_showHideLayers('Layer3','','show')\" onmouseout=\"MM_showHideLayers('Layer3','','hide')\"><P class=smallleft>30/04/2002</P></TD>\r\n    <TD><div class=OverflowHidden><A href=\"procesales.asp?nidCausa=235744&pidJuzgado=GAM591\">\r\n    <!--<TD onmouseover=\"MM_showHideLayers('Layer5','','show')\" onmouseout=\"MM_showHideLayers('Layer5','','hide')\"><div class=OverflowHidden><A href=\"procesales.asp?nidCausa=235744&pidJuzgado=GAM591\"> -->\r\n    <P class=smallleft>08/04/2011 - CAUSA PARALIZADA</P></A></div></TD>\r\n    </TR>     \r\n    <TR class=fondoceleste>\r\n    <TD colspan=\"5\" nowrap><div class=AnchoFijoCaratula>\r\n    <P class=smallleft>\r\n    <INPUT type=\"checkbox\" value=237679 name=\"Marcados\">\r\n    <INPUT type=\"hidden\" value=GAM591  ><A href=\"procesales.asp?nidCausa=237679&pidJuzgado=GAM591\">MUNICIPALIDAD DE QUILMES C/ MONTANARI, CANDIDO AGUSTIN S/ APREMIO - </A>\r\n    </P></div></TD></TR>\r\n    <TR class=fondoceleste>\r\n    <TD><div class=OverflowHidden><P class=smallleft>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;PARALIZADA</P></div></TD>        \r\n    \r\n        <TD nowrap onmouseover=\"MM_showHideLayers('Layer1','','show')\" onmouseout=\"MM_showHideLayers('Layer1','','hide')\"><P class=smallleft>0</P></TD>\r\n    \r\n        <TD nowrap onmouseover=\"MM_showHideLayers('Layer2','','show')\" onmouseout=\"MM_showHideLayers('Layer2','','hide')\"><P class=smallleft>16626</P></TD>\r\n            \r\n    <TD nowrap onmouseover=\"MM_showHideLayers('Layer3','','show')\" onmouseout=\"MM_showHideLayers('Layer3','','hide')\"><P class=smallleft>17/06/2003</P></TD>\r\n    <TD><div class=OverflowHidden><A href=\"procesales.asp?nidCausa=237679&pidJuzgado=GAM591\">\r\n    <!--<TD onmouseover=\"MM_showHideLayers('Layer5','','show')\" onmouseout=\"MM_showHideLayers('Layer5','','hide')\"><div class=OverflowHidden><A href=\"procesales.asp?nidCausa=237679&pidJuzgado=GAM591\"> -->\r\n    <P class=smallleft>28/01/2010 - ARCHIVO</P></A></div></TD></TR>\r\n</TBODY></TABLE>\r\n<DIV class=fondoazul id=Layer1 style=\"Z-INDEX: 1; LEFT: 0px; VISIBILITY: hidden; COLOR: #003063; POSITION: absolute; TOP: 0px\"><P class=white>&nbsp;N� de Receptor�a&nbsp;</P></DIV>\r\n<DIV class=fondoazul id=Layer2 style=\"Z-INDEX: 1; LEFT: 0px; VISIBILITY: hidden; COLOR: #003063; POSITION: absolute; TOP: 0px\"><P class=white>&nbsp;N� de Expediente&nbsp;</P></DIV>\r\n<DIV class=fondoazul id=Layer3 style=\"Z-INDEX: 1; LEFT: 0px; VISIBILITY: hidden; COLOR: #003063; POSITION: absolute; TOP: 0px\"><P class=white>&nbsp;Fecha de Inicio&nbsp;</P></DIV>\r\n<DIV class=fondoazul id=Layer4 style=\"Z-INDEX: 1; LEFT: 0px; VISIBILITY: hidden; COLOR: #003063; POSITION: absolute; TOP: 0px\"><P class=white>&nbsp;Estado&nbsp;</P></DIV>\r\n<DIV class=fondoazul id=Layer5 style=\"Z-INDEX: 1; LEFT: 0px; VISIBILITY: hidden; COLOR: #003063; POSITION: absolute; TOP: 0px\"><P class=white>&nbsp;Ultimo despacho &gt;&gt;Ampliar&nbsp;</P></DIV>\r\n\r\n<div class=\"renglon\"></div>\r\n\r\n<p class=\"right\">Total Expedientes : 9&nbsp;&nbsp;&nbsp;&nbsp; \r\n\r\n</form>\r\n\r\n\r\n\r\n<table class=\"pegada\"><tr><td class=\"lineaazul\" colspan=\"2\"></td></tr></table>\r\n</td></tr></table></td></tr></table></body></html>";

}
//var httpClientHandler = new HttpClientHandler
//{
//    CookieContainer = new CookieContainer(),
//    UseCookies = true,
//    AllowAutoRedirect = true
//};



//var client = new HttpClient(httpClientHandler);
//client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36");

//var cookie = new Cookie("ASPSESSIONIDQQRCRBSD", "IOIICHJAMDMFHOHDIBFEKBOA", "/", "mev.scba.gov.ar");
//httpClientHandler.CookieContainer.Add(cookie);

//var headers = new System.Collections.Generic.Dictionary<string, string>
//{
//    { "authority", "mev.scba.gov.ar" },
//    { "method", "GET" },
//    { "path", "/procesales.asp?nidCausa=233389&pidJuzgado=GAM591" },
//    { "scheme", "https" },
//    { "accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7" },
//    { "accept-encoding", "gzip, deflate, br" },
//    { "accept-language", "en-US,en;q=0.9,es;q=0.8" },
//    { "referer", "https://mev.scba.gov.ar/MuestraCausas.asp?radio=xCa&pOrden=xCa&pOrdenAD=Asc" },
//    { "sec-ch-ua", "\"Chromium\";v=\"110\", \"Not A(Brand\";v=\"24\", \"Google Chrome\";v=\"110\"" },
//    { "sec-ch-ua-mobile", "?0" },
//    { "sec-ch-ua-platform", "\"Windows\"" },
//    { "sec-fetch-dest", "document" },
//    { "sec-fetch-mode", "navigate" },
//    { "sec-fetch-site", "same-origin" },
//    { "sec-fetch-user", "?1" },
//    { "upgrade-insecure-requests", "1" },
//};

//foreach (var header in headers)
//{
//    client.DefaultRequestHeaders.TryAddWithoutValidation(header.Key, header.Value);
//}

//var response = await client.GetAsync("https://mev.scba.gov.ar/procesales.asp?nidCausa=233389&pidJuzgado=GAM591");

//var contentStream = await response.Content.ReadAsStreamAsync();

//// Check if the response is compressed
//if (response.Content.Headers.ContentEncoding.Contains("gzip"))
//{
//    contentStream = new GZipStream(contentStream, CompressionMode.Decompress);
//}
//else if (response.Content.Headers.ContentEncoding.Contains("deflate"))
//{
//    contentStream = new DeflateStream(contentStream, CompressionMode.Decompress);
//}

//using (var reader = new StreamReader(contentStream))
//{
//    var content = await reader.ReadToEndAsync();
//    var htmlDocument = new HtmlDocument();
//    htmlDocument.LoadHtml(content);

//    var tableRows = htmlDocument.DocumentNode.SelectNodes("//table[@class='pegada']/tr");
//    var tramites = new List<Tramite>();

//    foreach (var row in tableRows.Skip(1)) // skip first row as it contains headers
//    {
//        var columns = row.Descendants("td").ToList();

//        var fechaString = columns[0].InnerText;
//        var fecha = DateTime.Parse(fechaString);

//        var fojasString = columns[1].InnerText;
//        var fojas = int.Parse(fojasString);

//        var descripcion = columns[2].InnerText.Trim();

//        var tramite = new Tramite
//        {
//            Fecha = fecha,
//            Fojas = fojas,
//            Descripcion = descripcion
//        };

//        tramites.Add(tramite);
//    }
//    tramites.ForEach(t => Console.WriteLine(t));
//}


//public class LoginHandler
//{
//    public async Task<Cookie> GetCookie(string username, string password, Cookie cookie)
//    {
//        var handler = new HttpClientHandler
//        {
//            UseCookies = true,
//            CookieContainer = new CookieContainer()
//        };
//        handler.CookieContainer.Add(cookie);
//        var httpClient = new HttpClient(handler);
//        httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36");
//        httpClient.DefaultRequestHeaders.Add("Referer", "https://mev.scba.gov.ar/loguin.asp");
//        httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
//        httpClient.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.9,es;q=0.8");
//        httpClient.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");

//        var content = new FormUrlEncodedContent(new[]
//        {
//    new KeyValuePair<string, string>("usuario", "lcorrea"),
//    new KeyValuePair<string, string>("clave", "iPhone3G"),
//    new KeyValuePair<string, string>("DeptoRegistrado", "QU")
//});

//        var response = await httpClient.PostAsync("https://mev.scba.gov.ar/loguin.asp?familiadepto=", content);
//        response.EnsureSuccessStatusCode();
//        var c = await response.Content.ReadAsStreamAsync();

//        if (response.Content.Headers.ContentEncoding.Contains("gzip"))
//        {
//            c = new GZipStream(c, CompressionMode.Decompress);
//        }
//        else if (response.Content.Headers.ContentEncoding.Contains("deflate"))
//        {
//            c = new DeflateStream(c, CompressionMode.Decompress);
//        }

//        using (var reader = new StreamReader(c))
//        {
//            var htmlContent = await reader.ReadToEndAsync();
//            var htmlDocument = new HtmlDocument();
//            htmlDocument.LoadHtml(htmlContent);

//            var options = htmlDocument.DocumentNode.SelectNodes("//option");
//            var deptos = options.Select(x => x.SelectNodes("//h6").FirstOrDefault());
//            //.Select(node=> new
//            //{
//            //    Codigo = node.Attributes["value"],
//            //    //Nombre = node.SelectNodes("//h6").FirstOrDefault()?.InnerText
//            //}).ToList();            
//            var strub = ";";
//        }





//        content = new(new[]
//    {
//            new KeyValuePair<string, string>("TipoDto", "CC"),
//            new KeyValuePair<string, string>("DtoJudElegido", "23"),
//            new KeyValuePair<string, string>("Aceptar", "Aceptar")
//        });
//        response = await httpClient.PostAsync("https://mev.scba.gov.ar/POSLoguin.asp", content);
//        response.EnsureSuccessStatusCode();
//        content = new(new[]
//        {
//            new KeyValuePair<string, string>("OpcionBusqueda", "0"),
//            new KeyValuePair<string, string>("busca", "montanari"),
//            new KeyValuePair<string, string>("JuzgadoElegido", "GAM591"),
//            new KeyValuePair<string, string>("radio", "xCa"),
//            new KeyValuePair<string, string>("caratula", "montanari"),
//            new KeyValuePair<string, string>("Ncausa", ""),
//            new KeyValuePair<string, string>("Ninterno", ""),
//            new KeyValuePair<string, string>("Set", ""),
//            new KeyValuePair<string, string>("Desde", "2/3/2023"),
//            new KeyValuePair<string, string>("Hasta", "4/3/2023"),
//            new KeyValuePair<string, string>("SetNovedades", ""),
//            new KeyValuePair<string, string>("TipoCausa", "Ac"),
//            new KeyValuePair<string, string>("Buscar", "Buscar"),
//        });
//        response = await httpClient.PostAsync("https://mev.scba.gov.ar/busqueda.asp", content);

//        var contentStream = await response.Content.ReadAsStreamAsync();

//        // Check if the response is compressed
//        if (response.Content.Headers.ContentEncoding.Contains("gzip"))
//        {
//            contentStream = new GZipStream(contentStream, CompressionMode.Decompress);
//        }
//        else if (response.Content.Headers.ContentEncoding.Contains("deflate"))
//        {
//            contentStream = new DeflateStream(contentStream, CompressionMode.Decompress);
//        }

//        using (var reader = new StreamReader(contentStream))
//        {
//            var htmlContent = await reader.ReadToEndAsync();
//            var htmlDocument = new HtmlDocument();
//            htmlDocument.LoadHtml(htmlContent);

//            var tableRows = htmlDocument.DocumentNode.SelectNodes("//table[@class='pegada']/tr");
//            var tramites = new List<Tramite>();

//            foreach (var row in tableRows.Skip(1)) // skip first row as it contains headers
//            {
//                var columns = row.Descendants("td").ToList();

//                var fechaString = columns[0].InnerText;
//                var fecha = DateTime.Parse(fechaString);

//                var fojasString = columns[1].InnerText;
//                var fojas = int.Parse(fojasString);

//                var descripcion = columns[2].InnerText.Trim();

//                var tramite = new Tramite
//                {
//                    Fecha = fecha,
//                    Fojas = fojas,
//                    Descripcion = descripcion
//                };

//                tramites.Add(tramite);
//            }
//            tramites.ForEach(t => Console.WriteLine(t));
//        }
//        return cookie;
//    }
//}



public class LoginHandler
{
    public async Task<Cookie> GetCookie(string username, string password, Cookie cookie)
    {
        var handler = new HttpClientHandler
        {
            UseCookies = true,
            CookieContainer = new CookieContainer()
        };
        handler.CookieContainer.Add(cookie);
        var httpClient = new HttpClient(handler);
        httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36");
        httpClient.DefaultRequestHeaders.Add("Referer", "https://mev.scba.gov.ar/loguin.asp");
        httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
        httpClient.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.9,es;q=0.8");
        httpClient.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");

        var content = new FormUrlEncodedContent(new[]
        {
             new KeyValuePair<string, string>("usuario", "lcorrea"),
             new KeyValuePair<string, string>("clave", "iPhone3G"),
             new KeyValuePair<string, string>("DeptoRegistrado", "QU")
        });

        var response = await httpClient.PostAsync("https://mev.scba.gov.ar/loguin.asp?familiadepto=", content);
        response.EnsureSuccessStatusCode();

        content = new(new[]
        {
            new KeyValuePair<string, string>("TipoDto", "CC"),
            new KeyValuePair<string, string>("DtoJudElegido", "23"),
            new KeyValuePair<string, string>("Aceptar", "Aceptar")
        });
        response = await httpClient.PostAsync("https://mev.scba.gov.ar/POSLoguin.asp", content);
        response.EnsureSuccessStatusCode();
        content = new(new[]
        {
            new KeyValuePair<string, string>("OpcionBusqueda", "0"),
            new KeyValuePair<string, string>("busca", "montanari"),
            new KeyValuePair<string, string>("JuzgadoElegido", "GAM591"),
            new KeyValuePair<string, string>("radio", "xCa"),
            new KeyValuePair<string, string>("caratula", "montanari"),
            new KeyValuePair<string, string>("Ncausa", ""),
            new KeyValuePair<string, string>("Ninterno", ""),
            new KeyValuePair<string, string>("Set", ""),
            new KeyValuePair<string, string>("Desde", "2/3/2023"),
            new KeyValuePair<string, string>("Hasta", "4/3/2023"),
            new KeyValuePair<string, string>("SetNovedades", ""),
            new KeyValuePair<string, string>("TipoCausa", "Ac"),
            new KeyValuePair<string, string>("Buscar", "Buscar"),
        });
        response = await httpClient.PostAsync("https://mev.scba.gov.ar/busqueda.asp", content);

        var contentStream = await response.Content.ReadAsStreamAsync();

        // Check if the response is compressed
        if (response.Content.Headers.ContentEncoding.Contains("gzip"))
        {
            contentStream = new GZipStream(contentStream, CompressionMode.Decompress);
        }
        else if (response.Content.Headers.ContentEncoding.Contains("deflate"))
        {
            contentStream = new DeflateStream(contentStream, CompressionMode.Decompress);
        }

        using (var reader = new StreamReader(contentStream))
        {
            var htmlContent = await reader.ReadToEndAsync();
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(htmlContent);

            var tableRows = htmlDocument.DocumentNode.SelectNodes("//table[@class='pegada']/tr");
            var tramites = new List<Tramite>();

            foreach (var row in tableRows.Skip(1)) // skip first row as it contains headers
            {
                var columns = row.Descendants("td").ToList();

                var fechaString = columns[0].InnerText;
                var fecha = DateTime.Parse(fechaString);

                var fojasString = columns[1].InnerText;
                var fojas = int.Parse(fojasString);

                var descripcion = columns[2].InnerText.Trim();

                var tramite = new Tramite
                {
                    Fecha = fecha,
                    Fojas = fojas,
                    Descripcion = descripcion
                };

                tramites.Add(tramite);
            }
            tramites.ForEach(t => Console.WriteLine(t));
        }
        return cookie;
    }
}
