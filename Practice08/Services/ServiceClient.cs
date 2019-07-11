using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practice08.Models;

namespace Practice08.Services
{
    public class ServiceClient
    {

        public Client getClient()
        {
            return new Client { ClientId=1, Name="Juanito", BirthDate = new DateTime(1980,3,20) };
        }

        public List<Client> getClients()
        {
            Client client1 = new Client { ClientId = 1, Name = "Juanito", BirthDate = new DateTime(1980, 3, 20) };
            Client client2 = new Client { ClientId = 2, Name = "Pedrito", BirthDate = new DateTime(1980, 3, 20) };

            return new List<Client> { client1, client2 };
        }

    }
}