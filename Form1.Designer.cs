namespace janshi_Separate
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Member_Box = new System.Windows.Forms.TextBox();
            this.Result_box = new System.Windows.Forms.TextBox();
            this.Run_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seed_label = new System.Windows.Forms.Label();
            this.Seed_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Member_Box
            // 
            this.Member_Box.Location = new System.Drawing.Point(14, 24);
            this.Member_Box.Multiline = true;
            this.Member_Box.Name = "Member_Box";
            this.Member_Box.Size = new System.Drawing.Size(206, 297);
            this.Member_Box.TabIndex = 0;
            // 
            // Result_box
            // 
            this.Result_box.Location = new System.Drawing.Point(424, 24);
            this.Result_box.Multiline = true;
            this.Result_box.Name = "Result_box";
            this.Result_box.Size = new System.Drawing.Size(392, 297);
            this.Result_box.TabIndex = 1;
            // 
            // Run_button
            // 
            this.Run_button.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Run_button.Location = new System.Drawing.Point(226, 148);
            this.Run_button.Name = "Run_button";
            this.Run_button.Size = new System.Drawing.Size(190, 85);
            this.Run_button.TabIndex = 2;
            this.Run_button.Text = "-->分ける-->";
            this.Run_button.UseVisualStyleBackColor = true;
            this.Run_button.Click += new System.EventHandler(this.Run_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "メンバー（改行で分ける）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "結果";
            // 
            // seed_label
            // 
            this.seed_label.AutoSize = true;
            this.seed_label.Location = new System.Drawing.Point(227, 63);
            this.seed_label.Name = "seed_label";
            this.seed_label.Size = new System.Drawing.Size(42, 12);
            this.seed_label.TabIndex = 5;
            this.seed_label.Text = "Seed値";
            // 
            // Seed_box
            // 
            this.Seed_box.Location = new System.Drawing.Point(229, 79);
            this.Seed_box.MaxLength = 64;
            this.Seed_box.Name = "Seed_box";
            this.Seed_box.Size = new System.Drawing.Size(187, 19);
            this.Seed_box.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 332);
            this.Controls.Add(this.Seed_box);
            this.Controls.Add(this.seed_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Run_button);
            this.Controls.Add(this.Result_box);
            this.Controls.Add(this.Member_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "麻雀のメンバーをいい感じに分けるやつ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Member_Box;
        private System.Windows.Forms.TextBox Result_box;
        private System.Windows.Forms.Button Run_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label seed_label;
        private System.Windows.Forms.TextBox Seed_box;
    }
}

