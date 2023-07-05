namespace Application1.Views.Partials
{
    partial class NavigationBar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Application = new System.Windows.Forms.Label();
            this.btnHome = new Application1.Controls.PrimaryButton();
            this.btnCustomer = new Application1.Controls.PrimaryButton();
            this.btnSettings = new Application1.Controls.PrimaryButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Application);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 51);
            this.panel1.TabIndex = 0;
            // 
            // Application
            // 
            this.Application.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Application.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Application.Location = new System.Drawing.Point(0, 0);
            this.Application.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Application.Name = "Application";
            this.Application.Padding = new System.Windows.Forms.Padding(7);
            this.Application.Size = new System.Drawing.Size(262, 51);
            this.Application.TabIndex = 0;
            this.Application.Text = "Application";
            this.Application.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.btnHome.BorderRadius = 0;
            this.btnHome.BorderSize = 0;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(0, 51);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(5);
            this.btnHome.Size = new System.Drawing.Size(262, 37);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextColor = System.Drawing.Color.Black;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.btnCustomer.BorderRadius = 0;
            this.btnCustomer.BorderSize = 0;
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnCustomer.Location = new System.Drawing.Point(0, 88);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(5);
            this.btnCustomer.Size = new System.Drawing.Size(262, 37);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextColor = System.Drawing.Color.Black;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.btnSettings.BorderRadius = 0;
            this.btnSettings.BorderSize = 0;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Location = new System.Drawing.Point(0, 125);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(5);
            this.btnSettings.Size = new System.Drawing.Size(262, 37);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextColor = System.Drawing.Color.Black;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // NavigationBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "NavigationBar";
            this.Size = new System.Drawing.Size(262, 542);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Application;
        private Controls.PrimaryButton btnHome;
        private Controls.PrimaryButton btnCustomer;
        private Controls.PrimaryButton btnSettings;
    }
}