using HtmlAgilityPack;
using System.IO.Compression;
using System.Net;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;

public static class HTML
{
    public static string html = "<?xml version=\"1.0\" encoding=\"iso-8859-1\"?>\r\n<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n\r\n<html>\r\n<head>\r\n<title>Mesa de Entradas Virtual</title>\r\n<script type=\"text/javascript\">\r\n<!--\r\n\r\nestilo=\"estilo.css\";\r\n\r\nif (screen.availWidth <= 800) {estilo=\"estilo800600.css\"};\r\n\r\ndocument.write(\"<link rel=\\\"stylesheet\\\" href=\\\"\" + estilo + \"\\\" />\")\r\n\r\n-->\r\n</script>\r\n<script type=\"text/javascript\" src=\"mev.js?V=5\">\r\n<!--\r\n//-->\r\n</script>\r\n<script>\r\n  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){\r\n  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),\r\n  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)\r\n  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');\r\n \r\n  ga('create', 'UA-52485560-3', 'auto');\r\n  ga('send', 'pageview');\r\n \r\n</script>\r\n\r\n</head>\r\n<body>\r\n<link rel=\"stylesheet\" href=\"estilo2014.css\" />\r\n\r\n\r\n\r\n<script type=\"text/javascript\">\r\n<!--\r\nvar estilo = \"estilo2014.css\";\r\nif (screen.availWidth <= 1024) {estilo=\"estilomenor1024.css\"};\r\ndocument.write(\"<link rel=\\\"stylesheet\\\" href=\\\"\" + estilo + \"\\\" />\")\r\n-->\r\n</script>\r\n\r\n<table class=\"pegada\"><tr><td class=\"fondonuevo\" style=\"text-align:center\">\r\n<script type=\"text/javascript\">\r\n<!--\r\nalto = \"169px\";\r\nancho = \"1104px\";\r\nif (screen.availWidth <= 1024) {ancho=\"1000px\"; alto=\"153px\"};\r\nif (screen.availWidth <= 800) {ancho=\"770px\"; alto=\"117px\"};\r\n// texto = \"<img style=\\\"width: \" + ancho + \"; height: \" + alto + \";\\\" src=\\\"frisomev.jpg\\\" /></a>\";\r\n texto = \"<img src=\\\"frisomev.jpg\\\" />\";\r\ndocument.write(texto);\r\n\r\n-->\r\n\r\n</script>\r\n</td></tr><table>\r\n\r\n\r\n\r\n\r\n<p class=\"renglonchico\">&nbsp;</p>\r\n<table class=\"marco\"><tr><td><table class=\"pegada\">\r\n<tr>\r\n<td class=\"fondoazul\" width=\"33%\"><p class=\"whiteleft\">\r\n \r\nUsuarioMEV:&nbsp;<b>lcorrea</b>&nbsp;</b> \r\n    \r\n    <img src=\"images/TildeVerde.jpg\" width=\"30px\" alt=\"Usuario apto para solicitar autorizaciones de causas\" title=\"Usuario apto para solicitar autorizaciones de causas\"/><br /><b> Usuario apto para solicitar autorizaciones de causas</b>\r\n    \r\n<br> \r\nNombre:&nbsp;<b>Leandro Ernesto Correa</b> \r\n\r\n</p>\r\n</td>\r\n<td class=\"fondoazul\" width=\"34%\"><p class=\"whitecenter\">\r\n</p>\r\n</td>\r\n<td class=\"fondoazul\" width=\"33%\"><p class=\"whiteright\">\r\n</p>\r\n</td>\r\n</tr>\r\n</table>\r\n<!-- <table class=\"pegada\"><tr><td class=\"fondoazulclaro\">\r\n<p class=\"center\">\r\n</p></td></tr>\r\n</table>  -->\r\n    <p class=\"bluebig\"><strong></strong></p>    \r\n    <form action=\"POSLoguin.asp\" id=\"FORM2\" name=\"FORM2\" onsubmit=\"return verif_checks(this)\" method=\"post\">\r\n           \r\n\r\n    <table class=\"pegada\">            \r\n\r\n        \r\n\r\n        <h1><tr><td class=\"fondoclaro\" colspan=\"5\"><p class=\"center\">Seleccione el Organismo que quiera consultar</td></tr></h1>\r\n\r\n\t\t<tr><td class=\"fondoceleste\"></td><td class=\"fondoceleste\" colspan=\"2\"><p class=\"left\">\r\n\t\t<input id=\"TipoDto1\" type=\"radio\" value=\"SCJ\" name=\"TipoDto\" accesskey=\"S\"/><u>S</u>UPREMA CORTE</p></td><td class=\"fondoceleste\" colspan=\"2\"></td></tr>\r\n\t\t<tr><td class=\"fondoceleste\"></td><td class=\"fondoceleste\" colspan=\"2\"><p class=\"left\">\r\n\t\t<input id=\"TipoDto2\" type=\"radio\" value=\"LPC\" name=\"TipoDto\" accesskey =\"T\"/><u>T</u>ribunal de Casaci&oacute;n Penal</p></td><td class=\"fondoceleste\" colspan=\"2\"></td></tr>\r\n        <tr><td class=\"fondoceleste\"></td><td class=\"fondoceleste\" colspan=\"2\"><p class=\"left\">\r\n        <input id=\"TipoDto3\" type=\"radio\" value=\"PZ\"  name=\"TipoDto\" accesskey=\"Z\"/>Justicia de Pa<u>z</u></p></td><td class=\"fondoceleste\" colspan=\"2\"></td></tr>\r\n        <tr><td class=\"fondoceleste\"></td><td class=\"fondoceleste\" colspan=\"2\"><p class=\"left\">\r\n        <input id=\"TipoDto4\" type=\"radio\" value=\"CC\" name=\"TipoDto\" checked=\"checked\" accesskey=\"J\"/>Departamento <u>J</u>udicial:&nbsp;&nbsp;&nbsp;<select style=\"width:200px;\" id=\"DtoJudElegido\" size=\"1\" name=\"DtoJudElegido\" onclick=\"javascript:SetDepto();\"><option value=80 <H6>Avellaneda-Lanus</H6><option value=10 <H6>Azul</H6><option value=11 <H6>Bah�a Blanca</H6><option value=12 <H6>Dolores</H6><option value=13 <H6>Jun�n</H6><option value=14 <H6>La Matanza</H6><option value=6 <H6>La Plata</H6><option value=16 <H6>Lomas de Zamora</H6><option value=17 <H6>Mar del Plata</H6><option value=18 <H6>Mercedes</H6><option value=52 <H6>Moreno - Gral. Rodriguez</H6><option value=19 <H6>Moron</H6><option value=20 <H6>Necochea</H6><option value=21 <H6>Olavarr�a</H6><option value=22 <H6>Pergamino</H6><option value=23 <H6>Quilmes</H6><option value=24 <H6>San Isidro</H6><option value=25 <H6>San Mart�n</H6><option value=26 <H6>San Nicolas</H6><option value=27 <H6>Tandil</H6><option value=28 <H6>Trenque Lauquen</H6><option value=49 <H6>Tres Arroyos</H6><option value=29 <H6>Zarate/Campana</H6></select>\r\n        &nbsp;&nbsp;&nbsp;\r\n\t\t<input id=\"TipoF1\" type=\"CheckBox\" value=\"FF\" name=\"TipoF\" accesskey=\"F\"/>Fuero <u>F</u>amilia&nbsp;&nbsp;&nbsp;\r\n\t\t<input id=\"TipoF2\" type=\"CheckBox\" value=\"PP\" name=\"TipoP\"  accesskey=\"P\"/>Fuero <u>P</u>enal&nbsp;&nbsp;&nbsp;  \r\n\t\t<input id=\"Submit1\" name=\"Aceptar\" type=\"submit\" value=\"Aceptar\" accesskey=\"A\">\r\n        <td class=\"fondoceleste\"><p class=\"left\"></td>\r\n        </p></td></tr>\r\n        <tr><td class=\"fondoceleste\" colspan=\"5\"><p class=\"center\">&nbsp;</p></td></tr>\r\n    </table>\r\n           \r\n     <br>\r\n\r\n\t\r\n         <h2><table class=\"pegada\"><tr><td class=\"fondoclaro\" colspan=\"2\"><p class=\"center\">Men&uacute; con m&aacute;s Opciones</p></td></tr></table></h2>\r\n\r\n         <p class=\"bigcenter\">        \r\n            <a style=\"color: #003063\" href=\"ConsultasXMailAJuzgados.asp\"><strong>Consultas a Organismos</strong></A>&nbsp;&nbsp;&nbsp;&nbsp;\r\n            <a style=\"color: #003063\" href=\"AltaSolicitud.asp\">Alta Solicitud Autorizaci&oacute;nMEV</A>&nbsp;&nbsp;&nbsp;&nbsp;\r\n            <a style=\"color: #003063\" href=\"ConsSolicitudes.asp\">Consulta de Solicitudes</A>&nbsp;&nbsp;&nbsp;&nbsp;            \r\n            <a style=\"color: #003063\" href=\"ayuda.asp\">Ayuda</a>&nbsp;&nbsp;&nbsp;&nbsp;\r\n            <a style=\"color: #003063\" href=\"loguin.asp\">Desconectarse</a>\r\n        </p>\r\n        </form>    \r\n        <table class=\"pegada\"><tr><td class=\"lineaazul\" colspan=\"2\"></td></tr></table></td></tr></table></td></tr></table></body></html>";
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
//        //var handler = new HttpClientHandler
//        //{
//        //    UseCookies = true,
//        //    CookieContainer = new CookieContainer()
//        //};
//        //handler.CookieContainer.Add(cookie);
//        //var httpClient = new HttpClient(handler);
//        //httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36");
//        //httpClient.DefaultRequestHeaders.Add("Referer", "https://mev.scba.gov.ar/loguin.asp");
//        //httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
//        //httpClient.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.9,es;q=0.8");
//        //httpClient.DefaultRequestHeaders.Add("Upgrade-Insecure-Requests", "1");

//        //var content = new FormUrlEncodedContent(new[]
//        //{
//        //    new KeyValuePair<string, string>("usuario", "lcorrea"),
//        //    new KeyValuePair<string, string>("clave", "iPhone3G"),
//        //    new KeyValuePair<string, string>("DeptoRegistrado", "QU")
//        //});

//        //var response = await httpClient.PostAsync("https://mev.scba.gov.ar/loguin.asp?familiadepto=", content);
//        //response.EnsureSuccessStatusCode();
//        //var c = await response.Content.ReadAsStreamAsync();
        
//        //if (response.Content.Headers.ContentEncoding.Contains("gzip"))
//        //{
//        //    c = new GZipStream(c, CompressionMode.Decompress);
//        //}
//        //else if (response.Content.Headers.ContentEncoding.Contains("deflate"))
//        //{
//        //    c = new DeflateStream(c, CompressionMode.Decompress);
//        //}

//        //using (var reader = new StreamReader(c))
//        //{
//        //    var htmlContent = await reader.ReadToEndAsync();
//        //    var htmlDocument = new HtmlDocument();
//        //    htmlDocument.LoadHtml(htmlContent);
            
//        //    var options = htmlDocument.DocumentNode.SelectNodes("//option");
//        //    var deptos = options.Select(x => x.SelectNodes("//h6").FirstOrDefault());
//        //    //.Select(node=> new
//        //    //{
//        //    //    Codigo = node.Attributes["value"],
//        //    //    //Nombre = node.SelectNodes("//h6").FirstOrDefault()?.InnerText
//        //    //}).ToList();            
//        //    var strub = ";";
//        //}





////            content = new(new[]
////        {
////            new KeyValuePair<string, string>("TipoDto", "CC"),
////            new KeyValuePair<string, string>("DtoJudElegido", "23"),
////            new KeyValuePair<string, string>("Aceptar", "Aceptar")
////        });
////        response = await httpClient.PostAsync("https://mev.scba.gov.ar/POSLoguin.asp", content);
////        response.EnsureSuccessStatusCode();
////        content = new(new[]
////        {
////            new KeyValuePair<string, string>("OpcionBusqueda", "0"),
////            new KeyValuePair<string, string>("busca", "montanari"),
////            new KeyValuePair<string, string>("JuzgadoElegido", "GAM591"),
////            new KeyValuePair<string, string>("radio", "xCa"),
////            new KeyValuePair<string, string>("caratula", "montanari"),
////            new KeyValuePair<string, string>("Ncausa", ""),
////            new KeyValuePair<string, string>("Ninterno", ""),
////            new KeyValuePair<string, string>("Set", ""),
////            new KeyValuePair<string, string>("Desde", "2/3/2023"),
////            new KeyValuePair<string, string>("Hasta", "4/3/2023"),
////            new KeyValuePair<string, string>("SetNovedades", ""),
////            new KeyValuePair<string, string>("TipoCausa", "Ac"),
////            new KeyValuePair<string, string>("Buscar", "Buscar"),
////        });
////        response = await httpClient.PostAsync("https://mev.scba.gov.ar/busqueda.asp", content);

////        var contentStream = await response.Content.ReadAsStreamAsync();

////        // Check if the response is compressed
////        if (response.Content.Headers.ContentEncoding.Contains("gzip"))
////        {
////            contentStream = new GZipStream(contentStream, CompressionMode.Decompress);
////        }
////        else if (response.Content.Headers.ContentEncoding.Contains("deflate"))
////        {
////            contentStream = new DeflateStream(contentStream, CompressionMode.Decompress);
////        }

////        using (var reader = new StreamReader(contentStream))
////        {
////            var htmlContent = await reader.ReadToEndAsync();
////            var htmlDocument = new HtmlDocument();
////            htmlDocument.LoadHtml(htmlContent);

////            var tableRows = htmlDocument.DocumentNode.SelectNodes("//table[@class='pegada']/tr");
////            var tramites = new List<Tramite>();

////            foreach (var row in tableRows.Skip(1)) // skip first row as it contains headers
////            {
////                var columns = row.Descendants("td").ToList();

////                var fechaString = columns[0].InnerText;
////                var fecha = DateTime.Parse(fechaString);

////                var fojasString = columns[1].InnerText;
////                var fojas = int.Parse(fojasString);

////                var descripcion = columns[2].InnerText.Trim();

////                var tramite = new Tramite
////                {
////                    Fecha = fecha,
////                    Fojas = fojas,
////                    Descripcion = descripcion
////                };

////                tramites.Add(tramite);
////            }
////            tramites.ForEach(t => Console.WriteLine(t));
////        }
////        return cookie;
////    }
////}
