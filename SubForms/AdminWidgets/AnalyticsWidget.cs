using System.Runtime.InteropServices;
using Valet_Parking_System.Helpers;

namespace Valet_Parking_System.SubForms.AdminWidgets
{
    public partial class AnalyticsWidget : UserControl
    {
        public AnalyticsWidget()
        {
            InitializeComponent();
            RegionHelper.ApplyRoundedRegion(this, 20);
        }
    }
}

