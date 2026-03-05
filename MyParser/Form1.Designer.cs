using System;

namespace Parserr
{
    partial class GoBack2
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
            this.GoOver = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listViewBooks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Next = new System.Windows.Forms.Button();
            this.Before = new System.Windows.Forms.Button();
            this.CountBooks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GoOver
            // 
            this.GoOver.BackColor = System.Drawing.Color.White;
            this.GoOver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GoOver.FlatAppearance.BorderSize = 0;
            this.GoOver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GoOver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GoOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoOver.Location = new System.Drawing.Point(289, 553);
            this.GoOver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GoOver.Name = "GoOver";
            this.GoOver.Size = new System.Drawing.Size(216, 36);
            this.GoOver.TabIndex = 2;
            this.GoOver.Text = "Найти книгу";
            this.GoOver.UseVisualStyleBackColor = false;
            this.GoOver.Click += new System.EventHandler(this.GoOver_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(480, 13);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // listViewBooks
            // 
            this.listViewBooks.BackColor = System.Drawing.SystemColors.Info;
            this.listViewBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewBooks.FullRowSelect = true;
            this.listViewBooks.HideSelection = false;
            this.listViewBooks.Location = new System.Drawing.Point(32, 45);
            this.listViewBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewBooks.Name = "listViewBooks";
            this.listViewBooks.Size = new System.Drawing.Size(720, 491);
            this.listViewBooks.TabIndex = 14;
            this.listViewBooks.UseCompatibleStateImageBehavior = false;
            this.listViewBooks.View = System.Windows.Forms.View.Details;
            this.listViewBooks.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewBooks_ColumnClick);
            this.listViewBooks.ItemActivate += new System.EventHandler(this.listViewBooks_ItemActivate_1);
            this.listViewBooks.SelectedIndexChanged += new System.EventHandler(this.listViewBooks_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Заголовок";
            this.columnHeader1.Width = 113;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Автор";
            this.columnHeader2.Width = 139;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Оценка";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата выхода";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Цена";
            this.columnHeader5.Width = 100;
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.White;
            this.Next.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Next.FlatAppearance.BorderSize = 0;
            this.Next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next.Location = new System.Drawing.Point(525, 554);
            this.Next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(213, 37);
            this.Next.TabIndex = 16;
            this.Next.Text = "Следующая страница";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Before
            // 
            this.Before.BackColor = System.Drawing.Color.White;
            this.Before.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Before.FlatAppearance.BorderSize = 0;
            this.Before.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Before.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Before.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Before.Location = new System.Drawing.Point(18, 552);
            this.Before.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Before.Name = "Before";
            this.Before.Size = new System.Drawing.Size(251, 37);
            this.Before.TabIndex = 17;
            this.Before.Text = "Предыдущая страница";
            this.Before.UseVisualStyleBackColor = false;
            this.Before.Click += new System.EventHandler(this.Before_Click);
            // 
            // CountBooks
            // 
            this.CountBooks.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CountBooks.Location = new System.Drawing.Point(100, 13);
            this.CountBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CountBooks.Name = "CountBooks";
            this.CountBooks.Size = new System.Drawing.Size(343, 22);
            this.CountBooks.TabIndex = 18;
            // 
            // GoBack2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(778, 602);
            this.Controls.Add(this.CountBooks);
            this.Controls.Add(this.Before);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.listViewBooks);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GoOver);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GoBack2";
            this.Text = "Amazon";
            this.Load += new System.EventHandler(this.GoBack2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GoOver;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listViewBooks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Before;
        private System.Windows.Forms.TextBox CountBooks;
    }
}



