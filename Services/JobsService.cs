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

    internal Job GetById(int id)
    {
      var data = _repo.GetById(id);
      if (data == null)
      {
          throw new Exception("Invalid Id");
      }
      return data;
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