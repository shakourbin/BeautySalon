using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hsh.Windows.Forms
{
    public partial class MenuStrip : System.Windows.Forms.MenuStrip
    {
        public MenuStrip()
        {
            InitializeComponent();
        }

        public MenuStrip(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
