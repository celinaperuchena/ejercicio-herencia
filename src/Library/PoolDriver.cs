namespace Ucu.Poo.RideShare
{
    public class PoolDriver : Driver
    {
        public PoolDriver(
            string name,
            string lastName,
            string id,
            string photo,
            double rating,
            string bio,
            string vehicle,
            int maxCapacity,
            bool needsGlasses)
            : base(name, lastName, id, photo, rating, bio, vehicle, needsGlasses)
        {
            this.MaxCapacity = maxCapacity;
        }

        public int MaxCapacity { get; set; }
    }
}