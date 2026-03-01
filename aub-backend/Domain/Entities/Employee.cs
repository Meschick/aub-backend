namespace aub_backend.Domain.Entities
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Cpf { get; private set; }
        public string Telephone { get; private set; }
        public string Function { get; private set; }
        public DateOnly AdmissionDate { get; private set; }
        public decimal Salary { get; private set; }
        public decimal Commission { get; private set; }
        public bool Active { get; private set; }

        protected Employee() { }

        public Employee(
            string name,
            string cpf,
            string telephone,
            string function,
            DateOnly admissionDate,
            decimal salary,
            decimal commission,
            bool active)
        {
            Validate(name, cpf);
            Name = name;
            Cpf = cpf;
            Telephone = telephone;
            Function = function;
            AdmissionDate = admissionDate;
            Salary = salary;
            Commission = commission;
            Active = active;
        }

        private void Validate(string name, string cpf)
        {
            if (string.IsNullOrWhiteSpace(Name)) throw new ArgumentException("Nome é obrigatório");
            if ( (string.IsNullOrWhiteSpace(Cpf)) || (cpf.Length != 11 )) throw new ArgumentException("CPF inválido");
        }

    }
}
