using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using JPIEnrollmentSystem.Models;
using System.Linq;

namespace JPIEnrollmentSystem
{
    public partial class frmAddStudent : Form
    {
        #region Regular Expressions
        private Regex regexEmail = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
        private Regex regexNoNumAndSpecialChar = new Regex(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$");
        private Regex regexContact = new Regex(@"^(09|\+639)\d{9}$");
        private Regex regexInclusiveYears = new Regex(@"^(20|19)\d\d-(20|19)\d\d");
        private Regex regexYear = new Regex(@"^(20|19)\d\d");
        #endregion

        #region Student Information Variables
        private string lastName, firstName, middleName, gender, dateOfBirth, placeOfBirth, studentContact, email, religion, address,
            fatherName, fatherOccupation, fatherContact, motherName, motherOccupation, motherContact, guardianName, guardianRelationship,
            guardianContact, elem, elemInclusiveYears, elemYearGraduated, jhs, jhsInclusiveYears, jhsYearGraduated;

        private List<Requirement> requirements;

        private bool isAgeValid, blIDPic, blGoodMoral, blForm138, blPSA;

        private int age;
        #endregion

        #region RequirementEntities

        #endregion

        //private EnrollmentSystemContext context = new EnrollmentSystemContext();

        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            //// Show Requirements From the Database Table
            //requirements = context.Requirements.ToList();
            //foreach (var requirement in requirements)
            //{
            //    chckbxRequirements.Items.Add(requirement.Name);
            //}
        }

        bool checkCancel = true;

        #region Student Information Tab
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btnNext1_Click(object sender, EventArgs e)
        {
            lastName = tbLastName.Text;
            firstName = tbFirstName.Text;
            middleName = tbMiddleName.Text;
            isAgeValid = int.TryParse(tbAge.Text, out age);
            dateOfBirth = dtBirthday.Value.ToShortDateString(); // currently string need to change in datetime value
            placeOfBirth = tbPlaceOfBirth.Text;
            studentContact = tbStudentContactNum.Text;
            email = tbStudentEmail.Text;
            religion = tbReligion.Text;
            address = tbAddress.Text;

            //Validations
            if (!ValidateStudentInfoFields() || !ValidateNameAndReligion() || !ValidateAge() || !ValidateDateOfBirth()
                || !ValidatePlaceOfBirth() || !ValidateContactNum(studentContact) || !ValidateEmail())
            {
                return;
            }

            MessageBox.Show($"STUDENT DETAILS\nFull Name: {firstName} {middleName}. {lastName}\n" +
              $"Age: {age}\nGender: {gender}\nDate of Birth: {dateOfBirth}\n" +
              $"Place of Birth: {placeOfBirth}\nContact Number: {studentContact}\nEmail: {email}\n" +
              $"Religion: {religion}\nAddress:{address}");

            checkCancel = false;
            tabStudentDetails.SelectedTab = tabPage2;
        }

