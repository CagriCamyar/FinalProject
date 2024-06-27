using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll(); // listede birden fazla çıktı olacağından List<Category> yazıyoruz  
        IDataResult<Category> GetById(int categoryId); // Tek bir çıktı olacağından Category yazıyoruz

    }
}
