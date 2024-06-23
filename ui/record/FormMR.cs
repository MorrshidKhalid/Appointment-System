using System;
using ClinicBusinessLayer;
using System.Windows.Forms;

namespace ClinicPresentationLayerDesktop.ui.record
{
    public partial class FormMR : Form
    {
        readonly ClsMedicalRecord record;
        private string name;
        private readonly int age;
        private readonly char gender; 


        // Default Constructor.
        public FormMR(int RecordID, string name, int age, char gender)
        {
            InitializeComponent();

            record = ClsMedicalRecord.Find(RecordID);
            this.name = name;
            this.age = age;
            this.gender = gender;
        }


        private void LoadDate()
        {
            tbDescription.Text = record.Description;
            tbDiagnosis.Text = record.Diagnosis;
            tbNote.Text = record.Note;
            lbPatientName.Text = name;
            lbGender.Text = gender.ToString();
            lbAge.Text = age.ToString();
        }
        private void SaveRrcordData()
        {
            record.Description = tbDescription.Text.ToString();
            record.Diagnosis = tbDiagnosis.Text.ToString();
            record.Note = tbNote.Text.ToString();

            if (record.Save())
            {
                MessageBox.Show("Medical Record Has Updated successfully");
                Close();
            }
            else
                MessageBox.Show("Error Update Medical Record");
        }
        private void FormMR_Load(object sender, EventArgs e) => LoadDate();
        private void BtnSave_Click(object sender, EventArgs e) => SaveRrcordData();
        private void BtnPrescribe_Click(object sender, EventArgs e) => new FormPrescription(record.RecordID, name, age, gender).ShowDialog();
    }
}
