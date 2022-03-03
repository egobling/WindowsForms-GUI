
namespace Wforms_GUI_
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
            this.buttonTHE = new System.Windows.Forms.Button();
            this.BIGbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Link_YES = new System.Windows.Forms.LinkLabel();
            this.The_word = new System.Windows.Forms.Label();
            this.BoBPpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BoBPpic)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTHE
            // 
            this.buttonTHE.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTHE.Location = new System.Drawing.Point(209, 385);
            this.buttonTHE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTHE.Name = "buttonTHE";
            this.buttonTHE.Size = new System.Drawing.Size(100, 28);
            this.buttonTHE.TabIndex = 3;
            this.buttonTHE.Text = "BOB!";
            this.buttonTHE.UseVisualStyleBackColor = true;
            this.buttonTHE.Click += new System.EventHandler(this.babaB_Click);
            // 
            // BIGbox
            // 
            this.BIGbox.BackColor = System.Drawing.Color.White;
            this.BIGbox.Location = new System.Drawing.Point(20, 361);
            this.BIGbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BIGbox.Name = "BIGbox";
            this.BIGbox.Size = new System.Drawing.Size(148, 52);
            this.BIGbox.TabIndex = 4;
            this.BIGbox.Text = "THE BOB HAS SPOKEN ";
            this.BIGbox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "BOB";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Link_YES
            // 
            this.Link_YES.AutoSize = true;
            this.Link_YES.BackColor = System.Drawing.Color.Transparent;
            this.Link_YES.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_YES.LinkColor = System.Drawing.Color.Lime;
            this.Link_YES.Location = new System.Drawing.Point(535, 95);
            this.Link_YES.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Link_YES.Name = "Link_YES";
            this.Link_YES.Size = new System.Drawing.Size(37, 19);
            this.Link_YES.TabIndex = 7;
            this.Link_YES.TabStop = true;
            this.Link_YES.Text = "YES";
            this.Link_YES.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_YES_YES);
            // 
            // The_word
            // 
            this.The_word.AutoSize = true;
            this.The_word.BackColor = System.Drawing.Color.White;
            this.The_word.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.The_word.Location = new System.Drawing.Point(317, 95);
            this.The_word.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.The_word.Name = "The_word";
            this.The_word.Size = new System.Drawing.Size(188, 19);
            this.The_word.TabIndex = 8;
            this.The_word.Text = "This is the word of the bob!";
            // 
            // BoBPpic
            // 
            this.BoBPpic.BackColor = System.Drawing.Color.Transparent;
            this.BoBPpic.Image = global::Wforms_GUI_.Properties.Resources.cayta;
            this.BoBPpic.Location = new System.Drawing.Point(16, 74);
            this.BoBPpic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoBPpic.Name = "BoBPpic";
            this.BoBPpic.Size = new System.Drawing.Size(226, 227);
            this.BoBPpic.TabIndex = 2;
            this.BoBPpic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::Wforms_GUI_.Properties.Resources.catpope;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1059, 501);
            this.Controls.Add(this.The_word);
            this.Controls.Add(this.Link_YES);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BIGbox);
            this.Controls.Add(this.buttonTHE);
            this.Controls.Add(this.BoBPpic);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "BoX";
            ((System.ComponentModel.ISupportInitialize)(this.BoBPpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox BoBPpic;
        private System.Windows.Forms.Button buttonTHE;
        private System.Windows.Forms.RichTextBox BIGbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Link_YES;
        private System.Windows.Forms.Label The_word;
    }
}

