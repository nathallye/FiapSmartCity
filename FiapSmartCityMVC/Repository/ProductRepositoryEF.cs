using Microsoft.EntityFrameworkCore;

using FiapSmartCityMVC.Models;
using FiapSmartCityMVC.Repository.Context;

namespace FiapSmartCityMVC.Repository
{
    public class ProductRepositoryEF
    {

        private readonly DataBaseContext context;

        public ProductRepositoryEF()
        {
            // Criando um instância da classe de contexto do EntityFramework
            context = new DataBaseContext();
        }

        public ProductEF Read(int id)
        {
            id = 1; // Apenas para teste. Um código que já existe.
            var prod = context.ProductEF
                .FirstOrDefault(p => p.ProductId == id);

            return prod;
        }
    }
}