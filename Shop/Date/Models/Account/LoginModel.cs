using System.ComponentModel.DataAnnotations;

namespace Lucky.Date.Models.Account
{
    public class LoginModel
    {

        public string Login { get; set; }


        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
