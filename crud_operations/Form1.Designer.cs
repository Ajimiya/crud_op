namespace crud_operations
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtname = new TextBox();
            txtfname = new TextBox();
            txtno = new TextBox();
            txtaddress = new TextBox();
            txtmobile = new TextBox();
            StudentRecordDataGidView = new DataGridView();
            insert = new Button();
            update = new Button();
            db = new Button();
            reset = new Button();
            ((System.ComponentModel.ISupportInitialize)StudentRecordDataGidView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 255);
            label1.Font = new Font("Javanese Text", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(312, 28);
            label1.Name = "label1";
            label1.Size = new Size(190, 62);
            label1.TabIndex = 0;
            label1.Text = "Registration ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(155, 124);
            label2.Name = "label2";
            label2.Size = new Size(161, 16);
            label2.TabIndex = 1;
            label2.Text = "Name        : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(155, 167);
            label3.Name = "label3";
            label3.Size = new Size(150, 16);
            label3.TabIndex = 2;
            label3.Text = "Father name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(155, 215);
            label4.Name = "label4";
            label4.Size = new Size(150, 16);
            label4.TabIndex = 3;
            label4.Text = "Roll no     :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(155, 266);
            label5.Name = "label5";
            label5.Size = new Size(150, 16);
            label5.TabIndex = 4;
            label5.Text = "Address     :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(155, 312);
            label6.Name = "label6";
            label6.Size = new Size(150, 16);
            label6.TabIndex = 5;
            label6.Text = "Mobile      :";
            // 
            // txtname
            // 
            txtname.Location = new Point(333, 124);
            txtname.Name = "txtname";
            txtname.Size = new Size(372, 23);
            txtname.TabIndex = 6;
            // 
            // txtfname
            // 
            txtfname.Location = new Point(333, 167);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(372, 23);
            txtfname.TabIndex = 7;
            // 
            // txtno
            // 
            txtno.Location = new Point(333, 215);
            txtno.Name = "txtno";
            txtno.Size = new Size(372, 23);
            txtno.TabIndex = 8;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(333, 266);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(372, 23);
            txtaddress.TabIndex = 9;
            // 
            // txtmobile
            // 
            txtmobile.Location = new Point(333, 312);
            txtmobile.Name = "txtmobile";
            txtmobile.Size = new Size(372, 23);
            txtmobile.TabIndex = 10;
            // 
            // StudentRecordDataGidView
            // 
            StudentRecordDataGidView.BackgroundColor = Color.FromArgb(255, 192, 255);
            StudentRecordDataGidView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentRecordDataGidView.Location = new Point(12, 438);
            StudentRecordDataGidView.Name = "StudentRecordDataGidView";
            StudentRecordDataGidView.RowTemplate.Height = 25;
            StudentRecordDataGidView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentRecordDataGidView.Size = new Size(776, 246);
            StudentRecordDataGidView.TabIndex = 11;
            StudentRecordDataGidView.CellClick += StudentRecordDataGidView_CellClick;
            // 
            // insert
            // 
            insert.BackColor = Color.FromArgb(255, 128, 255);
            insert.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            insert.Location = new Point(155, 365);
            insert.Name = "insert";
            insert.Size = new Size(107, 40);
            insert.TabIndex = 12;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = false;
            insert.Click += insert_Click;
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(255, 128, 255);
            update.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            update.Location = new Point(302, 365);
            update.Name = "update";
            update.Size = new Size(107, 40);
            update.TabIndex = 13;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // db
            // 
            db.BackColor = Color.FromArgb(255, 128, 255);
            db.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            db.Location = new Point(449, 365);
            db.Name = "db";
            db.Size = new Size(107, 40);
            db.TabIndex = 14;
            db.Text = "Delete";
            db.UseVisualStyleBackColor = false;
            db.Click += db_Click;
            // 
            // reset
            // 
            reset.BackColor = Color.FromArgb(255, 128, 255);
            reset.Font = new Font("Javanese Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            reset.Location = new Point(596, 365);
            reset.Name = "reset";
            reset.Size = new Size(107, 40);
            reset.TabIndex = 15;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = false;
            reset.Click += reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(800, 695);
            Controls.Add(reset);
            Controls.Add(db);
            Controls.Add(update);
            Controls.Add(insert);
            Controls.Add(StudentRecordDataGidView);
            Controls.Add(txtmobile);
            Controls.Add(txtaddress);
            Controls.Add(txtno);
            Controls.Add(txtfname);
            Controls.Add(txtname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Information";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)StudentRecordDataGidView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtname;
        private TextBox txtfname;
        private TextBox txtno;
        private TextBox txtaddress;
        private TextBox txtmobile;
        private DataGridView StudentRecordDataGidView;
        private Button insert;
        private Button update;
        private Button db;
        private Button reset;

        public EventHandler delete_Click { get; private set; }
    }
}