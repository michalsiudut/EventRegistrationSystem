﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EventRegistrationSystem.Validation
{
    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null) return false;

            if (value is DateTime date)
            {
                return date > DateTime.Now;
            }

            return false;
        }
    }
}
