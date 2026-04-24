using Valet_Parking_System.Classes;
using Valet_Parking_System.Repository.CRUD;

namespace Valet_Parking_System.Services
{
    internal class CustomerService
    {
        public static bool AddCustomer(Customer customer)
        {
            if (customer == null)
                return false;

            if (customer.ValidateCustomer() != 0)
                return false;

            return CustomerRepository.AddCustomer(customer);
        }

        public static bool EditCustomer(Customer customer)
        {
            if (customer == null)
                return false;

            if (customer.ValidateCustomer() != 0)
                return false;

            return CustomerRepository.EditCustomer(customer);
        }

        public static bool RemoveCustomer(Customer customer)
        {
            if (customer == null)
                return false;

            return CustomerRepository.RemoveCustomer(customer);
        }
    }
}