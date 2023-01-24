namespace Indexers;

public class IP
{
    private int[] segments = new int[4];
    public IP(int segment1, int segment2, int segment3, int segment4)
        => (segments[0], segments[1], segments[2], segments[3]) = (segment1, segment2, segment3, segment4);
    public IP(string segs)
    {
        string[] segsToInt = segs.Split(".");
        for (int i = 0; i < segsToInt.Length; i++)
        {
            segments[i] = Convert.ToInt32(segsToInt[i]);
        }
    }
    public string IPAddress => string.Join(".", segments);

    public int this[int index]
    {
        get { return segments[index]; }
        set { segments[index] = value; }
    }
}
