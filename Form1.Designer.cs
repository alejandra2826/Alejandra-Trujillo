namespace holamundo
{
    partial class Form1
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
            btnValidar = new Button();
            txtContrasenauno = new TextBox();
            txtContrasenaDos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(145, 120);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(125, 32);
            btnValidar.TabIndex = 0;
            btnValidar.Text = "Validar Contraseña";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // txtContrasenauno
            // 
            txtContrasenauno.Location = new Point(145, 35);
            txtContrasenauno.Name = "txtContrasenauno";
            txtContrasenauno.Size = new Size(186, 23);
            txtContrasenauno.TabIndex = 1;
            // 
            // txtContrasenaDos
            // 
            txtContrasenaDos.Location = new Point(145, 72);
            txtContrasenaDos.Name = "txtContrasenaDos";
            txtContrasenaDos.Size = new Size(186, 23);
            txtContrasenaDos.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingresa una Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 4;
            label2.Text = "Repetir Contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(438, 189);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContrasenaDos);
            Controls.Add(txtContrasenauno);
            Controls.Add(btnValidar);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidar;
        private TextBox txtContrasenauno;
        private TextBox txtContrasenaDos;
        private Label label1;
        private Label label2;
    }
}