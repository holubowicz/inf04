using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopApp
{
    public class MusicAlbum
    {
        public string Artist { get; set; } = string.Empty;
        public string Album { get; set; } = string.Empty;
        public int SongsNumber { get; set; }
        public int Year { get; set; }
        public int DownloadNumber { get; set; }
    }
}
