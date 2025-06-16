namespace Project_LendNRead
{
    partial class FormReceipt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePickerRentalDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReturnDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.radioButtonQR = new System.Windows.Forms.RadioButton();
            this.radioButtonOnline = new System.Windows.Forms.RadioButton();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxReceipt = new System.Windows.Forms.ListBox();
            this.groupBoxPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rental Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Return Date :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(625, 95);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(314, 26);
            this.textBoxName.TabIndex = 3;
            // 
            // dateTimePickerRentalDate
            // 
            this.dateTimePickerRentalDate.Location = new System.Drawing.Point(625, 150);
            this.dateTimePickerRentalDate.Name = "dateTimePickerRentalDate";
            this.dateTimePickerRentalDate.Size = new System.Drawing.Size(314, 26);
            this.dateTimePickerRentalDate.TabIndex = 4;
            // 
            // dateTimePickerReturnDate
            // 
            this.dateTimePickerReturnDate.Location = new System.Drawing.Point(625, 209);
            this.dateTimePickerReturnDate.Name = "dateTimePickerReturnDate";
            this.dateTimePickerReturnDate.Size = new System.Drawing.Size(314, 26);
            this.dateTimePickerReturnDate.TabIndex = 5;
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.Controls.Add(this.radioButtonCash);
            this.groupBoxPayment.Controls.Add(this.radioButtonOnline);
            this.groupBoxPayment.Controls.Add(this.radioButtonQR);
            this.groupBoxPayment.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPayment.Location = new System.Drawing.Point(426, 270);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Size = new System.Drawing.Size(278, 150);
            this.groupBoxPayment.TabIndex = 6;
            this.groupBoxPayment.TabStop = false;
            this.groupBoxPayment.Text = "Payment Type :";
            // 
            // radioButtonQR
            // 
            this.radioButtonQR.AutoSize = true;
            this.radioButtonQR.Location = new System.Drawing.Point(33, 43);
            this.radioButtonQR.Name = "radioButtonQR";
            this.radioButtonQR.Size = new System.Drawing.Size(74, 33);
            this.radioButtonQR.TabIndex = 0;
            this.radioButtonQR.TabStop = true;
            this.radioButtonQR.Text = "QR";
            this.radioButtonQR.UseVisualStyleBackColor = true;
            // 
            // radioButtonOnline
            // 
            this.radioButtonOnline.AutoSize = true;
            this.radioButtonOnline.Location = new System.Drawing.Point(33, 73);
            this.radioButtonOnline.Name = "radioButtonOnline";
            this.radioButtonOnline.Size = new System.Drawing.Size(216, 33);
            this.radioButtonOnline.TabIndex = 1;
            this.radioButtonOnline.TabStop = true;
            this.radioButtonOnline.Text = "Online Banking";
            this.radioButtonOnline.UseVisualStyleBackColor = true;
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Location = new System.Drawing.Point(33, 103);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(97, 33);
            this.radioButtonCash.TabIndex = 2;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Cash";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(872, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "days";
            // 
            // listBoxReceipt
            // 
            this.listBoxReceipt.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxReceipt.FormattingEnabled = true;
            this.listBoxReceipt.ItemHeight = 29;
            this.listBoxReceipt.Location = new System.Drawing.Point(426, 446);
            this.listBoxReceipt.Name = "listBoxReceipt";
            this.listBoxReceipt.Size = new System.Drawing.Size(548, 149);
            this.listBoxReceipt.TabIndex = 8;
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 649);
            this.Controls.Add(this.listBoxReceipt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxPayment);
            this.Controls.Add(this.dateTimePickerReturnDate);
            this.Controls.Add(this.dateTimePickerRentalDate);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormReceipt";
            this.Text = "FormReceipt";
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePickerRentalDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate;
        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.RadioButton radioButtonOnline;
        private System.Windows.Forms.RadioButton radioButtonQR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxReceipt;
    }
}