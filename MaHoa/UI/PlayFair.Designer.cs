namespace MaHoa.UI
{
    partial class PlayFair
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbMaHoa = new System.Windows.Forms.RadioButton();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnInitMatrix = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbGiaiMa = new System.Windows.Forms.RadioButton();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.lblB = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbMaHoa
            // 
            this.rdbMaHoa.AutoSize = true;
            this.rdbMaHoa.Location = new System.Drawing.Point(24, 19);
            this.rdbMaHoa.Name = "rdbMaHoa";
            this.rdbMaHoa.Size = new System.Drawing.Size(61, 17);
            this.rdbMaHoa.TabIndex = 0;
            this.rdbMaHoa.TabStop = true;
            this.rdbMaHoa.Text = "Encrypt";
            this.rdbMaHoa.UseVisualStyleBackColor = true;
            this.rdbMaHoa.CheckedChanged += new System.EventHandler(this.radioButtonMethod_CheckedChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(386, 333);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(153, 36);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Encrypt";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnInitMatrix
            // 
            this.btnInitMatrix.Location = new System.Drawing.Point(386, 251);
            this.btnInitMatrix.Name = "btnInitMatrix";
            this.btnInitMatrix.Size = new System.Drawing.Size(153, 51);
            this.btnInitMatrix.TabIndex = 2;
            this.btnInitMatrix.Text = "Init Matrix";
            this.btnInitMatrix.UseVisualStyleBackColor = true;
            this.btnInitMatrix.Click += new System.EventHandler(this.btnInitMatrix_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbGiaiMa);
            this.groupBox3.Controls.Add(this.rdbMaHoa);
            this.groupBox3.Location = new System.Drawing.Point(386, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 77);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Method";
            // 
            // rdbGiaiMa
            // 
            this.rdbGiaiMa.AutoSize = true;
            this.rdbGiaiMa.Location = new System.Drawing.Point(24, 52);
            this.rdbGiaiMa.Name = "rdbGiaiMa";
            this.rdbGiaiMa.Size = new System.Drawing.Size(62, 17);
            this.rdbGiaiMa.TabIndex = 1;
            this.rdbGiaiMa.TabStop = true;
            this.rdbGiaiMa.Text = "Decrypt";
            this.rdbGiaiMa.UseVisualStyleBackColor = true;
            this.rdbGiaiMa.CheckedChanged += new System.EventHandler(this.radioButtonMethod_CheckedChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(110, 349);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(254, 20);
            this.txtResult.TabIndex = 8;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(24, 53);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(48, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "6 x 6";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(24, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(48, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "5 x 5";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(43, 352);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(64, 13);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "Cypher Text";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(386, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 92);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matrix Size";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(43, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 214);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key Matrix";
            // 
            // txtInput
            // 
            this.txtInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInput.Location = new System.Drawing.Point(110, 59);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(254, 20);
            this.txtInput.TabIndex = 0;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(43, 62);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(51, 13);
            this.lblA.TabIndex = 6;
            this.lblA.Text = "PlainText";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhóm 3 - PlayFair";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Key";
            // 
            // txtKey
            // 
            this.txtKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKey.Location = new System.Drawing.Point(110, 92);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(254, 20);
            this.txtKey.TabIndex = 1;
            // 
            // PlayFair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnInitMatrix);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.label1);
            this.Name = "PlayFair";
            this.Size = new System.Drawing.Size(584, 387);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbMaHoa;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnInitMatrix;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbGiaiMa;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
    }
}
