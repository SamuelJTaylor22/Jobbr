using System;
using System.Collections.Generic;
using Jobbr.Models;
using Jobbr.Repositories;

namespace Jobbr.Services
{
  public class JobsService
  {
      private readonly JobsRepo _repo;

    public JobsService(JobsRepo repo)
    {
      _repo = repo;
    }

    internal IEnumerable<Job> GetAll()
    {
      return _repo.GetAll();
    }

    internal object GetById(int id)
    {
      throw new NotImplementedException();
    }

    internal object Create(Job newJob)
    {
      throw new NotImplementedException();
    }

    internal object Edit(Job updated)
    {
      throw new NotImplementedException();
    }
  }
}