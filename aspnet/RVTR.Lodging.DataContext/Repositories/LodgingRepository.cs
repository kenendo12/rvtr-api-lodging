using RVTR.Lodging.ObjectModel.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RVTR.Lodging.DataContext.Repositories
{
  public class LodgingRepository : ILodgingRepository
  {
    public LodgingRepository(LodgingContext context)
    {

    }

    public Task DeleteAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<LodgingModel>> GetAsync()
    {
      throw new NotImplementedException();
    }

    public Task GetAsync(int id)
    {
      throw new NotImplementedException();
    }

    public Task InsertAsync(LodgingModel entry)
    {
      throw new NotImplementedException();
    }

    public void Update()
    {
      throw new NotImplementedException();
    }
  }
}
