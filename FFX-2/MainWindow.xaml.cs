using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;

namespace FFX_2
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        byte[] file;
        string path;

        GeneralOffset home;
        HandleEncript handleExternalProccess = new HandleEncript();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            refresh_ui();
        }

        private void btn_sel_yuna_Click(object sender, RoutedEventArgs e)
        {
            CheckBox tmp = null;
            UIElementCollection controls = grid_looksfere_yuna.Children;
            foreach (Control c in controls)
            {
                if (c is CheckBox)
                {
                    tmp = (CheckBox)c;
                    tmp.IsChecked = true;
                }
            }
        }

        private void btn_sel_rikku_Click(object sender, RoutedEventArgs e)
        {
            CheckBox tmp = null;
            UIElementCollection controls = grid_looksfere_rikku.Children;
            foreach (Control c in controls)
            {
                if (c is CheckBox)
                {
                    tmp = (CheckBox)c;
                    tmp.IsChecked = true;
                }
            }
        }

        private void btn_sel_paine_Click(object sender, RoutedEventArgs e)
        {
            CheckBox tmp = null;
            UIElementCollection controls = grid_looksfere_paine.Children;
            foreach (Control c in controls)
            {
                if (c is CheckBox)
                {
                    tmp = (CheckBox)c;
                    tmp.IsChecked = true;
                }
            }
        }

        void refresh_ui()
        {
            if (home == null) return;
            Storyboard sb = this.FindResource("SimulateProgressStoryboard") as Storyboard;
            DoubleAnimationUsingKeyFrames child = sb.Children[0] as DoubleAnimationUsingKeyFrames;
            float val = (float)home.Percentage / 100.0f;
            child.KeyFrames[1].Value = val;
            Storyboard.SetTarget(sb, this.percentageComplete);
            sb.Begin();
            TimeSpan time = TimeSpan.FromSeconds(home.Time);
            txtTime.Value = time;
            txtGuil.Value = home.Guil;
        }

        private void btnSave_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // TODO: aggiungere l'implementazione del gestore dell'evento in questa posizione.
            handleExternalProccess.Encript();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            //dialog.SelectedPath = readPath();
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();
            if (result.ToString() != "OK")
            {
                return;
            }
            path = dialog.SelectedPath;
            //Ora è decriptato
            string filename = path + "/SAVES";
            if (!File.Exists(filename))
            {
                Xceed.Wpf.Toolkit.MessageBox.Show("Errore, selezionare una cartella con i saves di FFX-2", "Cartella non valida", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            //Se arriviamo qua, i files esistono e dobbiamo decriptarli
            handleExternalProccess.setPath(path);
            handleExternalProccess.Decript();
            //A questo punto possiamo iniziare i lavori
            file = File.ReadAllBytes(filename);
            home = new GeneralOffset(file);
            refresh_ui();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            handleExternalProccess.Dispose();
        }

        private void txtGuil_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var guil = Convert.ToInt32(txtGuil.Text.Replace(".",""));
            if (home == null) return;
            home.Guil = guil;
        }

        private void txtTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (home == null) return;
            home.Time = (int)(txtTime.Value.Value.TotalSeconds);
        }
    }
}
