namespace Indexers;

public class Suduko
{
    public int[,] _matrix;
    public Suduko(int[,] matrix) =>
        _matrix = matrix;

    public int this[int row, int column]
    {
        get
        {
            return _matrix[row, column];
        }
        set
        {
            _matrix[row, column] = value;
        }
    }
}
