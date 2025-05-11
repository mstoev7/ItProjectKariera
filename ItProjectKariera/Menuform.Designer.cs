namespace ItProjectKariera
{
    partial class Menuform
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
            label1 = new Label();
            label2 = new Label();
            titleBox = new TextBox();
            previousNotes = new DataGridView();
            loadButton = new Button();
            deleteButton = new Button();
            newNoteButton = new Button();
            saveButton = new Button();
            noteBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)previousNotes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Ivory;
            label1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(341, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Ivory;
            label2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(341, 64);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "Note:";
            label2.Click += label2_Click;
            // 
            // titleBox
            // 
            titleBox.Location = new Point(341, 37);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(365, 23);
            titleBox.TabIndex = 2;
            // 
            // previousNotes
            // 
            previousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousNotes.BackgroundColor = Color.PaleGoldenrod;
            previousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousNotes.Location = new Point(12, 9);
            previousNotes.Name = "previousNotes";
            previousNotes.RowTemplate.Height = 25;
            previousNotes.Size = new Size(323, 294);
            previousNotes.TabIndex = 4;
            previousNotes.CellDoubleClick += previousNotes_CellDoubleClick;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.LightGoldenrodYellow;
            loadButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loadButton.ForeColor = Color.Black;
            loadButton.Location = new Point(30, 309);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(136, 45);
            loadButton.TabIndex = 5;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.LightGoldenrodYellow;
            deleteButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Location = new Point(189, 309);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(136, 45);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // newNoteButton
            // 
            newNoteButton.BackColor = Color.LightGoldenrodYellow;
            newNoteButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newNoteButton.Location = new Point(30, 362);
            newNoteButton.Name = "newNoteButton";
            newNoteButton.RightToLeft = RightToLeft.No;
            newNoteButton.Size = new Size(136, 45);
            newNoteButton.TabIndex = 9;
            newNoteButton.Text = "New Note";
            newNoteButton.UseVisualStyleBackColor = false;
            newNoteButton.Click += newNoteButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.LightGoldenrodYellow;
            saveButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(189, 362);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(136, 45);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // noteBox
            // 
            noteBox.Location = new Point(341, 92);
            noteBox.Multiline = true;
            noteBox.Name = "noteBox";
            noteBox.Size = new Size(365, 328);
            noteBox.TabIndex = 3;
            // 
            // Menuform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(718, 432);
            Controls.Add(saveButton);
            Controls.Add(newNoteButton);
            Controls.Add(deleteButton);
            Controls.Add(loadButton);
            Controls.Add(previousNotes);
            Controls.Add(noteBox);
            Controls.Add(titleBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Menuform";
            Text = "Menu";
            Load += Menuform_Load;
            ((System.ComponentModel.ISupportInitialize)previousNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox titleBox;
        private DataGridView previousNotes;
        private Button loadButton;
        private Button deleteButton;
        private Button newNoteButton;
        private Button saveButton;
        private TextBox noteBox;
    }
}