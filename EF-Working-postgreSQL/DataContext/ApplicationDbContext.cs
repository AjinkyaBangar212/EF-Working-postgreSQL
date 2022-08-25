using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EF_Working_postgreSQL.Models;
namespace EF_Working_postgreSQL.DataContext
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext():base(nameOrConnectionString: "Myconnection")
        { }


        public virtual DbSet<EmpClass> Empobj { get; set; }
    }
}