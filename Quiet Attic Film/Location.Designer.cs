namespace Quiet_Attic_Film
{
    partial class Location
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Location));
            this.txtCS = new System.Windows.Forms.TextBox();
            this.txtST = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtLI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvLocation = new System.Windows.Forms.DataGridView();
            this.propertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quiet_Attic_Film_ProductionDataSet5 = new Quiet_Attic_Film.Quiet_Attic_Film_ProductionDataSet5();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.propertyTableAdapter = new Quiet_Attic_Film.Quiet_Attic_Film_ProductionDataSet5TableAdapters.PropertyTableAdapter();
            this.btnClear = new System.Windows.Forms.Button();
            this.quiet_Attic_Film_ProductionDataSet10 = new Quiet_Attic_Film.Quiet_Attic_Film_ProductionDataSet10();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationTableAdapter = new Quiet_Attic_Film.Quiet_Attic_Film_ProductionDataSet10TableAdapters.LocationTableAdapter();
            this.locationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityorStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quiet_Attic_Film_ProductionDataSet11 = new Quiet_Attic_Film.Quiet_Attic_Film_ProductionDataSet11();
            this.locationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.locationTableAdapter1 = new Quiet_Attic_Film.Quiet_Attic_Film_ProductionDataSet11TableAdapters.LocationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiet_Attic_Film_ProductionDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiet_Attic_Film_ProductionDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiet_Attic_Film_ProductionDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCS
            // 
            this.txtCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCS.Location = new System.Drawing.Point(731, 338);
            this.txtCS.Multiline = true;
            this.txtCS.Name = "txtCS";
            this.txtCS.Size = new System.Drawing.Size(232, 29);
            this.txtCS.TabIndex = 4;
            // 
            // txtST
            // 
            this.txtST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtST.Location = new System.Drawing.Point(731, 267);
            this.txtST.Multiline = true;
            this.txtST.Name = "txtST";
            this.txtST.Size = new System.Drawing.Size(232, 29);
            this.txtST.TabIndex = 3;
            // 
            // txtLN
            // 
            this.txtLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLN.Location = new System.Drawing.Point(731, 198);
            this.txtLN.Multiline = true;
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(232, 29);
            this.txtLN.TabIndex = 2;
            // 
            // txtLI
            // 
            this.txtLI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLI.Location = new System.Drawing.Point(731, 121);
            this.txtLI.Multiline = true;
            this.txtLI.Name = "txtLI";
            this.txtLI.Size = new System.Drawing.Size(232, 29);
            this.txtLI.TabIndex = 1;
            this.txtLI.TextChanged += new System.EventHandler(this.txtLI_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Imprint MT Shadow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(570, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 58);
            this.label7.TabIndex = 27;
            this.label7.Text = "City or \r\nState";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(443, 543);
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
            this.btnSave.Location = new System.Drawing.Point(12, 543);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 36);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvLocation
            // 
            this.dgvLocation.AutoGenerateColumns = false;
            this.dgvLocation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationIDDataGridViewTextBoxColumn,
            this.locationNameDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityorStateDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn});
            this.dgvLocation.DataSource = this.locationBindingSource1;
            this.dgvLocation.Location = new System.Drawing.Point(12, 88);
            this.dgvLocation.Name = "dgvLocation";
            this.dgvLocation.RowHeadersWidth = 51;
            this.dgvLocation.RowTemplate.Height = 24;
            this.dgvLocation.Size = new System.Drawing.Size(531, 423);
            this.dgvLocation.TabIndex = 23;
            // 
            // propertyBindingSource
            // 
            this.propertyBindingSource.DataMember = "Property";
            this.propertyBindingSource.DataSource = this.quiet_Attic_Film_ProductionDataSet5;
            // 
            // quiet_Attic_Film_ProductionDataSet5
            // 
            this.quiet_Attic_Film_ProductionDataSet5.DataSetName = "Quiet_Attic_Film_ProductionDataSet5";
            this.quiet_Attic_Film_ProductionDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(570, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Street";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(570, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Loca: Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(570, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Location ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(679, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "Location Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gotham Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quiet Attic Films Production";
            // 
            // txtZC
            // 
            this.txtZC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZC.Location = new System.Drawing.Point(731, 415);
            this.txtZC.Multiline = true;
            this.txtZC.Name = "txtZC";
            this.txtZC.Size = new System.Drawing.Size(232, 29);
            this.txtZC.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(570, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 29);
            this.label6.TabIndex = 32;
            this.label6.Text = "Zip Code";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(888, 550);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 43);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(220, 543);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 36);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // propertyTableAdapter
            // 
            this.propertyTableAdapter.ClearBeforeFill = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(863, 475);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 36);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // quiet_Attic_Film_ProductionDataSet10
            // 
            this.quiet_Attic_Film_ProductionDataSet10.DataSetName = "Quiet_Attic_Film_ProductionDataSet10";
            this.quiet_Attic_Film_ProductionDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.quiet_Attic_Film_ProductionDataSet10;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // locationIDDataGridViewTextBoxColumn
            // 
            this.locationIDDataGridViewTextBoxColumn.DataPropertyName = "Location_ID";
            this.locationIDDataGridViewTextBoxColumn.HeaderText = "Location_ID";
            this.locationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationIDDataGridViewTextBoxColumn.Name = "locationIDDataGridViewTextBoxColumn";
            // 
            // locationNameDataGridViewTextBoxColumn
            // 
            this.locationNameDataGridViewTextBoxColumn.DataPropertyName = "Location_Name";
            this.locationNameDataGridViewTextBoxColumn.HeaderText = "Location_Name";
            this.locationNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationNameDataGridViewTextBoxColumn.Name = "locationNameDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // cityorStateDataGridViewTextBoxColumn
            // 
            this.cityorStateDataGridViewTextBoxColumn.DataPropertyName = "City_or_State";
            this.cityorStateDataGridViewTextBoxColumn.HeaderText = "City_or_State";
            this.cityorStateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityorStateDataGridViewTextBoxColumn.Name = "cityorStateDataGridViewTextBoxColumn";
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "Zip_Code";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "Zip_Code";
            this.zipCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            // 
            // quiet_Attic_Film_ProductionDataSet11
            // 
            this.quiet_Attic_Film_ProductionDataSet11.DataSetName = "Quiet_Attic_Film_ProductionDataSet11";
            this.quiet_Attic_Film_ProductionDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationBindingSource1
            // 
            this.locationBindingSource1.DataMember = "Location";
            this.locationBindingSource1.DataSource = this.quiet_Attic_Film_ProductionDataSet11;
            // 
            // locationTableAdapter1
            // 
            this.locationTableAdapter1.ClearBeforeFill = true;
            // 
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 605);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtZC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCS);
            this.Controls.Add(this.txtST);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.txtLI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Location";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location";
            this.Load += new System.EventHandler(this.Location_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiet_Attic_Film_ProductionDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiet_Attic_Film_ProductionDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiet_Attic_Film_ProductionDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCS;
        private System.Windows.Forms.TextBox txtST;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtLI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private Quiet_Attic_Film_ProductionDataSet5 quiet_Attic_Film_ProductionDataSet5;
        private System.Windows.Forms.BindingSource propertyBindingSource;
        private Quiet_Attic_Film_ProductionDataSet5TableAdapters.PropertyTableAdapter propertyTableAdapter;
        private System.Windows.Forms.Button btnClear;
        private Quiet_Attic_Film_ProductionDataSet10 quiet_Attic_Film_ProductionDataSet10;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private Quiet_Attic_Film_ProductionDataSet10TableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityorStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private Quiet_Attic_Film_ProductionDataSet11 quiet_Attic_Film_ProductionDataSet11;
        private System.Windows.Forms.BindingSource locationBindingSource1;
        private Quiet_Attic_Film_ProductionDataSet11TableAdapters.LocationTableAdapter locationTableAdapter1;
    }
}