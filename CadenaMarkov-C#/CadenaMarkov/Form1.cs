using System;
using System.Windows.Forms;

namespace CadenaMarkov
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        Markov.MarkovChain mc = new Markov.MarkovChain();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cargar_Click(object sender, EventArgs e)
        {
            mc.Load(txt_texto.Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_list_Click(object sender, EventArgs e)
        {
            palabrasEn.Items.Clear();
            Markov.Structs.RootWord w = new Markov.Structs.RootWord();
            foreach (object x in mc.Words)
            {
                w = (Markov.Structs.RootWord)mc.Words[((System.Collections.DictionaryEntry)x).Key];
                palabrasEn.Items.Add(w.Word);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lBRoot_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string index = (string)palabrasEn.Items[palabrasEn.SelectedIndex];
            index = index.ToLower();
            Markov.Structs.RootWord w = new Markov.Structs.RootWord();
            Markov.Structs.Child c = new Markov.Structs.Child();
            w = (Markov.Structs.RootWord)mc.Words[index];
            PalabrasCon.Items.Clear();
            foreach (object x in w.Childs)
            {
                c = (Markov.Structs.Child)w.Childs[((System.Collections.DictionaryEntry)x).Key];
                PalabrasCon.Items.Add(c.Word + "-" + (((double)c.Occurrence / (double)w.ChildCount) * 100) + "%");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Oracion_Click(object sender, EventArgs e)
        {
            txt_oracion.Text = mc.Output();
        }
    }
}
