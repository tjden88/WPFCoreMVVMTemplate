﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WPFCoreMVVMTemplate.ViewModels.Base
{
    internal abstract class WindowViewModel : ViewModel
    {
        #region Title : string - Заголовок окна

        /// <summary>Заголовок окна</summary>
        private string _Title = "Заголовок окна";

        /// <summary>Заголовок окна</summary>
        public string Title { get => _Title; set => Set(ref _Title, value); }

        #endregion
    }
}
