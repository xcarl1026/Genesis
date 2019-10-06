using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genesis
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ADTree tree = new ADTree();
            panel1.Controls.Add(tree);
        
        }
    }
}
