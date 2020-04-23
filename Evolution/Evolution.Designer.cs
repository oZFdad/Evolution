namespace Evolution
{
    partial class Evolution
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
            this.painBox = new System.Windows.Forms.PictureBox();
            this.btCheckPoint = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.painBox)).BeginInit();
            this.SuspendLayout();
            // 
            // painBox
            // 
            this.painBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painBox.Location = new System.Drawing.Point(1, 1);
            this.painBox.Name = "painBox";
            this.painBox.Size = new System.Drawing.Size(801, 801);
            this.painBox.TabIndex = 0;
            this.painBox.TabStop = false;
            this.painBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btCheckPoint
            // 
            this.btCheckPoint.Location = new System.Drawing.Point(854, 41);
            this.btCheckPoint.Name = "btCheckPoint";
            this.btCheckPoint.Size = new System.Drawing.Size(75, 23);
            this.btCheckPoint.TabIndex = 1;
            this.btCheckPoint.Text = "CheckPoint";
            this.btCheckPoint.UseVisualStyleBackColor = true;
            this.btCheckPoint.Click += new System.EventHandler(this.btCheckPoint_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(854, 81);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(854, 111);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 3;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // Evolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 861);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btCheckPoint);
            this.Controls.Add(this.painBox);
            this.Name = "Evolution";
            this.Text = "Evolution";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Evolution_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.painBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox painBox;
        private System.Windows.Forms.Button btCheckPoint;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btNext;
    }
}

