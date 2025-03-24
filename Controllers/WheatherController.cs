using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Study.Models;

namespace Study.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WheatherController : Controller
    {
        public readonly MyDbContext _myDbContext;
        public WheatherController(MyDbContext db)
        {
            _myDbContext = db;
        }
        public ViewResult Index()
        {
            return View() ;
        }
        [HttpGet(Name ="GetRecords")]
        public List<string> GetRecords(int id=10)
        {
            List<string> records = new List<string>();
            try
            {
                // Create Dummat String list  
                for(int i = 0; i < id; i++)
                {
                    records.Add(i.ToString());
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
            return records;
        }

        [HttpGet]       
        [Route("UpdateDataBase")]
        public Task<bool> UpdateDataBase()
        {
            // Create a List of Products 
            
            Myproducts products = new Myproducts()
            {
                Id = 1,
                productName = "Product 1",
                productPrice = 100
            };
            

            // Add to database 
            _myDbContext.myProducts.Add(products);
            _myDbContext.SaveChanges();



            return Task.FromResult(true);
        }
    }
}
