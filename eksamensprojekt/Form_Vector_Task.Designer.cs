
namespace eksamensprojekt
{
    partial class Form_Vector_Task
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
            this.button_Fin = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Fin
            // 
            this.button_Fin.Location = new System.Drawing.Point(713, 395);
            this.button_Fin.Name = "button_Fin";
            this.button_Fin.Size = new System.Drawing.Size(75, 43);
            this.button_Fin.TabIndex = 0;
            this.button_Fin.Text = "Finished";
            this.button_Fin.UseVisualStyleBackColor = true;
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(12, 395);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(81, 43);
            this.button_Back.TabIndex = 4;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            // 
            // Form_Vector_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Fin);
            this.Name = "Form_Vector_Task";
            this.Text = "Form_Vector_Task";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Fin;
        private System.Windows.Forms.Button button_Back;
    }
}