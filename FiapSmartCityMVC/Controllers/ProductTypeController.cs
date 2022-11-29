using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using FiapSmartCityMVC.Models;
using System.Diagnostics;

namespace FiapSmartCityMVC.Controllers
{
    public class ProductTypeController : Controller
    {
        // ACTION INDEX
        public IActionResult Index()
        {
            // Criando o atributo da lista
            IList<Models.ProductType> listType = new List<ProductType>();

            // Adicionando na lista o TipoProduto da Tinta
            listType.Add(new ProductType()
            {
                TypeId = 1,
                TypeDescription = "Tinta",
                Marketed = true
            });

            listType.Add(new ProductType()
            {
                TypeId = 2,
                TypeDescription = "Filtro de água",
                Marketed = true
            });

            listType.Add(new ProductType()
            {
                TypeId = 3,
                TypeDescription = "Captador de energia",
                Marketed = false
            });

            // Retornando para View a lista de Tipos
            return View(listType);
        }

        // ACTION CREATE
        // Anotação de uso do Verb HTTP Get
        [HttpGet]
        public IActionResult Create()
        {
            // Imprime a mensagem de execução
            Debug.Print("Executou a Action Create()");

            // Retorna para a View Cadastrar um 
            // objeto modelo com as propriedades em branco 
            return View(new ProductType());
        }

        // Anotação de uso do Verb HTTP Post
        [HttpPost]
        public IActionResult Create(ProductType productType)
        {
            // Validando o Campo Descricao
            //if (string.IsNullOrEmpty(productType.TypeDescription))
            //{
                // Adicionando a mensagem de Erro para descrição em branco
            //    ModelState.AddModelError("Description", "Descrição obrigatória!");
            //}

            // Se o ModelState não tem nenhum erro
            if (ModelState.IsValid)
            {
                // Simila que os dados foram gravados.
                Debug.Print("Descrição: " + productType.TypeDescription);
                Debug.Print("Comercializado: " + productType.TypeDescription);
                Debug.Print("Gravando o Tipo de Produto");

                return RedirectToAction("Index", "ProductType");

                // Encontrou um erro no preenchimento do campo descriçao
            }
            else
            {
                // retorna para tela do formulário
                return View(productType);
            }
        }

        // ACTION UPDATE
        [HttpGet]
        public IActionResult Update(int Id)
        {
            // Imprime a mensagem de execução
            Debug.Print("Consultando o Tipo com Id = " + Id);

            // Cria o modelo que SIMULA a consulta no  banco de dados
            ProductType productType = new ProductType()
            {
                TypeId = Id,
                TypeDescription = "Tinta",
                Marketed = true
            };

            // Retorna para a View o objeto modelo 
            // com as propriedades preenchidas com dados do banco de dados 
            return View(productType);
        }

        [HttpPost]
        public IActionResult Update(ProductType productType)
        {
            // Imprime os valores do modelo
            System.Diagnostics.Debug.Print("Descrição: " + productType.TypeDescription);
            System.Diagnostics.Debug.Print("Comercializado: " + productType.Marketed);

            // Simila que os dados foram gravados.
            System.Diagnostics.Debug.Print("Gravando o Tipo Editado");

            // Substituímos o return View()
            // pelo método de redirecionamento
            return RedirectToAction("Index", "ProductType");
        }

        // ACTION READ
        [HttpGet]
        public IActionResult Read(int Id)
        {
            // Imprime a mensagem de execução
            Debug.Print("Consultando o Tipo com Id = " + Id);

            // Cria o modelo que SIMULA a consulta no  banco de dados
            ProductType productType = new ProductType()
            {
                TypeId = Id,
                TypeDescription = "Tinta",
                Marketed = true
            };

            // Retorna para a View o objeto modelo 
            // com as propriedades preenchidas com dados do banco de dados 
            return View(productType);
        }

        // ACTION DELETE
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            // Imprime a mensagem de execução
            Debug.Print("Excluir o Tipo com Id = " + Id);

            // Substituímos o return View()
            // pelo método de redirecionamento
            return RedirectToAction("Index", "TypeProduct");
        }
    }
}

