using System.ComponentModel.DataAnnotations;

namespace RDA.TaskSQLite._5.Model
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public int UserID { get; set; }

    }
}
