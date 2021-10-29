using System;

namespace MaHoa
{
    public class PlayFair
    {
        private MatrixPlayFair matrix;

        //Ma trận n dòng n cột
        public PlayFair(int n)
        {
            matrix = new MatrixPlayFair(n);
        }

        //Khởi tạo ma trận dựa trên key
        public MatrixPlayFair InitMatrix(string key)
        {
            matrix.CreateMatrix(key);
            return matrix;
        }

        //Loại bỏ khoảng trắng trong chuỗi
        public string RemoveSpaceInString(string text)
        {
            var temp = String.Copy(text);
            int i = 0;
            while(i < temp.Length)
            {
                if(temp[i] == ' ')
                {
                    temp = temp.Remove(i, 1);
                }
                else
                {
                    i++;
                }
            }
            return temp;
        }

        public string HoanDoi(Coordinate dau, Coordinate cuoi, bool isEncrypt = true)
        {
            int value = 1;
            if (!isEncrypt)
            {
                value = -1;
            }
            //Kiểm tra tọa độ
            if (!(dau.I < matrix.N_matrix && dau.I >= 0
                && dau.J < matrix.N_matrix && dau.J >= 0
                && cuoi.I < matrix.N_matrix && cuoi.I >= 0
                && cuoi.J < matrix.N_matrix && cuoi.J >= 0))
                throw new IndexOutOfRangeException();
            var result = "";
            if (dau.I == cuoi.I) //Cùng dòng
            {
                result += matrix.Get(dau.I, ((dau.J + value)+ matrix.N_matrix) % matrix.N_matrix);
                result += matrix.Get(cuoi.I, ((cuoi.J + value) + matrix.N_matrix) % matrix.N_matrix);
            }
            else if (dau.J == cuoi.J) //Cùng cột
            {
                result += matrix.Get(((dau.I + value) + matrix.N_matrix) % matrix.N_matrix, dau.J);
                result += matrix.Get(((cuoi.I + value) + matrix.N_matrix) % matrix.N_matrix, cuoi.J);
            }
            else
            {
                result += matrix.Get(dau.I, cuoi.J);
                result += matrix.Get(cuoi.I, dau.J);
            }
            result += " ";
            return result;
        }

        public string EncryptTwoCharacter(char one, char two)
        {
            if (one == ' ' || two == ' ')
                throw new ArgumentException();
            //Lấy tọa độ của cặp ký tự
            Coordinate c_one, c_two;
            c_one = matrix.GetCoordinate(one);
            c_two = matrix.GetCoordinate(two);
            if (c_one == null || c_two == null)
                throw new ArgumentException();

            //Mã hóa cặp ký tự
            string result = HoanDoi(c_one, c_two);
            result += " ";
            return result;
        }

        public string Encrypt(string plainText)
        {
            //Xóa dấu cách
            plainText = RemoveSpaceInString(plainText);

            if (plainText.Length == 0)
                throw new ArgumentException("plaintext is empty");

            if(plainText.Length % 2 != 0)
            {
                plainText += "X";
            }
            //Tách cặp ký tự để mã hóa
            int i = 0;
            string result = "";
            while(i < plainText.Length)
            {
                var temp = EncryptTwoCharacter(plainText[i], plainText[i + 1]);
                result += temp ?? throw new ArgumentException("plain text invalid");
                i += 2;
            }
            return result;
        }

        public string DecryptTwoCharacter(char one, char two)
        {
            if (one == ' ' || two == ' ')
                throw new ArgumentException();
            //lấy tọa độ của cặp ký tự
            Coordinate c_one, c_two;
            c_one = matrix.GetCoordinate(one);
            c_two = matrix.GetCoordinate(two);
            if (c_one == null || c_two == null)
                throw new ArgumentException();

            //Giải mã cặp ký tự
            string result = HoanDoi(c_one, c_two,false);
            result += " ";
            return result;
        }

        public string Decrypt(string plainText)
        {
            //Xóa dấu cách
            plainText = RemoveSpaceInString(plainText);
            if (plainText.Length == 0)
                throw new ArgumentException("plaintext is empty");

            if (plainText.Length % 2 != 0)
            {
                plainText += "X";
            }
            //Tách cặp hai ký tự để giải mã
            int i = 0;
            string result = "";
            while (i < plainText.Length)
            {
                var temp = DecryptTwoCharacter(plainText[i], plainText[i + 1]);
                result += temp ?? throw new ArgumentException("plain text invalid");
                i += 2;
            }
            return result;
        }
    }
}
