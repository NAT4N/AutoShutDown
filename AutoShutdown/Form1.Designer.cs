namespace AutoShutdown
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.hourstxt = new System.Windows.Forms.Label();
            this.minutetxt = new System.Windows.Forms.Label();
            this.secondtxt = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.htxt = new System.Windows.Forms.TextBox();
            this.mtxt = new System.Windows.Forms.TextBox();
            this.stxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 323);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 35F);
            this.label2.Location = new System.Drawing.Point(71, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 55);
            this.label2.TabIndex = 2;
            this.label2.Text = "ShutDown";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 323);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "5 Minutes",
            "10 Minutes",
            "15 Minutes",
            "30 Minutes",
            "1 Hour",
            "2 Hours",
            "3 Hours",
            "4 Hours",
            "5 Hours",
            "6 Hours",
            "7 Hours",
            "8 Hours",
            "9 Hours",
            "10 Hours",
            "11 Hours",
            "12 Hours",
            "24 Hours",
            "Custom"});
            this.comboBox1.Location = new System.Drawing.Point(90, 97);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // hourstxt
            // 
            this.hourstxt.AutoSize = true;
            this.hourstxt.Font = new System.Drawing.Font("Arial Narrow", 40F);
            this.hourstxt.Location = new System.Drawing.Point(41, 161);
            this.hourstxt.Name = "hourstxt";
            this.hourstxt.Size = new System.Drawing.Size(78, 64);
            this.hourstxt.TabIndex = 8;
            this.hourstxt.Text = "00";
            this.hourstxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minutetxt
            // 
            this.minutetxt.AutoSize = true;
            this.minutetxt.Font = new System.Drawing.Font("Arial Narrow", 40F);
            this.minutetxt.Location = new System.Drawing.Point(123, 161);
            this.minutetxt.Name = "minutetxt";
            this.minutetxt.Size = new System.Drawing.Size(78, 64);
            this.minutetxt.TabIndex = 8;
            this.minutetxt.Text = "00";
            this.minutetxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // secondtxt
            // 
            this.secondtxt.AutoSize = true;
            this.secondtxt.Font = new System.Drawing.Font("Arial Narrow", 40F);
            this.secondtxt.Location = new System.Drawing.Point(209, 161);
            this.secondtxt.Name = "secondtxt";
            this.secondtxt.Size = new System.Drawing.Size(78, 64);
            this.secondtxt.TabIndex = 8;
            this.secondtxt.Text = "00";
            this.secondtxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 242);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(291, 57);
            this.progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Time";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(95, 386);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 17);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/NAT4N";
            // 
            // htxt
            // 
            this.htxt.Location = new System.Drawing.Point(61, 134);
            this.htxt.MaxLength = 2;
            this.htxt.Name = "htxt";
            this.htxt.Size = new System.Drawing.Size(31, 23);
            this.htxt.TabIndex = 11;
            this.htxt.Visible = false;
            // 
            // mtxt
            // 
            this.mtxt.Location = new System.Drawing.Point(142, 134);
            this.mtxt.MaxLength = 2;
            this.mtxt.Name = "mtxt";
            this.mtxt.Size = new System.Drawing.Size(30, 23);
            this.mtxt.TabIndex = 11;
            this.mtxt.Visible = false;
            // 
            // stxt
            // 
            this.stxt.Location = new System.Drawing.Point(228, 134);
            this.stxt.MaxLength = 2;
            this.stxt.Name = "stxt";
            this.stxt.Size = new System.Drawing.Size(29, 23);
            this.stxt.TabIndex = 11;
            this.stxt.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoShutdown.Properties.Resources.kisspng_computer_icons_shutdown_button_download_restart_5ac21c76505867_1461710815226707103291_9B1_icon;
            this.pictureBox1.Location = new System.Drawing.Point(19, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stxt);
            this.Controls.Add(this.mtxt);
            this.Controls.Add(this.htxt);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondtxt);
            this.Controls.Add(this.minutetxt);
            this.Controls.Add(this.hourstxt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Auto-ShutDown";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label hourstxt;
        private System.Windows.Forms.Label minutetxt;
        private System.Windows.Forms.Label secondtxt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox htxt;
        private System.Windows.Forms.TextBox mtxt;
        private System.Windows.Forms.TextBox stxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

