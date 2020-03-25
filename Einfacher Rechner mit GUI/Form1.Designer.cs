namespace Einfacher_Rechner_mit_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtZahl1 = new System.Windows.Forms.TextBox();
            this.txtZahl2 = new System.Windows.Forms.TextBox();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.btnRechnen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gBRechenart = new System.Windows.Forms.GroupBox();
            this.rBtnAdd = new System.Windows.Forms.RadioButton();
            this.rBtnSub = new System.Windows.Forms.RadioButton();
            this.rBtnMulti = new System.Windows.Forms.RadioButton();
            this.rBtnDiv = new System.Windows.Forms.RadioButton();
            this.gBRechenart.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtZahl1
            // 
            this.txtZahl1.Location = new System.Drawing.Point(12, 15);
            this.txtZahl1.Name = "txtZahl1";
            this.txtZahl1.Size = new System.Drawing.Size(100, 20);
            this.txtZahl1.TabIndex = 0;
            this.txtZahl1.Text = "Deine erste Zahl...";
            this.txtZahl1.TextChanged += new System.EventHandler(this.txtZahl1_TextChanged);
            // 
            // txtZahl2
            // 
            this.txtZahl2.Location = new System.Drawing.Point(138, 15);
            this.txtZahl2.Name = "txtZahl2";
            this.txtZahl2.Size = new System.Drawing.Size(100, 20);
            this.txtZahl2.TabIndex = 1;
            this.txtZahl2.Text = "Deine zweite Zahl...";
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.AutoSize = true;
            this.lblErgebnis.Location = new System.Drawing.Point(12, 118);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(60, 13);
            this.lblErgebnis.TabIndex = 2;
            this.lblErgebnis.Text = "Ergebnis = ";
            // 
            // btnRechnen
            // 
            this.btnRechnen.Location = new System.Drawing.Point(285, 60);
            this.btnRechnen.Name = "btnRechnen";
            this.btnRechnen.Size = new System.Drawing.Size(75, 23);
            this.btnRechnen.TabIndex = 3;
            this.btnRechnen.Text = "Rechnen";
            this.btnRechnen.UseVisualStyleBackColor = true;
            this.btnRechnen.Click += new System.EventHandler(this.btnRechnen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "©developed by siruuux";
            // 
            // gBRechenart
            // 
            this.gBRechenart.Controls.Add(this.rBtnDiv);
            this.gBRechenart.Controls.Add(this.rBtnMulti);
            this.gBRechenart.Controls.Add(this.rBtnSub);
            this.gBRechenart.Controls.Add(this.rBtnAdd);
            this.gBRechenart.Location = new System.Drawing.Point(15, 41);
            this.gBRechenart.Name = "gBRechenart";
            this.gBRechenart.Size = new System.Drawing.Size(189, 62);
            this.gBRechenart.TabIndex = 5;
            this.gBRechenart.TabStop = false;
            this.gBRechenart.Text = "Rechenart";
            // 
            // rBtnAdd
            // 
            this.rBtnAdd.AutoSize = true;
            this.rBtnAdd.Location = new System.Drawing.Point(12, 19);
            this.rBtnAdd.Name = "rBtnAdd";
            this.rBtnAdd.Size = new System.Drawing.Size(63, 17);
            this.rBtnAdd.TabIndex = 0;
            this.rBtnAdd.TabStop = true;
            this.rBtnAdd.Text = "Addition";
            this.rBtnAdd.UseVisualStyleBackColor = true;
            // 
            // rBtnSub
            // 
            this.rBtnSub.AutoSize = true;
            this.rBtnSub.Location = new System.Drawing.Point(12, 39);
            this.rBtnSub.Name = "rBtnSub";
            this.rBtnSub.Size = new System.Drawing.Size(79, 17);
            this.rBtnSub.TabIndex = 1;
            this.rBtnSub.TabStop = true;
            this.rBtnSub.Text = "Subtraktion";
            this.rBtnSub.UseVisualStyleBackColor = true;
            // 
            // rBtnMulti
            // 
            this.rBtnMulti.AutoSize = true;
            this.rBtnMulti.Location = new System.Drawing.Point(103, 19);
            this.rBtnMulti.Name = "rBtnMulti";
            this.rBtnMulti.Size = new System.Drawing.Size(86, 17);
            this.rBtnMulti.TabIndex = 2;
            this.rBtnMulti.TabStop = true;
            this.rBtnMulti.Text = "Multiplikation";
            this.rBtnMulti.UseVisualStyleBackColor = true;
            // 
            // rBtnDiv
            // 
            this.rBtnDiv.AutoSize = true;
            this.rBtnDiv.Location = new System.Drawing.Point(103, 39);
            this.rBtnDiv.Name = "rBtnDiv";
            this.rBtnDiv.Size = new System.Drawing.Size(62, 17);
            this.rBtnDiv.TabIndex = 3;
            this.rBtnDiv.TabStop = true;
            this.rBtnDiv.Text = "Division";
            this.rBtnDiv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 159);
            this.Controls.Add(this.gBRechenart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRechnen);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(this.txtZahl2);
            this.Controls.Add(this.txtZahl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Einfacher Rechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBRechenart.ResumeLayout(false);
            this.gBRechenart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtZahl1;
        private System.Windows.Forms.TextBox txtZahl2;
        private System.Windows.Forms.Label lblErgebnis;
        private System.Windows.Forms.Button btnRechnen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBRechenart;
        private System.Windows.Forms.RadioButton rBtnDiv;
        private System.Windows.Forms.RadioButton rBtnMulti;
        private System.Windows.Forms.RadioButton rBtnSub;
        private System.Windows.Forms.RadioButton rBtnAdd;
    }
}

