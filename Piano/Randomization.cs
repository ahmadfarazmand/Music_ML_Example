using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piano
{
    public class Randomization
    {
        private int[] Notes;
        private int length = 0;
        private Random r = new Random();
        private List<int> Result = new List<int>();

        public Randomization(PlayTypeSign sign, int[] notes)
        {
            Notes = notes;
            length = Notes.Length;

            switch (sign)
            {
                case PlayTypeSign.OrderNotes:
                    Result = OrderNotes();
                    break;
                case PlayTypeSign.Melody:
                    Result = Melody();
                    break;
                case PlayTypeSign.Melody2:
                    Result = Melody2();
                    break;
                case PlayTypeSign.Shuffle1:
                    Result = Shuffle1();
                    break;
                case PlayTypeSign.Shuffle2:
                    Result = Shuffle2();
                    break;
                case PlayTypeSign.Shuffle3:
                    Result = Shuffle3();
                    break;
                case PlayTypeSign.OrderAsc:
                    Result = OrderAsc();
                    break;
                case PlayTypeSign.OrderDes:
                    Result = OrderDes();
                    break;
                case PlayTypeSign.OrderAscBy2Step:
                    Result = OrderAscBy2Step();
                    break;
                case PlayTypeSign.OrderDesBy2Step:
                    Result = OrderDesBy2Step();
                    break;
                case PlayTypeSign.OrderAscBy3Step:
                    Result = OrderAscBy3Step();
                    break;
                case PlayTypeSign.OrderDesBy3Step:
                    Result = OrderDesBy3Step();
                    break;
                case PlayTypeSign.OrderingStep3:
                    Result = OrderingStep3();
                    break;
                case PlayTypeSign.OrderingStep3Backward:
                    Result = OrderingStep3Backward();
                    break;
                case PlayTypeSign.GetByBase:
                    Result = GetByBase();
                    break;
                default:
                    break;
            }
        }

        public List<int> GetList()
        {
            return Result;
        }

        public List<int> GetByBase()
        {
            List<int> result = new List<int>();

            for (int i = 0; i < length && result.Count < length; i++)
            {
                var randomPlace = r.Next(0, length);
                result.Add(Notes[i]);
                if (randomPlace % 2 == 0)
                    result.Add(0);
                result.Add(Notes[randomPlace]);
            }

            return result;
        }

        public List<int> OrderAsc()
        {
            List<int> result = new List<int>();
            Notes = Notes.OrderBy(a => Guid.NewGuid()).ToArray();
            for (int i = 0; i < length && result.Count < length; i++)
            {
                result.Add(Notes[i + 1 < length ? i + 1 : i]);
                result.Add(Notes[i + 2 < length ? i + 2 : i]);
            }

            return result;
        }

        public List<int> OrderDes()
        {
            List<int> result = new List<int>();
            Notes = Notes.OrderBy(a => Guid.NewGuid()).ToArray();
            for (int i = length; i >= 0 && result.Count < length; i--)
            {
                result.Add(Notes[i - 1 > 0 ? i - 1 : i + 1]);
                result.Add(Notes[i - 2 > 0 ? i - 2 : i]);
            }

            return result;
        }

        public List<int> OrderingStep3()
        {
            List<int> result = new List<int>();
            Notes = Notes.OrderBy(a => a).ToArray();
            int last = 0;

            for (int i = 0; i < length && result.Count < length; i++)
            {
                last = last + (i + 3);
                result.Add(Notes[last < length ? last : i]);
            }

            return result;
        }

        public List<int> OrderingStep3Backward()
        {
            List<int> result = new List<int>();
            Notes = Notes.OrderByDescending(a => a).ToArray();
            int last = 0;

            for (int i = 0; i < length && result.Count < length; i++)
            {
                last = last + (i - 3);
                result.Add(Notes[last >= 0 && last < length? last : i]);
            }

            return result;
        }

        public List<int> OrderAscBy2Step()
        {
            List<int> result = new List<int>();
            Notes = Notes.OrderBy(a => a).ToArray();
            for (int i = 0; i < length && result.Count < length; i++)
            {
                result.Add(Notes[i + 1 < length ? i + 1 : i]);
                result.Add(Notes[i + 3 < length ? i + 3 : i]);
            }

            return result;
        }

        public List<int> OrderDesBy2Step()
        {
            List<int> result = new List<int>();
            Notes = Notes.OrderByDescending(a => a).ToArray();
            for (int i = length; i >= 0 && result.Count < length; i--)
            {
                result.Add(Notes[i - 1 > 0 ? i - 1 : i + 1]);
                result.Add(Notes[i - 3 > 0 ? i - 3 : i]);
            }

            return result;
        }

        public List<int> OrderAscBy3Step()
        {
            List<int> result = new List<int>();
            Notes = Notes.OrderBy(a => a).ToArray();
            for (int i = 0; i < length && result.Count < length; i++)
            {
                result.Add(Notes[i - 1 > 0 && i - 1 < length ? i - 1 : i]);
                result.Add(Notes[i + 4 < length ? i + 4 : 0]);
                result.Add(Notes[i + 2 < length ? i + 2 : i]);
            }

            return result;
        }

        public List<int> OrderDesBy3Step()
        {
            List<int> result = new List<int>();
            Notes = Notes.OrderByDescending(a => a).ToArray();
            for (int i = length; i >= 0 && result.Count < length; i--)
            {
                result.Add(Notes[i - 1 > 0 ? i - 1 : i + 1]);
                result.Add(Notes[i - 4 > 0 ? i - 4 : 0]);
                result.Add(Notes[i - 2 > 0 ? i - 2 : i]);
            }

            return result;
        }

        private List<int> OrderNotes()
        {
            List<int> result = new List<int>();
            Notes = Notes.OrderBy(a => Guid.NewGuid()).ToArray();
            int n = r.Next(1, 3);
            int mod = r.Next(3, 6);
            if (n == 1)
                for (int i = 1; i < length; i += 2)
                {
                    result.Add(Notes[i]);
                    result.Add(Notes[i - 1]);
                    if (i % mod == 1)
                        result.Add(0);
                }

            if (n == 2)
                for (int i = 0; i < length; i++)
                {
                    if (i < length - 1)
                    {
                        result.Add(Notes[i + 1]);
                        result.Add(Notes[i]);
                        if (i % mod == 1)
                            result.Add(0);
                    }
                }

            if (n == 3)
                for (int i = length - 1; i >= 0; i--)
                {
                    if (i > 1)
                    {
                        result.Add(Notes[i + 1]);
                        result.Add(Notes[i]);
                        if (i % mod == 1)
                            result.Add(0);
                    }
                }

            return result;
        }

        private List<int> Melody()
        {
            List<int> result = new List<int>();
            int n = r.Next(1, 4);
            int mod = r.Next(2, 6);
            for (int i = length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j += 2)
                {
                    int r1 = r.Next(1, 2);
                    int r2 = r.Next(2, 3);
                    int r3 = r.Next(3, 4);
                    int r4 = r.Next(4, 5);
                    if (i + r2 < length && i + r2 > 0)
                        result.Add(Notes[i + r2]);
                    result.Add(Notes[i]);
                    if (i - r1 < length && i - r1 > 0)
                        result.Add(Notes[i - r1]);
                    if (i + r3 < length && i + r3 > 0)
                        result.Add(Notes[i + r3]);
                    if (i - 1 < length && i > 0)
                        result.Add(Notes[i - 1]);
                    if (i % mod == 0)
                        result.Add(0);
                }
            }
            return result;
        }

        private List<int> Melody2()
        {
            List<int> result = new List<int>();
            Notes = Notes.OrderBy(a => Guid.NewGuid()).ToArray();
            int n = r.Next(1, 5);
            int mod = r.Next(2, 6);
            if (n == 1)
                for (int i = 0; i < length; i += 2)
                {
                    if (i - 2 > 0)
                        result.Add(Notes[i - 2]);
                    if (i + 1 < length)
                        result.Add(Notes[i + 1]);
                    result.Add(Notes[i]);
                    if (i + 2 < length)
                        result.Add(Notes[i + 2]);
                    if (i % mod == 1)
                        result.Add(0);
                }

            if (n == 2)
                for (int i = 0; i < length; i += 3)
                {
                    if (i - 2 > 0)
                        result.Add(Notes[i - 2]);
                    if (i + 1 < length)
                        result.Add(Notes[i + 1]);
                    if (i + 3 < length)
                        result.Add(Notes[i + 3]);
                    result.Add(Notes[i]);
                    if (i + 2 < length)
                        result.Add(Notes[i + 2]);
                    if (i % mod == 1)
                        result.Add(0);
                }
            if (n == 3)
                for (int i = 0; i < length; i++)
                {
                    if (i + 3 < length)
                        result.Add(Notes[i + 3]);
                    result.Add(Notes[i]);
                    if (i + 2 < length)
                        result.Add(Notes[i + 2]);
                    if (i + 4 < length)
                        result.Add(Notes[i + 4]);
                    if (i + 1 < length)
                        result.Add(Notes[i + 1]);
                    if (i % mod == 1)
                        result.Add(0);
                }
            if (n == 4)
                for (int i = length - 1; i >= 0; i--)
                {
                    if (i - 3 > 0)
                        result.Add(Notes[i - 3]);
                    result.Add(Notes[i]);
                    if (i - 2 > 0)
                        result.Add(Notes[i - 2]);
                    if (i - 4 > 0)
                        result.Add(Notes[i - 4]);
                    if (i - 1 > 0)
                        result.Add(Notes[i - 1]);
                    if (i + 2 < length)
                        result.Add(Notes[i + 2]);
                    if (i % mod == 1)
                        result.Add(0);
                }
            return result;
        }

        private List<int> Shuffle1()
        {
            List<int> result = new List<int>();
            Notes = Notes.OrderBy(a => Guid.NewGuid()).ToArray();
            int n = r.Next(1, 4);
            int mod = r.Next(2, 6);
            for (int i = 0; i < length; i++)
            {
                if (mod % 2 == 1)
                    for (int j = 0; j < i; j += 2)
                    {
                        int r1 = r.Next(1, 3);
                        int r2 = r.Next(1, 4);
                        int r3 = r.Next(3, 5);
                        int r4 = r.Next(4, 6);
                        if (i + r2 < length)
                            result.Add(Notes[i + r2]);
                        result.Add(Notes[i]);
                        if (i + r1 < length)
                            result.Add(Notes[i + r1]);
                        if (i + r3 < length)
                            result.Add(Notes[i + r3]);
                        if (i + 1 < length)
                            result.Add(Notes[i + 1]);
                        if (i % mod == 0)
                            result.Add(0);
                    }
                else
                    for (int j = 0; j < i; j++)
                    {
                        int r1 = r.Next(2, 3);
                        int r2 = r.Next(2, 4);
                        int r3 = r.Next(4, 5);
                        int r4 = r.Next(3, 6);
                        if (i + r2 < length)
                            result.Add(Notes[i + r2]);
                        result.Add(Notes[i]);
                        if (i + r1 < length)
                            result.Add(Notes[i + r1]);
                        if (i + r3 < length)
                            result.Add(Notes[i + r3]);
                        if (i + 1 < length)
                            result.Add(Notes[i + 1]);
                        if (i % mod == 1)
                            result.Add(0);
                    }
            }
            return result;
        }

        private List<int> Shuffle2()
        {
            List<int> result = new List<int>();
            Notes = Notes.OrderBy(a => Guid.NewGuid()).ToArray();
            int n = r.Next(1, 4);
            int mod = r.Next(2, 6);
            for (int i = length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j += 2)
                {
                    int r1 = r.Next(2, 3);
                    int r2 = r.Next(1, 3);
                    int r3 = r.Next(3, 6);
                    int r4 = r.Next(2, 5);
                    if (i - r2 < length && i - r2 > 0)
                        result.Add(Notes[i - r2]);
                    result.Add(Notes[i]);
                    if (i - r1 < length && i - r1 > 0)
                        result.Add(Notes[i - r1]);
                    if (i - r3 < length && i - r3 > 0)
                        result.Add(Notes[i - r3]);
                    if (i - 1 < length && i > 0)
                        result.Add(Notes[i - 1]);
                    if (i % mod == 0)
                        result.Add(0);
                }
            }
            return result;
        }

        private List<int> Shuffle3()
        {
            List<int> result = new List<int>();
            int n = r.Next(1, 4);
            int mod = r.Next(2, 6);
            for (int i = 0; i < length; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    int r1 = r.Next(1, 4);
                    int r2 = r.Next(1, 3);
                    int r3 = r.Next(3, 6);
                    int r4 = r.Next(3, 5);
                    if (i + r2 < length)
                        result.Add(Notes[i + r2]);
                    result.Add(Notes[i]);
                    if (i + r1 < length)
                        result.Add(Notes[i + r1]);
                    if (i + r3 < length)
                        result.Add(Notes[i + r3]);
                    if (i + 1 < length)
                        result.Add(Notes[i + 1]);
                    if (i % mod == 1)
                        result.Add(0);
                }
            }
            return result;
        }
    }

    public enum PlayTypeSign
    {
        OrderNotes = 0,
        Melody = 1,
        Shuffle1 = 2,
        Shuffle2 = 3,
        Shuffle3 = 4,
        OrderAsc = 5,
        OrderDes = 6,
        OrderAscBy2Step = 7,
        OrderDesBy2Step = 8,
        OrderAscBy3Step = 9,
        OrderDesBy3Step = 10,
        OrderingStep3 = 11,
        OrderingStep3Backward = 12,
        GetByBase = 13,
        Melody2 = 14
    }
}
