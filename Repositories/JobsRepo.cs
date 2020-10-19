using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Jobbr.Models;

namespace Jobbr.Repositories
{
  public class JobsRepo
  {
    private readonly IDbConnection _db;
    public JobsRepo(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<Job> GetAll()
    {
      string sql = "SELECT * FROM jobs";
      return _db.Query<Job>(sql);
    }

    internal Job GetById(int id)
    {
      string sql = "SELECT * FROM jobs WHERE id = @id";
      return _db.QueryFirstOrDefault<Job>(sql, new {id});
    }

    internal object Create(Job newJob)
    {
      string sql = @"INSERT INTO jobs (location, description, contact) VALUES (@Location, @Description, @Contact); SELECT LAST_INSERT_ID();";
      int id = _db.ExecuteScalar<int>(sql, newJob);
      newJob.Id = id;
      return newJob;
    }
  }
}