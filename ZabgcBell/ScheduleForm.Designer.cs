
namespace ZabgcBell
{
    partial class ScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PageFiveMinutes = new System.Windows.Forms.TabPage();
            this.gradientPanel1 = new ZabgcBell.GradientPanel();
            this.OutButton = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TabTenMinutes = new System.Windows.Forms.TabPage();
            this.gradientPanel2 = new ZabgcBell.GradientPanel();
            this.CloseBTN2 = new System.Windows.Forms.Button();
            this.SaveBTN2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.RefreshBTN2 = new System.Windows.Forms.Button();
            this.DownBTN2 = new System.Windows.Forms.Button();
            this.UpBTN2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.PageFiveMinutes.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TabTenMinutes.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PageFiveMinutes);
            this.tabControl1.Controls.Add(this.TabTenMinutes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 575);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // PageFiveMinutes
            // 
            this.PageFiveMinutes.Controls.Add(this.gradientPanel1);
            this.PageFiveMinutes.Controls.Add(this.panel1);
            this.PageFiveMinutes.Location = new System.Drawing.Point(4, 24);
            this.PageFiveMinutes.Name = "PageFiveMinutes";
            this.PageFiveMinutes.Padding = new System.Windows.Forms.Padding(3);
            this.PageFiveMinutes.Size = new System.Drawing.Size(542, 547);
            this.PageFiveMinutes.TabIndex = 0;
            this.PageFiveMinutes.Text = "5 Минутные звонки";
            this.PageFiveMinutes.UseVisualStyleBackColor = true;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(88)))), ((int)(((byte)(209)))));
            this.gradientPanel1.Controls.Add(this.OutButton);
            this.gradientPanel1.Controls.Add(this.Save);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(3, 464);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(536, 80);
            this.gradientPanel1.TabIndex = 9;
            // 
            // OutButton
            // 
            this.OutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutButton.ForeColor = System.Drawing.Color.Navy;
            this.OutButton.Location = new System.Drawing.Point(350, 15);
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(80, 50);
            this.OutButton.TabIndex = 10;
            this.OutButton.Text = "Отмена";
            this.OutButton.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.Color.Navy;
            this.Save.Location = new System.Drawing.Point(445, 15);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(80, 50);
            this.Save.TabIndex = 9;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.RefreshButton);
            this.panel1.Controls.Add(this.DownButton);
            this.panel1.Controls.Add(this.UpButton);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 455);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 95);
            this.label2.TabIndex = 5;
            this.label2.Text = "12345";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(136)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(25, -80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 80);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "При сохранении проигрываются только первые 5 песен.\r\nЕсли песен меньше, они проиг" +
    "рываются с повтором.\r\nДанные были сохраненны.\r\n\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = global::ZabgcBell.Properties.Resources.arrow_refresh_synchronization_sync_icon_183045;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Location = new System.Drawing.Point(485, 125);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(50, 50);
            this.RefreshButton.TabIndex = 3;
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // DownButton
            // 
            this.DownButton.BackgroundImage = global::ZabgcBell.Properties.Resources._1492790981_66arrow_down_84230;
            this.DownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DownButton.FlatAppearance.BorderSize = 0;
            this.DownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownButton.Location = new System.Drawing.Point(485, 255);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(50, 50);
            this.DownButton.TabIndex = 2;
            this.DownButton.UseVisualStyleBackColor = true;
            // 
            // UpButton
            // 
            this.UpButton.BackgroundImage = global::ZabgcBell.Properties.Resources._1492790981_66arrow_down_842301;
            this.UpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpButton.FlatAppearance.BorderSize = 0;
            this.UpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpButton.Location = new System.Drawing.Point(485, 200);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(50, 50);
            this.UpButton.TabIndex = 1;
            this.UpButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(464, 480);
            this.listBox1.TabIndex = 0;
            // 
            // TabTenMinutes
            // 
            this.TabTenMinutes.Controls.Add(this.gradientPanel2);
            this.TabTenMinutes.Controls.Add(this.panel4);
            this.TabTenMinutes.Location = new System.Drawing.Point(4, 24);
            this.TabTenMinutes.Name = "TabTenMinutes";
            this.TabTenMinutes.Padding = new System.Windows.Forms.Padding(3);
            this.TabTenMinutes.Size = new System.Drawing.Size(542, 547);
            this.TabTenMinutes.TabIndex = 1;
            this.TabTenMinutes.Text = "10 Минутные звонки";
            this.TabTenMinutes.UseVisualStyleBackColor = true;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gradientPanel2.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(88)))), ((int)(((byte)(209)))));
            this.gradientPanel2.Controls.Add(this.CloseBTN2);
            this.gradientPanel2.Controls.Add(this.SaveBTN2);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel2.Location = new System.Drawing.Point(3, 464);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(536, 80);
            this.gradientPanel2.TabIndex = 11;
            // 
            // CloseBTN2
            // 
            this.CloseBTN2.BackColor = System.Drawing.Color.Transparent;
            this.CloseBTN2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBTN2.ForeColor = System.Drawing.Color.Navy;
            this.CloseBTN2.Location = new System.Drawing.Point(350, 15);
            this.CloseBTN2.Name = "CloseBTN2";
            this.CloseBTN2.Size = new System.Drawing.Size(80, 50);
            this.CloseBTN2.TabIndex = 10;
            this.CloseBTN2.Text = "Отмена";
            this.CloseBTN2.UseVisualStyleBackColor = false;
            // 
            // SaveBTN2
            // 
            this.SaveBTN2.BackColor = System.Drawing.Color.Transparent;
            this.SaveBTN2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBTN2.ForeColor = System.Drawing.Color.Navy;
            this.SaveBTN2.Location = new System.Drawing.Point(445, 15);
            this.SaveBTN2.Name = "SaveBTN2";
            this.SaveBTN2.Size = new System.Drawing.Size(80, 50);
            this.SaveBTN2.TabIndex = 9;
            this.SaveBTN2.Text = "Сохранить";
            this.SaveBTN2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.RefreshBTN2);
            this.panel4.Controls.Add(this.DownBTN2);
            this.panel4.Controls.Add(this.UpBTN2);
            this.panel4.Controls.Add(this.listBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(536, 455);
            this.panel4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 95);
            this.label3.TabIndex = 5;
            this.label3.Text = "12345";
            // 
            // RefreshBTN2
            // 
            this.RefreshBTN2.BackgroundImage = global::ZabgcBell.Properties.Resources.arrow_refresh_synchronization_sync_icon_183045;
            this.RefreshBTN2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshBTN2.FlatAppearance.BorderSize = 0;
            this.RefreshBTN2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBTN2.Location = new System.Drawing.Point(485, 125);
            this.RefreshBTN2.Name = "RefreshBTN2";
            this.RefreshBTN2.Size = new System.Drawing.Size(50, 50);
            this.RefreshBTN2.TabIndex = 3;
            this.RefreshBTN2.UseVisualStyleBackColor = true;
            // 
            // DownBTN2
            // 
            this.DownBTN2.BackgroundImage = global::ZabgcBell.Properties.Resources._1492790981_66arrow_down_84230;
            this.DownBTN2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DownBTN2.FlatAppearance.BorderSize = 0;
            this.DownBTN2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownBTN2.Location = new System.Drawing.Point(485, 255);
            this.DownBTN2.Name = "DownBTN2";
            this.DownBTN2.Size = new System.Drawing.Size(50, 50);
            this.DownBTN2.TabIndex = 2;
            this.DownBTN2.UseVisualStyleBackColor = true;
            // 
            // UpBTN2
            // 
            this.UpBTN2.BackgroundImage = global::ZabgcBell.Properties.Resources._1492790981_66arrow_down_842301;
            this.UpBTN2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpBTN2.FlatAppearance.BorderSize = 0;
            this.UpBTN2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpBTN2.Location = new System.Drawing.Point(485, 200);
            this.UpBTN2.Name = "UpBTN2";
            this.UpBTN2.Size = new System.Drawing.Size(50, 50);
            this.UpBTN2.TabIndex = 1;
            this.UpBTN2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.White;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(12, 6);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(464, 450);
            this.listBox2.TabIndex = 0;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 575);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Расписание";
            this.tabControl1.ResumeLayout(false);
            this.PageFiveMinutes.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.TabTenMinutes.ResumeLayout(false);
            this.gradientPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PageFiveMinutes;
        private System.Windows.Forms.TabPage TabTenMinutes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RefreshBTN2;
        private System.Windows.Forms.Button DownBTN2;
        private System.Windows.Forms.Button UpBTN2;
        private System.Windows.Forms.ListBox listBox2;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button OutButton;
        private System.Windows.Forms.Button Save;
        private GradientPanel gradientPanel2;
        private System.Windows.Forms.Button CloseBTN2;
        private System.Windows.Forms.Button SaveBTN2;
    }
}