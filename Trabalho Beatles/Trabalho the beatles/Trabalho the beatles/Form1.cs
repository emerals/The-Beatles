using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_the_beatles
{
    public partial class Beatles : Form
    {
        public Beatles()
        {
            InitializeComponent();
            Inicializacao();
        }

        /*-----VARIÁVEIS GLOBAIS-----*/
        int campos_repetidos = 0;
        int TempoRingo = 0;
        int TempoPaul = 0;
        int TempoGeorge = 0;
        int TempoJonh = 0;

        /*-----METÓDOS-----*/
        public void limpar()
        {
            tb_tempo_george.Text = "";
            tb_tempo_jonh.Text = "";
            tb_tempo_paul.Text = "";
            tb_tempo_ringo.Text = "";
            tb_tempo_jonh.Focus();//Primeiro campo do formulário
        }
  
        public void Inicializacao()//Limitar os números de caracteres do form para dois digitos
        {
            tb_tempo_jonh.MaxLength = 2;
            tb_tempo_george.MaxLength = 2;
            tb_tempo_paul.MaxLength = 2;
            tb_tempo_ringo.MaxLength = 2;

            tb_tempo_total.Text = "17";/*Tempo total pré definido*/
            tb_tempo_total.Enabled = true;/*Bloquear o tempo total para o usuário não digitar nada nele*/
        }

        public void TemposRepitidos()/*Método para caso algum tempo seja igual ao outro, assim daria conflito em quem seria o mais rápido*/
        {           
            TempoRingo = Convert.ToInt16(tb_tempo_ringo.Text);
            TempoPaul = Convert.ToInt16(tb_tempo_paul.Text);
            TempoGeorge = Convert.ToInt16(tb_tempo_george.Text);
            TempoJonh = Convert.ToInt16(tb_tempo_jonh.Text);

            if ((TempoRingo == TempoPaul) || (TempoRingo == TempoGeorge) || (TempoRingo == TempoJonh))//Inicio da verificação se tem campos com tempos iguais
            {
                campos_repetidos++;
            }
            if ((TempoPaul == TempoRingo) || (TempoPaul == TempoGeorge) || (TempoPaul == TempoJonh))
            {
                campos_repetidos++;
            }
            if ((TempoGeorge == TempoPaul) || (TempoGeorge == TempoRingo) || (TempoGeorge == TempoJonh))
            {
                campos_repetidos++;
            }
            if ((TempoJonh == TempoPaul) || (TempoJonh == TempoGeorge) || (TempoJonh == TempoRingo))//Fim da verificação de tempos iguais
            {
                campos_repetidos++;
            }

            int TempoTotal = Convert.ToInt16(tb_tempo_total.Text);//Tempo total de 17 minutos

            if (campos_repetidos > 0)/*Se tiver algum campo repetido*/
            {
                MessageBox.Show("PREENCHA TODOS OS CAMPOS COM VELOCIDADES DIFERENTES!");
                Application.Exit();
            }/*Onde irá dar erro acaso o usuário digite um campo igual*/
            
        }

        public void PassarPonteComMaisRapido()
        {
            TempoRingo = Convert.ToInt16(tb_tempo_ringo.Text);
            TempoPaul = Convert.ToInt16(tb_tempo_paul.Text);
            TempoGeorge = Convert.ToInt16(tb_tempo_george.Text);
            TempoJonh = Convert.ToInt16(tb_tempo_jonh.Text);

            int TempoTotal = Convert.ToInt16(tb_tempo_total.Text);//Tempo total de 17 minutos

            int[] HereComesTheSun = new int[] {TempoRingo, TempoPaul, TempoGeorge, TempoJonh};
            int[] YellowSubarine = HereComesTheSun;
            int total = 0;
            bool passou;

            string BeattleMaisRapido = "";
            string BeattleMaisRapido2 = "";
            string BeattleMaisRapido3 = "";
            string BeattleMaisRapido4 = "";

            Array.Sort(HereComesTheSun);/*Ordenar array de forma crescente*/

            for (int i = 0; i < 4; i++)//Somar o tempo total
            {
                if(i == 0) { total = HereComesTheSun[i] * 5; }/*Quem tá na posição 0 sempre será o mais rápido*/
                if(i == 1) { total += HereComesTheSun[i]; }
                if(i == 2) { total += HereComesTheSun[i]; }
                if(i == 3) { total += HereComesTheSun[i]; }
            }

            int tempoTotal = Convert.ToInt16(tb_tempo_total.Text);

                if (tempoTotal >= total)//Se o tempo de todos juntos for menor que o tempo total
                {
                    /*Calculo do tempo total para passagem*/

                    MessageBox.Show("Os beatles estão atrevessando a ponte Rickety. Irão demorar"+" "+tempoTotal+" minutos para completar a travessia");
                    passou = true;
                }

                else
                {
                    MessageBox.Show("ESTÃO MUITO DEVAGAR, NÃO CONSEGUIRÃO PASSAR A PONTE EM " +tempoTotal+" MINUTOS"+"..\n\n"
                    +"TENTE IR MAIS RÁPIDO DESTA VEZ!!!"                    
                    );
                    passou = false;
                    limpar();//Quando não conseguir passar eu limpo tudo
                  
                }
               
            if (passou == true)/*Se passaram, organiza como passarão*/
                {
                   if (TempoRingo == HereComesTheSun[0]){
                    BeattleMaisRapido = "RINGO";
                    BeattleMaisRapido2 = "GEORGE";
                    BeattleMaisRapido3 = "PAUL";
                    BeattleMaisRapido4 = "JOHN";
                    }

                    if (TempoGeorge == HereComesTheSun[0]){
                     BeattleMaisRapido = "GEORGE";
                     BeattleMaisRapido2 = "RINGO";
                     BeattleMaisRapido3 = "PAUL";
                     BeattleMaisRapido4 = "JOHN";
                    }
                    if (TempoJonh == HereComesTheSun[0]){
                     BeattleMaisRapido = "JOHN";
                    BeattleMaisRapido2 = "GEORGE";
                    BeattleMaisRapido3 = "PAUL";
                    BeattleMaisRapido4 = "RINGO";
                    }
                    if (TempoPaul == HereComesTheSun[0]){
                    BeattleMaisRapido = "PAUL";
                    BeattleMaisRapido2 = "GEORGE";
                    BeattleMaisRapido3 = "RINGO";
                    BeattleMaisRapido4 = "JOHN";
                    }
                    //Passando a ponte
                    MessageBox.Show("PASSA " + BeattleMaisRapido + " (Com a Lanterna) E " + BeattleMaisRapido2);///Sempre o primeiro mais rápido irá passar
                    MessageBox.Show("VOLTA " + BeattleMaisRapido + " (Com a Lanterna) ");
                    MessageBox.Show("PASSA " + BeattleMaisRapido + " (Com a Lanterna) E " + BeattleMaisRapido3);
                    MessageBox.Show("VOLTA " + BeattleMaisRapido + " (Com a Lanterna)");
                    MessageBox.Show("PASSA " + BeattleMaisRapido + " (Com a Lanterna) E " + BeattleMaisRapido4);
                    MessageBox.Show("TODOS OS BEATLES CONSIGUERAM CHEGAR NO SHOW A TEMPO!!!!");
                    limpar();
                    }                              
        }
        /*-----EVENTOS-----*/
        private void SomenteNumeros(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) ||
                e.KeyChar == (char)(Keys.Back))//Se for número e backspace
            {
                e.Handled = false;//Desligue o bloqueio   
                if (e.KeyChar == (char)(Keys.Back))
                { 
                    
                }
            }
            else
            {
                e.Handled = true;//Qualquer coisa diferente disso é bloqueado
            }
        }

        private void btn_Go_Click(object sender, EventArgs e)
        {
            try
            {
                TemposRepitidos(); /*Verificar se tem campo com valores iguais*/
                PassarPonteComMaisRapido();
            }
            catch (FormatException)
            {
                MessageBox.Show("Todos os campos deverão ser preenchidos, digite novamente os tempos");
                limpar();
               
            }
        }


    }
}
