using Microsoft.AspNetCore.Mvc;

namespace Study.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WheatherController : Controller
    {  
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
    }
}
