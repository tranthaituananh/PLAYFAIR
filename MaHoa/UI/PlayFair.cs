using System;
using System.Windows.Forms;

namespace MaHoa.UI
{
    public partial class PlayFair : UserControl
    {
        private MaHoa.PlayFair playfair;

        public PlayFair()
        {
            InitializeComponent();
            radioButton4.PerformClick();
            rdbMaHoa.PerformClick();
        }

        //Kiểm tra lựa chọn phương thức của người dùng
        private void radioButtonMethod_CheckedChanged(object sender, EventArgs e)
        {
            var control = ((RadioButton)sender).Name;
            if (control == "rdbGiaiMa")
            {
                lblA.Text = "Cypher Text";
                lblB.Text = "Plain Text";
                btnExecute.Text = "Decrypt";
            }
            else
            {
                lblB.Text = "Cypher Text";
                lblA.Text = "Plain Text";
                btnExecute.Text = "Encrypt";
            }
        }

        //Kiểm tra lựa chọn loại ma trận của người dùng
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            //remove old item in matrix
            this.groupBox1.Controls.Clear();
            var control = ((RadioButton)sender).Text;
            int value = 0;
            switch (control)
            {
                case "6 x 6":
                    value = 6;
                    break;
                case "5 x 5":
                    value = 5;
                    break;
            }
            playfair = new MaHoa.PlayFair(value);
        }

        //Vẽ ma trận
        private void DrawMatrix(MaHoa.Matrix matrix, bool allowModifier)
        {
            //Loại bỏ ma trận cũ
            this.groupBox1.Controls.Clear();
            //Hiện thị ma trận
            var X_begin = 7;
            var Y_begin = 19;
            for (int i = 1; i <= matrix.N_matrix; i++)
            {
                for (int j = 1; j <= matrix.N_matrix; j++)
                {
                    TextBox txt = new TextBox();
                    txt.Location = new System.Drawing.Point(X_begin, Y_begin);
                    txt.Name = "txt" + i.ToString() + j.ToString();
                    txt.Size = new System.Drawing.Size(44, 20);
                    txt.Enabled = allowModifier;
                    if (matrix != null)
                    {
                        txt.Text = matrix.Get(i - 1, j - 1).ToString();
                    }
                    this.groupBox1.Controls.Add(txt);
                    X_begin += 52;
                }
                X_begin = 7;
                Y_begin += 32;
            }
        }

        //Hành động click vào button để vẽ ma trận
        private void btnInitMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                var matrix = playfair.InitMatrix(txtKey.Text);
                DrawMatrix(matrix, false);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while init matrix with key", "Error", MessageBoxButtons.OK);
            }
        }

        //Hành động click vào button để thực hiện theo phương thức của người dùng đã chọn ở trên
        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (rdbMaHoa.Checked) //mã hóa
            {
                try
                {
                    string result = playfair.Encrypt(txtInput.Text);
                    txtResult.Text = result;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error while encrypt data", "Error", MessageBoxButtons.OK);
                }
            }
            else //giải mã
            {
                try
                {
                    string result = playfair.Decrypt(txtInput.Text);
                    txtResult.Text = result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while decrypt data", "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}
