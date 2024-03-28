namespace WinFormsValidator
{
    partial class Form3
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
            welcomeLabel = new Label();
            pictureBox = new PictureBox();
            uploadButton = new Button();
            labelE = new Label();
            labelG = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(44, 22);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(76, 31);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "label1";
            // 
            // pictureBox
            // 
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.Location = new Point(44, 70);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(215, 216);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // uploadButton
            // 
            uploadButton.Location = new Point(45, 292);
            uploadButton.Name = "uploadButton";
            uploadButton.Size = new Size(75, 23);
            uploadButton.TabIndex = 2;
            uploadButton.Text = "uploadPic";
            uploadButton.UseVisualStyleBackColor = true;
            uploadButton.Click += uploadButton_Click;
            // 
            // labelE
            // 
            labelE.AutoSize = true;
            labelE.Location = new Point(282, 70);
            labelE.Name = "labelE";
            labelE.Size = new Size(38, 15);
            labelE.TabIndex = 3;
            labelE.Text = "labelE";
            // 
            // labelG
            // 
            labelG.AutoSize = true;
            labelG.Location = new Point(282, 102);
            labelG.Name = "labelG";
            labelG.Size = new Size(40, 15);
            labelG.TabIndex = 4;
            labelG.Text = "labelG";
            // 
            // button1
            // 
            button1.Location = new Point(282, 244);
            button1.Name = "button1";
            button1.Size = new Size(75, 42);
            button1.TabIndex = 5;
            button1.Text = "reserve a court";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgroundcolor;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(labelG);
            Controls.Add(labelE);
            Controls.Add(uploadButton);
            Controls.Add(pictureBox);
            Controls.Add(welcomeLabel);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private PictureBox pictureBox;
        private Button uploadButton;
        private Label labelE;
        private Label labelG;
        private Button button1;
    }
}