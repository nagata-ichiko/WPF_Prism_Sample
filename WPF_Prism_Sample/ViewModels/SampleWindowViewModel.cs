using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace WPF_Prism_Sample.ViewModels
{
    public class SampleWindowViewModel : BindableBase
    {

        public DelegateCommand OpenDialogCommand { get; private set; }

        public SampleWindowViewModel()
        {
            this.OpenDialogCommand = new DelegateCommand(OpenDialog);
        }

        private void OpenDialog()
        {
            MessageBox.Show("これはサンプルです。");

        }

    }
}
