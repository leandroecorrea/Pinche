using System.IO.Compression;
using System.Net;
using System.Reflection.PortableExecutable;
using CsvHelper;
using HtmlAgilityPack;





var htmlContent = HTML.html;
var htmlDocument = new HtmlDocument();
htmlDocument.LoadHtml(htmlContent);

var options = htmlDocument.DocumentNode.SelectNodes("//option").Select(x => x.Attributes["value"].Value).ToList();
//var y = options.Select(x => new
//{
//    Codigo = x.Attributes["value"].Value,
//    Juzgado = x.ChildNodes.FirstOrDefault()?.InnerText
//});
//var deptos = options.Select(x => x.SelectNodes("//h6").FirstOrDefault());
var deptos = htmlDocument.DocumentNode.SelectNodes("//h6").Select(x=> x.InnerText).ToList();

var count = 0;
foreach(var option in options)
{
    Console.WriteLine($"{option},{deptos[count++]}");
}










//var user = "lcorrea";
//var password = "iPhone3G";

//var cookieProvider = new CookieProvider();
//var cookie = await cookieProvider.GetCookie(user, password);
//var loginHandler = new LoginHandler();
//var respuesta = await loginHandler.GetCookie(user, password, cookie);



//var httpClientHandler = new HttpClientHandler
//{
//    CookieContainer = new CookieContainer(),
//    UseCookies = true,
//    AllowAutoRedirect = true
//};



//var client = new HttpClient(httpClientHandler);
//client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36");
//httpClientHandler.CookieContainer.Add(cookie);
//var headers = new Dictionary<string, string>
//{
//    { "authority", "mev.scba.gov.ar" },
//    { "method", "POST" },
//    { "path", "/Busqueda.asp" },
//    { "scheme", "https" },
//    { "accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7" },
//    { "accept-encoding", "gzip, deflate, br" },
//    { "accept-language", "en-US,en;q=0.9,es;q=0.8" },
//    { "referer", "https://mev.scba.gov.ar/busqueda.asp" },
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

//var response = await client.GetAsync("https://mev.scba.gov.ar/busqueda.asp?OpcionBusqueda=0&busca=montanari&JuzgadoElegido=GAM591++&radio=xCa&caratula=montanari&NCausa=&NInterno=&Set=&Desde=2%2F3%2F2023&Hasta=4%2F3%2F2023&SetNovedades=&TipoCausa=Ac&Buscar=Buscar");

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