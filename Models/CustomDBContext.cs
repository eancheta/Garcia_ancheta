using Microsoft.EntityFrameworkCore;

namespace Garcia_ancheta.Models
{
    public partial class StudInfoSysContext
    {
        public StudInfoSysContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-LR57J5O\\SQLEXPRESS;Initial Catalog=StudInfoSys; Integrated Security=True;Trust Server Certificate=true");
        }
    }
}
