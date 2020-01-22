using System.Collections.Generic;
using System.Collections;
using Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;

namespace IvanovDDBPI182
{
    public class RangeOfShapes : IEnumerable
    {
        // list of shapes
        public List<Shape> ShapesList { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeOfShapes"/> class.
        /// </summary>
        public RangeOfShapes()
        {
            ShapesList = new List<Shape>();
        }

        /// <summary>
        /// return numerator which process listing of objects.
        /// </summary>
        /// <returns>
        /// Object <see cref="T:System.Collections.IEnumerator" />, which is used to list all objects.
        /// </returns>
        public IEnumerator GetEnumerator()
        {
            return ShapesList.GetEnumerator();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeOfShapes"/> class.
        /// </summary>
        /// <param name="additionalRanges">The additional ranges.</param>
        public RangeOfShapes(ShapeRange additionalRanges)
        {
            ShapesList = new List<Shape>();
            foreach (Shape shape in additionalRanges)
            {
                ShapesList.Add(shape);
            }
        }

        /// <summary>
        /// Gets the Shape at the specified index.
        /// </summary>
        /// <value>
        /// Shape
        /// </value>
        /// <param name="index">int num in list index.</param>
        /// <returns></returns>
        public Shape this[int index]
        {
            get
            {
                return ShapesList[index];
            }
        }

        /// <summary>
        /// Removes the missing shapes from list.
        /// </summary>
        public void RemoveMissingShapes()
        {
            List<Shape> newRange = new List<Shape>();
            int num = ShapesList.Count;
            for (int i = 0; i < num; i++)
            {
                try
                {
                    newRange.Add(ShapesList[i]);
                }
                catch
                {
                    continue;
                }
            }
            ShapesList = newRange;
        }

        /// <summary>
        /// Adds the specified additional shape.
        /// </summary>
        /// <param name="additionalShape">The additional shape.</param>
        public void Add(Shape additionalShape)
        {
            ShapesList.Add(additionalShape);
        }

        /// <summary>
        /// Adds the specified additional shape range.
        /// </summary>
        /// <param name="additionalShapeRange">The additional shape range.</param>
        public void Add(ShapeRange additionalShapeRange)
        {
            foreach (Shape shape in additionalShapeRange)
            {
                ShapesList.Add(shape);
            }
        }

        /// <summary>
        /// Selects all shapes in list.
        /// </summary>
        public void SelectAll()
        {
            foreach(Shape shape in ShapesList)
            {
                try
                {
                    shape.Select(Office.MsoTriState.msoFalse);
                }
                catch
                {
                    continue;
                }
            }
        }

        /// <summary>
        /// Deletes range and its content.
        /// </summary>
        public void DeleteContent()
        {
            foreach(Shape shape in ShapesList)
            {
                shape.Delete();
            }
            ShapesList = new List<Shape>();
        }

        /// <summary>
        /// Deletes this instance.
        /// </summary>
        public void Delete()
        {
            ShapesList = new List<Shape>();
        }

        /// <summary>
        /// returns num of elements in range.
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return ShapesList.Count;
        }
    }
}
