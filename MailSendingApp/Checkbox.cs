using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

namespace MailSendingApp
{
    public class DataGridViewCheckBoxHeaderCell : DataGridViewColumnHeaderCell
    {
        private Point checkBoxLocation;
        private Size checkBoxSize;
        private bool valueChanged;
        private bool isChecked;

        public DataGridViewCheckBoxHeaderCell()
        {
            this.valueChanged = false;
            this.isChecked = false;
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates dataGridViewElementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            if (this.OwningColumn is DataGridViewCheckBoxColumn checkBoxColumn)
            {
                if (checkBoxLocation == Point.Empty || checkBoxSize == Size.Empty)
                {
                    int preferredWidth = checkBoxColumn.GetPreferredWidth(DataGridViewAutoSizeColumnMode.ColumnHeader, false);
                    this.checkBoxSize = new Size(15, 15); 
                    this.checkBoxLocation = new Point(cellBounds.X + (cellBounds.Width - checkBoxSize.Width) / 2, cellBounds.Y + (cellBounds.Height - checkBoxSize.Height) / 2);
                }

                CheckBoxState state = isChecked ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal;

                CheckBoxRenderer.DrawCheckBox(graphics, checkBoxLocation, state);
            }
        }

        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            if (this.OwningColumn is DataGridViewCheckBoxColumn checkBoxColumn)
            {
                // Calculate the checkbox area
                Rectangle checkBoxBounds = new Rectangle(checkBoxLocation, checkBoxSize);

                // Handle the "Select All" checkbox click
                if (checkBoxBounds.Contains(e.Location))
                {
                    valueChanged = true;
                    isChecked = !isChecked;

                    // Update the value of all checkboxes in the column
                    foreach (DataGridViewRow row in this.DataGridView.Rows)
                    {
                        row.Cells[checkBoxColumn.Index].Value = isChecked;
                    }
                }
            }
            base.OnMouseClick(e);
        }


        protected override void OnMouseDoubleClick(DataGridViewCellMouseEventArgs e)
        {
            if (this.OwningColumn is DataGridViewCheckBoxColumn checkBoxColumn)
            {
                OnMouseClick(e);
            }
            base.OnMouseDoubleClick(e);
        }
    }

}
