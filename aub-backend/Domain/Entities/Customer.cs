 using aub_backend.Domain.Enums;

namespace aub_backend.Domain.Entities
{
    public class Customer
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Telephone { get; private set; }
        public string Email { get; private set; }
        public CustomerStatus CustomerStatus { get; private set; }

        private readonly List<Vehicle> _vehicles = new();
        public IReadOnlyCollection<Vehicle> Vehicles => _vehicles;
        protected Customer() { }

        public Customer(string name, string telephone, string email, CustomerStatus customerStatus)
        {
            Name = name;
            Telephone = telephone;
            Email = email;
            CustomerStatus = customerStatus;
        }

    }
}
