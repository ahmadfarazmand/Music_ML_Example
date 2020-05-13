using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.Note
{
    public class Note
    {
        private string name = "";
        private double frequence = 0;
        private int octave = 0;
        private int number = 0;

        public string Name { get { return name; } }
        public int Number { get { return number; } }
        public double Frequence { get { return frequence; } }
        public int Octave { get { return octave; } }

        public Note(int n)
        {
            switch (n)
            {
                case 12:
                    name = "C";
                    frequence = 0;
                    octave = 0;
                    number = n;
                    break;
                case 13:
                    name = "C#";
                    frequence = 0;
                    octave = 0;
                    number = n;
                    break;
                case 14:
                    name = "D";
                    frequence = 0;
                    octave = 0;
                    number = n;
                    break;
                case 15:
                    name = "D#";
                    frequence = 0;
                    octave = 0;
                    number = n;
                    break;
                case 16:
                    name = "E";
                    frequence = 0;
                    octave = 0;
                    number = n;
                    break;
                case 17:
                    name = "F";
                    frequence = 0;
                    octave = 0;
                    number = n;
                    break;
                case 18:
                    name = "F#";
                    frequence = 0;
                    octave = 0;
                    number = n;
                    break;
                case 19:
                    name = "G";
                    frequence = 0;
                    octave = 0;
                    number = n;
                    break;
                case 20:
                    name = "G#";
                    frequence = 0;
                    octave = 0;
                    number = n;
                    break;
                case 21:
                    name = "A";
                    frequence = 0;
                    octave = 0;
                    number = n;
                    break;
                case 22:
                    name = "A#";
                    frequence = 0;
                    octave = 0;
                    number = n;
                    break;
                case 23:
                    name = "B";
                    frequence = 0;
                    octave = 0;
                    number = n;
                    break;

                case 24:
                    name = "C";
                    frequence = 0;
                    octave = 1;
                    number = n;
                    break;
                case 25:
                    name = "C#";
                    frequence = 0;
                    octave = 1;
                    number = n;
                    break;
                case 26:
                    name = "D";
                    frequence = 0;
                    octave = 1;
                    number = n;
                    break;
                case 27:
                    name = "D#";
                    frequence = 0;
                    octave = 1;
                    number = n;
                    break;
                case 28:
                    name = "E";
                    frequence = 0;
                    octave = 1;
                    number = n;
                    break;
                case 29:
                    name = "F";
                    frequence = 0;
                    octave = 1;
                    number = n;
                    break;
                case 30:
                    name = "F#";
                    frequence = 0;
                    octave = 1;
                    number = n;
                    break;
                case 31:
                    name = "G";
                    frequence = 0;
                    octave = 1;
                    number = n;
                    break;
                case 32:
                    name = "G#";
                    frequence = 0;
                    octave = 1;
                    number = n;
                    break;
                case 33:
                    name = "A";
                    frequence = 0;
                    octave = 1;
                    number = n;
                    break;
                case 34:
                    name = "A#";
                    frequence = 0;
                    octave = 1;
                    number = n;
                    break;
                case 35:
                    name = "B";
                    frequence = 1;
                    octave = 0;
                    number = n;
                    break;

                case 36:
                    name = "C";
                    frequence = 0;
                    octave = 2;
                    number = n;
                    break;
                case 37:
                    name = "C#";
                    frequence = 0;
                    octave = 2;
                    number = n;
                    break;
                case 38:
                    name = "D";
                    frequence = 0;
                    octave = 2;
                    number = n;
                    break;
                case 39:
                    name = "D#";
                    frequence = 0;
                    octave = 2;
                    number = n;
                    break;
                case 40:
                    name = "E";
                    frequence = 0;
                    octave = 2;
                    number = n;
                    break;
                case 41:
                    name = "F";
                    frequence = 0;
                    octave = 2;
                    number = n;
                    break;
                case 42:
                    name = "F#";
                    frequence = 0;
                    octave = 2;
                    number = n;
                    break;
                case 43:
                    name = "G";
                    frequence = 0;
                    octave = 2;
                    number = n;
                    break;
                case 44:
                    name = "G#";
                    frequence = 0;
                    octave = 2;
                    number = n;
                    break;
                case 45:
                    name = "A";
                    frequence = 0;
                    octave = 2;
                    number = n;
                    break;
                case 46:
                    name = "A#";
                    frequence = 0;
                    octave = 2;
                    number = n;
                    break;
                case 47:
                    name = "B";
                    frequence = 0;
                    octave = 2;
                    number = n;
                    break;

                case 48:
                    name = "C";
                    frequence = 0;
                    octave = 3;
                    number = n;
                    break;
                case 49:
                    name = "C#";
                    frequence = 0;
                    octave = 3;
                    number = n;
                    break;
                case 50:
                    name = "D";
                    frequence = 0;
                    octave = 3;
                    number = n;
                    break;
                case 51:
                    name = "D#";
                    frequence = 0;
                    octave = 3;
                    number = n;
                    break;
                case 52:
                    name = "E";
                    frequence = 0;
                    octave = 3;
                    number = n;
                    break;
                case 53:
                    name = "F";
                    frequence = 0;
                    octave = 3;
                    number = n;
                    break;
                case 54:
                    name = "F#";
                    frequence = 0;
                    octave = 3;
                    number = n;
                    break;
                case 55:
                    name = "G";
                    frequence = 0;
                    octave = 3;
                    number = n;
                    break;
                case 56:
                    name = "G#";
                    frequence = 0;
                    octave = 3;
                    number = n;
                    break;
                case 57:
                    name = "A";
                    frequence = 0;
                    octave = 3;
                    number = n;
                    break;
                case 58:
                    name = "A#";
                    frequence = 0;
                    octave = 3;
                    number = n;
                    break;
                case 59:
                    name = "B";
                    frequence = 0;
                    octave = 3;
                    number = n;
                    break;

                case 60:
                    name = "C";
                    frequence = 0;
                    octave = 4;
                    number = n;
                    break;
                case 61:
                    name = "C#";
                    frequence = 0;
                    octave = 4;
                    number = n;
                    break;
                case 62:
                    name = "D";
                    frequence = 0;
                    octave = 4;
                    number = n;
                    break;
                case 63:
                    name = "D#";
                    frequence = 0;
                    octave = 4;
                    number = n;
                    break;
                case 64:
                    name = "E";
                    frequence = 0;
                    octave = 4;
                    number = n;
                    break;
                case 65:
                    name = "F";
                    frequence = 0;
                    octave = 4;
                    number = n;
                    break;
                case 66:
                    name = "F#";
                    frequence = 0;
                    octave = 4;
                    number = n;
                    break;
                case 67:
                    name = "G";
                    frequence = 0;
                    octave = 4;
                    number = n;
                    break;
                case 68:
                    name = "G#";
                    frequence = 0;
                    octave = 4;
                    number = n;
                    break;
                case 69:
                    name = "A";
                    frequence = 0;
                    octave = 4;
                    number = n;
                    break;
                case 70:
                    name = "A#";
                    frequence = 0;
                    octave = 4;
                    number = n;
                    break;
                case 71:
                    name = "B";
                    frequence = 0;
                    octave = 4;
                    number = n;
                    break;

                case 72:
                    name = "C";
                    frequence = 0;
                    octave = 5;
                    number = n;
                    break;
                case 73:
                    name = "C#";
                    frequence = 0;
                    octave = 5;
                    number = n;
                    break;
                case 74:
                    name = "D";
                    frequence = 0;
                    octave = 5;
                    number = n;
                    break;
                case 75:
                    name = "D#";
                    frequence = 0;
                    octave = 5;
                    number = n;
                    break;
                case 76:
                    name = "E";
                    frequence = 0;
                    octave = 5;
                    number = n;
                    break;
                case 77:
                    name = "F";
                    frequence = 0;
                    octave = 5;
                    number = n;
                    break;
                case 78:
                    name = "F#";
                    frequence = 0;
                    octave = 5;
                    number = n;
                    break;
                case 79:
                    name = "G";
                    frequence = 0;
                    octave = 5;
                    number = n;
                    break;
                case 80:
                    name = "G#";
                    frequence = 0;
                    octave = 5;
                    number = n;
                    break;
                case 81:
                    name = "A";
                    frequence = 0;
                    octave = 5;
                    number = n;
                    break;
                case 82:
                    name = "A#";
                    frequence = 0;
                    octave = 5;
                    number = n;
                    break;
                case 83:
                    name = "B";
                    frequence = 0;
                    octave = 5;
                    number = n;
                    break;

                case 84:
                    name = "C";
                    frequence = 0;
                    octave = 6;
                    number = n;
                    break;
                case 85:
                    name = "C#";
                    frequence = 0;
                    octave = 6;
                    number = n;
                    break;
                case 86:
                    name = "D";
                    frequence = 0;
                    octave = 6;
                    number = n;
                    break;
                case 87:
                    name = "D#";
                    frequence = 0;
                    octave = 6;
                    number = n;
                    break;
                case 88:
                    name = "E";
                    frequence = 0;
                    octave = 6;
                    number = n;
                    break;
                case 89:
                    name = "F";
                    frequence = 0;
                    octave = 6;
                    number = n;
                    break;
                case 90:
                    name = "F#";
                    frequence = 0;
                    octave = 6;
                    number = n;
                    break;
                case 91:
                    name = "G";
                    frequence = 0;
                    octave = 6;
                    number = n;
                    break;
                case 92:
                    name = "G#";
                    frequence = 0;
                    octave = 6;
                    number = n;
                    break;
                case 93:
                    name = "A";
                    frequence = 0;
                    octave = 6;
                    number = n;
                    break;
                case 94:
                    name = "A#";
                    frequence = 0;
                    octave = 6;
                    number = n;
                    break;
                case 95:
                    name = "B";
                    frequence = 0;
                    octave = 6;
                    number = n;
                    break;

                case 96:
                    name = "C";
                    frequence = 0;
                    octave = 7;
                    number = n;
                    break;
                case 97:
                    name = "C#";
                    frequence = 0;
                    octave = 7;
                    number = n;
                    break;
                case 98:
                    name = "D";
                    frequence = 0;
                    octave = 7;
                    number = n;
                    break;
                case 99:
                    name = "D#";
                    frequence = 0;
                    octave = 7;
                    number = n;
                    break;
                case 100:
                    name = "E";
                    frequence = 0;
                    octave = 7;
                    number = n;
                    break;
                case 101:
                    name = "F";
                    frequence = 0;
                    octave = 7;
                    number = n;
                    break;
                case 102:
                    name = "F#";
                    frequence = 0;
                    octave = 7;
                    number = n;
                    break;
                case 103:
                    name = "G";
                    frequence = 0;
                    octave = 7;
                    number = n;
                    break;
                case 104:
                    name = "G#";
                    frequence = 0;
                    octave = 7;
                    number = n;
                    break;
                case 105:
                    name = "A";
                    frequence = 0;
                    octave = 7;
                    number = n;
                    break;
                case 106:
                    name = "A#";
                    frequence = 0;
                    octave = 7;
                    number = n;
                    break;
                case 107:
                    name = "B";
                    frequence = 0;
                    octave = 7;
                    number = n;
                    break;

                case 108:
                    name = "C";
                    frequence = 0;
                    octave = 8;
                    number = n;
                    break;
                case 109:
                    name = "C#";
                    frequence = 0;
                    octave = 8;
                    number = n;
                    break;
                case 110:
                    name = "D";
                    frequence = 0;
                    octave = 8;
                    number = n;
                    break;
                case 111:
                    name = "D#";
                    frequence = 0;
                    octave = 8;
                    number = n;
                    break;
                case 112:
                    name = "E";
                    frequence = 0;
                    octave = 8;
                    number = n;
                    break;
                case 113:
                    name = "F";
                    frequence = 0;
                    octave = 8;
                    number = n;
                    break;
                case 114:
                    name = "F#";
                    frequence = 0;
                    octave = 8;
                    number = n;
                    break;
                case 115:
                    name = "G";
                    frequence = 0;
                    octave = 8;
                    number = n;
                    break;
                case 116:
                    name = "G#";
                    frequence = 0;
                    octave = 8;
                    number = n;
                    break;
                case 117:
                    name = "A";
                    frequence = 0;
                    octave = 8;
                    number = n;
                    break;
                case 118:
                    name = "A#";
                    frequence = 0;
                    octave = 8;
                    number = n;
                    break;
                case 119:
                    name = "B";
                    frequence = 0;
                    octave = 8;
                    number = n;
                    break;

                case 120:
                    name = "C";
                    frequence = 0;
                    octave = 9;
                    number = n;
                    break;
                case 121:
                    name = "C#";
                    frequence = 0;
                    octave = 9;
                    number = n;
                    break;
                case 122:
                    name = "D";
                    frequence = 0;
                    octave = 9;
                    number = n;
                    break;
                case 123:
                    name = "D#";
                    frequence = 0;
                    octave = 9;
                    number = n;
                    break;
                case 124:
                    name = "E";
                    frequence = 0;
                    octave = 9;
                    number = n;
                    break;
                case 125:
                    name = "F";
                    frequence = 0;
                    octave = 9;
                    number = n;
                    break;
                case 126:
                    name = "F#";
                    frequence = 0;
                    octave = 9;
                    number = n;
                    break;
                case 127:
                    name = "G";
                    frequence = 0;
                    octave = 9;
                    number = n;
                    break;

                default:
                    break;
            }
        }

    }
}
