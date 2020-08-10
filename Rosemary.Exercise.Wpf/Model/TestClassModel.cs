using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosemaryThemes.Wpf.BaseClass;

namespace Rosemary.Exercise.Wpf.Model
{
    public class TestClassModel:BaseDataModel
    {
        private int _age = 5;
        public string Name { get; set; } = "Sixteen";

        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                NotifyPropertyChanged(nameof(Age),nameof(Name));
            }
        }
    }
}
