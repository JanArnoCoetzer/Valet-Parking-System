using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Valet_Parking_System.Classes;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Valet_Parking_System.SubForms.AdminWidgets.DataElements
{
    public partial class DeOperatorsRow : UserControl
    {
        public Operator OperatorData;
        OperatorsTable operatorsTable;

        public bool selected = false;
        public DeOperatorsRow(Operator operatordata, OperatorsTable pt, bool BackPaneldark = false)
        {
            InitializeComponent();
            OperatorData = operatordata;
            operatorsTable = pt;

            txtOperatorID.Text = operatordata.operatorID.ToString();
            txtFullName.Text = operatordata.fullName.ToString();


            if (BackPaneldark)
            {
                panelColor = panelDark;
            }
            else
            {
                panelColor = panelLight;
            }
            SetColor(panelColor);
        }
        //-----------------------------Events-----------------------------

        private void TableElement_Clicked(object sender, EventArgs e)
        {
            operatorsTable.DeselectAllElements();
            selected = !selected;
            SetColor(selected ? Color.FromArgb(70, 130, 180) : panelColor);
           
            if (selected)
            {
                operatorsTable.SelectedOperatorUpdate(OperatorData);
            }
        }

        ///-----------------------------Rendering-----------------------------
        bool BackPaneldark = false;
        Color panelColor;
        Color panelLight = Color.FromArgb(245, 245, 245);
        Color panelDark = Color.FromArgb(235, 235, 235);

        public void Deselect()
        {
            selected = false;
            SetColor(panelColor);
        }

        private void SetColor(Color color)
        {
            BackPanel.BackColor = color;
        }

        private void TableElement_MouseHover(object sender, EventArgs e)
        {
            if (!selected) SetColor(Color.FromArgb(135, 206, 235));
        }

        private void TableElement_MouseLeave(object sender, EventArgs e)
        {
            if (!selected) SetColor(panelColor);
        }
    }
}
