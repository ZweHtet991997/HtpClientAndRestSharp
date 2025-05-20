using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Models
{
    public class AccountResponseModel
    {
        public List<AccountsModel> lstAccountInformation { get; set; }
    }

    public class AccountsModel
    {
        public int Id { get; set; }
        public string AccountNo { get; set; }
        public string AccountType { get; set; }
        public decimal AvailableBalance { get; set; }
        public bool IsAccountActive { get; set; }
    }
}
