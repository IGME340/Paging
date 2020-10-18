﻿using Paging.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paging.ViewModels
{
    class DetailPageViewModel
    {
        public GameData Data { get; set; }
        public DetailPageViewModel(GameData data)
        {
            Data = data; 
        }
    }
}
