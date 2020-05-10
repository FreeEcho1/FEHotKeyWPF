namespace FreeEcho
{
    namespace FEHotKeyWPF
    {
        /// <summary>
        /// ホットキー (WPF)
        /// </summary>
        public class HotKeyWPF
        {
            /// <summary>
            /// <para>キーイベント情報からホットキー情報を取得</para>
            /// <para>「PreviewKeyDown」を使用する必要がある。「KeyDown」だと一部キーが機能しない</para>
            /// </summary>
            /// <param name="e">キーイベント</param>
            /// <param name="backspace_erase">Back Spaceは無し (false=No/true=Yes)</param>
            /// <returns>ホットキー情報</returns>
            public static HotKeyInformation GetHotKey(
                System.Windows.Input.KeyEventArgs e,
                bool backspace_erase = false
                )
            {
                HotKeyInformation hot_key_information = new HotKeyInformation
                {
                    Alt = false,
                    Ctrl = false,
                    Shift = false,
                    KeyCharacter = 0
                };

                if (backspace_erase ? (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Back) == false) : true)
                {
                    if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.LeftCtrl) || e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.RightCtrl))
                    {
                        hot_key_information.Ctrl = true;
                    }
                    if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.LeftShift) || e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.RightShift))
                    {
                        hot_key_information.Shift = true;
                    }
                    if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.LeftAlt) || e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.RightAlt))
                    {
                        hot_key_information.Alt = true;
                    }
                    if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.LWin) || e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.RWin))
                    {
                        hot_key_information.Windows = true;
                    }

                    if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.A))
                    {
                        hot_key_information.KeyCharacter = (int)'A';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.B))
                    {
                        hot_key_information.KeyCharacter = (int)'B';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.C))
                    {
                        hot_key_information.KeyCharacter = (int)'C';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D))
                    {
                        hot_key_information.KeyCharacter = (int)'D';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.E))
                    {
                        hot_key_information.KeyCharacter = (int)'E';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F))
                    {
                        hot_key_information.KeyCharacter = (int)'F';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.G))
                    {
                        hot_key_information.KeyCharacter = (int)'G';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.H))
                    {
                        hot_key_information.KeyCharacter = (int)'H';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.I))
                    {
                        hot_key_information.KeyCharacter = (int)'I';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.J))
                    {
                        hot_key_information.KeyCharacter = (int)'J';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.K))
                    {
                        hot_key_information.KeyCharacter = (int)'K';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.L))
                    {
                        hot_key_information.KeyCharacter = (int)'L';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.M))
                    {
                        hot_key_information.KeyCharacter = (int)'M';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.N))
                    {
                        hot_key_information.KeyCharacter = (int)'N';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.O))
                    {
                        hot_key_information.KeyCharacter = (int)'O';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.P))
                    {
                        hot_key_information.KeyCharacter = (int)'P';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Q))
                    {
                        hot_key_information.KeyCharacter = (int)'Q';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.R))
                    {
                        hot_key_information.KeyCharacter = (int)'R';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.S))
                    {
                        hot_key_information.KeyCharacter = (int)'S';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.T))
                    {
                        hot_key_information.KeyCharacter = (int)'T';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.U))
                    {
                        hot_key_information.KeyCharacter = (int)'U';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.V))
                    {
                        hot_key_information.KeyCharacter = (int)'V';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.W))
                    {
                        hot_key_information.KeyCharacter = (int)'W';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.X))
                    {
                        hot_key_information.KeyCharacter = (int)'X';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Y))
                    {
                        hot_key_information.KeyCharacter = (int)'Y';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Z))
                    {
                        hot_key_information.KeyCharacter = (int)'Z';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D0))
                    {
                        hot_key_information.KeyCharacter = (int)'0';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D1))
                    {
                        hot_key_information.KeyCharacter = (int)'1';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D2))
                    {
                        hot_key_information.KeyCharacter = (int)'2';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D3))
                    {
                        hot_key_information.KeyCharacter = (int)'3';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D4))
                    {
                        hot_key_information.KeyCharacter = (int)'4';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D5))
                    {
                        hot_key_information.KeyCharacter = (int)'5';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D6))
                    {
                        hot_key_information.KeyCharacter = (int)'6';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D7))
                    {
                        hot_key_information.KeyCharacter = (int)'7';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D8))
                    {
                        hot_key_information.KeyCharacter = (int)'8';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.D9))
                    {
                        hot_key_information.KeyCharacter = (int)'9';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Space))
                    {
                        hot_key_information.KeyCharacter = (int)' ';
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Left))
                    {
                        hot_key_information.KeyCharacter = 37;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Up))
                    {
                        hot_key_information.KeyCharacter = 38;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Right))
                    {
                        hot_key_information.KeyCharacter = 39;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Down))
                    {
                        hot_key_information.KeyCharacter = 40;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F1))
                    {
                        hot_key_information.KeyCharacter = 112;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F2))
                    {
                        hot_key_information.KeyCharacter = 113;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F3))
                    {
                        hot_key_information.KeyCharacter = 114;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F4))
                    {
                        hot_key_information.KeyCharacter = 115;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F5))
                    {
                        hot_key_information.KeyCharacter = 116;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F6))
                    {
                        hot_key_information.KeyCharacter = 117;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F7))
                    {
                        hot_key_information.KeyCharacter = 118;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F8))
                    {
                        hot_key_information.KeyCharacter = 119;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F9))
                    {
                        hot_key_information.KeyCharacter = 120;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F10))
                    {
                        hot_key_information.KeyCharacter = 121;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F11))
                    {
                        hot_key_information.KeyCharacter = 122;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F12))
                    {
                        hot_key_information.KeyCharacter = 123;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F13))
                    {
                        hot_key_information.KeyCharacter = 124;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F14))
                    {
                        hot_key_information.KeyCharacter = 125;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F15))
                    {
                        hot_key_information.KeyCharacter = 126;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F16))
                    {
                        hot_key_information.KeyCharacter = 127;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F17))
                    {
                        hot_key_information.KeyCharacter = 128;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F18))
                    {
                        hot_key_information.KeyCharacter = 129;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F19))
                    {
                        hot_key_information.KeyCharacter = 130;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F20))
                    {
                        hot_key_information.KeyCharacter = 131;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F21))
                    {
                        hot_key_information.KeyCharacter = 132;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F22))
                    {
                        hot_key_information.KeyCharacter = 133;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F23))
                    {
                        hot_key_information.KeyCharacter = 134;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.F24))
                    {
                        hot_key_information.KeyCharacter = 135;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Tab))
                    {
                        hot_key_information.KeyCharacter = 9;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Enter))
                    {
                        hot_key_information.KeyCharacter = 13;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.CapsLock))
                    {
                        hot_key_information.KeyCharacter = 20;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Escape))
                    {
                        hot_key_information.KeyCharacter = 27;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.PageUp))
                    {
                        hot_key_information.KeyCharacter = 33;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.PageDown))
                    {
                        hot_key_information.KeyCharacter = 34;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.End))
                    {
                        hot_key_information.KeyCharacter = 35;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Home))
                    {
                        hot_key_information.KeyCharacter = 36;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Delete))
                    {
                        hot_key_information.KeyCharacter = 46;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemBackslash))
                    {
                        hot_key_information.KeyCharacter = 226;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemCloseBrackets))
                    {
                        hot_key_information.KeyCharacter = 221;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemComma))
                    {
                        hot_key_information.KeyCharacter = 188;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemMinus))
                    {
                        hot_key_information.KeyCharacter = 189;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemOpenBrackets))
                    {
                        hot_key_information.KeyCharacter = 219;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemPeriod))
                    {
                        hot_key_information.KeyCharacter = 190;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemPlus))
                    {
                        hot_key_information.KeyCharacter = 187;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemQuestion))
                    {
                        hot_key_information.KeyCharacter = 191;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemQuotes))
                    {
                        hot_key_information.KeyCharacter = 222;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemSemicolon))
                    {
                        hot_key_information.KeyCharacter = 186;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemTilde))
                    {
                        hot_key_information.KeyCharacter = 192;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.OemPipe))
                    {
                        hot_key_information.KeyCharacter = 220;
                    }
                    else if (e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Back))
                    {
                        hot_key_information.KeyCharacter = 8;
                    }
                }

                return (hot_key_information);
            }

            /// <summary>
            /// ホットキー情報からホットキーの文字列を取得
            /// </summary>
            /// <param name="hot_key_information">ホットキー情報</param>
            /// <returns>ホットキー文字列 (null=失敗)</returns>
            public static string GetHotKeyString(
                HotKeyInformation hot_key_information
                )
            {
                string hot_key_string = "";
                string plus = "";

                if (hot_key_information.Ctrl)
                {
                    hot_key_string += plus + "Ctrl";
                    plus = " + ";
                }
                if (hot_key_information.Shift)
                {
                    hot_key_string += plus + "Shift";
                    plus = " + ";
                }
                if (hot_key_information.Alt)
                {
                    hot_key_string += plus + "Alt";
                    plus = " + ";
                }
                if (hot_key_information.Windows)
                {
                    hot_key_string += plus + "Windows";
                    plus = " + ";
                }

                switch (hot_key_information.KeyCharacter)
                {
                    case (int)'A':
                        hot_key_string += plus + "A";
                        break;
                    case (int)'B':
                        hot_key_string += plus + "B";
                        break;
                    case (int)'C':
                        hot_key_string += plus + "C";
                        break;
                    case (int)'D':
                        hot_key_string += plus + "D";
                        break;
                    case (int)'E':
                        hot_key_string += plus + "E";
                        break;
                    case (int)'F':
                        hot_key_string += plus + "F";
                        break;
                    case (int)'G':
                        hot_key_string += plus + "G";
                        break;
                    case (int)'H':
                        hot_key_string += plus + "H";
                        break;
                    case (int)'I':
                        hot_key_string += plus + "I";
                        break;
                    case (int)'J':
                        hot_key_string += plus + "J";
                        break;
                    case (int)'K':
                        hot_key_string += plus + "K";
                        break;
                    case (int)'L':
                        hot_key_string += plus + "L";
                        break;
                    case (int)'M':
                        hot_key_string += plus + "M";
                        break;
                    case (int)'N':
                        hot_key_string += plus + "N";
                        break;
                    case (int)'O':
                        hot_key_string += plus + "O";
                        break;
                    case (int)'P':
                        hot_key_string += plus + "P";
                        break;
                    case (int)'Q':
                        hot_key_string += plus + "Q";
                        break;
                    case (int)'R':
                        hot_key_string += plus + "R";
                        break;
                    case (int)'S':
                        hot_key_string += plus + "S";
                        break;
                    case (int)'T':
                        hot_key_string += plus + "T";
                        break;
                    case (int)'U':
                        hot_key_string += plus + "U";
                        break;
                    case (int)'V':
                        hot_key_string += plus + "V";
                        break;
                    case (int)'W':
                        hot_key_string += plus + "W";
                        break;
                    case (int)'X':
                        hot_key_string += plus + "X";
                        break;
                    case (int)'Y':
                        hot_key_string += plus + "Y";
                        break;
                    case (int)'Z':
                        hot_key_string += plus + "Z";
                        break;
                    case (int)'0':
                        hot_key_string += plus + "0";
                        break;
                    case (int)'1':
                        hot_key_string += plus + "1";
                        break;
                    case (int)'2':
                        hot_key_string += plus + "2";
                        break;
                    case (int)'3':
                        hot_key_string += plus + "3";
                        break;
                    case (int)'4':
                        hot_key_string += plus + "4";
                        break;
                    case (int)'5':
                        hot_key_string += plus + "5";
                        break;
                    case (int)'6':
                        hot_key_string += plus + "6";
                        break;
                    case (int)'7':
                        hot_key_string += plus + "7";
                        break;
                    case (int)'8':
                        hot_key_string += plus + "8";
                        break;
                    case (int)'9':
                        hot_key_string += plus + "9";
                        break;
                    case (int)' ':
                        hot_key_string += plus + "Space";
                        break;
                    case 37:
                        hot_key_string += plus + "Left";
                        break;
                    case 38:
                        hot_key_string += plus + "Up";
                        break;
                    case 39:
                        hot_key_string += plus + "Right";
                        break;
                    case 40:
                        hot_key_string += plus + "Down";
                        break;
                    case 112:
                        hot_key_string += plus + "F1";
                        break;
                    case 113:
                        hot_key_string += plus + "F2";
                        break;
                    case 114:
                        hot_key_string += plus + "F3";
                        break;
                    case 115:
                        hot_key_string += plus + "F4";
                        break;
                    case 116:
                        hot_key_string += plus + "F5";
                        break;
                    case 117:
                        hot_key_string += plus + "F6";
                        break;
                    case 118:
                        hot_key_string += plus + "F7";
                        break;
                    case 119:
                        hot_key_string += plus + "F8";
                        break;
                    case 120:
                        hot_key_string += plus + "F9";
                        break;
                    case 121:
                        hot_key_string += plus + "F10";
                        break;
                    case 122:
                        hot_key_string += plus + "F11";
                        break;
                    case 123:
                        hot_key_string += plus + "F12";
                        break;
                    case 124:
                        hot_key_string += plus + "F13";
                        break;
                    case 125:
                        hot_key_string += plus + "F14";
                        break;
                    case 126:
                        hot_key_string += plus + "F15";
                        break;
                    case 127:
                        hot_key_string += plus + "F16";
                        break;
                    case 128:
                        hot_key_string += plus + "F17";
                        break;
                    case 129:
                        hot_key_string += plus + "F18";
                        break;
                    case 130:
                        hot_key_string += plus + "F19";
                        break;
                    case 131:
                        hot_key_string += plus + "F20";
                        break;
                    case 132:
                        hot_key_string += plus + "F21";
                        break;
                    case 133:
                        hot_key_string += plus + "F22";
                        break;
                    case 134:
                        hot_key_string += plus + "F23";
                        break;
                    case 135:
                        hot_key_string += plus + "F24";
                        break;
                    case 9:
                        hot_key_string += plus + "Tab";
                        break;
                    case 13:
                        hot_key_string += plus + "Enter";
                        break;
                    case 20:
                        hot_key_string += plus + "CapsLock";
                        break;
                    case 27:
                        hot_key_string += plus + "Escape";
                        break;
                    case 33:
                        hot_key_string += plus + "PageUp";
                        break;
                    case 34:
                        hot_key_string += plus + "PageDown";
                        break;
                    case 35:
                        hot_key_string += plus + "End";
                        break;
                    case 36:
                        hot_key_string += plus + "Home";
                        break;
                    case 46:
                        hot_key_string += plus + "Delete";
                        break;
                    case 226:
                        hot_key_string += plus + "\\";
                        break;
                    case 221:
                        hot_key_string += plus + "]";
                        break;
                    case 188:
                        hot_key_string += plus + ",";
                        break;
                    case 189:
                        hot_key_string += plus + "-";
                        break;
                    case 219:
                        hot_key_string += plus + "[";
                        break;
                    case 190:
                        hot_key_string += plus + ".";
                        break;
                    case 187:
                        hot_key_string += plus + ";";
                        break;
                    case 191:
                        hot_key_string += plus + "/";
                        break;
                    case 222:
                        hot_key_string += plus + "^";
                        break;
                    case 186:
                        hot_key_string += plus + ":";
                        break;
                    case 192:
                        hot_key_string += plus + "@";
                        break;
                    case 220:
                        hot_key_string += plus + "\\";
                        break;
                    case 8:
                        hot_key_string += plus + "BackSpace";
                        break;
                }

                return (hot_key_string);
            }
        }
    }
}
