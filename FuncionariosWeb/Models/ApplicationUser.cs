using Microsoft.AspNetCore.Identity;

namespace FuncionariosWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Cidade { get; set; }
    }
}
