using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProject.Models
{
    public class UserResponseModel
    {
        public List<UserModel> userList { get; set; }
    }

    public class UserModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string BankAccountNo { get; set; }
        public string CardType { get; set; }
    }
}
