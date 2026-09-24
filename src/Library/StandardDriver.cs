namespace Ucu.Poo.RideShare
{
    public class StandardDriver : Driver
    {
        public StandardDriver(
            string name,
            string lastName,
            string id,
            string photo,
            double rating,
            string bio,
            string vehicle)
            : base(name, lastName, id, photo, rating, bio, vehicle)
        {
        }
    }
}