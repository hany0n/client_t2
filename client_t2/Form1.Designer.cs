namespace client_t2
{
    partial class Form1
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
            btnSendM = new Button();
            btnConS = new Button();
            txtChatW = new TextBox();
            txtMesgS = new TextBox();
            SuspendLayout();
            // 
            // btnSendM
            // 
            btnSendM.Location = new Point(96, 210);
            btnSendM.Name = "btnSendM";
            btnSendM.Size = new Size(75, 23);
            btnSendM.TabIndex = 0;
            btnSendM.Text = "button1";
            btnSendM.UseVisualStyleBackColor = true;
            btnSendM.Click += btnSend_Click;
            // 
            // btnConS
            // 
            btnConS.Location = new Point(12, 12);
            btnConS.Name = "btnConS";
            btnConS.Size = new Size(75, 23);
            btnConS.TabIndex = 1;
            btnConS.Text = "button2";
            btnConS.UseVisualStyleBackColor = true;
            btnConS.Click += btnConnect_Click;
            // 
            // txtChatW
            // 
            txtChatW.Location = new Point(201, 24);
            txtChatW.Multiline = true;
            txtChatW.Name = "txtChatW";
            txtChatW.Size = new Size(409, 159);
            txtChatW.TabIndex = 2;
            // 
            // txtMesgS
            // 
            txtMesgS.Location = new Point(201, 210);
            txtMesgS.Name = "txtMesgS";
            txtMesgS.Size = new Size(409, 23);
            txtMesgS.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 246);
            Controls.Add(txtMesgS);
            Controls.Add(txtChatW);
            Controls.Add(btnConS);
            Controls.Add(btnSendM);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSendM;
        private Button btnConS;
        private TextBox txtChatW;
        private TextBox txtMesgS;
    }
}
