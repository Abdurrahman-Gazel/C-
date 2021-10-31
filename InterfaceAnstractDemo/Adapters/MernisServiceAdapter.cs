using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAnstractDemo.Abstract;
using InterfaceAnstractDemo.Adapters;
using InterfaceAnstractDemo.Entities;
using MernisServiceReference1;

namespace InterfaceAnstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomercheckService
    {

        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(customer.NationalityId,customer.FirstName.ToUpper(),customer.LastName.ToUpper(), customer.DateOfBirth.Year);

    }
}
