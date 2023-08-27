namespace EntregablePancho
{
    partial class Form1
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
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMostrarViajes = new System.Windows.Forms.Button();
            this.btnBloquearTarjeta = new System.Windows.Forms.Button();
            this.btnNumerosTarjeta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(13, 24);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(79, 43);
            this.btnAgregarCliente.TabIndex = 0;
            this.btnAgregarCliente.Text = "Registrar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar Viajes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMostrarViajes
            // 
            this.btnMostrarViajes.Location = new System.Drawing.Point(182, 24);
            this.btnMostrarViajes.Name = "btnMostrarViajes";
            this.btnMostrarViajes.Size = new System.Drawing.Size(79, 43);
            this.btnMostrarViajes.TabIndex = 2;
            this.btnMostrarViajes.Text = "Mostrar últimos viajes";
            this.btnMostrarViajes.UseVisualStyleBackColor = true;
            this.btnMostrarViajes.Click += new System.EventHandler(this.btnMostrarViajes_Click);
            // 
            // btnBloquearTarjeta
            // 
            this.btnBloquearTarjeta.Location = new System.Drawing.Point(267, 24);
            this.btnBloquearTarjeta.Name = "btnBloquearTarjeta";
            this.btnBloquearTarjeta.Size = new System.Drawing.Size(79, 43);
            this.btnBloquearTarjeta.TabIndex = 3;
            this.btnBloquearTarjeta.Text = "Bloquear Tarjeta";
            this.btnBloquearTarjeta.UseVisualStyleBackColor = true;
            this.btnBloquearTarjeta.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNumerosTarjeta
            // 
            this.btnNumerosTarjeta.Location = new System.Drawing.Point(13, 199);
            this.btnNumerosTarjeta.Name = "btnNumerosTarjeta";
            this.btnNumerosTarjeta.Size = new System.Drawing.Size(75, 23);
            this.btnNumerosTarjeta.TabIndex = 4;
            this.btnNumerosTarjeta.Text = "Ver números";
            this.btnNumerosTarjeta.UseVisualStyleBackColor = true;
            this.btnNumerosTarjeta.Click += new System.EventHandler(this.btnNumerosTarjeta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 256);
            this.Controls.Add(this.btnNumerosTarjeta);
            this.Controls.Add(this.btnBloquearTarjeta);
            this.Controls.Add(this.btnMostrarViajes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregarCliente);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMostrarViajes;
        private System.Windows.Forms.Button btnBloquearTarjeta;
        private System.Windows.Forms.Button btnNumerosTarjeta;
    }
}

