using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoDelete;
using System.Activities.Presentation.Metadata;
using System.ComponentModel;

namespace AutoDelete.Activites.Extensions
{
    public class DesignerMetadata : IRegisterMetadata
    {
        public void Register()
        {
            AttributeTableBuilder attributeTableBuilder = new AttributeTableBuilder();
            attributeTableBuilder.AddCustomAttributes(typeof(AutoDelete), new DesignerAttribute(typeof(ActivityDesigner1)));
            MetadataStore.AddAttributeTable(attributeTableBuilder.CreateTable());
        }
    }
}
