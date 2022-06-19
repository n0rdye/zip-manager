namespace WindowsFormsApp18
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.распаковатьВToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.архивироватьПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбраноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбраныеПапкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имяПапкиToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.питьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.состояниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.состояниеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listView2 = new System.Windows.Forms.ListView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 120);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(569, 329);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView1_ItemDrag);
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            this.listView1.DragLeave += new System.EventHandler(this.listView1_DragLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.питьToolStripMenuItem,
            this.состояниеToolStripMenuItem,
            this.состояниеToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.распаковатьВToolStripMenuItem,
            this.архивироватьПапкуToolStripMenuItem,
            this.удалитьВыбраноеToolStripMenuItem,
            this.удалитьВыбраныеПапкиToolStripMenuItem,
            this.добавитьПапкуToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.менюToolStripMenuItem.Text = "меню";
            // 
            // распаковатьВToolStripMenuItem
            // 
            this.распаковатьВToolStripMenuItem.Name = "распаковатьВToolStripMenuItem";
            this.распаковатьВToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.распаковатьВToolStripMenuItem.Text = "распаковать в>";
            this.распаковатьВToolStripMenuItem.Click += new System.EventHandler(this.распаковатьВToolStripMenuItem_Click);
            // 
            // архивироватьПапкуToolStripMenuItem
            // 
            this.архивироватьПапкуToolStripMenuItem.Name = "архивироватьПапкуToolStripMenuItem";
            this.архивироватьПапкуToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.архивироватьПапкуToolStripMenuItem.Text = "архивировать папку";
            this.архивироватьПапкуToolStripMenuItem.Click += new System.EventHandler(this.архивироватьПапкуToolStripMenuItem_Click);
            // 
            // удалитьВыбраноеToolStripMenuItem
            // 
            this.удалитьВыбраноеToolStripMenuItem.Name = "удалитьВыбраноеToolStripMenuItem";
            this.удалитьВыбраноеToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.удалитьВыбраноеToolStripMenuItem.Text = "удалить выбраные файлы";
            this.удалитьВыбраноеToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыбраноеToolStripMenuItem_Click);
            // 
            // удалитьВыбраныеПапкиToolStripMenuItem
            // 
            this.удалитьВыбраныеПапкиToolStripMenuItem.Name = "удалитьВыбраныеПапкиToolStripMenuItem";
            this.удалитьВыбраныеПапкиToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.удалитьВыбраныеПапкиToolStripMenuItem.Text = "удалить выбраные папки";
            this.удалитьВыбраныеПапкиToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыбраныеПапкиToolStripMenuItem_Click);
            // 
            // добавитьПапкуToolStripMenuItem
            // 
            this.добавитьПапкуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.имяПапкиToolStripMenuItem});
            this.добавитьПапкуToolStripMenuItem.Name = "добавитьПапкуToolStripMenuItem";
            this.добавитьПапкуToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.добавитьПапкуToolStripMenuItem.Text = "добавить папку";
            this.добавитьПапкуToolStripMenuItem.Click += new System.EventHandler(this.добавитьПапкуToolStripMenuItem_Click);
            // 
            // имяПапкиToolStripMenuItem
            // 
            this.имяПапкиToolStripMenuItem.Name = "имяПапкиToolStripMenuItem";
            this.имяПапкиToolStripMenuItem.Size = new System.Drawing.Size(180, 23);
            this.имяПапкиToolStripMenuItem.Text = "имя папки";
            // 
            // питьToolStripMenuItem
            // 
            this.питьToolStripMenuItem.Name = "питьToolStripMenuItem";
            this.питьToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // состояниеToolStripMenuItem
            // 
            this.состояниеToolStripMenuItem.Name = "состояниеToolStripMenuItem";
            this.состояниеToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.состояниеToolStripMenuItem.Text = "состояние -";
            // 
            // состояниеToolStripMenuItem1
            // 
            this.состояниеToolStripMenuItem1.Name = "состояниеToolStripMenuItem1";
            this.состояниеToolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.состояниеToolStripMenuItem1.Text = "*";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(0, 27);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(569, 93);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Tile;
            this.listView2.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "arc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem состояниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem состояниеToolStripMenuItem1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ToolStripMenuItem распаковатьВToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem архивироватьПапкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem питьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбраноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбраныеПапкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПапкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox имяПапкиToolStripMenuItem;
    }
}

