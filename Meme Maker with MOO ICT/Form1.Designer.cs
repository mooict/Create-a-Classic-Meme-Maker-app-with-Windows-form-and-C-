
namespace Meme_Maker_with_MOO_ICT
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTopTextBox = new System.Windows.Forms.TextBox();
            this.txtBottomTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.imgPreview = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTopText = new System.Windows.Forms.Label();
            this.lblBottomText = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtBottomTextBox);
            this.groupBox1.Controls.Add(this.txtTopTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Texts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bottom Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Change Colour";
            // 
            // txtTopTextBox
            // 
            this.txtTopTextBox.Location = new System.Drawing.Point(25, 58);
            this.txtTopTextBox.Multiline = true;
            this.txtTopTextBox.Name = "txtTopTextBox";
            this.txtTopTextBox.Size = new System.Drawing.Size(369, 70);
            this.txtTopTextBox.TabIndex = 3;
            this.txtTopTextBox.TextChanged += new System.EventHandler(this.ChangeTopText);
            // 
            // txtBottomTextBox
            // 
            this.txtBottomTextBox.Location = new System.Drawing.Point(25, 180);
            this.txtBottomTextBox.Multiline = true;
            this.txtBottomTextBox.Name = "txtBottomTextBox";
            this.txtBottomTextBox.Size = new System.Drawing.Size(369, 70);
            this.txtBottomTextBox.TabIndex = 4;
            this.txtBottomTextBox.TextChanged += new System.EventHandler(this.ChangeBottomText);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(28, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 32);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ChangeTextColour);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(70, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 32);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ChangeTextColour);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(112, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 32);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ChangeTextColour);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(28, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 32);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ChangeTextColour);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Fuchsia;
            this.button5.Location = new System.Drawing.Point(70, 371);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 32);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ChangeTextColour);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button6.Location = new System.Drawing.Point(112, 371);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 32);
            this.button6.TabIndex = 10;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ChangeTextColour);
            // 
            // imgPreview
            // 
            this.imgPreview.BackColor = System.Drawing.Color.Black;
            this.imgPreview.Location = new System.Drawing.Point(423, 31);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(423, 449);
            this.imgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPreview.TabIndex = 1;
            this.imgPreview.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(188, 510);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(122, 74);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.OpenImage);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(524, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 74);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveImage);
            // 
            // lblTopText
            // 
            this.lblTopText.BackColor = System.Drawing.Color.Transparent;
            this.lblTopText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopText.ForeColor = System.Drawing.Color.White;
            this.lblTopText.Location = new System.Drawing.Point(423, 31);
            this.lblTopText.Name = "lblTopText";
            this.lblTopText.Size = new System.Drawing.Size(423, 87);
            this.lblTopText.TabIndex = 4;
            this.lblTopText.Text = "Sample Top Text";
            this.lblTopText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBottomText
            // 
            this.lblBottomText.BackColor = System.Drawing.Color.Transparent;
            this.lblBottomText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottomText.ForeColor = System.Drawing.Color.White;
            this.lblBottomText.Location = new System.Drawing.Point(423, 401);
            this.lblBottomText.Name = "lblBottomText";
            this.lblBottomText.Size = new System.Drawing.Size(423, 79);
            this.lblBottomText.TabIndex = 5;
            this.lblBottomText.Text = "Sample Bottom Text";
            this.lblBottomText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 611);
            this.Controls.Add(this.lblBottomText);
            this.Controls.Add(this.lblTopText);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.imgPreview);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Meme Maker with MOO ICT";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBottomTextBox;
        private System.Windows.Forms.TextBox txtTopTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imgPreview;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTopText;
        private System.Windows.Forms.Label lblBottomText;
    }
}

