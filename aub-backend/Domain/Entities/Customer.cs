 using aub_backend.Domain.Enums;

namespace aub_backend.Domain.Entities
{
    public class Customer
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Telephone { get; private set; }
        public string Email { get; private set; }

        public string Cpf { get; private set; }

        public DateTime RegistrationDate { get; private set; }
        public DateOnly DateOfBirth { get; private set; }

        public string Gender { get; private set; }
        public CustomerStatus CustomerStatus { get; private set; }

        private readonly List<Vehicle> _vehicles = new();
        public IReadOnlyCollection<Vehicle> Vehicles => _vehicles;
        protected Customer() { }

        public Customer(
            string name, 
            string telephone, 
            string email, 
            string cpf, 
            DateTime registrationDate, 
            DateOnly dateOfBirth,
            string gender,
            CustomerStatus customerStatus)
        {
            Validate(name, email, cpf);
            Name = name;
            Telephone = telephone;
            Email = email;
            Cpf = cpf;
            RegistrationDate = registrationDate;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            CustomerStatus = customerStatus;
        }


        private void Validate(string name, string email, string cpf)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Nome é obrigatório");
            if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Email é obrigatório");
            if (string.IsNullOrWhiteSpace(cpf)) throw new ArgumentException("CPF é obrigatório");
        }


    }
}
