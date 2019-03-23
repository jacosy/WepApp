namespace WepAppMVC.ViewModels
{
    public class AccountUserVM
    {
        public string Account { get; }
        public string FullName { get; set; }
        public string AccountStatus { get; set; }
        public string ValidStartDate { get; set; }
        public string ValidStartTime { get; set; }
        public string ValidEndDate { get; set; }
        public string ValidEndTime { get; set; }
        public string LastLoginIP { get; set; }
        public string LastLoginTime { get; set; }
    }
}