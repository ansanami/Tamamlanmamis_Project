
namespace OOP_PreLab
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.checkBoxSquare = new System.Windows.Forms.CheckBox();
            this.shapeLabel = new System.Windows.Forms.Label();
            this.checkBoxRound = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBoxTriangle = new System.Windows.Forms.CheckBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.mavi = new System.Windows.Forms.CheckBox();
            this.yeşil = new System.Windows.Forms.CheckBox();
            this.kırmızı = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.adminSettings = new System.Windows.Forms.Button();
            this.button_ayarlar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxSquare
            // 
            this.checkBoxSquare.AutoSize = true;
            this.checkBoxSquare.Checked = global::OOP_PreLab.Settings1.Default.square;
            this.checkBoxSquare.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSquare.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::OOP_PreLab.Settings1.Default, "square", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxSquare.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxSquare.Location = new System.Drawing.Point(219, 96);
            this.checkBoxSquare.Name = "checkBoxSquare";
            this.checkBoxSquare.Size = new System.Drawing.Size(87, 23);
            this.checkBoxSquare.TabIndex = 4;
            this.checkBoxSquare.Text = "Square";
            this.checkBoxSquare.UseVisualStyleBackColor = true;
            // 
            // shapeLabel
            // 
            this.shapeLabel.AutoSize = true;
            this.shapeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeLabel.Location = new System.Drawing.Point(3, 96);
            this.shapeLabel.Name = "shapeLabel";
            this.shapeLabel.Size = new System.Drawing.Size(176, 28);
            this.shapeLabel.TabIndex = 3;
            this.shapeLabel.Text = "Shape Option:";
            // 
            // checkBoxRound
            // 
            this.checkBoxRound.AutoSize = true;
            this.checkBoxRound.Checked = global::OOP_PreLab.Settings1.Default.round;
            this.checkBoxRound.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::OOP_PreLab.Settings1.Default, "round", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxRound.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxRound.Location = new System.Drawing.Point(441, 96);
            this.checkBoxRound.Name = "checkBoxRound";
            this.checkBoxRound.Size = new System.Drawing.Size(83, 23);
            this.checkBoxRound.TabIndex = 5;
            this.checkBoxRound.Text = "Round";
            this.checkBoxRound.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::OOP_PreLab.Settings1.Default, "diffculty_level", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard",
            "Custom"});
            this.comboBox1.Location = new System.Drawing.Point(207, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = global::OOP_PreLab.Settings1.Default.diffculty_level;
            // 
            // checkBoxTriangle
            // 
            this.checkBoxTriangle.AutoSize = true;
            this.checkBoxTriangle.Checked = global::OOP_PreLab.Settings1.Default.triangle;
            this.checkBoxTriangle.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::OOP_PreLab.Settings1.Default, "triangle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxTriangle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxTriangle.Location = new System.Drawing.Point(325, 96);
            this.checkBoxTriangle.Name = "checkBoxTriangle";
            this.checkBoxTriangle.Size = new System.Drawing.Size(93, 23);
            this.checkBoxTriangle.TabIndex = 6;
            this.checkBoxTriangle.Text = "Triangle";
            this.checkBoxTriangle.UseVisualStyleBackColor = true;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.Location = new System.Drawing.Point(3, 24);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(192, 28);
            this.levelLabel.TabIndex = 2;
            this.levelLabel.Text = "Difficulty Level:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(517, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 66);
            this.button2.TabIndex = 8;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::OOP_PreLab.Settings1.Default, "visible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxWidth.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::OOP_PreLab.Settings1.Default, "width", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxWidth.Location = new System.Drawing.Point(354, 26);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(50, 22);
            this.textBoxWidth.TabIndex = 9;
            this.textBoxWidth.Text = global::OOP_PreLab.Settings1.Default.width;
            this.textBoxWidth.Visible = global::OOP_PreLab.Settings1.Default.visible;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::OOP_PreLab.Settings1.Default, "visible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxHeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::OOP_PreLab.Settings1.Default, "height", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxHeight.Location = new System.Drawing.Point(441, 26);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(47, 22);
            this.textBoxHeight.TabIndex = 10;
            this.textBoxHeight.Text = global::OOP_PreLab.Settings1.Default.height;
            this.textBoxHeight.Visible = global::OOP_PreLab.Settings1.Default.visible;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::OOP_PreLab.Settings1.Default, "visible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.Location = new System.Drawing.Point(356, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Width:";
            this.label3.Visible = global::OOP_PreLab.Settings1.Default.visible;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::OOP_PreLab.Settings1.Default, "visible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label4.Location = new System.Drawing.Point(438, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Height:";
            this.label4.Visible = global::OOP_PreLab.Settings1.Default.visible;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(3, 148);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(198, 28);
            this.colorLabel.TabIndex = 13;
            this.colorLabel.Text = "Color Selection:";
            // 
            // mavi
            // 
            this.mavi.AutoSize = true;
            this.mavi.Checked = global::OOP_PreLab.Settings1.Default.mavi;
            this.mavi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mavi.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::OOP_PreLab.Settings1.Default, "mavi", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mavi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mavi.Location = new System.Drawing.Point(219, 154);
            this.mavi.Name = "mavi";
            this.mavi.Size = new System.Drawing.Size(66, 23);
            this.mavi.TabIndex = 14;
            this.mavi.Text = "Blue";
            this.mavi.UseVisualStyleBackColor = true;
            // 
            // yeşil
            // 
            this.yeşil.AutoSize = true;
            this.yeşil.Checked = global::OOP_PreLab.Settings1.Default.yeşil;
            this.yeşil.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yeşil.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::OOP_PreLab.Settings1.Default, "yeşil", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.yeşil.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeşil.Location = new System.Drawing.Point(325, 154);
            this.yeşil.Name = "yeşil";
            this.yeşil.Size = new System.Drawing.Size(79, 23);
            this.yeşil.TabIndex = 15;
            this.yeşil.Text = "Green";
            this.yeşil.UseVisualStyleBackColor = true;
            // 
            // kırmızı
            // 
            this.kırmızı.AutoSize = true;
            this.kırmızı.Checked = global::OOP_PreLab.Settings1.Default.kırmızı;
            this.kırmızı.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::OOP_PreLab.Settings1.Default, "kırmızı", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.kırmızı.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kırmızı.Location = new System.Drawing.Point(441, 154);
            this.kırmızı.Name = "kırmızı";
            this.kırmızı.Size = new System.Drawing.Size(62, 23);
            this.kırmızı.TabIndex = 16;
            this.kırmızı.Text = "Red";
            this.kırmızı.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.kırmızı);
            this.panel1.Controls.Add(this.yeşil);
            this.panel1.Controls.Add(this.mavi);
            this.panel1.Controls.Add(this.colorLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxHeight);
            this.panel1.Controls.Add(this.textBoxWidth);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.levelLabel);
            this.panel1.Controls.Add(this.checkBoxTriangle);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.checkBoxRound);
            this.panel1.Controls.Add(this.shapeLabel);
            this.panel1.Controls.Add(this.checkBoxSquare);
            this.panel1.Location = new System.Drawing.Point(175, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 364);
            this.panel1.TabIndex = 10;
            this.panel1.Visible = false;
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(12, 12);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(140, 66);
            this.playButton.TabIndex = 13;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(12, 420);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 66);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Logout";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // adminSettings
            // 
            this.adminSettings.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminSettings.Location = new System.Drawing.Point(12, 339);
            this.adminSettings.Name = "adminSettings";
            this.adminSettings.Size = new System.Drawing.Size(140, 66);
            this.adminSettings.TabIndex = 12;
            this.adminSettings.Text = "Admin Settings";
            this.adminSettings.UseVisualStyleBackColor = true;
            this.adminSettings.Click += new System.EventHandler(this.adminSettings_Click);
            // 
            // button_ayarlar
            // 
            this.button_ayarlar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ayarlar.Location = new System.Drawing.Point(12, 253);
            this.button_ayarlar.Name = "button_ayarlar";
            this.button_ayarlar.Size = new System.Drawing.Size(140, 66);
            this.button_ayarlar.TabIndex = 14;
            this.button_ayarlar.Text = "Settings";
            this.button_ayarlar.UseVisualStyleBackColor = true;
            this.button_ayarlar.Click += new System.EventHandler(this.button_ayarlar_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(841, 508);
            this.Controls.Add(this.button_ayarlar);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.adminSettings);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitButton);
            this.Name = "Form5";
            this.Text = "Form5";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxSquare;
        private System.Windows.Forms.Label shapeLabel;
        private System.Windows.Forms.CheckBox checkBoxRound;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBoxTriangle;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.CheckBox mavi;
        private System.Windows.Forms.CheckBox yeşil;
        private System.Windows.Forms.CheckBox kırmızı;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button adminSettings;
        private System.Windows.Forms.Button button_ayarlar;
    }
}