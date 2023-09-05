using System.IO;
using System.Windows.Forms;

namespace MPE
{
    public partial class reportForm : Form
    {
        public reportForm()
        {
            InitializeComponent();
            reader.src = Directory.GetCurrentDirectory() + @"\Отчет по курсовой, Долгих, Дробин, Степанов.pdf";
        }
    }
}
