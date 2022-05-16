using System.Net.Http.Headers;

namespace LoveLiveHeardleSpotify.Data
{
    public class Endpoints
    {
        public static HttpRequestMessage GetToken(string client_id, string client_secret)
        {
            var content = new FormUrlEncodedContent(new[] { new KeyValuePair<string, string>("grant_type", "client_credentials") });
            var authenticationString =
            Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes($"{client_id}:{client_secret}"));

            var bearerTokenRequest = new HttpRequestMessage(HttpMethod.Post, "https://accounts.spotify.com/api/token");
            bearerTokenRequest.Headers.Authorization = new AuthenticationHeaderValue("Basic", authenticationString);
            bearerTokenRequest.Content = content;

            return bearerTokenRequest;
        }

        public static HttpRequestMessage GetPlayListInfo(SpotifyToken? token, string playlist_id)
        {
            var playListReq = new HttpRequestMessage(HttpMethod.Get,
            $"https://api.spotify.com/v1/playlists/{playlist_id}?fields=id,owner,description,name,images,tracks(href,next,total)");

            playListReq.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token?.access_token);

            return playListReq;
        }

        public static HttpRequestMessage GetPlayListSongs(SpotifyToken? token, string playlist_id)
        {
            var playListReq = new HttpRequestMessage(HttpMethod.Get,
            $"https://api.spotify.com/v1/playlists/{playlist_id}/tracks?fields=total,next,items(track(name,id,preview_url,artists(name),album(images,name)))");
            playListReq.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token?.access_token);

            return playListReq;
        }
    }

}