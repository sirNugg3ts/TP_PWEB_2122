using System.Linq;
using TPPweb2122.Models;
using X.PagedList;

namespace TPPweb2122.ViewModels
{
    public class ImoveisViewModel
    {
        public IPagedList<Imovel> Imoveis { get; set; }

        public void paginacao(IQueryable<Imovel> imoveis,int page,int nreg)
        {
            Imoveis = imoveis.ToPagedList(page, nreg);
            return;
        }
    }
}
