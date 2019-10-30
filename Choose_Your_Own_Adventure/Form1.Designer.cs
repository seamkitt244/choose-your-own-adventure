namespace Choose_Your_Own_Adventure
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backdrop = new System.Windows.Forms.Label();
            this.gamePictureBox = new System.Windows.Forms.PictureBox();
            this.gameLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.startPictureBox = new System.Windows.Forms.PictureBox();
            this.leftPictureBox = new System.Windows.Forms.PictureBox();
            this.middlePictureBox = new System.Windows.Forms.PictureBox();
            this.rightPictureBox = new System.Windows.Forms.PictureBox();
            this.questionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backdrop
            // 
            this.backdrop.BackColor = System.Drawing.Color.Black;
            this.backdrop.Location = new System.Drawing.Point(-16, -3);
            this.backdrop.Name = "backdrop";
            this.backdrop.Size = new System.Drawing.Size(971, 903);
            this.backdrop.TabIndex = 2;
            this.backdrop.Text = "label1 hhhj";
            // 
            // gamePictureBox
            // 
            this.gamePictureBox.BackgroundImage = global::Choose_Your_Own_Adventure.Properties.Resources.title_Choose_your_own_adventure;
            this.gamePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamePictureBox.InitialImage = null;
            this.gamePictureBox.Location = new System.Drawing.Point(32, 150);
            this.gamePictureBox.Name = "gamePictureBox";
            this.gamePictureBox.Size = new System.Drawing.Size(882, 431);
            this.gamePictureBox.TabIndex = 7;
            this.gamePictureBox.TabStop = false;
            this.gamePictureBox.WaitOnLoad = true;
            // 
            // gameLabel
            // 
            this.gameLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gameLabel.Location = new System.Drawing.Point(32, 24);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(882, 114);
            this.gameLabel.TabIndex = 8;
            this.gameLabel.Text = "It\'s the start for reading week and you don\'t have a clue what \r\nyou\'re going to " +
    "do.  Your friend James suggests that you and\r\nhim go up to his family\'s cottage " +
    "on crystal lake.";
            this.gameLabel.Visible = false;
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.startLabel.Location = new System.Drawing.Point(32, 561);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(433, 33);
            this.startLabel.TabIndex = 10;
            this.startLabel.Text = "Press the green button to start";
            // 
            // startPictureBox
            // 
            this.startPictureBox.BackgroundImage = global::Choose_Your_Own_Adventure.Properties.Resources.start;
            this.startPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startPictureBox.Location = new System.Drawing.Point(342, 622);
            this.startPictureBox.Name = "startPictureBox";
            this.startPictureBox.Size = new System.Drawing.Size(265, 113);
            this.startPictureBox.TabIndex = 11;
            this.startPictureBox.TabStop = false;
            // 
            // leftPictureBox
            // 
            this.leftPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftPictureBox.BackgroundImage")));
            this.leftPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftPictureBox.Location = new System.Drawing.Point(38, 665);
            this.leftPictureBox.Name = "leftPictureBox";
            this.leftPictureBox.Size = new System.Drawing.Size(265, 100);
            this.leftPictureBox.TabIndex = 12;
            this.leftPictureBox.TabStop = false;
            this.leftPictureBox.Visible = false;
            // 
            // middlePictureBox
            // 
            this.middlePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("middlePictureBox.BackgroundImage")));
            this.middlePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.middlePictureBox.Location = new System.Drawing.Point(342, 665);
            this.middlePictureBox.Name = "middlePictureBox";
            this.middlePictureBox.Size = new System.Drawing.Size(265, 100);
            this.middlePictureBox.TabIndex = 13;
            this.middlePictureBox.TabStop = false;
            this.middlePictureBox.Visible = false;
            // 
            // rightPictureBox
            // 
            this.rightPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightPictureBox.BackgroundImage")));
            this.rightPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightPictureBox.Location = new System.Drawing.Point(649, 665);
            this.rightPictureBox.Name = "rightPictureBox";
            this.rightPictureBox.Size = new System.Drawing.Size(265, 100);
            this.rightPictureBox.TabIndex = 14;
            this.rightPictureBox.TabStop = false;
            this.rightPictureBox.Visible = false;
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.questionLabel.Location = new System.Drawing.Point(32, 561);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(882, 33);
            this.questionLabel.TabIndex = 15;
            this.questionLabel.Text = "label1";
            this.questionLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 784);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.rightPictureBox);
            this.Controls.Add(this.middlePictureBox);
            this.Controls.Add(this.leftPictureBox);
            this.Controls.Add(this.startPictureBox);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.gamePictureBox);
            this.Controls.Add(this.backdrop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Don\'t Split Up";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label backdrop;
        private System.Windows.Forms.PictureBox gamePictureBox;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.PictureBox startPictureBox;
        private System.Windows.Forms.PictureBox leftPictureBox;
        private System.Windows.Forms.PictureBox middlePictureBox;
        private System.Windows.Forms.PictureBox rightPictureBox;
        private System.Windows.Forms.Label questionLabel;
    }
}

