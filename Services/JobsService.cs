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

    internal Job Create(Job newJob)
    {
      return _repo.Create(newJob);
    }

    internal Job Edit(Job updated)
    {
      var data = GetById(updated.Id);
      updated.Description = updated.Description != null ? updated.Description : data.Description;
      updated.Contact = updated.Contact != null && updated.Contact.Length > 2 ? updated.Contact : data.Contact;

      return _repo.Edit(updated);
    }

    internal string Delete(int id)
    {
    var data = GetById(id);
    _repo.Delete(id);
    return "delorted";
    }
  }
}