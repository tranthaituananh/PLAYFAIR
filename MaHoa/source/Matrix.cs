namespace MaHoa
{
    public class Matrix
    {
        public char[,] matrix;//Khai báo ma trận 
        public int N_matrix;//Kích cỡ của ma trận

        //Tạo ma trận có cùng số hàng và số cột
        public Matrix(int n)
        {
            N_matrix = n;
            matrix = new char[N_matrix, N_matrix];
        }

        //Trả về ký tự tại dòng i cột j
        public char Get(int i, int j)
        {
            return matrix[i, j];
        }

        //Trả về I và J cùng chung giá trị
        public char Get(Coordinate cor)
        {
            return matrix[cor.I, cor.J];
        }

        //Đưa ký tự vào vị trí của ma trận (tất cả ký tự in hoa)
        public void Set(int i, int j, char value)
        {
            matrix[i, j] = value.ToString().ToUpper()[0];
        }
    }
}
