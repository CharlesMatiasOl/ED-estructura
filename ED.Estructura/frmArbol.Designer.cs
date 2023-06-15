namespace ED.Estructura
{
    partial class frmArbol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArbol));
            this.mrcListado = new System.Windows.Forms.GroupBox();
            this.lstListarArbol = new System.Windows.Forms.ListBox();
            this.dgGrillaArbol = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcOrden = new System.Windows.Forms.GroupBox();
            this.optDescendente = new System.Windows.Forms.RadioButton();
            this.optAscendente = new System.Windows.Forms.RadioButton();
            this.mrcLista = new System.Windows.Forms.GroupBox();
            this.optPostOrden = new System.Windows.Forms.RadioButton();
            this.optPreOrden = new System.Windows.Forms.RadioButton();
            this.optInOrden = new System.Windows.Forms.RadioButton();
            this.mrcElementoEliminado = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lstCodigo = new System.Windows.Forms.ComboBox();
            this.lblCodigoEE = new System.Windows.Forms.Label();
            this.mrcNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramiteN = new System.Windows.Forms.TextBox();
            this.txtNombreN = new System.Windows.Forms.TextBox();
            this.txtCodigoN = new System.Windows.Forms.TextBox();
            this.lblTramiteN = new System.Windows.Forms.Label();
            this.lblNombreN = new System.Windows.Forms.Label();
            this.lblCodigoN = new System.Windows.Forms.Label();
            this.PTArbol = new System.Windows.Forms.TreeView();
            this.mrcListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrillaArbol)).BeginInit();
            this.mrcOrden.SuspendLayout();
            this.mrcLista.SuspendLayout();
            this.mrcElementoEliminado.SuspendLayout();
            this.mrcNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcListado
            // 
            this.mrcListado.Controls.Add(this.lstListarArbol);
            this.mrcListado.Controls.Add(this.dgGrillaArbol);
            this.mrcListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcListado.ForeColor = System.Drawing.Color.Black;
            this.mrcListado.Location = new System.Drawing.Point(38, 396);
            this.mrcListado.Name = "mrcListado";
            this.mrcListado.Size = new System.Drawing.Size(653, 196);
            this.mrcListado.TabIndex = 53;
            this.mrcListado.TabStop = false;
            this.mrcListado.Text = "Listado en una lista y una grilla";
            // 
            // lstListarArbol
            // 
            this.lstListarArbol.FormattingEnabled = true;
            this.lstListarArbol.Location = new System.Drawing.Point(20, 30);
            this.lstListarArbol.Name = "lstListarArbol";
            this.lstListarArbol.Size = new System.Drawing.Size(222, 134);
            this.lstListarArbol.TabIndex = 1;
            // 
            // dgGrillaArbol
            // 
            this.dgGrillaArbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGrillaArbol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgGrillaArbol.Location = new System.Drawing.Point(286, 30);
            this.dgGrillaArbol.Name = "dgGrillaArbol";
            this.dgGrillaArbol.Size = new System.Drawing.Size(344, 139);
            this.dgGrillaArbol.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.Name = "Tramite";
            // 
            // mrcOrden
            // 
            this.mrcOrden.Controls.Add(this.optDescendente);
            this.mrcOrden.Controls.Add(this.optAscendente);
            this.mrcOrden.Enabled = false;
            this.mrcOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcOrden.ForeColor = System.Drawing.Color.Black;
            this.mrcOrden.Location = new System.Drawing.Point(557, 255);
            this.mrcOrden.Name = "mrcOrden";
            this.mrcOrden.Size = new System.Drawing.Size(134, 118);
            this.mrcOrden.TabIndex = 61;
            this.mrcOrden.TabStop = false;
            this.mrcOrden.Text = "Orden";
            // 
            // optDescendente
            // 
            this.optDescendente.AutoSize = true;
            this.optDescendente.Location = new System.Drawing.Point(19, 80);
            this.optDescendente.Name = "optDescendente";
            this.optDescendente.Size = new System.Drawing.Size(89, 17);
            this.optDescendente.TabIndex = 3;
            this.optDescendente.TabStop = true;
            this.optDescendente.Text = "Descendente";
            this.optDescendente.UseVisualStyleBackColor = true;
            this.optDescendente.CheckedChanged += new System.EventHandler(this.optDescendente_CheckedChanged);
            // 
            // optAscendente
            // 
            this.optAscendente.AutoSize = true;
            this.optAscendente.Location = new System.Drawing.Point(19, 36);
            this.optAscendente.Name = "optAscendente";
            this.optAscendente.Size = new System.Drawing.Size(82, 17);
            this.optAscendente.TabIndex = 2;
            this.optAscendente.TabStop = true;
            this.optAscendente.Text = "Ascendente";
            this.optAscendente.UseVisualStyleBackColor = true;
            this.optAscendente.CheckedChanged += new System.EventHandler(this.optAscendente_CheckedChanged);
            // 
            // mrcLista
            // 
            this.mrcLista.Controls.Add(this.optPostOrden);
            this.mrcLista.Controls.Add(this.optPreOrden);
            this.mrcLista.Controls.Add(this.optInOrden);
            this.mrcLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcLista.ForeColor = System.Drawing.Color.Black;
            this.mrcLista.Location = new System.Drawing.Point(557, 27);
            this.mrcLista.Name = "mrcLista";
            this.mrcLista.Size = new System.Drawing.Size(134, 218);
            this.mrcLista.TabIndex = 60;
            this.mrcLista.TabStop = false;
            this.mrcLista.Text = "Lista";
            this.mrcLista.Enter += new System.EventHandler(this.mrcLista_Enter);
            // 
            // optPostOrden
            // 
            this.optPostOrden.AutoSize = true;
            this.optPostOrden.Location = new System.Drawing.Point(19, 121);
            this.optPostOrden.Name = "optPostOrden";
            this.optPostOrden.Size = new System.Drawing.Size(78, 17);
            this.optPostOrden.TabIndex = 2;
            this.optPostOrden.TabStop = true;
            this.optPostOrden.Text = "Post-Orden";
            this.optPostOrden.UseVisualStyleBackColor = true;
            this.optPostOrden.CheckedChanged += new System.EventHandler(this.optPostOrden_CheckedChanged);
            // 
            // optPreOrden
            // 
            this.optPreOrden.AutoSize = true;
            this.optPreOrden.Location = new System.Drawing.Point(19, 80);
            this.optPreOrden.Name = "optPreOrden";
            this.optPreOrden.Size = new System.Drawing.Size(73, 17);
            this.optPreOrden.TabIndex = 1;
            this.optPreOrden.TabStop = true;
            this.optPreOrden.Text = "Pre-Orden";
            this.optPreOrden.UseVisualStyleBackColor = true;
            this.optPreOrden.CheckedChanged += new System.EventHandler(this.optPreOrden_CheckedChanged);
            // 
            // optInOrden
            // 
            this.optInOrden.AutoSize = true;
            this.optInOrden.Location = new System.Drawing.Point(19, 36);
            this.optInOrden.Name = "optInOrden";
            this.optInOrden.Size = new System.Drawing.Size(66, 17);
            this.optInOrden.TabIndex = 0;
            this.optInOrden.TabStop = true;
            this.optInOrden.Text = "In-Orden";
            this.optInOrden.UseVisualStyleBackColor = true;
            this.optInOrden.CheckedChanged += new System.EventHandler(this.optInOrden_CheckedChanged);
            // 
            // mrcElementoEliminado
            // 
            this.mrcElementoEliminado.Controls.Add(this.btnEliminar);
            this.mrcElementoEliminado.Controls.Add(this.lstCodigo);
            this.mrcElementoEliminado.Controls.Add(this.lblCodigoEE);
            this.mrcElementoEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcElementoEliminado.ForeColor = System.Drawing.Color.Black;
            this.mrcElementoEliminado.Location = new System.Drawing.Point(280, 255);
            this.mrcElementoEliminado.Name = "mrcElementoEliminado";
            this.mrcElementoEliminado.Size = new System.Drawing.Size(248, 118);
            this.mrcElementoEliminado.TabIndex = 59;
            this.mrcElementoEliminado.TabStop = false;
            this.mrcElementoEliminado.Text = "Elemento eliminado";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(107, 69);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lstCodigo
            // 
            this.lstCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstCodigo.FormattingEnabled = true;
            this.lstCodigo.Location = new System.Drawing.Point(107, 30);
            this.lstCodigo.Name = "lstCodigo";
            this.lstCodigo.Size = new System.Drawing.Size(116, 21);
            this.lstCodigo.TabIndex = 3;
            // 
            // lblCodigoEE
            // 
            this.lblCodigoEE.AutoSize = true;
            this.lblCodigoEE.Location = new System.Drawing.Point(29, 36);
            this.lblCodigoEE.Name = "lblCodigoEE";
            this.lblCodigoEE.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoEE.TabIndex = 2;
            this.lblCodigoEE.Text = "Codigo:";
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
            this.mrcNuevoElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcNuevoElemento.ForeColor = System.Drawing.Color.Black;
            this.mrcNuevoElemento.Location = new System.Drawing.Point(280, 27);
            this.mrcNuevoElemento.Name = "mrcNuevoElemento";
            this.mrcNuevoElemento.Size = new System.Drawing.Size(248, 218);
            this.mrcNuevoElemento.TabIndex = 58;
            this.mrcNuevoElemento.TabStop = false;
            this.mrcNuevoElemento.Text = "Nuevo elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(123, 167);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramiteN
            // 
            this.txtTramiteN.Location = new System.Drawing.Point(123, 123);
            this.txtTramiteN.Name = "txtTramiteN";
            this.txtTramiteN.Size = new System.Drawing.Size(100, 20);
            this.txtTramiteN.TabIndex = 2;
            // 
            // txtNombreN
            // 
            this.txtNombreN.Location = new System.Drawing.Point(123, 82);
            this.txtNombreN.Name = "txtNombreN";
            this.txtNombreN.Size = new System.Drawing.Size(100, 20);
            this.txtNombreN.TabIndex = 1;
            // 
            // txtCodigoN
            // 
            this.txtCodigoN.Location = new System.Drawing.Point(123, 36);
            this.txtCodigoN.Name = "txtCodigoN";
            this.txtCodigoN.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoN.TabIndex = 0;
            // 
            // lblTramiteN
            // 
            this.lblTramiteN.AutoSize = true;
            this.lblTramiteN.Location = new System.Drawing.Point(18, 129);
            this.lblTramiteN.Name = "lblTramiteN";
            this.lblTramiteN.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteN.TabIndex = 3;
            this.lblTramiteN.Text = "Tramite:";
            // 
            // lblNombreN
            // 
            this.lblNombreN.AutoSize = true;
            this.lblNombreN.Location = new System.Drawing.Point(18, 88);
            this.lblNombreN.Name = "lblNombreN";
            this.lblNombreN.Size = new System.Drawing.Size(47, 13);
            this.lblNombreN.TabIndex = 2;
            this.lblNombreN.Text = "Nombre:";
            // 
            // lblCodigoN
            // 
            this.lblCodigoN.AutoSize = true;
            this.lblCodigoN.Location = new System.Drawing.Point(18, 42);
            this.lblCodigoN.Name = "lblCodigoN";
            this.lblCodigoN.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoN.TabIndex = 1;
            this.lblCodigoN.Text = "Codigo:";
            // 
            // PTArbol
            // 
            this.PTArbol.Location = new System.Drawing.Point(38, 27);
            this.PTArbol.Name = "PTArbol";
            this.PTArbol.Size = new System.Drawing.Size(222, 346);
            this.PTArbol.TabIndex = 62;
            // 
            // frmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 624);
            this.Controls.Add(this.PTArbol);
            this.Controls.Add(this.mrcOrden);
            this.Controls.Add(this.mrcListado);
            this.Controls.Add(this.mrcLista);
            this.Controls.Add(this.mrcNuevoElemento);
            this.Controls.Add(this.mrcElementoEliminado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArbol";
            this.Text = "frmArbol";
            this.Load += new System.EventHandler(this.frmArbol_Load);
            this.mrcListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGrillaArbol)).EndInit();
            this.mrcOrden.ResumeLayout(false);
            this.mrcOrden.PerformLayout();
            this.mrcLista.ResumeLayout(false);
            this.mrcLista.PerformLayout();
            this.mrcElementoEliminado.ResumeLayout(false);
            this.mrcElementoEliminado.PerformLayout();
            this.mrcNuevoElemento.ResumeLayout(false);
            this.mrcNuevoElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcListado;
        private System.Windows.Forms.ListBox lstListarArbol;
        private System.Windows.Forms.DataGridView dgGrillaArbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.GroupBox mrcOrden;
        private System.Windows.Forms.RadioButton optDescendente;
        private System.Windows.Forms.RadioButton optAscendente;
        private System.Windows.Forms.GroupBox mrcLista;
        private System.Windows.Forms.RadioButton optPostOrden;
        private System.Windows.Forms.RadioButton optPreOrden;
        private System.Windows.Forms.RadioButton optInOrden;
        private System.Windows.Forms.GroupBox mrcElementoEliminado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox lstCodigo;
        private System.Windows.Forms.Label lblCodigoEE;
        private System.Windows.Forms.GroupBox mrcNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramiteN;
        private System.Windows.Forms.TextBox txtNombreN;
        private System.Windows.Forms.TextBox txtCodigoN;
        private System.Windows.Forms.Label lblTramiteN;
        private System.Windows.Forms.Label lblNombreN;
        private System.Windows.Forms.Label lblCodigoN;
        private System.Windows.Forms.TreeView PTArbol;
    }
}