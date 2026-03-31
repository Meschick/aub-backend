namespace aub_backend.Application.DTOs
{
    public class PagedResponse<T>
    {
        public IEnumerable<T> ?Data { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
         public int TotalCount { get; set; }

        public PagedResponse(IEnumerable<T> data, int count, int pageNumber, int pageSize)
        {
            Data = data;
            TotalCount = count;
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }
    }
}
