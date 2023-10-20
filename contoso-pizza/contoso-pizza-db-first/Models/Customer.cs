using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contoso_pizza_db_first.Models
{
    public partial class Customer
    {
        public string FullName
        {
            get => $"{FirstName} {LastName}";
        }
    }
}
