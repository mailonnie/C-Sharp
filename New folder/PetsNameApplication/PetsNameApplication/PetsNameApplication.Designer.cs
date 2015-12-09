namespace PetsNameApplication
{
    partial class PetsNameApplication
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDisplayPetsName = new System.Windows.Forms.Button();
            this.rbLucy = new System.Windows.Forms.RadioButton();
            this.rbBamboo = new System.Windows.Forms.RadioButton();
            this.rbLala = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(290, 181);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 52);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDisplayPetsName
            // 
            this.btnDisplayPetsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayPetsName.Location = new System.Drawing.Point(104, 181);
            this.btnDisplayPetsName.Name = "btnDisplayPetsName";
            this.btnDisplayPetsName.Size = new System.Drawing.Size(104, 52);
            this.btnDisplayPetsName.TabIndex = 0;
            this.btnDisplayPetsName.Text = "Display Pet\'s Name";
            this.btnDisplayPetsName.UseVisualStyleBackColor = true;
            this.btnDisplayPetsName.Click += new System.EventHandler(this.btnDisplayPetsName_Click);
            // 
            // rbLucy
            // 
            this.rbLucy.AutoSize = true;
            this.rbLucy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLucy.Location = new System.Drawing.Point(66, 64);
            this.rbLucy.Name = "rbLucy";
            this.rbLucy.Size = new System.Drawing.Size(66, 24);
            this.rbLucy.TabIndex = 3;
            this.rbLucy.TabStop = true;
            this.rbLucy.Text = "Lucy";
            this.rbLucy.UseVisualStyleBackColor = true;
            // 
            // rbBamboo
            // 
            this.rbBamboo.AutoSize = true;
            this.rbBamboo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBamboo.Location = new System.Drawing.Point(202, 64);
            this.rbBamboo.Name = "rbBamboo";
            this.rbBamboo.Size = new System.Drawing.Size(92, 24);
            this.rbBamboo.TabIndex = 4;
            this.rbBamboo.TabStop = true;
            this.rbBamboo.Text = "Bamboo";
            this.rbBamboo.UseVisualStyleBackColor = true;
            // 
            // rbLala
            // 
            this.rbLala.AutoSize = true;
            this.rbLala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLala.Location = new System.Drawing.Point(359, 64);
            this.rbLala.Name = "rbLala";
            this.rbLala.Size = new System.Drawing.Size(62, 24);
            this.rbLala.TabIndex = 5;
            this.rbLala.TabStop = true;
            this.rbLala.Text = "Lala";
            this.rbLala.UseVisualStyleBackColor = true;
            // 
            // PetsNameApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 282);
            this.Controls.Add(this.rbLala);
            this.Controls.Add(this.rbBamboo);
            this.Controls.Add(this.rbLucy);
            this.Controls.Add(this.btnDisplayPetsName);
            this.Controls.Add(this.btnExit);
            this.Name = "PetsNameApplication";
            this.Text = "Pet\'s Name Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDisplayPetsName;
        private System.Windows.Forms.RadioButton rbLucy;
        private System.Windows.Forms.RadioButton rbBamboo;
        private System.Windows.Forms.RadioButton rbLala;
    }
}

