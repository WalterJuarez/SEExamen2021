namespace SEExamen2021
{
    partial class frMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btIngresar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btSalir = new System.Windows.Forms.Button();
            this.btDatosG = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btBuscarCod = new System.Windows.Forms.Button();
            this.btbuscarnombre = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btIngresar
            // 
            this.btIngresar.Location = new System.Drawing.Point(97, 63);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(183, 36);
            this.btIngresar.TabIndex = 0;
            this.btIngresar.Text = "Ingresar Cliente";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(97, 401);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(183, 36);
            this.btSalir.TabIndex = 1;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btDatosG
            // 
            this.btDatosG.Location = new System.Drawing.Point(97, 343);
            this.btDatosG.Name = "btDatosG";
            this.btDatosG.Size = new System.Drawing.Size(183, 36);
            this.btDatosG.TabIndex = 2;
            this.btDatosG.Text = "Datos Generales";
            this.btDatosG.UseVisualStyleBackColor = true;
            this.btDatosG.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(97, 288);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(183, 36);
            this.btEliminar.TabIndex = 3;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btBuscarCod
            // 
            this.btBuscarCod.Location = new System.Drawing.Point(97, 119);
            this.btBuscarCod.Name = "btBuscarCod";
            this.btBuscarCod.Size = new System.Drawing.Size(183, 36);
            this.btBuscarCod.TabIndex = 4;
            this.btBuscarCod.Text = "Buscar por Codigo";
            this.btBuscarCod.UseVisualStyleBackColor = true;
            this.btBuscarCod.Click += new System.EventHandler(this.btBuscarCod_Click);
            // 
            // btbuscarnombre
            // 
            this.btbuscarnombre.Location = new System.Drawing.Point(97, 173);
            this.btbuscarnombre.Name = "btbuscarnombre";
            this.btbuscarnombre.Size = new System.Drawing.Size(183, 36);
            this.btbuscarnombre.TabIndex = 5;
            this.btbuscarnombre.Text = "Buscar por nombre";
            this.btbuscarnombre.UseVisualStyleBackColor = true;
            this.btbuscarnombre.Click += new System.EventHandler(this.btbuscarnombre_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(97, 232);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(183, 36);
            this.btModificar.TabIndex = 6;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // frMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 493);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btbuscarnombre);
            this.Controls.Add(this.btBuscarCod);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btDatosG);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btIngresar);
            this.Name = "frMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btDatosG;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btBuscarCod;
        private System.Windows.Forms.Button btbuscarnombre;
        private System.Windows.Forms.Button btModificar;
    }
}

