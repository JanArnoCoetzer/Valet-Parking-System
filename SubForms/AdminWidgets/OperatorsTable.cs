using System.Diagnostics;
using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.SubForms.AdminWidgets.DataElements;
using Valet_Parking_System.SubForms.AdminWidgets.FloatingWidgets;
using Valet_Parking_System.SubForms.BookingWidgets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Valet_Parking_System.SubForms.AdminWidgets
{
    public partial class OperatorsTable : UserControl
    {
        EditOperatorWindow editOperatorWindow;
        AddOperatorWindow addOperatorWindow;
        AdminSubForm parent;
        Operator Selectedoperator;
        
        public OperatorsTable()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 20, 20));
        }
        

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        internal void SetParent(AdminSubForm adminSubForm)
        {
            parent = adminSubForm;
        }
        internal void DeselectAllElements()
        {
            foreach (Control c in OperatorsTableContentPanel.Controls)
            {
                if (c is DeOperatorsRow row)
                    row.Deselect();
            }
        }
        internal void SelectedOperatorUpdate(Operator operatorData)
        {
            Selectedoperator = operatorData;
        }


        internal async Task LoadOperatorsAsync(List<Operator> loadedOperators)
        {
            try
            {
                OperatorsTableContentPanel.Controls.Clear();

                if (loadedOperators == null || loadedOperators.Count == 0)
                    return;

                const int chunkSize = 20;
                int totalChunks = (loadedOperators.Count + chunkSize - 1) / chunkSize;

                for (int chunk = 0; chunk < totalChunks; chunk++)
                {
                    int start = chunk * chunkSize;
                    int end = Math.Min(start + chunkSize, loadedOperators.Count);

                    for (int i = start; i < end; i++)
                    {
                        var parkingSpace = loadedOperators[i];
                        bool isDarkRow = i % 2 == 0;
                        var row = new DeOperatorsRow(parkingSpace, this, isDarkRow);
                        OperatorsTableContentPanel.Controls.Add(row);
                    }

                    if (chunk < totalChunks - 1)
                        await Task.Delay(5);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"DisplayOperators failed: {ex.Message}");
                MessageBox.Show($"Error loading Operators: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEditOperator_Click(object sender, EventArgs e)
        {
            if (Selectedoperator != null)
            {
                editOperatorWindow?.Close();
                editOperatorWindow?.Dispose();
                editOperatorWindow = new EditOperatorWindow(this, Selectedoperator);
                editOperatorWindow.StartPosition = FormStartPosition.CenterScreen;
                editOperatorWindow.ShowDialog();
            }
        }

        public void CancelEditOperator()
        {
            editOperatorWindow?.Close();
            editOperatorWindow?.Dispose();
            editOperatorWindow = null;
        }

        private void BtnAddOperator_Click(object sender, EventArgs e)
        {
            addOperatorWindow?.Close();
            addOperatorWindow?.Dispose();
            addOperatorWindow = new AddOperatorWindow(this);
            addOperatorWindow.StartPosition = FormStartPosition.CenterScreen;
            addOperatorWindow.ShowDialog();
        }

        public void CancelAddOperator()
        {
            addOperatorWindow?.Close();
            addOperatorWindow?.Dispose();
            addOperatorWindow = null;
        }

        internal void AddOperator(Operator operatordata)
        {
            CancelAddOperator();
            parent.OnOperatorAdd(operatordata);
        }

        internal void EditOperator(Operator operatordata)
        {
            CancelEditOperator();
            parent.EditOperator(operatordata);
        }

        internal void RemoveOperator(Operator operatordata)
        {
            CancelEditOperator();
            parent.RemoveOperator(operatordata);
        }

        
    }
}

