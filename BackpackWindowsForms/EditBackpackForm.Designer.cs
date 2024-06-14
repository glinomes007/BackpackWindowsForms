namespace BackpackWindowsForms
{
    partial class EditBackpackForm
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Approve = new System.Windows.Forms.Button();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.ShapeComboBox = new System.Windows.Forms.ComboBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.ShapeLabel = new System.Windows.Forms.Label();
            this.TagLabel = new System.Windows.Forms.Label();
            this.TagTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(158, 209);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(81, 34);
            this.Cancel.TabIndex = 29;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Approve
            // 
            this.Approve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Approve.Location = new System.Drawing.Point(245, 209);
            this.Approve.Name = "Approve";
            this.Approve.Size = new System.Drawing.Size(75, 34);
            this.Approve.TabIndex = 28;
            this.Approve.Text = "Ок";
            this.Approve.UseVisualStyleBackColor = true;
            this.Approve.Click += new System.EventHandler(this.Approve_Click);
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(118, 166);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(202, 28);
            this.ColorComboBox.TabIndex = 27;
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Location = new System.Drawing.Point(118, 118);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(202, 28);
            this.MaterialComboBox.TabIndex = 26;
            // 
            // ShapeComboBox
            // 
            this.ShapeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShapeComboBox.FormattingEnabled = true;
            this.ShapeComboBox.Location = new System.Drawing.Point(118, 68);
            this.ShapeComboBox.Name = "ShapeComboBox";
            this.ShapeComboBox.Size = new System.Drawing.Size(202, 28);
            this.ShapeComboBox.TabIndex = 25;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorLabel.Location = new System.Drawing.Point(10, 174);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(56, 20);
            this.ColorLabel.TabIndex = 24;
            this.ColorLabel.Text = "Цвет: ";
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaterialLabel.Location = new System.Drawing.Point(10, 121);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(94, 20);
            this.MaterialLabel.TabIndex = 23;
            this.MaterialLabel.Text = "Материал: ";
            // 
            // ShapeLabel
            // 
            this.ShapeLabel.AutoSize = true;
            this.ShapeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShapeLabel.Location = new System.Drawing.Point(10, 71);
            this.ShapeLabel.Name = "ShapeLabel";
            this.ShapeLabel.Size = new System.Drawing.Size(44, 20);
            this.ShapeLabel.TabIndex = 22;
            this.ShapeLabel.Text = "Тип: ";
            // 
            // TagLabel
            // 
            this.TagLabel.AutoSize = true;
            this.TagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TagLabel.Location = new System.Drawing.Point(10, 24);
            this.TagLabel.Name = "TagLabel";
            this.TagLabel.Size = new System.Drawing.Size(84, 20);
            this.TagLabel.TabIndex = 21;
            this.TagLabel.Text = "Подпись: ";
            // 
            // TagTextBox
            // 
            this.TagTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TagTextBox.Location = new System.Drawing.Point(118, 21);
            this.TagTextBox.Name = "TagTextBox";
            this.TagTextBox.Size = new System.Drawing.Size(202, 26);
            this.TagTextBox.TabIndex = 20;
            // 
            // EditBackpackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 255);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Approve);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.ShapeComboBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.ShapeLabel);
            this.Controls.Add(this.TagLabel);
            this.Controls.Add(this.TagTextBox);
            this.MaximumSize = new System.Drawing.Size(348, 294);
            this.MinimumSize = new System.Drawing.Size(348, 294);
            this.Name = "EditBackpackForm";
            this.Text = "EditBackpackForm";
            this.Load += new System.EventHandler(this.EditBackpackForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Approve;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.ComboBox ShapeComboBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.Label ShapeLabel;
        private System.Windows.Forms.Label TagLabel;
        private System.Windows.Forms.TextBox TagTextBox;
    }
}