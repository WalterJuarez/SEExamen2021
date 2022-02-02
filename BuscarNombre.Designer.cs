namespace SEExamen2021
{
    partial class BuscarNombre
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btbuscarnombre = new System.Windows.Forms.Button();
            this.dgbusqueda = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgbusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ingrese un nombre y un apellido para poder realizar la busqueda";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(169, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(276, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // btbuscarnombre
            // 
            this.btbuscarnombre.Location = new System.Drawing.Point(511, 59);
            this.btbuscarnombre.Name = "btbuscarnombre";
            this.btbuscarnombre.Size = new System.Drawing.Size(142, 40);
            this.btbuscarnombre.TabIndex = 3;
            this.btbuscarnombre.Text = "Buscar por nombre";
            this.btbuscarnombre.UseVisualStyleBackColor = true;
            this.btbuscarnombre.Click += new System.EventHandler(this.btbuscarnombre_Click);
            // 
            // dgbusqueda
            // 
            this.dgbusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbusqueda.Location = new System.Drawing.Point(87, 173);
            this.dgbusqueda.Name = "dgbusqueda";
            this.dgbusqueda.RowHeadersWidth = 51;
            this.dgbusqueda.RowTemplate.Height = 24;
            this.dgbusqueda.Size = new System.Drawing.Size(383, 150);
            this.dgbusqueda.TabIndex = 4;
            // 
            // BuscarNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgbusqueda);
            this.Controls.Add(this.btbuscarnombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuscarNombre";
            this.Text = "Buscar por nombre Nombre";
            ((System.ComponentModel.ISupportInitialize)(this.dgbusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btbuscarnombre;
        private System.Windows.Forms.DataGridView dgbusqueda;
    }
}