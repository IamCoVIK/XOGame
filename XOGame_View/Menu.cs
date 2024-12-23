using System.Linq;
using System.Windows.Forms;
using XOGame_Model;

namespace XOGame_View
{
    public class Menu : Form
    {
        private FlowLayoutPanel my_layout;
        private Button play;
        private Button settings;
        private Button records;

        private PlayWidget playWidget;
        private SettingsWidget settingsWidget;
        private RecordsWidget recordsWidget;

        private Settings Settings;

        public Menu(Settings settings)
        {
            Settings = settings;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "XOGame";
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MaximizeBox = false;
            MinimizeBox = false;

            my_layout = new FlowLayoutPanel();
            my_layout.FlowDirection = FlowDirection.TopDown;
            my_layout.AutoSize = true;
            my_layout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            my_layout.SuspendLayout();
            SuspendLayout();
            Controls.Add(my_layout);

            play = new Button() { Text = "Играть" };
            settings = new Button() { Text = "Настройки" };
            records = new Button() { Text = "Статистика" };

            my_layout.Controls.Add(play);
            my_layout.Controls.Add(settings);
            my_layout.Controls.Add(records);

            play.Click += (o, e) => PlayClicked();
            settings.Click += (o, e) => SettingsClicked();
            records.Click += (o, e) => RecordsClicked();

            my_layout.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void PlayClicked()
        {
            if (Application.OpenForms.OfType<PlayWidget>().Count() == 0)
            {
                playWidget = new PlayWidget(Settings);
                playWidget.Show();
            }
        }
        private void SettingsClicked()
        {
            if (Application.OpenForms.OfType<SettingsWidget>().Count() == 0)
            {
                settingsWidget = new SettingsWidget(Settings);
                settingsWidget.Show();
            }
        }
        private void RecordsClicked() 
        {
            if (Application.OpenForms.OfType<RecordsWidget>().Count() == 0)
            {
                recordsWidget = new RecordsWidget(Settings);
                recordsWidget.Show();
            }
        }
    }
}
