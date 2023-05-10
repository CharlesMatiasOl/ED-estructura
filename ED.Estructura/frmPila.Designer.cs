namespace ED.Estructura
{
    partial class frmPila
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
            this.mrcListayGrilla = new System.Windows.Forms.GroupBox();
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstListaPila = new System.Windows.Forms.ListBox();
            this.mrcElementoEliminado = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramiteEE = new System.Windows.Forms.Label();
            this.lblNombreEE = new System.Windows.Forms.Label();
            this.lblCodigoEE = new System.Windows.Forms.Label();
            this.lblTramiteE = new System.Windows.Forms.Label();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblCodigoE = new System.Windows.Forms.Label();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramiteN = new System.Windows.Forms.TextBox();
            this.txtNombreN = new System.Windows.Forms.TextBox();
            this.txtCodigoN = new System.Windows.Forms.TextBox();
            this.lblTramiteN = new System.Windows.Forms.Label();
            this.lblNombreN = new System.Windows.Forms.Label();
            this.lblCodigoN = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mrcListayGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            this.mrcElementoEliminado.SuspendLayout();
            this.mrcNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcListayGrilla
            // 
            this.mrcListayGrilla.Controls.Add(this.dgvPila);
            this.mrcListayGrilla.Controls.Add(this.lstListaPila);
            this.mrcListayGrilla.Location = new System.Drawing.Point(22, 218);
            this.mrcListayGrilla.Name = "mrcListayGrilla";
            this.mrcListayGrilla.Size = new System.Drawing.Size(606, 196);
            this.mrcListayGrilla.TabIndex = 11;
            this.mrcListayGrilla.TabStop = false;
            this.mrcListayGrilla.Text = "Listado en una grilla y lista";
            // 
            // dgvPila
            // 
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPila.Location = new System.Drawing.Point(238, 22);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.Size = new System.Drawing.Size(344, 154);
            this.dgvPila.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codgio";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // lstListaPila
            // 
            this.lstListaPila.FormattingEnabled = true;
            this.lstListaPila.Location = new System.Drawing.Point(6, 16);
            this.lstListaPila.Name = "lstListaPila";
            this.lstListaPila.Size = new System.Drawing.Size(182, 160);
            this.lstListaPila.TabIndex = 0;
            // 
            // mrcElementoEliminado
            // 
            this.mrcElementoEliminado.Controls.Add(this.btnEliminar);
            this.mrcElementoEliminado.Controls.Add(this.lblTramiteEE);
            this.mrcElementoEliminado.Controls.Add(this.lblNombreEE);
            this.mrcElementoEliminado.Controls.Add(this.lblCodigoEE);
            this.mrcElementoEliminado.Controls.Add(this.lblTramiteE);
            this.mrcElementoEliminado.Controls.Add(this.lblNombreE);
            this.mrcElementoEliminado.Controls.Add(this.lblCodigoE);
            this.mrcElementoEliminado.Location = new System.Drawing.Point(438, 39);
            this.mrcElementoEliminado.Name = "mrcElementoEliminado";
            this.mrcElementoEliminado.Size = new System.Drawing.Size(190, 150);
            this.mrcElementoEliminado.TabIndex = 10;
            this.mrcElementoEliminado.TabStop = false;
            this.mrcElementoEliminado.Text = "Elemento Eliminado";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(9, 111);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblTramiteEE
            // 
            this.lblTramiteEE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteEE.Location = new System.Drawing.Point(66, 83);
            this.lblTramiteEE.Name = "lblTramiteEE";
            this.lblTramiteEE.Size = new System.Drawing.Size(100, 23);
            this.lblTramiteEE.TabIndex = 8;
            // 
            // lblNombreEE
            // 
            this.lblNombreEE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreEE.Location = new System.Drawing.Point(66, 51);
            this.lblNombreEE.Name = "lblNombreEE";
            this.lblNombreEE.Size = new System.Drawing.Size(100, 23);
            this.lblNombreEE.TabIndex = 7;
            // 
            // lblCodigoEE
            // 
            this.lblCodigoEE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigoEE.Location = new System.Drawing.Point(66, 16);
            this.lblCodigoEE.Name = "lblCodigoEE";
            this.lblCodigoEE.Size = new System.Drawing.Size(100, 23);
            this.lblCodigoEE.TabIndex = 6;
            // 
            // lblTramiteE
            // 
            this.lblTramiteE.AutoSize = true;
            this.lblTramiteE.Location = new System.Drawing.Point(6, 84);
            this.lblTramiteE.Name = "lblTramiteE";
            this.lblTramiteE.Size = new System.Drawing.Size(42, 13);
            this.lblTramiteE.TabIndex = 5;
            this.lblTramiteE.Text = "Tramite";
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Location = new System.Drawing.Point(6, 52);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(44, 13);
            this.lblNombreE.TabIndex = 4;
            this.lblNombreE.Text = "Nombre";
            // 
            // lblCodigoE
            // 
            this.lblCodigoE.AutoSize = true;
            this.lblCodigoE.Location = new System.Drawing.Point(6, 20);
            this.lblCodigoE.Name = "lblCodigoE";
            this.lblCodigoE.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoE.TabIndex = 3;
            this.lblCodigoE.Text = "Codigo";
            // 
            // mrcNuevoElemento
            // 
            this.mrcNuevoElemento.Controls.Add(this.btnAgregar);
            this.mrcNuevoElemento.Controls.Add(this.txtTramiteN);
            this.mrcNuevoElemento.Controls.Add(this.txtNombreN);
            this.mrcNuevoElemento.Controls.Add(this.txtCodigoN);
            this.mrcNuevoElemento.Controls.Add(this.lblTramiteN);
            this.mrcNuevoElemento.Controls.Add(this.lblNombreN);
            this.mrcNuevoElemento.Controls.Add(this.lblCodigoN);
            this.mrcNuevoElemento.Location = new System.Drawing.Point(223, 39);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(188, 150);
            this.mrcNuevoElemento.TabIndex = 9;
            this.mrcNuevoElemento.TabStop = false;
            this.mrcNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(10, 111);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramiteN
            // 
            this.txtTramiteN.Location = new System.Drawing.Point(64, 77);
            this.txtTramiteN.Name = "txtTramiteN";
            this.txtTramiteN.Size = new System.Drawing.Size(100, 20);
            this.txtTramiteN.TabIndex = 5;
            // 
            // txtNombreN
            // 
            this.txtNombreN.Location = new System.Drawing.Point(64, 49);
            this.txtNombreN.Name = "txtNombreN";
            this.txtNombreN.Size = new System.Drawing.Size(100, 20);
            this.txtNombreN.TabIndex = 4;
            // 
            // txtCodigoN
            // 
            this.txtCodigoN.Location = new System.Drawing.Point(64, 19);
            this.txtCodigoN.Name = "txtCodigoN";
            this.txtCodigoN.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoN.TabIndex = 3;
            // 
            // lblTramiteN
            // 
            this.lblTramiteN.AutoSize = true;
            this.lblTramiteN.Location = new System.Drawing.Point(7, 84);
            this.lblTramiteN.Name = "lblTramiteN";
            this.lblTramiteN.Size = new System.Drawing.Size(42, 13);
            this.lblTramiteN.TabIndex = 2;
            this.lblTramiteN.Text = "Tramite";
            // 
            // lblNombreN
            // 
            this.lblNombreN.AutoSize = true;
            this.lblNombreN.Location = new System.Drawing.Point(7, 52);
            this.lblNombreN.Name = "lblNombreN";
            this.lblNombreN.Size = new System.Drawing.Size(44, 13);
            this.lblNombreN.TabIndex = 1;
            this.lblNombreN.Text = "Nombre";
            // 
            // lblCodigoN
            // 
            this.lblCodigoN.AutoSize = true;
            this.lblCodigoN.Location = new System.Drawing.Point(7, 20);
            this.lblCodigoN.Name = "lblCodigoN";
            this.lblCodigoN.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoN.TabIndex = 0;
            this.lblCodigoN.Text = "Codigo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ED.Estructura.Properties.Resources.aaa;
            this.pictureBox1.Location = new System.Drawing.Point(22, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 443);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mrcListayGrilla);
            this.Controls.Add(this.mrcElementoEliminado);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Name = "frmPila";
            this.Text = "Estructura-Pila";
            this.Load += new System.EventHandler(this.frmPila_Load);
            this.mrcListayGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            this.mrcElementoEliminado.ResumeLayout(false);
            this.mrcElementoEliminado.PerformLayout();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcListayGrilla;
        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstListaPila;
        private System.Windows.Forms.GroupBox mrcElementoEliminado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTramiteEE;
        private System.Windows.Forms.Label lblNombreEE;
        private System.Windows.Forms.Label lblCodigoEE;
        private System.Windows.Forms.Label lblTramiteE;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblCodigoE;
        private System.Windows.Forms.GroupBox mrcNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramiteN;
        private System.Windows.Forms.TextBox txtNombreN;
        private System.Windows.Forms.TextBox txtCodigoN;
        private System.Windows.Forms.Label lblTramiteN;
        private System.Windows.Forms.Label lblNombreN;
        private System.Windows.Forms.Label lblCodigoN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}