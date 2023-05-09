

namespace Notatnik
{
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private DialogResult czyzapisac()
        {
            DialogResult zakoncz = MessageBox.Show("Zamkn¹æ i Zapisaæ Plik?", "Notatnik",
          MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (zakoncz == DialogResult.Yes)
                zapiszToolStripMenuItem_Click(null, null);
            return zakoncz;

            DialogResult odp = MessageBox.Show("Zapisaæ Zmiany w Notatniku?", "Notatnik",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (odp == DialogResult.Yes)
                zapiszToolStripMenuItem_Click(null, null);
            return odp;

        
        }
        

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
{
           
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string plik = "";
            if (richTextBox1.Text != "")
            {
                DialogResult odp = czyzapisac();
                if (odp == DialogResult.Cancel)
                    return;
                plik = "";
                richTextBox1.Clear();
            }

        }

        private void otwórzToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }

        }

        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
                richTextBox1.Undo();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
        }

        private void ponówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo == true)
                richTextBox1.Redo();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void wyczyœæToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                richTextBox1.Font = this.fontDialog1.Font;
                
            }
        }

        private void kolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                richTextBox1.Font = this.fontDialog1.Font;
                richTextBox1.ForeColor = this.fontDialog1.Color;
            }
        }

        private void pogróbienieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new System.Drawing.Font(this.Font, richTextBox1.Font.Style);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
                richTextBox1.Undo();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "") 
            {
                DialogResult zakoncz = czyzapisac();
                if (zakoncz == DialogResult.Cancel == true);
            }
           Application.Exit();
        }

        private void wyjscieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                DialogResult zakoncz = czyzapisac();
                if (zakoncz == DialogResult.Cancel == true) ;
            }
            Application.Exit();
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult autor = MessageBox.Show("Autor Programu Hamela Micha³ ", "Notatnik");
           
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string plik = "";
            if (richTextBox1.Text != "")
            {
                DialogResult odp = czyzapisac();
                if (odp == DialogResult.Cancel)
                    return;
                plik = "";
                richTextBox1.Clear();
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo == true)
                richTextBox1.Redo();
        }
    }
}