using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFInMemory
{
    public class Seeder
    {
        public static void Seed(AppDbContext context)
        {
            // Add States
            for (var i = 1; i <= 51; i++)
            {
                context.States.Add(new State { Id = i });
            }

            context.SaveChanges();


            // Add Countries
            for (var i = 1; i <= 4; i++)
            {
                context.Countries.Add(new Country { Id = i });
            }
            context.SaveChanges();

            // TODO: Uncomment following 2 lines to see inversion
            //context.States.ToList();
            //context.Countries.ToList();

            // Add Agencies
            context.Agencies.AddRange(
                new Agency
                {
                    Id = 401,
                    InsuranceCertificate = new InsuranceCertificate(),
                    Addresses =
                    {
                        new Address
                        {
                            Id = 102,
                            StateId = 36,
                            CountryId = 1
                        },
                        new Address
                        {
                            Id = 103,
                            StateId = 36,
                            CountryId = 1
                        }
                    },
                    Contacts =
                    {
                        new Contact
                        {
                            Id = 84
                        }
                    },
                    Commissions =
                    {
                        new Commission
                        {
                            Id = 82
                        }
                    },
                    Notes =
                    {
                        new Note()
                    }
                },
                new Agency
                {
                    Id = 402
                },
                new Agency
                {
                    Id = 403
                });
            context.SaveChanges();
        }
    }
}
