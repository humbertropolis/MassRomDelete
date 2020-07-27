using MassRomDelete.Structures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MassRomDelete
{
    public partial class Main : Form
    {
        private const string gameListFileName = "gamelist.xml";
        public string GameListFile { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!ValidateRomsFolder() || !ValidateFilters())
                return;

            var gameList = DeserializeGameList();

            DeleteFiles(gameList);
            SerializeGameList(gameList);

            var msg = "Operation successfully";
            MessageBox.Show(msg);
        }       

        private void BtnRomsFolder_Click(object sender, EventArgs e)
        {
            if (romsFolderDialog.ShowDialog() == DialogResult.OK)
            {
                txtRomsFolder.Text = romsFolderDialog.SelectedPath;
            }
        }

        #region Aux Methods

        private void DeleteFiles(GameList gameList)
        {
            var gamesToRemove = new GameList { Games = new List<Game>() };
            var alreadyRemoved = false;

            foreach (var game in gameList.Games)
            {
                var rom = game.Path.Substring(2, game.Path.Length-2);
                var image = string.IsNullOrEmpty(game.Image) ? string.Empty : game.Image.Substring(2, game.Image.Length-2);

                if (cbNameFilter.Checked)
                {
                    if (game.Name.ToLower().Contains(txtNameFilter.Text.ToLower()))
                    {
                        RemoveOperation(gamesToRemove, game, rom, image);
                        alreadyRemoved = true;
                    }                        
                }                    

                if (cbGenreFilter.Checked && !alreadyRemoved)
                {
                    if (game.Genre.ToLower().Contains(txtGenreFilter.Text.ToLower()))
                        RemoveOperation(gamesToRemove, game, rom, image);                    
                }

                alreadyRemoved = false;
            }

            foreach (var game in gamesToRemove.Games)
            {
                gameList.Games.Remove(game);
            }
        }        

        private GameList DeserializeGameList()
        {
            var deserializer = new XmlSerializer(typeof(GameList));
            using (var reader = new StreamReader(GameListFile))
            {
                var gameList = (GameList)deserializer.Deserialize(reader);

                return gameList;
            }
        }

        private void RemoveOperation(GameList gamesToRemove, Game game, string rom, string image)
        {
            File.Delete(Path.Combine(txtRomsFolder.Text, rom));
            if(!string.IsNullOrEmpty(image))
                File.Delete(Path.Combine(txtRomsFolder.Text, image));
            
            gamesToRemove.Games.Add(game);
        }

        private void SerializeGameList(GameList gameList)
        {
            var serializer = new XmlSerializer(typeof(GameList));
            var streamWriter = new StreamWriter(GameListFile);

            serializer.Serialize(streamWriter, gameList);
            streamWriter.Close();
        }

        private bool ValidateFilters()
        {
            if (!cbGenreFilter.Checked && !cbNameFilter.Checked)
            {
                var msg = "You must select at least one filter";
                MessageBox.Show(msg);

                return false; 
            }


            var a = ValidateNameFilter() && ValidateGenreFilter();
            return a;
        }

        private bool ValidateGenreFilter()
        {
            if (cbGenreFilter.Checked && string.IsNullOrEmpty(txtGenreFilter.Text)) 
            {
                var msg = "Genre filter selected but field is empty";
                MessageBox.Show(msg);

                return false;
            }

            return true;
        }

        private bool ValidateNameFilter()
        {
            if (cbNameFilter.Checked && string.IsNullOrEmpty(txtNameFilter.Text))
            {
                var msg = "Name filter selected but field is empty";
                MessageBox.Show(msg);

                return false;
            }

            return true;
        }

        private bool ValidateRomsFolder()
        {
            try
            {
                GameListFile = Path.Combine(txtRomsFolder.Text, gameListFileName);                
                if(!File.Exists(GameListFile) || !Directory.Exists(txtRomsFolder.Text))
                    throw new Exception();
            }
            catch
            {
                var msg = "Invalid Roms Folder";
                MessageBox.Show(msg);
                return false;
            }

            return true;
        }
        
        #endregion
    }
}
