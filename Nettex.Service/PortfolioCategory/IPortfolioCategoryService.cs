using Nettex.Core.Entities;
using System.Collections.Generic;

namespace Nettex.Service
{
    public interface IPortfolioCategoryService
    {
        PortfolioCategory GetById(int Id);
        IEnumerable<PortfolioCategory> GetActives();
        IEnumerable<PortfolioCategory> GetCategories();
        bool Insert(PortfolioCategory PortfolioCategory);
        bool Update(PortfolioCategory PortfolioCategory);
        bool Delete(PortfolioCategory PortfolioCategory);
    }
}