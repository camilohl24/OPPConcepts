using System;
using System.Collections.Generic;
using System.Text;

namespace OPPConcepts.Backend
{
    public class Invoice : IPay

    {
        private float _quantity;
        private decimal _value;

        public Invoice(int id, string description, Date date, float quantity, decimal value)
        {
            Id = id;
            Description = description;
            Quantity = quantity;
            Value = value;
            Date = date;
        }

        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public float Quantity
        {
            get => _quantity; 
            set => _quantity = ValidteQuantity(value); 
        }
        public decimal Value
        { 
            get => _value;
            set => _value = ValidateValue(value);
        }
        public Date Date { get; set; } = null!;
        public decimal GetValueToPay() => Value * (decimal)Quantity;
        public override string ToString()
        {
            return $"{Id}\t{Description}\n\t" +
                $"Value............: {Value,20:C2}\n\t" +
                $"Quantity.........: {Quantity,20:N2}\n\t" +
                $"Value to pay.....: {GetValueToPay(),20:C2}";
        }



        private float ValidteQuantity(float quantuty) 
        {
            if (quantuty < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantuty), $"Quantity must be greater than or equal to 0. ");
            }
            return quantuty;
        }
        private decimal ValidateValue(decimal value) 
        { 
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), $"Value must be greater than or equal to 0. ");
            }
            return value;

        }

    }
}
