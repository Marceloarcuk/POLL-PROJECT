namespace EnqueteWeb.Models
{
    public static class Repositorio
    {
        private static List<Resposta> respostas = new List<Resposta>();
        public static IEnumerable<Resposta> Respostas {get {return respostas;}}
        public static void AdicionarResposta(Resposta resposta)
        {
            respostas.Add(resposta);
        }

        static Repositorio()
        {
            respostas.Add(new Resposta() {Nome="fulano", Email="fulano.gmail.com",Sim=false});
            respostas.Add(new Resposta() {Nome="ciclano", Email="ciclano.gmail.com",Sim=true});
            respostas.Add(new Resposta() {Nome="beltrano", Email="beltrano.gmail.com",Sim=false});
            respostas.Add(new Resposta() {Nome="Maria", Email="Maria.gmail.com",Sim=false});
            respostas.Add(new Resposta() {Nome="Jose", Email="Jose.gmail.com",Sim=true});
            respostas.Add(new Resposta() {Nome="Joao", Email="Joao.gmail.com",Sim=true});
        }
    }
}