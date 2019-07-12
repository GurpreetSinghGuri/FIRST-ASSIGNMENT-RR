namespace FIRST_ASSIGNMENT_RR
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_spin = new System.Windows.Forms.Button();
            this.btn_shoot_away = new System.Windows.Forms.Button();
            this.btn_shoot = new System.Windows.Forms.Button();
            this.btn_play_again = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pic_box_main = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.victoryIndicatorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_main)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.Color.Yellow;
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.Location = new System.Drawing.Point(16, 17);
            this.btn_load.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(94, 56);
            this.btn_load.TabIndex = 0;
            this.btn_load.Text = "LOAD";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.Btn_load_Click);
            // 
            // btn_spin
            // 
            this.btn_spin.BackColor = System.Drawing.Color.Yellow;
            this.btn_spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btn_spin.Location = new System.Drawing.Point(136, 17);
            this.btn_spin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(98, 56);
            this.btn_spin.TabIndex = 1;
            this.btn_spin.Text = "SPIN";
            this.btn_spin.UseVisualStyleBackColor = false;
            this.btn_spin.Click += new System.EventHandler(this.Btn_spin_Click);
            // 
            // btn_shoot_away
            // 
            this.btn_shoot_away.BackColor = System.Drawing.Color.Yellow;
            this.btn_shoot_away.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btn_shoot_away.Location = new System.Drawing.Point(16, 115);
            this.btn_shoot_away.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_shoot_away.Name = "btn_shoot_away";
            this.btn_shoot_away.Size = new System.Drawing.Size(94, 56);
            this.btn_shoot_away.TabIndex = 2;
            this.btn_shoot_away.Text = "SHOOT AWAY";
            this.btn_shoot_away.UseVisualStyleBackColor = false;
            this.btn_shoot_away.Click += new System.EventHandler(this.Btn_shoot_away_Click);
            // 
            // btn_shoot
            // 
            this.btn_shoot.BackColor = System.Drawing.Color.Yellow;
            this.btn_shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btn_shoot.Location = new System.Drawing.Point(136, 115);
            this.btn_shoot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_shoot.Name = "btn_shoot";
            this.btn_shoot.Size = new System.Drawing.Size(98, 56);
            this.btn_shoot.TabIndex = 3;
            this.btn_shoot.Text = "SHOOT";
            this.btn_shoot.UseVisualStyleBackColor = false;
            this.btn_shoot.Click += new System.EventHandler(this.Btn_shoot_Click);
            // 
            // btn_play_again
            // 
            this.btn_play_again.BackColor = System.Drawing.Color.Yellow;
            this.btn_play_again.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btn_play_again.Location = new System.Drawing.Point(16, 211);
            this.btn_play_again.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_play_again.Name = "btn_play_again";
            this.btn_play_again.Size = new System.Drawing.Size(94, 56);
            this.btn_play_again.TabIndex = 4;
            this.btn_play_again.Text = "PLAY AGAIN";
            this.btn_play_again.UseVisualStyleBackColor = false;
            this.btn_play_again.Click += new System.EventHandler(this.Btn_play_again_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Yellow;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btn_exit.Location = new System.Drawing.Point(136, 211);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(98, 56);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit);
            // 
            // pic_box_main
            // 
            this.pic_box_main.Image = global::FIRST_ASSIGNMENT_RR.Properties.Resources.backy;
            this.pic_box_main.Location = new System.Drawing.Point(449, 50);
            this.pic_box_main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_box_main.Name = "pic_box_main";
            this.pic_box_main.Size = new System.Drawing.Size(392, 280);
            this.pic_box_main.TabIndex = 6;
            this.pic_box_main.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // victoryIndicatorLabel
            // 
            this.victoryIndicatorLabel.AutoSize = true;
            this.victoryIndicatorLabel.BackColor = System.Drawing.Color.Transparent;
            this.victoryIndicatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victoryIndicatorLabel.ForeColor = System.Drawing.Color.Transparent;
            this.victoryIndicatorLabel.Location = new System.Drawing.Point(449, 9);
            this.victoryIndicatorLabel.Name = "victoryIndicatorLabel";
            this.victoryIndicatorLabel.Size = new System.Drawing.Size(218, 31);
            this.victoryIndicatorLabel.TabIndex = 8;
            this.victoryIndicatorLabel.Text = "Victory Indicator:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(850, 372);
            this.Controls.Add(this.victoryIndicatorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_box_main);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_play_again);
            this.Controls.Add(this.btn_shoot);
            this.Controls.Add(this.btn_shoot_away);
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.btn_load);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.Button btn_shoot_away;
        private System.Windows.Forms.Button btn_play_again;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_shoot;
        private System.Windows.Forms.PictureBox pic_box_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label victoryIndicatorLabel;
    }
}

