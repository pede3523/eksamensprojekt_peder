
namespace eksamensprojekt
{
    partial class Leaderboard
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
            this.listBox_Vector = new System.Windows.Forms.ListBox();
            this.listBox_Geometri = new System.Windows.Forms.ListBox();
            this.listBox_Procent = new System.Windows.Forms.ListBox();
            this.listBox_trigometri = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leaderboard";
            // 
            // listBox_Vector
            // 
            this.listBox_Vector.FormattingEnabled = true;
            this.listBox_Vector.ItemHeight = 16;
            this.listBox_Vector.Location = new System.Drawing.Point(12, 103);
            this.listBox_Vector.Name = "listBox_Vector";
            this.listBox_Vector.Size = new System.Drawing.Size(152, 308);
            this.listBox_Vector.TabIndex = 1;
            // 
            // listBox_Geometri
            // 
            this.listBox_Geometri.FormattingEnabled = true;
            this.listBox_Geometri.ItemHeight = 16;
            this.listBox_Geometri.Location = new System.Drawing.Point(170, 103);
            this.listBox_Geometri.Name = "listBox_Geometri";
            this.listBox_Geometri.Size = new System.Drawing.Size(160, 308);
            this.listBox_Geometri.TabIndex = 2;
            // 
            // listBox_Procent
            // 
            this.listBox_Procent.FormattingEnabled = true;
            this.listBox_Procent.ItemHeight = 16;
            this.listBox_Procent.Location = new System.Drawing.Point(462, 103);
            this.listBox_Procent.Name = "listBox_Procent";
            this.listBox_Procent.Size = new System.Drawing.Size(160, 308);
            this.listBox_Procent.TabIndex = 3;
            // 
            // listBox_trigometri
            // 
            this.listBox_trigometri.FormattingEnabled = true;
            this.listBox_trigometri.ItemHeight = 16;
            this.listBox_trigometri.Location = new System.Drawing.Point(628, 103);
            this.listBox_trigometri.Name = "listBox_trigometri";
            this.listBox_trigometri.Size = new System.Drawing.Size(160, 308);
            this.listBox_trigometri.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Procent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(660, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trigometri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Geometri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vector";
            // 
            // button_finish
            // 
            this.button_finish.Location = new System.Drawing.Point(367, 208);
            this.button_finish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_finish.Name = "button_finish";
            this.button_finish.Size = new System.Drawing.Size(67, 34);
            this.button_finish.TabIndex = 9;
            this.button_finish.Text = "Finish";
            this.button_finish.UseVisualStyleBackColor = true;
            this.button_finish.Click += new System.EventHandler(this.button_finish_Click);
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_finish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_trigometri);
            this.Controls.Add(this.listBox_Procent);
            this.Controls.Add(this.listBox_Geometri);
            this.Controls.Add(this.listBox_Vector);
            this.Controls.Add(this.label1);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Vector;
        private System.Windows.Forms.ListBox listBox_Geometri;
        private System.Windows.Forms.ListBox listBox_Procent;
        private System.Windows.Forms.ListBox listBox_trigometri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_finish;
    }
}