namespace Ucu.Poo.RideShare
{
    public class Passenger : User
    {
        public Passenger(
            string name,
            string lastName,
            string id,
            string photo,
            double rating)
            : base(name, lastName, id, photo)
        {
            this.Rating = rating;
        }

        public double Rating { get; set; }

        public override string Welcome()
        {
            return $"Bienvenido {this.Name} {this.LastName}";
        }
    }
}