using BusinessLogic.Repository;
using System.Data;

namespace BusinessLogic.Controller
{
    public class SalesController
    {
        private readonly SalesRepository salesRepository;

        public SalesController() => salesRepository = new SalesRepository();

 
    }
}
