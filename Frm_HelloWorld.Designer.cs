namespace HelloWorld
{
    partial class Frm_HelloWorld
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
            this.btnCliqueAqui = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCliqueAqui
            // 
            this.btnCliqueAqui.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliqueAqui.Location = new System.Drawing.Point(68, 42);
            this.btnCliqueAqui.Name = "btnCliqueAqui";
            this.btnCliqueAqui.Size = new System.Drawing.Size(108, 27);
            this.btnCliqueAqui.TabIndex = 0;
            this.btnCliqueAqui.Text = "Clique Aqui";
            this.btnCliqueAqui.UseVisualStyleBackColor = true;
            this.btnCliqueAqui.Click += new System.EventHandler(this.btnCliqueAqui_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloWorld.Location = new System.Drawing.Point(78, 93);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(0, 20);
            this.lblHelloWorld.TabIndex = 1;
            // 
            // Frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 193);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnCliqueAqui);
            this.Name = "Frm_HelloWorld";
            this.ShowIcon = false;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCliqueAqui;
        private System.Windows.Forms.Label lblHelloWorld;
    }
}

