﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//Cambio 1
using System;
using System.ComponentModel.DataAnnotations;
//Segundo cambio
namespace PartsUnlimited.Models
{
    //My firts change
    //Otro cambio en el código
    //Cambio agregado por desarrollo en VS Code
    public class CartItem
    {
        [Key]
        public int CartItemId { get; set; }

        [Required]
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}
