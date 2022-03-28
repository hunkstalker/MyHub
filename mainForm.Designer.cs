
namespace MyLauncher
{
    partial class mainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.iconSystray = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_Hora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dD_options = new System.Windows.Forms.ComboBox();
            this.numUpDo_Horas = new System.Windows.Forms.NumericUpDown();
            this.btn_accept = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numUpDo_Mins = new System.Windows.Forms.NumericUpDown();
            this.pb_info = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDo_Horas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDo_Mins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_info)).BeginInit();
            this.SuspendLayout();
            // 
            // iconSystray
            // 
            this.iconSystray.ContextMenuStrip = this.iconMenu;
            this.iconSystray.Icon = ((System.Drawing.Icon)(resources.GetObject("iconSystray.Icon")));
            this.iconSystray.Text = "MyLauncher";
            this.iconSystray.DoubleClick += new System.EventHandler(this.iconSystray_DoubleClick);
            // 
            // iconMenu
            // 
            this.iconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.iconMenu.Name = "iconMenu";
            this.iconMenu.Size = new System.Drawing.Size(97, 26);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.iconMenu_Salir_Click);
            // 
            // lb_Hora
            // 
            this.lb_Hora.AutoSize = true;
            this.lb_Hora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_Hora.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hora.ForeColor = System.Drawing.Color.White;
            this.lb_Hora.Location = new System.Drawing.Point(232, 19);
            this.lb_Hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Hora.Name = "lb_Hora";
            this.lb_Hora.Size = new System.Drawing.Size(63, 19);
            this.lb_Hora.TabIndex = 1;
            this.lb_Hora.Text = "Horas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(232, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minutos:";
            // 
            // dD_options
            // 
            this.dD_options.FormattingEnabled = true;
            this.dD_options.Location = new System.Drawing.Point(12, 16);
            this.dD_options.Name = "dD_options";
            this.dD_options.Size = new System.Drawing.Size(174, 27);
            this.dD_options.TabIndex = 3;
            this.dD_options.Text = "Shutdown";
            // 
            // numUpDo_Horas
            // 
            this.numUpDo_Horas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDo_Horas.Location = new System.Drawing.Point(318, 15);
            this.numUpDo_Horas.Name = "numUpDo_Horas";
            this.numUpDo_Horas.Size = new System.Drawing.Size(85, 26);
            this.numUpDo_Horas.TabIndex = 4;
            this.numUpDo_Horas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDo_Horas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_accept
            // 
            this.btn_accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_accept.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_accept.FlatAppearance.BorderSize = 2;
            this.btn_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accept.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accept.ForeColor = System.Drawing.Color.Black;
            this.btn_accept.Location = new System.Drawing.Point(12, 63);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(167, 40);
            this.btn_accept.TabIndex = 6;
            this.btn_accept.Text = "Aceptar";
            this.btn_accept.UseVisualStyleBackColor = false;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(18, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 40);
            this.panel1.TabIndex = 7;
            // 
            // numUpDo_Mins
            // 
            this.numUpDo_Mins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpDo_Mins.Location = new System.Drawing.Point(318, 59);
            this.numUpDo_Mins.Name = "numUpDo_Mins";
            this.numUpDo_Mins.Size = new System.Drawing.Size(85, 26);
            this.numUpDo_Mins.TabIndex = 5;
            this.numUpDo_Mins.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pb_info
            // 
            this.pb_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pb_info.Location = new System.Drawing.Point(12, 132);
            this.pb_info.Name = "pb_info";
            this.pb_info.Size = new System.Drawing.Size(391, 34);
            this.pb_info.TabIndex = 8;
            this.pb_info.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "¡Hoy es un gran día!";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(419, 184);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_info);
            this.Controls.Add(this.btn_accept);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numUpDo_Mins);
            this.Controls.Add(this.numUpDo_Horas);
            this.Controls.Add(this.dD_options);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Hora);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  MyHub";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_Closing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.iconMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDo_Horas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDo_Mins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon iconSystray;
        private System.Windows.Forms.ContextMenuStrip iconMenu;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lb_Hora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dD_options;
        private System.Windows.Forms.NumericUpDown numUpDo_Horas;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numUpDo_Mins;
        private System.Windows.Forms.PictureBox pb_info;
        private System.Windows.Forms.Label label2;
    }
}

