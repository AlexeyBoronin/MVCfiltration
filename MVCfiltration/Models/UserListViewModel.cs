using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCfiltration.Models
{
    public class UserListViewModel
    {
        public IEnumerable<User> Users { get; set; } = new List<User>();
        public SelectList Companies { get; set; } = new SelectList(new List<Company>(), "Id", "Name");
        public string? Name { get; set; }
    }
}
