using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1___DateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ex: 30/07/2000 e 31/07/2023
            DateTime dataNasc = dateTimePicker1.Value;
            DateTime dataAtual = DateTime.Today;

            //TimeSpan a = (dataNasc - dataAtual);
             int idade = dataAtual.Year - dataNasc.Year;// 2023 - 2006 //esta dando 0
            int comp = DateTime.Compare(dataAtual, dataNasc);
          
            //primeira é anterior a segunda, correto -1
            ///lembrete: tentar usar este compare no if
            /// 

            if (comp < 0) 
            {
                idade--;
            }

           /* if (comp == 0) //ja fez aniversario
            {
                idade++;
            }
            else if(comp == 1)
            {
                idade--;
            }*/
            label1.Text = idade.ToString();


            /*if (dataNasc.Month > dataAtual.Month || dataNasc.Day > dataAtual.Day) //verificando se passou o mes e o dia
            {
                idade--;// se nao passou, vou tirar -1
            }
            else if (dataNasc.Month <= dataAtual.Month || dataNasc.Day <= dataAtual.Day) 
            {
                idade++;//se ja passou +1 //duvidas
            }
            label1.Text = idade.ToString();//esta dando 1, então parece que o if esta correto
           // MessageBox.Show(idade.ToString());*/

        }
    }
}
