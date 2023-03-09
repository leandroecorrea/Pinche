public static class StringComparer
{
    public static bool AreStringsSimilar(string string1, string string2)
    {
        // Check if the strings are identical
        if (string1 == string2)
        {
            return true;
        }

        // Calculate the Levenshtein distance between the two strings
        int distance = ComputeLevenshteinDistance(string1, string2);

        // Calculate the similarity score
        double similarity = 1.0 - ((double)distance / (double)Math.Max(string1.Length, string2.Length));

        // If the similarity score is above a certain threshold, consider the strings similar
        double similarityThreshold = 0.75; // Change this value to adjust the similarity threshold
        if (similarity >= similarityThreshold)
        {
            return true;
        }

        // Otherwise, the strings are not similar enough
        return false;
    }

    // Helper method to compute the Levenshtein distance between two strings
    private static int ComputeLevenshteinDistance(string s, string t)
    {
        int[,] distance = new int[s.Length + 1, t.Length + 1];

        for (int i = 0; i <= s.Length; i++)
        {
            distance[i, 0] = i;
        }

        for (int j = 0; j <= t.Length; j++)
        {
            distance[0, j] = j;
        }

        for (int i = 1; i <= s.Length; i++)
        {
            for (int j = 1; j <= t.Length; j++)
            {
                int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;
                distance[i, j] = Math.Min(Math.Min(distance[i - 1, j] + 1, distance[i, j - 1] + 1), distance[i - 1, j - 1] + cost);
            }
        }

        return distance[s.Length, t.Length];
    }

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
