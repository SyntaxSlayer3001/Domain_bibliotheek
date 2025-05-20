using Domain_bibliotheek.Business;
using Domain_bibliotheek.Persistence;

namespace winboek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var mapper = new Boekmapper();
            var brouwerLijst = mapper.GetBoeken();
            lbBoeken.Items.Clear();
            foreach (var brouwer in brouwerLijst)
            {
                lbBoeken.Items.Add(brouwer); // ToString() wordt automatisch gebruikt
            }
        }
        FormAddBoek form2 = new FormAddBoek();
        private void btnAddBoek_Click_1(object sender, EventArgs e)
        {
            //Open het formulier FormAddBoek waar ik nieuwe boeken kan toevoegen
            form2.ShowDialog();
        }
    }
}
