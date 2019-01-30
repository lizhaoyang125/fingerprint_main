namespace Demo
{
    partial class Form_initial
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
            this.button_ToRegisterWindow = new System.Windows.Forms.Button();
            this.button_normalCard = new System.Windows.Forms.Button();
            this.button_qinzike = new System.Windows.Forms.Button();
            this.button_linshituo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_ToRegisterWindow
            // 
            this.button_ToRegisterWindow.Location = new System.Drawing.Point(189, 136);
            this.button_ToRegisterWindow.Name = "button_ToRegisterWindow";
            this.button_ToRegisterWindow.Size = new System.Drawing.Size(109, 42);
            this.button_ToRegisterWindow.TabIndex = 0;
            this.button_ToRegisterWindow.Text = "注册新学员";
            this.button_ToRegisterWindow.UseVisualStyleBackColor = true;
            this.button_ToRegisterWindow.Click += new System.EventHandler(this.button_ToRegisterWindow_Click);
            // 
            // button_normalCard
            // 
            this.button_normalCard.Location = new System.Drawing.Point(330, 136);
            this.button_normalCard.Name = "button_normalCard";
            this.button_normalCard.Size = new System.Drawing.Size(109, 42);
            this.button_normalCard.TabIndex = 1;
            this.button_normalCard.Text = "一般打卡";
            this.button_normalCard.UseVisualStyleBackColor = true;
            this.button_normalCard.Click += new System.EventHandler(this.button_normalCard_Click);
            // 
            // button_qinzike
            // 
            this.button_qinzike.Location = new System.Drawing.Point(189, 234);
            this.button_qinzike.Name = "button_qinzike";
            this.button_qinzike.Size = new System.Drawing.Size(109, 42);
            this.button_qinzike.TabIndex = 2;
            this.button_qinzike.Text = "亲子课打卡";
            this.button_qinzike.UseVisualStyleBackColor = true;
            // 
            // button_linshituo
            // 
            this.button_linshituo.Location = new System.Drawing.Point(330, 234);
            this.button_linshituo.Name = "button_linshituo";
            this.button_linshituo.Size = new System.Drawing.Size(109, 42);
            this.button_linshituo.TabIndex = 3;
            this.button_linshituo.Text = "临时托打卡";
            this.button_linshituo.UseVisualStyleBackColor = true;
            this.button_linshituo.Click += new System.EventHandler(this.button_linshituo_Click);
            // 
            // Form_initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_linshituo);
            this.Controls.Add(this.button_qinzike);
            this.Controls.Add(this.button_normalCard);
            this.Controls.Add(this.button_ToRegisterWindow);
            this.Name = "Form_initial";
            this.Text = "Form_initial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ToRegisterWindow;
        private System.Windows.Forms.Button button_normalCard;
        private System.Windows.Forms.Button button_qinzike;
        private System.Windows.Forms.Button button_linshituo;
    }
}