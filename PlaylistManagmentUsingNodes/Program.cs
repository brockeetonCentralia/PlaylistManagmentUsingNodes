using PlaylistManagmentUsingNodes;

Playlist playlist = new Playlist();

playlist.AddSongBeginning("No Doubt About It", "Neal McCoy", 3.45);
playlist.AddSongEnd("Amarillo by Morning", "George Strait", 2.56);
playlist.PrintPlaylistForward();
playlist.PringPlaylistBackward();
playlist.RemoveSong("No Doubt About It", "Neal McCoy", 3.45);
playlist.PrintPlaylistForward();
playlist.PringPlaylistBackward();