using HtmlAgilityPack;
using System.IO.Compression;
using System.Net;
using System.Net.Mime;
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
