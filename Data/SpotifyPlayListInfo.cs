namespace LoveLiveHeardleSpotify.Data
{
    public class PlayListImage
    {
        public int? height { get; set; }
        public string? url { get; set; }
        public int? width { get; set; }
    }

    public class ExternalUrls
    {
        public string? spotify { get; set; }
    }

    public class Owner
    {
        public string? display_name { get; set; }
        public ExternalUrls? external_urls { get; set; }
        public string? href { get; set; }
        public string? id { get; set; }
        public string? type { get; set; }
        public string? uri { get; set; }
    }

    public class Tracks
    {
        public string? href { get; set; }
        public string? next { get; set; }

        public int? total { get; set; }
    }

    public class PlaylistInfo
    {
        public string? description { get; set; }
        public string? id { get; set; }
        public List<PlayListImage>? images { get; set; }
        public string? name { get; set; }
        public Owner? owner { get; set; }
        public Tracks? tracks { get; set; }
    }
}