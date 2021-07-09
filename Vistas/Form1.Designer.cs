
namespace ProyectoProgGrafica
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
            this.CbObjetos = new System.Windows.Forms.ComboBox();
            this.CbPartes = new System.Windows.Forms.ComboBox();
            this.CbOperacion = new System.Windows.Forms.ComboBox();
            this.TBX = new System.Windows.Forms.TextBox();
            this.TBY = new System.Windows.Forms.TextBox();
            this.glControl = new OpenTK.WinForms.GLControl();
            this.TBZ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CbObjetos
            // 
            this.CbObjetos.FormattingEnabled = true;
            this.CbObjetos.Location = new System.Drawing.Point(0, 2);
            this.CbObjetos.Name = "CbObjetos";
            this.CbObjetos.Size = new System.Drawing.Size(121, 23);
            this.CbObjetos.TabIndex = 4;
            this.CbObjetos.SelectedValueChanged += new System.EventHandler(this.CbObjetos_SelectedValueChanged);
            // 
            // CbPartes
            // 
            this.CbPartes.FormattingEnabled = true;
            this.CbPartes.Location = new System.Drawing.Point(127, 2);
            this.CbPartes.Name = "CbPartes";
            this.CbPartes.Size = new System.Drawing.Size(121, 23);
            this.CbPartes.TabIndex = 5;
            this.CbPartes.SelectedValueChanged += new System.EventHandler(this.CbPartes_SelectedValueChanged);
            // 
            // CbOperacion
            // 
            this.CbOperacion.FormattingEnabled = true;
            this.CbOperacion.Location = new System.Drawing.Point(266, 2);
            this.CbOperacion.Name = "CbOperacion";
            this.CbOperacion.Size = new System.Drawing.Size(121, 23);
            this.CbOperacion.TabIndex = 6;
            this.CbOperacion.SelectedValueChanged += new System.EventHandler(this.CbOperacion_SelectedValueChanged);
            // 
            // TBX
            // 
            this.TBX.Location = new System.Drawing.Point(219, 50);
            this.TBX.Name = "TBX";
            this.TBX.Size = new System.Drawing.Size(100, 23);
            this.TBX.TabIndex = 8;
            // 
            // TBY
            // 
            this.TBY.Location = new System.Drawing.Point(325, 50);
            this.TBY.Name = "TBY";
            this.TBY.Size = new System.Drawing.Size(100, 23);
            this.TBY.TabIndex = 9;
            // 
            // glControl
            // 
            this.glControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glControl.API = OpenTK.Windowing.Common.ContextAPI.OpenGL;
            this.glControl.APIVersion = new System.Version(3, 3, 0, 0);
            this.glControl.Flags = OpenTK.Windowing.Common.ContextFlags.Default;
            this.glControl.IsEventDriven = true;
            this.glControl.Location = new System.Drawing.Point(0, 2);
            this.glControl.Name = "glControl";
            this.glControl.Profile = OpenTK.Windowing.Common.ContextProfile.Compatability;
            this.glControl.Size = new System.Drawing.Size(964, 493);
            this.glControl.TabIndex = 3;
            this.glControl.Text = "glControl1";
            this.glControl.Load += new System.EventHandler(this.glControl_Load);
            this.glControl.Click += new System.EventHandler(this.glControl_Click);
            this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_Paint);
            this.glControl.Resize += new System.EventHandler(this.glControl_Resize);
            // 
            // TBZ
            // 
            this.TBZ.Location = new System.Drawing.Point(431, 50);
            this.TBZ.Name = "TBZ";
            this.TBZ.Size = new System.Drawing.Size(100, 23);
            this.TBZ.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 496);
            this.Controls.Add(this.TBZ);
            this.Controls.Add(this.TBY);
            this.Controls.Add(this.TBX);
            this.Controls.Add(this.CbOperacion);
            this.Controls.Add(this.CbPartes);
            this.Controls.Add(this.CbObjetos);
            this.Controls.Add(this.glControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CbObjetos;
        private System.Windows.Forms.ComboBox CbPartes;
        private System.Windows.Forms.ComboBox CbOperacion;
        private System.Windows.Forms.TextBox TBX;
        private System.Windows.Forms.TextBox TBY;
        private OpenTK.WinForms.GLControl glControl;
        private System.Windows.Forms.TextBox TBZ;
    }
}

