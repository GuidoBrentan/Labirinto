namespace appLabirinto
{
    partial class appLabirinto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnEncontrar = new System.Windows.Forms.Button();
            this.gbBotoes = new System.Windows.Forms.GroupBox();
            this.gbLabirinto = new System.Windows.Forms.GroupBox();
            this.dgvLabirinto = new System.Windows.Forms.DataGridView();
            this.openFIle = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gbBotoes.SuspendLayout();
            this.gbLabirinto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabirinto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(597, 9);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 45);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir Arquivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnEncontrar
            // 
            this.btnEncontrar.Location = new System.Drawing.Point(678, 9);
            this.btnEncontrar.Name = "btnEncontrar";
            this.btnEncontrar.Size = new System.Drawing.Size(75, 45);
            this.btnEncontrar.TabIndex = 0;
            this.btnEncontrar.Text = "Encontrar Caminhos";
            this.btnEncontrar.UseVisualStyleBackColor = true;
            this.btnEncontrar.Click += new System.EventHandler(this.btnEncontrar_Click);
            // 
            // gbBotoes
            // 
            this.gbBotoes.Controls.Add(this.btnAbrir);
            this.gbBotoes.Controls.Add(this.btnEncontrar);
            this.gbBotoes.Location = new System.Drawing.Point(13, 12);
            this.gbBotoes.Name = "gbBotoes";
            this.gbBotoes.Size = new System.Drawing.Size(759, 60);
            this.gbBotoes.TabIndex = 1;
            this.gbBotoes.TabStop = false;
            // 
            // gbLabirinto
            // 
            this.gbLabirinto.Controls.Add(this.dgvLabirinto);
            this.gbLabirinto.Location = new System.Drawing.Point(13, 79);
            this.gbLabirinto.Name = "gbLabirinto";
            this.gbLabirinto.Size = new System.Drawing.Size(753, 261);
            this.gbLabirinto.TabIndex = 2;
            this.gbLabirinto.TabStop = false;
            this.gbLabirinto.Text = "Labirinto";
            // 
            // dgvLabirinto
            // 
            this.dgvLabirinto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLabirinto.Location = new System.Drawing.Point(7, 23);
            this.dgvLabirinto.Name = "dgvLabirinto";
            this.dgvLabirinto.ReadOnly = true;
            this.dgvLabirinto.Size = new System.Drawing.Size(740, 225);
            this.dgvLabirinto.TabIndex = 0;
            this.dgvLabirinto.Text = "dataGridView1";
            // 
            // openFIle
            // 
            this.openFIle.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(14, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 270);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caminhos";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(724, 235);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.Text = "dataGridView2";
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // appLabirinto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 631);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbLabirinto);
            this.Controls.Add(this.gbBotoes);
            this.Name = "appLabirinto";
            this.Text = "appLabirinto";
            this.gbBotoes.ResumeLayout(false);
            this.gbLabirinto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabirinto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnEncontrar;
        private System.Windows.Forms.GroupBox gbBotoes;
        private System.Windows.Forms.GroupBox gbLabirinto;
        private System.Windows.Forms.DataGridView dgvLabirinto;
        private System.Windows.Forms.OpenFileDialog openFIle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

