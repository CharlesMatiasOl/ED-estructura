namespace ED.Estructura
{
    partial class frmCola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCola));
            this.mrcListayGrilla = new System.Windows.Forms.GroupBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstListaCola = new System.Windows.Forms.ListBox();
            this.mrcElementoEliminado = new System.Windows.Forms.GroupBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.lblTramiteEE = new System.Windows.Forms.Label();
            this.lblNombreEE = new System.Windows.Forms.Label();
            this.lblCodigoEE = new System.Windows.Forms.Label();
            this.lblTramiteE = new System.Windows.Forms.Label();
            this.lblNombreE = new System.Windows.Forms.Label();
            this.lblCodigoE = new System.Windows.Forms.Label();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtTramiteN = new System.Windows.Forms.TextBox();
            this.txtNombreN = new System.Windows.Forms.TextBox();
            this.txtCodigoN = new System.Windows.Forms.TextBox();
            this.lblTramiteN = new System.Windows.Forms.Label();
            this.lblNombreN = new System.Windows.Forms.Label();
            this.lblCodigoN = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mrcListayGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.mrcElementoEliminado.SuspendLayout();
            this.mrcNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcListayGrilla
            // 
            this.mrcListayGrilla.Controls.Add(this.dgvCola);
            this.mrcListayGrilla.Controls.Add(this.lstListaCola);
            this.mrcListayGrilla.Location = new System.Drawing.Point(17, 215);
            this.mrcListayGrilla.Name = "mrcListayGrilla";
            this.mrcListayGrilla.Size = new System.Drawing.Size(635, 184);
            this.mrcListayGrilla.TabIndex = 4;
            this.mrcListayGrilla.TabStop = false;
            this.mrcListayGrilla.Text = "Listado en una grilla y lista";
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCola.Location = new System.Drawing.Point(257, 13);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(344, 154);
            this.dgvCola.TabIndex = 1;
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
            // lstListaCola
            // 
            this.lstListaCola.FormattingEnabled = true;
            this.lstListaCola.Location = new System.Drawing.Point(7, 20);
            this.lstListaCola.Name = "lstListaCola";
            this.lstListaCola.Size = new System.Drawing.Size(182, 147);
            this.lstListaCola.TabIndex = 0;
            // 
            // mrcElementoEliminado
            // 
            this.mrcElementoEliminado.Controls.Add(this.cmdEliminar);
            this.mrcElementoEliminado.Controls.Add(this.lblTramiteEE);
            this.mrcElementoEliminado.Controls.Add(this.lblNombreEE);
            this.mrcElementoEliminado.Controls.Add(this.lblCodigoEE);
            this.mrcElementoEliminado.Controls.Add(this.lblTramiteE);
            this.mrcElementoEliminado.Controls.Add(this.lblNombreE);
            this.mrcElementoEliminado.Controls.Add(this.lblCodigoE);
            this.mrcElementoEliminado.Location = new System.Drawing.Point(452, 33);
            this.mrcElementoEliminado.Name = "mrcElementoEliminado";
            this.mrcElementoEliminado.Size = new System.Drawing.Size(200, 140);
            this.mrcElementoEliminado.TabIndex = 3;
            this.mrcElementoEliminado.TabStop = false;
            this.mrcElementoEliminado.Text = "Elemento Eliminado";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(9, 111);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(157, 23);
            this.cmdEliminar.TabIndex = 7;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
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
            this.mrcNuevoElemento.Controls.Add(this.cmdAgregar);
            this.mrcNuevoElemento.Controls.Add(this.txtTramiteN);
            this.mrcNuevoElemento.Controls.Add(this.txtNombreN);
            this.mrcNuevoElemento.Controls.Add(this.txtCodigoN);
            this.mrcNuevoElemento.Controls.Add(this.lblTramiteN);
            this.mrcNuevoElemento.Controls.Add(this.lblNombreN);
            this.mrcNuevoElemento.Controls.Add(this.lblCodigoN);
            this.mrcNuevoElemento.Location = new System.Drawing.Point(235, 33);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(200, 140);
            this.mrcNuevoElemento.TabIndex = 2;
            this.mrcNuevoElemento.TabStop = false;
            this.mrcNuevoElemento.Text = "Nuevo Elemento";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(10, 111);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(157, 23);
            this.cmdAgregar.TabIndex = 6;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
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
            this.pictureBox1.Image = global::ED.Estructura.Properties.Resources.Cola_svg;
            this.pictureBox1.Location = new System.Drawing.Point(24, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 421);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mrcListayGrilla);
            this.Controls.Add(this.mrcElementoEliminado);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCola";
            this.Text = "frmCola";
            this.Load += new System.EventHandler(this.frmCola_Load);
            this.mrcListayGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.mrcElementoEliminado.ResumeLayout(false);
            this.mrcElementoEliminado.PerformLayout();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcListayGrilla;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstListaCola;
        private System.Windows.Forms.GroupBox mrcElementoEliminado;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Label lblTramiteEE;
        private System.Windows.Forms.Label lblNombreEE;
        private System.Windows.Forms.Label lblCodigoEE;
        private System.Windows.Forms.Label lblTramiteE;
        private System.Windows.Forms.Label lblNombreE;
        private System.Windows.Forms.Label lblCodigoE;
        private System.Windows.Forms.GroupBox mrcNuevoElemento;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.TextBox txtTramiteN;
        private System.Windows.Forms.TextBox txtNombreN;
        private System.Windows.Forms.TextBox txtCodigoN;
        private System.Windows.Forms.Label lblTramiteN;
        private System.Windows.Forms.Label lblNombreN;
        private System.Windows.Forms.Label lblCodigoN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}