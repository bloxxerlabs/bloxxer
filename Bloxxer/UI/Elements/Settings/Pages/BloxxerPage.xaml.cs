using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bloxxer.UI.ViewModels.Settings;

namespace Bloxxer.UI.Elements.Settings.Pages
{
    /// <summary>
    /// Interaction logic for BloxxerPage.xaml
    /// </summary>
    public partial class BloxxerPage
    {
        public BloxxerPage()
        {
            DataContext = new BloxxerViewModel();
            InitializeComponent();
        }
    }
}
