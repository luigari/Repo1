﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.AspNetCore.Identity;
//Mi primer cambio
namespace PartsUnlimited.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}