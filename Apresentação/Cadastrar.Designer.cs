
namespace WindowsFormsApp2
{
    partial class Cadastrar
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
            this.Login = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.Label();
            this.confirmsenha = new System.Windows.Forms.Label();
            this.logincad = new System.Windows.Forms.TextBox();
            this.confcad = new System.Windows.Forms.TextBox();
            this.senhacad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(45, 26);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(52, 21);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha.Location = new System.Drawing.Point(46, 85);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(57, 21);
            this.senha.TabIndex = 1;
            this.senha.Text = "Senha";
            this.senha.Click += new System.EventHandler(this.label2_Click);
            // 
            // confirmsenha
            // 
            this.confirmsenha.AutoSize = true;
            this.confirmsenha.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmsenha.Location = new System.Drawing.Point(45, 148);
            this.confirmsenha.Name = "confirmsenha";
            this.confirmsenha.Size = new System.Drawing.Size(137, 21);
            this.confirmsenha.TabIndex = 2;
            this.confirmsenha.Text = "Confirmar senha";
            // 
            // logincad
            // 
            this.logincad.Location = new System.Drawing.Point(49, 51);
            this.logincad.Name = "logincad";
            this.logincad.Size = new System.Drawing.Size(134, 20);
            this.logincad.TabIndex = 3;
            // 
            // confcad
            // 
            this.confcad.Location = new System.Drawing.Point(48, 172);
            this.confcad.Name = "confcad";
            this.confcad.PasswordChar = '*';
            this.confcad.Size = new System.Drawing.Size(134, 20);
            this.confcad.TabIndex = 4;
            // 
            // senhacad
            // 
            this.senhacad.Location = new System.Drawing.Point(49, 110);
            this.senhacad.Name = "senhacad";
            this.senhacad.PasswordChar = '*';
            this.senhacad.Size = new System.Drawing.Size(134, 20);
            this.senhacad.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(59, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.senhacad);
            this.Controls.Add(this.confcad);
            this.Controls.Add(this.logincad);
            this.Controls.Add(this.confirmsenha);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.Cadastrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.Label confirmsenha;
        private System.Windows.Forms.TextBox logincad;
        private System.Windows.Forms.TextBox confcad;
        private System.Windows.Forms.TextBox senhacad;
        private System.Windows.Forms.Button button1;
    }
}