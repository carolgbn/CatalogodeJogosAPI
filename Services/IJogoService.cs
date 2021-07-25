using CatalogoJogos.InputModel;
using CatalogoJogos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoJogos.Services
{
    public class IJogoService : IDisposable
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal Task Inserir(JogoInputModel jogoInputModel)
        {
            throw new NotImplementedException();
        }

        internal Task Atualizar(Guid idJogo, double preco)
        {
            throw new NotImplementedException();
        }

        internal Task Remover(Guid idJogo)
        {
            throw new NotImplementedException();
        }

        internal Task Obter(Guid idJogo)
        {
            throw new NotImplementedException();
        }
    }
}
