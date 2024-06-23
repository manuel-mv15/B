namespace Barberia
{
    partial class InicioDeSecion
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
            txt_Usuario = new TextBox();
            txt_Clave = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_Ingresar = new Button();
            SuspendLayout();
            // 
            // txt_Usuario
            // 
            txt_Usuario.Location = new Point(295, 106);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(250, 47);
            txt_Usuario.TabIndex = 0;
            // 
            // txt_Clave
            // 
            txt_Clave.Location = new Point(295, 201);
            txt_Clave.Name = "txt_Clave";
            txt_Clave.Size = new Size(250, 47);
            txt_Clave.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 106);
            label1.Name = "label1";
            label1.Size = new Size(119, 41);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 201);
            label2.Name = "label2";
            label2.Size = new Size(89, 41);
            label2.TabIndex = 3;
            label2.Text = "Clave";
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.Location = new Point(244, 361);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(188, 58);
            btn_Ingresar.TabIndex = 4;
            btn_Ingresar.Text = "Ingresar";
            btn_Ingresar.UseVisualStyleBackColor = true;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 615);
            Controls.Add(btn_Ingresar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Clave);
            Controls.Add(txt_Usuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Usuario;
        private TextBox txt_Clave;
        private Label label1;
        private Label label2;
        private Button btn_Ingresar;
    }
}
