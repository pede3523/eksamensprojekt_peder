
namespace eksamensprojekt
{
    partial class Form_Geomatri_task
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
            this.button_back = new System.Windows.Forms.Button();
            this.button_finish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geomatri task ";
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(13, 396);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 42);
            this.button_back.TabIndex = 1;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            // 
            // button_finish
            // 
            this.button_finish.Location = new System.Drawing.Point(713, 396);
            this.button_finish.Name = "button_finish";
            this.button_finish.Size = new System.Drawing.Size(75, 42);
            this.button_finish.TabIndex = 2;
            this.button_finish.Text = "Finish";
            this.button_finish.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // Form_Geomatri_task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_finish);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label1);
            this.Name = "Form_Geomatri_task";
            this.Text = "Form_Geomatri_task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_finish;
        private System.Windows.Forms.Label label2;
    }
}