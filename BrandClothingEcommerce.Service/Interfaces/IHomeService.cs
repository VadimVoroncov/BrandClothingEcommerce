using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdatedWebBCE.Domain.Entity;

namespace UpdatedWebBCE.Service.Interfaces
{
    public interface IHomeService
    {
        Task<IEnumerable<Product>> GetProduct(string sTerm = "", int typeOfСlothingId = 0);
        Task<IEnumerable<TypeOfСlothing>> TypeOfСlothing();
    }
}
