namespace Empezando
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.rbSumar = new System.Windows.Forms.RadioButton();
            this.rbRestar = new System.Windows.Forms.RadioButton();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lvHistorial = new System.Windows.Forms.ListView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtResultadoReal = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultadoComun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            resources.ApplyResources(this.txtNumero, "txtNumero");
            this.txtNumero.Name = "txtNumero";
            // 
            // rbSumar
            // 
            resources.ApplyResources(this.rbSumar, "rbSumar");
            this.rbSumar.Name = "rbSumar";
            this.rbSumar.TabStop = true;
            this.rbSumar.UseVisualStyleBackColor = true;
            // 
            // rbRestar
            // 
            resources.ApplyResources(this.rbRestar, "rbRestar");
            this.rbRestar.Name = "rbRestar";
            this.rbRestar.TabStop = true;
            this.rbRestar.UseVisualStyleBackColor = true;
            // 
            // lblNumero
            // 
            resources.ApplyResources(this.lblNumero, "lblNumero");
            this.lblNumero.Name = "lblNumero";
            // 
            // txtPorcentaje
            // 
            resources.ApplyResources(this.txtPorcentaje, "txtPorcentaje");
            this.txtPorcentaje.Name = "txtPorcentaje";
            // 
            // lblPorcentaje
            // 
            resources.ApplyResources(this.lblPorcentaje, "lblPorcentaje");
            this.lblPorcentaje.Name = "lblPorcentaje";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.rbRestar);
            this.groupBox1.Controls.Add(this.rbSumar);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnCalcular
            // 
            resources.ApplyResources(this.btnCalcular, "btnCalcular");
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lvHistorial
            // 
            resources.ApplyResources(this.lvHistorial, "lvHistorial");
            this.lvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvHistorial.HideSelection = false;
            this.lvHistorial.Name = "lvHistorial";
            this.lvHistorial.TabStop = false;
            this.lvHistorial.UseCompatibleStateImageBehavior = false;
            this.lvHistorial.View = System.Windows.Forms.View.List;
            // 
            // notifyIcon1
            // 
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            // 
            // txtResultadoReal
            // 
            resources.ApplyResources(this.txtResultadoReal, "txtResultadoReal");
            this.txtResultadoReal.Name = "txtResultadoReal";
            // 
            // lblResultado
            // 
            resources.ApplyResources(this.lblResultado, "lblResultado");
            this.lblResultado.Name = "lblResultado";
            // 
            // txtResultadoComun
            // 
            resources.ApplyResources(this.txtResultadoComun, "txtResultadoComun");
            this.txtResultadoComun.Name = "txtResultadoComun";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtResultadoComun);
            this.groupBox2.Controls.Add(this.lblResultado);
            this.groupBox2.Controls.Add(this.txtResultadoReal);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // lblHistorial
            // 
            resources.ApplyResources(this.lblHistorial, "lblHistorial");
            this.lblHistorial.Name = "lblHistorial";
            // 
            // FrmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvHistorial);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNumero);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.RadioButton rbSumar;
        private System.Windows.Forms.RadioButton rbRestar;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListView lvHistorial;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox txtResultadoReal;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultadoComun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblHistorial;
    }
}

