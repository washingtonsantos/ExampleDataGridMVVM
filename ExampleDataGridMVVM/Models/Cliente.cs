using Prism.Mvvm;
using System;

namespace ExampleDataGridMVVM.Models
{
    public class Cliente : BindableBase
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
        public string UF { get; set; }
        private string mensagem;
        public string Mensagem
        {
            get { return mensagem; }
            set { SetProperty(ref mensagem, value); }
        }
    }
}
