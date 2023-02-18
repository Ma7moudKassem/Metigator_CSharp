namespace Pagination;

public static class Extentions
{
    public static IEnumerable<T> Paginate<T>(this IEnumerable<T> source, int page = 1, int size = 10)
    {
        if (source is null || !source.Any())
            throw new ArgumentNullException("source mustn't be empty or null");

        int _page = page; int _size = size;

        if (_page <= 0) _page = 1;
        if (_size <= 0) _size = 10;

        int total = source.Count();
        int pages = (int)Math.Ceiling((decimal)total / size);

        IEnumerable<T> result = source.Skip((_page - 1) * size).Take(_size);

        return result;
    }
}
