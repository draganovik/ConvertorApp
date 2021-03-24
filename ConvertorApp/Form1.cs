using ConvertorApp.Convertors;
using ConvertorApp.DataTypes;
using ConvertorApp.Interfaces;
using System;
using System.Windows.Forms;

namespace ConvertorApp
{
    public partial class Form1 : Form
    {
        private IConverter converter;
        public Form1()
        {
            InitializeComponent();
            SetConversionType();
        }

        public ConversionType GetSelectedConversionType()
        {
            tbxValueOutput.Text = "";
            if (rbtnTypeLength.Checked)
            {
                return ConversionType.LENGTH;
            }
            else if (rbtnTypeMass.Checked)
            {
                return ConversionType.MASS;
            }
            else if (rbtnTypeMoney.Checked)
            {
                return ConversionType.MONEY;
            }
            else if (rbtnTypeTime.Checked)
            {
                return ConversionType.TIME;
            }
            else if (rbtnTypeCustomMoney.Checked)
            {
                return ConversionType.CUSTOM_MONEY;
            }
            return ConversionType.LENGTH;
        }

        public TimeType GetSelectedTimeType()
        {
            tbxValueOutput.Text = "";
            if (rbtnTimeHours.Checked)
            {
                return TimeType.HOURS;
            }
            else if (rbtnTimeMinutes.Checked)
            {
                return TimeType.MINUTES;
            }
            else if (rbtnTimeSeconds.Checked)
            {
                return TimeType.SECONDS;
            }
            return TimeType.HOURS;
        }

        public bool IsSegmentTypeMultiple()
        {
            return rbtnSegmentMultiple.Checked;
        }

        private void SetConversionType()
        {
            grbxTime.Visible = false;
            grbxSegment.Visible = false;
            switch (GetSelectedConversionType())
            {
                case ConversionType.LENGTH:
                default:
                    lbConvertFrom.Text = "Feet (ft)";
                    lbConvertTo.Text = "Meters (m)";
                    grbxSegment.Visible = true;
                    converter = new LengthConverter();
                    break;
                case ConversionType.MASS:
                    lbConvertFrom.Text = "Pounds (lb)";
                    lbConvertTo.Text = "Kilograms (kg)";
                    grbxSegment.Visible = true;
                    converter = new MassConverter();
                    break;
                case ConversionType.MONEY:
                    lbConvertFrom.Text = "Euro (EUR)";
                    lbConvertTo.Text = "Dinar (RSD)";
                    grbxSegment.Visible = true;
                    converter = new MoneyConverter();
                    break;
                case ConversionType.TIME:
                    lbConvertFrom.Text = "Days (d)";
                    SetTimeType();
                    grbxTime.Visible = true;
                    break;
                case ConversionType.CUSTOM_MONEY:
                    lbConvertFrom.Text = "Expression (20€ to $)";
                    lbConvertTo.Text = "Conversion result";
                    converter = new MoneyConverter();
                    break;
            }
        }

        private void SetTimeType()
        {
            var toTime = GetSelectedTimeType();
            converter = new TimeConverter(toTime);
            switch (toTime)
            {
                case TimeType.HOURS:
                default:
                    lbConvertTo.Text = "Hours (hr)";
                    break;
                case TimeType.MINUTES:
                    lbConvertTo.Text = "Minutes (min)";
                    break;
                case TimeType.SECONDS:
                    lbConvertTo.Text = "Seconds (s)";
                    break;
            }
            converter = new TimeConverter(toTime);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                if (GetSelectedConversionType() == ConversionType.CUSTOM_MONEY && converter is MoneyConverter mCustomConverter)
                {
                    tbxValueOutput.Text = Math.Round(mCustomConverter.CustomConvert(tbxValueInput.Text), 3).ToString();
                    return;
                }
                if (converter is IMultipleConverter mConverter)
                {
                    tbxValueOutput.Text = Math.Round(mConverter.ConvertArray(tbxValueInput.Text), 3).ToString();
                    return;
                }
                tbxValueOutput.Text = Math.Round(converter.Convert(double.Parse(tbxValueInput.Text)), 3).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TypeCheckedChanged(object sender, EventArgs e)
        {
            SetConversionType();
        }

        private void TimeCheckedChanged(object sender, EventArgs e)
        {
            SetTimeType();
        }
    }
}
