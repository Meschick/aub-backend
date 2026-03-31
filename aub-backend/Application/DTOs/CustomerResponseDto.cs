namespace aub_backend.Application.DTOs
{
    public class CustomerResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Gender { get; set; }
    }
}
