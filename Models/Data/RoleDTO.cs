using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Store.Models.Data
{
    [Table("tblRoles")]
    public class RoleDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
    }
}