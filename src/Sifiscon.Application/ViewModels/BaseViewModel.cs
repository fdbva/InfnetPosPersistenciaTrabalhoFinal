﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifiscon.Application.ViewModels
{
    public class BaseViewModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}
