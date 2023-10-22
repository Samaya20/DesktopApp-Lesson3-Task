namespace Anket
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameTextBox = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            addButton = new Button();
            changeButton = new Button();
            birthDateTimePicker = new DateTimePicker();
            label5 = new Label();
            telephoneTextBox = new TextBox();
            label4 = new Label();
            emailTextBox = new TextBox();
            label3 = new Label();
            surnameTextBox = new TextBox();
            label2 = new Label();
            peopleListBox = new ListBox();
            saveBtn = new Button();
            loadBtn = new Button();
            fileNameTextBox = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(6, 51);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(237, 23);
            nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(39, 18);
            label1.TabIndex = 1;
            label1.Text = "Ad :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(changeButton);
            groupBox1.Controls.Add(birthDateTimePicker);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(telephoneTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(emailTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(surnameTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 389);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Anket";
            // 
            // addButton
            // 
            addButton.BackColor = Color.LimeGreen;
            addButton.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(127, 339);
            addButton.Name = "addButton";
            addButton.Size = new Size(116, 37);
            addButton.TabIndex = 12;
            addButton.Text = "Əlavə et";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // changeButton
            // 
            changeButton.BackColor = Color.RoyalBlue;
            changeButton.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            changeButton.ForeColor = Color.White;
            changeButton.Location = new Point(6, 339);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(115, 37);
            changeButton.TabIndex = 11;
            changeButton.Text = "Dəyiş";
            changeButton.UseVisualStyleBackColor = false;
            changeButton.Click += changeButton_Click;
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.Format = DateTimePickerFormat.Short;
            birthDateTimePicker.Location = new Point(6, 293);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(237, 23);
            birthDateTimePicker.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 267);
            label5.Name = "label5";
            label5.Size = new Size(115, 18);
            label5.TabIndex = 9;
            label5.Text = "Doğum tarixi :";
            // 
            // telephoneTextBox
            // 
            telephoneTextBox.Location = new Point(6, 226);
            telephoneTextBox.Name = "telephoneTextBox";
            telephoneTextBox.Size = new Size(237, 23);
            telephoneTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 205);
            label4.Name = "label4";
            label4.Size = new Size(71, 18);
            label4.TabIndex = 7;
            label4.Text = "Nömrə :";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(6, 167);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(237, 23);
            emailTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 146);
            label3.Name = "label3";
            label3.Size = new Size(59, 18);
            label3.TabIndex = 5;
            label3.Text = "Email :";
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(6, 108);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(237, 23);
            surnameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 87);
            label2.Name = "label2";
            label2.Size = new Size(67, 18);
            label2.TabIndex = 3;
            label2.Text = "Soyad :";
            // 
            // peopleListBox
            // 
            peopleListBox.ForeColor = SystemColors.ActiveCaptionText;
            peopleListBox.FormattingEnabled = true;
            peopleListBox.HorizontalScrollbar = true;
            peopleListBox.ItemHeight = 15;
            peopleListBox.Location = new Point(284, 21);
            peopleListBox.Name = "peopleListBox";
            peopleListBox.Size = new Size(221, 259);
            peopleListBox.TabIndex = 3;
            peopleListBox.SelectedIndexChanged += peopleListBox_SelectedIndexChanged;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Goldenrod;
            saveBtn.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(402, 351);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(103, 37);
            saveBtn.TabIndex = 14;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // loadBtn
            // 
            loadBtn.BackColor = Color.DarkSlateGray;
            loadBtn.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            loadBtn.ForeColor = Color.White;
            loadBtn.Location = new Point(284, 351);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(111, 37);
            loadBtn.TabIndex = 13;
            loadBtn.Text = "Load";
            loadBtn.UseVisualStyleBackColor = false;
            loadBtn.Click += loadBtn_Click;
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.Location = new Point(284, 322);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.Size = new Size(221, 23);
            fileNameTextBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(284, 301);
            label6.Name = "label6";
            label6.Size = new Size(87, 18);
            label6.TabIndex = 14;
            label6.Text = "Faylın adı :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 413);
            Controls.Add(fileNameTextBox);
            Controls.Add(label6);
            Controls.Add(saveBtn);
            Controls.Add(loadBtn);
            Controls.Add(peopleListBox);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox emailTextBox;
        private Label label3;
        private TextBox surnameTextBox;
        private Label label2;
        private DateTimePicker birthDateTimePicker;
        private Label label5;
        private TextBox telephoneTextBox;
        private Label label4;
        private Button addButton;
        private Button changeButton;
        private ListBox peopleListBox;
        private Button saveBtn;
        private Button loadBtn;
        private TextBox fileNameTextBox;
        private Label label6;
    }
}