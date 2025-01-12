using Nettex.Core.Entities;
using System.Collections.Generic;

namespace Nettex.Service
{
    public interface IJobCategoryService
    {
        JobCategory GetById(int Id);
        IEnumerable<JobCategory> GetActives();
        IEnumerable<JobCategory> GetCategories();
        bool Insert(JobCategory jobCategory);
        bool Update(JobCategory jobCategory);
        bool Delete(JobCategory jobCategory);
    }
}