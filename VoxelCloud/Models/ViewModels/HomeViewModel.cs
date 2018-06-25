using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VoxelCloud.Models.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            Message = string.Empty;
        }

        public string Message { get; set; }
    }
}