﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;

namespace AutoDelete.Activites.Extensions
{

    //Dots allow for hierarchy. App Integration.Excel is where Excel activities are.
    [Category("Category.Where.Your.Activity.Appears.In.Toolbox")]
    [DisplayName("Human readable name instead of class name")]
    [Description("The text of the tooltip")]
    public class AutoDelete : CodeActivity
    {
        //Note that these attributes are localized so you need to localize this attribute for Studio languages other than English
        [Category("Input")]
        [DisplayName("Start Date : You want to delete")]
        [Description("Enter the start date")]
        [RequiredArgument]
        public InArgument<DateTime> StratDate { get; set; }

        [Category("Input")]
        [DisplayName("End Date : You want to delete")]
        [Description("Enter the End date")]
        [RequiredArgument]
        public InArgument<DateTime> EndDate { get; set; }

        [Category("Input")]
        [DisplayName("Path files")]
        [Description("PAath files you want to delete")]
        [RequiredArgument]
        public InArgument<String> Pathfiles { get; set; }

        [Category("Output")]
        public OutArgument<Boolean> FlagFinish { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            try
            {
                var startDate = StratDate.Get(context);
                var endDate = EndDate.Get(context);
                var pathfiles = Pathfiles.Get(context);
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}