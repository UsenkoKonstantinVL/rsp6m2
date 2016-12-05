using System;
using System.Collections.Generic;
using System.Windows.Forms;
using rsp6m2.Controls;

namespace rsp6m2.HelpClass
{
    public class Helper
    {
        public static void SetBorderToControl(Control c)
        {
            if(c is Button)
            {
                Button b = (Button)c;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 3;
                b.FlatAppearance.BorderColor = System.Drawing.Color.Red;
                b.Invalidate();
                return;
            }
            if(c is Tumbler)
            {
                Tumbler t = (Tumbler)c;
                t.Highlight();
                return;
            }
            if(c is RoundTrumbler)
            {
                RoundTrumbler t = (RoundTrumbler)c;
                t.Highlight();
                return;
            }
            if(c is tumbler3)
            {
                var t = (tumbler3)c;
                t.Highlight();
                return;
            }
            if(c is Bigbutton)
            {
                var t = (Bigbutton)c;
                t.Highlight();
                return;
            }


        }


        public static void DeleteBorderToControl(Control c)
        {
            if (c is Button)
            {
                Button b = (Button)c;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                //b.FlatAppearance.BorderColor = System.Drawing.Color.Red;
               // b.Invalidate();
                return;
            }
            if (c is Tumbler)
            {
                Tumbler t = (Tumbler)c;
                t.Highlight();
                return;
            }
            if (c is RoundTrumbler)
            {
                RoundTrumbler t = (RoundTrumbler)c;
                t.Highlight();
                return;
            }


        }


        public static void ListsOfControls(List<Control> AllControls, List<Control> SpecialControl, 
            Control.ControlCollection cCollection)
        {
            foreach (Control c in cCollection)
            {
                AllControls.Add(c);
               
                if (c is Tumbler)
                {
                    SpecialControl.Add(c);
                }
                else if (c is RoundTrumbler)
                {
                    SpecialControl.Add(c);
                }
                else if (c is Light)
                {
                    SpecialControl.Add(c);
                }
                else if (c is Voltmetr)
                {
                    SpecialControl.Add(c);
                }
                else if (c is GreenElement)
                {
                    SpecialControl.Add(c);
                }
                else if (c is YellowElement)
                {
                    SpecialControl.Add(c);
                }
                else if (c is tumbler3)
                {
                    SpecialControl.Add(c);
                }
            }
        }

        public static void ReplaceControls(List<Control> list, Control.ControlCollection cCollection )
        {
            var controls = cCollection.GetEnumerator();
            List<Control> newListControls = new List<Control>();

            for(int i = 0; i < cCollection.Count; i++)
            {
                bool a = false;
                int ij = -1;
                for (int j = 0; j < list.Count; j++)
                {
                    
                    if(list[j].Name == cCollection[i].Name)
                    {
                        a = true;
                        ij = j;
                    }
                }

                if(a)
                {
                    newListControls.Add(list[ij]);
                }
                else
                {
                    newListControls.Add(cCollection[i]);
                }
            }


            cCollection.Clear();

            foreach(Control c in newListControls)
            {
                cCollection.Add(c);
            }
        }
    }
}
