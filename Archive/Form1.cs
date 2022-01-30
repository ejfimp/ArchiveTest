using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json; //Needs to be installed before use, check https://stackoverflow.com/questions/59503393
using System.Text.Json.Serialization;
namespace Archive
{
    public partial class Archive : Form
    {
        List<Media> archive = new List<Media>();
        private string name, genre, creator, studio;
        private int release_year, length;


        private void exitButton_Click(object sender, EventArgs e)
        {
            var json = JsonSerializer.Serialize(archive);
            Directory.CreateDirectory(@"C:\archive\");
            File.WriteAllText(@"c:\archive\archive.json", json);
            Close();
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            archiveBox.Clear();
            for (int i = 0; i < archive.Count; i++)
            {
                archiveBox.Text = archiveBox.Text + $"{archive[i]}";
            }
        }

        public Archive()
        {
            InitializeComponent();
        }        

        private void addButton_Click(object sender, EventArgs e)
        {
            archiveBox.Clear();

            name = nameBox.Text;
            genre = genreBox.Text;
            release_year = int.Parse(releaseBox.Text);
            creator = creatorBox.Text;

            if(filmButton.Checked)
            {
                length = int.Parse(lengthBox.Text);
                studio = studioBox.Text;
                archive.Add(new Film(name, genre, release_year,creator, length, studio));
                archiveBox.Text = $"Added {name} to the archive with the following info:\r\n\r\n{archive[archive.Count -1]}";
            }
            else if(bookButton.Checked)
            {
                length = int.Parse(lengthBox.Text);
                archive.Add(new Book(name, genre, release_year, creator, length));
                archiveBox.Text = $"Added {name} to the archive with the following info:\r\n\r\n{archive[archive.Count - 1]}";
            }
            else if(gameButton.Checked)
            {
                studio = studioBox.Text;
                archive.Add(new Game(name, genre, release_year, creator, studio));
                archiveBox.Text = $"Added {name} to the archive with the following info:\r\n\r\n{archive[archive.Count - 1]}";
            }

            nameBox.Clear(); genreBox.Clear(); releaseBox.Clear(); creatorBox.Clear(); lengthBox.Clear(); studioBox.Clear(); 
        }

        private void mediaChoice_clicked(object sender, EventArgs e)
        {
            //labels visibility
            nameLabel.Visible = true;
            genreLabel.Visible = true;
            releaseLabel.Visible = true;
            creatorLabel.Visible = true;

            //textbox visibility
            nameBox.Visible = true;
            genreBox.Visible = true;
            releaseBox.Visible = true;
            creatorBox.Visible = true;

            //certain labels and textboxes changes depending on choice
            if (filmButton.Checked)
            {
                //label changes for film
                creatorLabel.Text = "Director";
                lengthLabel.Text = "Minutes";
                studioLabel.Text = "Studio";
                lengthLabel.Visible = true;
                studioLabel.Visible = true;
                //textbox changes for film
                lengthBox.Visible = true;
                studioBox.Visible = true;
            }
            else if (bookButton.Checked)
            {
                //label changes for book
                creatorLabel.Text = "Author";
                lengthLabel.Text = "Pages";
                lengthLabel.Visible = true;
                studioLabel.Visible = false;
                //textbox changes for book
                lengthBox.Visible = true;
                studioBox.Visible = false;
            }
            else if (gameButton.Checked)
            {
                //label changes for game
                creatorLabel.Text = "Developer";
                studioLabel.Text = "Publisher";
                lengthLabel.Visible = false;
                studioLabel.Visible = true;
                //textbox changes for game
                lengthBox.Visible = false;
                studioBox.Visible = true;
            }
        }
        private void checkIfNum(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(releaseBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                releaseBox.Text = releaseBox.Text.Remove(releaseBox.Text.Length - 1);
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(lengthBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                lengthBox.Text = lengthBox.Text.Remove(lengthBox.Text.Length - 1);
            }
        }
    }
}
