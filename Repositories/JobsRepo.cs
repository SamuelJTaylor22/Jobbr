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
  }
}