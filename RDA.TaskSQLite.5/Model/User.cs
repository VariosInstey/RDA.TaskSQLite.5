using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace RDA.TaskSQLite._5.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Login {get; set; }
        public string Password { get; set; }
        public virtual ICollection<Role> Roles { get; private set; } = new ObservableCollection<Role>();
    }
}
