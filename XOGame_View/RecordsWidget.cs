using System.Windows.Forms;
using XOGame_Model;

namespace XOGame_View
{
    public partial class RecordsWidget : Form
    {
        Records records;

        public RecordsWidget(Settings s)
        {
            records = new Records(s);
            InitializeComponent();
            SetRecords();
        }

        private void SetRecords()
        {
            for(int i = 0; i < records.records.Count; i++)
            {
                tableLayoutPanel1.Controls.Add(new Label() { Text = records.records[i].name }, 0, i + 1);
                tableLayoutPanel1.Controls.Add(new Label() { Text = records.records[i].points }, 1, i + 1);
            }
        }
    }
}
