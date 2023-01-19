namespace WebPortal.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        public string UsuarioNome { get;set; }

        public string UsuarioSobrenome { get; set; }

        public string UsuarioEmail { get; set; }

        public string UsuarioSenha { get; }

        public int UsuarioTelefone { get; set; }

        public int UsuarioCPF { get; set; }

        public DateTime UsuarioAniversario { get; set;}


    }
}
