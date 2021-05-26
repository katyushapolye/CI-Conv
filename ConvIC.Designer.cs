
namespace ConvIC_1._0_Alpha
{
    partial class ConvIC
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Confirm = new System.Windows.Forms.Button();
            this.FileSelect = new System.Windows.Forms.OpenFileDialog();
            this.Select_File = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Select_Dir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(295, 451);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(166, 49);
            this.Confirm.TabIndex = 0;
            this.Confirm.Text = "Confirm and Convert";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // FileSelect
            // 
            this.FileSelect.FileName = "Select File";
            // 
            // Select_File
            // 
            this.Select_File.Location = new System.Drawing.Point(295, 67);
            this.Select_File.Name = "Select_File";
            this.Select_File.Size = new System.Drawing.Size(90, 20);
            this.Select_File.TabIndex = 1;
            this.Select_File.Text = "Select File";
            this.Select_File.UseVisualStyleBackColor = true;
            this.Select_File.Click += new System.EventHandler(this.Select_File_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 20);
            this.textBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(523, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Weight?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selected JSON File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Save File Directory";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 20);
            this.textBox2.TabIndex = 6;
            // 
            // Select_Dir
            // 
            this.Select_Dir.Location = new System.Drawing.Point(295, 119);
            this.Select_Dir.Name = "Select_Dir";
            this.Select_Dir.Size = new System.Drawing.Size(90, 20);
            this.Select_Dir.TabIndex = 7;
            this.Select_Dir.Text = "Select Directory";
            this.Select_Dir.UseVisualStyleBackColor = true;
            // 
            // ConvIC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 512);
            this.Controls.Add(this.Select_Dir);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Select_File);
            this.Controls.Add(this.Confirm);
            this.Name = "ConvIC";
            this.Text = "ConvIC";
            this.Load += new System.EventHandler(this.ConvIC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.OpenFileDialog FileSelect;
        private System.Windows.Forms.Button Select_File;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Select_Dir;
    }
}

