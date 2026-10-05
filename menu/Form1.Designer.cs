namespace menu
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripSeparator();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            salirToolStripMenuItem2 = new ToolStripMenuItem();
            formatoToolStripMenuItem = new ToolStripMenuItem();
            fuenteToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripSeparator();
            copiarToolStripMenuItem1 = new ToolStripMenuItem();
            pegarToolStripMenuItem = new ToolStripMenuItem();
            cortarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            seleccionarTodoToolStripMenuItem = new ToolStripMenuItem();
            borrarTodoToolStripMenuItem = new ToolStripMenuItem();
            fuenteToolStripMenuItem1 = new ToolStripMenuItem();
            fuenteToolStripMenuItem2 = new ToolStripMenuItem();
            colorDeFuenteToolStripMenuItem = new ToolStripMenuItem();
            colorDeFondoToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, formatoToolStripMenuItem, fuenteToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem, salirToolStripMenuItem, guardarComoToolStripMenuItem, salirToolStripMenuItem1, salirToolStripMenuItem2 });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(152, 22);
            acercaDeToolStripMenuItem.Text = "Nuevo";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(149, 6);
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(152, 22);
            guardarComoToolStripMenuItem.Text = "Abrir";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(152, 22);
            salirToolStripMenuItem1.Text = "Guardar Como";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem1_Click;
            // 
            // salirToolStripMenuItem2
            // 
            salirToolStripMenuItem2.Name = "salirToolStripMenuItem2";
            salirToolStripMenuItem2.Size = new Size(152, 22);
            salirToolStripMenuItem2.Text = "Salir";
            salirToolStripMenuItem2.Click += salirToolStripMenuItem2_Click;
            // 
            // formatoToolStripMenuItem
            // 
            formatoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fuenteToolStripMenuItem, colorToolStripMenuItem, copiarToolStripMenuItem, copiarToolStripMenuItem1, pegarToolStripMenuItem, cortarToolStripMenuItem, toolStripMenuItem1, seleccionarTodoToolStripMenuItem, borrarTodoToolStripMenuItem });
            formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            formatoToolStripMenuItem.Size = new Size(49, 20);
            formatoToolStripMenuItem.Text = "&Editar";
            formatoToolStripMenuItem.Click += formatoToolStripMenuItem_Click;
            // 
            // fuenteToolStripMenuItem
            // 
            fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            fuenteToolStripMenuItem.Size = new Size(162, 22);
            fuenteToolStripMenuItem.Text = "Atras";
            fuenteToolStripMenuItem.Click += fuenteToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(162, 22);
            colorToolStripMenuItem.Text = "Adelante";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(159, 6);
            // 
            // copiarToolStripMenuItem1
            // 
            copiarToolStripMenuItem1.Name = "copiarToolStripMenuItem1";
            copiarToolStripMenuItem1.Size = new Size(162, 22);
            copiarToolStripMenuItem1.Text = "Copiar";
            copiarToolStripMenuItem1.Click += copiarToolStripMenuItem1_Click;
            // 
            // pegarToolStripMenuItem
            // 
            pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            pegarToolStripMenuItem.Size = new Size(162, 22);
            pegarToolStripMenuItem.Text = "Pegar";
            pegarToolStripMenuItem.Click += pegarToolStripMenuItem_Click;
            // 
            // cortarToolStripMenuItem
            // 
            cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            cortarToolStripMenuItem.Size = new Size(162, 22);
            cortarToolStripMenuItem.Text = "Cortar";
            cortarToolStripMenuItem.Click += cortarToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(159, 6);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            seleccionarTodoToolStripMenuItem.Size = new Size(162, 22);
            seleccionarTodoToolStripMenuItem.Text = "Seleccionar todo";
            seleccionarTodoToolStripMenuItem.Click += seleccionarTodoToolStripMenuItem_Click;
            // 
            // borrarTodoToolStripMenuItem
            // 
            borrarTodoToolStripMenuItem.Name = "borrarTodoToolStripMenuItem";
            borrarTodoToolStripMenuItem.Size = new Size(162, 22);
            borrarTodoToolStripMenuItem.Text = "Borrar todo";
            borrarTodoToolStripMenuItem.Click += borrarTodoToolStripMenuItem_Click;
            // 
            // fuenteToolStripMenuItem1
            // 
            fuenteToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { fuenteToolStripMenuItem2, colorDeFuenteToolStripMenuItem, colorDeFondoToolStripMenuItem });
            fuenteToolStripMenuItem1.Name = "fuenteToolStripMenuItem1";
            fuenteToolStripMenuItem1.Size = new Size(55, 20);
            fuenteToolStripMenuItem1.Text = "&Fuente";
            fuenteToolStripMenuItem1.Click += fuenteToolStripMenuItem1_Click;
            // 
            // fuenteToolStripMenuItem2
            // 
            fuenteToolStripMenuItem2.Name = "fuenteToolStripMenuItem2";
            fuenteToolStripMenuItem2.Size = new Size(180, 22);
            fuenteToolStripMenuItem2.Text = "Fuente";
            fuenteToolStripMenuItem2.Click += fuenteToolStripMenuItem2_Click;
            // 
            // colorDeFuenteToolStripMenuItem
            // 
            colorDeFuenteToolStripMenuItem.Name = "colorDeFuenteToolStripMenuItem";
            colorDeFuenteToolStripMenuItem.Size = new Size(180, 22);
            colorDeFuenteToolStripMenuItem.Text = "Color de Fuente";
            colorDeFuenteToolStripMenuItem.Click += colorDeFuenteToolStripMenuItem_Click;
            // 
            // colorDeFondoToolStripMenuItem
            // 
            colorDeFondoToolStripMenuItem.Name = "colorDeFondoToolStripMenuItem";
            colorDeFondoToolStripMenuItem.Size = new Size(180, 22);
            colorDeFondoToolStripMenuItem.Text = "Color de Fondo";
            colorDeFondoToolStripMenuItem.Click += colorDeFondoToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 426);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Mi Editor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem formatoToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private ToolStripSeparator salirToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem2;
        private ToolStripSeparator copiarToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem1;
        private ToolStripMenuItem pegarToolStripMenuItem;
        private ToolStripMenuItem cortarToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private ToolStripMenuItem borrarTodoToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem1;
        private ToolStripMenuItem fuenteToolStripMenuItem2;
        private ToolStripMenuItem colorDeFuenteToolStripMenuItem;
        private ToolStripMenuItem colorDeFondoToolStripMenuItem;
    }
}
