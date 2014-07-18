using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        //To handle the file and the path where it is
        byte[] file;
        string path;

        //Offset Manager
        GeneralOffset home;
        //Decript / Encript Proccess
        HandleEncript handleExternalProccess = new HandleEncript();
        bool isDecript = false;
        Microsoft.Win32.RegistryKey key;
        //Checksum Calculator
        CRC checksum;

        public MainWindow()
        {
            InitializeComponent();
            //Registro di sys per la path di default
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("TTFFX-2", true);
            if (key == null)
            {
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("TTFFX-2");
            }
        }


        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            refresh_ui();
        }

        //Select all the dresspheres YUNA
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
        //Select all the dresspheres RIKKU
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
        //Select all the dresspheres PAINE
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

        //Update UI w/ value from file
        void refresh_ui()
        {
            if (isDecript)
            {
                btnSave.IsEnabled = true;
                btnLoad.IsEnabled = false;
            }
            else
            {
                btnSave.IsEnabled = false;
                btnLoad.IsEnabled = true;
            }
            if (home == null) return;
            Storyboard sb = this.FindResource("SimulateProgressStoryboard") as Storyboard;
            DoubleAnimationUsingKeyFrames child = sb.Children[0] as DoubleAnimationUsingKeyFrames;
            float val = (float)home.Percentage / 100.0f;
            child.KeyFrames[1].Value = val;
            Storyboard.SetTarget(sb, this.percentageComplete);
            sb.Begin();
            TimeSpan time = TimeSpan.FromSeconds(home.Time);
            txtHH.Value = (int)Math.Floor(time.TotalHours);
            txtMM.Value = time.Minutes;
            txtSS.Value = time.Seconds;
            txtGuil.Value = home.Guil;
            txtYunaRun.Value = home.RunYuna;
            txtRikkuRun.Value = home.RunRikku;
            txtPaineRun.Value = home.RunPaine;
        }

        //Ripristinate UI after save the file
        private void reset_ui()
        {
            home = null;
            btnSave.IsEnabled = false;
            btnLoad.IsEnabled = true;
            Storyboard sb = this.FindResource("SimulateProgressStoryboard") as Storyboard;
            DoubleAnimationUsingKeyFrames child = sb.Children[0] as DoubleAnimationUsingKeyFrames;
            float val = 0;
            child.KeyFrames[1].Value = val;
            Storyboard.SetTarget(sb, this.percentageComplete);
            sb.Begin();
            txtHH.Text = "";
            txtMM.Text = "";
            txtSS.Text = "";
            txtGuil.Text = "";
            txtYunaRun.Text = "";
            txtRikkuRun.Text = "";
            txtPaineRun.Text = "";
            txtChecksum.Text = "";
            chkAccessori.IsEnabled = true;
            chkInventario.IsEnabled = true;
            chkAccessori.IsChecked = chkInventario.IsChecked = false;
        }

        //What to do if we load a save? 
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.SelectedPath = key.GetValue("last_path") as string;
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();
            if (result.ToString() != "OK")
            {
                return;
            }
            path = dialog.SelectedPath;
            key.SetValue("last_path", path, Microsoft.Win32.RegistryValueKind.String);
            string filename = path + "/SAVES";
            //Little Check
            if (!File.Exists(filename))
            {
                Xceed.Wpf.Toolkit.MessageBox.Show("Errore, selezionare una cartella con i saves di FFX-2 HD", "Cartella non valida", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            //Se arriviamo qua, i files esistono e dobbiamo decriptarli
            handleExternalProccess.setPath(path);
            handleExternalProccess.Decript();
            isDecript = true;
            //A questo punto possiamo iniziare i lavori
            file = File.ReadAllBytes(filename);
            checksum = new CRC(file);
            //Link HexBox with CRC
            txtChecksum.DataContext = checksum;
            home = new GeneralOffset(file,path,checksum);
            refresh_ui();
        }

        //Save File. Encript. Restart.
        private void btnSave_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Utility.writeFile(file, path);
            handleExternalProccess.Encript();
            //Ripristiniamo tutto
            isDecript = false;
            home = null;
            handleExternalProccess.Dispose();
            reset_ui();
            refresh_ui();
        }

        //If we close the window, just make sure to encript if necessary
        private void Window_Closed(object sender, EventArgs e)
        {
            if (isDecript)
            {
                handleExternalProccess.Encript();
            }
            handleExternalProccess.Dispose();
        }

        #region "Handle UI w/ File"
        private void txtGuil_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (home == null) return;
            var guil = Convert.ToInt32(txtGuil.Text.Replace(".", ""));
            home.Guil = guil;
        }

        private void chkInventario_Checked(object sender, RoutedEventArgs e)
        {

            if (home == null) { chkInventario.IsChecked = false; return; }
            chkInventario.IsEnabled = false;
            home.setInventario();
        }
        private void chkAccessori_Checked(object sender, RoutedEventArgs e)
        {

            if (home == null) { chkAccessori.IsChecked = false; return; }
            chkAccessori.IsEnabled = false;
            home.setAccessori();
        }

        private void txtYunaRun_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (home == null) return;
            home.RunYuna = (byte)txtYunaRun.Value;
        }

        private void txtRikkuRun_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (home == null) return;
            home.RunRikku = (byte)txtRikkuRun.Value;
        }

        private void txtPaineRun_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (home == null) return;
            home.RunPaine = (byte)txtPaineRun.Value;
        }


        void handleTime(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (home == null) return;
            int h = txtHH.Text != "" ? Convert.ToInt32(txtHH.Text) : 0;
            int m = txtMM.Text != "" ? Convert.ToInt32(txtMM.Text) : 0;
            int s = txtSS.Text != "" ? Convert.ToInt32(txtSS.Text) : 0;
            int second = h * 3600 + m * 60 + s;
            Console.WriteLine(second);
            home.Time = second;
        }
        #endregion
    }
}
