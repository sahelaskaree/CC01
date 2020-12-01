using CC01.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.BO
{
    public partial class CreerEcole : Form
    {
        public CreerEcole()
        {
            InitializeComponent();
        }
        public void ImporterImage(PictureBox pictureBox)
        {
            OpenFileDialog of = new OpenFileDialog
            {
                Title = "Choose a picture",
                Filter = "Images(.jpg, jpeg, png, gif)|*.jpg; *.jpeg; *.png; *.gif"
            };
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = null;
                pictureBox.ImageLocation = of.FileName;
                pictureBox.Image = Image.FromFile(of.FileName);
            }
        }
        public string PictureName(PictureBox pictureBox)
        {
            const string folder = "Images";
            DirectoryInfo di = new DirectoryInfo(folder);
            if (!di.Exists)
            {
                di.Create();
            }
            string pictureName = string.Empty;
            if (pictureBox.ImageLocation != null)
            {
                pictureName = folder + "/" + Guid.NewGuid().ToString() + Path.GetExtension(pictureBox.ImageLocation);
                FileInfo fi = new FileInfo(pictureBox.ImageLocation);
                fi.CopyTo(pictureName);
            }
            return pictureName;
        }
        private void btnCreer_Click(object sender, EventArgs e)
        {
            TypeEcole et = new TypeEcole();
            string matricule = txtI.ToString();
            string nom = txtNom.ToString();
           
            string image = PictureName(pctI);

            string lieuN = txtL.ToString();
            int contact = int.Parse(txtC.ToString());
            string email = txtE.ToString();
            et.AjouterEcole(matricule, nom, image,  lieuN, contact, email);
        }
    }
}
