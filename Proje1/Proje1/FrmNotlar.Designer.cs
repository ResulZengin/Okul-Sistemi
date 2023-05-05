namespace Proje1
{
    partial class FrmNotlar
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
            this.bonusOkulDataSet = new Proje1.BonusOkulDataSet();
            this.tBLNOTLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLNOTLARTableAdapter = new Proje1.BonusOkulDataSetTableAdapters.TBLNOTLARTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusOkulDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLNOTLARBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 598);
            this.dataGridView1.TabIndex = 0;
            // 
            // bonusOkulDataSet
            // 
            this.bonusOkulDataSet.DataSetName = "BonusOkulDataSet";
            this.bonusOkulDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLNOTLARBindingSource
            // 
            this.tBLNOTLARBindingSource.DataMember = "TBLNOTLAR";
            this.tBLNOTLARBindingSource.DataSource = this.bonusOkulDataSet;
            // 
            // tBLNOTLARTableAdapter
            // 
            this.tBLNOTLARTableAdapter.ClearBeforeFill = true;
            // 
            // FrmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 598);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmNotlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Not Ekranı";
            this.Load += new System.EventHandler(this.FrmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusOkulDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLNOTLARBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BonusOkulDataSet bonusOkulDataSet;
        private System.Windows.Forms.BindingSource tBLNOTLARBindingSource;
        private BonusOkulDataSetTableAdapters.TBLNOTLARTableAdapter tBLNOTLARTableAdapter;
    }
}