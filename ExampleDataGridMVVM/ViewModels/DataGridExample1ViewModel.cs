using ExampleDataGridMVVM.Models;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Linq;

namespace ExampleDataGridMVVM.ViewModels
{
    public class DataGridExample1ViewModel : BindableBase
    {
        public DataGridExample1ViewModel()
        {
            InitClientes();
        }

        private DelegateCommand<Cliente> alteraMensagemCommand;
        public DelegateCommand<Cliente> AlteraMensagemCommand
            => alteraMensagemCommand ?? (alteraMensagemCommand = new DelegateCommand<Cliente>(AlterarMensagemDaUF));

        private void AlterarMensagemDaUF(Cliente cliente)
        {
            Clientes.ToList().ForEach(c => 
            {
                if (c.UF == cliente.UF)
                    c.Mensagem = cliente.Mensagem;
            });
        }

        private ICollection<Cliente> clientes;
        public ICollection<Cliente> Clientes
        {
            get { return clientes; }
            set { SetProperty(ref clientes, value); }
        }

        private void InitClientes()
        {
            Clientes = new List<Cliente>();
            Clientes.Add(new Cliente { Id = System.Guid.NewGuid(), Nome = "Roberto Carlos", CPF = "236.744.730-62", Ativo = true, UF = "SP", Mensagem = "", Valor = 150.15m });
            Clientes.Add(new Cliente { Id = System.Guid.NewGuid(), Nome = "Maria do Bairro", CPF = "058.306.110-90", Ativo = true, UF = "BA", Mensagem = "", Valor = 40.05m });
            Clientes.Add(new Cliente { Id = System.Guid.NewGuid(), Nome = "Pelé", CPF = "484.751.370-32", Ativo = true, UF = "SP", Mensagem = "", Valor = 380 });
            Clientes.Add(new Cliente { Id = System.Guid.NewGuid(), Nome = "Chaves", CPF = "582.471.810-53", Ativo = true, UF = "BA", Mensagem = "", Valor = 450.36m });
            Clientes.Add(new Cliente { Id = System.Guid.NewGuid(), Nome = "Bolsonaro", CPF = "821.477.690-29", Ativo = true, UF = "RJ", Mensagem = "", Valor = 14.89m });
            Clientes.Add(new Cliente { Id = System.Guid.NewGuid(), Nome = "Lula", CPF = "777.832.240-40", Ativo = true, UF = "RJ", Mensagem = "", Valor = 19.56m });
        }

    }
}
