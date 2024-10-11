namespace MAHOADES_NHOM9_ANTT
{
    partial class DES_Encrpytion
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBanRo = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.radioEncryp = new System.Windows.Forms.RadioButton();
            this.radioDecryp = new System.Windows.Forms.RadioButton();
            this.GenKey = new System.Windows.Forms.Button();
            this.dgvListKey = new System.Windows.Forms.DataGridView();
            this.dgvKeyLR = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeyLR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1407, 65);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ HÓA DES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập bản tin M:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập khóa K:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBanRo
            // 
            this.txtBanRo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanRo.Location = new System.Drawing.Point(224, 89);
            this.txtBanRo.Margin = new System.Windows.Forms.Padding(4);
            this.txtBanRo.Multiline = true;
            this.txtBanRo.Name = "txtBanRo";
            this.txtBanRo.Size = new System.Drawing.Size(332, 46);
            this.txtBanRo.TabIndex = 3;
            this.txtBanRo.Text = "0123456789ABCDEF";
            this.txtBanRo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBanRo.TextChanged += new System.EventHandler(this.txtBanRo_TextChanged);
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(224, 182);
            this.txtKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(332, 46);
            this.txtKey.TabIndex = 4;
            this.txtKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 383);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kết quả:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(224, 373);
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(332, 46);
            this.txtResult.TabIndex = 6;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(224, 306);
            this.btnResult.Margin = new System.Windows.Forms.Padding(4);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(121, 41);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "Nộp";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnEncrpytion_Click);
            // 
            // radioEncryp
            // 
            this.radioEncryp.AutoSize = true;
            this.radioEncryp.Location = new System.Drawing.Point(224, 255);
            this.radioEncryp.Margin = new System.Windows.Forms.Padding(4);
            this.radioEncryp.Name = "radioEncryp";
            this.radioEncryp.Size = new System.Drawing.Size(73, 20);
            this.radioEncryp.TabIndex = 8;
            this.radioEncryp.TabStop = true;
            this.radioEncryp.Text = "Mã hóa";
            this.radioEncryp.UseVisualStyleBackColor = true;
            this.radioEncryp.CheckedChanged += new System.EventHandler(this.radioEncryp_CheckedChanged);
            // 
            // radioDecryp
            // 
            this.radioDecryp.AutoSize = true;
            this.radioDecryp.Location = new System.Drawing.Point(405, 255);
            this.radioDecryp.Margin = new System.Windows.Forms.Padding(4);
            this.radioDecryp.Name = "radioDecryp";
            this.radioDecryp.Size = new System.Drawing.Size(74, 20);
            this.radioDecryp.TabIndex = 9;
            this.radioDecryp.TabStop = true;
            this.radioDecryp.Text = "Giải mã";
            this.radioDecryp.UseVisualStyleBackColor = true;
            this.radioDecryp.CheckedChanged += new System.EventHandler(this.radioDecryp_CheckedChanged);
            // 
            // GenKey
            // 
            this.GenKey.Location = new System.Drawing.Point(436, 306);
            this.GenKey.Margin = new System.Windows.Forms.Padding(4);
            this.GenKey.Name = "GenKey";
            this.GenKey.Size = new System.Drawing.Size(121, 41);
            this.GenKey.TabIndex = 10;
            this.GenKey.Text = "Sinh Khóa";
            this.GenKey.UseVisualStyleBackColor = true;
            this.GenKey.Click += new System.EventHandler(this.GenKey_Click);
            // 
            // dgvListKey
            // 
            this.dgvListKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListKey.Location = new System.Drawing.Point(580, 89);
            this.dgvListKey.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListKey.Name = "dgvListKey";
            this.dgvListKey.RowHeadersWidth = 51;
            this.dgvListKey.Size = new System.Drawing.Size(345, 482);
            this.dgvListKey.TabIndex = 11;
            // 
            // dgvKeyLR
            // 
            this.dgvKeyLR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeyLR.Location = new System.Drawing.Point(933, 89);
            this.dgvKeyLR.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKeyLR.Name = "dgvKeyLR";
            this.dgvKeyLR.RowHeadersWidth = 51;
            this.dgvKeyLR.Size = new System.Drawing.Size(474, 482);
            this.dgvKeyLR.TabIndex = 12;
            this.dgvKeyLR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKeyLR_CellContentClick);
            // 
            // DES_Encrpytion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 586);
            this.Controls.Add(this.dgvKeyLR);
            this.Controls.Add(this.dgvListKey);
            this.Controls.Add(this.GenKey);
            this.Controls.Add(this.radioDecryp);
            this.Controls.Add(this.radioEncryp);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtBanRo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DES_Encrpytion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DES_Encrpytion";
            this.Load += new System.EventHandler(this.DES_Encrpytion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeyLR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBanRo;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.RadioButton radioEncryp;
        private System.Windows.Forms.RadioButton radioDecryp;
        private System.Windows.Forms.Button GenKey;
        private System.Windows.Forms.DataGridView dgvListKey;
        private System.Windows.Forms.DataGridView dgvKeyLR;
    }
}

