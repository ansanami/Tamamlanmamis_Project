
namespace OOP_PreLab
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.kayıtolbutton = new System.Windows.Forms.Button();
            this.allUserbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kayıtolbutton
            // 
            this.kayıtolbutton.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayıtolbutton.ForeColor = System.Drawing.Color.Green;
            this.kayıtolbutton.Location = new System.Drawing.Point(72, 55);
            this.kayıtolbutton.Name = "kayıtolbutton";
            this.kayıtolbutton.Size = new System.Drawing.Size(143, 56);
            this.kayıtolbutton.TabIndex = 17;
            this.kayıtolbutton.Text = "Add";
            this.kayıtolbutton.UseVisualStyleBackColor = true;
            this.kayıtolbutton.Click += new System.EventHandler(this.kayıtolbutton_Click);
            // 
            // allUserbutton
            // 
            this.allUserbutton.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allUserbutton.ForeColor = System.Drawing.Color.Green;
            this.allUserbutton.Location = new System.Drawing.Point(528, 55);
            this.allUserbutton.Name = "allUserbutton";
            this.allUserbutton.Size = new System.Drawing.Size(143, 56);
            this.allUserbutton.TabIndex = 18;
            this.allUserbutton.Text = "List All";
            this.allUserbutton.UseVisualStyleBackColor = true;
            this.allUserbutton.Click += new System.EventHandler(this.allUserbutton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(72, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 56);
            this.button1.TabIndex = 19;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Green;
            this.backButton.Location = new System.Drawing.Point(316, 338);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(143, 56);
            this.backButton.TabIndex = 21;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserButton.ForeColor = System.Drawing.Color.Green;
            this.deleteUserButton.Location = new System.Drawing.Point(528, 218);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(143, 56);
            this.deleteUserButton.TabIndex = 20;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.allUserbutton);
            this.Controls.Add(this.kayıtolbutton);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kayıtolbutton;
        private System.Windows.Forms.Button allUserbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteUserButton;
    }
}