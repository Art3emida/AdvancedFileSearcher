using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedFileSearcher
{
    public partial class PreviewWnd : Form
    {
        public static string Input = "";
        private MainWnd MainWnd;
        public PreviewWnd(MainWnd sender)
        {
            InitializeComponent();
            MainWnd = sender;
            PreviewInput.Text = Input;
            if (!string.IsNullOrEmpty(PreviewInput.Text)) ButtonPreviewClick(null, null);
        }

        private void ButtonPreviewClick(object sender, EventArgs e)
        {
            if (Engine.ContentIsValid(PreviewInput.Text, MainWnd.CondsData.Text))
            {
                PreviewResult.ForeColor = Color.Green;
                PreviewResult.Text = "Файл БУДЕТ найден!";
            }
            else
            {
                PreviewResult.ForeColor = Color.Red;
                PreviewResult.Text = "Файл НЕ БУДЕТ найден!";
            }
        }
    }
}
