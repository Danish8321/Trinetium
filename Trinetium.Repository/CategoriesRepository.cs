using System;
using System.Collections.Generic;
using System.Text;
using Trinetium.Contracts;
using Trinetium.Entities;
using Trinetium.Entities.Models;

namespace Trinetium.Repository
{
    public class CategoriesRepository : RepositoryBase<Categories>, ICategories
    {
        public CategoriesRepository(NorthwindContext northwindContext) : base(northwindContext)
        {
        }
    }
}
