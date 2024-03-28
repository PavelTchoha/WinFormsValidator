namespace WinFormsValidator
{
    partial class Form2
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
            passwordLabel = new Label();
            passwordBox = new TextBox();
            usernameLabel = new Label();
            SignInLabel = new Label();
            usernameBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Yu Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            passwordLabel.Location = new Point(309, 173);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(76, 20);
            passwordLabel.TabIndex = 11;
            passwordLabel.Text = "password";
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(309, 196);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(111, 23);
            passwordBox.TabIndex = 10;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Yu Gothic", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            usernameLabel.Location = new Point(309, 112);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(77, 20);
            usernameLabel.TabIndex = 9;
            usernameLabel.Text = "username";
            // 
            // SignInLabel
            // 
            SignInLabel.AutoSize = true;
            SignInLabel.Font = new Font("Yu Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SignInLabel.Location = new Point(309, 67);
            SignInLabel.Name = "SignInLabel";
            SignInLabel.Size = new Size(97, 31);
            SignInLabel.TabIndex = 8;
            SignInLabel.Text = "Sign In";
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(309, 136);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(111, 23);
            usernameBox.TabIndex = 7;
            usernameBox.TextChanged += usernameBox_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(309, 241);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += si_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundcolor;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(passwordLabel);
            Controls.Add(passwordBox);
            Controls.Add(usernameLabel);
            Controls.Add(SignInLabel);
            Controls.Add(usernameBox);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label passwordLabel;
        private TextBox passwordBox;
        private Label usernameLabel;
        private Label SignInLabel;
        private TextBox usernameBox;
        private Button button1;
    }
}