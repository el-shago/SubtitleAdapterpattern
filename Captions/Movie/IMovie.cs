namespace Captions
{
    public interface IMovie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly DatePublished { get; set; }

        public ICaptionsJson CaptionsJson { get; set; }

        public void PlayMovie();
    }
}

