namespace Yazilimpark.Models
{
    public class QueryFilter
    {
        private const int DefaultPageSize = 20;
        private const int DefaultPageNumber = 0;

        private int pageSize = DefaultPageSize;
        private int pageNumber = DefaultPageNumber;

        public int PageSize
        {
            get => pageSize;
            set => pageSize = (value <= 0 || value > 20) ? DefaultPageSize : value;
        }

        public int PageNumber
        {
            get => pageNumber;
            set => pageNumber = value < 0 ? 0 : value;
        }
        
    }
}
