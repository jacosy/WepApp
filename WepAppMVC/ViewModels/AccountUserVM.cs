namespace WepAppMVC.ViewModels
{
    public class AccountUserVM
    {
        public string Account { get; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string AccountStatus { get; set; }
        public string ValidStartTime { get; set; }
        public string ValidEndTime { get; set; }
        public string LastLoginIP { get; set; }
        public string LastLoginTime { get; set; }

        public AccountUserVM(string account)
        {
            Account = account;
        }
    }
}