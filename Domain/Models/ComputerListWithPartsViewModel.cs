using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models.Enums;
using Newtonsoft.Json;
using Utilities;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Models
{
    public class ComputerListWithPartsViewModel
    {
        public ComputerWithDescriptionsDto[] Computers { get; set; }
        public ComputerPartsModel PartLists { get; set; }
    }
}