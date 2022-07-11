using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Code_Evaluation_Test.Model;

namespace Code_Evaluation_Test.Data
{
    public class Code_Evaluation_TestContext : DbContext
    {
        public Code_Evaluation_TestContext (DbContextOptions<Code_Evaluation_TestContext> options)
            : base(options)
        {
        }

        public DbSet<Code_Evaluation_Test.Model.Employee>? Employee { get; set; }
    }
}
