using System;
using System.Collections;

namespace Markov
{
    /// <summary>
    //
    /// </summary>
    public class Structs
    {
        public struct RootWord
        {
            public bool Start;
            public bool End;
            public string Word;
            public int ChildCount;
            public Hashtable Childs;
        }
        public struct Child
        {
            public int Occurrence;
            public string Word;
        }
    }

    /// <summary>
    /// 
    /// </summary>
	public class MarkovChain
    {
        ArrayList startindex = new ArrayList();
        public Hashtable Words = new Hashtable(1024, .1f);
        public void Load(string Input)
        {
            startindex = new ArrayList();
            Words = new Hashtable(1024, .1f);
            Structs.RootWord w = new Structs.RootWord();
            Structs.Child c = new Structs.Child();
            string[] s = Input.Replace("\r\n", " ").Replace("\t", " ").Replace("  ", " ").Split(' ');
            string s1 = "";
            bool NextisStart = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == "")
                    continue;
                s1 = s[i].ToLower();
                w = new Structs.RootWord();
                c = new Structs.Child();
                if (Words.ContainsKey(s1))
                {//si existe, agrega un nuevo hijo palabra o actualiza la cuenta existen de palabras hijos
                    if (i < s.Length - 1)
                    {
                        w = (Structs.RootWord)Words[s1];
                        if (NextisStart)
                        {
                            w.Start = true;
                            NextisStart = false;
                            startindex.Add(s1);
                        }
                        if (w.Childs.ContainsKey(s[i + 1].ToLower())) //Existe. Simplemete actualiza la cuenta
                        {
                            c = (Structs.Child)w.Childs[s[i + 1].ToLower()];
                            c.Occurrence++;
                            w.Childs.Remove(s[i + 1].ToLower());
                        }
                        else //No existe, agrega nueva palabra
                        {
                            c.Word = s[i + 1];
                            c.Occurrence = 1;

                        }
                        w.ChildCount++;
                        w.Childs.Add(s[i + 1].ToLower(), c);

                        Words.Remove(s1);
                        Words.Add(s1, w);
                    }
                }
                else
                {//nueva palabra
                    w = new Structs.RootWord();
                    w.Childs = new Hashtable();
                    if (i == 0)
                    {
                        w.Start = true;
                        startindex.Add(s1);
                    }
                    w.Word = s[i];
                    if (i < s.Length - 1)
                    {
                        c.Word = s[i + 1];
                        c.Occurrence = 1;
                        w.Childs.Add(s[i + 1].ToLower(), c);
                        w.ChildCount = 1;
                    }
                    else
                        w.End = true;
                    if (s1.Substring(s1.Length - 1, 1) == ".")
                    {
                        w.End = true;
                        NextisStart = true;
                    }
                    else if (NextisStart)
                    {
                        w.Start = true;
                        NextisStart = false;
                        startindex.Add(s1);
                    }
                    Words.Add(s1, w);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		public string Output()
        {
            string output = "";
            Random r = new Random(Environment.TickCount + startindex.Count);
            Structs.RootWord w = (Structs.RootWord)Words[((string)startindex[r.Next(startindex.Count)]).ToLower()];
            output = w.Word + " ";
            Structs.Child c = new Structs.Child();
            ArrayList a = new ArrayList();
            int pos = 0;
            int rnd = 0; int min = 0; int max = 0;
            do
            {
                rnd = r.Next(w.ChildCount + 1);
                pos = 0;
                foreach (object x in w.Childs)
                {
                    c = (Structs.Child)w.Childs[((System.Collections.DictionaryEntry)x).Key];
                    min = pos;
                    pos += c.Occurrence;
                    max = pos;
                    if (min <= rnd & max >= rnd)
                    {
                        output += c.Word + " ";
                        w = (Structs.RootWord)Words[c.Word.ToLower()];
                        break;
                    }
                }
            } while (!w.End);
            return output;
        }
    }
}
