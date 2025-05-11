using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItProjectKariera
{

    public partial class Menuform : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;

        private string currentUser;

        public Menuform(string username)
        {
            InitializeComponent();
            currentUser = username;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8P9N9H2;Initial Catalog=Project;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Menuform_Load(object sender, EventArgs e)
        {
            LoadUserNotes();
        }

        private void LoadUserNotes()
        {
            notes.Clear();

            string query = "SELECT NoteId, Title, Note FROM UserNotes WHERE Username = @username";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", currentUser);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(notes);
            }

            previousNotes.DataSource = notes;
            if (notes.Columns.Contains("NoteId"))
                previousNotes.Columns["NoteId"].Visible = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (previousNotes.CurrentCell == null) return;

            int noteId = (int)notes.Rows[previousNotes.CurrentCell.RowIndex]["NoteId"];

            string query = "DELETE FROM UserNotes WHERE NoteId = @noteId";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@noteId", noteId);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            notes.Rows.RemoveAt(previousNotes.CurrentCell.RowIndex);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (previousNotes.CurrentRow == null) return;

            titleBox.Text = previousNotes.CurrentRow.Cells["Title"].Value.ToString();
            noteBox.Text = previousNotes.CurrentRow.Cells["Note"].Value.ToString();
            editing = true;
        }


        private void newNoteButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            noteBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string title = titleBox.Text;
            string note = noteBox.Text;

            if (editing)
            {
                int noteId = (int)notes.Rows[previousNotes.CurrentCell.RowIndex]["NoteId"];
                string query = "UPDATE UserNotes SET Title = @title, Note = @note WHERE NoteId = @noteId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@note", note);
                    cmd.Parameters.AddWithValue("@noteId", noteId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                notes.Rows[previousNotes.CurrentCell.RowIndex]["Title"] = title;
                notes.Rows[previousNotes.CurrentCell.RowIndex]["Note"] = note;
                editing = false;
            }
            else
            {
                string query = "INSERT INTO UserNotes (Username, Title, Note) VALUES (@username, @title, @note)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", currentUser);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@note", note);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                // Refresh DataTable
                notes.Clear();
                Menuform_Load(null, null); // reload notes
            }

            titleBox.Clear();
            noteBox.Clear();
        }

        private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titleBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}
