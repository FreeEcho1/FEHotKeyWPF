namespace FreeEcho
{
    namespace FEHotKeyWPF
    {
        /// <summary>
        /// ホットキー情報
        /// </summary>
        public class HotKeyInformation
        {
            /// <summary>
            /// Ctrl
            /// </summary>
            public bool Ctrl
            {
                get;
                set;
            } = false;
            /// <summary>
            /// Shift
            /// </summary>
            public bool Shift
            {
                get;
                set;
            } = false;
            /// <summary>
            /// Alt
            /// </summary>
            public bool Alt
            {
                get;
                set;
            } = false;
            /// <summary>
            /// Windows
            /// </summary>
            public bool Windows
            {
                get;
                set;
            } = false;
            /// <summary>
            /// 数字及び文字
            /// </summary>
            public int KeyCharacter
            {
                get;
                set;
            } = 0;

            /// <summary>
            /// コンストラクタ
            /// </summary>
            public HotKeyInformation()
            {
            }

            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="hot_key_information">ホットキー情報</param>
            public HotKeyInformation(
                HotKeyInformation hot_key_information
                )
            {
                try
                {
                    Copy(hot_key_information);
                }
                catch
                {
                    throw;
                }
            }

            /// <summary>
            /// コピー
            /// </summary>
            /// <param name="hot_key_information">ホットキー情報</param>
            public void Copy(
                HotKeyInformation hot_key_information
                )
            {
                Alt = hot_key_information.Alt;
                Ctrl = hot_key_information.Ctrl;
                Shift = hot_key_information.Shift;
                Windows = hot_key_information.Windows;
                KeyCharacter = hot_key_information.KeyCharacter;
            }
        }
    }
}
