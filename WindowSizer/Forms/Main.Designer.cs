namespace WindowSizer.Forms
{
    partial class Main
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
            this.styleForm1 = new WindowSizer.Theme.StyleForm();
            this.WindowSearchBox = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.WindowList = new System.Windows.Forms.ListBox();
            this.WindowMiniSize = new System.Windows.Forms.Button();
            this.WindowActive = new System.Windows.Forms.Button();
            this.SelectWindow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WindowHideTaskBar = new System.Windows.Forms.CheckBox();
            this.WindowTitleHide = new System.Windows.Forms.CheckBox();
            this.UserSettingMode = new System.Windows.Forms.RadioButton();
            this.FullScreenMode = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WindowPosY = new System.Windows.Forms.TextBox();
            this.WindowPosX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WindowHeight = new System.Windows.Forms.TextBox();
            this.WindowWidth = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.WindowClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // styleForm1
            // 
            this.styleForm1.BackColor = System.Drawing.Color.Aqua;
            this.styleForm1.Location = new System.Drawing.Point(0, 0);
            this.styleForm1.MaximumSize = new System.Drawing.Size(999, 32);
            this.styleForm1.MinimumSize = new System.Drawing.Size(0, 32);
            this.styleForm1.Name = "styleForm1";
            this.styleForm1.Size = new System.Drawing.Size(49, 32);
            this.styleForm1.TabIndex = 0;
            // 
            // WindowSearchBox
            // 
            this.WindowSearchBox.Location = new System.Drawing.Point(95, 41);
            this.WindowSearchBox.Name = "WindowSearchBox";
            this.WindowSearchBox.Size = new System.Drawing.Size(150, 21);
            this.WindowSearchBox.TabIndex = 3;
            // 
            // Search
            // 
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Location = new System.Drawing.Point(251, 41);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(43, 21);
            this.Search.TabIndex = 4;
            this.Search.Text = "검색";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // WindowList
            // 
            this.WindowList.FormattingEnabled = true;
            this.WindowList.ItemHeight = 12;
            this.WindowList.Location = new System.Drawing.Point(12, 68);
            this.WindowList.Name = "WindowList";
            this.WindowList.Size = new System.Drawing.Size(282, 172);
            this.WindowList.TabIndex = 5;
            this.WindowList.SelectedIndexChanged += new System.EventHandler(this.WindowList_SelectedIndexChanged);
            // 
            // WindowMiniSize
            // 
            this.WindowMiniSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindowMiniSize.Location = new System.Drawing.Point(156, 246);
            this.WindowMiniSize.Name = "WindowMiniSize";
            this.WindowMiniSize.Size = new System.Drawing.Size(66, 24);
            this.WindowMiniSize.TabIndex = 11;
            this.WindowMiniSize.Text = "최소화";
            this.WindowMiniSize.UseVisualStyleBackColor = true;
            this.WindowMiniSize.Click += new System.EventHandler(this.WindowMiniSize_Click);
            // 
            // WindowActive
            // 
            this.WindowActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindowActive.Location = new System.Drawing.Point(84, 246);
            this.WindowActive.Name = "WindowActive";
            this.WindowActive.Size = new System.Drawing.Size(66, 24);
            this.WindowActive.TabIndex = 10;
            this.WindowActive.Text = "활성화";
            this.WindowActive.UseVisualStyleBackColor = true;
            this.WindowActive.Click += new System.EventHandler(this.WindowActive_Click);
            // 
            // SelectWindow
            // 
            this.SelectWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectWindow.Location = new System.Drawing.Point(12, 246);
            this.SelectWindow.Name = "SelectWindow";
            this.SelectWindow.Size = new System.Drawing.Size(66, 24);
            this.SelectWindow.TabIndex = 9;
            this.SelectWindow.Text = "창 선택";
            this.SelectWindow.UseVisualStyleBackColor = true;
            this.SelectWindow.Click += new System.EventHandler(this.SelectWindow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "윈도우 이름 :";
            // 
            // WindowHideTaskBar
            // 
            this.WindowHideTaskBar.AutoSize = true;
            this.WindowHideTaskBar.Location = new System.Drawing.Point(12, 297);
            this.WindowHideTaskBar.Name = "WindowHideTaskBar";
            this.WindowHideTaskBar.Size = new System.Drawing.Size(156, 16);
            this.WindowHideTaskBar.TabIndex = 16;
            this.WindowHideTaskBar.Text = "창이 시작 메뉴를 가리기";
            this.WindowHideTaskBar.UseVisualStyleBackColor = true;
            // 
            // WindowTitleHide
            // 
            this.WindowTitleHide.AutoSize = true;
            this.WindowTitleHide.Location = new System.Drawing.Point(12, 276);
            this.WindowTitleHide.Name = "WindowTitleHide";
            this.WindowTitleHide.Size = new System.Drawing.Size(140, 16);
            this.WindowTitleHide.TabIndex = 15;
            this.WindowTitleHide.Text = "윈도우 타이틀 숨기기";
            this.WindowTitleHide.UseVisualStyleBackColor = true;
            // 
            // UserSettingMode
            // 
            this.UserSettingMode.AutoSize = true;
            this.UserSettingMode.Location = new System.Drawing.Point(169, 296);
            this.UserSettingMode.Name = "UserSettingMode";
            this.UserSettingMode.Size = new System.Drawing.Size(127, 16);
            this.UserSettingMode.TabIndex = 18;
            this.UserSettingMode.TabStop = true;
            this.UserSettingMode.Text = "사용자 지정 사이즈";
            this.UserSettingMode.UseVisualStyleBackColor = true;
            this.UserSettingMode.CheckedChanged += new System.EventHandler(this.UserSettingMode_CheckedChanged);
            // 
            // FullScreenMode
            // 
            this.FullScreenMode.AutoSize = true;
            this.FullScreenMode.Location = new System.Drawing.Point(169, 275);
            this.FullScreenMode.Name = "FullScreenMode";
            this.FullScreenMode.Size = new System.Drawing.Size(87, 16);
            this.FullScreenMode.TabIndex = 17;
            this.FullScreenMode.TabStop = true;
            this.FullScreenMode.Text = "전체 창모드";
            this.FullScreenMode.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(119, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 12);
            this.label3.TabIndex = 40;
            this.label3.Text = "Y :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(119, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 12);
            this.label4.TabIndex = 39;
            this.label4.Text = "X :";
            // 
            // WindowPosY
            // 
            this.WindowPosY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WindowPosY.Enabled = false;
            this.WindowPosY.Location = new System.Drawing.Point(145, 350);
            this.WindowPosY.Name = "WindowPosY";
            this.WindowPosY.Size = new System.Drawing.Size(58, 21);
            this.WindowPosY.TabIndex = 38;
            // 
            // WindowPosX
            // 
            this.WindowPosX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WindowPosX.Enabled = false;
            this.WindowPosX.Location = new System.Drawing.Point(145, 319);
            this.WindowPosX.Name = "WindowPosX";
            this.WindowPosX.Size = new System.Drawing.Size(58, 21);
            this.WindowPosX.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 36;
            this.label2.Text = "높이 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 35;
            this.label5.Text = "넓이 :";
            // 
            // WindowHeight
            // 
            this.WindowHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WindowHeight.Enabled = false;
            this.WindowHeight.Location = new System.Drawing.Point(54, 350);
            this.WindowHeight.Name = "WindowHeight";
            this.WindowHeight.Size = new System.Drawing.Size(58, 21);
            this.WindowHeight.TabIndex = 34;
            // 
            // WindowWidth
            // 
            this.WindowWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WindowWidth.Enabled = false;
            this.WindowWidth.Location = new System.Drawing.Point(54, 319);
            this.WindowWidth.Name = "WindowWidth";
            this.WindowWidth.Size = new System.Drawing.Size(58, 21);
            this.WindowWidth.TabIndex = 33;
            // 
            // ApplyButton
            // 
            this.ApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyButton.Location = new System.Drawing.Point(219, 347);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 24);
            this.ApplyButton.TabIndex = 41;
            this.ApplyButton.Text = "적용";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // WindowClose
            // 
            this.WindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindowClose.Location = new System.Drawing.Point(228, 246);
            this.WindowClose.Name = "WindowClose";
            this.WindowClose.Size = new System.Drawing.Size(66, 24);
            this.WindowClose.TabIndex = 42;
            this.WindowClose.Text = "창 종료";
            this.WindowClose.UseVisualStyleBackColor = true;
            this.WindowClose.Click += new System.EventHandler(this.WindowClose_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(306, 384);
            this.Controls.Add(this.WindowClose);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WindowPosY);
            this.Controls.Add(this.WindowPosX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WindowHeight);
            this.Controls.Add(this.WindowWidth);
            this.Controls.Add(this.UserSettingMode);
            this.Controls.Add(this.FullScreenMode);
            this.Controls.Add(this.WindowHideTaskBar);
            this.Controls.Add(this.WindowTitleHide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WindowMiniSize);
            this.Controls.Add(this.WindowActive);
            this.Controls.Add(this.SelectWindow);
            this.Controls.Add(this.WindowList);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.WindowSearchBox);
            this.Controls.Add(this.styleForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Window Sizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Theme.StyleForm styleForm1;
        private System.Windows.Forms.TextBox WindowSearchBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ListBox WindowList;
        private System.Windows.Forms.Button WindowMiniSize;
        private System.Windows.Forms.Button WindowActive;
        private System.Windows.Forms.Button SelectWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox WindowHideTaskBar;
        private System.Windows.Forms.CheckBox WindowTitleHide;
        private System.Windows.Forms.RadioButton UserSettingMode;
        private System.Windows.Forms.RadioButton FullScreenMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WindowPosY;
        private System.Windows.Forms.TextBox WindowPosX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WindowHeight;
        private System.Windows.Forms.TextBox WindowWidth;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button WindowClose;
    }
}