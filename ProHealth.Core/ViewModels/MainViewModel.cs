﻿using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProHealth.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public void ShowLogin()
        {
            ShowViewModel<LoginViewModel>();
        }
    }
}
