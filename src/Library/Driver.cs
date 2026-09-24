namespace Ucu.Poo.RideShare
{
    public class Driver : User
    {
        public Driver(
            string name,
            string lastName,
            string id,
            string photo,
            double rating,
            string bio,
            string vehicle,
            bool needsGlasses)
            : base(name, lastName, id, photo)
        {
            this.Rating = rating;
            this.Bio = bio;
            this.Vehicle = vehicle;
            this.NeedsGlasses = needsGlasses;
        }

        public double Rating { get; set; }

        public string Bio { get; set; }

        public string Vehicle { get; set; }

        public bool NeedsGlasses { get; set; }

        public override string Welcome()
        {
            return $"Bienvenido {this.Name}. {this.Bio}";
        }
    }
}