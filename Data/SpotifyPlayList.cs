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
        public Artist[]? artists { get; set; }
        public string? id { get; set; }
        public string? name { get; set; }
        public string? preview_url { get; set; }
    }

    public class Artist
    {
        public string? name { get; set; }
    }
}
