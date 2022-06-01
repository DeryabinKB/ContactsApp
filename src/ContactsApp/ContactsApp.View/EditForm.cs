using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Действия окна при нажатии на ОК.
        /// </summary>
        private void EditFormOKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Действия окна при нажатии на cancel.
        /// </summary>
        private void EditFormCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
