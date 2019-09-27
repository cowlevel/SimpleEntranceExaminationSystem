using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility
{
    public static class BindingControl
    {
        public static void BindEnumToCombobox<T>(this ComboBox comboBox, T defaultSelection)
        {
            var list = Enum.GetValues(typeof(T))
                .Cast<T>()
                .Select(value => new
                {
                    Description = (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute)?.Description ?? value.ToString(),
                    Value = value
                })
                .OrderBy(item => item.Value.ToString())
                .ToList();

            comboBox.DataSource = list;
            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "Value";

            //foreach (var opts in list)
            //{
            //    if (opts.Value.ToString() == defaultSelection.ToString())
            //    {
            //        comboBox.SelectedItem = opts;
            //    }
            //}
        }

        public static void FillByEnumOrderByNumber<TEnum>(this System.Windows.Forms.ComboBox ctrl, TEnum enum1, bool showValueInDisplay = true) where TEnum : struct
        {
            if (!typeof(TEnum).IsEnum) throw new ArgumentException("An Enumeration type is required.", "enumObj");

            var values = from TEnum enumValue in Enum.GetValues(typeof(TEnum))
                         select
                            new
                             KeyValuePair<TEnum, string>((enumValue), enumValue.ToString());

            ctrl.DataSource = values
                .OrderBy(x => x.Key)

                .ToList();

            ctrl.DisplayMember = "Value";
            ctrl.ValueMember = "Key";

            ctrl.SelectedValue = enum1;
        }

        public static IEnumerable<KeyValuePair<T, string>> Of<T>()
        {
            return Enum.GetValues(typeof(T))
                .Cast<T>()
                .Select(p => new KeyValuePair<T, string>(
                    p,
                    (p.GetType().GetField(p.ToString())
                    .GetCustomAttributes(typeof(DescriptionAttribute), false)
                    .FirstOrDefault() as DescriptionAttribute)?.Description ?? p.ToString()
                    ))
                    .ToList();
        }
    }
}
