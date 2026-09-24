namespace Ucu.Poo.RideShare
{
    public abstract class User
    {
        protected User(string name, string lastName, string id, string photo)        
        {
            this.Name = name;
            this.LastName = lastName;
            this.Id = id;
            this.Photo = photo;
        }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Id { get; set; }

        public string Photo { get; set; }

        // Cada tipo de usuario tendrá su propio mensaje de bienvenida
        public abstract string Welcome();
    }
}