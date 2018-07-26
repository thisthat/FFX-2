using FFX_2.Lang;
using FFX_2.looksfere;
using FFX_2.Looksfere;
using FFX_2.Personaggi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
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
        //Updater
        Updater up;
        //YRP
        Yuna yuna;
        Rikku rikku;
        Paine paine;
        //Dresspheres
        Pistolera pistolera = new Pistolera();
        Magipistolera maginistolera = new Magipistolera();
        Alchimista alchimista = new Alchimista();
        Guerriera guerriera = new Guerriera();
        Samurai samurai = new Samurai();
        CavaliereNero cavalierenero = new CavaliereNero();
        Berserker berserker = new Berserker();
        Soubrette soubrette = new Soubrette();
        Nerarcano nerarcano = new Nerarcano();
        Biancarcano biancarcano = new Biancarcano();
        Bandita bandita = new Bandita();
        Domatrice domatrice = new Domatrice();
        DeaFortunata deafortunata = new DeaFortunata();
        Mascotte mascotte = new Mascotte();
        Psichica psichica = new Psichica();
        Festaiola festaiola = new Festaiola();

        Floralia floralia = new Floralia();
        Automastino automastino = new Automastino();
        Suprema suprema = new Suprema();

        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
        public MainWindow()
        {
            InitializeComponent();

            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(LogInfo);

            System.Threading.Thread.Sleep(1000);
            //Lang Loader
            up = new Updater();
            loaderLanguage();


            //Registro di sys per la path di default
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("TTFFX-2", true);
            if (key == null)
            {
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("TTFFX-2");
            }
        }

        private void LogInfo(object sender, UnhandledExceptionEventArgs e)
        {
            string filePath = @"Log.txt";
            Exception ex = (Exception)e.ExceptionObject;
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("Message :" + ex.Message + Environment.NewLine + "StackTrace :" + ex.StackTrace + Environment.NewLine);
                writer.WriteLine(e.ToString());
                writer.WriteLine("Type: " + e.GetType());
                writer.WriteLine(ex.TargetSite);
                writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);
            }
        }

        #region "LANG LOADER"
        private void loaderLanguage()
        {
            CultureInfo ci = CultureInfo.InstalledUICulture;
            //Già fatto per l'italiano
            string langName;
            switch (ci.Name)
            {
                case "it-IT": return;
                case "en-US": langName = "en-US"; break;
                default: langName = "en-US"; break;
            }
            LangLoader lang = new LangLoader(langName);
            //All UIObjects
            //this.Title = lang.get(LangLoader.WndTitle);
            this.btnLoad.Content = lang.get(LangLoader.LoadBtn);
            this.btnSave.Content = lang.get(LangLoader.SaveBtn);
            this.headFrameCampain.Header = lang.get(LangLoader.Campains);
            //Home TAB
            this.lblPercent.Content = lang.get(LangLoader.Percentual);
            this.lblGuil.Content = lang.get(LangLoader.Guil);
            this.txtGuil.Watermark = lang.get(LangLoader.Guil);
            this.lblTime.Content = lang.get(LangLoader.Time);
            this.lblRunYuna.Content = lang.get(LangLoader.RunYuna);
            this.lblRunRikku.Content = lang.get(LangLoader.RunRikku);
            this.lblRunPaine.Content = lang.get(LangLoader.RunPaine);
            this.txtYunaRun.Watermark = lang.get(LangLoader.RunYuna);
            this.txtRikkuRun.Watermark = lang.get(LangLoader.RunRikku);
            this.txtPaineRun.Watermark = lang.get(LangLoader.RunPaine);
            this.chkAccessori.Content = lang.get(LangLoader.Accessories);
            this.chkInventario.Content = lang.get(LangLoader.Item);
            this.chkLooksfera.Content = lang.get(LangLoader.AllDress);
            this.chkAllItem.Content = lang.get(LangLoader.AllItem);
            //YUNA TAB
            this.frmYunaStat.Header = lang.get(LangLoader.Stat);
            this.btn_sel_yuna.Content = lang.get(LangLoader.SelectAll);
            this.pistolera_yuna.Content = lang.get(LangLoader.Gunner);
            this.bandita_yuna.Content = lang.get(LangLoader.Thief);
            this.guerriera_yuna.Content = lang.get(LangLoader.Warrior);
            this.soubrette_yuna.Content = lang.get(LangLoader.Songstress);
            this.festaiola_yuna.Content = lang.get(LangLoader.Festivalist);
            this.psichica_yuna.Content = lang.get(LangLoader.Psychic);
            this.nerarcano_yuna.Content = lang.get(LangLoader.BlackMage);
            this.biancarcano_yuna.Content = lang.get(LangLoader.WhiteMage);
            this.magipistolera_yuna.Content = lang.get(LangLoader.GunMage);
            this.cavalierenero_yuna.Content = lang.get(LangLoader.DarkKnight);
            this.berserker_yuna.Content = lang.get(LangLoader.Berserker);
            this.alchimista_yuna.Content = lang.get(LangLoader.Alchemist);
            this.deafortunata_yuna.Content = lang.get(LangLoader.LadyLuck);
            this.domatrice_yuna.Content = lang.get(LangLoader.Trainer);
            this.samurai_yuna.Content = lang.get(LangLoader.Samurai);
            this.mascotte_yuna.Content = lang.get(LangLoader.Mascot);
            this.floralia_yuna.Content = lang.get(LangLoader.FloralFallal);

            //RIKKU TAB
            this.frmRikkuStat.Header = lang.get(LangLoader.Stat);
            this.btn_sel_rikku.Content = lang.get(LangLoader.SelectAll);
            this.pistolera_rikku.Content = lang.get(LangLoader.Gunner);
            this.bandita_rikku.Content = lang.get(LangLoader.Thief);
            this.guerriera_rikku.Content = lang.get(LangLoader.Warrior);
            this.soubrette_rikku.Content = lang.get(LangLoader.Songstress);
            this.festaiola_rikku.Content = lang.get(LangLoader.Festivalist);
            this.psichica_rikku.Content = lang.get(LangLoader.Psychic);
            this.nerarcano_rikku.Content = lang.get(LangLoader.BlackMage);
            this.biancarcano_rikku.Content = lang.get(LangLoader.WhiteMage);
            this.magipistolera_rikku.Content = lang.get(LangLoader.GunMage);
            this.cavalierenero_rikku.Content = lang.get(LangLoader.DarkKnight);
            this.berserker_rikku.Content = lang.get(LangLoader.Berserker);
            this.alchimista_rikku.Content = lang.get(LangLoader.Alchemist);
            this.deafortunata_rikku.Content = lang.get(LangLoader.LadyLuck);
            this.domatrice_rikku.Content = lang.get(LangLoader.Trainer);
            this.samurai_rikku.Content = lang.get(LangLoader.Samurai);
            this.mascotte_rikku.Content = lang.get(LangLoader.Mascot);
            this.automatino_rikku.Content = lang.get(LangLoader.MachinaMaw);

            //PAINE TAB
            this.frmPaineStat.Header = lang.get(LangLoader.Stat);
            this.btn_sel_paine.Content = lang.get(LangLoader.SelectAll);
            this.pistolera_paine.Content = lang.get(LangLoader.Gunner);
            this.bandita_paine.Content = lang.get(LangLoader.Thief);
            this.guerriera_paine.Content = lang.get(LangLoader.Warrior);
            this.soubrette_paine.Content = lang.get(LangLoader.Songstress);
            this.festaiola_paine.Content = lang.get(LangLoader.Festivalist);
            this.psichica_paine.Content = lang.get(LangLoader.Psychic);
            this.nerarcano_paine.Content = lang.get(LangLoader.BlackMage);
            this.biancarcano_paine.Content = lang.get(LangLoader.WhiteMage);
            this.magipistolera_paine.Content = lang.get(LangLoader.GunMage);
            this.cavalierenero_paine.Content = lang.get(LangLoader.DarkKnight);
            this.berserker_paine.Content = lang.get(LangLoader.Berserker);
            this.alchimista_paine.Content = lang.get(LangLoader.Alchemist);
            this.deafortunata_paine.Content = lang.get(LangLoader.LadyLuck);
            this.domatrice_paine.Content = lang.get(LangLoader.Trainer);
            this.samurai_paine.Content = lang.get(LangLoader.Samurai);
            this.mascotte_paine.Content = lang.get(LangLoader.Mascot);
            this.suprema_paine.Content = lang.get(LangLoader.FullThrottle);

            //CALM LAND TAB
            this.frmAzzurro.Header = lang.get(LangLoader.OpenAir);
            this.frmArgento.Header = lang.get(LangLoader.Argent);
            this.frmSposa.Header = lang.get(LangLoader.WifeHunt);
            this.lblPointAzzurro.Content = lang.get(LangLoader.Point);
            this.lblPointArgento.Content = lang.get(LangLoader.Point);
            this.lblPointSposa.Content = lang.get(LangLoader.Point);
            this.txtPointAzzurro.Watermark = lang.get(LangLoader.PointOpenAir);
            this.txtPointArgento.Watermark = lang.get(LangLoader.PointSilver);
            this.txtPointSposa.Watermark = lang.get(LangLoader.PointWife);
        }
        #endregion
        #region "UI Base"
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            refresh_ui();
        }

        //Select all the dresspheres YUNA
        private void btn_sel_yuna_Click(object sender, RoutedEventArgs e)
        {
            if (home == null) { return; }
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
            if (home == null) { return; }
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
            if (home == null) { return; }
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
            txtYunaRun.Value = yuna.RunYuna;
            txtRikkuRun.Value = rikku.RunRikku;
            txtPaineRun.Value = paine.RunPaine;
            txtPointArgento.Value = home.PointArgento;
            txtPointAzzurro.Value = home.PointAzzurro;
            txtPointSposa.Value = home.PointSposa;
            //STATS
            txtHPYuna.Value = yuna.HPYuna;
            txtMPYuna.Value = yuna.MPYuna;
            txtHPRikku.Value = rikku.HPRikku;
            txtMPRikku.Value = rikku.MPRikku;
            txtHPPaine.Value = paine.HPPaine;
            txtMPPaine.Value = paine.MPPaine;
        }

        //Ripristinate UI after save the file
        private void reset_ui()
        {
            home = null;
            yuna = null;
            rikku = null;
            paine = null;
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
            chkLooksfera.IsEnabled = true;
            chkAllItem.IsEnabled = true;
            chkAccessori.IsChecked = chkInventario.IsChecked = chkLooksfera.IsChecked = chkAllItem.IsChecked = false;
            //TAB YUNA
            CheckBox tmp;
            UIElementCollection controls;
            controls = grid_looksfere_yuna.Children;
            foreach (Control c in controls)
            {
                if (c is CheckBox)
                {
                    tmp = (CheckBox)c;
                    tmp.IsChecked = false;
                    tmp.IsEnabled = true;
                }
            }
            //TAB RIKKU
            controls = grid_looksfere_rikku.Children;
            foreach (Control c in controls)
            {
                if (c is CheckBox)
                {
                    tmp = (CheckBox)c;
                    tmp.IsChecked = false;
                    tmp.IsEnabled = true;
                }
            }
            //TAB PAINE
            controls = grid_looksfere_paine.Children;
            foreach (Control c in controls)
            {
                if (c is CheckBox)
                {
                    tmp = (CheckBox)c;
                    tmp.IsChecked = false;
                    tmp.IsEnabled = true;
                }
            }
            //TAB CALM LAND
            txtPointArgento.Text = "";
            txtPointAzzurro.Text = "";
            txtPointSposa.Text = "";
            //STATS
            txtHPYuna.Text = "";
            txtMPYuna.Text = "";
            txtHPRikku.Text = "";
            txtMPRikku.Text = "";
            txtHPPaine.Text = "";
            txtMPPaine.Text = "";
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
                Xceed.Wpf.Toolkit.MessageBox.Show("Error, please select a folder containing the saves of FFX-2 HD", "Folder not valid", MessageBoxButton.OK, MessageBoxImage.Error);
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
            home = new GeneralOffset(file, path, checksum);
            yuna = new Yuna(file, checksum);
            rikku = new Rikku(file, checksum);
            paine = new Paine(file, checksum);
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

        #endregion
        #region "Handle UI w/ File"
        #region "HOME AND LOOK"
        private void txtGuil_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (home == null) return;
            var val = txtGuil.Text.Replace(".", "");
            val = val.Replace(",", "");
            var guil = Convert.ToInt32(val);
            home.Guil = guil;
        }

        private void chkInventario_Checked(object sender, RoutedEventArgs e)
        {

            if (home == null) { chkInventario.IsChecked = false; return; }
            chkInventario.IsEnabled = false;
            if (chkAllItem.IsChecked.Value)
            {
                home.setInventario(GeneralOffset.N_ITEMS);
            }
            else { home.setInventario(); }
            
        }
        private void chkAllItem_Checked(object sender, RoutedEventArgs e)
        {
            if (home == null) { chkAllItem.IsChecked = false; return; }
            chkAllItem.IsEnabled = false;
            home.setAllItem(chkInventario.IsChecked.Value);
        }
        private void chkAccessori_Checked(object sender, RoutedEventArgs e)
        {

            if (home == null) { chkAccessori.IsChecked = false; return; }
            chkAccessori.IsEnabled = false;
            home.setAccessori();
        }

        private void chkLooksfera_Checked(object sender, RoutedEventArgs e)
        {
            if (home == null) { chkLooksfera.IsChecked = false; return; }
            chkLooksfera.IsEnabled = false;
            home.setAllLooksfere();
        }


        

        private void txtPointAzzurro_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (home == null) return;
            home.PointAzzurro = (int)txtPointAzzurro.Value;
        }
        private void txtPointArgento_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (home == null) return;
            home.PointArgento = (int)txtPointArgento.Value;
        }
        private void txtPointSposa_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (home == null) return;
            home.PointSposa = (byte)txtPointSposa.Value;
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

        #region "STATS"
        private void txtHPYuna_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (yuna == null) return;
            yuna.HPYuna = (int)txtHPYuna.Value;
        }
        private void txtMPYuna_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (yuna == null) return;
            yuna.MPYuna = (int)txtMPYuna.Value;
        }
        private void txtHPRikku_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (rikku == null) return;
            rikku.HPRikku = (int)txtHPRikku.Value;
        }
        private void txtMPRikku_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (rikku == null) return;
            rikku.MPRikku = (int)txtMPRikku.Value;
        }

        private void txtHPPaine_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (paine == null) return;
            paine.HPPaine = (int)txtHPPaine.Value;
        }

        private void txtMPPaine_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (paine == null) return;
            paine.MPPaine = (int)txtMPPaine.Value;
        }
        private void txtYunaRun_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (yuna == null) return;
            yuna.RunYuna = (byte)txtYunaRun.Value;
        }

        private void txtRikkuRun_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (rikku == null) return;
            rikku.RunRikku = (byte)txtRikkuRun.Value;
        }

        private void txtPaineRun_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (paine == null) return;
            paine.RunPaine = (byte)txtPaineRun.Value;
        }
        #endregion

        #region "LookSfere"
        private void lookSferaYuna_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            handleLooksfera(sender, Looksfera.YRP.YUNA);
        }
        private void lookSferaRikku_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            handleLooksfera(sender, Looksfera.YRP.RIKKU);
        }
        private void lookSferaPaine_Checked(object sender, System.Windows.RoutedEventArgs e)
        {
            handleLooksfera(sender, Looksfera.YRP.PAINE);
        }

        private void handleLooksfera(object sender, Looksfera.YRP pg)
        {
            // TODO: aggiungere l'implementazione del gestore dell'evento in questa posizione.
            CheckBox look = (CheckBox)sender;
            //if (home == null) { look.IsChecked = false; return; }
            string id = look.Name.Split('_')[0];
            switch (id)
            {
                case Looksfera.ALCHIMISTA: alchimista.write(file, pg); break;
                case Looksfera.AUTOMASTINO: automastino.write(file); break;
                case Looksfera.BANDITA: bandita.write(file, pg); break;
                case Looksfera.BERSERKER: berserker.write(file, pg); break;
                case Looksfera.BIANCARCANO: biancarcano.write(file, pg); break;
                case Looksfera.CAVALIERE_NERO: cavalierenero.write(file, pg); break;
                case Looksfera.DEA_FORTUNATA: deafortunata.write(file, pg); break;
                case Looksfera.DOMATRICE: domatrice.write(file, pg); break;
                case Looksfera.FESTAIOLA: festaiola.write(file, pg); break;
                case Looksfera.FLORALIA: floralia.write(file); break;
                case Looksfera.GUERRIERA: guerriera.write(file, pg); break;
                case Looksfera.MAGIPISTOLERA: maginistolera.write(file, pg); break;
                case Looksfera.MASCOTTE: mascotte.write(file, pg); break;
                case Looksfera.NERARCANO: nerarcano.write(file, pg); break;
                case Looksfera.PISTOLERA: pistolera.write(file, pg); break;
                case Looksfera.PSICHICA: psichica.write(file, pg); break;
                case Looksfera.SAMURAI: samurai.write(file, pg); break;
                case Looksfera.SOUBRETTE: soubrette.write(file, pg); break;
                case Looksfera.SUPREMA: suprema.write(file); break;
                default: break;
            }
            checksum.SetChecksum();
            look.IsEnabled = false;
        }

       
        


        #endregion


        #endregion
        
        
    }
}
