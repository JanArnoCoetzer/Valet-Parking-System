using System.Runtime.InteropServices;

namespace Valet_Parking_System.Helpers
{
    public static class RegionHelper
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        [DllImport("gdi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool DeleteObject(IntPtr hObject);

        public static void ApplyRoundedRegion(Control control, int radius)
        {
            if (control == null || control.Width <= 0 || control.Height <= 0)
            {
                return;
            }

            IntPtr hrgn = IntPtr.Zero;
            Region oldRegion = control.Region;

            try
            {
                hrgn = CreateRoundRectRgn(0, 0, control.Width, control.Height, radius, radius);
                control.Region = Region.FromHrgn(hrgn);
                oldRegion?.Dispose();
            }
            finally
            {
                if (hrgn != IntPtr.Zero)
                {
                    DeleteObject(hrgn);
                }
            }
        }
    }
}