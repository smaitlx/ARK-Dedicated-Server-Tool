﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ARK_Server_Manager.Views.ServerProfilePanels
{
    /// <summary>
    /// Interaction logic for Installation.xaml
    /// </summary>
    public partial class Installation : ProfilePanelBase
    {
        public Installation() : base(nameof(Installation))
        {
            InitializeComponent();
        }
    }
}
