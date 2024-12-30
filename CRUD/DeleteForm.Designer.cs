namespace CRUD
{
    partial class DeleteForm
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
            btnDeletar = new Button();
            btnVerificar = new Button();
            txtId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.FromArgb(231, 76, 60);
            btnDeletar.FlatAppearance.BorderSize = 0;
            btnDeletar.FlatStyle = FlatStyle.Flat;
            btnDeletar.ForeColor = Color.White;
            btnDeletar.Location = new Point(18, 76);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(313, 31);
            btnDeletar.TabIndex = 11;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.FromArgb(41, 166, 68);
            btnVerificar.FlatAppearance.BorderSize = 0;
            btnVerificar.FlatStyle = FlatStyle.Flat;
            btnVerificar.ForeColor = Color.White;
            btnVerificar.Location = new Point(231, 37);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(100, 25);
            btnVerificar.TabIndex = 10;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(18, 37);
            txtId.Name = "txtId";
            txtId.Size = new Size(207, 25);
            txtId.TabIndex = 12;
            txtId.TextChanged += txtId_TextChanged;
            txtId.KeyPress += txtId_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 17);
            label1.Name = "label1";
            label1.Size = new Size(93, 17);
            label1.TabIndex = 13;
            label1.Text = "Id do Produto:";
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 127);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(btnDeletar);
            Controls.Add(btnVerificar);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteForm";
            Padding = new Padding(15, 17, 15, 17);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deletar Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeletar;
        private Button btnVerificar;
        private TextBox txtId;
        private Label label1;
    }
}