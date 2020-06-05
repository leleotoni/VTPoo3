using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO3.Models
{
    public class ViewModel
    {
        public Serie Serie { get; set; }
        public Episodio Episodio { get; set; }
        public ViewModel()
        {

        }

    }
}
