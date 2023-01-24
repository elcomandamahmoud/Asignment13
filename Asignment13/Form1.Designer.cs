namespace Asignment13
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LBLName = new System.Windows.Forms.Label();
            this.TXTName = new System.Windows.Forms.TextBox();
            this.LBLAge = new System.Windows.Forms.Label();
            this.TXTAge = new System.Windows.Forms.TextBox();
            this.BTNWelcome = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLName
            // 
            resources.ApplyResources(this.LBLName, "LBLName");
            this.LBLName.Name = "LBLName";
            // 
            // TXTName
            // 
            resources.ApplyResources(this.TXTName, "TXTName");
            this.TXTName.Name = "TXTName";
            // 
            // LBLAge
            // 
            resources.ApplyResources(this.LBLAge, "LBLAge");
            this.LBLAge.Name = "LBLAge";
            // 
            // TXTAge
            // 
            resources.ApplyResources(this.TXTAge, "TXTAge");
            this.TXTAge.Name = "TXTAge";
            // 
            // BTNWelcome
            // 
            resources.ApplyResources(this.BTNWelcome, "BTNWelcome");
            this.BTNWelcome.Name = "BTNWelcome";
            this.BTNWelcome.UseVisualStyleBackColor = true;
            this.BTNWelcome.Click += new System.EventHandler(this.BTNWelcome_Click);
            // 
            // BTNExit
            // 
            resources.ApplyResources(this.BTNExit, "BTNExit");
            this.BTNExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.BTNWelcome;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTNExit;
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.BTNWelcome);
            this.Controls.Add(this.TXTAge);
            this.Controls.Add(this.LBLAge);
            this.Controls.Add(this.TXTName);
            this.Controls.Add(this.LBLName);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLName;
        private System.Windows.Forms.TextBox TXTName;
        private System.Windows.Forms.Label LBLAge;
        private System.Windows.Forms.TextBox TXTAge;
        private System.Windows.Forms.Button BTNWelcome;
        private System.Windows.Forms.Button BTNExit;
    }
}

