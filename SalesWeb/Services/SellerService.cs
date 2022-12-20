using SalesWeb.Data;
using SalesWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SalesWeb.Services.Exceptions;
using System.Threading.Tasks;

namespace SalesWeb.Services
{
    public class SellerService
    {
        private readonly SalesWebContext _context;

        public SellerService(SalesWebContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.OrderBy(x => x.Name).ToListAsync();
        }

        public async Task InsertAsync(Seller seller)
        {
            _context.Add(seller);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(seller => seller.Department).FirstOrDefaultAsync(seller => seller.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var seller = await _context.Seller.FindAsync(id);
                _context.Seller.Remove(seller);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new IntegrityException(ex.Message);
            }
        }

        public async Task UpdateAsync(Seller seller)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == seller.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }

            try
            {
                _context.Update(seller);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                /*Tratativa muito importante para separar as camadas, no caso de alguma exception na camada de acesso a dados,
                será lançado uma exception da camada de serviços.
                Então para respeitar a arquitetura mvc, o controlador só irá interagir com a camada de serviços.
                A camada de serviços capitura as exceptions da camada de acesso a dados e relança elas no formato de exceptions de serviços.
                */
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
