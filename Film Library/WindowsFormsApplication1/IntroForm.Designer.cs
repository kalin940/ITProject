namespace WindowsFormsApplication1
{
    partial class IntroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroForm));
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DramaMovieButton = new System.Windows.Forms.Button();
            this.ThrillerMovieButton = new System.Windows.Forms.Button();
            this.HorrorMovieButton = new System.Windows.Forms.Button();
            this.FantasyMovieButton = new System.Windows.Forms.Button();
            this.ComedyMovieButton = new System.Windows.Forms.Button();
            this.ActionMovieButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MostPopularButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showAllButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBox.Location = new System.Drawing.Point(252, 13);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(228, 24);
            this.searchBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(486, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(79, 26);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DramaMovieButton);
            this.groupBox1.Controls.Add(this.ThrillerMovieButton);
            this.groupBox1.Controls.Add(this.HorrorMovieButton);
            this.groupBox1.Controls.Add(this.FantasyMovieButton);
            this.groupBox1.Controls.Add(this.ComedyMovieButton);
            this.groupBox1.Controls.Add(this.ActionMovieButton);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.MostPopularButton);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBox1.Location = new System.Drawing.Point(4, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 247);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categories";
            // 
            // DramaMovieButton
            // 
            this.DramaMovieButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.DramaMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DramaMovieButton.Location = new System.Drawing.Point(7, 127);
            this.DramaMovieButton.Name = "DramaMovieButton";
            this.DramaMovieButton.Size = new System.Drawing.Size(104, 28);
            this.DramaMovieButton.TabIndex = 7;
            this.DramaMovieButton.Text = "Drama";
            this.DramaMovieButton.UseVisualStyleBackColor = false;
            this.DramaMovieButton.Click += new System.EventHandler(this.DramaMovieButton_Click);
            // 
            // ThrillerMovieButton
            // 
            this.ThrillerMovieButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ThrillerMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThrillerMovieButton.Location = new System.Drawing.Point(7, 203);
            this.ThrillerMovieButton.Name = "ThrillerMovieButton";
            this.ThrillerMovieButton.Size = new System.Drawing.Size(104, 28);
            this.ThrillerMovieButton.TabIndex = 6;
            this.ThrillerMovieButton.Text = "Thriller";
            this.ThrillerMovieButton.UseVisualStyleBackColor = false;
            this.ThrillerMovieButton.Click += new System.EventHandler(this.Thriller_Click);
            // 
            // HorrorMovieButton
            // 
            this.HorrorMovieButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.HorrorMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HorrorMovieButton.Location = new System.Drawing.Point(7, 178);
            this.HorrorMovieButton.Name = "HorrorMovieButton";
            this.HorrorMovieButton.Size = new System.Drawing.Size(104, 28);
            this.HorrorMovieButton.TabIndex = 5;
            this.HorrorMovieButton.Text = "Horror";
            this.HorrorMovieButton.UseVisualStyleBackColor = false;
            this.HorrorMovieButton.Click += new System.EventHandler(this.HorrorMovieButton_Click);
            // 
            // FantasyMovieButton
            // 
            this.FantasyMovieButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.FantasyMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FantasyMovieButton.Location = new System.Drawing.Point(7, 153);
            this.FantasyMovieButton.Name = "FantasyMovieButton";
            this.FantasyMovieButton.Size = new System.Drawing.Size(104, 28);
            this.FantasyMovieButton.TabIndex = 4;
            this.FantasyMovieButton.Text = "Fantasy";
            this.FantasyMovieButton.UseVisualStyleBackColor = false;
            this.FantasyMovieButton.Click += new System.EventHandler(this.FantasyMovieButton_Click);
            // 
            // ComedyMovieButton
            // 
            this.ComedyMovieButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ComedyMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComedyMovieButton.Location = new System.Drawing.Point(7, 103);
            this.ComedyMovieButton.Name = "ComedyMovieButton";
            this.ComedyMovieButton.Size = new System.Drawing.Size(104, 28);
            this.ComedyMovieButton.TabIndex = 3;
            this.ComedyMovieButton.Text = "Comedy";
            this.ComedyMovieButton.UseVisualStyleBackColor = false;
            this.ComedyMovieButton.Click += new System.EventHandler(this.ComedyMovieButton_Click);
            // 
            // ActionMovieButton
            // 
            this.ActionMovieButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ActionMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionMovieButton.Location = new System.Drawing.Point(7, 78);
            this.ActionMovieButton.Name = "ActionMovieButton";
            this.ActionMovieButton.Size = new System.Drawing.Size(104, 28);
            this.ActionMovieButton.TabIndex = 2;
            this.ActionMovieButton.Text = "Action";
            this.ActionMovieButton.UseVisualStyleBackColor = false;
            this.ActionMovieButton.Click += new System.EventHandler(this.ActionMovieButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(7, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 28);
            this.button3.TabIndex = 1;
            this.button3.Text = "New";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MostPopularButton
            // 
            this.MostPopularButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MostPopularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MostPopularButton.Location = new System.Drawing.Point(7, 30);
            this.MostPopularButton.Name = "MostPopularButton";
            this.MostPopularButton.Size = new System.Drawing.Size(104, 28);
            this.MostPopularButton.TabIndex = 0;
            this.MostPopularButton.Text = "Most Popular";
            this.MostPopularButton.UseVisualStyleBackColor = false;
            this.MostPopularButton.Click += new System.EventHandler(this.MostPopularButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(125, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 305);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // showAllButton
            // 
            this.showAllButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.showAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showAllButton.Location = new System.Drawing.Point(571, 12);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(82, 26);
            this.showAllButton.TabIndex = 5;
            this.showAllButton.Text = "Display all";
            this.showAllButton.UseVisualStyleBackColor = false;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Movie",
            "Actor",
            "Director"});
            this.comboBox1.Location = new System.Drawing.Point(125, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Movie";
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 389);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Name = "IntroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Library ";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FantasyMovieButton;
        private System.Windows.Forms.Button ComedyMovieButton;
        private System.Windows.Forms.Button ActionMovieButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button MostPopularButton;
        private System.Windows.Forms.Button DramaMovieButton;
        private System.Windows.Forms.Button ThrillerMovieButton;
        private System.Windows.Forms.Button HorrorMovieButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}