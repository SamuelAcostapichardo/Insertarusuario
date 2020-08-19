namespace Tareas
{
    partial class Form1
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
            this.Txtidusuario = new System.Windows.Forms.TextBox();
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.Txtapellido = new System.Windows.Forms.TextBox();
            this.Txtcorreo = new System.Windows.Forms.TextBox();
            this.Txtcontrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtconfirmar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btnregistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txtidusuario
            // 
            this.Txtidusuario.Location = new System.Drawing.Point(104, 57);
            this.Txtidusuario.Name = "Txtidusuario";
            this.Txtidusuario.Size = new System.Drawing.Size(47, 20);
            this.Txtidusuario.TabIndex = 0;
            this.Txtidusuario.Visible = false;
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(104, 127);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(100, 20);
            this.Txtnombre.TabIndex = 1;
            // 
            // Txtapellido
            // 
            this.Txtapellido.Location = new System.Drawing.Point(104, 183);
            this.Txtapellido.Name = "Txtapellido";
            this.Txtapellido.Size = new System.Drawing.Size(100, 20);
            this.Txtapellido.TabIndex = 2;
            // 
            // Txtcorreo
            // 
            this.Txtcorreo.Location = new System.Drawing.Point(104, 228);
            this.Txtcorreo.Name = "Txtcorreo";
            this.Txtcorreo.Size = new System.Drawing.Size(100, 20);
            this.Txtcorreo.TabIndex = 3;
            // 
            // Txtcontrasena
            // 
            this.Txtcontrasena.Location = new System.Drawing.Point(104, 279);
            this.Txtcontrasena.Name = "Txtcontrasena";
            this.Txtcontrasena.Size = new System.Drawing.Size(100, 20);
            this.Txtcontrasena.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña";
            // 
            // Txtconfirmar
            // 
            this.Txtconfirmar.Location = new System.Drawing.Point(104, 326);
            this.Txtconfirmar.Name = "Txtconfirmar";
            this.Txtconfirmar.Size = new System.Drawing.Size(100, 20);
            this.Txtconfirmar.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirmar Contraseña";
            // 
            // Btnregistrar
            // 
            this.Btnregistrar.Location = new System.Drawing.Point(362, 323);
            this.Btnregistrar.Name = "Btnregistrar";
            this.Btnregistrar.Size = new System.Drawing.Size(269, 85);
            this.Btnregistrar.TabIndex = 11;
            this.Btnregistrar.Text = "Registrar";
            this.Btnregistrar.UseVisualStyleBackColor = true;
            this.Btnregistrar.Click += new System.EventHandler(this.Btnregistrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnregistrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txtconfirmar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtcontrasena);
            this.Controls.Add(this.Txtcorreo);
            this.Controls.Add(this.Txtapellido);
            this.Controls.Add(this.Txtnombre);
            this.Controls.Add(this.Txtidusuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtidusuario;
        private System.Windows.Forms.TextBox Txtnombre;
        private System.Windows.Forms.TextBox Txtapellido;
        private System.Windows.Forms.TextBox Txtcorreo;
        private System.Windows.Forms.TextBox Txtcontrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtconfirmar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btnregistrar;
    }
}