        #region Validations
        private bool ValidateStudentInfoFields()
        {
            if (cbxGender.SelectedIndex != -1 && cbxGender.SelectedItem != null && !string.IsNullOrWhiteSpace(lastName) && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(middleName)
                            && !string.IsNullOrWhiteSpace(dateOfBirth) && !string.IsNullOrWhiteSpace(placeOfBirth)
                            && !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(studentContact) && !string.IsNullOrWhiteSpace(religion) && !string.IsNullOrWhiteSpace(address)
                            )
            {
                gender = cbxGender.SelectedItem.ToString(); // save gender if the field is already validated
                return true;
                
            }

            MessageBox.Show("Please provide all missing fields.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private bool ValidateNameAndReligion()
        {
            Match matchFirstName = regexNoNumAndSpecialChar.Match(firstName);
            Match matchMiddleName = regexNoNumAndSpecialChar.Match(lastName);
            Match matchLastName = regexNoNumAndSpecialChar.Match(middleName);
            if (!matchFirstName.Success || !matchMiddleName.Success || !matchLastName.Success)
            {
                MessageBox.Show("Please provide a valid First Name, Middle Name or Last Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Match matchReligion = regexNoNumAndSpecialChar.Match(religion);

            if (matchReligion.Success) { return true; }

            MessageBox.Show("Religion must not contain a number and special characters", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private bool ValidateAge()
        {
            if (isAgeValid || age > 15) { return true; }

            MessageBox.Show("Please provide a valid age", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private bool ValidateDateOfBirth()
        {
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(dtBirthday.Value.ToString("yyyyMMdd"));
            int ageNow = (now - dob) / 10000;

            int year = int.Parse(dtBirthday.Value.ToString("yyyy"));
            if(year < 1950 || year > DateTime.Now.Year - 15)
            {
                MessageBox.Show($"Date of birth year must not be less than 1950 or greater than {DateTime.Now.Year - 15}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (ageNow == age) { return true; }

            MessageBox.Show("Please enter the correct age or correct date of birth", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private bool ValidateContactNum(string contactNum)
        {
            Match matchContact = regexContact.Match(contactNum);
            if (matchContact.Success) { return true; }

            MessageBox.Show("Please provide a valid contact number(e.g. +639..., 09...)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private bool ValidateEmail()
        {
            Match matchEmail = regexEmail.Match(email);
            if(matchEmail.Success) { return true; }
            
            MessageBox.Show("Please provide a valid email.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private bool ValidatePlaceOfBirth()
        {
            Match matchPOB = regexNoNumAndSpecialChar.Match(placeOfBirth);
            if(matchPOB.Success) { return true; }

            MessageBox.Show("Place of birth must not contain a number or special characters", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        #endregion

        #endregion

        #region Family Information Tab
        private void btnNext2_Click(object sender, EventArgs e)
        {
            int familyInfoDetails = 0;

            fatherName = tbFatherName.Text;
            fatherOccupation = tbFatherOccupation.Text;
            fatherContact = tbFatherContactNum.Text;

            motherName = tbMotherName.Text;
            motherOccupation = tbMotherOccupation.Text;
            motherContact = tbMotherContactNum.Text;

            guardianName = tbGuardianName.Text;
            guardianRelationship = tbGuardianRelationship.Text;
            guardianContact = tbGuardianContactNum.Text;


            if (!string.IsNullOrWhiteSpace(fatherName) && !string.IsNullOrWhiteSpace(fatherOccupation) && !string.IsNullOrWhiteSpace(fatherContact))
            {
                if (!ValidateParentOrGuardian(fatherName, fatherOccupation))
                {
                    MessageBox.Show("Please provide the correct Father's name or occupation", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidateContactNum(fatherContact)) { return; }
                familyInfoDetails++;
            }


            if (!string.IsNullOrWhiteSpace(motherName) && !string.IsNullOrWhiteSpace(motherOccupation) && !string.IsNullOrWhiteSpace(motherContact))
            {
                if (!ValidateParentOrGuardian(motherName, motherOccupation))
                {
                    MessageBox.Show("Please provide the correct Mother's name or occupation", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidateContactNum(motherContact)) { return; }
                familyInfoDetails++;
            }

            if (!string.IsNullOrWhiteSpace(guardianName) && !string.IsNullOrWhiteSpace(guardianRelationship) && !string.IsNullOrWhiteSpace(guardianContact))
            {
                if (!ValidateParentOrGuardian(guardianName, guardianRelationship))
                {
                    MessageBox.Show("Please provide the correct Guardian's name or relationship", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidateContactNum(guardianContact)) { return; }
                familyInfoDetails++;
            }

            if (familyInfoDetails <= 0)
            {
                MessageBox.Show("Please provide at least one parent/guardian complete information", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"FAMILY INFO:\nFather's Name: {fatherName}\nFather's Occupation: {fatherOccupation}\nFather's Contact Number: {fatherContact}" +
                $"\nMother's Name: {motherName}\nMother's Occupation: {motherOccupation}\nMother's Contact Number: {motherContact}\n" +
                $"Guardian's Name: {guardianName}\nRelationship with Guardian: {guardianRelationship}\nGuardian Contact Number: {guardianContact}");
                
                checkCancel = false;
                tabStudentDetails.SelectedTab = tabPage3;
            }

            


        }

        private void btnPrev1_Click(object sender, EventArgs e)
        {
            checkCancel = false;
            tabStudentDetails.SelectedTab = tabPage1;
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool ValidateParentOrGuardian(string name, string occupationOrRelationship)
        {
            Match matchName = regexNoNumAndSpecialChar.Match(name);
            Match matchOccupationOrRelationship = regexNoNumAndSpecialChar.Match(occupationOrRelationship);
            if (matchName.Success && matchOccupationOrRelationship.Success) { return true; }
            return false;
        }
        #endregion

        #region Requirements Tab
        private void btnPrev2_Click(object sender, EventArgs e)
        {
            checkCancel = false;
            tabStudentDetails.SelectedTab = tabPage2;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            elem = tbElementary.Text;
            elemInclusiveYears = tbElemInclusiveYears.Text;
            elemYearGraduated = tbElemYearGraduated.Text;

            jhs = tbJHS.Text;
            jhsInclusiveYears = tbJHSInclusiveYears.Text;
            jhsYearGraduated = tbJHSYearGraduated.Text;


            if (!ValidateLRNAndGradeLevel() || !ValidateBackgroundFields() || !ValidateEducationalBackground(elem, elemInclusiveYears, elemYearGraduated) || !ValidateEducationalBackground(jhs, jhsInclusiveYears, jhsYearGraduated)
                || !ValidateRequirements()) { return; }


            //Student student = new Student()
            //{
            //    FirstName = firstName,
            //    LastName = lastName,
            //    MiddleName = middleName,
            //    GradeLevel = 11,
            //    Email = email,
            //    Address = address,
            //};

            //context.Students.Add(student);
            //context.SaveChanges();

            //StudentInformation studentInformation = new StudentInformation()
            //{
            //    Student = student,
            //    Age = age,
            //    Gender = gender,
            //    LRN = tbLRN.Text,
            //    Religion = religion,
            //    DateOfBirth = Convert.ToDateTime(dateOfBirth),
            //    Elem = elem,
            //    ElemInclusiveYears = elemInclusiveYears,
            //    ElemYearGraduated = Convert.ToInt32(elemYearGraduated),
            //    Jhs = jhs,
            //    JhsInclusiveYears = jhsInclusiveYears,
            //    JhsYearGraduated = Convert.ToInt32(jhsYearGraduated),
            //    ContactNumber = studentContact
            //};

            //context.StudentsInformation.Add(studentInformation);

            //StudentFamilyInformation familyInformation = new StudentFamilyInformation()
            //{
            //    Student = student,
            //    FatherName = fatherName,
            //    FatherOccupation = fatherOccupation,
            //    FatherContacNo = fatherContact,
            //    MotherName = motherName,
            //    MotherOccupation = motherOccupation,
            //    MotherContactNo = motherContact,
            //    GuardianName = guardianName,
            //    GuardianRelation = guardianRelationship,
            //    GuardianContacNo = guardianContact
            //};
            
            //context.StudentsFamilyInformation.Add(familyInformation);


            //foreach (Requirement item in chckbxRequirements.CheckedItems)
            //{
            //    StudentRequirement studentRequirement = new StudentRequirement()
            //    {
            //        Student = student,
            //        Requirement = item,
            //    };

            //    context.StudentsRequirements.Add(studentRequirement);
            //}

            //context.SaveChanges();

            

            //string providedRequirements = "";
            //foreach (string requirement in requirements)
            //{
            //    providedRequirements += $"{requirement}\n";
            //}

            //MessageBox.Show($"Educational Background:\nElementary School: {elem}\nElementary Inclusive Years: {elemInclusiveYears}\nElementary Year Graduated: {elemYearGraduated}" +
            //    $"\nJunior High School: {jhs}\nJHS Inclusive Years: {jhsInclusiveYears}\nJHS Year Graduated: {jhsYearGraduated}\n" +
            //    $"Requirements Provided: {providedRequirements}");




            this.Dispose();
        }

        #region EducationValidation

        private bool ValidateLRNAndGradeLevel()
        {
            if(cbxGradeLvl.SelectedIndex != -1 && cbxGradeLvl.SelectedItem != null && !string.IsNullOrWhiteSpace(tbLRN.Text) 
                && cbxStrand.SelectedIndex != -1) { return true; }
            MessageBox.Show("Please provide LRN, Grade Level, or Strand", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;

        }
        private bool ValidateBackgroundFields()
        {
            if (!string.IsNullOrWhiteSpace(elem) && !string.IsNullOrWhiteSpace(elemInclusiveYears) && !string.IsNullOrWhiteSpace(elemYearGraduated)
                && !string.IsNullOrWhiteSpace(jhs) && !string.IsNullOrWhiteSpace(jhsInclusiveYears) && !string.IsNullOrWhiteSpace(jhsInclusiveYears))
            { return true; }

            MessageBox.Show("Please provide the missing fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private bool ValidateEducationalBackground(string level, string inclusiveYears, string yearGraduated)
        {
            Match matchLevel = regexNoNumAndSpecialChar.Match(level);
            Match matchInclusiveYears = regexInclusiveYears.Match(inclusiveYears);
            Match matchYearGraduated = regexYear.Match(yearGraduated);

            if (!matchLevel.Success)
            {
                MessageBox.Show("Please provide the correct school name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!matchInclusiveYears.Success)
            {
                MessageBox.Show("Please provide the correct inclusive year\ne.g.: 2010-2014", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!matchYearGraduated.Success)
            {
                MessageBox.Show("Please provide the correct year graduated\ne.g: 2018", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidateRequirements()
        {
            if (chckbxRequirements.CheckedItems.Count > 0)
            {
                //foreach (var item in chckbxRequirements.CheckedItems)
                //{
                //    foreach(Requirement requirement in requirements)
                //    {
                //        if(item.ToString() == requirement.ToString())
                //        {
                //            int id = requirement.Id;
                //        }
                //    }
                //}

                return true;
            }

            MessageBox.Show("There must be at least one requirement provided", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        #endregion

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #endregion

        private void tabControl1(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = checkCancel;
            checkCancel = true;
        }
    }
}
