using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;

using Demo_MVVMBasic.Models;
using Demo_MVVMBasic.Data;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using Demo_MVVMBasic.Views;

namespace Demo_MVVMBasic
{
    class AddWindowViewModel
    {
        public ICommand ButtonSaveCommand { get; set; }
        public ICommand ButtonCancelCommand { get; set; }

        public Widget UserWidget { get; set; }

        private WidgetOperation _widgetOperation;

        public AddWindowViewModel(WidgetOperation widgetOperation)
        {
            UserWidget = widgetOperation.Widget;
            _widgetOperation = widgetOperation;

            ButtonSaveCommand = new RelayCommand(new Action<object>(AddWidget));
            ButtonCancelCommand = new RelayCommand(new Action<object>(CancelAddWidget));
        }

        public void AddWidget(object parameter)
        {
            // validate user inputs
            _widgetOperation.Status = WidgetOperation.OperationStatus.OKAY;

            if (parameter is System.Windows.Window)
            {
                (parameter as System.Windows.Window).Close();
            }
        }

        public void CancelAddWidget(object parameter)
        {
            _widgetOperation.Status = WidgetOperation.OperationStatus.CANCEL;

            if (parameter is System.Windows.Window)
            {
                (parameter as System.Windows.Window).Close();
            }
        }
    }
}
