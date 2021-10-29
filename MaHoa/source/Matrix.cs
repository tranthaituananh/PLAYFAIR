namespace MaHoa
{
    public class Matrix
    {
        public char[,] matrix;
        public int N_matrix; //size of matrix

        public Matrix(int n)
        {
            N_matrix = n;
            matrix = new char[N_matrix, N_matrix];
        }

        public char Get(int i, int j)
        {
            return matrix[i, j];
        }

        public char Get(Coordinate cor)
        {
            return matrix[cor.I, cor.J];
        }

        public void Set(int i, int j, char value)
        {
            matrix[i, j] = value.ToString().ToUpper()[0];
        }
    }
}
