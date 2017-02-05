namespace WF_Components_Example
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCustom1 = new Components.TextBoxCustom();
            this.textBoxCustom2 = new Components.TextBoxCustom();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Testando o TextBox Customizado";
            // 
            // textBoxCustom1
            // 
            this.textBoxCustom1.BackColorIn = System.Drawing.Color.Silver;
            this.textBoxCustom1.BackColorOut = System.Drawing.Color.White;
            this.textBoxCustom1.ForeColorIn = System.Drawing.Color.Black;
            this.textBoxCustom1.ForeColorOut = System.Drawing.Color.Red;
            this.textBoxCustom1.Location = new System.Drawing.Point(22, 64);
            this.textBoxCustom1.Name = "textBoxCustom1";
            this.textBoxCustom1.Size = new System.Drawing.Size(236, 20);
            this.textBoxCustom1.TabIndex = 0;
            // 
            // textBoxCustom2
            // 
            this.textBoxCustom2.BackColorIn = System.Drawing.Color.Silver;
            this.textBoxCustom2.BackColorOut = System.Drawing.Color.White;
            this.textBoxCustom2.ForeColorIn = System.Drawing.Color.Black;
            this.textBoxCustom2.ForeColorOut = System.Drawing.Color.Red;
            this.textBoxCustom2.Location = new System.Drawing.Point(22, 100);
            this.textBoxCustom2.Name = "textBoxCustom2";
            this.textBoxCustom2.Size = new System.Drawing.Size(236, 20);
            this.textBoxCustom2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "[Após digitar, tecle Tab]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 154);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCustom2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCustom1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.TextBoxCustom textBoxCustom1;
        private System.Windows.Forms.Label label1;
        private Components.TextBoxCustom textBoxCustom2;
        private System.Windows.Forms.Label label2;
    }
}

