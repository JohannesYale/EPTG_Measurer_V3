using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPTG_Measurer_V3
{
    public partial class ChooseStudyGroup : Form
    {
        public Database.StudyGroups StudyGroup { get; set; }
        public ChooseStudyGroup()
        {
            InitializeComponent();
            using (Database.ModelsContext context = new Database.ModelsContext())
            {
                gridStudy.DataSource = context.StudyGroups.ToList();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (gridStudy.SelectedRows.Count != 0)
            {
                this.DialogResult = DialogResult.OK;
                StudyGroup = gridStudy.SelectedRows[0].DataBoundItem as Database.StudyGroups;
                this.Close();
            }
        }
    }
}
