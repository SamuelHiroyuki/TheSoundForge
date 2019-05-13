namespace TheSoundForge
{
    partial class frmDelFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelFunc));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDfuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endfuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadefuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFfuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPfuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telfuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celfuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbTheSoundForgerDataSet2 = new TheSoundForge.dbTheSoundForgerDataSet2();
            this.tbFuncionarioTableAdapter = new TheSoundForge.dbTheSoundForgerDataSet2TableAdapters.tbFuncionarioTableAdapter();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTheSoundForgerDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDfuncDataGridViewTextBoxColumn,
            this.nomefuncDataGridViewTextBoxColumn,
            this.endfuncDataGridViewTextBoxColumn,
            this.cidadefuncDataGridViewTextBoxColumn,
            this.uFfuncDataGridViewTextBoxColumn,
            this.cEPfuncDataGridViewTextBoxColumn,
            this.telfuncDataGridViewTextBoxColumn,
            this.celfuncDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbFuncionarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDfuncDataGridViewTextBoxColumn
            // 
            this.iDfuncDataGridViewTextBoxColumn.DataPropertyName = "ID_func";
            this.iDfuncDataGridViewTextBoxColumn.HeaderText = "ID_func";
            this.iDfuncDataGridViewTextBoxColumn.Name = "iDfuncDataGridViewTextBoxColumn";
            this.iDfuncDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomefuncDataGridViewTextBoxColumn
            // 
            this.nomefuncDataGridViewTextBoxColumn.DataPropertyName = "Nome_func";
            this.nomefuncDataGridViewTextBoxColumn.HeaderText = "Nome_func";
            this.nomefuncDataGridViewTextBoxColumn.Name = "nomefuncDataGridViewTextBoxColumn";
            // 
            // endfuncDataGridViewTextBoxColumn
            // 
            this.endfuncDataGridViewTextBoxColumn.DataPropertyName = "End_func";
            this.endfuncDataGridViewTextBoxColumn.HeaderText = "End_func";
            this.endfuncDataGridViewTextBoxColumn.Name = "endfuncDataGridViewTextBoxColumn";
            // 
            // cidadefuncDataGridViewTextBoxColumn
            // 
            this.cidadefuncDataGridViewTextBoxColumn.DataPropertyName = "Cidade_func";
            this.cidadefuncDataGridViewTextBoxColumn.HeaderText = "Cidade_func";
            this.cidadefuncDataGridViewTextBoxColumn.Name = "cidadefuncDataGridViewTextBoxColumn";
            // 
            // uFfuncDataGridViewTextBoxColumn
            // 
            this.uFfuncDataGridViewTextBoxColumn.DataPropertyName = "UF_func";
            this.uFfuncDataGridViewTextBoxColumn.HeaderText = "UF_func";
            this.uFfuncDataGridViewTextBoxColumn.Name = "uFfuncDataGridViewTextBoxColumn";
            // 
            // cEPfuncDataGridViewTextBoxColumn
            // 
            this.cEPfuncDataGridViewTextBoxColumn.DataPropertyName = "CEP_func";
            this.cEPfuncDataGridViewTextBoxColumn.HeaderText = "CEP_func";
            this.cEPfuncDataGridViewTextBoxColumn.Name = "cEPfuncDataGridViewTextBoxColumn";
            // 
            // telfuncDataGridViewTextBoxColumn
            // 
            this.telfuncDataGridViewTextBoxColumn.DataPropertyName = "Tel_func";
            this.telfuncDataGridViewTextBoxColumn.HeaderText = "Tel_func";
            this.telfuncDataGridViewTextBoxColumn.Name = "telfuncDataGridViewTextBoxColumn";
            // 
            // celfuncDataGridViewTextBoxColumn
            // 
            this.celfuncDataGridViewTextBoxColumn.DataPropertyName = "Cel_func";
            this.celfuncDataGridViewTextBoxColumn.HeaderText = "Cel_func";
            this.celfuncDataGridViewTextBoxColumn.Name = "celfuncDataGridViewTextBoxColumn";
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            // 
            // tbFuncionarioBindingSource
            // 
            this.tbFuncionarioBindingSource.DataMember = "tbFuncionario";
            this.tbFuncionarioBindingSource.DataSource = this.dbTheSoundForgerDataSet2;
            // 
            // dbTheSoundForgerDataSet2
            // 
            this.dbTheSoundForgerDataSet2.DataSetName = "dbTheSoundForgerDataSet2";
            this.dbTheSoundForgerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFuncionarioTableAdapter
            // 
            this.tbFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(260, 168);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(245, 29);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Excluir";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // frmDelFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 209);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDelFunc";
            this.Text = "Deletar Funcionário";
            this.Load += new System.EventHandler(this.frmDelFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTheSoundForgerDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbTheSoundForgerDataSet2 dbTheSoundForgerDataSet2;
        private System.Windows.Forms.BindingSource tbFuncionarioBindingSource;
        private dbTheSoundForgerDataSet2TableAdapters.tbFuncionarioTableAdapter tbFuncionarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDfuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endfuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadefuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFfuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPfuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telfuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celfuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDel;
    }
}