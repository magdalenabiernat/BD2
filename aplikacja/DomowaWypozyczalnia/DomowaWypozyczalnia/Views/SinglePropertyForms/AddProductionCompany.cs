﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomowaWypozyczalnia
{
    public partial class AddProductionCompany : AddSingleProperty
    {
        public AddProductionCompany() 
            : base("Dodaj wytwórnię filmową",AddOrEditProductionCompany)
        { }

        public AddProductionCompany(ProductionCompany company)
            : base("Edytuj wytwórnię " + company.Name, AddOrEditProductionCompany, company)
        {
            SetComponents(company.Name);
        }

         static Result AddOrEditProductionCompany(TextBox textBox, object obj)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                List<ProductionCompany> companies = ProductionCompany.GetAllWithName(textBox.Text);
                if(obj == null)
                {
                    if (companies == null || companies.Count == 0)
                    {
                        ProductionCompany.InsertCompany(textBox.Text);
                        return Result.Ok;
                    }
                    else
                        return Result.DuplicatedValue;
                } 
                else
                {
                    if (companies == null || companies.Count == 0)
                    {
                        ((ProductionCompany)obj).Name = textBox.Text;
                        Database.Submit();
                        return Result.Ok;
                    }
                    else
                        return Result.UnchangedValue;
                }
            }
            else
                return Result.EmptyImput;
        }
    }
}
