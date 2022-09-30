namespace Launcher
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectDirectoryGTA5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.SelectDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.mainLabel = new System.Windows.Forms.Label();
            this.showDirectory = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showDirectory);
            this.groupBox1.Controls.Add(this.Connect);
            this.groupBox1.Controls.Add(this.SelectDirectoryGTA5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(12, 430);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1011, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры подключения";
            // 
            // SelectDirectoryGTA5
            // 
            this.SelectDirectoryGTA5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectDirectoryGTA5.Location = new System.Drawing.Point(86, 20);
            this.SelectDirectoryGTA5.Name = "SelectDirectoryGTA5";
            this.SelectDirectoryGTA5.Size = new System.Drawing.Size(125, 27);
            this.SelectDirectoryGTA5.TabIndex = 7;
            this.SelectDirectoryGTA5.Text = "Выбрать";
            this.SelectDirectoryGTA5.UseVisualStyleBackColor = true;
            this.SelectDirectoryGTA5.Click += new System.EventHandler(this.SelectDirectoryGTA5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Game Of Squids", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "GTA5";
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.Connect.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.Connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(139)))), ((int)(((byte)(141)))));
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Connect.Location = new System.Drawing.Point(836, 37);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(169, 39);
            this.Connect.TabIndex = 3;
            this.Connect.Text = "Подключиться";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // SelectDirectory
            // 
            this.SelectDirectory.SelectedPath = "D:\\Program Files\\Rockstar Games\\Grand Theft Auto V";
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Game Of Squids", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainLabel.Location = new System.Drawing.Point(3, 4);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(126, 33);
            this.mainLabel.TabIndex = 3;
            this.mainLabel.Text = "capital";
            // 
            // showDirectory
            // 
            this.showDirectory.AutoSize = true;
            this.showDirectory.Location = new System.Drawing.Point(18, 46);
            this.showDirectory.Name = "showDirectory";
            this.showDirectory.Size = new System.Drawing.Size(0, 20);
            this.showDirectory.TabIndex = 8;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Game Of Squids", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.closeButton.Location = new System.Drawing.Point(967, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(63, 36);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 48);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1011, 376);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // Logo
            // 
            this.Logo.Image = global::Launcher.Properties.Resources._2;
            this.Logo.Location = new System.Drawing.Point(418, 135);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(200, 200);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 6;
            this.Logo.TabStop = false;
            this.Logo.Visible = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 17000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(26)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1035, 524);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Launcher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SelectDirectoryGTA5;
        private System.Windows.Forms.FolderBrowserDialog SelectDirectory;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label showDirectory;
        private System.Windows.Forms.Button closeButton;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Timer Timer;
    }
}

