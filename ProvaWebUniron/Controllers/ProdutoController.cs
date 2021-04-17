using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProvaWebUniron.Context;
using ProvaWebUniron.Models;
using System.Linq;

namespace ProvaWebUniron.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly DataContext _DataContext;
        public ProdutoController(DataContext DataContext)
        {
            _DataContext = DataContext;
        }
        // GET: ProdutoController
        public ActionResult Index()
        {
            var produtos = _DataContext.Produtos.ToList();
            if (produtos.Any())
            {
                return View(produtos);
            }
            return View();
        }

        // GET: ProdutoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProdutoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdutoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produto produto)
        {
            try
            {
                _DataContext.Produtos.Add(produto);
                _DataContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProdutoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProdutoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProdutoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
