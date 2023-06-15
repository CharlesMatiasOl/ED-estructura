namespace ED.Estructura
{
    partial class frmRepasoBase
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
            this.txtOpBaseDato = new System.Windows.Forms.Label();
            this.cbConsulta = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblRepaso = new System.Windows.Forms.Label();
            this.dgRepasoBase = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepasoBase)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOpBaseDato
            // 
            this.txtOpBaseDato.AutoSize = true;
            this.txtOpBaseDato.Location = new System.Drawing.Point(12, 22);
            this.txtOpBaseDato.Name = "txtOpBaseDato";
            this.txtOpBaseDato.Size = new System.Drawing.Size(161, 13);
            this.txtOpBaseDato.TabIndex = 0;
            this.txtOpBaseDato.Text = "Operaciones con Base de Datos";
            // 
            // cbConsulta
            // 
            this.cbConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConsulta.FormattingEnabled = true;
            this.cbConsulta.Items.AddRange(new object[] {
            "Diferencia",
            "Interseccion",
            "Juntar",
            "Proyeccion simple",
            "Proyeccion multiatributo",
            "Seleccion multiatributo con operador AND",
            "Seleccion multiatributo con operador OR",
            "Seleccion multiatributo por convolucion",
            "Seleccion simple",
            "Union"});
            this.cbConsulta.Location = new System.Drawing.Point(179, 17);
            this.cbConsulta.Name = "cbConsulta";
            this.cbConsulta.Size = new System.Drawing.Size(376, 24);
            this.cbConsulta.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(571, 17);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(92, 24);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblRepaso
            // 
            this.lblRepaso.BackColor = System.Drawing.Color.White;
            this.lblRepaso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRepaso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRepaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepaso.Location = new System.Drawing.Point(15, 56);
            this.lblRepaso.Name = "lblRepaso";
            this.lblRepaso.Size = new System.Drawing.Size(648, 103);
            this.lblRepaso.TabIndex = 5;
            // 
            // dgRepasoBase
            // 
            this.dgRepasoBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRepasoBase.Location = new System.Drawing.Point(12, 184);
            this.dgRepasoBase.Name = "dgRepasoBase";
            this.dgRepasoBase.Size = new System.Drawing.Size(648, 271);
            this.dgRepasoBase.TabIndex = 6;
            // 
            // frmRepasoBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 487);
            this.Controls.Add(this.dgRepasoBase);
            this.Controls.Add(this.lblRepaso);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cbConsulta);
            this.Controls.Add(this.txtOpBaseDato);
            this.Name = "frmRepasoBase";
            this.Text = "frmRepasoBase";
            this.Load += new System.EventHandler(this.frmRepasoBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRepasoBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtOpBaseDato;
        private System.Windows.Forms.ComboBox cbConsulta;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblRepaso;
        private System.Windows.Forms.DataGridView dgRepasoBase;
    }
}