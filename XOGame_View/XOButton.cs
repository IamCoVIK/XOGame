using System.Windows.Forms;

namespace XOGame_View
{
    public class XOButton : Button
    {
        private XO content;
        public XO Value
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                switch (value)
                {
                    case XO.Empty:
                        Text = string.Empty;
                        break;
                    case XO.X:
                        Text = "X";
                        break;
                    case XO.O:
                        Text = "O";
                        break;
                }
            }
        }
        public enum XO
        {
            X, O, Empty
        }

        private void ButtonClicked(bool turn)
        {
            if (Value == XO.Empty)
            {
                if (turn)
                {
                    Value = XO.X;
                }
                else
                {
                    Value = XO.O;
                }
                //PlayWidget.Turn = !turn;
            }
        }

        public XOButton(XO value)
        {
            Value = value;
            //Click += (o, e) => ButtonClicked(PlayWidget.Turn);
        }
    }
}
