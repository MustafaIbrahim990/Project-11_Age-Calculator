using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Age_Calculator_Project
{
    public partial class frmAgeCalculatorScreen : Form
    {
        struct stUserAge
        {
            public int AgeInYears;
            public int AgeInMonths;
            public int AgeInDays;
            public int AgeAsNumberOfMonths;
            public int AgeAsNumberOfWeeks;
            public int AgeAsNumberOfDays;
            public int AgeAsNumberOfHours;
            public int AgeAsNumberOfMinutes;
            public int AgeAsNumberOfSeconds;
        }

        stUserAge UserAge;

        public frmAgeCalculatorScreen()
        {
            InitializeComponent();
        }

        private void frmAgeCalculatorScreen_Load(object sender, EventArgs e)
        {

        }

        //----------------------------------------------//

        private int GetUserOfBirthDayInYears()
        {
            return dateTimePicker1.Value.Year;
        }

        private int GetUserOfBirthDayInMonths()
        {
            return dateTimePicker1.Value.Month;
        }

        private int GetUserOfBirthDayInDays()
        {
            return dateTimePicker1.Value.Day;
        }

        private DateTime GetUserOfBirthDay()
        {
            DateTime UserOfBirthDay = new DateTime(GetUserOfBirthDayInYears(), GetUserOfBirthDayInMonths(), GetUserOfBirthDayInDays());
            return UserOfBirthDay;
        }

        private DateTime GetCurrentDate()
        {
            return DateTime.Now;
        }

        //----------------------------------------------//

        private TimeSpan GetDifferenceDate()
        {
            return GetCurrentDate().Subtract(GetUserOfBirthDay());
        }

        private bool IsBirthDayCorrect()
        {
            if (GetDifferenceDate().TotalDays < 0)
                return true;
            else
                return false;
        }

        //----------------------------------------------//

        private void GetUserAgeInYears()
        {
            UserAge.AgeInYears = GetCurrentDate().Year - GetUserOfBirthDay().Year;
        }

        private void GetUserAgeInMonths()
        {
            if (GetCurrentDate().Month >= GetUserOfBirthDay().Month)
            {
                UserAge.AgeInMonths = GetCurrentDate().Month - GetUserOfBirthDay().Month;
                return;
            }

            UserAge.AgeInMonths = GetCurrentDate().Month - GetUserOfBirthDay().Month;

            if (UserAge.AgeInMonths < 0)
            {
                UserAge.AgeInYears--;
                UserAge.AgeInMonths += 12;
            }
        }

        private void GetUserAgeInDays()
        {
            if (GetCurrentDate().Day >= GetUserOfBirthDay().Day)
            {
                UserAge.AgeInDays = GetCurrentDate().Day - GetUserOfBirthDay().Day;
                return;
            }

            UserAge.AgeInDays = GetCurrentDate().Day - GetUserOfBirthDay().Day;

            if (UserAge.AgeInDays < 0)
            {
                if (UserAge.AgeInMonths == 1) 
                {
                    UserAge.AgeInYears--;
                    UserAge.AgeInMonths = 12;
                }
                else
                {
                    UserAge.AgeInMonths--;
                }
                UserAge.AgeInDays += DateTime.DaysInMonth(UserAge.AgeInYears, UserAge.AgeInMonths);
            }
        }

        //----------------------------------------------//

        private void GetUserAgeAsNumberOfMonths()
        {
            UserAge.AgeAsNumberOfMonths = (UserAge.AgeInYears * 12) + UserAge.AgeInMonths;
        }

        private void GetUserAgeAsNumberOfDays()
        {
            UserAge.AgeAsNumberOfDays = (int)GetDifferenceDate().TotalDays;
        }

        private void GetUserAgeAsNumberOfWeeks()
        {
            UserAge.AgeAsNumberOfWeeks = UserAge.AgeAsNumberOfDays / 7;
        }

        private void GetUserAgeAsNumberOfHours()
        {
            UserAge.AgeAsNumberOfHours = UserAge.AgeAsNumberOfDays * 24;
        }

        private void GetUserAgeAsNumberOfMinutes()
        {
            UserAge.AgeAsNumberOfMinutes = UserAge.AgeAsNumberOfHours * 60;
        }

        private void GetUserAgeAsNumberOfSeconds()
        {
            UserAge.AgeAsNumberOfSeconds = UserAge.AgeAsNumberOfMinutes * 60;
        }

        //----------------------------------------------//

        private void GetUserAgeInfo()
        {
            if (IsBirthDayCorrect())
            {
                MessageBox.Show("Date Is Not Correct,\nPlaese Enter The Correct Date!","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GetUserAgeInYears();
            GetUserAgeInMonths();
            GetUserAgeInDays();

            GetUserAgeAsNumberOfMonths();
            GetUserAgeAsNumberOfDays();
            GetUserAgeAsNumberOfWeeks();
            GetUserAgeAsNumberOfHours();
            GetUserAgeAsNumberOfMinutes();
            GetUserAgeAsNumberOfSeconds();
        }

        //----------------------------------------------//

        private void ShowUserAgeInfo()
        {
            lblAgeInYears.Text = "عمرك هو " + UserAge.AgeInYears.ToString() + " سنة";
            lblAgeInMonths.Text = "و " + UserAge.AgeInMonths.ToString() + " شهور";
            lblAgeInDays.Text = "و " + UserAge.AgeInDays.ToString() + " يوم";

            lblAgeAsNumberOfMonths.Text = UserAge.AgeAsNumberOfMonths.ToString() + " شهر";
            lblAgeAsNumberOfWeeks.Text = UserAge.AgeAsNumberOfWeeks.ToString() + " أسبوع";
            lblAgeAsNumberOfDays.Text = UserAge.AgeAsNumberOfDays.ToString() + " يوم";
            lblAgeAsNumberOfHours.Text = UserAge.AgeAsNumberOfHours.ToString() + " ساعة";
            lblAgeAsNumberOfMinutes.Text = UserAge.AgeAsNumberOfMinutes.ToString() + " دقيقة";
            lblAgeAsNumberOfSeconds.Text = UserAge.AgeAsNumberOfSeconds.ToString() + " ثانية";
        }

        //----------------------------------------------//

        private void btnStartAgeCalculation_Click(object sender, EventArgs e)
        {
            GetUserAgeInfo();
            ShowUserAgeInfo();
        }
    }
}