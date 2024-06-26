﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//Cambio 2
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//Otro cambio
//Tercer cambio
namespace PartsUnlimited.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}
