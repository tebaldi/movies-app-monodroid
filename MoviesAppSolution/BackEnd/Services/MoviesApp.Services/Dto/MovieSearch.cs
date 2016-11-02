﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApp.Services.Dto
{
    public class MovieSearch : IDataTransferObject
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
    }
}
