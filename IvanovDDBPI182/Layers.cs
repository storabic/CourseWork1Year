using Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;

namespace IvanovDDBPI182
{
    public class Layer : RangeOfShapes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Layer"/> class.
        /// </summary>
        public Layer() : base()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Layer"/> class.
        /// </summary>
        /// <param name="shapeRange">The shape range.</param>
        public Layer(ShapeRange shapeRange) : base(shapeRange)
        {
        }
        /// <summary>
        /// Changes the transparency.
        /// </summary>
        /// <param name="value">The value.</param>
        public void ChangeTransparency(int value)
        {
            float transparency = (float)value / 100;
            foreach (Shape shape in ShapesList)
            {
                if (shape.Type == Office.MsoShapeType.msoTextBox)
                {
                    shape.TextFrame2.TextRange.Font.Fill.Transparency = transparency;
                    if (shape.Fill.BackColor.RGB == 16777215)
                        return;
                }
                shape.Fill.Transparency = transparency;
            }
        }
        /// <summary>
        /// Checks if shape is in layer.
        /// </summary>
        /// <param name="shapeToCheck">The shape to check.</param>
        /// <returns></returns>
        public bool ShapeIsInLayer(Shape shapeToCheck)
        {
            foreach (Shape shape in ShapesList)
            {
                if (shape == shapeToCheck)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Changes the layer Z-coordinate overlay.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="direction">The direction.</param>
        public void ChangeLayerOverlay(int direction)
        {
            foreach (Shape shape in ShapesList)
            {
                switch (direction)
                {
                    case -2:
                        shape.ZOrder(Office.MsoZOrderCmd.msoBringToFront);
                        break;
                    case 2:
                        shape.ZOrder(Office.MsoZOrderCmd.msoSendToBack);
                        break;
                }
            }
        }
        /// <summary>
        /// Hides or shows the layer depending on hide var.
        /// </summary>
        /// <param name="hide">if set to true - hides, if false - shows.</param>
        public void HideLayer(bool hide)
        {
            if (hide)
            {
                foreach (Shape shape in ShapesList)
                {
                    shape.Visible = Office.MsoTriState.msoFalse;
                }
            }
            else
            {
                foreach (Shape shape in ShapesList)
                {
                    shape.Visible = Office.MsoTriState.msoTrue;
                }
            }
        }
        /// <summary>
        /// Shows the layer by selecting all shapes in layer.
        /// </summary>
        public void ShowLayer()
        {
            foreach (Shape shape in ShapesList)
            {
                shape.Select(Office.MsoTriState.msoFalse);
            }
        }
    }
}