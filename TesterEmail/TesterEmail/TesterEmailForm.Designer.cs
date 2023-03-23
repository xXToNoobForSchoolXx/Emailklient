namespace TesterEmail
{
    partial class TesterEmailForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxFrom = new TextBox();
            textBoxTo = new TextBox();
            textBoxSubject = new TextBox();
            textBoxSMTP = new TextBox();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            textBoxMassage = new TextBox();
            textBoxAttach = new TextBox();
            buttonAttach = new Button();
            buttonSend = new Button();
            labelMassage = new Label();
            labelSubject = new Label();
            labelTo = new Label();
            labelFrom = new Label();
            labelSMTP = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            SuspendLayout();
            // 
            // textBoxFrom
            // 
            textBoxFrom.Location = new Point(100, 100);
            textBoxFrom.Multiline = true;
            textBoxFrom.Name = "textBoxFrom";
            textBoxFrom.Size = new Size(350, 25);
            textBoxFrom.TabIndex = 0;
            // 
            // textBoxTo
            // 
            textBoxTo.Location = new Point(100, 140);
            textBoxTo.Multiline = true;
            textBoxTo.Name = "textBoxTo";
            textBoxTo.Size = new Size(350, 25);
            textBoxTo.TabIndex = 1;
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(100, 180);
            textBoxSubject.Multiline = true;
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(350, 25);
            textBoxSubject.TabIndex = 2;
            // 
            // textBoxSMTP
            // 
            textBoxSMTP.Location = new Point(580, 100);
            textBoxSMTP.Multiline = true;
            textBoxSMTP.Name = "textBoxSMTP";
            textBoxSMTP.Size = new Size(350, 25);
            textBoxSMTP.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(580, 140);
            textBoxUsername.Multiline = true;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(350, 25);
            textBoxUsername.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(580, 180);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(350, 25);
            textBoxPassword.TabIndex = 5;
            // 
            // textBoxMassage
            // 
            textBoxMassage.Location = new Point(100, 220);
            textBoxMassage.Multiline = true;
            textBoxMassage.Name = "textBoxMassage";
            textBoxMassage.Size = new Size(350, 210);
            textBoxMassage.TabIndex = 6;
            // 
            // textBoxAttach
            // 
            textBoxAttach.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAttach.Location = new Point(580, 270);
            textBoxAttach.Multiline = true;
            textBoxAttach.Name = "textBoxAttach";
            textBoxAttach.Size = new Size(350, 25);
            textBoxAttach.TabIndex = 7;
            // 
            // buttonAttach
            // 
            buttonAttach.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAttach.Location = new Point(480, 270);
            buttonAttach.Name = "buttonAttach";
            buttonAttach.Size = new Size(80, 25);
            buttonAttach.TabIndex = 8;
            buttonAttach.Text = "Attach";
            buttonAttach.UseVisualStyleBackColor = true;
            buttonAttach.Click += buttonAttach_Click;
            // 
            // buttonSend
            // 
            buttonSend.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSend.Location = new Point(715, 350);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(80, 25);
            buttonSend.TabIndex = 9;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // labelMassage
            // 
            labelMassage.AutoSize = true;
            labelMassage.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMassage.Location = new Point(30, 220);
            labelMassage.Name = "labelMassage";
            labelMassage.Size = new Size(63, 19);
            labelMassage.TabIndex = 16;
            labelMassage.Text = "Massage";
            // 
            // labelSubject
            // 
            labelSubject.AutoSize = true;
            labelSubject.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSubject.Location = new Point(30, 180);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(55, 19);
            labelSubject.TabIndex = 17;
            labelSubject.Text = "Subject";
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTo.Location = new Point(30, 140);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(25, 19);
            labelTo.TabIndex = 18;
            labelTo.Text = "To";
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFrom.Location = new Point(30, 100);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(42, 19);
            labelFrom.TabIndex = 19;
            labelFrom.Text = "From";
            // 
            // labelSMTP
            // 
            labelSMTP.AutoSize = true;
            labelSMTP.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSMTP.Location = new Point(480, 100);
            labelSMTP.Name = "labelSMTP";
            labelSMTP.Size = new Size(93, 19);
            labelSMTP.TabIndex = 20;
            labelSMTP.Text = "SMTP Server";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.Location = new Point(480, 140);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(70, 19);
            labelUsername.TabIndex = 21;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(480, 180);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(69, 19);
            labelPassword.TabIndex = 22;
            labelPassword.Text = "Password";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelSMTP);
            Controls.Add(labelFrom);
            Controls.Add(labelTo);
            Controls.Add(labelSubject);
            Controls.Add(labelMassage);
            Controls.Add(buttonSend);
            Controls.Add(buttonAttach);
            Controls.Add(textBoxAttach);
            Controls.Add(textBoxMassage);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxSMTP);
            Controls.Add(textBoxSubject);
            Controls.Add(textBoxTo);
            Controls.Add(textBoxFrom);
            Name = "FormMain";
            Text = "Third Party Email";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFrom;
        private TextBox textBoxTo;
        private TextBox textBoxSubject;
        private TextBox textBoxSMTP;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private TextBox textBoxMassage;
        private TextBox textBoxAttach;
        private Button buttonAttach;
        private Button buttonSend;
        private Label labelMassage;
        private Label labelSubject;
        private Label labelTo;
        private Label labelFrom;
        private Label labelSMTP;
        private Label labelUsername;
        private Label labelPassword;
    }
}