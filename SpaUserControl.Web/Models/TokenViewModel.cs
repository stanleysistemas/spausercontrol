﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaUserControl.Web.Models
{
    public class TokenViewModel
    {
        public string access_token  { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

    }
}