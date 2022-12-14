using Microsoft.EntityFrameworkCore;

using FiapSmartCityMVC.Models;
using FiapSmartCityMVC.Repository.Context;

namespace FiapSmartCityMVC.Repository
{
    public class ProductEFRepository
    {

        private readonly DataBaseContext context;

        public ProductEFRepository()
        {
            // Criando um instância da classe de contexto do EntityFramework (relacionando ao BD)
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