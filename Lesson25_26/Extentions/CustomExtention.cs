namespace Lesson25_26.Extentions;

public static class CustomExtention
{
    public static IEnumerable<int> GetEnumerator(this int x)
    {
        for (int i = 0; i < x; i++)
        {
            yield return i;
        }
    }



}
 