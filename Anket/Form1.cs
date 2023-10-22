using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;


//yaranan faylın location'u: ..\bin\Debug\net6.0-windows (default file: peoples.json)


namespace Anket
{
    public partial class Form1 : Form
    {
        private List<Person> peopleList;
        private string currentFileName;
        public Form1()
        {
            InitializeComponent();
            peopleList = new List<Person>();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = peopleListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < peopleList.Count)
            {
                Person selectedPerson = peopleList[selectedIndex];
                selectedPerson.Name = nameTextBox.Text;
                selectedPerson.Surname = surnameTextBox.Text;
                selectedPerson.Email = emailTextBox.Text;
                selectedPerson.Telephone = telephoneTextBox.Text;
                selectedPerson.BirthDate = birthDateTimePicker.Value;

                peopleListBox.Items[selectedIndex] = selectedPerson.Name;
                MessageBox.Show("Dəyişikliklər save olundu.");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string email = emailTextBox.Text;
            string telephone = telephoneTextBox.Text;
            DateTime birthDate = birthDateTimePicker.Value;

            Person person = new Person
            {
                Name = name,
                Surname = surname,
                Email = email,
                Telephone = telephone,
                BirthDate = birthDate
            };

            peopleList.Add(person);

            peopleListBox.Items.Add(name);

            ClearInputFields();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string fileName = fileNameTextBox.Text;

            if (!string.IsNullOrWhiteSpace(fileName) && File.Exists(fileName))
            {
                string jsonData = File.ReadAllText(fileName);
                peopleList = JsonSerializer.Deserialize<List<Person>>(jsonData);

                peopleListBox.Items.Clear();
                foreach (var person in peopleList)
                {
                    peopleListBox.Items.Add(person.Name);
                }

                currentFileName = fileName;
                MessageBox.Show("Məlumatlar uğurla yükləndi.");
            }
            else
            {
                MessageBox.Show("Qeyd edilən fayl tapılmadı.");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string fileName = fileNameTextBox.Text;

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Fayl adı daxil etmədiniz!");
                return;
            }

            if (File.Exists(fileName))
            {
                string jsonData = JsonSerializer.Serialize(peopleList);
                File.WriteAllText(fileName, jsonData);
                MessageBox.Show("Məlumatlar uğurla save olundu.");
            }
            else
            {
                string jsonData = JsonSerializer.Serialize(peopleList);
                File.WriteAllText(fileName, jsonData);
                currentFileName = fileName;
                MessageBox.Show("Yeni fayl yaradıldı və məlumatlar uğurla save olundu.");
            }
        }



        private void peopleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = peopleListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < peopleList.Count)
            {
                Person selectedPerson = peopleList[selectedIndex];

                nameTextBox.Text = selectedPerson.Name;
                surnameTextBox.Text = selectedPerson.Surname;
                emailTextBox.Text = selectedPerson.Email;
                telephoneTextBox.Text = selectedPerson.Telephone;
                birthDateTimePicker.Value = selectedPerson.BirthDate;
            }
        }

        private void ClearInputFields()
        {
            nameTextBox.Clear();
            surnameTextBox.Clear();
            emailTextBox.Clear();
            telephoneTextBox.Clear();
            birthDateTimePicker.Value = DateTime.Now;
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public DateTime BirthDate { get; set; }
    }
}