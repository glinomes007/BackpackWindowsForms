namespace BackpackWindowsForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackpackList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ByPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ByShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ByMateraialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ByColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ByTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackpackList
            // 
            this.BackpackList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackpackList.FormattingEnabled = true;
            this.BackpackList.ItemHeight = 20;
            this.BackpackList.Location = new System.Drawing.Point(0, 27);
            this.BackpackList.Name = "BackpackList";
            this.BackpackList.Size = new System.Drawing.Size(800, 424);
            this.BackpackList.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ProductToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.SortByToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddToolStripMenuItem.Text = "Добавить";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // SortByToolStripMenuItem
            // 
            this.SortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ByPriceToolStripMenuItem,
            this.ByShapeToolStripMenuItem,
            this.ByMateraialToolStripMenuItem,
            this.ByColorToolStripMenuItem1,
            this.ByTagToolStripMenuItem});
            this.SortByToolStripMenuItem.Name = "SortByToolStripMenuItem";
            this.SortByToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SortByToolStripMenuItem.Text = "Сортировать по";
            // 
            // ByPriceToolStripMenuItem
            // 
            this.ByPriceToolStripMenuItem.Name = "ByPriceToolStripMenuItem";
            this.ByPriceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ByPriceToolStripMenuItem.Text = "Цене";
            this.ByPriceToolStripMenuItem.Click += new System.EventHandler(this.ByPriceToolStripMenuItem_Click);
            // 
            // ByShapeToolStripMenuItem
            // 
            this.ByShapeToolStripMenuItem.Name = "ByShapeToolStripMenuItem";
            this.ByShapeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ByShapeToolStripMenuItem.Text = "Типу";
            this.ByShapeToolStripMenuItem.Click += new System.EventHandler(this.ByShapeToolStripMenuItem_Click);
            // 
            // ByMateraialToolStripMenuItem
            // 
            this.ByMateraialToolStripMenuItem.Name = "ByMateraialToolStripMenuItem";
            this.ByMateraialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ByMateraialToolStripMenuItem.Text = "Материалу";
            this.ByMateraialToolStripMenuItem.Click += new System.EventHandler(this.ByMateraialToolStripMenuItem_Click);
            // 
            // ByColorToolStripMenuItem1
            // 
            this.ByColorToolStripMenuItem1.Name = "ByColorToolStripMenuItem1";
            this.ByColorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ByColorToolStripMenuItem1.Text = "Цвету";
            this.ByColorToolStripMenuItem1.Click += new System.EventHandler(this.ByColorToolStripMenuItem1_Click);
            // 
            // ByTagToolStripMenuItem
            // 
            this.ByTagToolStripMenuItem.Name = "ByTagToolStripMenuItem";
            this.ByTagToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ByTagToolStripMenuItem.Text = "Подписи";
            this.ByTagToolStripMenuItem.Click += new System.EventHandler(this.ByTagToolStripMenuItem_Click);
            // 
            // ProductToolStripMenuItem
            // 
            this.ProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem";
            this.ProductToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ProductToolStripMenuItem.Text = "Товар";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EditToolStripMenuItem.Text = "Редактировать";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BackpackList);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox BackpackList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ByPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ByShapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ByMateraialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ByColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ByTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
    }
}

