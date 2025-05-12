namespace odevList
{
    partial class formScreen
    {
        private System.ComponentModel.IContainer components = null;
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formScreen));
            textBox = new TextBox();
            addHead = new Button();
            label3 = new Label();
            addFirstBox = new TextBox();
            label4 = new Label();
            addLastBox = new TextBox();
            addLast = new Button();
            label6 = new Label();
            targetBox = new TextBox();
            label5 = new Label();
            addMiddleBox = new TextBox();
            addMiddle = new Button();
            label2 = new Label();
            deleteBox = new TextBox();
            deleteNode = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Enabled = false;
            textBox.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox.Location = new Point(235, 44);
            textBox.Margin = new Padding(3, 4, 3, 4);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(453, 221);
            textBox.TabIndex = 0;
            // 
            // addHead
            // 
            addHead.BackColor = SystemColors.AppWorkspace;
            addHead.ForeColor = Color.Crimson;
            addHead.Location = new Point(27, 104);
            addHead.Margin = new Padding(3, 4, 3, 4);
            addHead.Name = "addHead";
            addHead.Size = new Size(177, 39);
            addHead.TabIndex = 1;
            addHead.Text = "Ekle";
            addHead.UseVisualStyleBackColor = false;
            addHead.Click += addHead_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(12, 29);
            label3.Name = "label3";
            label3.Size = new Size(200, 20);
            label3.TabIndex = 7;
            label3.Text = "Başa Eklenecek Sayıyı Yazınız";
            label3.Click += label3_Click;
            // 
            // addFirstBox
            // 
            addFirstBox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            addFirstBox.Location = new Point(27, 53);
            addFirstBox.Margin = new Padding(3, 4, 3, 4);
            addFirstBox.Multiline = true;
            addFirstBox.Name = "addFirstBox";
            addFirstBox.Size = new Size(177, 41);
            addFirstBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Crimson;
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(703, 29);
            label4.Name = "label4";
            label4.Size = new Size(202, 20);
            label4.TabIndex = 8;
            label4.Text = "Sona Eklenecek Sayıyı Yazınız";
            // 
            // addLastBox
            // 
            addLastBox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            addLastBox.Location = new Point(714, 53);
            addLastBox.Margin = new Padding(3, 4, 3, 4);
            addLastBox.Multiline = true;
            addLastBox.Name = "addLastBox";
            addLastBox.Size = new Size(177, 41);
            addLastBox.TabIndex = 3;
            // 
            // addLast
            // 
            addLast.BackColor = SystemColors.AppWorkspace;
            addLast.ForeColor = Color.Crimson;
            addLast.Location = new Point(714, 102);
            addLast.Margin = new Padding(3, 4, 3, 4);
            addLast.Name = "addLast";
            addLast.Size = new Size(177, 39);
            addLast.TabIndex = 2;
            addLast.Text = "Ekle";
            addLast.UseVisualStyleBackColor = false;
            addLast.Click += addLast_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(634, 283);
            label6.Name = "label6";
            label6.Size = new Size(138, 20);
            label6.TabIndex = 13;
            label6.Text = "Hedef Sayıyı Giriniz";
            // 
            // targetBox
            // 
            targetBox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            targetBox.Location = new Point(615, 311);
            targetBox.Margin = new Padding(3, 4, 3, 4);
            targetBox.Multiline = true;
            targetBox.Name = "targetBox";
            targetBox.Size = new Size(177, 41);
            targetBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(379, 287);
            label5.Name = "label5";
            label5.Size = new Size(204, 20);
            label5.TabIndex = 9;
            label5.Text = "Araya Eklenecek Sayıyı Giriniz";
            label5.Click += label5_Click;
            // 
            // addMiddleBox
            // 
            addMiddleBox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            addMiddleBox.Location = new Point(393, 311);
            addMiddleBox.Margin = new Padding(3, 4, 3, 4);
            addMiddleBox.Multiline = true;
            addMiddleBox.Name = "addMiddleBox";
            addMiddleBox.Size = new Size(177, 41);
            addMiddleBox.TabIndex = 4;
            // 
            // addMiddle
            // 
            addMiddle.BackColor = SystemColors.AppWorkspace;
            addMiddle.ForeColor = Color.Crimson;
            addMiddle.Location = new Point(517, 361);
            addMiddle.Margin = new Padding(3, 4, 3, 4);
            addMiddle.Name = "addMiddle";
            addMiddle.Size = new Size(177, 39);
            addMiddle.TabIndex = 3;
            addMiddle.Text = "Ekle";
            addMiddle.UseVisualStyleBackColor = false;
            addMiddle.Click += addMiddle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(144, 283);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 6;
            label2.Text = "Silinecek Sayıyı Yazınız";
            // 
            // deleteBox
            // 
            deleteBox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            deleteBox.Location = new Point(135, 311);
            deleteBox.Margin = new Padding(3, 4, 3, 4);
            deleteBox.Multiline = true;
            deleteBox.Name = "deleteBox";
            deleteBox.Size = new Size(177, 41);
            deleteBox.TabIndex = 5;
            // 
            // deleteNode
            // 
            deleteNode.BackColor = SystemColors.AppWorkspace;
            deleteNode.ForeColor = Color.Crimson;
            deleteNode.Location = new Point(135, 361);
            deleteNode.Margin = new Padding(3, 4, 3, 4);
            deleteNode.Name = "deleteNode";
            deleteNode.Size = new Size(177, 39);
            deleteNode.TabIndex = 4;
            deleteNode.Text = "Sil";
            deleteNode.UseVisualStyleBackColor = false;
            deleteNode.Click += deleteNode_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonShadow;
            textBox1.ForeColor = Color.Crimson;
            textBox1.Location = new Point(766, 507);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 14;
            textBox1.Text = "Emirhan Şermet";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonShadow;
            textBox2.ForeColor = Color.Crimson;
            textBox2.Location = new Point(766, 540);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 15;
            textBox2.Text = "233908058";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.Blue;
            textBox3.Location = new Point(667, 507);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(93, 27);
            textBox3.TabIndex = 16;
            textBox3.Text = "Ad - Soyad=";
            // 
            // textBox4
            // 
            textBox4.ForeColor = Color.Blue;
            textBox4.Location = new Point(667, 540);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(93, 27);
            textBox4.TabIndex = 17;
            textBox4.Text = "Öğrenci No=";
            // 
            // formScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(937, 611);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(addFirstBox);
            Controls.Add(addHead);
            Controls.Add(addLastBox);
            Controls.Add(label6);
            Controls.Add(addLast);
            Controls.Add(label2);
            Controls.Add(targetBox);
            Controls.Add(label5);
            Controls.Add(addMiddleBox);
            Controls.Add(deleteBox);
            Controls.Add(addMiddle);
            Controls.Add(deleteNode);
            Controls.Add(textBox);
            ForeColor = Color.DarkGray;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "formScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emirhan Şermet";
            Load += formScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button addHead;
        private Button addLast;
        private Button addMiddle;
        private Button deleteNode;
        private TextBox addFirstBox;
        private Label label3;
        private Label label4;
        private TextBox addLastBox;
        private Label label5;
        private TextBox addMiddleBox;
        private Label label2;
        private TextBox deleteBox;
        private Label label6;
        private TextBox targetBox;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
