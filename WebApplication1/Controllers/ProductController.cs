using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web.Mvc;
using WebApplication1.BusinessLogic.MainBL;
using WebApplication1.Domain.Entities.User;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductContext _context;

        public ProductController()
        {
            _context = new ProductContext(); // Inițializare a variabilei _context
        }

        public ActionResult Index()
        {
            List<Product> products = _context.Products.ToList();
            return View(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Product prod = new Product();
            return View(prod);
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        ModelState.AddModelError(validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
                return View(product); // Returnăm din nou view-ul cu modelul pentru a afișa erorile de validare
            }
        }

        public ActionResult Details(string Id)
        {
            Product prod = _context.Products.Where(p => p.Code == Id).FirstOrDefault();
            return View(prod);
        }


        [HttpGet]
        public ActionResult Edit(string Id)
        {
            Product prod = _context.Products.Where(p => p.Code == Id).FirstOrDefault();
            return View(prod);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            _context.Products.Attach(product);
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("index");
        }


        [HttpGet]
        public ActionResult Delete(string Id)
        {
            Product prod = _context.Products.Where(p => p.Code == Id).FirstOrDefault();
            return View(prod);
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {
            _context.Products.Attach(product);
            _context.Entry(product).State = EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction("index");
        }

    }
}
