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
            string vehicle)
            : base(name, lastName, id, photo)
        {
            this.Rating = rating;
            this.Bio = bio;
            this.Vehicle = vehicle;
        }

        public double Rating { get; set; }

        public string Bio { get; set; }

        public string Vehicle { get; set; }

        public override string Welcome()
        {
            return $"Bienvenido {this.Name}. {this.Bio}";
        }
    }
}