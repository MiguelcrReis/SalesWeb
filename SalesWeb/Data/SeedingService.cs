using SalesWeb.Models;
using SalesWeb.Models.Enums;
using System;
using System.Linq;

namespace SalesWeb.Data
{
    public class SeedingService
    {
        private SalesWebContext _context;

        public SeedingService(SalesWebContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            //Checks if the db has already been populated.
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");
            Department d5 = new Department(5, "Sports");

            Seller s1 = new Seller(1, "Bill Gates", "gates@email.com", new DateTime(1955, 10, 28), 5000.0, d1);
            Seller s2 = new Seller(2, "Elon Musk", "musk@email.com", new DateTime(1971, 6, 28), 5000.0, d2);
            Seller s3 = new Seller(3, "Gisele Bündchen", "bündchen@email.com", new DateTime(1980, 7, 20), 5000.0, d3);
            Seller s4 = new Seller(4, "J. K. Rowling", "rowling@email.com", new DateTime(1965, 7, 31), 5000.0, d4);
            Seller s5 = new Seller(5, "Lionel Messi", "messi@email.com", new DateTime(1987, 6, 24), 5000.0, d5);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2022, 12, 20), 10000.0, SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2022, 12, 20), 250.0, SaleStatus.Billed, s2);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2022, 12, 20), 300.0, SaleStatus.Billed, s3);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2022, 12, 20), 150.0, SaleStatus.Billed, s4);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2022, 12, 20), 460, SaleStatus.Billed, s5);
            SalesRecord sr6 = new SalesRecord(6, new DateTime(2022, 12, 20), 5000.0, SaleStatus.Billed, s1);
            SalesRecord sr7 = new SalesRecord(7, new DateTime(2022, 12, 20), 1500.0, SaleStatus.Billed, s2);
            SalesRecord sr8 = new SalesRecord(8, new DateTime(2022, 12, 20), 550.0, SaleStatus.Billed, s3);
            SalesRecord sr9 = new SalesRecord(9, new DateTime(2022, 12, 20), 220.0, SaleStatus.Billed, s4);
            SalesRecord sr10 = new SalesRecord(10, new DateTime(2022, 12, 20), 400.0, SaleStatus.Billed, s5);

            _context.Department.AddRange(d1, d2, d3, d4, d5);
            _context.Seller.AddRange(s1, s2, s3, s4, s5);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr8, sr9, sr10);

            _context.SaveChanges();
        }
    }
}
