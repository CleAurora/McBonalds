using Microsoft.Extensions.Primitives;

namespace McBonalds.Models
{
    public class Hamburguer
    {
        public Hamburguer(StringValues Nome)
        {
            this.Nome = Nome;
        }

        public string Nome {get; set;}
    }
}