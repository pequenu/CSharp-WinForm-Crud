namespace CRUD
{
    partial class CreateForm
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
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtDesc = new TextBox();
            label3 = new Label();
            txtValor = new TextBox();
            label4 = new Label();
            qntEstoque = new NumericUpDown();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)qntEstoque).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(118, 17);
            label1.TabIndex = 0;
            label1.Text = "Nome do Produto:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(18, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(313, 25);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(18, 81);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 2;
            label2.Text = "Descrição:";
            // 
            // txtDesc
            // 
            txtDesc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDesc.Location = new Point(18, 101);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(313, 90);
            txtDesc.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(18, 208);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 4;
            label3.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtValor.Location = new Point(18, 228);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(313, 25);
            txtValor.TabIndex = 5;
            txtValor.KeyPress += txtValor_KeyPress;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(18, 274);
            label4.Name = "label4";
            label4.Size = new Size(58, 17);
            label4.TabIndex = 6;
            label4.Text = "Estoque:";
            // 
            // qntEstoque
            // 
            qntEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            qntEstoque.Location = new Point(18, 294);
            qntEstoque.Name = "qntEstoque";
            qntEstoque.Size = new Size(313, 25);
            qntEstoque.TabIndex = 7;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(231, 76, 60);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(159, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(151, 31);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegistrar.BackColor = Color.FromArgb(41, 166, 68);
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(3, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(150, 31);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnCancelar, 1, 0);
            tableLayoutPanel2.Controls.Add(btnRegistrar, 0, 0);
            tableLayoutPanel2.Location = new Point(18, 336);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(313, 37);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 391);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(txtDesc);
            Controls.Add(qntEstoque);
            Controls.Add(label2);
            Controls.Add(txtValor);
            Controls.Add(label1);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateForm";
            Padding = new Padding(15);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Registro";
            ((System.ComponentModel.ISupportInitialize)qntEstoque).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtDesc;
        private Label label3;
        private TextBox txtValor;
        private Label label4;
        private NumericUpDown qntEstoque;
        private Button btnCancelar;
        private Button btnRegistrar;
        private TableLayoutPanel tableLayoutPanel2;
    }
}