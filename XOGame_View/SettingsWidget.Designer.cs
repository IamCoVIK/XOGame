namespace XOGame_View
{
    partial class SettingsWidget
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
            this.label_path = new System.Windows.Forms.Label();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.label_size = new System.Windows.Forms.Label();
            this.textBox_size = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Location = new System.Drawing.Point(12, 9);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(34, 13);
            this.label_path.TabIndex = 0;
            this.label_path.Text = "Путь:";
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(12, 25);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(226, 20);
            this.textBox_path.TabIndex = 1;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(12, 115);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(226, 34);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(12, 61);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(148, 13);
            this.label_size.TabIndex = 0;
            this.label_size.Text = "Размер поля (формат NxN):";
            // 
            // textBox_size
            // 
            this.textBox_size.Location = new System.Drawing.Point(12, 77);
            this.textBox_size.Name = "textBox_size";
            this.textBox_size.Size = new System.Drawing.Size(226, 20);
            this.textBox_size.TabIndex = 1;
            this.textBox_size.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_size_Validating);
            // 
            // SettingsWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 161);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.textBox_size);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.label_path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWidget";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.TextBox textBox_size;
    }
}