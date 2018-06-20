using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NClass.GUI
{
    public static class Commands
    {
        public static readonly RoutedUICommand ViewToolbar = new RoutedUICommand("Toolbar", "ViewToolbar", typeof(Commands));
        public static readonly RoutedUICommand ViewStatusbar = new RoutedUICommand("Statusbar", "ViewStatusbar", typeof(Commands));
        public static readonly RoutedUICommand ViewExplorer = new RoutedUICommand("Model Explorer", "ViewModelExplorer", typeof(Commands));
        public static readonly RoutedUICommand ViewNavigator = new RoutedUICommand("Diagram Explorer", "ViewDiagramExplorer", typeof(Commands));

        public static readonly RoutedUICommand Options = new RoutedUICommand("Options", "Options", typeof(Commands));
        public static readonly RoutedUICommand Exit = new RoutedUICommand("Exit", "Exit", typeof(Commands));
        public static readonly RoutedUICommand About = new RoutedUICommand("About", "Exit", typeof(Commands));


    }
}
