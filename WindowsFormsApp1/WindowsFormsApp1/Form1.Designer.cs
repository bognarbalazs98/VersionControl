namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tickidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradingDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portfolioEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeTrackerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portfolioEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tickidDataGridViewTextBoxColumn,
            this.indexDataGridViewTextBoxColumn,
            this.tradingDayDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.volumeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tickBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticksDataGridViewTextBoxColumn,
            this.databaseDataGridViewTextBoxColumn,
            this.changeTrackerDataGridViewTextBoxColumn,
            this.configurationDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.portfolioEntitiesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(287, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // tickBindingSource
            // 
            this.tickBindingSource.DataSource = typeof(WindowsFormsApp1.Tick);
            // 
            // tickidDataGridViewTextBoxColumn
            // 
            this.tickidDataGridViewTextBoxColumn.DataPropertyName = "Tick_id";
            this.tickidDataGridViewTextBoxColumn.HeaderText = "Tick_id";
            this.tickidDataGridViewTextBoxColumn.Name = "tickidDataGridViewTextBoxColumn";
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "Index";
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            // 
            // tradingDayDataGridViewTextBoxColumn
            // 
            this.tradingDayDataGridViewTextBoxColumn.DataPropertyName = "TradingDay";
            this.tradingDayDataGridViewTextBoxColumn.HeaderText = "TradingDay";
            this.tradingDayDataGridViewTextBoxColumn.Name = "tradingDayDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // volumeDataGridViewTextBoxColumn
            // 
            this.volumeDataGridViewTextBoxColumn.DataPropertyName = "Volume";
            this.volumeDataGridViewTextBoxColumn.HeaderText = "Volume";
            this.volumeDataGridViewTextBoxColumn.Name = "volumeDataGridViewTextBoxColumn";
            // 
            // portfolioEntitiesBindingSource
            // 
            this.portfolioEntitiesBindingSource.DataSource = typeof(WindowsFormsApp1.PortfolioEntities);
            // 
            // ticksDataGridViewTextBoxColumn
            // 
            this.ticksDataGridViewTextBoxColumn.DataPropertyName = "Ticks";
            this.ticksDataGridViewTextBoxColumn.HeaderText = "Ticks";
            this.ticksDataGridViewTextBoxColumn.Name = "ticksDataGridViewTextBoxColumn";
            // 
            // databaseDataGridViewTextBoxColumn
            // 
            this.databaseDataGridViewTextBoxColumn.DataPropertyName = "Database";
            this.databaseDataGridViewTextBoxColumn.HeaderText = "Database";
            this.databaseDataGridViewTextBoxColumn.Name = "databaseDataGridViewTextBoxColumn";
            this.databaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // changeTrackerDataGridViewTextBoxColumn
            // 
            this.changeTrackerDataGridViewTextBoxColumn.DataPropertyName = "ChangeTracker";
            this.changeTrackerDataGridViewTextBoxColumn.HeaderText = "ChangeTracker";
            this.changeTrackerDataGridViewTextBoxColumn.Name = "changeTrackerDataGridViewTextBoxColumn";
            this.changeTrackerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // configurationDataGridViewTextBoxColumn
            // 
            this.configurationDataGridViewTextBoxColumn.DataPropertyName = "Configuration";
            this.configurationDataGridViewTextBoxColumn.HeaderText = "Configuration";
            this.configurationDataGridViewTextBoxColumn.Name = "configurationDataGridViewTextBoxColumn";
            this.configurationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portfolioEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tickidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradingDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tickBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeTrackerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn configurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource portfolioEntitiesBindingSource;
    }
}

