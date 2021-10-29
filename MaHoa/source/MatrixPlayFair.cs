using System;
using System.Linq;

namespace MaHoa
{
    public class MatrixPlayFair : Matrix
    {
        //Tạo ma trận n dòng và n cột dựa trên phương thức khởi tạo kế thừa từ class Matrix
        public MatrixPlayFair(int n_matrix) : base(n_matrix) { } 

        //Khởi tạo ma trận
        public void CreateMatrix(string key)
        {
            string temp = String.Copy(key);
            var alpha = Alphabet.Tolist();
            var an = alpha + "0123456789";
            //Xóa dấu cách
            temp = temp.Replace(" ", "");
            temp = temp.ToUpper();
            //Key không chứa ký tự đặc biệt
            foreach(char c in temp)
            {
                if (!an.Contains<char>(c))
                    throw new ArgumentException("key don't have special character");
            }
            temp += alpha;
            if(N_matrix == 5)
            {
                temp = temp.Replace('J', 'I');
            }else if(N_matrix == 6)
            {
                temp += "0123456789";
            }
            else
            {
                throw new Exception("size of matrix in [5,6]");
            }
            temp = RemoveSameCharacter(temp);

            int k = 0;
            foreach (char x in temp.ToCharArray())
            {
                base.Set(k / N_matrix, k % N_matrix, x);
                k++;
            }
        }

        //Loại bỏ những ký tự giống nhau trong key
        public string RemoveSameCharacter(string key)
        {
            int i = 0;
            while (i < key.Length - 1)
            {
                int j = i + 1;
                while (j < key.Length)
                {
                    if (key[i] == key[j])
                    {
                        key = key.Remove(j, 1);
                    }
                    else
                    {
                        j++;
                    }
                }
                i++;
            }
            return key;
        }

        //Trả về tạo độ ký tự I và J
        public Coordinate GetCoordinate(char key)
        {
            key = key.ToString().ToUpper()[0];
            for(int i = 0; i < N_matrix; i++)
            {
                for(int j = 0; j < N_matrix; j++)
                {
                    if(matrix[i,j] == key)
                    {
                        Coordinate temp = new Coordinate()
                        {
                            I = i,
                            J = j
                        };
                        return temp;
                    }
                }
            }
            return null;
        }
    }
}
