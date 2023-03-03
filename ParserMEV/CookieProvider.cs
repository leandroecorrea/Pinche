using System.Net;

public class CookieProvider
{
    //https://mev.scba.gov.ar/loguin.asp
    public async Task<Cookie> GetCookie(string username, string password)
    {
        var cookieContainer = new CookieContainer();
        var httpClientHandler = new HttpClientHandler
        {
            CookieContainer = cookieContainer,
            UseCookies = true,
        };

        using (var httpClient = new HttpClient(httpClientHandler))
        {

            var httpResponse = await httpClient.GetAsync("https://mev.scba.gov.ar/loguin.asp");
            httpResponse.EnsureSuccessStatusCode();

            var cookie = cookieContainer.GetCookies(httpResponse.RequestMessage.RequestUri).FirstOrDefault();
            return new Cookie(cookie.Name, cookie.Value, "/", "mev.scba.gov.ar");
        }
    }
}