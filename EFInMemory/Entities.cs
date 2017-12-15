using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFInMemory
{
    public class Agency
    {
        public int Id { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<Contact> Contacts { get; set; } = new List<Contact>();
        public List<Note> Notes { get; set; } = new List<Note>();
        public List<Commission> Commissions { get; set; } = new List<Commission>();
        public InsuranceCertificate InsuranceCertificate { get; set; } = new InsuranceCertificate();
    }

    public class Address
    {
        public int Id { get; set; }
        [Required]
        public int CountryId { get; set; }
        public Country Country { get; set; }
        [Required]
        public int StateId { get; set; }
        public State State { get; set; }
    }

    public class Country
    {
        public int Id { get; set; }
    }

    public class State
    {
        public int Id { get; set; }
    }

    public class Contact
    {
        public int Id { get; set; }
    }

    public class Note
    {
        public int Id { get; set; }
    }

    public class Commission
    {
        public int Id { get; set; }
    }
    public class InsuranceCertificate
    {
        public int Id { get; set; }
    }
}