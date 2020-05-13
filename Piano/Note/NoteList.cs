using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano.Note
{
    public static class NoteList
    {
        public static List<Note> GetList(int? ftOcv = null ,int? flOcv = null )
        {
            List<Note> result = new List<Note>();

            for (int i = 12; i < 128; i++)
            {
                Note n = new Note(i);
                result.Add(n);
            }

            if(ftOcv != null)
            {
                result = result.Where(a => a.Octave >= ftOcv).ToList();
            }

            if(flOcv != null)
            {
                result = result.Where(a => a.Octave <= flOcv).ToList();
            }

            return result;
        }
    }
}
