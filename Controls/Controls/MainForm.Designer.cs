﻿
namespace Controls
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.captionLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.inputButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.loadRTFbutton = new System.Windows.Forms.Button();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.undelineCheckBox = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.stringListBox = new System.Windows.Forms.ListBox();
            this.fontComboBox = new System.Windows.Forms.ComboBox();
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.myProgressBar = new System.Windows.Forms.ProgressBar();
            this.slideshowButton = new System.Windows.Forms.Button();
            this.slideshowTimer = new System.Windows.Forms.Timer(this.components);
            this.textOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // captionLabel
            // 
            this.captionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captionLabel.Location = new System.Drawing.Point(12, 23);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Size = new System.Drawing.Size(485, 31);
            this.captionLabel.TabIndex = 0;
            this.captionLabel.Text = "Надпись";
            this.captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.captionLabel.MouseLeave += new System.EventHandler(this.captionLabel_MouseLeave);
            this.captionLabel.MouseHover += new System.EventHandler(this.captionLabel_MouseHover);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextBox.Location = new System.Drawing.Point(17, 103);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(480, 26);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLabel.Location = new System.Drawing.Point(17, 67);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(136, 20);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "Введите текст";
            // 
            // inputButton
            // 
            this.inputButton.BackgroundImage = global::Controls.Properties.Resources.bg;
            this.inputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputButton.Location = new System.Drawing.Point(21, 158);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(104, 28);
            this.inputButton.TabIndex = 3;
            this.inputButton.Text = "Ввод";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Visible = false;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(520, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(465, 392);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // loadRTFbutton
            // 
            this.loadRTFbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadRTFbutton.Location = new System.Drawing.Point(520, 437);
            this.loadRTFbutton.Name = "loadRTFbutton";
            this.loadRTFbutton.Size = new System.Drawing.Size(215, 39);
            this.loadRTFbutton.TabIndex = 5;
            this.loadRTFbutton.Text = "Загрузить текст";
            this.loadRTFbutton.UseVisualStyleBackColor = true;
            this.loadRTFbutton.Click += new System.EventHandler(this.loadRTFbutton_Click);
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boldCheckBox.Location = new System.Drawing.Point(21, 215);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(133, 24);
            this.boldCheckBox.TabIndex = 6;
            this.boldCheckBox.Text = "полужирный";
            this.boldCheckBox.UseVisualStyleBackColor = true;
            this.boldCheckBox.CheckedChanged += new System.EventHandler(this.ChangeFontStyle);
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.italicCheckBox.Location = new System.Drawing.Point(21, 255);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(87, 24);
            this.italicCheckBox.TabIndex = 6;
            this.italicCheckBox.Text = "курсив";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            this.italicCheckBox.CheckedChanged += new System.EventHandler(this.ChangeFontStyle);
            // 
            // undelineCheckBox
            // 
            this.undelineCheckBox.AutoSize = true;
            this.undelineCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.undelineCheckBox.Location = new System.Drawing.Point(21, 295);
            this.undelineCheckBox.Name = "undelineCheckBox";
            this.undelineCheckBox.Size = new System.Drawing.Size(152, 24);
            this.undelineCheckBox.TabIndex = 6;
            this.undelineCheckBox.Text = "подчеркнутый";
            this.undelineCheckBox.UseVisualStyleBackColor = true;
            this.undelineCheckBox.CheckedChanged += new System.EventHandler(this.ChangeFontStyle);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(260, 215);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.Text = "10 пт";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.ChangeFontSize);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(260, 255);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "14 пт";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.ChangeFontSize);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(260, 295);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 24);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.Text = "18 пт";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.ChangeFontSize);
            // 
            // stringListBox
            // 
            this.stringListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stringListBox.FormattingEnabled = true;
            this.stringListBox.ItemHeight = 20;
            this.stringListBox.Location = new System.Drawing.Point(21, 331);
            this.stringListBox.Name = "stringListBox";
            this.stringListBox.Size = new System.Drawing.Size(476, 84);
            this.stringListBox.Sorted = true;
            this.stringListBox.TabIndex = 8;
            this.stringListBox.SelectedIndexChanged += new System.EventHandler(this.stringListBox_SelectedIndexChanged);
            // 
            // fontComboBox
            // 
            this.fontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontComboBox.FormattingEnabled = true;
            this.fontComboBox.Location = new System.Drawing.Point(260, 158);
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(237, 28);
            this.fontComboBox.TabIndex = 9;
            this.fontComboBox.SelectedIndexChanged += new System.EventHandler(this.fontComboBox_SelectedIndexChanged);
            // 
            // myPictureBox
            // 
            this.myPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.myPictureBox.Location = new System.Drawing.Point(21, 437);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(476, 291);
            this.myPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myPictureBox.TabIndex = 10;
            this.myPictureBox.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(21, 747);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 39);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "<<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.ChangePicture);
            // 
            // forwardButton
            // 
            this.forwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forwardButton.Location = new System.Drawing.Point(422, 747);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(75, 39);
            this.forwardButton.TabIndex = 11;
            this.forwardButton.Text = ">>";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.ChangePicture);
            // 
            // myProgressBar
            // 
            this.myProgressBar.Location = new System.Drawing.Point(31, 812);
            this.myProgressBar.Maximum = 150;
            this.myProgressBar.Name = "myProgressBar";
            this.myProgressBar.Size = new System.Drawing.Size(476, 23);
            this.myProgressBar.Step = 25;
            this.myProgressBar.TabIndex = 12;
            // 
            // slideshowButton
            // 
            this.slideshowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slideshowButton.Location = new System.Drawing.Point(226, 747);
            this.slideshowButton.Name = "slideshowButton";
            this.slideshowButton.Size = new System.Drawing.Size(75, 39);
            this.slideshowButton.TabIndex = 13;
            this.slideshowButton.Text = "Пуск";
            this.slideshowButton.UseVisualStyleBackColor = true;
            this.slideshowButton.Click += new System.EventHandler(this.slideshowButton_Click);
            // 
            // slideshowTimer
            // 
            this.slideshowTimer.Interval = 40;
            this.slideshowTimer.Tick += new System.EventHandler(this.slideshowTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 856);
            this.Controls.Add(this.slideshowButton);
            this.Controls.Add(this.myProgressBar);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.myPictureBox);
            this.Controls.Add(this.fontComboBox);
            this.Controls.Add(this.stringListBox);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.undelineCheckBox);
            this.Controls.Add(this.italicCheckBox);
            this.Controls.Add(this.boldCheckBox);
            this.Controls.Add(this.loadRTFbutton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.captionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Элементы управления";
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label captionLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button loadRTFbutton;
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.CheckBox undelineCheckBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ListBox stringListBox;
        private System.Windows.Forms.ComboBox fontComboBox;
        private System.Windows.Forms.PictureBox myPictureBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.ProgressBar myProgressBar;
        private System.Windows.Forms.Button slideshowButton;
        private System.Windows.Forms.Timer slideshowTimer;
        private System.Windows.Forms.OpenFileDialog textOpenFileDialog;
    }
}

