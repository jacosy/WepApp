namespace WebApp.Common.Models
{
    public class AjaxData<T>
    {
        public T data { get; set; }
        public bool isSucceeded { get; set; }
        public string message { get; set; }
    }
}