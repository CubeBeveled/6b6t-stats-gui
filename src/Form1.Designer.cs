namespace _6b6tStatsGUI
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
        /// <param name="disposing">True if managed resources should be disposed; otherwise, False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.fetchStatsButton = new System.Windows.Forms.Button();
            this.statsDataGridView = new System.Windows.Forms.DataGridView();
            this.statusLabel = new System.Windows.Forms.Label();

            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameTextBox.Location = new System.Drawing.Point(30, 30);
            this.usernameTextBox.Size = new System.Drawing.Size(250, 30);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PlaceholderText = "Enter Username";
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.usernameTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // fetchStatsButton
            // 
            this.fetchStatsButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.fetchStatsButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fetchStatsButton.ForeColor = System.Drawing.Color.White;
            this.fetchStatsButton.Location = new System.Drawing.Point(300, 30);
            this.fetchStatsButton.Size = new System.Drawing.Size(120, 30);
            this.fetchStatsButton.Name = "fetchStatsButton";
            this.fetchStatsButton.Text = "Fetch Stats";
            this.fetchStatsButton.UseVisualStyleBackColor = false;
            this.fetchStatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fetchStatsButton.FlatAppearance.BorderSize = 0;
            this.fetchStatsButton.MouseEnter += new System.EventHandler(this.FetchStatsButton_MouseEnter);
            this.fetchStatsButton.MouseLeave += new System.EventHandler(this.FetchStatsButton_MouseLeave);
            this.fetchStatsButton.Click += new System.EventHandler(this.FetchStatsButton_Click);

            // 
            // statsDataGridView
            // 
            this.statsDataGridView.AllowUserToAddRows = false;
            this.statsDataGridView.AllowUserToDeleteRows = false;
            this.statsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.statsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.statsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statsDataGridView.Location = new System.Drawing.Point(30, 80);
            this.statsDataGridView.Size = new System.Drawing.Size(660, 280);  
            this.statsDataGridView.Name = "statsDataGridView";
            this.statsDataGridView.ReadOnly = true;
            this.statsDataGridView.RowHeadersVisible = false;
            this.statsDataGridView.ColumnCount = 4;
            this.statsDataGridView.Columns[0].Name = "Stat";
            this.statsDataGridView.Columns[1].Name = "7 Days";
            this.statsDataGridView.Columns[2].Name = "30 Days";
            this.statsDataGridView.Columns[3].Name = "Total";

            // Header Style
            this.statsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.statsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.statsDataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // Adjusting column widths and row size
            this.statsDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.statsDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.statsDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.statsDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Reduced font size for better fit
            this.statsDataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statsDataGridView.RowTemplate.Height = 18; 

            // Styling the grid rows
            this.statsDataGridView.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.statsDataGridView.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.statsDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(75, 75, 75);
            this.statsDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            // Add hover effect for rows
            this.statsDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.StatsDataGridView_CellMouseEnter);
            this.statsDataGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.StatsDataGridView_CellMouseLeave);

            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(30, 370);
            this.statusLabel.Size = new System.Drawing.Size(660, 20);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Text = "Enter a username to fetch stats.";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.ClientSize = new System.Drawing.Size(820, 450);  
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.fetchStatsButton);
            this.Controls.Add(this.statsDataGridView);
            this.Controls.Add(this.statusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "6b6t Player Stats";

            ((System.ComponentModel.ISupportInitialize)(this.statsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button fetchStatsButton;
        private System.Windows.Forms.DataGridView statsDataGridView;
        private System.Windows.Forms.Label statusLabel;

        // Hover effect for fetchStatsButton
        private void FetchStatsButton_MouseEnter(object sender, EventArgs e)
        {
            fetchStatsButton.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
        }

        private void FetchStatsButton_MouseLeave(object sender, EventArgs e)
        {
            fetchStatsButton.BackColor = System.Drawing.Color.FromArgb(50, 50, 50);
        }

        // Hover effect for rows in DataGridView
        private void StatsDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                statsDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            }
        }

        private void StatsDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                statsDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(60, 60, 60);
            }
        }
    }
}
