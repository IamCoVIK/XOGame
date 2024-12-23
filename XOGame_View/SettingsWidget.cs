using System;
using System.ComponentModel;
using System.Windows.Forms;
using XOGame_Model;

namespace XOGame_View
{
    public partial class SettingsWidget : Form
    {
        private Settings settings;
        private ErrorProvider errorProviderPath;
        private ErrorProvider errorProviderSize;

        public SettingsWidget(Settings s)
        {
            settings = s;

            errorProviderPath = new ErrorProvider();
            errorProviderPath.ContainerControl = this;

            errorProviderSize = new ErrorProvider();
            errorProviderSize.ContainerControl = this;

            InitializeComponent();
        }

        private void textBox_size_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_size.Text))
            {
                if (!settings.ValidateSize(textBox_size.Text))
                {
                    e.Cancel = true;
                    errorProviderSize.SetError(textBox_size, "Неверный формат ввода. Используйте NxN, где N - 10-20.");
                }
                else
                {
                    errorProviderSize.SetError(textBox_size, "");
                }
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_path.Text))
            {
                settings.PathDefault();
            }
            else
            {
                bool fileValid = settings.ValidateFile(textBox_path.Text);
                if (!fileValid)
                {
                    errorProviderPath.SetError(textBox_path, "Неверный путь к файлу или наполнение файла.");
                    return;
                }
                else
                {
                    errorProviderPath.SetError(textBox_path, "");
                    settings.SetPath(textBox_path.Text);
                }
            }
            if (string.IsNullOrWhiteSpace(textBox_size.Text))
            {
                settings.SizeDefault();
            }
            else
            {
                settings.SetSize(Convert.ToInt32(textBox_size.Text.Split('x')[0]));
            }
        }
    }
}
