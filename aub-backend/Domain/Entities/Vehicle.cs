namespace aub_backend.Domain.Entities
{
    public class Vehicle

    {
        public int Id { get; private set; }
        public string Mark { get; private set; }   
        public string Model { get; private set; }
        public string Type { get; private set; }
        public int Year { get; private set; }
        public string Plate { get; private set; }
        public string Color { get; private set; }
        public int Mileage { get; private set; }
        public string Observations { get; private set; }
        public DateTime RegistrationDate { get; private set; }
        public int CustomerId { get; private set; }
        public Customer Customer { get; private set; }

        protected Vehicle() { }
                
        public Vehicle(
            string mark, 
            string model, 
            string type, 
            int year, 
            string plate, 
            string color, 
            int mileage, 
            string observations, 
            DateTime registrationDate,
            int customerId)
        {
            Validate(mark, model, plate, customerId);
            Mark = mark;
            Model = model;
            Type = type;
            Year = year;
            Plate = plate;
            Color = color;
            Mileage = mileage;
            Observations = observations;
            RegistrationDate = registrationDate;
            CustomerId = customerId;
        }

        private void Validate(string mark, string model, string plate, int customerId)
        {
            if (string.IsNullOrWhiteSpace(mark)) throw new ArgumentException("Marca é obrigatória");

            if (string.IsNullOrWhiteSpace(model)) throw new ArgumentException("Modelo é obrigatório");

            if (string.IsNullOrWhiteSpace(plate)) throw new ArgumentException("Placa é obrigatória");

            if (customerId < 0) throw new ArgumentException("Cliente inválido");
        }

    }
}
