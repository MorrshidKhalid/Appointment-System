using System;
using ClinicBusinessLayer;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace ClinicPresentationLayerDesktop.ui.record
{
    public partial class FormPrescription : Form
    {
        private readonly int RecordID; // Always comes with value.
        private int Counter = 0; // Keep Track Dynamic Controls (Counter, name. position).
        private Mode enMode;

        private ClsMedication medication;
        private ClsPrescription prescription;


        // Default Constructor.
        public FormPrescription(int RecordID, string name, int age, char gender)
        {
            InitializeComponent();

            this.RecordID = RecordID;
            lbPatientName.Text = name.ToString();
            lbAge.Text = age.ToString();
            lbGender.Text = gender.ToString();

            prescription = ClsPrescription.Find(RecordID);
            enMode = (prescription != null) ? Mode.Update : Mode.Add;
        }


        private void RefreshMedicationData()
        {
            DataTable dt = ClsMedication.GetMedications(prescription.PrescriptionID);
            int index = 0;
            foreach (DataRow row in dt.Rows)
            {
                
                LoadData(index, row["MedicationName"].ToString(),
                                                  int.Parse(row["Freq"].ToString()),
                                                  row["Dosage"].ToString(),
                                                  (DateTime)row["StartDate"],
                                                  (DateTime)row["EndDate"]);
                index++;
            }
        }


        public static bool AreStringsEmpty(string string1, string string2, string string3)
            => string.IsNullOrEmpty(string1) ||
               string.IsNullOrEmpty(string2) ||
               string.IsNullOrEmpty(string3);

        private void GenerateControls()
        {
            if (Counter <= 20)
            {
                // Create a New Controls.
                TextBox tbMedicationName = new TextBox();
                TextBox tbFreq = new TextBox();
                TextBox tbDosage = new TextBox();
                DateTimePicker date1 = new DateTimePicker();
                DateTimePicker date2 = new DateTimePicker();


                // Specify MedicationName TextBox Positions on the layout.
                tbMedicationName.Location = new Point(12, 136 + (Counter * 25)); // Adjust position based on count
                tbMedicationName.Size = new Size(183, 20);
                tbMedicationName.Name = $"name{Counter}"; // Unique name for each textbox.


                // Specify Freq TextBox Positions on the layout.
                tbFreq.Location = new Point(201, 136 + (Counter * 25)); // Adjust position based on count
                tbFreq.Size = new Size(56, 20);
                tbFreq.Name = $"freq{Counter}"; // Unique name for each textbox.


                // Specify Dosage TextBox Positions on the layout.
                tbDosage.Location = new Point(263, 136 + (Counter * 25)); // Adjust position based on count
                tbDosage.Size = new Size(190, 20);
                tbDosage.Name = $"Dosage{Counter}"; // Unique name for each textbox.

                // Specify StartDate DatePicker Positions on the layout.
                date1.Location = new Point(481, 136 + (Counter * 25)); // Adjust position based on count
                date1.Size = new Size(190, 20);
                date1.Name = $"sDate{Counter}"; // Unique name for each datePicker.

                // Specify EndDate DatePicker Positions on the layout.
                date2.Location = new Point(695, 136 + (Counter * 25)); // Adjust position based on count
                date2.Size = new Size(190, 20);
                date2.Name = $"eDate{Counter}"; // Unique name for each datePicker.

                // Add the Controls to the form's Controls collection.
                Controls.Add(tbMedicationName);
                Controls.Add(tbFreq);
                Controls.Add(tbDosage);
                Controls.Add(date1);
                Controls.Add(date2);
            }

            Counter++; // Increment counter for next textbox
        }

        private void LoadData(int idx, string name, int freq, string dosage, DateTime sDate, DateTime eDate)
        {
            GenerateControls();

            TextBox tbName = (TextBox)Controls.Find($"name{idx}", true)[0];
            TextBox tbFreq = (TextBox)Controls.Find($"freq{idx}", true)[0];
            TextBox tbDosage = (TextBox)Controls.Find($"dosage{idx}", true)[0];
            DateTimePicker dpS = (DateTimePicker)Controls.Find($"sDate{idx}", true)[0];
            DateTimePicker dpE = (DateTimePicker)Controls.Find($"eDate{idx}", true)[0];
            tbName.Text = name;
            tbFreq.Text = freq.ToString();
            tbDosage.Text = dosage;
            dpS.Value = sDate;
            dpE.Value = eDate;
        }

        private bool SaveMedication(string name, int freq, string dosage, DateTimePicker sDate, DateTimePicker eDate)
        {
            medication = new ClsMedication
            {
                PrescriptionID = prescription.InsertedID,
                MedicationName = name,
                Freq = freq,
                Dosage = dosage,
                SDate = sDate.Value,
                EDate = eDate.Value
            };

            return medication.Save();
        }

        private void AddNewPrescription()
        {
            if (Counter <= 0)
                return;

            // Must Save Prescription First to Database.
            prescription = new ClsPrescription
            {
                RecordID = RecordID
            };
            if (!prescription.Save())
            {
                MessageBox.Show("Error");
                return;
            }

            // Save Medications to Database Related to The Prescription.
            for (int i = 0; i < Counter; i++)
            {
                TextBox tbName = (TextBox)Controls.Find($"name{i}", true)[0];
                TextBox tbFreq = (TextBox)Controls.Find($"freq{i}", true)[0];
                TextBox tbDosage = (TextBox)Controls.Find($"dosage{i}", true)[0];
                DateTimePicker dpS = (DateTimePicker)Controls.Find($"sDate{i}", true)[0];
                DateTimePicker dpE = (DateTimePicker)Controls.Find($"eDate{i}", true)[0];
                string name = tbName.Text.ToString().Trim();
                string freq = tbFreq.Text.ToString().Trim();
                string dosage = tbDosage.Text.ToString().Trim();

                if (!AreStringsEmpty(name, freq, dosage))
                    SaveMedication(name, int.Parse(freq), dosage, dpS, dpE);

                MessageBox.Show("Successfully Added Medication(s)");
            }

        }

        private void HandelSave()
        {
            // Save Medications related to this Prescription.
            switch (enMode)
            {
                case Mode.Add:
                    AddNewPrescription();
                    enMode = Mode.Update;
                    break;

                case Mode.Update:
                    break;
            }
        }

        private void BtnMedicationLine_Click(object sender, EventArgs e) => GenerateControls();

        private void BtnSave_Click(object sender, EventArgs e) => HandelSave();

        private void FormPrescription_Load(object sender, EventArgs e)
        {
            if (enMode == Mode.Update)
                RefreshMedicationData();
        }
    }
}