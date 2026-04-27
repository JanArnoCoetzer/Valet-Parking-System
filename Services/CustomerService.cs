using Valet_Parking_System.Classes;
using Valet_Parking_System.Repository.CRUD;

namespace Valet_Parking_System.Services
{
    internal class CustomerService
    {
        internal static int AddCustomerAndReturnId(Customer customer)
        {
            if (customer == null)
                return -1;

            if (customer.ValidateCustomer() != 0)
                return -1;

            return CustomerRepository.AddCustomerAndReturnId(customer);
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