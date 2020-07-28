using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAnimation.Classes;

namespace WindowsFormsAnimationEx
{
    public partial class Form1 : Form
    {
        // INDEPENDENTE
        WindowsFormsAnimation.Independents.WFAPanel WFAPanel1 = new WindowsFormsAnimation.Independents.WFAPanel();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // COMPONENTE
            panel1.AnimationStateResponse += Panel1_AnimationStateResponse;// CRIANDO O EVENTO AnimationStateResponse
            panel1.InAnimation += Panel1_InAnimation;// CRIANDO O EVENTO InAnimation

            // INDEPENDENTE
            WFAPanel1.AnimationStateResponse += WFAPanel1_AnimationStateResponse;// CRIANDO O EVENTO AnimationStateResponse
            WFAPanel1.InAnimation += WFAPanel1_InAnimation;// CRIANDO O EVENTO InAnimation
        }

        #region COMPONENTE
        private void btnShowRideComp_Click(object sender, EventArgs e)
        {
            if(panel1.AnimationAtualState == AnimationState.HIDE)// VERIFICA O STATUS ATUAL DO PAINEL
            {
                panel1.Show(// MÉTODO PARA EXIBIR O COMPONENTE
                    new WindowsFormsAnimation.Classes.Config()
                    { 
                        Delay = 1,// TEMPO DE ESPERA ATÉ A PRÓXIMA ALTERAÇÃO EM MILISEGUNDOS
                        Finish = 200,// WIDTH FINAL DO COMPONENTE
                        Value = 1// VALOR WIDTH A SER ACRECENTADO POR DELAY
                    }, Animation.SLIDE);// TIPO DE ANIMAÇÃO
            }
            else
            {
                panel1.Hide(// MÉTODO PARA EXIBIR O COMPONENTE
                    new WindowsFormsAnimation.Classes.Config()
                    {
                        Delay = 1,// TEMPO DE ESPERA ATÉ A PRÓXIMA ALTERAÇÃO EM MILISEGUNDOS
                        Finish = 0,// WIDTH FINAL DO COMPONENTE
                        Value = 1// VALOR WIDTH A SER DIMINUIDO POR DELAY
                    }, Animation.SLIDE);// TIPO DE ANIMAÇÃO
            }
        }

        private void Panel1_InAnimation(object sender, EventArgs e)
        {
            EventStateArgs ev = (EventStateArgs)e;// EventArgs É INFORMADO COMO EventStateArgs

            lblInAnimationCom.Text = "InAnimation - " + ev.AnimationState.ToString();
            lblInAnimationCom.ForeColor = Color.Green;
        }

        private void Panel1_AnimationStateResponse(object sender, EventArgs e)
        {
            EventStateArgs ev = (EventStateArgs)e;// EventArgs É INFORMADO COMO EventStateArgs

            lblInAnimationCom.Text = "InAnimation - " + ev.AnimationState.ToString();
            lblInAnimationCom.ForeColor = Color.Black;

            lblAnimationStateResponseComp.Text = "AnimationStateResponse - " + ev.AnimationState.ToString() + " - " + DateTime.Now.ToString("HH:mm:ss");
        }
        #endregion

        #region INDEPENDENTE
        private void btnShowRideImp_Click(object sender, EventArgs e)
        {
            if (WFAPanel1.AnimationAtualState == AnimationState.HIDE)// VERIFICA O STATUS ATUAL DA CLASSE
            {
                WFAPanel1.Show(// MÉTODO PARA EXIBIR O COMPONENTE
                    new WindowsFormsAnimation.Classes.Config()
                    {
                        Delay = 1,// TEMPO DE ESPERA ATÉ A PRÓXIMA ALTERAÇÃO EM MILISEGUNDOS
                        Finish = 200,// WIDTH FINAL DO COMPONENTE
                        Value = 1// VALOR WIDTH A SER ACRECENTADO POR DELAY
                    }, Animation.SLIDE,// TIPO DE ANIMAÇÃO
                    panel2);// PANEL PARA EXECUTAR A ANIMAÇÃO
            }
            else
            {
                WFAPanel1.Hide(// MÉTODO PARA EXIBIR O COMPONENTE
                    new WindowsFormsAnimation.Classes.Config()
                    {
                        Delay = 1,// TEMPO DE ESPERA ATÉ A PRÓXIMA ALTERAÇÃO EM MILISEGUNDOS
                        Finish = 0,// WIDTH FINAL DO COMPONENTE
                        Value = 1// VALOR WIDTH A SER DIMINUIDO POR DELAY
                    }, Animation.SLIDE,// TIPO DE ANIMAÇÃO
                    panel2);// PANEL PARA EXECUTAR A ANIMAÇÃO
            }
        }

        private void WFAPanel1_InAnimation(object sender, EventArgs e)
        {
            EventStateArgs ev = (EventStateArgs)e;// EventArgs É INFORMADO COMO EventStateArgs

            lblInAnimationImp.Text = "InAnimation - " + ev.AnimationState.ToString();
            lblInAnimationImp.ForeColor = Color.Green;
        }

        private void WFAPanel1_AnimationStateResponse(object sender, EventArgs e)
        {
            EventStateArgs ev = (EventStateArgs)e;// EventArgs É INFORMADO COMO EventStateArgs

            lblInAnimationImp.Text = "InAnimation - " + ev.AnimationState.ToString();
            lblInAnimationImp.ForeColor = Color.Black;

            lblAnimationStateResponseImp.Text = "AnimationStateResponse - " + ev.AnimationState.ToString() + " - " + DateTime.Now.ToString("HH:mm:ss");
        }
        #endregion
    }
}
