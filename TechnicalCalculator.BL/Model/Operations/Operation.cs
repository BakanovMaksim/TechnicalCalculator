﻿using System;
using TechnicalCalculator.BL.Model.Operations;

namespace TechnicalCalculator.BL.Model
{
    /// <summary>
    /// Операции.
    /// </summary>
    public class Operation
    {
        /// <summary>
        /// Бинарные операции.
        /// </summary>
        public BinaryOperations BinaryOperations { get; }

        public Operation() => BinaryOperations = new BinaryOperations();
    }
}
