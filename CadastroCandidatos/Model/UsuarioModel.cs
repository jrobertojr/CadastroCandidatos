namespace CadastroCandidatos.Model
{
    class UsuarioModel
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public bool Adm { get; set; }
        public bool Status { get; set; }
        public string Data { get; set; }
    }
}
