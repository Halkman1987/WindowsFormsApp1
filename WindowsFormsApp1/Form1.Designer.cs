﻿namespace WindowsFormsApp1
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
            this.btnClickThis = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.pct = new System.Windows.Forms.PictureBox();
            this.pctLineXY = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLineXY)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.Location = new System.Drawing.Point(545, 12);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(243, 96);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "ClickThis";
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(621, 166);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(29, 13);
            this.lblHelloWorld.TabIndex = 1;
            this.lblHelloWorld.Text = "label";
            this.lblHelloWorld.Click += new System.EventHandler(this.lblHelloWorld_Click);
            // 
            // pct
            // 
            this.pct.Location = new System.Drawing.Point(29, 29);
            this.pct.Name = "pct";
            this.pct.Size = new System.Drawing.Size(422, 340);
            this.pct.TabIndex = 2;
            this.pct.TabStop = false;
            this.pct.Click += new System.EventHandler(this.pct_Click);
            // 
            // pctLineXY
            // 
            this.pctLineXY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctLineXY.Location = new System.Drawing.Point(61, 44);
            this.pctLineXY.Name = "pctLineXY";
            this.pctLineXY.Size = new System.Drawing.Size(350, 281);
            this.pctLineXY.TabIndex = 2;
            this.pctLineXY.TabStop = false;
            this.pctLineXY.Click += new System.EventHandler(this.pctLineXY_Click);
            this.pctLineXY.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pctLineXY_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctLineXY);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnClickThis);
            this.Name = "Form1";
            this.Text = "Название Первой Программы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLineXY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.PictureBox pct;
        private System.Windows.Forms.PictureBox pctLineXY;
    }
}

