namespace WinFormsApp1
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
            addAddandPopulateButton = new Button();
            addNumberTextBox = new TextBox();
            addCheckedListBox = new CheckedListBox();
            addListBox = new ListBox();
            addClear = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // addAddandPopulateButton
            // 
            addAddandPopulateButton.Location = new Point(12, 12);
            addAddandPopulateButton.Name = "addAddandPopulateButton";
            addAddandPopulateButton.Size = new Size(112, 34);
            addAddandPopulateButton.TabIndex = 0;
            addAddandPopulateButton.Text = "1";
            addAddandPopulateButton.UseVisualStyleBackColor = true;
            addAddandPopulateButton.Click += addAddandPopulateButton_Click;
            // 
            // addNumberTextBox
            // 
            addNumberTextBox.Location = new Point(130, 15);
            addNumberTextBox.Name = "addNumberTextBox";
            addNumberTextBox.Size = new Size(658, 31);
            addNumberTextBox.TabIndex = 1;
            addNumberTextBox.TextChanged += addNumberTextBox_TextChanged;
            addNumberTextBox.KeyPress += addNumberTextBox_KeyPress;
            // 
            // addCheckedListBox
            // 
            addCheckedListBox.FormattingEnabled = true;
            addCheckedListBox.Location = new Point(12, 63);
            addCheckedListBox.Name = "addCheckedListBox";
            addCheckedListBox.Size = new Size(180, 368);
            addCheckedListBox.TabIndex = 2;
            addCheckedListBox.ItemCheck += addCheckedItemOnCheckBox;
            addCheckedListBox.SelectedIndexChanged += addCheckedListBox_SelectedIndexChanged;
            // 
            // addListBox
            // 
            addListBox.FormattingEnabled = true;
            addListBox.ItemHeight = 25;
            addListBox.Location = new Point(198, 52);
            addListBox.Name = "addListBox";
            addListBox.Size = new Size(590, 379);
            addListBox.TabIndex = 3;
            addListBox.SelectedIndexChanged += addListBox_SelectedIndexChanged;
            // 
            // addClear
            // 
            addClear.Location = new Point(608, 484);
            addClear.Name = "addClear";
            addClear.Size = new Size(180, 46);
            addClear.TabIndex = 4;
            addClear.Text = "clear";
            addClear.UseVisualStyleBackColor = true;
            addClear.Click += addClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 455);
            label1.Name = "label1";
            label1.Size = new Size(373, 25);
            label1.TabIndex = 5;
            label1.Text = "button amplfies, list boxes hold and compute";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 496);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "sort";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(130, 496);
            button2.Name = "button2";
            button2.Size = new Size(116, 34);
            button2.TabIndex = 7;
            button2.Text = "count";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 496);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 542);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(addClear);
            Controls.Add(addListBox);
            Controls.Add(addCheckedListBox);
            Controls.Add(addNumberTextBox);
            Controls.Add(addAddandPopulateButton);
            Name = "Form1";
            Text = "Add thingamabob";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addAddandPopulateButton;
        private TextBox addNumberTextBox;
        private CheckedListBox addCheckedListBox;
        private ListBox addListBox;
        private Button addClear;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label3;
    }
}
