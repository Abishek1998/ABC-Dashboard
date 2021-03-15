using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Dashboard
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            panelWorkingDaysHours.Visible = false;
            panelLecturers.Visible = false;
            panelSubjects.Visible = false;
            panelStudents.Visible = false;
            panelTags.Visible = false;
            panelLocation.Visible = false;
            panelSession.Visible = false;
        }
        
        private void hideSubMenu()
        {
            if (panelWorkingDaysHours.Visible == true)
                panelWorkingDaysHours.Visible = false;

            if (panelLecturers.Visible == true)
                panelLecturers.Visible = false;

            if (panelSubjects.Visible == true)
                panelSubjects.Visible = false;

            if (panelStudents.Visible == true)
                panelStudents.Visible = false;

            if (panelTags.Visible == true)
                panelTags.Visible = false;

            if (panelLocation.Visible == true)
                panelLocation.Visible = false;

            if (panelSession.Visible == true)
                panelSession.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnWorkingDaysHours_Click(object sender, EventArgs e)
        {
            showSubMenu(panelWorkingDaysHours);
        }

        private void btnAddWorkingDaysHours_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnManageWorkingDaysHours_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnLecturers_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLecturers);
        }

        private void btnAddLecturers_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnManageLecturers_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubjects);
        }

        private void btnAddSubjects_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnManageSubjects_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStudents);
        }

        private void btnAddStudents_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTags);
        }

        private void btnAddTags_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnManageTags_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLocation);
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnManageLocation_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
    }
}
