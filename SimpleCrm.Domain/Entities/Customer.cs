namespace SimpleCrm.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; set; } // false

        public string Name { get; set; } // true

        public string TaxNumber { get; set; }// true

        public string Email { get; set; } // true

        public string PhoneNumber { get; set; }// true

        public string[] AccountNumbers { get; set; }

        //"name": "Jan Kowalski",
        //"taxNumber": null,
        //"email": "j.kowalski@gmail.com",
        //"phoneNumber": "698654632",
        //"statusVat": null,
        //"accountNumbers": []
    }
}
