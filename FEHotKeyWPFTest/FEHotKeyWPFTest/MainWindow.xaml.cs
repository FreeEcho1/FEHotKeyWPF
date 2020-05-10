namespace FEHotKeyWPFTest
{
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            try
            {
                InitializeComponent();

                Loaded += MainWindow_Loaded;
                Closed += MainWindow_Closed;
                TextBoxHotKey.PreviewKeyDown += TextBoxHotKey_PreviewKeyDown;
            }
            catch
            {
            }
        }

        private void MainWindow_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                System.Windows.Interop.HwndSource source = System.Windows.Interop.HwndSource.FromHwnd(new System.Windows.Interop.WindowInteropHelper(this).Handle);
                source.AddHook(new System.Windows.Interop.HwndSourceHook(WndProc));

                FreeEcho.FEHotKeyWPF.HotKeyProcessing.RegisterHotKey(source.Handle, true, false, true, false, 'A', 0);
                FreeEcho.FEHotKeyWPF.HotKeyProcessing.RegisterHotKey(source.Handle, false, true, false, true, 'B', 1);
            }
            catch
            {
            }
        }

        private void MainWindow_Closed(object sender, System.EventArgs e)
        {
            try
            {
                System.Windows.Interop.HwndSource source = System.Windows.Interop.HwndSource.FromHwnd(new System.Windows.Interop.WindowInteropHelper(this).Handle);
                FreeEcho.FEHotKeyWPF.HotKeyProcessing.UnregisterHotKey(source.Handle, 0);
                FreeEcho.FEHotKeyWPF.HotKeyProcessing.UnregisterHotKey(source.Handle, 1);
            }
            catch
            {
            }
        }

        private void TextBoxHotKey_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            try
            {
                FreeEcho.FEHotKeyWPF.HotKeyInformation hot_key_information = FreeEcho.FEHotKeyWPF.HotKeyWPF.GetHotKey(e);
                LabelInputInformation.Content = FreeEcho.FEHotKeyWPF.HotKeyWPF.GetHotKeyString(hot_key_information);
                TextBoxHotKey.Text = (string)LabelInputInformation.Content;
                e.Handled = true;
            }
            catch
            {
            }
        }

        static System.IntPtr WndProc(System.IntPtr hwnd, int msg, System.IntPtr wparam, System.IntPtr lparam, ref bool handled)
        {
            switch (msg)
            {
                case 0x0312:        // WM_HOTKEY
                    switch (wparam.ToInt32())
                    {
                        case 0:
                            System.Diagnostics.Debug.WriteLine("ホットキー「Alt + Shift + A」が押された。");
                            break;
                        case 1:
                            System.Diagnostics.Debug.WriteLine("ホットキー「Ctrl + Windows + B」が押された。");
                            break;
                    }
                    break;
            }
            return (System.IntPtr.Zero);
        }
    }
}
