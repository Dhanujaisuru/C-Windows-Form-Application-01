﻿namespace Quiet_Attic_Film
{
    partial class Production
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Production));
            this.txtND = new System.Windows.Forms.TextBox();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.txtPI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvProduction = new System.Windows.Forms.DataGridView();
            this.productionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quiet_Attic_Film_ProductionDataSet3 = new Quiet_Attic_Film.Quiet_Attic_Film_ProductionDataSet3();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPT = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.productionTableAdapter = new Quiet_Attic_Film.Quiet_Attic_Film_ProductionDataSet3TableAdapters.ProductionTableAdapter();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiet_Attic_Film_ProductionDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtND
            // 
            this.txtND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtND.Location = new System.Drawing.Point(736, 336);
            this.txtND.Multiline = true;
            this.txtND.Name = "txtND";
            this.txtND.Size = new System.Drawing.Size(226, 29);
            this.txtND.TabIndex = 4;
            // 
            // txtPN
            // 
            this.txtPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPN.Location = new System.Drawing.Point(736, 200);
            this.txtPN.Multiline = true;
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(226, 29);
            this.txtPN.TabIndex = 2;
            // 
            // txtPI
            // 
            this.txtPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPI.Location = new System.Drawing.Point(736, 123);
            this.txtPI.Multiline = true;
            this.txtPI.Name = "txtPI";
            this.txtPI.Size = new System.Drawing.Size(226, 29);
            this.txtPI.TabIndex = 1;
            this.txtPI.TextChanged += new System.EventHandler(this.txtPI_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Imprint MT Shadow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(569, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "No of Days";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(442, 545);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 36);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(11, 545);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 36);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvProduction
            // 
            this.dgvProduction.AutoGenerateColumns = false;
            this.dgvProduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productionIDDataGridViewTextBoxColumn,
            this.productionNameDataGridViewTextBoxColumn,
            this.productionTypeDataGridViewTextBoxColumn,
            this.noOfDaysDataGridViewTextBoxColumn});
            this.dgvProduction.DataSource = this.productionBindingSource;
            this.dgvProduction.Location = new System.Drawing.Point(11, 90);
            this.dgvProduction.Name = "dgvProduction";
            this.dgvProduction.RowHeadersWidth = 51;
            this.dgvProduction.RowTemplate.Height = 24;
            this.dgvProduction.Size = new System.Drawing.Size(531, 423);
            this.dgvProduction.TabIndex = 23;
            // 
            // productionIDDataGridViewTextBoxColumn
            // 
            this.productionIDDataGridViewTextBoxColumn.DataPropertyName = "Production_ID";
            this.productionIDDataGridViewTextBoxColumn.HeaderText = "Production_ID";
            this.productionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productionIDDataGridViewTextBoxColumn.Name = "productionIDDataGridViewTextBoxColumn";
            // 
            // productionNameDataGridViewTextBoxColumn
            // 
            this.productionNameDataGridViewTextBoxColumn.DataPropertyName = "Production_Name";
            this.productionNameDataGridViewTextBoxColumn.HeaderText = "Production_Name";
            this.productionNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productionNameDataGridViewTextBoxColumn.Name = "productionNameDataGridViewTextBoxColumn";
            // 
            // productionTypeDataGridViewTextBoxColumn
            // 
            this.productionTypeDataGridViewTextBoxColumn.DataPropertyName = "Production_Type";
            this.productionTypeDataGridViewTextBoxColumn.HeaderText = "Production_Type";
            this.productionTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productionTypeDataGridViewTextBoxColumn.Name = "productionTypeDataGridViewTextBoxColumn";
            // 
            // noOfDaysDataGridViewTextBoxColumn
            // 
            this.noOfDaysDataGridViewTextBoxColumn.DataPropertyName = "No_Of_Days";
            this.noOfDaysDataGridViewTextBoxColumn.HeaderText = "No_Of_Days";
            this.noOfDaysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noOfDaysDataGridViewTextBoxColumn.Name = "noOfDaysDataGridViewTextBoxColumn";
            // 
            // productionBindingSource
            // 
            this.productionBindingSource.DataMember = "Production";
            this.productionBindingSource.DataSource = this.quiet_Attic_Film_ProductionDataSet3;
            // 
            // quiet_Attic_Film_ProductionDataSet3
            // 
            this.quiet_Attic_Film_ProductionDataSet3.DataSetName = "Quiet_Attic_Film_ProductionDataSet3";
            this.quiet_Attic_Film_ProductionDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(569, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Prod: Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(569, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Prod: Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Prod: ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(642, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "Production Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gotham Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quiet Attic Films Production";
            // 
            // cmbPT
            // 
            this.cmbPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPT.FormattingEnabled = true;
            this.cmbPT.ItemHeight = 25;
            this.cmbPT.Items.AddRange(new object[] {
            "Advertisement",
            "Information Video",
            "Training Film"});
            this.cmbPT.Location = new System.Drawing.Point(736, 274);
            this.cmbPT.Name = "cmbPT";
            this.cmbPT.Size = new System.Drawing.Size(226, 33);
            this.cmbPT.TabIndex = 32;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(886, 553);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 43);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(221, 545);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 36);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // productionTableAdapter
            // 
            this.productionTableAdapter.ClearBeforeFill = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(861, 477);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 36);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Production
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 608);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbPT);
            this.Controls.Add(this.txtND);
            this.Controls.Add(this.txtPN);
            this.Controls.Add(this.txtPI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvProduction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Production";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production";
            this.Load += new System.EventHandler(this.Production_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiet_Attic_Film_ProductionDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtND;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.TextBox txtPI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvProduction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPT;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private Quiet_Attic_Film_ProductionDataSet3 quiet_Attic_Film_ProductionDataSet3;
        private System.Windows.Forms.BindingSource productionBindingSource;
        private Quiet_Attic_Film_ProductionDataSet3TableAdapters.ProductionTableAdapter productionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClear;
    }
}