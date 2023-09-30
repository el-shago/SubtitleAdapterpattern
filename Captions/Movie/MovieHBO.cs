using System;
namespace Captions
{
    public class MovieHBO : IMovie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly DatePublished { get; set; }
        public ICaptionsJson CaptionsJson { get; set; }

        public MovieHBO(string name, string description, DateOnly datePublished, int id)
        {
            Id = id;
            Name = name;
            Description = description;
            DatePublished = datePublished;
            CaptionsJson = new HBOMaxCaptionsJsonAdapter(id);
        }

        public void PlayMovie()
        {
            Console.WriteLine("Reproduciendo pelicula: " + Name);
            Console.WriteLine("Descripcion: " + Description);

            var captions = CaptionsJson.GetJson();
            var captionsStr = MergeCaptionTexts.MergeCaptions(captions);
        }
    }
}

