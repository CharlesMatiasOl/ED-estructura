namespace ED.Estructura
{
    partial class frmBaseDato
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
            this.dgBase = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdDiferencia = new System.Windows.Forms.Button();
            this.cmdInterseccion = new System.Windows.Forms.Button();
            this.cmdUnion = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdSeleccionConvolucion = new System.Windows.Forms.Button();
            this.cmdSeleccionMulti = new System.Windows.Forms.Button();
            this.cmdSeleccionSimple = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdJuntar = new System.Windows.Forms.Button();
            this.cmdProyeccionMulti = new System.Windows.Forms.Button();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBase)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgBase
            // 
            this.dgBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBase.Location = new System.Drawing.Point(12, 12);
            this.dgBase.Name = "dgBase";
            this.dgBase.Size = new System.Drawing.Size(726, 300);
            this.dgBase.TabIndex = 1;
            this.dgBase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdDiferencia);
            this.groupBox2.Controls.Add(this.cmdInterseccion);
            this.groupBox2.Controls.Add(this.cmdUnion);
            this.groupBox2.Location = new System.Drawing.Point(510, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 153);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones Algebraicas";
            // 
            // cmdDiferencia
            // 
            this.cmdDiferencia.Location = new System.Drawing.Point(13, 109);
            this.cmdDiferencia.Name = "cmdDiferencia";
            this.cmdDiferencia.Size = new System.Drawing.Size(203, 23);
            this.cmdDiferencia.TabIndex = 2;
            this.cmdDiferencia.Text = "Diferencia";
            this.cmdDiferencia.UseVisualStyleBackColor = true;
            this.cmdDiferencia.Click += new System.EventHandler(this.cmdDiferencia_Click);
            // 
            // cmdInterseccion
            // 
            this.cmdInterseccion.Location = new System.Drawing.Point(13, 62);
            this.cmdInterseccion.Name = "cmdInterseccion";
            this.cmdInterseccion.Size = new System.Drawing.Size(203, 23);
            this.cmdInterseccion.TabIndex = 1;
            this.cmdInterseccion.Text = "Interseccion";
            this.cmdInterseccion.UseVisualStyleBackColor = true;
            this.cmdInterseccion.Click += new System.EventHandler(this.cmdInterseccion_Click);
            // 
            // cmdUnion
            // 
            this.cmdUnion.Location = new System.Drawing.Point(13, 19);
            this.cmdUnion.Name = "cmdUnion";
            this.cmdUnion.Size = new System.Drawing.Size(203, 23);
            this.cmdUnion.TabIndex = 0;
            this.cmdUnion.Text = "Union";
            this.cmdUnion.UseVisualStyleBackColor = true;
            this.cmdUnion.Click += new System.EventHandler(this.cmdUnion_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdSeleccionConvolucion);
            this.groupBox3.Controls.Add(this.cmdSeleccionMulti);
            this.groupBox3.Controls.Add(this.cmdSeleccionSimple);
            this.groupBox3.Location = new System.Drawing.Point(259, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 153);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opereaciones de Seleccion";
            // 
            // cmdSeleccionConvolucion
            // 
            this.cmdSeleccionConvolucion.Location = new System.Drawing.Point(13, 109);
            this.cmdSeleccionConvolucion.Name = "cmdSeleccionConvolucion";
            this.cmdSeleccionConvolucion.Size = new System.Drawing.Size(203, 23);
            this.cmdSeleccionConvolucion.TabIndex = 2;
            this.cmdSeleccionConvolucion.Text = "Seleccion por convolucion";
            this.cmdSeleccionConvolucion.UseVisualStyleBackColor = true;
            this.cmdSeleccionConvolucion.Click += new System.EventHandler(this.cmdSeleccionConvolucion_Click);
            // 
            // cmdSeleccionMulti
            // 
            this.cmdSeleccionMulti.Location = new System.Drawing.Point(13, 62);
            this.cmdSeleccionMulti.Name = "cmdSeleccionMulti";
            this.cmdSeleccionMulti.Size = new System.Drawing.Size(203, 23);
            this.cmdSeleccionMulti.TabIndex = 1;
            this.cmdSeleccionMulti.Text = "Seleccion Multiatributo";
            this.cmdSeleccionMulti.UseVisualStyleBackColor = true;
            this.cmdSeleccionMulti.Click += new System.EventHandler(this.cmdSeleccionMulti_Click);
            // 
            // cmdSeleccionSimple
            // 
            this.cmdSeleccionSimple.Location = new System.Drawing.Point(13, 19);
            this.cmdSeleccionSimple.Name = "cmdSeleccionSimple";
            this.cmdSeleccionSimple.Size = new System.Drawing.Size(203, 23);
            this.cmdSeleccionSimple.TabIndex = 0;
            this.cmdSeleccionSimple.Text = "Seleccion Simple";
            this.cmdSeleccionSimple.UseVisualStyleBackColor = true;
            this.cmdSeleccionSimple.Click += new System.EventHandler(this.cmdSeleccionSimple_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdJuntar);
            this.groupBox1.Controls.Add(this.cmdProyeccionMulti);
            this.groupBox1.Controls.Add(this.btnProyeccionSimple);
            this.groupBox1.Location = new System.Drawing.Point(12, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 153);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones de Proyeccion";
            // 
            // cmdJuntar
            // 
            this.cmdJuntar.Location = new System.Drawing.Point(13, 109);
            this.cmdJuntar.Name = "cmdJuntar";
            this.cmdJuntar.Size = new System.Drawing.Size(203, 23);
            this.cmdJuntar.TabIndex = 2;
            this.cmdJuntar.Text = "Juntar";
            this.cmdJuntar.UseVisualStyleBackColor = true;
            this.cmdJuntar.Click += new System.EventHandler(this.cmdJuntar_Click);
            // 
            // cmdProyeccionMulti
            // 
            this.cmdProyeccionMulti.Location = new System.Drawing.Point(13, 62);
            this.cmdProyeccionMulti.Name = "cmdProyeccionMulti";
            this.cmdProyeccionMulti.Size = new System.Drawing.Size(203, 23);
            this.cmdProyeccionMulti.TabIndex = 1;
            this.cmdProyeccionMulti.Text = "Proyeccion Multiatributo";
            this.cmdProyeccionMulti.UseVisualStyleBackColor = true;
            this.cmdProyeccionMulti.Click += new System.EventHandler(this.cmdProyeccionMulti_Click);
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.Location = new System.Drawing.Point(13, 19);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(203, 23);
            this.btnProyeccionSimple.TabIndex = 0;
            this.btnProyeccionSimple.Text = "Proyeccion Simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            this.btnProyeccionSimple.Click += new System.EventHandler(this.cmdProyeccionSimple_Click);
            // 
            // frmBaseDato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgBase);
            this.Name = "frmBaseDato";
            this.Text = "frmBaseDato";
            this.Load += new System.EventHandler(this.frmBaseDato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBase)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdDiferencia;
        private System.Windows.Forms.Button cmdInterseccion;
        private System.Windows.Forms.Button cmdUnion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdSeleccionConvolucion;
        private System.Windows.Forms.Button cmdSeleccionMulti;
        private System.Windows.Forms.Button cmdSeleccionSimple;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdJuntar;
        private System.Windows.Forms.Button cmdProyeccionMulti;
        private System.Windows.Forms.Button btnProyeccionSimple;
    }
}