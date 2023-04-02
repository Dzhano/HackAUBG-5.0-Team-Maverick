namespace MusicPlayer
{
	public class Music
	{
		public string Name { get; set; }
		public string ID { get; set; }
		public string Thumb { get; set; }

		public Music(string Name, string ID, string Thumb = "")
		{
			this.Name = Name;
			this.ID = ID.Split('&')[0].Replace("/watch?v=", "");
			this.Thumb = Thumb;
		}
	}
}