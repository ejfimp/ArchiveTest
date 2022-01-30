namespace Archive
{
    partial class Archive
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
            this.bookButton = new System.Windows.Forms.RadioButton();
            this.filmButton = new System.Windows.Forms.RadioButton();
            this.gameButton = new System.Windows.Forms.RadioButton();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.releaseBox = new System.Windows.Forms.TextBox();
            this.creatorBox = new System.Windows.Forms.TextBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.studioBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.releaseLabel = new System.Windows.Forms.Label();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.studioLabel = new System.Windows.Forms.Label();
            this.archiveBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.archiveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookButton
            // 
            this.bookButton.AutoSize = true;
            this.bookButton.Location = new System.Drawing.Point(3, 39);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(50, 17);
            this.bookButton.TabIndex = 1;
            this.bookButton.TabStop = true;
            this.bookButton.Text = "Book";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.CheckedChanged += new System.EventHandler(this.mediaChoice_clicked);
            // 
            // filmButton
            // 
            this.filmButton.AutoSize = true;
            this.filmButton.Location = new System.Drawing.Point(3, 16);
            this.filmButton.Name = "filmButton";
            this.filmButton.Size = new System.Drawing.Size(43, 17);
            this.filmButton.TabIndex = 2;
            this.filmButton.TabStop = true;
            this.filmButton.Text = "Film";
            this.filmButton.UseVisualStyleBackColor = true;
            this.filmButton.CheckedChanged += new System.EventHandler(this.mediaChoice_clicked);
            // 
            // gameButton
            // 
            this.gameButton.AutoSize = true;
            this.gameButton.Location = new System.Drawing.Point(3, 62);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(53, 17);
            this.gameButton.TabIndex = 3;
            this.gameButton.TabStop = true;
            this.gameButton.Text = "Game";
            this.gameButton.UseVisualStyleBackColor = true;
            this.gameButton.CheckedChanged += new System.EventHandler(this.mediaChoice_clicked);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(116, 44);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 4;
            this.nameBox.Visible = false;
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(284, 44);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(100, 20);
            this.genreBox.TabIndex = 5;
            this.genreBox.Visible = false;
            // 
            // releaseBox
            // 
            this.releaseBox.Location = new System.Drawing.Point(116, 88);
            this.releaseBox.Name = "releaseBox";
            this.releaseBox.Size = new System.Drawing.Size(100, 20);
            this.releaseBox.TabIndex = 6;
            this.releaseBox.Visible = false;
            this.releaseBox.TextChanged += new System.EventHandler(this.checkIfNum);
            // 
            // creatorBox
            // 
            this.creatorBox.Location = new System.Drawing.Point(284, 88);
            this.creatorBox.Name = "creatorBox";
            this.creatorBox.Size = new System.Drawing.Size(100, 20);
            this.creatorBox.TabIndex = 7;
            this.creatorBox.Visible = false;
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(116, 136);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(100, 20);
            this.lengthBox.TabIndex = 8;
            this.lengthBox.Visible = false;
            this.lengthBox.TextChanged += new System.EventHandler(this.checkIfNum);
            // 
            // studioBox
            // 
            this.studioBox.Location = new System.Drawing.Point(284, 136);
            this.studioBox.Name = "studioBox";
            this.studioBox.Size = new System.Drawing.Size(100, 20);
            this.studioBox.TabIndex = 9;
            this.studioBox.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(113, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name";
            this.nameLabel.Visible = false;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(281, 28);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(36, 13);
            this.genreLabel.TabIndex = 11;
            this.genreLabel.Text = "Genre";
            this.genreLabel.Visible = false;
            // 
            // releaseLabel
            // 
            this.releaseLabel.AutoSize = true;
            this.releaseLabel.Location = new System.Drawing.Point(113, 72);
            this.releaseLabel.Name = "releaseLabel";
            this.releaseLabel.Size = new System.Drawing.Size(71, 13);
            this.releaseLabel.TabIndex = 12;
            this.releaseLabel.Text = "Release Year";
            this.releaseLabel.Visible = false;
            // 
            // creatorLabel
            // 
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Location = new System.Drawing.Point(281, 72);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(41, 13);
            this.creatorLabel.TabIndex = 13;
            this.creatorLabel.Text = "Creator";
            this.creatorLabel.Visible = false;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(113, 120);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(40, 13);
            this.lengthLabel.TabIndex = 14;
            this.lengthLabel.Text = "Length";
            this.lengthLabel.Visible = false;
            // 
            // studioLabel
            // 
            this.studioLabel.AutoSize = true;
            this.studioLabel.Location = new System.Drawing.Point(281, 120);
            this.studioLabel.Name = "studioLabel";
            this.studioLabel.Size = new System.Drawing.Size(37, 13);
            this.studioLabel.TabIndex = 15;
            this.studioLabel.Text = "Studio";
            this.studioLabel.Visible = false;
            // 
            // archiveBox
            // 
            this.archiveBox.Location = new System.Drawing.Point(116, 171);
            this.archiveBox.Multiline = true;
            this.archiveBox.Name = "archiveBox";
            this.archiveBox.ReadOnly = true;
            this.archiveBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.archiveBox.Size = new System.Drawing.Size(267, 225);
            this.archiveBox.TabIndex = 16;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(11, 183);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(91, 23);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Add to archive";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filmButton);
            this.panel1.Controls.Add(this.bookButton);
            this.panel1.Controls.Add(this.gameButton);
            this.panel1.Location = new System.Drawing.Point(8, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 102);
            this.panel1.TabIndex = 18;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(11, 373);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(91, 23);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // archiveButton
            // 
            this.archiveButton.Location = new System.Drawing.Point(11, 225);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(91, 23);
            this.archiveButton.TabIndex = 20;
            this.archiveButton.Text = "Check archive";
            this.archiveButton.UseVisualStyleBackColor = true;
            this.archiveButton.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 413);
            this.Controls.Add(this.archiveButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.archiveBox);
            this.Controls.Add(this.studioLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.creatorLabel);
            this.Controls.Add(this.releaseLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.studioBox);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.creatorBox);
            this.Controls.Add(this.releaseBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.nameBox);
            this.Name = "Archive";
            this.Text = "Archive";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton bookButton;
        private System.Windows.Forms.RadioButton filmButton;
        private System.Windows.Forms.RadioButton gameButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.TextBox releaseBox;
        private System.Windows.Forms.TextBox creatorBox;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.TextBox studioBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label releaseLabel;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label studioLabel;
        private System.Windows.Forms.TextBox archiveBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button archiveButton;
    }
}

