namespace WindowsFormsAnimationEx
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblAnimationStateResponseComp = new System.Windows.Forms.Label();
            this.lblInAnimationCom = new System.Windows.Forms.Label();
            this.btnShowRideComp = new System.Windows.Forms.Button();
            this.panel1 = new WindowsFormsAnimation.Controls.WFAPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblAnimationStateResponseImp = new System.Windows.Forms.Label();
            this.lblInAnimationImp = new System.Windows.Forms.Label();
            this.btnShowRideImp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblAnimationStateResponseComp);
            this.tabPage1.Controls.Add(this.lblInAnimationCom);
            this.tabPage1.Controls.Add(this.btnShowRideComp);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Componente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblAnimationStateResponseComp
            // 
            this.lblAnimationStateResponseComp.AutoSize = true;
            this.lblAnimationStateResponseComp.Location = new System.Drawing.Point(209, 48);
            this.lblAnimationStateResponseComp.Name = "lblAnimationStateResponseComp";
            this.lblAnimationStateResponseComp.Size = new System.Drawing.Size(126, 13);
            this.lblAnimationStateResponseComp.TabIndex = 3;
            this.lblAnimationStateResponseComp.Text = "AnimationStateResponse";
            // 
            // lblInAnimationCom
            // 
            this.lblInAnimationCom.AutoSize = true;
            this.lblInAnimationCom.Location = new System.Drawing.Point(209, 29);
            this.lblInAnimationCom.Name = "lblInAnimationCom";
            this.lblInAnimationCom.Size = new System.Drawing.Size(62, 13);
            this.lblInAnimationCom.TabIndex = 2;
            this.lblInAnimationCom.Text = "InAnimation";
            // 
            // btnShowRideComp
            // 
            this.btnShowRideComp.Location = new System.Drawing.Point(209, 3);
            this.btnShowRideComp.Name = "btnShowRideComp";
            this.btnShowRideComp.Size = new System.Drawing.Size(75, 23);
            this.btnShowRideComp.TabIndex = 1;
            this.btnShowRideComp.Text = "Show/Ride";
            this.btnShowRideComp.UseVisualStyleBackColor = true;
            this.btnShowRideComp.Click += new System.EventHandler(this.btnShowRideComp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 418);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amostra de texto em LIVRE ";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amostra de texto em DOCK Amostra de texto em DOCK Amostra de texto em DOCK Amostr" +
    "a de texto em DOCK Amostra de texto em DOCK";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblAnimationStateResponseImp);
            this.tabPage2.Controls.Add(this.lblInAnimationImp);
            this.tabPage2.Controls.Add(this.btnShowRideImp);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Indepentende";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblAnimationStateResponseImp
            // 
            this.lblAnimationStateResponseImp.AutoSize = true;
            this.lblAnimationStateResponseImp.Location = new System.Drawing.Point(209, 48);
            this.lblAnimationStateResponseImp.Name = "lblAnimationStateResponseImp";
            this.lblAnimationStateResponseImp.Size = new System.Drawing.Size(126, 13);
            this.lblAnimationStateResponseImp.TabIndex = 7;
            this.lblAnimationStateResponseImp.Text = "AnimationStateResponse";
            // 
            // lblInAnimationImp
            // 
            this.lblInAnimationImp.AutoSize = true;
            this.lblInAnimationImp.Location = new System.Drawing.Point(209, 29);
            this.lblInAnimationImp.Name = "lblInAnimationImp";
            this.lblInAnimationImp.Size = new System.Drawing.Size(62, 13);
            this.lblInAnimationImp.TabIndex = 6;
            this.lblInAnimationImp.Text = "InAnimation";
            // 
            // btnShowRideImp
            // 
            this.btnShowRideImp.Location = new System.Drawing.Point(209, 3);
            this.btnShowRideImp.Name = "btnShowRideImp";
            this.btnShowRideImp.Size = new System.Drawing.Size(75, 23);
            this.btnShowRideImp.TabIndex = 5;
            this.btnShowRideImp.Text = "Show/Ride";
            this.btnShowRideImp.UseVisualStyleBackColor = true;
            this.btnShowRideImp.Click += new System.EventHandler(this.btnShowRideImp_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 418);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Amostra de texto em LIVRE ";
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 58);
            this.label6.TabIndex = 0;
            this.label6.Text = "Amostra de texto em DOCK Amostra de texto em DOCK Amostra de texto em DOCK Amostr" +
    "a de texto em DOCK Amostra de texto em DOCK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Exemplo de uso da biblioteca NuGet WindowsFormsAnimation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnShowRideComp;
        private WindowsFormsAnimation.Controls.WFAPanel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInAnimationCom;
        private System.Windows.Forms.Label lblAnimationStateResponseComp;
        private System.Windows.Forms.Label lblAnimationStateResponseImp;
        private System.Windows.Forms.Label lblInAnimationImp;
        private System.Windows.Forms.Button btnShowRideImp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

