namespace SoSmartTv.VideoPlayer.ViewModels
{
	public class VideoItem : IVideoItem
	{
		public VideoItem(int id, string title, string sourcePath, string genre, string description, string posterSource)
		{
			Id = id;
			Title = title;
			SourcePath = sourcePath;
			Genre = genre;
			Description = description;
			PosterSource = posterSource;
		}

		public int Id { get; set; }
		public string Title { get; }
		public string SourcePath { get; }
		public string Genre { get; }
		public string Description { get; }
		public string PosterSource { get; }
	}
}