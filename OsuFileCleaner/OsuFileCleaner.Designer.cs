namespace OsuFileCleaner
{
    partial class OsuFileCleaner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OsuFileCleaner));
            this.FileSelecter = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.CleanButton = new System.Windows.Forms.Button();
            this.CleanOption = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FileSelecter
            // 
            this.FileSelecter.Location = new System.Drawing.Point(310, 12);
            this.FileSelecter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileSelecter.Name = "FileSelecter";
            this.FileSelecter.Size = new System.Drawing.Size(50, 23);
            this.FileSelecter.TabIndex = 0;
            this.FileSelecter.Text = "선택";
            this.FileSelecter.UseVisualStyleBackColor = true;
            this.FileSelecter.Click += new System.EventHandler(this.FileSelecter_Click);
            // 
            // FilePath
            // 
            this.FilePath.BackColor = System.Drawing.SystemColors.Window;
            this.FilePath.Location = new System.Drawing.Point(12, 12);
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Size = new System.Drawing.Size(292, 23);
            this.FilePath.TabIndex = 1;
            // 
            // CleanButton
            // 
            this.CleanButton.Enabled = false;
            this.CleanButton.Location = new System.Drawing.Point(269, 43);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(91, 23);
            this.CleanButton.TabIndex = 2;
            this.CleanButton.Text = "정리";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // CleanOption
            // 
            this.CleanOption.BackColor = System.Drawing.SystemColors.Window;
            this.CleanOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CleanOption.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CleanOption.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CleanOption.FormattingEnabled = true;
            this.CleanOption.Items.AddRange(new object[] {
            "비트맵(게임내 비트맵 삭제 후 남은 폴더)",
            "영상",
            "효과음",
            "배경 이미지",
            "게임 이미지(콤보 버스트, 실패 등)"});
            this.CleanOption.Location = new System.Drawing.Point(12, 43);
            this.CleanOption.Name = "CleanOption";
            this.CleanOption.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CleanOption.Size = new System.Drawing.Size(251, 23);
            this.CleanOption.TabIndex = 3;
            this.CleanOption.SelectedIndexChanged += new System.EventHandler(this.CleanOption_SelectedIndexChanged);
            // 
            // OsuFileCleaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 78);
            this.Controls.Add(this.CleanOption);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.FileSelecter);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OsuFileCleaner";
            this.Text = "OsuFileCleaner";
            this.Load += new System.EventHandler(this.OsuFileDeleter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FileSelecter;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.ComboBox CleanOption;
    }
}