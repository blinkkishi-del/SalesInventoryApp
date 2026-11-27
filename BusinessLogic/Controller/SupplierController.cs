using BusinessLogic.Repository;
using Model;

namespace BusinessLogic.Controller
{
    public class SupplierController
    {
        private readonly SupplierRepository supplierRepository;

        public SupplierController()
        {
            supplierRepository = new SupplierRepository();
        }

        public void Add(SupplierModel model)
        {
            if (model == null) throw new Exception("Missing parameter: model");
            supplierRepository.AddSupplier(model);
        }

        public void Update(SupplierModel model)
        {
            if (model == null) throw new Exception("Missing parameter: model");
            supplierRepository.UpdateSupplier(model);
        }

        public void Delete(string supplierId)
        {
            if (string.IsNullOrEmpty(supplierId)) throw new Exception("Invalid supplier Id");
            supplierRepository.DeleteSupplier(supplierId);
        }

        public List<SupplierModel> GetAllSuppliers() => supplierRepository.GetAll();
    }
}
