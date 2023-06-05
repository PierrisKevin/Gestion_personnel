using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_chambre
{
    internal class connectDB
    {
        public string dbConnect()
        {
            string connectionString = "server=localhost;database=hotel_management;user=root;password=";
            return connectionString;
        }
    }
}
