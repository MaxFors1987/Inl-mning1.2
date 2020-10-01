using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Inlämning1._2
{
    public partial class frmAddressBook : Form
    {
        public frmAddressBook()
        {
            InitializeComponent();
            cboxTypeSearch.Items.Add("Name");
            cboxTypeSearch.Items.Add("City");
            cboxTypeSearch.Items.Add("Address");
            cboxTypeSearch.Items.Add("PhoneNumber");
            cboxTypeSearch.Text = "Name";
        }
        List<Person> people = new List<Person>();
        List<Person> searchResult = new List<Person>();
        string selectedItem = "";

        //Sparas till telefonboken
        private void BtSave_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person(txtBoxFullName.Text, txtBoxAddress.Text, txtBoxPostalNumber.Text,
                txtBoxCity.Text, txtBoxPhoneNumber.Text, txtBoxMail.Text);
            SaveToFile(newPerson);
        }
        //För att visa alla sparade adresser i telefonboken så loopas listan igenom och printas ut
        private void BtShowAll_Click(object sender, EventArgs e)
        {
            SyncDataFromFile();
            searchResult.Clear();
        }
        //Uppdaterar listan i listview direkt när vi har gjort ändring i 
        //telefonboken och textboxarna töms
        public void btUpdate_Click(object sender, EventArgs e)
        {
            string path = @"SaveFile.txt";
            string words = Convert.ToString(selectedItem);
            List<string> NewLines = new List<string>();
            var oldLine = System.IO.File.ReadAllLines(path);
            foreach (string line in oldLine)
            {
                string newLine;
                if (line.Contains(words))
                {
                    newLine = $"{txtBoxFullName.Text},{txtBoxAddress.Text}," +
                       $"{txtBoxPostalNumber.Text},{txtBoxCity.Text}," +
                       $"{txtBoxPhoneNumber.Text},{txtBoxMail.Text}";
                }
                else
                {
                    newLine = line;
                }
                NewLines.Add(newLine);
            }
            System.IO.File.WriteAllLines(path, NewLines);

            people[listViewList.FocusedItem.Index]
            = new Person(txtBoxFullName.Text, txtBoxAddress.Text,
            txtBoxPostalNumber.Text, txtBoxCity.Text, txtBoxPhoneNumber.Text, txtBoxMail.Text);
            listViewList.Items.Clear();
            foreach (Person person in people)
            {
                AddListRow(person);
            }
            ClearFields();
        }
        private void BtSearch_Click(object sender, EventArgs e)
        {
            searchResult.Clear();
            if (txtSearchBox.Text.Length > 0)
            {
                string searchWord = txtSearchBox.Text;
                string typeSearch = cboxTypeSearch.SelectedItem.ToString();
                foreach (Person person in people)
                {
                    if (typeSearch == "Name" && person.FullName.ToLower().Contains(searchWord.ToLower()))
                    {
                        searchResult.Add(person);
                    }
                    else if (typeSearch == "City" && person.City.ToLower().Contains(searchWord.ToLower()))
                    {
                        searchResult.Add(person);
                    }
                    else if (typeSearch == "Address" && person.Address.ToLower().Contains(searchWord.ToLower()))
                    {
                        searchResult.Add(person);
                    }
                    else if (typeSearch == "PhoneNumber" && person.PhoneNumber.Contains(searchWord))
                    {
                        searchResult.Add(person);
                    }
                }
                ClearListView();
                foreach (Person searchedValue in searchResult)
                {
                    AddListRow(searchedValue);
                }
            }
        }
        private void BtRemove_Click(object sender, EventArgs e)
        {
            string path = "SaveFile.txt";
            string word = Convert.ToString(selectedItem);  
            var oldLines = System.IO.File.ReadAllLines(path);
            var newLines = oldLines.Where(line => !line.Contains(word));
            System.IO.File.WriteAllLines(path, newLines);
            FileStream obj = new FileStream(path, FileMode.Append);
            obj.Close();

            people.RemoveAt(listViewList.FocusedItem.Index);
            listViewList.Items.RemoveAt(listViewList.FocusedItem.Index);
            ClearFields();

        }
        public void SyncDataFromFile()
        {
            people.Clear();
            listViewList.Items.Clear();
            GetDataFromTxtFile();
            ClearFields();
        }

        //Tömmer alla textboxfälten i telefonboken
        private void BtClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        //Väljer först vilken typ vi ska söka efter och matchar sökordet 
        //det vi söker så printas resultatet ut i listan

        public void ClearListView()
        {
            listViewList.Items.Clear();
        }
        public void ClearFields()
        {
            txtBoxFullName.Clear(); txtBoxAddress.Clear(); txtBoxPostalNumber.Clear(); txtBoxCity.Clear();
            txtBoxPhoneNumber.Clear(); txtBoxMail.Clear();
        }
        //Det sparade värdet skrivs ner till textfilen
        public void SaveToFile(Person person)
        {
            string path = "SaveFile.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(person.FullName + "," + person.Address + ", " +
                person.PostalNumber + "," + person.City + "," + person.PhoneNumber + "," + person.Mail);
            }
            SyncDataFromFile();
        }
        //Läser in befintlig sparad lista i telefonboken
        public void GetDataFromTxtFile()
        {
            string path = "SaveFile.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string str;
                while ((str = reader.ReadLine()) != null)
                {
                    string[] input = str.Split(',');
                    Person newPerson = new Person(input[0], input[1], input[2], input[3], input[4], input[5]);
                    people.Add(newPerson);
                }
            }
            foreach (Person person in people)
            {
                AddListRow(person);
            }
        }
        //Skriver ut adresserna till listan
        public void AddListRow(Person person)
        {
            string[] addRow = {person.FullName, person.Address,
                person.City, person.PostalNumber,person.PhoneNumber, person.Mail};
            ListViewItem item = new ListViewItem(addRow);
            listViewList.Items.Add(item);
        }
        //När vi klickar på en rad visas denna upp i textboxarna och matchar index mot textbox
        public void ViewSelectedItemsTextBox(object sender, EventArgs e)
        {
            if (listViewList.SelectedItems.Count == 0)
            {
                return;
            }
            txtBoxFullName.Text = listViewList.SelectedItems[0].SubItems[0].Text;
            txtBoxAddress.Text = listViewList.SelectedItems[0].SubItems[1].Text;
            txtBoxPostalNumber.Text = listViewList.SelectedItems[0].SubItems[2].Text;
            txtBoxCity.Text = listViewList.SelectedItems[0].SubItems[3].Text;
            txtBoxPhoneNumber.Text = listViewList.SelectedItems[0].SubItems[4].Text;
            txtBoxMail.Text = listViewList.SelectedItems[0].SubItems[5].Text;

            selectedItem = txtBoxFullName.Text + "," + txtBoxAddress.Text + "," + txtBoxPostalNumber.Text +
                "," + txtBoxCity.Text + "," + txtBoxPhoneNumber.Text + "," + txtBoxMail.Text;
        }
        //Läser in adreesboken från start så vi inte behöver skriva in nya adresser
        private void frmAddressBook_Load_1(object sender, EventArgs e)
        {
            GetDataFromTxtFile();

        }
    }
}
