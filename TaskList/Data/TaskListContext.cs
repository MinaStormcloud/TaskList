using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskList.Models;

namespace TaskList.Data
{
    public class TaskListContext : DbContext
    {
        public TaskListContext (DbContextOptions<TaskListContext> options)
            : base(options)
        {
        }

        public DbSet<TaskList.Models.Task> Task { get; set; } = default!;
    }
}
