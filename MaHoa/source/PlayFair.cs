using System;

namespace MaHoa
{
    public class PlayFair
    {
        private MatrixPlayFair matrix;

        public PlayFair(int n)
        {
            matrix = new MatrixPlayFair(n);
        }

        public MatrixPlayFair InitMatrix(string key)
        {
            matrix.CreateMatrix(key);
            return matrix;
        }

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
            //check coordinate
            if (!(dau.I < matrix.N_matrix && dau.I >= 0
                && dau.J < matrix.N_matrix && dau.J >= 0
                && cuoi.I < matrix.N_matrix && cuoi.I >= 0
                && cuoi.J < matrix.N_matrix && cuoi.J >= 0))
                throw new IndexOutOfRangeException();
            var result = "";
            if (dau.I == cuoi.I) //same row
            {
                result += matrix.Get(dau.I, ((dau.J + value)+ matrix.N_matrix) % matrix.N_matrix);
                result += matrix.Get(cuoi.I, ((cuoi.J + value) + matrix.N_matrix) % matrix.N_matrix);
            }
            else if (dau.J == cuoi.J) //same column
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
            //get coordinate of one and two
            Coordinate c_one, c_two;
            c_one = matrix.GetCoordinate(one);
            c_two = matrix.GetCoordinate(two);
            if (c_one == null || c_two == null)
                throw new ArgumentException();

            //encrypt two character
            string result = HoanDoi(c_one, c_two);
            result += " ";
            return result;
        }

        public string Encrypt(string plainText)
        {
            //remove space 
            plainText = RemoveSpaceInString(plainText);

            if (plainText.Length == 0)
                throw new ArgumentException("plaintext is empty");

            if(plainText.Length % 2 != 0)
            {
                plainText += "X";
            }
            //split pair two character to encrypt
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
            //get coordinate of one and two
            Coordinate c_one, c_two;
            c_one = matrix.GetCoordinate(one);
            c_two = matrix.GetCoordinate(two);
            if (c_one == null || c_two == null)
                throw new ArgumentException();

            //encrypt two character
            string result = HoanDoi(c_one, c_two,false);
            result += " ";
            return result;
        }

        public string Decrypt(string plainText)
        {
            //remove space 
            plainText = RemoveSpaceInString(plainText);
            if (plainText.Length == 0)
                throw new ArgumentException("plaintext is empty");

            if (plainText.Length % 2 != 0)
            {
                plainText += "X";
            }
            //split pair two character to encrypt
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
