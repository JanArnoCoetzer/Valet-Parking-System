using System.Diagnostics;
using System.Runtime.InteropServices;
using Valet_Parking_System.Classes;
using Valet_Parking_System.SubForms.AdminWidgets.DataElements;
using Valet_Parking_System.SubForms.AdminWidgets.FloatingWidgets;

namespace Valet_Parking_System.SubForms.AdminWidgets
{
    public partial class OperatorsTable : UserControl
    {
        private EditOperatorWindow editOperatorWindow;
        private AddOperatorWindow addOperatorWindow;
        private AdminSubForm parent;
        private Operator selectedOperator;

        //-----------------------------Constructor-----------------------------

        public OperatorsTable()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Size.Width, Size.Height, 20, 20));
        }

        //-----------------------------Parent Setup-----------------------------

        internal void SetParent(AdminSubForm adminSubForm)
        {
            parent = adminSubForm;
        }

        //-----------------------------Selection-----------------------------

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
            selectedOperator = operatorData;
        }

        //-----------------------------Data Loading-----------------------------

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
                        var operatorData = loadedOperators[i];
                        bool isDarkRow = i % 2 == 0;

                        var row = new DeOperatorsRow(operatorData, this, isDarkRow);
                        OperatorsTableContentPanel.Controls.Add(row);
                    }

                    if (chunk < totalChunks - 1)
                        await Task.Delay(5);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"LoadOperatorsAsync failed: {ex.Message}");
                MessageBox.Show($"Error loading operators: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //-----------------------------Window Actions-----------------------------

        private void BtnEditOperator_Click(object sender, EventArgs e)
        {
            if (selectedOperator != null)
            {
                editOperatorWindow?.Close();
                editOperatorWindow?.Dispose();

                editOperatorWindow = new EditOperatorWindow(this, selectedOperator);
                editOperatorWindow.StartPosition = FormStartPosition.CenterScreen;
                editOperatorWindow.ShowDialog();
            }
        }

        private void BtnAddOperator_Click(object sender, EventArgs e)
        {
            addOperatorWindow?.Close();
            addOperatorWindow?.Dispose();

            addOperatorWindow = new AddOperatorWindow(this);
            addOperatorWindow.StartPosition = FormStartPosition.CenterScreen;
            addOperatorWindow.ShowDialog();
        }

        public void CancelEditOperator()
        {
            editOperatorWindow?.Close();
            editOperatorWindow?.Dispose();
            editOperatorWindow = null;
        }

        public void CancelAddOperator()
        {
            addOperatorWindow?.Close();
            addOperatorWindow?.Dispose();
            addOperatorWindow = null;
        }

        //-----------------------------CRUD Actions-----------------------------

        internal void AddOperator(Operator operatorData)
        {
            CancelAddOperator();
            parent.OnOperatorAdd(operatorData);
        }

        internal void EditOperator(Operator operatorData)
        {
            CancelEditOperator();
            parent.EditOperator(operatorData);
        }

        internal void RemoveOperator(Operator operatorData)
        {
            CancelEditOperator();
            parent.RemoveOperator(operatorData);
        }

        //-----------------------------Rendering-----------------------------

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
    }
}