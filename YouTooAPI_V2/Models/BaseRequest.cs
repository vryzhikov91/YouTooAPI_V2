namespace YouTooAPI_V2.Models
{
    public class BaseRequest<T>
    {
        public int? PageNumber { get; set; }
        public int? PageCount { get; set; }
        public T? Filter { get; set; }
    }
}