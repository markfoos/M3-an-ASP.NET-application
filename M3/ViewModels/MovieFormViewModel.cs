﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using M3.Models;

namespace M3.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres  { get; set; }
        public Movie Movie { get; set; }
    }
}