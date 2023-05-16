
namespace LibraryOfDennysa
{
    partial class AFISARE_CARTI
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edituraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domeniuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anaparitieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrpagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet = new LibraryOfDennysa.BibliotecaDataSet();
            this.libraryTableAdapter = new LibraryOfDennysa.BibliotecaDataSetTableAdapters.LibraryTableAdapter();
            this.labelUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Maroon;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack.Font = new System.Drawing.Font("Parchment", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(535, 615);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(133, 73);
            this.buttonBack.TabIndex = 24;
            this.buttonBack.Text = "back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Parchment", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Maroon;
            this.exit.Location = new System.Drawing.Point(1145, -3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(74, 68);
            this.exit.TabIndex = 23;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titluDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.edituraDataGridViewTextBoxColumn,
            this.domeniuDataGridViewTextBoxColumn,
            this.anaparitieDataGridViewTextBoxColumn,
            this.nrpagDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.libraryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(222, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 541);
            this.dataGridView1.TabIndex = 25;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // titluDataGridViewTextBoxColumn
            // 
            this.titluDataGridViewTextBoxColumn.DataPropertyName = "titlu";
            this.titluDataGridViewTextBoxColumn.HeaderText = "titlu";
            this.titluDataGridViewTextBoxColumn.Name = "titluDataGridViewTextBoxColumn";
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            // 
            // edituraDataGridViewTextBoxColumn
            // 
            this.edituraDataGridViewTextBoxColumn.DataPropertyName = "editura";
            this.edituraDataGridViewTextBoxColumn.HeaderText = "editura";
            this.edituraDataGridViewTextBoxColumn.Name = "edituraDataGridViewTextBoxColumn";
            // 
            // domeniuDataGridViewTextBoxColumn
            // 
            this.domeniuDataGridViewTextBoxColumn.DataPropertyName = "domeniu";
            this.domeniuDataGridViewTextBoxColumn.HeaderText = "domeniu";
            this.domeniuDataGridViewTextBoxColumn.Name = "domeniuDataGridViewTextBoxColumn";
            // 
            // anaparitieDataGridViewTextBoxColumn
            // 
            this.anaparitieDataGridViewTextBoxColumn.DataPropertyName = "anaparitie";
            this.anaparitieDataGridViewTextBoxColumn.HeaderText = "anaparitie";
            this.anaparitieDataGridViewTextBoxColumn.Name = "anaparitieDataGridViewTextBoxColumn";
            // 
            // nrpagDataGridViewTextBoxColumn
            // 
            this.nrpagDataGridViewTextBoxColumn.DataPropertyName = "nrpag";
            this.nrpagDataGridViewTextBoxColumn.HeaderText = "nrpag";
            this.nrpagDataGridViewTextBoxColumn.Name = "nrpagDataGridViewTextBoxColumn";
            // 
            // libraryBindingSource
            // 
            this.libraryBindingSource.DataMember = "Library";
            this.libraryBindingSource.DataSource = this.bibliotecaDataSet;
            // 
            // bibliotecaDataSet
            // 
            this.bibliotecaDataSet.DataSetName = "BibliotecaDataSet";
            this.bibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryTableAdapter
            // 
            this.libraryTableAdapter.ClearBeforeFill = true;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.BackColor = System.Drawing.Color.Transparent;
            this.labelUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelUser.Font = new System.Drawing.Font("Parchment", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Maroon;
            this.labelUser.Location = new System.Drawing.Point(352, -3);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(447, 68);
            this.labelUser.TabIndex = 26;
            this.labelUser.Text = "Afisarea cartilor din biblioteca";
            // 
            // AFISARE_CARTI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryOfDennysa.Properties.Resources.afisareBG;
            this.ClientSize = new System.Drawing.Size(1220, 700);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AFISARE_CARTI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AFISARE_CARTI";
            this.Load += new System.EventHandler(this.AFISARE_CARTI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BibliotecaDataSet bibliotecaDataSet;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private BibliotecaDataSetTableAdapters.LibraryTableAdapter libraryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edituraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domeniuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anaparitieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrpagDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelUser;
    }
}