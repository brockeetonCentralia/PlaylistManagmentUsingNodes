using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistManagmentUsingNodes
{
    public class SongNode
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public SongNode Next { get; set; }
        public SongNode Prev { get; set; }

        public SongNode(string title, string artist, double duration)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Next = null;
            Prev = null;
        }
    }
}
