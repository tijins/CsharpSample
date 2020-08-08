namespace WindowsFormsApp1
{
    partial class DicSample
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
            this.yamada = new System.Windows.Forms.Button();
            this.tanaka = new System.Windows.Forms.Button();
            this.suzuki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yamada
            // 
            this.yamada.Location = new System.Drawing.Point(12, 12);
            this.yamada.Name = "yamada";
            this.yamada.Size = new System.Drawing.Size(76, 50);
            this.yamada.TabIndex = 0;
            this.yamada.Text = "山田";
            this.yamada.UseVisualStyleBackColor = true;
            this.yamada.Click += new System.EventHandler(this.yamada_Click);
            // 
            // tanaka
            // 
            this.tanaka.Location = new System.Drawing.Point(94, 12);
            this.tanaka.Name = "tanaka";
            this.tanaka.Size = new System.Drawing.Size(76, 50);
            this.tanaka.TabIndex = 0;
            this.tanaka.Text = "田中";
            this.tanaka.UseVisualStyleBackColor = true;
            this.tanaka.Click += new System.EventHandler(this.tanaka_Click);
            // 
            // suzuki
            // 
            this.suzuki.Location = new System.Drawing.Point(176, 12);
            this.suzuki.Name = "suzuki";
            this.suzuki.Size = new System.Drawing.Size(76, 50);
            this.suzuki.TabIndex = 0;
            this.suzuki.Text = "鈴木";
            this.suzuki.UseVisualStyleBackColor = true;
            this.suzuki.Click += new System.EventHandler(this.suzuki_Click);
            // 
            // DicSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 85);
            this.Controls.Add(this.suzuki);
            this.Controls.Add(this.tanaka);
            this.Controls.Add(this.yamada);
            this.Name = "DicSample";
            this.Text = "Dictionaryのサンプル";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yamada;
        private System.Windows.Forms.Button tanaka;
        private System.Windows.Forms.Button suzuki;
    }
}