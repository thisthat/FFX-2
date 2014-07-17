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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CRC_Calc
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string path;
        byte[] file;
        public MainWindow()
        {
            InitializeComponent();
            //Ora è decriptato
            string filename = "C:\\Users\\this_that\\Desktop\\FFX\\save\\BLES01880X-2_DIR--------------4/SAVES";
            file = File.ReadAllBytes(filename);
            //file[90727] = 0;
            //file[90728] = 0;
            //file[90729] = 0;
            //file[90730] = 0;
            file[0x16268] = 0;
            file[0x16269] = 0;
            //var x = c.ComputeChecksum(file);

            Crc16Ccitt x = new Crc16Ccitt(InitialCrcValue.NonZero1);
            Console.WriteLine(x.ComputeChecksum(file).ToString("X4") + " - " + file.Length);
            this.Close();
        }

     

    }

    public enum InitialCrcValue { Zeros, NonZero1 = 0xffff, NonZero2 = 0x1D0F }

    public class Crc16Ccitt
    {
        const ushort poly = 0x1021;
        ushort[] table = new ushort[256];
        ushort initialValue = 0;

        public ushort ComputeChecksum(byte[] bytes)
        {
            ushort crc = this.initialValue;
            var l = 0x1626B;
            for (int i = 0x40; i <= l; ++i)
            {
                crc = (ushort)((crc << 8) ^ table[((crc >> 8) ^ (0xff & bytes[i]))]);
            }
            return (ushort)(~crc);
        }

        public byte[] ComputeChecksumBytes(byte[] bytes)
        {
            ushort crc = ComputeChecksum(bytes);
            return BitConverter.GetBytes(crc);
        }

        public Crc16Ccitt(InitialCrcValue initialValue)
        {
            this.initialValue = (ushort)initialValue;
            ushort temp, a;
            for (int i = 0; i < table.Length; ++i)
            {
                temp = 0;
                a = (ushort)(i << 8);
                for (int j = 0; j < 8; ++j)
                {
                    if (((temp ^ a) & 0x8000) != 0)
                    {
                        temp = (ushort)((temp << 1) ^ poly);
                    }
                    else
                    {
                        temp <<= 1;
                    }
                    a <<= 1;
                }
                table[i] = temp;
            }
            table[0xFF] = 0;
        }
    }

}


