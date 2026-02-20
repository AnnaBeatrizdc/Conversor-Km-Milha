using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_KM_Milhas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BTN_calcular_Click(object sender, EventArgs e)
        {
            if (RB_kmpmilha.Checked)
            {
                ConverteKM CKM = new ConverteKM();

                CKM.setvalorMi(TB_valor2.Text);
                ConverterKMBLL.validaDados(CKM);
                if (Erro.getErro())
                {
                    MessageBox.Show(Erro.getMens());
                }
                else
                {
                    TB_valorconvertido2.Text = CKM.getConverteKM();
                    TB_valor2.Enabled = false;
                }
            }
            else if (RB_milhapkm.Checked)
            {
                ConverteMilha CMilha = new ConverteMilha();

                CMilha.setvalorKm(TB_valor2.Text);
                ConverterMilhaBLL.validaDados(CMilha);
                if (Erro.getErro())
                {
                    MessageBox.Show(Erro.getMens());
                }
                else
                {
                    TB_valorconvertido2.Text = CMilha.getConverteMilha();
                    TB_valor2.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma opção de converção...");
            }
        }

        private void BTN_Limpar2_Click(object sender, EventArgs e)
        {
            TB_valor2.Clear();
            TB_valorconvertido2.Clear();
            TB_valor2.Enabled = true;
            TB_valor2.Focus();
        }

        private void BTN_Limpar_Click(object sender, EventArgs e)
        {
            TB_valor.Clear();
            TB_valorconvertido.Clear();
            TB_valor.Enabled = true;
            TB_valor.Focus();
        }

        private void BTN_CalcularComboBox_Click(object sender, EventArgs e)
        {
            if (CB_Opcao.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma opção de converção...");
                return;
            }

            switch (CB_Opcao.SelectedItem.ToString())
            {
                case "Km para milha":
                    ConverteKM CKM = new ConverteKM();

                    CKM.setvalorMi(TB_valor.Text);
                    ConverterKMBLL.validaDados(CKM);
                    if (Erro.getErro())
                    {
                        MessageBox.Show(Erro.getMens());
                    }
                    else
                    {
                        TB_valorconvertido.Text = CKM.getConverteKM();
                        TB_valor.Enabled = false;
                    }
                    break;

                case "Milha para Km":
                    ConverteMilha CMilha = new ConverteMilha();

                    CMilha.setvalorKm(TB_valor.Text);
                    ConverterMilhaBLL.validaDados(CMilha);
                    if (Erro.getErro())
                    {
                        MessageBox.Show(Erro.getMens());
                    }
                    else
                    {
                        TB_valorconvertido.Text = CMilha.getConverteMilha();
                        TB_valor.Enabled = false;
                    }
                    break;
            }
        }
    }
}
