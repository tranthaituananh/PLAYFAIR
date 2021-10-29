namespace MaHoa
{
    public static class Alphabet
    {
        //Trả về vị trí của ký tự
        public static int GetPosition(char Chu_cai)
        {
            return (int)(Chu_cai) - 64;
        }
        
        //Trả về ký tự
        public static char GetCharacter(int x)
        {
            return (char)(x + 64);
        }

        public static char Seed(int currentPos, int offset)
        {
            int c = (currentPos + offset) % 26;
            return (char)(c + 64);
        }

        //Liệt kê ký tự bảng chữ cái
        public static string Tolist()
        {
            string str = null;
            for (int i = 0; i < 26; i++)
            {
                str += (char)(65 + i);
            }
            return str;
        }
    }
}
