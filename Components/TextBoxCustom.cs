using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components
{
    public class TextBoxCustom : TextBox
    {
        private Color _backColorIn;

        [Category("Configurações de Cores"),
        Description("Cor de Fundo ao receber foco."),
        RefreshProperties(RefreshProperties.Repaint)]
        public Color BackColorIn
        {
            get
            {
                return _backColorIn;
            }

            set
            {
                _backColorIn = value;
            }
        }

        private Color _backColorOut;

        [Category("Configurações de Cores"),
        Description("Cor de Fundo ao perder foco."),
        RefreshProperties(RefreshProperties.Repaint)]
        public Color BackColorOut
        {
            get
            {
                return _backColorOut;
            }

            set
            {
                _backColorOut = value;
            }
        }

        private Color _foreColorIn;
        [Category("Configurações de Cores"),
        Description("Cor da letra ao receber foco."),
        RefreshProperties(RefreshProperties.Repaint)]
        public Color ForeColorIn
        {
            get { return _foreColorIn; }
            set { _foreColorIn = value; }
        }

        private Color _foreColorOut;
        [Category("Configurações de Cores"),
        Description("Cor da letra ao perder foco."),
        RefreshProperties(RefreshProperties.Repaint)]
        public Color ForeColorOut
        {
            get { return _foreColorOut; }
            set { _foreColorOut = value; }
        }

        public TextBoxCustom()
        {
            _backColorIn = Color.Silver;
            _backColorOut = Color.White;

            _foreColorIn = Color.Black;
            _foreColorOut = Color.Red;
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            BackColor = _backColorIn;
            ForeColor = _foreColorIn;    
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            BackColor = _backColorOut;
            ForeColor = _foreColorOut; 
        }
    }
}
