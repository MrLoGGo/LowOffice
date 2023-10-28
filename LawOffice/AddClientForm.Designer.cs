namespace LawOffice
{
    partial class AddClientForm
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
            this.ClientIdLable = new System.Windows.Forms.Label();
            this.FullNameClientLable = new System.Windows.Forms.Label();
            this.PassportLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.FullNameBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.MaskedTextBox();
            this.PassportBox = new System.Windows.Forms.MaskedTextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientIdLable
            // 
            this.ClientIdLable.AutoSize = true;
            this.ClientIdLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientIdLable.Location = new System.Drawing.Point(90, 31);
            this.ClientIdLable.Name = "ClientIdLable";
            this.ClientIdLable.Size = new System.Drawing.Size(74, 20);
            this.ClientIdLable.TabIndex = 0;
            this.ClientIdLable.Text = "Client ID:";
            // 
            // FullNameClientLable
            // 
            this.FullNameClientLable.AutoSize = true;
            this.FullNameClientLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameClientLable.Location = new System.Drawing.Point(90, 61);
            this.FullNameClientLable.Name = "FullNameClientLable";
            this.FullNameClientLable.Size = new System.Drawing.Size(121, 20);
            this.FullNameClientLable.TabIndex = 1;
            this.FullNameClientLable.Text = "Client full name:";
            // 
            // PassportLabel
            // 
            this.PassportLabel.AutoSize = true;
            this.PassportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassportLabel.Location = new System.Drawing.Point(90, 92);
            this.PassportLabel.Name = "PassportLabel";
            this.PassportLabel.Size = new System.Drawing.Size(76, 20);
            this.PassportLabel.TabIndex = 2;
            this.PassportLabel.Text = "Passport:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneLabel.Location = new System.Drawing.Point(90, 123);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(59, 20);
            this.PhoneLabel.TabIndex = 3;
            this.PhoneLabel.Text = "Phone:";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(170, 33);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(271, 20);
            this.IDBox.TabIndex = 4;
            // 
            // FullNameBox
            // 
            this.FullNameBox.Location = new System.Drawing.Point(217, 61);
            this.FullNameBox.Name = "FullNameBox";
            this.FullNameBox.Size = new System.Drawing.Size(224, 20);
            this.FullNameBox.TabIndex = 5;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(170, 124);
            this.PhoneBox.Mask = "+7 999 999-99-99";
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(271, 20);
            this.PhoneBox.TabIndex = 8;
            this.PhoneBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PhoneBox_MouseUp);
            // 
            // PassportBox
            // 
            this.PassportBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.PassportBox.Location = new System.Drawing.Point(170, 94);
            this.PassportBox.Mask = "99 99 999999";
            this.PassportBox.Name = "PassportBox";
            this.PassportBox.Size = new System.Drawing.Size(271, 20);
            this.PassportBox.TabIndex = 9;
            this.PassportBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PassportBox_MouseUp);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(94, 168);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(347, 31);
            this.OkButton.TabIndex = 10;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AddClientForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(531, 211);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PassportBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.FullNameBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.PassportLabel);
            this.Controls.Add(this.FullNameClientLable);
            this.Controls.Add(this.ClientIdLable);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(547, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(547, 250);
            this.Name = "AddClientForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddClientForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientIdLable;
        private System.Windows.Forms.Label FullNameClientLable;
        private System.Windows.Forms.Label PassportLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox FullNameBox;
        private System.Windows.Forms.MaskedTextBox PhoneBox;
        private System.Windows.Forms.MaskedTextBox PassportBox;
        private System.Windows.Forms.Button OkButton;
    }
}