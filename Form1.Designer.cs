﻿namespace urban_style_auto_regist
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        const string AppName = "Urban-Style-Auto-Regist";

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
            ShopList = new ComboBox();
            BtnStart = new Button();
            SuspendLayout();
            // 
            // ShopList
            // 
            ShopList.FormattingEnabled = true;
            ShopList.ImeMode = ImeMode.NoControl;
            ShopList.Location = new Point(349, 203);
            ShopList.Name = "ShopList";
            ShopList.Size = new Size(121, 23);
            ShopList.TabIndex = 0;
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(372, 232);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(75, 23);
            BtnStart.TabIndex = 1;
            BtnStart.Text = "START";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnStart);
            Controls.Add(ShopList);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox ShopList;
        private Button BtnStart;
    }
}
