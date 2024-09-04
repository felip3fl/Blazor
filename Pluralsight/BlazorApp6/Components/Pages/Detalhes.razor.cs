using Microsoft.AspNetCore.Components;
using Shared.Domain;

namespace BlazorApp6.Components.Pages
{
    public partial class Detalhes
    {
        [Parameter]
        public string DetalhesId { get; set; }

        public Carro? Carro { get; set; } = new Carro();



        public Detalhes()
        {
            Carro.Id = "123";
            Carro.Marca = "VW";
            Carro.Modelo = "Gol";
            Carro.Ano = 2014;
            Carro.Cor = "Verde";
            Carro.Quilometragem = 456;
        }
    }
}
