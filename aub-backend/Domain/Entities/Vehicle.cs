namespace aub_backend.Domain.Entities
{
    public class Vehicle

    {
        public int Id { get; private set; }
        public string Mark { get; private set; }   
        public string Model { get; private set; }
        public int Year { get; private set; }
        public string Plate { get; private set; }
        public string Color { get; private set; }
        public int CustomerId { get; private set; }
        public Customer Customer { get; private set; }

        protected Vehicle() { }

        public Vehicle(string mark, string model, int year, string plate, string color, int customerId)
        {
            Mark = mark;
            Model = model;
            Year = year;
            Plate = plate;
            Color = color;
            CustomerId = customerId;
        }

    }
}
