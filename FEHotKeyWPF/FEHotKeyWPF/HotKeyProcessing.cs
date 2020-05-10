namespace FreeEcho
{
    namespace FEHotKeyWPF
    {
        /// <summary>
        /// ネイティブメソッド
        /// </summary>
        class NativeMethods
        {
            [System.Runtime.InteropServices.DllImport("User32.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
            public extern static int RegisterHotKey(System.IntPtr hWnd, int id, int fsModifiers, int vk);
            [System.Runtime.InteropServices.DllImport("User32.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
            public extern static int UnregisterHotKey(System.IntPtr hWnd, int id);
        }

        /// <summary>
        /// ホットキー処理
        /// </summary>
        public class HotKeyProcessing
        {
            /// <summary>
            /// ホットキーを登録
            /// </summary>
            /// <param name="hwnd">ウィンドウのハンドル</param>
            /// <param name="hot_key_information">ホットキー情報</param>
            /// <param name="id">ホットキーの識別子 (0x0000～0xBFFF)</param>
            /// <returns>結果 (false=失敗/true=成功)</returns>
            public static bool RegisterHotKey(
                System.IntPtr hwnd,
                HotKeyInformation hot_key_information,
                int id
                )
            {
                return (RegisterHotKey(hwnd, hot_key_information.Alt, hot_key_information.Ctrl, hot_key_information.Shift, hot_key_information.Windows, hot_key_information.KeyCharacter, id));
            }

            /// <summary>
            /// ホットキーを登録
            /// </summary>
            /// <param name="hwnd">ウィンドのウハンドル</param>
            /// <param name="alt">Alt</param>
            /// <param name="ctrl">Ctrl</param>
            /// <param name="shift">Shift</param>
            /// <param name="windows">Windows</param>
            /// <param name="vk">仮想キーコード (文字)</param>
            /// <param name="id">ホットキーの識別子 (0x0000～0xBFFF)</param>
            /// <returns>結果 (false=登録に失敗/true=登録に成功)</returns>
            public static bool RegisterHotKey(
                System.IntPtr hwnd,
                bool alt,
                bool ctrl,
                bool shift,
                bool windows,
                int vk,
                int id
                )
            {
                int mod_key = 0;

                if (alt)
                {
                    mod_key |= 0x0001;       // MOD_ALT
                }
                if (ctrl)
                {
                    mod_key |= 0x0002;       // MOD_CONTROL
                }
                if (shift)
                {
                    mod_key |= 0x0004;     // MOD_SHIFT
                }
                if (windows)
                {
                    mod_key |= 0x0008;     // MOD_WIN
                }

                return ((NativeMethods.RegisterHotKey(hwnd, id, mod_key, vk) == 0) ? false : true);
            }

            /// <summary>
            /// 定義したホットキーを破棄
            /// </summary>
            /// <param name="hwnd">ウィンドウのハンドル</param>
            /// <param name="id">ホットキーの識別子</param>
            /// <returns>結果 (false=破棄に失敗/true=破棄に成功)</returns>
            public static bool UnregisterHotKey(
                System.IntPtr hwnd,
                int id
                )
            {
                return ((NativeMethods.UnregisterHotKey(hwnd, id) == 0) ? false : true);
            }
        }
    }
}
