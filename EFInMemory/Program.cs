using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EFInMemory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var ctx = new AppDbContext())
            {
                Seeder.Seed(ctx);
            }

            var context = new AppDbContext();
            //Console.WriteLine(((Model)context.Model).ToDebugString());
            var sw = new Stopwatch();

            for (var i = 0; i < 1; i++)
            {
                sw.Start();
                var agency = context.Agencies
                    .Include(a => a.Addresses)
                        .ThenInclude(s => s.State)
                    .Include(a => a.Addresses)
                        .ThenInclude(c => c.Country)
                    .Include(a => a.InsuranceCertificate)
                    .Include(a => a.Contacts)
                    .Include(a => a.Commissions)
                    .Include(a => a.Notes)
                    .SingleOrDefault(e => e.Id == 401);

                Console.WriteLine(sw.Elapsed);
                sw.Reset();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
