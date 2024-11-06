using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistManagmentUsingNodes
{
    public class Playlist
    {
        private SongNode head;
        public void AddSongBeginning(string title, string artist, double duration)
        {
            SongNode newSong = new SongNode(title, artist, duration);
            if (head != null)
            {
                head.Prev = newSong;
            }
            newSong.Next = head;
            head = newSong;
            Console.WriteLine($"New song Title: {title} by {artist}, Duration: {duration}, has been added to the BEGINNING of your Playlist.");
        }
        public void AddSongEnd(string title, string artist, double duration)
        {
            SongNode newSong = new SongNode(title, artist, duration);
            if (head == null)
            {
                head = newSong;
            }
            else
            {
                SongNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newSong;
                newSong.Prev = current;
            }
            Console.WriteLine($"New song Title: {title} by {artist}, Duration: {duration}, has been added to the END of your Playlist.");
        }
        public void RemoveSong(string title, string artist, double duration)
        {
            if (head == null)
            {
                Console.WriteLine("Playlist is Empty");
                return;
            }

            SongNode current = head;

            if (head.Title == title)
            {
                head = head.Next;
                if (head != null)
                {
                    head.Prev = null;
                }
                Console.WriteLine($"Removed {title} from playlist.");
                return;
            }
            while (current != null && current.Title != title)
            {
                current = current.Next;
            }
            if (current == null)
            {
                Console.WriteLine($"{title} is not in your playlist.");
            }
            else
            {
                if(current.Next != null)
                {
                    current.Next.Prev = current.Prev;
                }
                if(current.Prev != null)
                {
                    current.Prev.Next = current.Next;
                }
                Console.WriteLine($"Removed {title} from playlist.");
            }
        }
        public void PrintPlaylistForward()
        {
            if (head == null)
            {
                Console.WriteLine("Playlist is empty.");
                return;
            }

            Console.Write("Forward: ");

            SongNode current = head;

            while (current != null)
            {
                Console.Write(current.Title + " by " + current.Artist + "," + " Duration: " + current.Duration + " <-> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
        public void PrintPlaylistBackward()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty.");
                return;
            }

            SongNode current = head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            Console.Write("Backward: ");

            while (current != null)
            {
                Console.Write(current.Title + " by " + current.Artist + "," + " Duration: " + current.Duration + " <-> ");
                current = current.Prev; 
            }
            Console.WriteLine("null");
        }
    }
}
