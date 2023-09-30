
namespace Captions
{
    public class MoviePrime : IMovie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly DatePublished { get; set; }

        public ICaptionsJson CaptionsJson { get; set; }

        public MoviePrime(string name, string description, DateOnly datePublished, int id)
        {
            Id = id;
            Name = name;
            Description = description;
            DatePublished = datePublished;
            CaptionsJson = new PrimeCaptionsJson(id);
        }

        public void PlayMovie()
        {
            Console.WriteLine("Reproduciendo pelicula: " + Name);
            Console.WriteLine("Descripcion: " + Description);
            Console.WriteLine("Captions " + CaptionsJson.GetJson());
        }
    }
}

