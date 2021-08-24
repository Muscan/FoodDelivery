
namespace FoodDelivery
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnComanda = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.rdoBtn3 = new System.Windows.Forms.RadioButton();
            this.rdoBtn2 = new System.Windows.Forms.RadioButton();
            this.rdoBtn1 = new System.Windows.Forms.RadioButton();
            this.grpExtra = new System.Windows.Forms.GroupBox();
            this.rdoBtn4 = new System.Windows.Forms.RadioButton();
            this.rdoBtn5 = new System.Windows.Forms.RadioButton();
            this.rdoBtn6 = new System.Windows.Forms.RadioButton();
            this.cmBoxArea = new System.Windows.Forms.ComboBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.grpMenu.SuspendLayout();
            this.grpExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnComanda
            // 
            this.btnComanda.Location = new System.Drawing.Point(347, 523);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(94, 29);
            this.btnComanda.TabIndex = 0;
            this.btnComanda.Text = "Comanda";
            this.btnComanda.UseVisualStyleBackColor = true;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.Location = new System.Drawing.Point(48, 523);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(94, 29);
            this.btnAnuleaza.TabIndex = 1;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.rdoBtn3);
            this.grpMenu.Controls.Add(this.rdoBtn2);
            this.grpMenu.Controls.Add(this.rdoBtn1);
            this.grpMenu.Location = new System.Drawing.Point(12, 34);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(330, 298);
            this.grpMenu.TabIndex = 2;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "Meniu";
            // 
            // rdoBtn3
            // 
            this.rdoBtn3.AutoSize = true;
            this.rdoBtn3.Location = new System.Drawing.Point(36, 205);
            this.rdoBtn3.Name = "rdoBtn3";
            this.rdoBtn3.Size = new System.Drawing.Size(79, 24);
            this.rdoBtn3.TabIndex = 2;
            this.rdoBtn3.TabStop = true;
            this.rdoBtn3.Text = "Menu 3";
            this.rdoBtn3.UseVisualStyleBackColor = true;
            // 
            // rdoBtn2
            // 
            this.rdoBtn2.AutoSize = true;
            this.rdoBtn2.Location = new System.Drawing.Point(36, 123);
            this.rdoBtn2.Name = "rdoBtn2";
            this.rdoBtn2.Size = new System.Drawing.Size(79, 24);
            this.rdoBtn2.TabIndex = 1;
            this.rdoBtn2.TabStop = true;
            this.rdoBtn2.Text = "Menu 2";
            this.rdoBtn2.UseVisualStyleBackColor = true;
            // 
            // rdoBtn1
            // 
            this.rdoBtn1.AutoSize = true;
            this.rdoBtn1.Location = new System.Drawing.Point(36, 41);
            this.rdoBtn1.Name = "rdoBtn1";
            this.rdoBtn1.Size = new System.Drawing.Size(79, 24);
            this.rdoBtn1.TabIndex = 0;
            this.rdoBtn1.TabStop = true;
            this.rdoBtn1.Text = "Menu 1";
            this.rdoBtn1.UseVisualStyleBackColor = true;
            // 
            // grpExtra
            // 
            this.grpExtra.Controls.Add(this.rdoBtn4);
            this.grpExtra.Controls.Add(this.rdoBtn5);
            this.grpExtra.Controls.Add(this.rdoBtn6);
            this.grpExtra.Location = new System.Drawing.Point(365, 34);
            this.grpExtra.Name = "grpExtra";
            this.grpExtra.Size = new System.Drawing.Size(414, 298);
            this.grpExtra.TabIndex = 3;
            this.grpExtra.TabStop = false;
            this.grpExtra.Text = "Extra";
            // 
            // rdoBtn4
            // 
            this.rdoBtn4.AutoSize = true;
            this.rdoBtn4.Location = new System.Drawing.Point(6, 41);
            this.rdoBtn4.Name = "rdoBtn4";
            this.rdoBtn4.Size = new System.Drawing.Size(75, 24);
            this.rdoBtn4.TabIndex = 3;
            this.rdoBtn4.TabStop = true;
            this.rdoBtn4.Text = "Extra 1";
            this.rdoBtn4.UseVisualStyleBackColor = true;
            // 
            // rdoBtn5
            // 
            this.rdoBtn5.AutoSize = true;
            this.rdoBtn5.Location = new System.Drawing.Point(0, 123);
            this.rdoBtn5.Name = "rdoBtn5";
            this.rdoBtn5.Size = new System.Drawing.Size(75, 24);
            this.rdoBtn5.TabIndex = 4;
            this.rdoBtn5.TabStop = true;
            this.rdoBtn5.Text = "Extra 2";
            this.rdoBtn5.UseVisualStyleBackColor = true;
            // 
            // rdoBtn6
            // 
            this.rdoBtn6.AutoSize = true;
            this.rdoBtn6.Location = new System.Drawing.Point(0, 205);
            this.rdoBtn6.Name = "rdoBtn6";
            this.rdoBtn6.Size = new System.Drawing.Size(75, 24);
            this.rdoBtn6.TabIndex = 5;
            this.rdoBtn6.TabStop = true;
            this.rdoBtn6.Text = "Extra 3";
            this.rdoBtn6.UseVisualStyleBackColor = true;
            // 
            // cmBoxArea
            // 
            this.cmBoxArea.FormattingEnabled = true;
            this.cmBoxArea.Location = new System.Drawing.Point(885, 44);
            this.cmBoxArea.Name = "cmBoxArea";
            this.cmBoxArea.Size = new System.Drawing.Size(302, 28);
            this.cmBoxArea.TabIndex = 4;
            this.cmBoxArea.Text = "Zona Livrare";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(634, 360);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(40, 20);
            this.lblFinal.TabIndex = 5;
            this.lblFinal.Text = "Final";
            this.lblFinal.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 612);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.cmBoxArea);
            this.Controls.Add(this.grpExtra);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnComanda);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.grpExtra.ResumeLayout(false);
            this.grpExtra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComanda;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.GroupBox grpExtra;
        private System.Windows.Forms.ComboBox cmBoxArea;
        private System.Windows.Forms.RadioButton rdoBtn3;
        private System.Windows.Forms.RadioButton rdoBtn2;
        private System.Windows.Forms.RadioButton rdoBtn1;
        private System.Windows.Forms.RadioButton rdoBtn4;
        private System.Windows.Forms.RadioButton rdoBtn5;
        private System.Windows.Forms.RadioButton rdoBtn6;
        private System.Windows.Forms.Label lblFinal;
    }
}

