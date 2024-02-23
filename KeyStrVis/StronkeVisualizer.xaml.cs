using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KeyStrVis
{
    /// <summary>
    /// Interaction logic for StronkeVisualizer.xaml
    /// </summary>
    public partial class StronkeVisualizer : Window
    {
        static private bool IsDragging = false;
        static private Point StartPoint;
        private readonly KeyboardHook _hook;
        public StronkeVisualizer()
        {
            InitializeComponent();
            Topmost = true;
            _hook = new KeyboardHook();
            _hook.KeyPressed += Hook_KeyPressed;
            _hook.KeyReleased += Hook_KeyReleased;
        }
        
        private void Hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#7a7d80");
            string Pressed_Keys = KSV_textBlock.Text;
            string KeyStronke = GetKey(e.KeyPressed);

            if (KeyStronke != "Space" && Pressed_Keys.Length <=10 )
            {
                switch (KeyStronke)
                {

                    case "LeftShift":
                        Shift_Way.Text = "|";
                        Shift_Way.TextAlignment = TextAlignment.Left;
                        Shift_Border.Background = new SolidColorBrush(color);
                        break;
                    case "RightShift":
                        Shift_Way.Text = "|";
                        Shift_Way.TextAlignment = TextAlignment.Right;
                        Shift_Border.Background = new SolidColorBrush(color);
                        break;
                    case "LeftCtrl":
                        Ctrl_Border.Background = new SolidColorBrush(color);
                        break;
                    case "Tab":
                        Tab_Border.Background = new SolidColorBrush(color);
                        break;
                    case "LWin":
                        Win_Border.Background = new SolidColorBrush(color);
                        break;
                    case "Return":
                        KSV_textBlock.Text = "Enter";
                        break;
                    case "Back":
                        if(KSV_textBlock.Text != "")
                        {
                          KSV_textBlock.Text = Pressed_Keys.Remove(Pressed_Keys.Length - 1);
                        }
                        break;
                    default:
                        KSV_textBlock.Text =  Pressed_Keys+KeyStronke;
                        break;
                }
            }   
            else
            {
                Pressed_Keys = "";
                KSV_textBlock.Text =  "";
            }
            
        }

        private void Hook_KeyReleased(object sender, KeyReleasedEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#CED4DA");
            switch (GetKey(e.KeyReleased))          
            {

                case "LeftCtrl":
                    Ctrl_Border.Background = new SolidColorBrush(color);
                    break;
                case "LeftShift":
                    Shift_Way.Text = "";
                    Shift_Border.Background = new SolidColorBrush(color);
                    break;
                case "RightShift":
                    Shift_Way.Text = "";
                    Shift_Border.Background = new SolidColorBrush(color);
                    break;
                case "Tab":
                    Tab_Border.Background = new SolidColorBrush(color);
                    break;
                case "LWin":
                    Win_Border.Background = new SolidColorBrush(color);
                    break;
                case "Return":
                    KSV_textBlock.Text = "";
                    break;


            }
        }




        private void backToMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }


        private void KSV_Move_ClickDown(object sender, MouseButtonEventArgs e)
        {
            IsDragging = true;
            StartPoint = e.GetPosition(this);
        }

        private void KSV_Move_ClickUp(object sender, MouseButtonEventArgs e)
        {
            IsDragging= false;
        }

        private void KSV_Move(object sender, MouseEventArgs e)
        {

            if (IsDragging)
            {
                Point MousePosition = e.GetPosition(this);
                double offsetX = MousePosition.X - StartPoint.X;
                double offsetY = MousePosition.Y - StartPoint.Y;

                Left += offsetX;
                Top += offsetY;

            }

        }

        private string GetKey(Key key)
        {
            // tr mode 
            switch(key){
                case Key.OemQuestion: return "Ö"; 
                case Key.Oem6: return "Ü"; 
                case Key.OemOpenBrackets: return "Ğ"; 
                case Key.Oem1: return "Ş"; 
                case Key.Oem5: return "Ç"; 
                case Key.OemPeriod: return "."; 
                case Key.OemQuotes: return "İ"; 
                case Key.OemComma: return ","; 
                case Key.Oem8: return "*";
                case Key.Oem3: return "'";
                case Key.OemMinus: return "-";
                   


                default:
                    return key.ToString();

            }
        }
    }

    public class KeyboardHook : IDisposable
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;

        private readonly LowLevelKeyboardProc _proc;
        private readonly IntPtr _hookID = IntPtr.Zero;

        public event EventHandler<KeyPressedEventArgs> KeyPressed;
        public event EventHandler<KeyReleasedEventArgs> KeyReleased;

        public KeyboardHook()
        {
            _proc = HookCallback;
            _hookID = SetHook(_proc);
        }

        public void Dispose()
        {
            UnhookWindowsHookEx(_hookID);
        }

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (var curProcess = System.Diagnostics.Process.GetCurrentProcess())
            using (var curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                  GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && (wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_KEYUP))
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Key key = KeyInterop.KeyFromVirtualKey(vkCode);

                if (wParam == (IntPtr)WM_KEYDOWN)
                {
                    // Tuş basıldığında Hook_KeyPressed metotunu çağır
                    KeyPressed?.Invoke(this, new KeyPressedEventArgs(key));
                }
                else if (wParam == (IntPtr)WM_KEYUP)
                {
                    // Tuş bırakıldığında Hook_KeyReleased metotunu çağır
                    KeyReleased?.Invoke(this, new KeyReleasedEventArgs(key));
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }


        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
          LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
          IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }

    public class KeyPressedEventArgs : EventArgs
    {
        public Key KeyPressed { get; private set; }

        public KeyPressedEventArgs(Key keyPressed)
        {
            KeyPressed = keyPressed;
        }
    }

    public class KeyReleasedEventArgs : EventArgs
    {
        public Key KeyReleased { get; private set; }

        public KeyReleasedEventArgs(Key keyReleased)
        {
            KeyReleased = keyReleased;
        }
    }
}
