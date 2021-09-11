
namespace chapelet
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
            this.panelGora = new System.Windows.Forms.Panel();
            this.panelLewy = new System.Windows.Forms.Panel();
            this.panelLewyWewnatrz = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelGora.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGora
            // 
            this.panelGora.Controls.Add(this.panelLewy);
            this.panelGora.Location = new System.Drawing.Point(0, 1);
            this.panelGora.Name = "panelGora";
            this.panelGora.Size = new System.Drawing.Size(801, 47);
            this.panelGora.TabIndex = 0;
            // 
            // panelLewy
            // 
            this.panelLewy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLewy.Location = new System.Drawing.Point(0, 46);
            this.panelLewy.Name = "panelLewy";
            this.panelLewy.Size = new System.Drawing.Size(181, 403);
            this.panelLewy.TabIndex = 1;
            // 
            // panelLewyWewnatrz
            // 
            this.panelLewyWewnatrz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLewyWewnatrz.BackgroundImage = global::chapelet.Properties.Resources.la_salette_cross_white;
            this.panelLewyWewnatrz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLewyWewnatrz.Location = new System.Drawing.Point(0, 303);
            this.panelLewyWewnatrz.Name = "panelLewyWewnatrz";
            this.panelLewyWewnatrz.Size = new System.Drawing.Size(181, 277);
            this.panelLewyWewnatrz.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ave Maria";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Credo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Pater Noster";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Engravers MT", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(181, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(733, 530);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(913, 580);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelLewyWewnatrz);
            this.Controls.Add(this.panelGora);
            this.Name = "Form1";
            this.Text = "Rosarium";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelGora.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGora;
        private System.Windows.Forms.Panel panelLewy;
        private System.Windows.Forms.Panel panelLewyWewnatrz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

