namespace LoveLiveHeardleSpotify.Data
{

    public class SpotifyPlaylist
    {
        public Song[]? items { get; set; }
    }

    public class Song
    {
        public Track? track { get; set; }
    }

    public class Track
    {
        public Album? album { get; set; }
        public Artist[]? artists { get; set; }
        public string? id { get; set; }
        public string? name { get; set; }
        public string? preview_url { get; set; }
    }

    public class Album
    {
        public Image[]? images { get; set; }
        public string? name { get; set; }
    }

    public class Image
    {
        public int height { get; set; }
        public string? url { get; set; }
        public int width { get; set; }
    }

    public class Artist
    {
        public string? name { get; set; }
    }

}
