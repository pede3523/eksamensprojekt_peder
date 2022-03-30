
namespace eksamensprojekt
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
            this.button_Vec = new System.Windows.Forms.Button();
            this.button_Geo = new System.Windows.Forms.Button();
            this.button_Pro = new System.Windows.Forms.Button();
            this.button_Tri = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a subjekt you want to improve";
            // 
            // button_Vec
            // 
            this.button_Vec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Vec.Location = new System.Drawing.Point(309, 115);
            this.button_Vec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Vec.Name = "button_Vec";
            this.button_Vec.Size = new System.Drawing.Size(228, 75);
            this.button_Vec.TabIndex = 1;
            this.button_Vec.Text = "Vector";
            this.button_Vec.UseVisualStyleBackColor = true;
            this.button_Vec.Click += new System.EventHandler(this.button_Vec_Click);
            // 
            // button_Geo
            // 
            this.button_Geo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Geo.Location = new System.Drawing.Point(309, 198);
            this.button_Geo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Geo.Name = "button_Geo";
            this.button_Geo.Size = new System.Drawing.Size(228, 75);
            this.button_Geo.TabIndex = 2;
            this.button_Geo.Text = "Geometri";
            this.button_Geo.UseVisualStyleBackColor = true;
            this.button_Geo.Click += new System.EventHandler(this.button_Geo_Click);
            // 
            // button_Pro
            // 
            this.button_Pro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Pro.Location = new System.Drawing.Point(309, 280);
            this.button_Pro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Pro.Name = "button_Pro";
            this.button_Pro.Size = new System.Drawing.Size(228, 75);
            this.button_Pro.TabIndex = 3;
            this.button_Pro.Text = "%";
            this.button_Pro.UseVisualStyleBackColor = true;
            this.button_Pro.Click += new System.EventHandler(this.button_Pro_Click);
            // 
            // button_Tri
            // 
            this.button_Tri.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Tri.Location = new System.Drawing.Point(309, 362);
            this.button_Tri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Tri.Name = "button_Tri";
            this.button_Tri.Size = new System.Drawing.Size(228, 75);
            this.button_Tri.TabIndex = 4;
            this.button_Tri.Text = "Trigonometri";
            this.button_Tri.UseVisualStyleBackColor = true;
            this.button_Tri.Click += new System.EventHandler(this.button_Tri_Click);
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(768, 505);
            this.button_Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(118, 42);
            this.button_Close.TabIndex = 5;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Tri);
            this.Controls.Add(this.button_Pro);
            this.Controls.Add(this.button_Geo);
            this.Controls.Add(this.button_Vec);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Vec;
        private System.Windows.Forms.Button button_Geo;
        private System.Windows.Forms.Button button_Pro;
        private System.Windows.Forms.Button button_Tri;
        private System.Windows.Forms.Button button_Close;
    }
}

