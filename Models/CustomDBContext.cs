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
            optionsBuilder.UseSqlServer("Server=DESKTOP-LR57J5O\\SQLEXPRESS;Database=StudInfoSys;");
        }
    }
}
