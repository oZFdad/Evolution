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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.painBox = new System.Windows.Forms.PictureBox();
            this.btCheckPoint = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.lbState = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.painBox)).BeginInit();
            this.SuspendLayout();
            // 
            // painBox
            // 
            this.painBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.painBox.Location = new System.Drawing.Point(1, 1);
            this.painBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.painBox.Name = "painBox";
            this.painBox.Size = new System.Drawing.Size(1000, 1000);
            this.painBox.TabIndex = 0;
            this.painBox.TabStop = false;
            this.painBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btCheckPoint
            // 
            this.btCheckPoint.Location = new System.Drawing.Point(1038, 12);
            this.btCheckPoint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btCheckPoint.Name = "btCheckPoint";
            this.btCheckPoint.Size = new System.Drawing.Size(88, 27);
            this.btCheckPoint.TabIndex = 1;
            this.btCheckPoint.Text = "CheckPoint";
            this.btCheckPoint.UseVisualStyleBackColor = true;
            this.btCheckPoint.Click += new System.EventHandler(this.btCheckPoint_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(1038, 54);
            this.btStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(88, 45);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Заполнить поле";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(1038, 105);
            this.btNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(88, 50);
            this.btNext.TabIndex = 3;
            this.btNext.Text = "Старт симуляции";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // lbState
            // 
            this.lbState.Location = new System.Drawing.Point(1025, 180);
            this.lbState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(110, 201);
            this.lbState.TabIndex = 4;
            this.lbState.Text = "Information";
            // 
            // Evolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 993);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btCheckPoint);
            this.Controls.Add(this.painBox);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Evolution";
            this.Text = "Evolution";
            ((System.ComponentModel.ISupportInitialize) (this.painBox)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox painBox;
        private System.Windows.Forms.Button btCheckPoint;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Button btNext;
    }
}

