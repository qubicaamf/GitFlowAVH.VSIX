﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using GitFlowAVH.ViewModels;

namespace GitFlowAVH.UI
{
    /// <summary>
    /// Interaction logic for BugfixesUI.xaml
    /// </summary>
    public partial class BugfixesUI : UserControl
    {
        public BugfixesUI(BugfixesViewModel model)
        {
            InitializeComponent();
            DataContext = model;
        }

        private void BugfixesGrid_OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var model = (BugfixesViewModel)DataContext;
            model.CheckoutBugfixBranch();
        }
    }
}