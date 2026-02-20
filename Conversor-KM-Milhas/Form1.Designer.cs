namespace Conversor_KM_Milhas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CB_Opcao = new System.Windows.Forms.ComboBox();
            this.BTN_Limpar = new System.Windows.Forms.Button();
            this.BTN_CalcularComboBox = new System.Windows.Forms.Button();
            this.TB_valorconvertido = new System.Windows.Forms.TextBox();
            this.TB_valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RB_milhapkm = new System.Windows.Forms.RadioButton();
            this.RB_kmpmilha = new System.Windows.Forms.RadioButton();
            this.BTN_Limpar2 = new System.Windows.Forms.Button();
            this.BTN_calcularRadioButton = new System.Windows.Forms.Button();
            this.TB_valorconvertido2 = new System.Windows.Forms.TextBox();
            this.TB_valor2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-6, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(604, 278);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightBlue;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.CB_Opcao);
            this.tabPage1.Controls.Add(this.BTN_Limpar);
            this.tabPage1.Controls.Add(this.BTN_CalcularComboBox);
            this.tabPage1.Controls.Add(this.TB_valorconvertido);
            this.tabPage1.Controls.Add(this.TB_valor);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(596, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ComboBox";
            // 
            // CB_Opcao
            // 
            this.CB_Opcao.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Opcao.FormattingEnabled = true;
            this.CB_Opcao.Items.AddRange(new object[] {
            "Km para milha",
            "Milha para Km"});
            this.CB_Opcao.Location = new System.Drawing.Point(35, 75);
            this.CB_Opcao.Name = "CB_Opcao";
            this.CB_Opcao.Size = new System.Drawing.Size(151, 28);
            this.CB_Opcao.TabIndex = 53;
            this.CB_Opcao.Text = "Escolha uma opção";
            // 
            // BTN_Limpar
            // 
            this.BTN_Limpar.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_Limpar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Limpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Limpar.Location = new System.Drawing.Point(210, 109);
            this.BTN_Limpar.Name = "BTN_Limpar";
            this.BTN_Limpar.Size = new System.Drawing.Size(104, 37);
            this.BTN_Limpar.TabIndex = 52;
            this.BTN_Limpar.Text = "Limpar";
            this.BTN_Limpar.UseVisualStyleBackColor = false;
            this.BTN_Limpar.Click += new System.EventHandler(this.BTN_Limpar_Click);
            // 
            // BTN_CalcularComboBox
            // 
            this.BTN_CalcularComboBox.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_CalcularComboBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CalcularComboBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_CalcularComboBox.Location = new System.Drawing.Point(210, 65);
            this.BTN_CalcularComboBox.Name = "BTN_CalcularComboBox";
            this.BTN_CalcularComboBox.Size = new System.Drawing.Size(104, 38);
            this.BTN_CalcularComboBox.TabIndex = 51;
            this.BTN_CalcularComboBox.Text = "Calcular";
            this.BTN_CalcularComboBox.UseVisualStyleBackColor = false;
            this.BTN_CalcularComboBox.Click += new System.EventHandler(this.BTN_CalcularComboBox_Click);
            // 
            // TB_valorconvertido
            // 
            this.TB_valorconvertido.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_valorconvertido.Location = new System.Drawing.Point(205, 162);
            this.TB_valorconvertido.Name = "TB_valorconvertido";
            this.TB_valorconvertido.Size = new System.Drawing.Size(113, 30);
            this.TB_valorconvertido.TabIndex = 50;
            // 
            // TB_valor
            // 
            this.TB_valor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_valor.Location = new System.Drawing.Point(205, 26);
            this.TB_valor.Name = "TB_valor";
            this.TB_valor.Size = new System.Drawing.Size(113, 30);
            this.TB_valor.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "Valor convertido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 26);
            this.label3.TabIndex = 47;
            this.label3.Text = "Digite um valor:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.RB_milhapkm);
            this.tabPage2.Controls.Add(this.RB_kmpmilha);
            this.tabPage2.Controls.Add(this.BTN_Limpar2);
            this.tabPage2.Controls.Add(this.BTN_calcularRadioButton);
            this.tabPage2.Controls.Add(this.TB_valorconvertido2);
            this.tabPage2.Controls.Add(this.TB_valor2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(596, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RadioButton";
            // 
            // RB_milhapkm
            // 
            this.RB_milhapkm.AutoSize = true;
            this.RB_milhapkm.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_milhapkm.Location = new System.Drawing.Point(55, 108);
            this.RB_milhapkm.Name = "RB_milhapkm";
            this.RB_milhapkm.Size = new System.Drawing.Size(123, 24);
            this.RB_milhapkm.TabIndex = 54;
            this.RB_milhapkm.TabStop = true;
            this.RB_milhapkm.Text = "Milha para Km";
            this.RB_milhapkm.UseVisualStyleBackColor = true;
            // 
            // RB_kmpmilha
            // 
            this.RB_kmpmilha.AutoSize = true;
            this.RB_kmpmilha.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_kmpmilha.Location = new System.Drawing.Point(55, 78);
            this.RB_kmpmilha.Name = "RB_kmpmilha";
            this.RB_kmpmilha.Size = new System.Drawing.Size(121, 24);
            this.RB_kmpmilha.TabIndex = 53;
            this.RB_kmpmilha.TabStop = true;
            this.RB_kmpmilha.Text = "Km para milha";
            this.RB_kmpmilha.UseVisualStyleBackColor = true;
            // 
            // BTN_Limpar2
            // 
            this.BTN_Limpar2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BTN_Limpar2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Limpar2.Location = new System.Drawing.Point(210, 108);
            this.BTN_Limpar2.Name = "BTN_Limpar2";
            this.BTN_Limpar2.Size = new System.Drawing.Size(104, 37);
            this.BTN_Limpar2.TabIndex = 52;
            this.BTN_Limpar2.Text = "Limpar";
            this.BTN_Limpar2.UseVisualStyleBackColor = false;
            this.BTN_Limpar2.Click += new System.EventHandler(this.BTN_Limpar2_Click);
            // 
            // BTN_calcularRadioButton
            // 
            this.BTN_calcularRadioButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BTN_calcularRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_calcularRadioButton.Location = new System.Drawing.Point(210, 64);
            this.BTN_calcularRadioButton.Name = "BTN_calcularRadioButton";
            this.BTN_calcularRadioButton.Size = new System.Drawing.Size(104, 38);
            this.BTN_calcularRadioButton.TabIndex = 51;
            this.BTN_calcularRadioButton.Text = "Calcular";
            this.BTN_calcularRadioButton.UseVisualStyleBackColor = false;
            this.BTN_calcularRadioButton.Click += new System.EventHandler(this.BTN_calcular_Click);
            // 
            // TB_valorconvertido2
            // 
            this.TB_valorconvertido2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_valorconvertido2.Location = new System.Drawing.Point(205, 161);
            this.TB_valorconvertido2.Name = "TB_valorconvertido2";
            this.TB_valorconvertido2.Size = new System.Drawing.Size(113, 30);
            this.TB_valorconvertido2.TabIndex = 50;
            // 
            // TB_valor2
            // 
            this.TB_valor2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_valor2.Location = new System.Drawing.Point(205, 25);
            this.TB_valor2.Name = "TB_valor2";
            this.TB_valor2.Size = new System.Drawing.Size(113, 30);
            this.TB_valor2.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 48;
            this.label1.Text = "Valor convertido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 26);
            this.label4.TabIndex = 47;
            this.label4.Text = "Digite um valor:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Conversor_KM_Milhas.Properties.Resources.img_km_milha;
            this.pictureBox1.Location = new System.Drawing.Point(332, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Conversor_KM_Milhas.Properties.Resources.img_km_milha;
            this.pictureBox2.Location = new System.Drawing.Point(329, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(591, 273);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox CB_Opcao;
        private System.Windows.Forms.Button BTN_Limpar;
        private System.Windows.Forms.Button BTN_CalcularComboBox;
        private System.Windows.Forms.TextBox TB_valorconvertido;
        private System.Windows.Forms.TextBox TB_valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton RB_milhapkm;
        private System.Windows.Forms.RadioButton RB_kmpmilha;
        private System.Windows.Forms.Button BTN_Limpar2;
        private System.Windows.Forms.Button BTN_calcularRadioButton;
        private System.Windows.Forms.TextBox TB_valorconvertido2;
        private System.Windows.Forms.TextBox TB_valor2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

