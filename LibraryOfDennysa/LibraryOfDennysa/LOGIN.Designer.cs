
namespace LibraryOfDennysa
{
    partial class LOGIN
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelParola = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.butonLogin = new System.Windows.Forms.Button();
            this.butonSign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Parchment", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(504, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 114);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.BackColor = System.Drawing.Color.Transparent;
            this.labelParola.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelParola.Font = new System.Drawing.Font("Parchment", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParola.ForeColor = System.Drawing.Color.White;
            this.labelParola.Location = new System.Drawing.Point(316, 339);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(266, 102);
            this.labelParola.TabIndex = 2;
            this.labelParola.Text = "Parola:    ";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelUser.Font = new System.Drawing.Font("Parchment", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.White;
            this.labelUser.Location = new System.Drawing.Point(314, 237);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(268, 102);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "Utilizator:";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Parchment", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Maroon;
            this.exit.Location = new System.Drawing.Point(1153, -3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(74, 68);
            this.exit.TabIndex = 4;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.White;
            this.textBoxPass.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxPass.Location = new System.Drawing.Point(586, 384);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(255, 23);
            this.textBoxPass.TabIndex = 5;
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.BackColor = System.Drawing.Color.White;
            this.comboBoxUser.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUser.ForeColor = System.Drawing.Color.Maroon;
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.ItemHeight = 15;
            this.comboBoxUser.Location = new System.Drawing.Point(588, 283);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(253, 23);
            this.comboBoxUser.TabIndex = 6;
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            // 
            // butonLogin
            // 
            this.butonLogin.BackColor = System.Drawing.Color.Maroon;
            this.butonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butonLogin.Font = new System.Drawing.Font("Parchment", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonLogin.ForeColor = System.Drawing.Color.White;
            this.butonLogin.Location = new System.Drawing.Point(469, 540);
            this.butonLogin.Name = "butonLogin";
            this.butonLogin.Size = new System.Drawing.Size(133, 73);
            this.butonLogin.TabIndex = 7;
            this.butonLogin.Text = "login";
            this.butonLogin.UseVisualStyleBackColor = false;
            this.butonLogin.Click += new System.EventHandler(this.butonLogin_Click);
            // 
            // butonSign
            // 
            this.butonSign.BackColor = System.Drawing.Color.Maroon;
            this.butonSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butonSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butonSign.Font = new System.Drawing.Font("Parchment", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonSign.ForeColor = System.Drawing.Color.White;
            this.butonSign.Location = new System.Drawing.Point(622, 540);
            this.butonSign.Name = "butonSign";
            this.butonSign.Size = new System.Drawing.Size(133, 73);
            this.butonSign.TabIndex = 8;
            this.butonSign.Text = "sign in";
            this.butonSign.UseVisualStyleBackColor = false;
            this.butonSign.Click += new System.EventHandler(this.butonSign_Click);
            // 
            // LOGIN
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::LibraryOfDennysa.Properties.Resources.loginBg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 700);
            this.Controls.Add(this.butonSign);
            this.Controls.Add(this.butonLogin);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Vivaldi", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Button butonLogin;
        private System.Windows.Forms.Button butonSign;
    }
}

