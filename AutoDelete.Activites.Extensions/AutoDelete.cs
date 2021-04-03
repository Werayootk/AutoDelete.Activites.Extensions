using System;
using System.Collections.Generic;
using System.Linq;
using System.Activities;
using System.ComponentModel;
using System.IO;

namespace AutoDelete.Activites.Extensions
{

    //Dots allow for hierarchy. App Integration.Excel is where Excel activities are.
    [Category("System.File")]
    [DisplayName("AutoDelete")]
    [Description("Use for delete all files in path.")]
    public class AutoDelete : CodeActivity
    {
        //Note that these attributes are localized so you need to localize this attribute for Studio languages other than English
        [Category("Input")]
        [DisplayName("Start Date : You want to delete")]
        [Description("Enter the start date")]
        [RequiredArgument]
        public InArgument<DateTime> StartDate { get; set; }

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
                var startDate = StartDate.Get(context);
                var endDate = EndDate.Get(context);
                var pathfiles = Pathfiles.Get(context);

                FileAttributes attr = File.GetAttributes(pathfiles);
                if (attr.HasFlag(FileAttributes.Directory))
                {
                    List<string> FileName = new List<string>();
                    FileName = Directory.GetFiles(pathfiles).ToList();
                    foreach (var item in FileName)
                    {
                        DateTime _dateFileCreate = new DateTime();
                        var _path = Path.Combine(pathfiles, item);
                        _dateFileCreate = File.GetCreationTime(_path);
                        if (startDate <= _dateFileCreate && endDate >= _dateFileCreate)
                        {
                            File.Delete(_path);                           
                        }
                    }
                }
                else
                {
                    throw new Exception("This is a file, Please give a Path");
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}