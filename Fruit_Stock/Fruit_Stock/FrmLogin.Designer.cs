﻿
namespace Fruit_Stock
{
    partial class FrmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pbShopkeeper = new System.Windows.Forms.PictureBox();
            this.pbFruitFrontShopkeeper = new System.Windows.Forms.PictureBox();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbShopkeeper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruitFrontShopkeeper)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = global::Fruit_Stock.Properties.Resources.btnLogin;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Mali", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(446, 470);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 43);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Fruit_Stock.Properties.Resources.btnExit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Mali", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(913, 562);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 52);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("TH Sarabun New", 16F, System.Drawing.FontStyle.Bold);
            this.txtUsername.Location = new System.Drawing.Point(357, 330);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(281, 36);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("TH Sarabun New", 16F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(357, 394);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(281, 36);
            this.txtPassword.TabIndex = 2;
            // 
            // pbShopkeeper
            // 
            this.pbShopkeeper.BackColor = System.Drawing.Color.Transparent;
            this.pbShopkeeper.BackgroundImage = global::Fruit_Stock.Properties.Resources.shopkeeper;
            this.pbShopkeeper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbShopkeeper.Location = new System.Drawing.Point(364, 39);
            this.pbShopkeeper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbShopkeeper.Name = "pbShopkeeper";
            this.pbShopkeeper.Size = new System.Drawing.Size(262, 265);
            this.pbShopkeeper.TabIndex = 6;
            this.pbShopkeeper.TabStop = false;
            // 
            // pbFruitFrontShopkeeper
            // 
            this.pbFruitFrontShopkeeper.BackColor = System.Drawing.Color.Transparent;
            this.pbFruitFrontShopkeeper.BackgroundImage = global::Fruit_Stock.Properties.Resources.fruits_2;
            this.pbFruitFrontShopkeeper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFruitFrontShopkeeper.Location = new System.Drawing.Point(460, 196);
            this.pbFruitFrontShopkeeper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbFruitFrontShopkeeper.Name = "pbFruitFrontShopkeeper";
            this.pbFruitFrontShopkeeper.Size = new System.Drawing.Size(75, 73);
            this.pbFruitFrontShopkeeper.TabIndex = 7;
            this.pbFruitFrontShopkeeper.TabStop = false;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.cbShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowPassword.ForeColor = System.Drawing.Color.White;
            this.cbShowPassword.Location = new System.Drawing.Point(649, 401);
            this.cbShowPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(126, 21);
            this.cbShowPassword.TabIndex = 9;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = global::Fruit_Stock.Properties.Resources.Outstanding_Colorful_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 624);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.pbFruitFrontShopkeeper);
            this.Controls.Add(this.pbShopkeeper);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1489, 885);
            this.MinimumSize = new System.Drawing.Size(1028, 631);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fruit Shop Login Form";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbShopkeeper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruitFrontShopkeeper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pbShopkeeper;
        private System.Windows.Forms.PictureBox pbFruitFrontShopkeeper;
        private System.Windows.Forms.CheckBox cbShowPassword;
    }
}