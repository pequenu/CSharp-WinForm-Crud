namespace CRUD
{
    partial class UpdateForm
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
            txtId = new TextBox();
            btnVerificar = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnCancelar = new Button();
            btnAtualizar = new Button();
            groupBox1 = new GroupBox();
            txtNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtDesc = new TextBox();
            txtValor = new TextBox();
            qntEstoque = new NumericUpDown();
            label2 = new Label();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)qntEstoque).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 17);
            label1.Name = "label1";
            label1.Size = new Size(93, 17);
            label1.TabIndex = 16;
            label1.Text = "Id do Produto:";
            // 
            // txtId
            // 
            txtId.Location = new Point(18, 37);
            txtId.Name = "txtId";
            txtId.Size = new Size(207, 25);
            txtId.TabIndex = 15;
            txtId.TextChanged += txtId_TextChanged;
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
            btnVerificar.TabIndex = 14;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnCancelar, 1, 0);
            tableLayoutPanel2.Controls.Add(btnAtualizar, 0, 0);
            tableLayoutPanel2.Location = new Point(18, 416);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(313, 37);
            tableLayoutPanel2.TabIndex = 17;
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
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAtualizar.BackColor = Color.FromArgb(41, 166, 68);
            btnAtualizar.Enabled = false;
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(3, 3);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(150, 31);
            btnAtualizar.TabIndex = 8;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDesc);
            groupBox1.Controls.Add(txtValor);
            groupBox1.Controls.Add(qntEstoque);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(18, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 333);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Enabled = false;
            txtNome.Location = new Point(6, 41);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(301, 25);
            txtNome.TabIndex = 20;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(6, 21);
            label4.Name = "label4";
            label4.Size = new Size(118, 17);
            label4.TabIndex = 19;
            label4.Text = "Nome do Produto:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(6, 214);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 23;
            label3.Text = "Valor:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(6, 282);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 25;
            label5.Text = "Estoque:";
            // 
            // txtDesc
            // 
            txtDesc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDesc.Enabled = false;
            txtDesc.Location = new Point(6, 107);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(301, 87);
            txtDesc.TabIndex = 22;
            // 
            // txtValor
            // 
            txtValor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtValor.Enabled = false;
            txtValor.Location = new Point(6, 234);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(301, 25);
            txtValor.TabIndex = 24;
            txtValor.KeyPress += txtValor_KeyPress;
            // 
            // qntEstoque
            // 
            qntEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            qntEstoque.Enabled = false;
            qntEstoque.Location = new Point(6, 302);
            qntEstoque.Name = "qntEstoque";
            qntEstoque.Size = new Size(301, 25);
            qntEstoque.TabIndex = 26;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(6, 87);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 21;
            label2.Text = "Descrição:";
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 473);
            Controls.Add(groupBox1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(btnVerificar);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateForm";
            Padding = new Padding(15, 17, 15, 17);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar Registro";
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)qntEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Button btnVerificar;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnCancelar;
        private Button btnAtualizar;
        private GroupBox groupBox1;
        private TextBox txtNome;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox txtDesc;
        private TextBox txtValor;
        private NumericUpDown qntEstoque;
        private Label label2;
    }
}